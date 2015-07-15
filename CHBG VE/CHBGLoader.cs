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
    class CHBGLoader
    {
        //public List<CHBGImage> Images;
        private BinaryReader file;

        public CHBGLoader()
        {
            //Images = new List<CHBGImage>();
        }

        private Bitmap Generate_Palette_Bitmap(CHBGImage image)
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

        private Bitmap Generate_Tiles_Bitmap(CHBGImage image)
        {
            int height = (image.different_tiles / 21) * 10 + 10;
            Bitmap bitmap = new Bitmap(200, height);
            int ox = 0;
            int oy = 0;
            for (int i = 0; i < image.different_tiles; i++)
            {
                for (int x = 0; x < image.tiles[i].Width; x++)
                {
                    for (int y = 0; y < image.tiles[i].Height; y++)
                    {
                        Color color = image.tiles[i].GetPixel(x, y);
                        bitmap.SetPixel(ox + x, oy + y, color);
                    }
                }
                if (ox < 200 - 20)
                {
                    ox += 9;
                }
                else
                {
                    ox = 0;
                    oy += 9;
                }

            }
            return bitmap;
        }

        private Bitmap Generate_Bitmap(CHBGImage image)
        {
            Bitmap bitmap = new Bitmap(image.width, image.height);
            int ox = 0;
            int oy = 0;
            for (int i = 0; i < image.puzzle.Length; i++)
            {
                for (int x = 0; x < image.tiles[image.puzzle[i]].Width; x++)
                {
                    for (int y = 0; y < image.tiles[image.puzzle[i]].Height; y++)
                    {
                        Color color = image.tiles[image.puzzle[i]].GetPixel(x, y);
                        bitmap.SetPixel(ox + x, oy + y, color);
                    }
                }
                if (ox < image.width - 8)
                {
                    ox += 8;
                }
                else
                {
                    ox = 0;
                    oy += 8;
                }

            }
            return bitmap;
        }

        private Bitmap Generate_Tile(CHBGImage image, byte[] indexes)
        {
            Bitmap tile = new Bitmap(8, 8);
            for (int x = 0; x < tile.Width; x++)
            {
                for (int y = 0; y < tile.Height; y++)
                {
                    //try
                    //{
                        tile.SetPixel(x, y, image.palette[indexes[y * 8 + x]].Color);
                    //}
                    //catch
                   // {
                    //    tile.SetPixel(x, y, Color.Black);
                    //}
                }
            }
            return tile;
        }
        public CHBGImage LoadImage(string filename)
        {
            file = new BinaryReader(File.Open(filename, FileMode.Open));
            CHBGImage image = new CHBGImage();
            image.header = file.ReadUInt32();
            if (image.header != 0x47424843)
            {
                System.Windows.Forms.MessageBox.Show("invalid header");
                return null;
            }
            image.filename = Path.GetFileName(filename);
            image.width = file.ReadUInt16();
            image.height = file.ReadUInt16();
            image.tile_color_bits = file.ReadByte();
            image.palette_lines = file.ReadByte();
            image.different_tiles = file.ReadUInt16();
            image.nothing = file.ReadUInt32();
            image.palette = new _555Color[image.palette_lines * 16];
            for (int i = 0; i < (image.palette_lines * 16); i++)
            {
                UInt16 color = file.ReadUInt16();
                image.palette.SetValue(new _555Color(color), i);
            }
            image.image_tiles = (UInt32)((image.width * image.height) / 64);
            image.puzzle = new UInt16[image.image_tiles];
            for (int i = 0; i < image.image_tiles; i++)
            {
                UInt16 tile = file.ReadUInt16();
                image.puzzle.SetValue(tile, i);
            }
            //UInt16 tiles_bytes = (UInt16)(different_tiles * (8 * tile_color_bits));
            image.tiles = new Bitmap[image.different_tiles];
            for (int i = 0; i < image.different_tiles; i++)
            {
                byte[] indexes = new byte[64];//[8 * image.tile_color_bits];
                byte index = 0;
                for (int j = 0; j < 64; j++)
                {
                    index = file.ReadByte();
                    if (image.tile_color_bits == 8)
                    {
                        indexes.SetValue(index, j);
                    }
                    else
                    {
                        byte first_color = (byte)(index & 0xF);
                        byte second_color = (byte)(index >> 4);
                        indexes.SetValue(first_color, j);
                        indexes.SetValue(second_color, j + 1);
                        j++;
                    }
                }
                //System.Diagnostics.Debugger.Break();
                Bitmap tile = Generate_Tile(image, indexes);
                image.tiles.SetValue(tile, i);
            }
            image.bitmap = Generate_Bitmap(image);
            image.tiles_bitmap = Generate_Tiles_Bitmap(image);
            image.palette_bitmap = Generate_Palette_Bitmap(image);
            //Images.Add(image);
            file.Close();
            StreamWriter file2 = new StreamWriter("colors.txt");
            for (int i = 0; i < image.palette.Length; i++)
            {
                file2.WriteLine("Color: " + image.palette[i].Color.ToString());
            }
            file2.Close();
            return image;
        }
    }
}
