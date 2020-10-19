namespace Barcode006
{
    partial class FmCGTIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmCGTIN));
            this.udPixPerXQR = new System.Windows.Forms.NumericUpDown();
            this.laPixPerX = new System.Windows.Forms.Label();
            this.px128 = new System.Windows.Forms.PictureBox();
            this.cx128In = new System.Windows.Forms.ComboBox();
            this.pxQR = new System.Windows.Forms.PictureBox();
            this.cxQrIn = new System.Windows.Forms.ComboBox();
            this.bnDecode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.laResShiftArrow = new System.Windows.Forms.Label();
            this.laRFIDOut = new System.Windows.Forms.Label();
            this.laLotNum2 = new System.Windows.Forms.Label();
            this.laDValue2 = new System.Windows.Forms.Label();
            this.laDType2 = new System.Windows.Forms.Label();
            this.laGTIN2 = new System.Windows.Forms.Label();
            this.laLotShift = new System.Windows.Forms.Label();
            this.laDateValueShift = new System.Windows.Forms.Label();
            this.laDateTypeShift = new System.Windows.Forms.Label();
            this.laGTINShift = new System.Windows.Forms.Label();
            this.laHeaderShift = new System.Windows.Forms.Label();
            this.laLotHex = new System.Windows.Forms.Label();
            this.laDateValueHex = new System.Windows.Forms.Label();
            this.laDateTypeHex = new System.Windows.Forms.Label();
            this.laGTINHex = new System.Windows.Forms.Label();
            this.laHeaderHex = new System.Windows.Forms.Label();
            this.laHex = new System.Windows.Forms.Label();
            this.laHeader2 = new System.Windows.Forms.Label();
            this.cxHeader = new System.Windows.Forms.ComboBox();
            this.laHeader = new System.Windows.Forms.Label();
            this.laaError = new System.Windows.Forms.Label();
            this.laRFID = new System.Windows.Forms.Label();
            this.txWarn = new System.Windows.Forms.TextBox();
            this.laLot = new System.Windows.Forms.Label();
            this.laDate = new System.Windows.Forms.Label();
            this.laDateType = new System.Windows.Forms.Label();
            this.laGTIN = new System.Windows.Forms.Label();
            this.cxLotNum = new System.Windows.Forms.ComboBox();
            this.cxDate = new System.Windows.Forms.ComboBox();
            this.cxDateType = new System.Windows.Forms.ComboBox();
            this.cxGTIN = new System.Windows.Forms.ComboBox();
            this.txError = new System.Windows.Forms.TextBox();
            this.txAvery = new System.Windows.Forms.TextBox();
            this.pxAveryLogo = new System.Windows.Forms.PictureBox();
            this.laPixPerXQR = new System.Windows.Forms.Label();
            this.laPixPerX128 = new System.Windows.Forms.Label();
            this.udPixPerX128 = new System.Windows.Forms.NumericUpDown();
            this.cxEPC = new System.Windows.Forms.ComboBox();
            this.la128HR = new System.Windows.Forms.Label();
            this.la128HR2 = new System.Windows.Forms.Label();
            this.laQR2 = new System.Windows.Forms.Label();
            this.laWarn = new System.Windows.Forms.Label();
            this.cxSerNum = new System.Windows.Forms.ComboBox();
            this.laSerNum = new System.Windows.Forms.Label();
            this.bnRefresh = new System.Windows.Forms.Button();
            this.laQRHead = new System.Windows.Forms.Label();
            this.cxQRHead = new System.Windows.Forms.ComboBox();
            this.laSample = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udPixPerXQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.px128)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxAveryLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPixPerX128)).BeginInit();
            this.SuspendLayout();
            // 
            // udPixPerXQR
            // 
            this.udPixPerXQR.Location = new System.Drawing.Point(610, 170);
            this.udPixPerXQR.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udPixPerXQR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPixPerXQR.Name = "udPixPerXQR";
            this.udPixPerXQR.Size = new System.Drawing.Size(44, 20);
            this.udPixPerXQR.TabIndex = 12;
            this.udPixPerXQR.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.udPixPerXQR.Click += new System.EventHandler(this.udPixPerXQR_Click);
            // 
            // laPixPerX
            // 
            this.laPixPerX.AutoSize = true;
            this.laPixPerX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPixPerX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laPixPerX.Location = new System.Drawing.Point(545, 156);
            this.laPixPerX.Name = "laPixPerX";
            this.laPixPerX.Size = new System.Drawing.Size(99, 13);
            this.laPixPerX.TabIndex = 10;
            this.laPixPerX.Text = "Pixels / Element";
            // 
            // px128
            // 
            this.px128.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.px128.Location = new System.Drawing.Point(24, 330);
            this.px128.Name = "px128";
            this.px128.Size = new System.Drawing.Size(794, 86);
            this.px128.TabIndex = 9;
            this.px128.TabStop = false;
            // 
            // cx128In
            // 
            this.cx128In.FormattingEnabled = true;
            this.cx128In.Items.AddRange(new object[] {
            "01012345678901281720071910A1B23C45D67",
            "01000280280030181720092310A123-56"});
            this.cx128In.Location = new System.Drawing.Point(158, 288);
            this.cx128In.Name = "cx128In";
            this.cx128In.Size = new System.Drawing.Size(533, 21);
            this.cx128In.TabIndex = 8;
            this.cx128In.Text = "010123456789012321987654";
            // 
            // pxQR
            // 
            this.pxQR.Location = new System.Drawing.Point(671, 109);
            this.pxQR.Name = "pxQR";
            this.pxQR.Size = new System.Drawing.Size(120, 120);
            this.pxQR.TabIndex = 16;
            this.pxQR.TabStop = false;
            // 
            // cxQrIn
            // 
            this.cxQrIn.FormattingEnabled = true;
            this.cxQrIn.Items.AddRange(new object[] {
            "HELLO WORLD.",
            "Hello, world.",
            "01.01234567890128.17.200719.10.A1B23C45D67",
            "https://id.gs1.org/gtin/01234567890128/exp/200719/lot/A1B23C45D67"});
            this.cxQrIn.Location = new System.Drawing.Point(158, 261);
            this.cxQrIn.Name = "cxQrIn";
            this.cxQrIn.Size = new System.Drawing.Size(645, 21);
            this.cxQrIn.TabIndex = 17;
            this.cxQrIn.Text = "HELLO WORLD.";
            // 
            // bnDecode
            // 
            this.bnDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnDecode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bnDecode.Location = new System.Drawing.Point(430, 215);
            this.bnDecode.Name = "bnDecode";
            this.bnDecode.Size = new System.Drawing.Size(75, 23);
            this.bnDecode.TabIndex = 129;
            this.bnDecode.Text = "Decode";
            this.bnDecode.UseVisualStyleBackColor = true;
            this.bnDecode.Click += new System.EventHandler(this.bnDecode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(294, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 159;
            this.label2.Text = "<-- Shifted 3 bits";
            // 
            // laResShiftArrow
            // 
            this.laResShiftArrow.AutoSize = true;
            this.laResShiftArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laResShiftArrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laResShiftArrow.Location = new System.Drawing.Point(258, 116);
            this.laResShiftArrow.Name = "laResShiftArrow";
            this.laResShiftArrow.Size = new System.Drawing.Size(130, 17);
            this.laResShiftArrow.TabIndex = 158;
            this.laResShiftArrow.Text = "<-- Shifted 2 bits";
            // 
            // laRFIDOut
            // 
            this.laRFIDOut.AutoSize = true;
            this.laRFIDOut.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laRFIDOut.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.laRFIDOut.Location = new System.Drawing.Point(96, 197);
            this.laRFIDOut.Name = "laRFIDOut";
            this.laRFIDOut.Size = new System.Drawing.Size(296, 17);
            this.laRFIDOut.TabIndex = 157;
            this.laRFIDOut.Text = "FE047DC7EC132F07984711A118331EC5";
            // 
            // laLotNum2
            // 
            this.laLotNum2.AutoSize = true;
            this.laLotNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laLotNum2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laLotNum2.Location = new System.Drawing.Point(13, 170);
            this.laLotNum2.Name = "laLotNum2";
            this.laLotNum2.Size = new System.Drawing.Size(45, 17);
            this.laLotNum2.TabIndex = 156;
            this.laLotNum2.Text = "Lot #";
            // 
            // laDValue2
            // 
            this.laDValue2.AutoSize = true;
            this.laDValue2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDValue2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laDValue2.Location = new System.Drawing.Point(13, 152);
            this.laDValue2.Name = "laDValue2";
            this.laDValue2.Size = new System.Drawing.Size(65, 17);
            this.laDValue2.TabIndex = 155;
            this.laDValue2.Text = "D.Value";
            // 
            // laDType2
            // 
            this.laDType2.AutoSize = true;
            this.laDType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDType2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laDType2.Location = new System.Drawing.Point(13, 134);
            this.laDType2.Name = "laDType2";
            this.laDType2.Size = new System.Drawing.Size(60, 17);
            this.laDType2.TabIndex = 154;
            this.laDType2.Text = "D.Type";
            // 
            // laGTIN2
            // 
            this.laGTIN2.AutoSize = true;
            this.laGTIN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laGTIN2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laGTIN2.Location = new System.Drawing.Point(13, 116);
            this.laGTIN2.Name = "laGTIN2";
            this.laGTIN2.Size = new System.Drawing.Size(45, 17);
            this.laGTIN2.TabIndex = 153;
            this.laGTIN2.Text = "GTIN";
            // 
            // laLotShift
            // 
            this.laLotShift.AutoSize = true;
            this.laLotShift.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laLotShift.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.laLotShift.Location = new System.Drawing.Point(248, 170);
            this.laLotShift.Name = "laLotShift";
            this.laLotShift.Size = new System.Drawing.Size(143, 17);
            this.laLotShift.TabIndex = 152;
            this.laLotShift.Text = "04711A118331EC5";
            // 
            // laDateValueShift
            // 
            this.laDateValueShift.AutoSize = true;
            this.laDateValueShift.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDateValueShift.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.laDateValueShift.Location = new System.Drawing.Point(221, 152);
            this.laDateValueShift.Name = "laDateValueShift";
            this.laDateValueShift.Size = new System.Drawing.Size(44, 17);
            this.laDateValueShift.TabIndex = 151;
            this.laDateValueShift.Text = "0798";
            // 
            // laDateTypeShift
            // 
            this.laDateTypeShift.AutoSize = true;
            this.laDateTypeShift.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDateTypeShift.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.laDateTypeShift.Location = new System.Drawing.Point(213, 134);
            this.laDateTypeShift.Name = "laDateTypeShift";
            this.laDateTypeShift.Size = new System.Drawing.Size(17, 17);
            this.laDateTypeShift.TabIndex = 150;
            this.laDateTypeShift.Text = "3";
            // 
            // laGTINShift
            // 
            this.laGTINShift.AutoSize = true;
            this.laGTINShift.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laGTINShift.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.laGTINShift.Location = new System.Drawing.Point(114, 116);
            this.laGTINShift.Name = "laGTINShift";
            this.laGTINShift.Size = new System.Drawing.Size(116, 17);
            this.laGTINShift.TabIndex = 149;
            this.laGTINShift.Text = "047DC7EC132C";
            // 
            // laHeaderShift
            // 
            this.laHeaderShift.AutoSize = true;
            this.laHeaderShift.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laHeaderShift.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.laHeaderShift.Location = new System.Drawing.Point(96, 98);
            this.laHeaderShift.Name = "laHeaderShift";
            this.laHeaderShift.Size = new System.Drawing.Size(26, 17);
            this.laHeaderShift.TabIndex = 148;
            this.laHeaderShift.Text = "FE";
            // 
            // laLotHex
            // 
            this.laLotHex.AutoSize = true;
            this.laLotHex.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laLotHex.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.laLotHex.Location = new System.Drawing.Point(506, 68);
            this.laLotHex.Name = "laLotHex";
            this.laLotHex.Size = new System.Drawing.Size(170, 17);
            this.laLotHex.TabIndex = 147;
            this.laLotHex.Text = "047 11A1 1833 1EC5";
            // 
            // laDateValueHex
            // 
            this.laDateValueHex.AutoSize = true;
            this.laDateValueHex.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDateValueHex.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.laDateValueHex.Location = new System.Drawing.Point(388, 68);
            this.laDateValueHex.Name = "laDateValueHex";
            this.laDateValueHex.Size = new System.Drawing.Size(44, 17);
            this.laDateValueHex.TabIndex = 146;
            this.laDateValueHex.Text = "00F3";
            // 
            // laDateTypeHex
            // 
            this.laDateTypeHex.AutoSize = true;
            this.laDateTypeHex.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDateTypeHex.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.laDateTypeHex.Location = new System.Drawing.Point(270, 68);
            this.laDateTypeHex.Name = "laDateTypeHex";
            this.laDateTypeHex.Size = new System.Drawing.Size(17, 17);
            this.laDateTypeHex.TabIndex = 145;
            this.laDateTypeHex.Text = "3";
            // 
            // laGTINHex
            // 
            this.laGTINHex.AutoSize = true;
            this.laGTINHex.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laGTINHex.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.laGTINHex.Location = new System.Drawing.Point(125, 68);
            this.laGTINHex.Name = "laGTINHex";
            this.laGTINHex.Size = new System.Drawing.Size(116, 17);
            this.laGTINHex.TabIndex = 144;
            this.laGTINHex.Text = "011F71FB04CB";
            // 
            // laHeaderHex
            // 
            this.laHeaderHex.AutoSize = true;
            this.laHeaderHex.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laHeaderHex.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.laHeaderHex.Location = new System.Drawing.Point(62, 68);
            this.laHeaderHex.Name = "laHeaderHex";
            this.laHeaderHex.Size = new System.Drawing.Size(26, 17);
            this.laHeaderHex.TabIndex = 143;
            this.laHeaderHex.Text = "FE";
            // 
            // laHex
            // 
            this.laHex.AutoSize = true;
            this.laHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laHex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laHex.Location = new System.Drawing.Point(13, 68);
            this.laHex.Name = "laHex";
            this.laHex.Size = new System.Drawing.Size(40, 17);
            this.laHex.TabIndex = 142;
            this.laHex.Text = "Hex:";
            // 
            // laHeader2
            // 
            this.laHeader2.AutoSize = true;
            this.laHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laHeader2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laHeader2.Location = new System.Drawing.Point(13, 98);
            this.laHeader2.Name = "laHeader2";
            this.laHeader2.Size = new System.Drawing.Size(61, 17);
            this.laHeader2.TabIndex = 141;
            this.laHeader2.Text = "Header";
            // 
            // cxHeader
            // 
            this.cxHeader.AllowDrop = true;
            this.cxHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxHeader.FormattingEnabled = true;
            this.cxHeader.Items.AddRange(new object[] {
            "FE",
            "00",
            "FF"});
            this.cxHeader.Location = new System.Drawing.Point(64, 36);
            this.cxHeader.Name = "cxHeader";
            this.cxHeader.Size = new System.Drawing.Size(58, 24);
            this.cxHeader.TabIndex = 123;
            this.cxHeader.Text = "FE";
            this.cxHeader.SelectedIndexChanged += new System.EventHandler(this.cxHeader_SelectedIndexChanged);
            this.cxHeader.TextUpdate += new System.EventHandler(this.cxHeader_TextUpdate);
            // 
            // laHeader
            // 
            this.laHeader.AutoSize = true;
            this.laHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laHeader.Location = new System.Drawing.Point(61, 16);
            this.laHeader.Name = "laHeader";
            this.laHeader.Size = new System.Drawing.Size(61, 17);
            this.laHeader.TabIndex = 140;
            this.laHeader.Text = "Header";
            // 
            // laaError
            // 
            this.laaError.AutoSize = true;
            this.laaError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laaError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laaError.Location = new System.Drawing.Point(202, 475);
            this.laaError.Name = "laaError";
            this.laaError.Size = new System.Drawing.Size(45, 17);
            this.laaError.TabIndex = 139;
            this.laaError.Text = "Error";
            // 
            // laRFID
            // 
            this.laRFID.AutoSize = true;
            this.laRFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laRFID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laRFID.Location = new System.Drawing.Point(13, 196);
            this.laRFID.Name = "laRFID";
            this.laRFID.Size = new System.Drawing.Size(43, 17);
            this.laRFID.TabIndex = 138;
            this.laRFID.Text = "RFID";
            // 
            // txWarn
            // 
            this.txWarn.AllowDrop = true;
            this.txWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txWarn.Location = new System.Drawing.Point(253, 501);
            this.txWarn.Name = "txWarn";
            this.txWarn.Size = new System.Drawing.Size(469, 23);
            this.txWarn.TabIndex = 131;
            // 
            // laLot
            // 
            this.laLot.AutoSize = true;
            this.laLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laLot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laLot.Location = new System.Drawing.Point(506, 16);
            this.laLot.Name = "laLot";
            this.laLot.Size = new System.Drawing.Size(92, 17);
            this.laLot.TabIndex = 137;
            this.laLot.Text = "Lot Number";
            // 
            // laDate
            // 
            this.laDate.AutoSize = true;
            this.laDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laDate.Location = new System.Drawing.Point(388, 16);
            this.laDate.Name = "laDate";
            this.laDate.Size = new System.Drawing.Size(115, 17);
            this.laDate.TabIndex = 136;
            this.laDate.Text = "Date (YMMDD)";
            // 
            // laDateType
            // 
            this.laDateType.AutoSize = true;
            this.laDateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDateType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laDateType.Location = new System.Drawing.Point(270, 16);
            this.laDateType.Name = "laDateType";
            this.laDateType.Size = new System.Drawing.Size(83, 17);
            this.laDateType.TabIndex = 135;
            this.laDateType.Text = "Date Type";
            // 
            // laGTIN
            // 
            this.laGTIN.AutoSize = true;
            this.laGTIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laGTIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laGTIN.Location = new System.Drawing.Point(125, 16);
            this.laGTIN.Name = "laGTIN";
            this.laGTIN.Size = new System.Drawing.Size(138, 17);
            this.laGTIN.TabIndex = 134;
            this.laGTIN.Text = "GTIN (w/ Chk Dig)";
            // 
            // cxLotNum
            // 
            this.cxLotNum.AllowDrop = true;
            this.cxLotNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxLotNum.FormattingEnabled = true;
            this.cxLotNum.Items.AddRange(new object[] {
            "A1B23C45D67",
            "",
            "99999999999",
            "A123-56"});
            this.cxLotNum.Location = new System.Drawing.Point(509, 36);
            this.cxLotNum.Name = "cxLotNum";
            this.cxLotNum.Size = new System.Drawing.Size(164, 24);
            this.cxLotNum.TabIndex = 127;
            this.cxLotNum.Text = "A12B34C56D7";
            this.cxLotNum.SelectedIndexChanged += new System.EventHandler(this.cxLot_SelectedIndexChanged);
            this.cxLotNum.TextUpdate += new System.EventHandler(this.cxLot_TextUpdate);
            // 
            // cxDate
            // 
            this.cxDate.AllowDrop = true;
            this.cxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxDate.FormattingEnabled = true;
            this.cxDate.Items.AddRange(new object[] {
            "00719",
            "01023",
            "00101",
            "91231"});
            this.cxDate.Location = new System.Drawing.Point(391, 36);
            this.cxDate.Name = "cxDate";
            this.cxDate.Size = new System.Drawing.Size(112, 24);
            this.cxDate.TabIndex = 126;
            this.cxDate.Text = "00719";
            this.cxDate.SelectedIndexChanged += new System.EventHandler(this.cxDate_SelectedIndexChanged);
            this.cxDate.TextUpdate += new System.EventHandler(this.cxDate_TextUpdate);
            // 
            // cxDateType
            // 
            this.cxDateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cxDateType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxDateType.FormattingEnabled = true;
            this.cxDateType.Items.AddRange(new object[] {
            "(11) Production",
            "(13) Packing",
            "(15) Best before",
            "(17) Expiration"});
            this.cxDateType.Location = new System.Drawing.Point(273, 36);
            this.cxDateType.Name = "cxDateType";
            this.cxDateType.Size = new System.Drawing.Size(112, 24);
            this.cxDateType.TabIndex = 125;
            this.cxDateType.SelectedIndexChanged += new System.EventHandler(this.cxDateType_SelectedIndexChanged);
            // 
            // cxGTIN
            // 
            this.cxGTIN.AllowDrop = true;
            this.cxGTIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxGTIN.FormattingEnabled = true;
            this.cxGTIN.Items.AddRange(new object[] {
            "01234567890128",
            "00000000000000",
            "70368744177663",
            "00037000919964",
            "00028028003018"});
            this.cxGTIN.Location = new System.Drawing.Point(128, 36);
            this.cxGTIN.Name = "cxGTIN";
            this.cxGTIN.Size = new System.Drawing.Size(139, 24);
            this.cxGTIN.TabIndex = 124;
            this.cxGTIN.Text = "01234567890123";
            this.cxGTIN.SelectedIndexChanged += new System.EventHandler(this.cxGTIN_SelectedIndexChanged);
            this.cxGTIN.TextUpdate += new System.EventHandler(this.cxGTIN_TextUpdate);
            // 
            // txError
            // 
            this.txError.AllowDrop = true;
            this.txError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txError.Location = new System.Drawing.Point(253, 472);
            this.txError.Name = "txError";
            this.txError.Size = new System.Drawing.Size(469, 23);
            this.txError.TabIndex = 130;
            // 
            // txAvery
            // 
            this.txAvery.BackColor = System.Drawing.SystemColors.Window;
            this.txAvery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txAvery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txAvery.Location = new System.Drawing.Point(99, 477);
            this.txAvery.Multiline = true;
            this.txAvery.Name = "txAvery";
            this.txAvery.ReadOnly = true;
            this.txAvery.Size = new System.Drawing.Size(100, 47);
            this.txAvery.TabIndex = 133;
            this.txAvery.TabStop = false;
            this.txAvery.Text = "Avery\r\nDennison";
            // 
            // pxAveryLogo
            // 
            this.pxAveryLogo.Image = global::Barcode006.Properties.Resources.ADLogoPC;
            this.pxAveryLogo.Location = new System.Drawing.Point(25, 462);
            this.pxAveryLogo.Name = "pxAveryLogo";
            this.pxAveryLogo.Size = new System.Drawing.Size(69, 58);
            this.pxAveryLogo.TabIndex = 132;
            this.pxAveryLogo.TabStop = false;
            // 
            // laPixPerXQR
            // 
            this.laPixPerXQR.AutoSize = true;
            this.laPixPerXQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPixPerXQR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laPixPerXQR.Location = new System.Drawing.Point(546, 174);
            this.laPixPerXQR.Name = "laPixPerXQR";
            this.laPixPerXQR.Size = new System.Drawing.Size(58, 13);
            this.laPixPerXQR.TabIndex = 162;
            this.laPixPerXQR.Text = "QR-Code";
            // 
            // laPixPerX128
            // 
            this.laPixPerX128.AutoSize = true;
            this.laPixPerX128.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPixPerX128.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laPixPerX128.Location = new System.Drawing.Point(544, 195);
            this.laPixPerX128.Name = "laPixPerX128";
            this.laPixPerX128.Size = new System.Drawing.Size(61, 13);
            this.laPixPerX128.TabIndex = 164;
            this.laPixPerX128.Text = "Code-128";
            // 
            // udPixPerX128
            // 
            this.udPixPerX128.Location = new System.Drawing.Point(610, 193);
            this.udPixPerX128.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udPixPerX128.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udPixPerX128.Name = "udPixPerX128";
            this.udPixPerX128.Size = new System.Drawing.Size(44, 20);
            this.udPixPerX128.TabIndex = 163;
            this.udPixPerX128.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.udPixPerX128.Click += new System.EventHandler(this.udPixPerX128_Click);
            // 
            // cxEPC
            // 
            this.cxEPC.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxEPC.FormattingEnabled = true;
            this.cxEPC.Items.AddRange(new object[] {
            "FE047DC7EC134307984711A118331EC5",
            "FEFFFFFFFFFFFB9CFE3F0000F9FF0000",
            "FE001A1A658B2B09B847CD43E0600000"});
            this.cxEPC.Location = new System.Drawing.Point(96, 215);
            this.cxEPC.Name = "cxEPC";
            this.cxEPC.Size = new System.Drawing.Size(331, 25);
            this.cxEPC.TabIndex = 165;
            this.cxEPC.Text = "FE047DC7EC132F07984711A118331EC5";
            // 
            // la128HR
            // 
            this.la128HR.AutoSize = true;
            this.la128HR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la128HR.Location = new System.Drawing.Point(131, 434);
            this.la128HR.Name = "la128HR";
            this.la128HR.Size = new System.Drawing.Size(58, 18);
            this.la128HR.TabIndex = 166;
            this.la128HR.Text = "(01) ...";
            // 
            // la128HR2
            // 
            this.la128HR2.AutoSize = true;
            this.la128HR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la128HR2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.la128HR2.Location = new System.Drawing.Point(13, 288);
            this.la128HR2.Name = "la128HR2";
            this.la128HR2.Size = new System.Drawing.Size(139, 17);
            this.la128HR2.TabIndex = 167;
            this.la128HR2.Text = "Code-128 Content";
            // 
            // laQR2
            // 
            this.laQR2.AutoSize = true;
            this.laQR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laQR2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laQR2.Location = new System.Drawing.Point(13, 261);
            this.laQR2.Name = "laQR2";
            this.laQR2.Size = new System.Drawing.Size(134, 17);
            this.laQR2.TabIndex = 168;
            this.laQR2.Text = "QR Code Content";
            // 
            // laWarn
            // 
            this.laWarn.AutoSize = true;
            this.laWarn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laWarn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laWarn.Location = new System.Drawing.Point(202, 504);
            this.laWarn.Name = "laWarn";
            this.laWarn.Size = new System.Drawing.Size(46, 17);
            this.laWarn.TabIndex = 169;
            this.laWarn.Text = "Warn";
            // 
            // cxSerNum
            // 
            this.cxSerNum.AllowDrop = true;
            this.cxSerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxSerNum.FormattingEnabled = true;
            this.cxSerNum.Items.AddRange(new object[] {
            "123456",
            "9876543210",
            "0",
            "99999999999999"});
            this.cxSerNum.Location = new System.Drawing.Point(679, 36);
            this.cxSerNum.Name = "cxSerNum";
            this.cxSerNum.Size = new System.Drawing.Size(114, 24);
            this.cxSerNum.TabIndex = 170;
            this.cxSerNum.Text = "123456";
            this.cxSerNum.SelectedIndexChanged += new System.EventHandler(this.cxSerNum_SelectedIndexChanged);
            this.cxSerNum.TextUpdate += new System.EventHandler(this.cxSerNum_TextUpdate);
            // 
            // laSerNum
            // 
            this.laSerNum.AutoSize = true;
            this.laSerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSerNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laSerNum.Location = new System.Drawing.Point(676, 16);
            this.laSerNum.Name = "laSerNum";
            this.laSerNum.Size = new System.Drawing.Size(117, 17);
            this.laSerNum.TabIndex = 171;
            this.laSerNum.Text = "Ser. Num (TID)";
            // 
            // bnRefresh
            // 
            this.bnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bnRefresh.Location = new System.Drawing.Point(696, 288);
            this.bnRefresh.Name = "bnRefresh";
            this.bnRefresh.Size = new System.Drawing.Size(107, 23);
            this.bnRefresh.TabIndex = 172;
            this.bnRefresh.Text = "Refresh Bmps.";
            this.bnRefresh.UseVisualStyleBackColor = true;
            this.bnRefresh.Click += new System.EventHandler(this.bnRefresh_Click);
            // 
            // laQRHead
            // 
            this.laQRHead.AutoSize = true;
            this.laQRHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laQRHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laQRHead.Location = new System.Drawing.Point(490, 109);
            this.laQRHead.Name = "laQRHead";
            this.laQRHead.Size = new System.Drawing.Size(132, 17);
            this.laQRHead.TabIndex = 174;
            this.laQRHead.Text = "QR-Code Header";
            // 
            // cxQRHead
            // 
            this.cxQRHead.AllowDrop = true;
            this.cxQRHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cxQRHead.FormattingEnabled = true;
            this.cxQRHead.Items.AddRange(new object[] {
            "https://id.gs1.org",
            "",
            "https://tbd"});
            this.cxQRHead.Location = new System.Drawing.Point(492, 129);
            this.cxQRHead.Name = "cxQRHead";
            this.cxQRHead.Size = new System.Drawing.Size(164, 24);
            this.cxQRHead.TabIndex = 173;
            this.cxQRHead.Text = "https://id.gs1.org";
            this.cxQRHead.SelectedIndexChanged += new System.EventHandler(this.cxQRHead_SelectedIndexChanged);
            this.cxQRHead.TextUpdate += new System.EventHandler(this.cxQRHead_TextUpdate);
            // 
            // laSample
            // 
            this.laSample.AutoSize = true;
            this.laSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSample.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.laSample.Location = new System.Drawing.Point(671, 89);
            this.laSample.Name = "laSample";
            this.laSample.Size = new System.Drawing.Size(132, 17);
            this.laSample.TabIndex = 175;
            this.laSample.Text = "Sample QR-Code";
            // 
            // FmCGTIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 538);
            this.Controls.Add(this.laSample);
            this.Controls.Add(this.laQRHead);
            this.Controls.Add(this.cxQRHead);
            this.Controls.Add(this.bnRefresh);
            this.Controls.Add(this.laSerNum);
            this.Controls.Add(this.cxSerNum);
            this.Controls.Add(this.laWarn);
            this.Controls.Add(this.laQR2);
            this.Controls.Add(this.la128HR2);
            this.Controls.Add(this.la128HR);
            this.Controls.Add(this.cxEPC);
            this.Controls.Add(this.laPixPerX128);
            this.Controls.Add(this.udPixPerX128);
            this.Controls.Add(this.laPixPerXQR);
            this.Controls.Add(this.bnDecode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.laResShiftArrow);
            this.Controls.Add(this.laRFIDOut);
            this.Controls.Add(this.laLotNum2);
            this.Controls.Add(this.laDValue2);
            this.Controls.Add(this.laDType2);
            this.Controls.Add(this.laGTIN2);
            this.Controls.Add(this.laLotShift);
            this.Controls.Add(this.laDateValueShift);
            this.Controls.Add(this.laDateTypeShift);
            this.Controls.Add(this.laGTINShift);
            this.Controls.Add(this.laHeaderShift);
            this.Controls.Add(this.laLotHex);
            this.Controls.Add(this.laDateValueHex);
            this.Controls.Add(this.laDateTypeHex);
            this.Controls.Add(this.laGTINHex);
            this.Controls.Add(this.laHeaderHex);
            this.Controls.Add(this.laHex);
            this.Controls.Add(this.laHeader2);
            this.Controls.Add(this.cxHeader);
            this.Controls.Add(this.laHeader);
            this.Controls.Add(this.laaError);
            this.Controls.Add(this.laRFID);
            this.Controls.Add(this.txWarn);
            this.Controls.Add(this.laLot);
            this.Controls.Add(this.laDate);
            this.Controls.Add(this.laDateType);
            this.Controls.Add(this.laGTIN);
            this.Controls.Add(this.cxLotNum);
            this.Controls.Add(this.cxDate);
            this.Controls.Add(this.cxDateType);
            this.Controls.Add(this.cxGTIN);
            this.Controls.Add(this.txError);
            this.Controls.Add(this.txAvery);
            this.Controls.Add(this.pxAveryLogo);
            this.Controls.Add(this.cxQrIn);
            this.Controls.Add(this.pxQR);
            this.Controls.Add(this.udPixPerXQR);
            this.Controls.Add(this.laPixPerX);
            this.Controls.Add(this.px128);
            this.Controls.Add(this.cx128In);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FmCGTIN";
            this.Text = "Extended GTIN / Date / Lot Number Converter for Chipotle";
            this.Load += new System.EventHandler(this.FmCGTIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udPixPerXQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.px128)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxAveryLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udPixPerX128)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown udPixPerXQR;
        private System.Windows.Forms.Label laPixPerX;
        private System.Windows.Forms.PictureBox px128;
        private System.Windows.Forms.ComboBox cx128In;
        private System.Windows.Forms.PictureBox pxQR;
        private System.Windows.Forms.ComboBox cxQrIn;
        private System.Windows.Forms.Button bnDecode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label laResShiftArrow;
        private System.Windows.Forms.Label laRFIDOut;
        private System.Windows.Forms.Label laLotNum2;
        private System.Windows.Forms.Label laDValue2;
        private System.Windows.Forms.Label laDType2;
        private System.Windows.Forms.Label laGTIN2;
        private System.Windows.Forms.Label laLotShift;
        private System.Windows.Forms.Label laDateValueShift;
        private System.Windows.Forms.Label laDateTypeShift;
        private System.Windows.Forms.Label laGTINShift;
        private System.Windows.Forms.Label laHeaderShift;
        private System.Windows.Forms.Label laLotHex;
        private System.Windows.Forms.Label laDateValueHex;
        private System.Windows.Forms.Label laDateTypeHex;
        private System.Windows.Forms.Label laGTINHex;
        private System.Windows.Forms.Label laHeaderHex;
        private System.Windows.Forms.Label laHex;
        private System.Windows.Forms.Label laHeader2;
        private System.Windows.Forms.ComboBox cxHeader;
        private System.Windows.Forms.Label laHeader;
        private System.Windows.Forms.Label laaError;
        private System.Windows.Forms.Label laRFID;
        public System.Windows.Forms.TextBox txWarn;
        private System.Windows.Forms.Label laLot;
        private System.Windows.Forms.Label laDate;
        private System.Windows.Forms.Label laDateType;
        private System.Windows.Forms.Label laGTIN;
        private System.Windows.Forms.ComboBox cxLotNum;
        private System.Windows.Forms.ComboBox cxDate;
        private System.Windows.Forms.ComboBox cxDateType;
        private System.Windows.Forms.ComboBox cxGTIN;
        public System.Windows.Forms.TextBox txError;
        private System.Windows.Forms.TextBox txAvery;
        private System.Windows.Forms.PictureBox pxAveryLogo;
        private System.Windows.Forms.Label laPixPerXQR;
        private System.Windows.Forms.Label laPixPerX128;
        private System.Windows.Forms.NumericUpDown udPixPerX128;
        private System.Windows.Forms.ComboBox cxEPC;
        private System.Windows.Forms.Label la128HR;
        private System.Windows.Forms.Label la128HR2;
        private System.Windows.Forms.Label laQR2;
        private System.Windows.Forms.Label laWarn;
        private System.Windows.Forms.ComboBox cxSerNum;
        private System.Windows.Forms.Label laSerNum;
        private System.Windows.Forms.Button bnRefresh;
        private System.Windows.Forms.Label laQRHead;
        private System.Windows.Forms.ComboBox cxQRHead;
        private System.Windows.Forms.Label laSample;
    }
}

