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
    class Image
    {
        public string filename;
        public UInt32 header;
        public UInt16 width;
        public UInt16 height;
        public byte tile_color_bits;
        public byte palette_lines;
        public UInt32 image_tiles;

        public _555Color[] palette;
        public Bitmap palette_bitmap;
        public Bitmap bitmap;

        public Bitmap[] tiles;
        public Bitmap tiles_bitmap;
        public UInt16 different_tiles;

        public Image()
        {
        }

        ~Image()
        {
            if (palette_bitmap != null)
            { palette_bitmap.Dispose(); }
            bitmap.Dispose();
            if (tiles_bitmap != null)
            { tiles_bitmap.Dispose(); }
        }

        public void RMDSExport(Image paleta_extra)
        {
            MessageBox.Show("This will export the image with CHBG format." +
                            "\nPlease note that this feature is not optimized.", "Experimental feature");
            DialogResult result = new DialogResult();
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.RestoreDirectory = false;
            dialog.Filter = "CHBG Image (*.bin)|*.bin";
            dialog.FileName = Path.ChangeExtension(filename, null);
            dialog.AddExtension = true;
            result = dialog.ShowDialog();
            if (dialog.FileName != "" && result == DialogResult.OK)
            {
                CHBGWriter writer = new CHBGWriter(bitmap, paleta_extra);
                writer.Write(dialog.FileName);
                MessageBox.Show("Finished!");
            }
        }
        public void CommonExport()
        {
            DialogResult result = new DialogResult();
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.RestoreDirectory = false;
            dialog.Filter = "PNG Image (*.png) [Recommended]|*.png|JPEG Image (*.jpeg) [Bad Idea]|*.jpg|BMP Image (*.bmp)|*.bmp";
            dialog.FileName = Path.ChangeExtension(filename, null);
            dialog.AddExtension = true;
            result = dialog.ShowDialog();
            if (dialog.FileName != "" && result == DialogResult.OK)
            {
                System.IO.FileStream fs = (System.IO.FileStream)dialog.OpenFile();
                switch (dialog.FilterIndex)
                {
                    case 1:
                        bitmap.Save(fs,
                        System.Drawing.Imaging.ImageFormat.Png);
                        break;

                    case 2:
                        bitmap.Save(fs,
                        System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 3:
                        bitmap.Save(fs,
                        System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }
                fs.Close();
            }
        }

    }
}
