using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace RMDSCM
{
    class CHBGWriter
    {
        private int    header = 0x47424843;
        private ushort width;
        private ushort height;
        private byte   bitdepth = 0x08;
        private byte   palette_lines = 0x10;
        private int    padding = 0x000000;

        private Bitmap bitmap;
        private _555Color[] palette;
        private byte[] tiles;
        private ushort total_tiles;

        private _555Color[] paleta_extra;

        public CHBGWriter(Bitmap bitmap2, Image paleta_extra2)
        {
            paleta_extra = paleta_extra2.palette;
            bitmap = bitmap2;
            width  = (ushort)bitmap.Width;
            height = (ushort)bitmap.Height;
            palette_lines = paleta_extra2.palette_lines;

            if ((width % 8 != 0) && (height % 8 != 0))
            {
                MessageBox.Show("Width and Height must be divisible by 8");
                return;
            }
        }

        public void Write(string filename)
        {
            Generate();
            BinaryWriter writer;
            writer = new BinaryWriter(File.Open(filename, FileMode.Create, FileAccess.Write));
            writer.Write(header);
            writer.Write(width);
            writer.Write(height);
            writer.Write(bitdepth);
            writer.Write(palette_lines);
            writer.Write(total_tiles);
            writer.Write(padding);
            foreach (_555Color color in palette)
            {
                writer.Write(color.Int16);
            }
            for (int k = 0; k < total_tiles; k++)
            {
                writer.Write((ushort)k);
            }
            for (int k = 0; k < tiles.Length; k++)
            {
                writer.Write(tiles[k]);
            }
            writer.Close();
        }
        public void Generate()
        {
            // Highly experimental
            // Componer paleta
            Color[] tpalette = new Color[paleta_extra.Length];//[256];
            int i = 0;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color color = bitmap.GetPixel(x, y);
                    if (!tpalette.Contains(color))
                    {
                        tpalette.SetValue(color, i);
                        i++;
                    }
                }
            }
            // Pasar la paleta a 555Color
            palette = new _555Color[tpalette.Length];
            for (int j = 0; j < tpalette.Length; j++)
            {
                //palette.SetValue(new _555Color(tpalette[j]), j);
                palette.SetValue(paleta_extra[j], j);
            }

            // Generar los tiles numericos
            int total = width * height;
            total_tiles = (ushort)(total / 64);
            int current = 0;
            int extra_x = 0;
            int extra_y = 0;
            // array con todos los bytes de los tiles
            tiles = new byte[width * height];
            while (current < total)
            {
                for (int y = 0; y < 8; y++)
                {
                    for (int x = 0; x < 8; x++)
                    {
                        Color color = bitmap.GetPixel(x + extra_x, y + extra_y);
                        _555Color color2 = new _555Color(color);
                        for (int j = 0; j < palette.Length; j++)
                        {
                            if (palette[j].Int16 == color2.Int16)
                            {
                                // Guardar la posicion del color
                                tiles.SetValue((byte)j, current);
                                break;
                            }
                            else { tiles.SetValue((byte)0, current); }
                        }
                        current++;
                    }
                }
                extra_x += 8;
                if (extra_x >= width)
                {
                    extra_x = 0;
                    extra_y += 8;
                }
            }
        }
    }
}