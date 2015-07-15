using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RMDSCM
{
    class BMBGLoader
    {
        //public List<BMBGImage> Images;
        private BinaryReader file;

        public BMBGLoader()
        {
            //Images = new List<BMBGImage>();
        }

        private Bitmap Generate_Palette_Bitmap(BMBGImage image)
        {
            Bitmap bitmap = new Bitmap(168, 90);
            int ox = 0;
            int oy = 0;
            // 21
            for (int i = 0; i < image.palette.Length; i++)
            {
                for (int x = 0; x < 8; x++)
                {
                    for (int y = 0; y < 6; y++)
                    {
                        Color color = image.palette[i].Color;
                        bitmap.SetPixel(x + ox, y + oy, color);
                    }
                }
                if (ox < 168 - 8)
                {
                    ox += 8;
                }
                else
                {
                    ox = 0;
                    oy += 6;
                }
            }
            return bitmap;
        }

        private Bitmap Generate_Bitmap(BMBGImage image)
        {
            Bitmap bitmap = new Bitmap(image.width, image.height);
            for (int x = 0; x < image.width; x++)
            {
                for (int y = 0; y < image.height; y++)
                {
                    //try
                    //{
                        byte tile = image.puzzle[y * image.width + x];
                        bitmap.SetPixel(x, y, image.palette[tile].Color);
                    //}
                    //catch
                    //{
                    //    bitmap.SetPixel(x, y, Color.PaleTurquoise);
                    //}
                }
            }
            return bitmap;
        }
        public BMBGImage LoadImage(string filename)
        {
            file = new BinaryReader(File.Open(filename, FileMode.Open));
            BMBGImage image = new BMBGImage();
            image.header = file.ReadUInt32();
            if (image.header != 0x47424D42)
            {
                System.Windows.Forms.MessageBox.Show("invalid header");
                return null;
            }
            image.filename = Path.GetFileName(filename);
            image.width = file.ReadUInt16();
            image.height = file.ReadUInt16();
            image.tile_color_bits = file.ReadByte();
            image.palette_lines = file.ReadByte();
            image.nothing1 = file.ReadUInt16();
            image.nothing2 = file.ReadUInt32();
            image.palette = new _555Color[image.palette_lines * 16];
            for (int i = 0; i < (image.palette_lines * 16); i++)
            {
                UInt16 color = file.ReadUInt16();
                image.palette.SetValue(new _555Color(color), i);
            }
            image.image_tiles = (UInt32)(image.width * image.height);
            image.puzzle = new byte[image.image_tiles];
            for (int i = 0; i < image.image_tiles; i++)
            {
                if (image.tile_color_bits == 8)
                {
                    byte tile = file.ReadByte();
                    image.puzzle.SetValue(tile, i);
                }
                if (image.tile_color_bits == 4)
                {
                    byte tile = file.ReadByte();
                    byte first_color = (byte)(tile & 0xF);
                    byte second_color = (byte)(tile >> 4);
                    image.puzzle.SetValue(first_color, i);
                    image.puzzle.SetValue(second_color, i + 1);
                    i++;
                }
            }
            image.bitmap = Generate_Bitmap(image);
            image.palette_bitmap = Generate_Palette_Bitmap(image);
            //Images.Add(image);
            file.Close();
            return image;
        }
    }
}
