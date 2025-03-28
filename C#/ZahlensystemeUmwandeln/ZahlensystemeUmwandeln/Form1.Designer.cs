namespace ZahlensystemeUmwandeln
{
    partial class Formular
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBxDec = new System.Windows.Forms.TextBox();
            this.dec2bin = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.bin2dec = new System.Windows.Forms.Button();
            this.txtBxBin = new System.Windows.Forms.TextBox();
            this.lbl_Dec = new System.Windows.Forms.Label();
            this.dec2hex = new System.Windows.Forms.Button();
            this.lblHexaResult = new System.Windows.Forms.Label();
            this.pnl_DecNumbSpace = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vonDezimalzahlZuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vonBinärzahlZuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vonHexadezimalzahlZuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bin2hexaDec = new System.Windows.Forms.Button();
            this.lbl_HexaDec = new System.Windows.Forms.Label();
            this.txtBxHex = new System.Windows.Forms.TextBox();
            this.hex2dec = new System.Windows.Forms.Button();
            this.lbl_DecFromHex = new System.Windows.Forms.Label();
            this.hex2bin = new System.Windows.Forms.Button();
            this.lbl_BinFromHex = new System.Windows.Forms.Label();
            this.pnl_BinNumbSpace = new System.Windows.Forms.Panel();
            this.pnl_HexDecNumbSpace = new System.Windows.Forms.Panel();
            this.pnl_DecNumbSpace.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.pnl_BinNumbSpace.SuspendLayout();
            this.pnl_HexDecNumbSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBxDec
            // 
            this.txtBxDec.Location = new System.Drawing.Point(21, 27);
            this.txtBxDec.Name = "txtBxDec";
            this.txtBxDec.Size = new System.Drawing.Size(192, 27);
            this.txtBxDec.TabIndex = 0;
            // 
            // dec2bin
            // 
            this.dec2bin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dec2bin.Location = new System.Drawing.Point(21, 100);
            this.dec2bin.Name = "dec2bin";
            this.dec2bin.Size = new System.Drawing.Size(192, 42);
            this.dec2bin.TabIndex = 1;
            this.dec2bin.Text = "Dezimal in Binär";
            this.dec2bin.UseVisualStyleBackColor = true;
            this.dec2bin.Click += new System.EventHandler(this.Dec2Bin_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(21, 173);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(112, 28);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Binärzahl: ";
            // 
            // bin2dec
            // 
            this.bin2dec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bin2dec.Location = new System.Drawing.Point(28, 100);
            this.bin2dec.Name = "bin2dec";
            this.bin2dec.Size = new System.Drawing.Size(193, 42);
            this.bin2dec.TabIndex = 3;
            this.bin2dec.Text = "Binär in Dezimal";
            this.bin2dec.UseVisualStyleBackColor = true;
            this.bin2dec.Click += new System.EventHandler(this.Bin2Dec_Click);
            // 
            // txtBxBin
            // 
            this.txtBxBin.Location = new System.Drawing.Point(28, 27);
            this.txtBxBin.Name = "txtBxBin";
            this.txtBxBin.Size = new System.Drawing.Size(193, 27);
            this.txtBxBin.TabIndex = 4;
            // 
            // lbl_Dec
            // 
            this.lbl_Dec.AutoSize = true;
            this.lbl_Dec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dec.Location = new System.Drawing.Point(28, 173);
            this.lbl_Dec.Name = "lbl_Dec";
            this.lbl_Dec.Size = new System.Drawing.Size(139, 28);
            this.lbl_Dec.TabIndex = 5;
            this.lbl_Dec.Text = "Dezimalzahl: ";
            // 
            // dec2hex
            // 
            this.dec2hex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dec2hex.Location = new System.Drawing.Point(21, 251);
            this.dec2hex.Name = "dec2hex";
            this.dec2hex.Size = new System.Drawing.Size(280, 42);
            this.dec2hex.TabIndex = 6;
            this.dec2hex.Text = "Dezimal in Hexadezimal";
            this.dec2hex.UseVisualStyleBackColor = true;
            this.dec2hex.Click += new System.EventHandler(this.Dec2Hexadec_Click);
            // 
            // lblHexaResult
            // 
            this.lblHexaResult.AutoSize = true;
            this.lblHexaResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHexaResult.Location = new System.Drawing.Point(21, 323);
            this.lblHexaResult.Name = "lblHexaResult";
            this.lblHexaResult.Size = new System.Drawing.Size(184, 28);
            this.lblHexaResult.TabIndex = 7;
            this.lblHexaResult.Text = "Hexadezimalzahl: ";
            // 
            // pnl_DecNumbSpace
            // 
            this.pnl_DecNumbSpace.BackColor = System.Drawing.Color.LightGreen;
            this.pnl_DecNumbSpace.Controls.Add(this.txtBxDec);
            this.pnl_DecNumbSpace.Controls.Add(this.lblHexaResult);
            this.pnl_DecNumbSpace.Controls.Add(this.dec2bin);
            this.pnl_DecNumbSpace.Controls.Add(this.dec2hex);
            this.pnl_DecNumbSpace.Controls.Add(this.lblResult);
            this.pnl_DecNumbSpace.Location = new System.Drawing.Point(37, 52);
            this.pnl_DecNumbSpace.Name = "pnl_DecNumbSpace";
            this.pnl_DecNumbSpace.Size = new System.Drawing.Size(400, 400);
            this.pnl_DecNumbSpace.TabIndex = 8;
            this.pnl_DecNumbSpace.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1288, 28);
            this.menuStrip.TabIndex = 9;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vonDezimalzahlZuToolStripMenuItem,
            this.vonBinärzahlZuToolStripMenuItem,
            this.vonHexadezimalzahlZuToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.menuToolStripMenuItem.Text = "Optionen";
            // 
            // vonDezimalzahlZuToolStripMenuItem
            // 
            this.vonDezimalzahlZuToolStripMenuItem.Name = "vonDezimalzahlZuToolStripMenuItem";
            this.vonDezimalzahlZuToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.vonDezimalzahlZuToolStripMenuItem.Text = "von Dezimalzahl zu . . .";
            this.vonDezimalzahlZuToolStripMenuItem.Click += new System.EventHandler(this.Dec2WhatToolStripMenuItem_Click);
            // 
            // vonBinärzahlZuToolStripMenuItem
            // 
            this.vonBinärzahlZuToolStripMenuItem.Name = "vonBinärzahlZuToolStripMenuItem";
            this.vonBinärzahlZuToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.vonBinärzahlZuToolStripMenuItem.Text = "von Binärzahl zu . . . ";
            this.vonBinärzahlZuToolStripMenuItem.Click += new System.EventHandler(this.Binary2WhatToolStripMenuItem_Click);
            // 
            // vonHexadezimalzahlZuToolStripMenuItem
            // 
            this.vonHexadezimalzahlZuToolStripMenuItem.Name = "vonHexadezimalzahlZuToolStripMenuItem";
            this.vonHexadezimalzahlZuToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.vonHexadezimalzahlZuToolStripMenuItem.Text = "von Hexadezimalzahl zu . . . ";
            this.vonHexadezimalzahlZuToolStripMenuItem.Click += new System.EventHandler(this.Hexadec2WhatToolStripMenuItem_Click);
            // 
            // bin2hexaDec
            // 
            this.bin2hexaDec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bin2hexaDec.Location = new System.Drawing.Point(28, 251);
            this.bin2hexaDec.Name = "bin2hexaDec";
            this.bin2hexaDec.Size = new System.Drawing.Size(245, 42);
            this.bin2hexaDec.TabIndex = 10;
            this.bin2hexaDec.Text = "Binär in Hexadezimal";
            this.bin2hexaDec.UseVisualStyleBackColor = true;
            this.bin2hexaDec.Click += new System.EventHandler(this.Bin2Hexadec_Click);
            // 
            // lbl_HexaDec
            // 
            this.lbl_HexaDec.AutoSize = true;
            this.lbl_HexaDec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HexaDec.Location = new System.Drawing.Point(28, 323);
            this.lbl_HexaDec.Name = "lbl_HexaDec";
            this.lbl_HexaDec.Size = new System.Drawing.Size(184, 28);
            this.lbl_HexaDec.TabIndex = 11;
            this.lbl_HexaDec.Text = "Hexadezimalzahl: ";
            // 
            // txtBxHex
            // 
            this.txtBxHex.Location = new System.Drawing.Point(26, 27);
            this.txtBxHex.Name = "txtBxHex";
            this.txtBxHex.Size = new System.Drawing.Size(193, 27);
            this.txtBxHex.TabIndex = 12;
            // 
            // hex2dec
            // 
            this.hex2dec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hex2dec.Location = new System.Drawing.Point(26, 100);
            this.hex2dec.Name = "hex2dec";
            this.hex2dec.Size = new System.Drawing.Size(266, 42);
            this.hex2dec.TabIndex = 13;
            this.hex2dec.Text = "Hexadezimal in Dezimal";
            this.hex2dec.UseVisualStyleBackColor = true;
            this.hex2dec.Click += new System.EventHandler(this.Hexadec2Dec_Click);
            // 
            // lbl_DecFromHex
            // 
            this.lbl_DecFromHex.AutoSize = true;
            this.lbl_DecFromHex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DecFromHex.Location = new System.Drawing.Point(26, 173);
            this.lbl_DecFromHex.Name = "lbl_DecFromHex";
            this.lbl_DecFromHex.Size = new System.Drawing.Size(139, 28);
            this.lbl_DecFromHex.TabIndex = 14;
            this.lbl_DecFromHex.Text = "Dezimalzahl: ";
            // 
            // hex2bin
            // 
            this.hex2bin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hex2bin.Location = new System.Drawing.Point(26, 251);
            this.hex2bin.Name = "hex2bin";
            this.hex2bin.Size = new System.Drawing.Size(245, 42);
            this.hex2bin.TabIndex = 15;
            this.hex2bin.Text = "Hexadezimal in Binär";
            this.hex2bin.UseVisualStyleBackColor = true;
            this.hex2bin.Click += new System.EventHandler(this.Hexadec2Bin_Click);
            // 
            // lbl_BinFromHex
            // 
            this.lbl_BinFromHex.AutoSize = true;
            this.lbl_BinFromHex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_BinFromHex.Location = new System.Drawing.Point(26, 323);
            this.lbl_BinFromHex.Name = "lbl_BinFromHex";
            this.lbl_BinFromHex.Size = new System.Drawing.Size(106, 28);
            this.lbl_BinFromHex.TabIndex = 16;
            this.lbl_BinFromHex.Text = "Binärzahl:";
            // 
            // pnl_BinNumbSpace
            // 
            this.pnl_BinNumbSpace.BackColor = System.Drawing.Color.LightGreen;
            this.pnl_BinNumbSpace.Controls.Add(this.txtBxBin);
            this.pnl_BinNumbSpace.Controls.Add(this.bin2dec);
            this.pnl_BinNumbSpace.Controls.Add(this.lbl_Dec);
            this.pnl_BinNumbSpace.Controls.Add(this.bin2hexaDec);
            this.pnl_BinNumbSpace.Controls.Add(this.lbl_HexaDec);
            this.pnl_BinNumbSpace.Location = new System.Drawing.Point(443, 52);
            this.pnl_BinNumbSpace.Name = "pnl_BinNumbSpace";
            this.pnl_BinNumbSpace.Size = new System.Drawing.Size(400, 400);
            this.pnl_BinNumbSpace.TabIndex = 17;
            this.pnl_BinNumbSpace.Visible = false;
            // 
            // pnl_HexDecNumbSpace
            // 
            this.pnl_HexDecNumbSpace.BackColor = System.Drawing.Color.LightGreen;
            this.pnl_HexDecNumbSpace.Controls.Add(this.txtBxHex);
            this.pnl_HexDecNumbSpace.Controls.Add(this.hex2dec);
            this.pnl_HexDecNumbSpace.Controls.Add(this.lbl_BinFromHex);
            this.pnl_HexDecNumbSpace.Controls.Add(this.lbl_DecFromHex);
            this.pnl_HexDecNumbSpace.Controls.Add(this.hex2bin);
            this.pnl_HexDecNumbSpace.Location = new System.Drawing.Point(849, 52);
            this.pnl_HexDecNumbSpace.Name = "pnl_HexDecNumbSpace";
            this.pnl_HexDecNumbSpace.Size = new System.Drawing.Size(400, 400);
            this.pnl_HexDecNumbSpace.TabIndex = 18;
            this.pnl_HexDecNumbSpace.Visible = false;
            // 
            // Formular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 503);
            this.Controls.Add(this.pnl_HexDecNumbSpace);
            this.Controls.Add(this.pnl_BinNumbSpace);
            this.Controls.Add(this.pnl_DecNumbSpace);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Formular";
            this.Text = "Zahlenumrechner";
            this.Load += new System.EventHandler(this.Formular_Load);
            this.pnl_DecNumbSpace.ResumeLayout(false);
            this.pnl_DecNumbSpace.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnl_BinNumbSpace.ResumeLayout(false);
            this.pnl_BinNumbSpace.PerformLayout();
            this.pnl_HexDecNumbSpace.ResumeLayout(false);
            this.pnl_HexDecNumbSpace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBxDec;
        private Button dec2bin;
        private Label lblResult;
        private Button bin2dec;
        private TextBox txtBxBin;
        private Label lbl_Dec;
        private Button dec2hex;
        private Label lblHexaResult;
        private Panel pnl_DecNumbSpace;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem vonDezimalzahlZuToolStripMenuItem;
        private Button bin2hexaDec;
        private Label lbl_HexaDec;
        private TextBox txtBxHex;
        private Button hex2dec;
        private Label lbl_DecFromHex;
        private Button hex2bin;
        private Label lbl_BinFromHex;
        private ToolStripMenuItem vonBinärzahlZuToolStripMenuItem;
        private ToolStripMenuItem vonHexadezimalzahlZuToolStripMenuItem;
        private Panel pnl_BinNumbSpace;
        private Panel pnl_HexDecNumbSpace;
    }
}