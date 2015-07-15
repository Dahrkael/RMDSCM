namespace RMDSCM
{
    partial class Formulario
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.LoadRMDSButton = new System.Windows.Forms.Button();
            this.SaveCommonButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelWidth = new System.Windows.Forms.Label();
            this.LabelHeight = new System.Windows.Forms.Label();
            this.LabelDifferentTiles = new System.Windows.Forms.Label();
            this.LabelColorBits = new System.Windows.Forms.Label();
            this.LabelImageTiles = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LabelHeader = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LabelTilesPerColumn = new System.Windows.Forms.Label();
            this.LabelTilesPerRow = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LabelPaletteColors = new System.Windows.Forms.Label();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.image_list = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PictureBoxTiles = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PictureBoxPalette = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.LoadCommonButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.SaveRMDSButton = new System.Windows.Forms.Button();
            this.InvertedLZSSButton = new System.Windows.Forms.Button();
            this.ExtractNDSButton = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTiles)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPalette)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoadRMDSButton
            // 
            this.LoadRMDSButton.Location = new System.Drawing.Point(7, 19);
            this.LoadRMDSButton.Name = "LoadRMDSButton";
            this.LoadRMDSButton.Size = new System.Drawing.Size(140, 23);
            this.LoadRMDSButton.TabIndex = 0;
            this.LoadRMDSButton.Text = "RMDS Graphics File";
            this.LoadRMDSButton.UseVisualStyleBackColor = true;
            this.LoadRMDSButton.Click += new System.EventHandler(this.LoadRMDSButton_Click);
            // 
            // SaveCommonButton
            // 
            this.SaveCommonButton.Enabled = false;
            this.SaveCommonButton.Location = new System.Drawing.Point(6, 48);
            this.SaveCommonButton.Name = "SaveCommonButton";
            this.SaveCommonButton.Size = new System.Drawing.Size(140, 23);
            this.SaveCommonButton.TabIndex = 2;
            this.SaveCommonButton.Text = "Common Graphics File";
            this.SaveCommonButton.UseVisualStyleBackColor = true;
            this.SaveCommonButton.Click += new System.EventHandler(this.SaveCommonButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Different Tiles:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tile Color Bits:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Image Tiles:";
            // 
            // LabelWidth
            // 
            this.LabelWidth.AutoSize = true;
            this.LabelWidth.Location = new System.Drawing.Point(384, 40);
            this.LabelWidth.Name = "LabelWidth";
            this.LabelWidth.Size = new System.Drawing.Size(31, 13);
            this.LabelWidth.TabIndex = 8;
            this.LabelWidth.Text = "0000";
            // 
            // LabelHeight
            // 
            this.LabelHeight.AutoSize = true;
            this.LabelHeight.Location = new System.Drawing.Point(384, 62);
            this.LabelHeight.Name = "LabelHeight";
            this.LabelHeight.Size = new System.Drawing.Size(31, 13);
            this.LabelHeight.TabIndex = 9;
            this.LabelHeight.Text = "0000";
            // 
            // LabelDifferentTiles
            // 
            this.LabelDifferentTiles.AutoSize = true;
            this.LabelDifferentTiles.Location = new System.Drawing.Point(384, 129);
            this.LabelDifferentTiles.Name = "LabelDifferentTiles";
            this.LabelDifferentTiles.Size = new System.Drawing.Size(31, 13);
            this.LabelDifferentTiles.TabIndex = 10;
            this.LabelDifferentTiles.Text = "0000";
            // 
            // LabelColorBits
            // 
            this.LabelColorBits.AutoSize = true;
            this.LabelColorBits.Location = new System.Drawing.Point(384, 84);
            this.LabelColorBits.Name = "LabelColorBits";
            this.LabelColorBits.Size = new System.Drawing.Size(31, 13);
            this.LabelColorBits.TabIndex = 11;
            this.LabelColorBits.Text = "0000";
            // 
            // LabelImageTiles
            // 
            this.LabelImageTiles.AutoSize = true;
            this.LabelImageTiles.Location = new System.Drawing.Point(384, 197);
            this.LabelImageTiles.Name = "LabelImageTiles";
            this.LabelImageTiles.Size = new System.Drawing.Size(31, 13);
            this.LabelImageTiles.TabIndex = 12;
            this.LabelImageTiles.Text = "0000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(292, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Header:";
            // 
            // LabelHeader
            // 
            this.LabelHeader.AutoSize = true;
            this.LabelHeader.Location = new System.Drawing.Point(384, 18);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(31, 13);
            this.LabelHeader.TabIndex = 14;
            this.LabelHeader.Text = "0000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(292, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Row Tiles:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(292, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Column Tiles:";
            // 
            // LabelTilesPerColumn
            // 
            this.LabelTilesPerColumn.AutoSize = true;
            this.LabelTilesPerColumn.Location = new System.Drawing.Point(384, 175);
            this.LabelTilesPerColumn.Name = "LabelTilesPerColumn";
            this.LabelTilesPerColumn.Size = new System.Drawing.Size(31, 13);
            this.LabelTilesPerColumn.TabIndex = 17;
            this.LabelTilesPerColumn.Text = "0000";
            // 
            // LabelTilesPerRow
            // 
            this.LabelTilesPerRow.AutoSize = true;
            this.LabelTilesPerRow.Location = new System.Drawing.Point(384, 151);
            this.LabelTilesPerRow.Name = "LabelTilesPerRow";
            this.LabelTilesPerRow.Size = new System.Drawing.Size(31, 13);
            this.LabelTilesPerRow.TabIndex = 18;
            this.LabelTilesPerRow.Text = "0000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(292, 106);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Palette Colors:";
            // 
            // LabelPaletteColors
            // 
            this.LabelPaletteColors.AutoSize = true;
            this.LabelPaletteColors.Location = new System.Drawing.Point(384, 106);
            this.LabelPaletteColors.Name = "LabelPaletteColors";
            this.LabelPaletteColors.Size = new System.Drawing.Size(31, 13);
            this.LabelPaletteColors.TabIndex = 20;
            this.LabelPaletteColors.Text = "0000";
            // 
            // image_list
            // 
            this.image_list.FormattingEnabled = true;
            this.image_list.Location = new System.Drawing.Point(6, 19);
            this.image_list.Name = "image_list";
            this.image_list.Size = new System.Drawing.Size(156, 342);
            this.image_list.TabIndex = 21;
            this.image_list.SelectedIndexChanged += new System.EventHandler(this.image_list_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.image_list);
            this.groupBox1.Location = new System.Drawing.Point(164, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 375);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loaded Images";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Enabled = false;
            this.DeleteButton.Location = new System.Drawing.Point(12, 184);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(140, 23);
            this.DeleteButton.TabIndex = 22;
            this.DeleteButton.Text = "Delete Selected Image";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LabelPaletteColors);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.LabelTilesPerRow);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.LabelTilesPerColumn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LabelHeader);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.LabelImageTiles);
            this.groupBox2.Controls.Add(this.LabelWidth);
            this.groupBox2.Controls.Add(this.LabelColorBits);
            this.groupBox2.Controls.Add(this.LabelHeight);
            this.groupBox2.Controls.Add(this.LabelDifferentTiles);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(339, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 375);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Image";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Location = new System.Drawing.Point(192, 259);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 110);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tiles";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.PictureBoxTiles);
            this.panel1.Location = new System.Drawing.Point(6, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 90);
            this.panel1.TabIndex = 27;
            // 
            // PictureBoxTiles
            // 
            this.PictureBoxTiles.Location = new System.Drawing.Point(17, 5);
            this.PictureBoxTiles.Name = "PictureBoxTiles";
            this.PictureBoxTiles.Size = new System.Drawing.Size(200, 82);
            this.PictureBoxTiles.TabIndex = 23;
            this.PictureBoxTiles.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PictureBoxPalette);
            this.groupBox3.Location = new System.Drawing.Point(6, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 110);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Palette";
            // 
            // PictureBoxPalette
            // 
            this.PictureBoxPalette.Location = new System.Drawing.Point(6, 14);
            this.PictureBoxPalette.Name = "PictureBoxPalette";
            this.PictureBoxPalette.Size = new System.Drawing.Size(168, 91);
            this.PictureBoxPalette.TabIndex = 23;
            this.PictureBoxPalette.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.PictureBox);
            this.panel2.Location = new System.Drawing.Point(6, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 235);
            this.panel2.TabIndex = 27;
            // 
            // PictureBox
            // 
            this.PictureBox.InitialImage = null;
            this.PictureBox.Location = new System.Drawing.Point(6, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(263, 229);
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            // 
            // LoadCommonButton
            // 
            this.LoadCommonButton.Location = new System.Drawing.Point(7, 48);
            this.LoadCommonButton.Name = "LoadCommonButton";
            this.LoadCommonButton.Size = new System.Drawing.Size(140, 23);
            this.LoadCommonButton.TabIndex = 26;
            this.LoadCommonButton.Text = "Common Graphics File";
            this.LoadCommonButton.UseVisualStyleBackColor = true;
            this.LoadCommonButton.Click += new System.EventHandler(this.LoadCommonButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.LoadCommonButton);
            this.groupBox5.Controls.Add(this.LoadRMDSButton);
            this.groupBox5.Location = new System.Drawing.Point(6, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(153, 80);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Load";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.SaveRMDSButton);
            this.groupBox6.Controls.Add(this.SaveCommonButton);
            this.groupBox6.Location = new System.Drawing.Point(6, 98);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(153, 80);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Save";
            // 
            // SaveRMDSButton
            // 
            this.SaveRMDSButton.Enabled = false;
            this.SaveRMDSButton.Location = new System.Drawing.Point(7, 19);
            this.SaveRMDSButton.Name = "SaveRMDSButton";
            this.SaveRMDSButton.Size = new System.Drawing.Size(140, 23);
            this.SaveRMDSButton.TabIndex = 3;
            this.SaveRMDSButton.Text = "RMDS Graphics File";
            this.SaveRMDSButton.UseVisualStyleBackColor = true;
            this.SaveRMDSButton.Click += new System.EventHandler(this.SaveRMDSButton_Click);
            // 
            // InvertedLZSSButton
            // 
            this.InvertedLZSSButton.Location = new System.Drawing.Point(6, 19);
            this.InvertedLZSSButton.Name = "InvertedLZSSButton";
            this.InvertedLZSSButton.Size = new System.Drawing.Size(140, 23);
            this.InvertedLZSSButton.TabIndex = 29;
            this.InvertedLZSSButton.Text = "Inverted LZSS";
            this.InvertedLZSSButton.UseVisualStyleBackColor = true;
            this.InvertedLZSSButton.Click += new System.EventHandler(this.InvertedLZSSButton_Click);
            // 
            // ExtractNDSButton
            // 
            this.ExtractNDSButton.Location = new System.Drawing.Point(7, 48);
            this.ExtractNDSButton.Name = "ExtractNDSButton";
            this.ExtractNDSButton.Size = new System.Drawing.Size(140, 23);
            this.ExtractNDSButton.TabIndex = 30;
            this.ExtractNDSButton.Text = "Extract NDS File";
            this.ExtractNDSButton.UseVisualStyleBackColor = true;
            this.ExtractNDSButton.Click += new System.EventHandler(this.ExtractNDSButton_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.InvertedLZSSButton);
            this.groupBox7.Controls.Add(this.ExtractNDSButton);
            this.groupBox7.Location = new System.Drawing.Point(6, 308);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(153, 79);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Extra Functions";
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 399);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Formulario";
            this.Text = "RPG Maker DS Content Manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTiles)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPalette)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadRMDSButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button SaveCommonButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelWidth;
        private System.Windows.Forms.Label LabelHeight;
        private System.Windows.Forms.Label LabelDifferentTiles;
        private System.Windows.Forms.Label LabelColorBits;
        private System.Windows.Forms.Label LabelImageTiles;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabelHeader;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LabelTilesPerColumn;
        private System.Windows.Forms.Label LabelTilesPerRow;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label LabelPaletteColors;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private System.Windows.Forms.ListBox image_list;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PictureBoxPalette;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox PictureBoxTiles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button LoadCommonButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button SaveRMDSButton;
        private System.Windows.Forms.Button InvertedLZSSButton;
        private System.Windows.Forms.Button ExtractNDSButton;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}

