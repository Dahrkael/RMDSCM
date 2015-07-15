using System;
using System.IO.Compression;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace RMDSCM
{
    public partial class Formulario : Form
    {
        private CHBGLoader      CHBGManager;
        private BMBGLoader      BMBGManager;
        private List<Image>     Images;

        public Formulario()
        {
            InitializeComponent();
            Directory.SetCurrentDirectory(Path.GetDirectoryName(Application.ExecutablePath));
            CHBGManager = new CHBGLoader();
            BMBGManager = new BMBGLoader();
            Images = new List<Image>();
            PictureBox.Image = RMDSCM.Properties.Resources.splash;
        }

        private int CheckFileHeader(string filename)
        {
            // 0 Error
            // 1 CHBG
            // 2 BMBG
            try
            {
                BinaryReader file = new BinaryReader(File.Open(filename, FileMode.Open));
                UInt32 header = file.ReadUInt32();
                file.Close();
                if (header == 0x47424843)
                { return 1; }
                if (header == 0x47424D42)
                { return 2; }
            }
            catch
            { System.Windows.Forms.MessageBox.Show("Read Error", "Error"); }
            return 0;
        }

        private void ShowSelectedImage(Image image)
        {
            if (image.header == 0x47424843)
            {
                LabelHeader.Text            = System.Text.ASCIIEncoding.ASCII.GetString(BitConverter.GetBytes(image.header));
                LabelWidth.Text             = image.width.ToString();
                LabelHeight.Text            = image.height.ToString();
                LabelColorBits.Text         = image.tile_color_bits.ToString();
                LabelPaletteColors.Text     = (image.palette_lines * 16).ToString();
                LabelImageTiles.Text        = image.image_tiles.ToString();
                LabelTilesPerRow.Text       = (image.width / 8).ToString();
                LabelTilesPerColumn.Text    = (image.height / 8).ToString();
                LabelDifferentTiles.Text    = image.different_tiles.ToString();

                PictureBox.Image        = image.bitmap;
                PictureBox.Width        = image.width;
                PictureBox.Height       = image.height;
                PictureBoxPalette.Image = image.palette_bitmap;
                PictureBoxTiles.Height  = image.tiles_bitmap.Height;
                PictureBoxTiles.Image   = image.tiles_bitmap;
            }
            else if (image.header == 0x47424D42)
            {
                LabelHeader.Text = System.Text.ASCIIEncoding.ASCII.GetString(BitConverter.GetBytes(image.header));
                LabelWidth.Text = image.width.ToString();
                LabelHeight.Text = image.height.ToString();
                LabelColorBits.Text = image.tile_color_bits.ToString();
                LabelPaletteColors.Text = (image.palette_lines * 16).ToString();
                LabelImageTiles.Text = image.image_tiles.ToString();
                LabelTilesPerRow.Text = "0000";
                LabelTilesPerColumn.Text = "0000";
                LabelDifferentTiles.Text = "0000";

                PictureBox.Image = image.bitmap;
                PictureBox.Width = image.width;
                PictureBox.Height = image.height;
                PictureBoxPalette.Image = image.palette_bitmap;
                PictureBoxTiles.Height = 1;
                PictureBoxTiles.Image = null;
            }
            else
            {
                LabelHeader.Text = "Common";
                LabelWidth.Text = image.bitmap.Width.ToString();
                LabelHeight.Text = image.bitmap.Height.ToString();
                LabelColorBits.Text = "0000";
                LabelPaletteColors.Text = "0000";
                LabelImageTiles.Text = "0000";
                LabelTilesPerRow.Text = "0000";
                LabelTilesPerColumn.Text = "0000";
                LabelDifferentTiles.Text = "0000";

                PictureBox.Image = image.bitmap;
                PictureBox.Width = image.width;
                PictureBox.Height = image.height;
                PictureBoxPalette.Image = null;
                PictureBoxTiles.Height = 1;
                PictureBoxTiles.Image = null;

            }

        }

        private void LoadRMDSButton_Click(object sender, EventArgs e)
        {
            string filename;
            string ofilename;
            //openDialog.Filter = null;
            openDialog.Filter = "RPG Maker DS Image (*.bin, *.blz)|*.bin;*.blz";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                ofilename = openDialog.FileName;
                filename = ofilename;
                Image image;
                if (Path.GetExtension(ofilename) == ".blz")
                {
                    string dfilename = Path.GetTempFileName();
                    LZSS.Decompress(ofilename, dfilename);
                    filename = dfilename;
                }

                switch (CheckFileHeader(filename))
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Unknown Format.", "Error");
                        break;
                    case 1:
                        image = CHBGManager.LoadImage(filename);
                        image.filename = ofilename;
                        if (image != null)
                        {
                            Images.Add(image);
                            image_list.BeginUpdate();
                            image_list.Items.Add("[CHBG] " + Path.GetFileName(ofilename));
                            image_list.SelectedIndex = image_list.Items.Count - 1;
                            image_list.EndUpdate();
                        }
                        break;
                    case 2:
                        image = BMBGManager.LoadImage(filename);
                        if (image != null)
                        {
                            Images.Add(image);
                            image_list.BeginUpdate();
                            image_list.Items.Add("[BMBG] " + Path.GetFileName(ofilename));
                            image_list.SelectedIndex = image_list.Items.Count - 1;
                            image_list.EndUpdate();
                        }
                        break;
                }
            }
            else
            {
                return;
            }
        }

        private void LoadCommonButton_Click(object sender, EventArgs e)
        {
            string filename;
            //openDialog.Filter = null;
            openDialog.Filter = "Common Image File (*.png)|*.png;*.gif";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                filename = openDialog.FileName;
                Image image = new Image();
                image.bitmap = new Bitmap(filename);
                image.width = (ushort)image.bitmap.Width;
                image.height = (ushort)image.bitmap.Height;
                Images.Add(image);
                image_list.BeginUpdate();
                image_list.Items.Add("[PNG] " + Path.GetFileName(filename));
                image_list.SelectedIndex = image_list.Items.Count - 1;
                image_list.EndUpdate();
            }
        }

        private void SaveRMDSButton_Click(object sender, EventArgs e)
        {
            Images.ElementAt(image_list.SelectedIndex).RMDSExport(Images.ElementAt(image_list.SelectedIndex-1));
        }

        private void SaveCommonButton_Click(object sender, EventArgs e)
        {
            Images.ElementAt(image_list.SelectedIndex).CommonExport();
        }

        private void image_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (image_list.SelectedIndex != -1)
            {
                ShowSelectedImage(Images.ElementAt(image_list.SelectedIndex));
                SaveCommonButton.Enabled    = true;
                SaveRMDSButton.Enabled      = true;
                DeleteButton.Enabled        = true;
            }
            else
            {
                LabelHeader.Text            = "0000";
                LabelWidth.Text             = "0000";
                LabelHeight.Text            = "0000";
                LabelColorBits.Text         = "0000";
                LabelPaletteColors.Text     = "0000";
                LabelImageTiles.Text        = "0000";
                LabelTilesPerRow.Text       = "0000";
                LabelTilesPerColumn.Text    = "0000";
                LabelDifferentTiles.Text    = "0000";

                PictureBox.Image        = RMDSCM.Properties.Resources.splash;
                PictureBox.Width        = 263;
                PictureBox.Height       = 229;
                PictureBoxPalette.Image = null;
                PictureBoxTiles.Height  = 1;
                PictureBoxTiles.Image   = null;
                SaveCommonButton.Enabled = false;
                SaveRMDSButton.Enabled  = false;
                DeleteButton.Enabled    = false;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = image_list.SelectedIndex;
            image_list.BeginUpdate();
            Images.RemoveAt(index);
            image_list.Items.RemoveAt(index);
            image_list.EndUpdate();
        }

        private void InvertedLZSSButton_Click(object sender, EventArgs e)
        {
            openDialog.Filter = null;
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                LZSS.Decompress(openDialog.FileName, openDialog.FileName+".lz");
                MessageBox.Show("Decompressed!");
            }
        }

        private void ExtractNDSButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Non-working Feature");
            return;
            /*
            if (File.Exists("ndstool.exe") == false)
            {
                MessageBox.Show("This feature requires ndstool.exe to be in the same folder as RMDSCM");
                return;
            }
            openDialog.Filter = "Nintendo DS Rom (*.nds)|*.nds";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string folder = Path.GetFileNameWithoutExtension(openDialog.FileName);
                string param  = string.Format("-x \"{1}\" -9 \"{0}\\arm9.bin\" -7 \"{0}\\arm7.bin\" -y9 \"{0}\\y9.bin\" -y7 \"{0}\\y7.bin\" -d \"{0}\\data\" -y \"{0}\\overlay\" -t \"{0}\\banner.bin\" -h \"{0}\\header.bin\"", folder, openDialog.FileName);
                Process.Start("ndstool.exe", param);
            }
            */
        }
    }
}
