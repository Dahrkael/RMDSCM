using System;
using System.IO;

namespace RMDSCM
{
    public class LZSS
    {
        public LZSS()
        {
        }

        // Overlay (inverted) compression
        public static void Decompress(string openFilename, string saveFilename)
        {
            BinaryReader infile;
            infile = new BinaryReader(File.Open(openFilename, FileMode.Open, FileAccess.Read));
            byte[] buffer = new byte[infile.BaseStream.Length];
            infile.Read(buffer, 0, buffer.Length);
            infile.Close();

            // 4 bytes con la diferencia en bytes entre el archivo descomprimido y el comprimido
            int difference = BitConverter.ToInt32(buffer, buffer.Length - 4) & 0xFFFFFF;
            // 1 byte con el tamaño de la cabecera, entre 0x08 y 0xB
            byte header_size = buffer[buffer.Length - 5];
            // 3 bytes con el tamaño de la parte comprimida
            int compressed_size = BitConverter.ToInt32(buffer, buffer.Length - 8);
            // unos bytes 0xFF de relleno (de 0 a 3)
            
            // tamaño de la imagen final
            int final_size = buffer.Length + difference;
            byte[] buffer2 = new byte[final_size];
            // inicio del bloque comprimido
            int index = (buffer.Length - header_size) - 1;
            // posicion inicial para ir rellenando el buffer 2
            int index2 = buffer2.Length - 1;
            // inicio (fin) del bloque comprimido
            int compression_end = (buffer.Length - compressed_size) & 0xFFFFFF;
            int position = 0;
            int length = 0;
            // Mientras la posicion no alcance el final del bloque (a la inversa, como todo)
            while (index >= compression_end)
            {
                byte flags = buffer[index];
                index--;
                for (int i = 7; i > -1; i--)
                {
                    // Esto no pasara, creo
                    if (index < 0) { break; }

                    // Se saca un bit cada vez
                    byte flag = (byte)((flags >> i) & 0x01);
                    if (flag == 0)
                    {
                        // Byte no codificado
                        buffer2[index2] = buffer[index];
                        index--; index2--;
                    }
                    else
                    {
                        // Dos bytes
                        // 12 bits para posicion, 4 para longitud
                        // 0000 111100001111
                        length = (buffer[index] >> 4) + 3; // 0, 1 y 2 no existen
                        position = (((buffer[index] & 0xF) << 8) | buffer[index - 1]) + 3;
                        index -= 2;
                        for (int j = 0; j < length; j++)
                        {
                            buffer2[index2] = buffer2[index2 + position];
                            index2--;
                        }
                    }
                }
            }
            // Copiar la parte no comprimida
            Array.Copy(buffer, 0, buffer2, 0, index2 + 1);
            BinaryWriter outfile;
            outfile = new BinaryWriter(File.Open(saveFilename, FileMode.Create, FileAccess.Write));
            outfile.Write(buffer2, 0, final_size);
            outfile.Close();
        }
    }
}