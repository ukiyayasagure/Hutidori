namespace Hutidori {
    partial class FrmMain {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.gbResize = new System.Windows.Forms.GroupBox();
            this.numResizeWidth = new System.Windows.Forms.NumericUpDown();
            this.txtResizeHeight = new System.Windows.Forms.TextBox();
            this.cboResizeMethod = new System.Windows.Forms.ComboBox();
            this.numResizeHeight = new System.Windows.Forms.NumericUpDown();
            this.txtResizeWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkResize = new System.Windows.Forms.CheckBox();
            this.chkUntiUnti = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUntiUntiUp = new System.Windows.Forms.CheckBox();
            this.chkUntiUntiDrop = new System.Windows.Forms.CheckBox();
            this.numUntiUnti = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numHutiThreshold = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numHutiSigma = new System.Windows.Forms.NumericUpDown();
            this.numHutiWindowSize = new System.Windows.Forms.NumericUpDown();
            this.cboHutiMethod = new System.Windows.Forms.ComboBox();
            this.chkHutiKeepSrc = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkHutiSmooth = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pbHutiColor = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numHutiWidth = new System.Windows.Forms.NumericUpDown();
            this.numHutiAlpha = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.chkHutidori = new System.Windows.Forms.CheckBox();
            this.rdoOutput32Bit = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkOutputSimplePNA = new System.Windows.Forms.CheckBox();
            this.rdoOutput24Bit = new System.Windows.Forms.RadioButton();
            this.pbOutputBackColor = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkOutputBackup = new System.Windows.Forms.CheckBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.lblDo = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.cdMain = new System.Windows.Forms.ColorDialog();
            this.btnPreview = new System.Windows.Forms.Button();
            this.txtPreviewFileName = new System.Windows.Forms.TextBox();
            this.chkPreviewLayered = new System.Windows.Forms.CheckBox();
            this.gbResize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResizeWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResizeHeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUntiUnti)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHutiThreshold)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHutiSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHutiWindowSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHutiColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHutiWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHutiAlpha)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutputBackColor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbResize
            // 
            this.gbResize.Controls.Add(this.numResizeWidth);
            this.gbResize.Controls.Add(this.txtResizeHeight);
            this.gbResize.Controls.Add(this.cboResizeMethod);
            this.gbResize.Controls.Add(this.numResizeHeight);
            this.gbResize.Controls.Add(this.txtResizeWidth);
            this.gbResize.Controls.Add(this.label2);
            this.gbResize.Controls.Add(this.label6);
            this.gbResize.Controls.Add(this.label4);
            this.gbResize.Controls.Add(this.label5);
            this.gbResize.Controls.Add(this.label3);
            this.gbResize.Controls.Add(this.label1);
            this.gbResize.Controls.Add(this.chkResize);
            this.gbResize.Location = new System.Drawing.Point(12, 12);
            this.gbResize.Name = "gbResize";
            this.gbResize.Size = new System.Drawing.Size(268, 111);
            this.gbResize.TabIndex = 0;
            this.gbResize.TabStop = false;
            // 
            // numResizeWidth
            // 
            this.numResizeWidth.Location = new System.Drawing.Point(140, 22);
            this.numResizeWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numResizeWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numResizeWidth.Name = "numResizeWidth";
            this.numResizeWidth.Size = new System.Drawing.Size(53, 19);
            this.numResizeWidth.TabIndex = 4;
            this.numResizeWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numResizeWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numResizeWidth.ValueChanged += new System.EventHandler(this.numResizeWidth_ValueChanged);
            // 
            // txtResizeHeight
            // 
            this.txtResizeHeight.Location = new System.Drawing.Point(37, 56);
            this.txtResizeHeight.Name = "txtResizeHeight";
            this.txtResizeHeight.ReadOnly = true;
            this.txtResizeHeight.Size = new System.Drawing.Size(74, 19);
            this.txtResizeHeight.TabIndex = 6;
            this.txtResizeHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResizeHeight.Validating += new System.ComponentModel.CancelEventHandler(this.txtResizeHeight_Validating);
            // 
            // cboResizeMethod
            // 
            this.cboResizeMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResizeMethod.FormattingEnabled = true;
            this.cboResizeMethod.Items.AddRange(new object[] {
            "HQBicubic（高速、おすすめ）",
            "Nearest Neighbor（低画質）",
            "Triangle（低画質）",
            "Hermite",
            "Bell（おすすめ、ぼけ強）",
            "CubicBSpline（エッジ弱）",
            "Lanczos3（おすすめ、エッジ強）",
            "Mitchell",
            "Cosine",
            "CatmullRom",
            "Quadratic",
            "QuadraticBSpline",
            "CubicConvolution",
            "Lanczos8（低速、エッジ強）"});
            this.cboResizeMethod.Location = new System.Drawing.Point(6, 81);
            this.cboResizeMethod.Name = "cboResizeMethod";
            this.cboResizeMethod.Size = new System.Drawing.Size(256, 20);
            this.cboResizeMethod.TabIndex = 1;
            this.cboResizeMethod.SelectedIndexChanged += new System.EventHandler(this.cboMethod_SelectedIndexChanged);
            // 
            // numResizeHeight
            // 
            this.numResizeHeight.Location = new System.Drawing.Point(140, 56);
            this.numResizeHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numResizeHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numResizeHeight.Name = "numResizeHeight";
            this.numResizeHeight.Size = new System.Drawing.Size(53, 19);
            this.numResizeHeight.TabIndex = 8;
            this.numResizeHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numResizeHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numResizeHeight.ValueChanged += new System.EventHandler(this.numResizeHeight_ValueChanged);
            // 
            // txtResizeWidth
            // 
            this.txtResizeWidth.Location = new System.Drawing.Point(37, 22);
            this.txtResizeWidth.Name = "txtResizeWidth";
            this.txtResizeWidth.ReadOnly = true;
            this.txtResizeWidth.Size = new System.Drawing.Size(74, 19);
            this.txtResizeWidth.TabIndex = 2;
            this.txtResizeWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResizeWidth.Validating += new System.ComponentModel.CancelEventHandler(this.txtResizeWidth_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "高さ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "px";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "px";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "幅";
            // 
            // chkResize
            // 
            this.chkResize.AutoSize = true;
            this.chkResize.Location = new System.Drawing.Point(6, 0);
            this.chkResize.Name = "chkResize";
            this.chkResize.Size = new System.Drawing.Size(88, 16);
            this.chkResize.TabIndex = 0;
            this.chkResize.Text = "リサイズを行う";
            this.chkResize.UseVisualStyleBackColor = true;
            this.chkResize.CheckedChanged += new System.EventHandler(this.chkResize_CheckedChanged);
            // 
            // chkUntiUnti
            // 
            this.chkUntiUnti.AutoSize = true;
            this.chkUntiUnti.Location = new System.Drawing.Point(6, 0);
            this.chkUntiUnti.Name = "chkUntiUnti";
            this.chkUntiUnti.Size = new System.Drawing.Size(155, 16);
            this.chkUntiUnti.TabIndex = 0;
            this.chkUntiUnti.Text = "アンチ・アンチエイリアスを行う";
            this.chkUntiUnti.UseVisualStyleBackColor = true;
            this.chkUntiUnti.CheckedChanged += new System.EventHandler(this.chkUntiUnti_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUntiUntiUp);
            this.groupBox1.Controls.Add(this.chkUntiUntiDrop);
            this.groupBox1.Controls.Add(this.numUntiUnti);
            this.groupBox1.Controls.Add(this.chkUntiUnti);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // chkUntiUntiUp
            // 
            this.chkUntiUntiUp.AutoSize = true;
            this.chkUntiUntiUp.Checked = true;
            this.chkUntiUntiUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUntiUntiUp.Location = new System.Drawing.Point(201, 20);
            this.chkUntiUntiUp.Name = "chkUntiUntiUp";
            this.chkUntiUntiUp.Size = new System.Drawing.Size(48, 16);
            this.chkUntiUntiUp.TabIndex = 4;
            this.chkUntiUntiUp.Text = "切上";
            this.chkUntiUntiUp.UseVisualStyleBackColor = true;
            // 
            // chkUntiUntiDrop
            // 
            this.chkUntiUntiDrop.AutoSize = true;
            this.chkUntiUntiDrop.Checked = true;
            this.chkUntiUntiDrop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUntiUntiDrop.Location = new System.Drawing.Point(152, 20);
            this.chkUntiUntiDrop.Name = "chkUntiUntiDrop";
            this.chkUntiUntiDrop.Size = new System.Drawing.Size(48, 16);
            this.chkUntiUntiDrop.TabIndex = 3;
            this.chkUntiUntiDrop.Text = "切捨";
            this.chkUntiUntiDrop.UseVisualStyleBackColor = true;
            // 
            // numUntiUnti
            // 
            this.numUntiUnti.Location = new System.Drawing.Point(93, 19);
            this.numUntiUnti.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUntiUnti.Name = "numUntiUnti";
            this.numUntiUnti.Size = new System.Drawing.Size(53, 19);
            this.numUntiUnti.TabIndex = 2;
            this.numUntiUnti.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUntiUnti.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "透明度しきい値";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numHutiThreshold);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.chkHutiSmooth);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.pbHutiColor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.numHutiWidth);
            this.groupBox2.Controls.Add(this.numHutiAlpha);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.chkHutidori);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 212);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // numHutiThreshold
            // 
            this.numHutiThreshold.Location = new System.Drawing.Point(125, 90);
            this.numHutiThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numHutiThreshold.Name = "numHutiThreshold";
            this.numHutiThreshold.Size = new System.Drawing.Size(53, 19);
            this.numHutiThreshold.TabIndex = 9;
            this.numHutiThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numHutiSigma);
            this.groupBox4.Controls.Add(this.numHutiWindowSize);
            this.groupBox4.Controls.Add(this.cboHutiMethod);
            this.groupBox4.Controls.Add(this.chkHutiKeepSrc);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(6, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 94);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "上級者向けオプション";
            // 
            // numHutiSigma
            // 
            this.numHutiSigma.DecimalPlaces = 1;
            this.numHutiSigma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numHutiSigma.Location = new System.Drawing.Point(140, 44);
            this.numHutiSigma.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numHutiSigma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numHutiSigma.Name = "numHutiSigma";
            this.numHutiSigma.Size = new System.Drawing.Size(53, 19);
            this.numHutiSigma.TabIndex = 4;
            this.numHutiSigma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numHutiSigma.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numHutiWindowSize
            // 
            this.numHutiWindowSize.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numHutiWindowSize.Location = new System.Drawing.Point(58, 44);
            this.numHutiWindowSize.Maximum = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.numHutiWindowSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numHutiWindowSize.Name = "numHutiWindowSize";
            this.numHutiWindowSize.Size = new System.Drawing.Size(53, 19);
            this.numHutiWindowSize.TabIndex = 3;
            this.numHutiWindowSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numHutiWindowSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // cboHutiMethod
            // 
            this.cboHutiMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHutiMethod.FormattingEnabled = true;
            this.cboHutiMethod.Items.AddRange(new object[] {
            "ガウシアンフィルタ",
            "移動平均フィルタ"});
            this.cboHutiMethod.Location = new System.Drawing.Point(6, 18);
            this.cboHutiMethod.Name = "cboHutiMethod";
            this.cboHutiMethod.Size = new System.Drawing.Size(244, 20);
            this.cboHutiMethod.TabIndex = 1;
            this.cboHutiMethod.SelectedIndexChanged += new System.EventHandler(this.cboMethod_SelectedIndexChanged);
            // 
            // chkHutiKeepSrc
            // 
            this.chkHutiKeepSrc.AutoSize = true;
            this.chkHutiKeepSrc.Location = new System.Drawing.Point(6, 69);
            this.chkHutiKeepSrc.Name = "chkHutiKeepSrc";
            this.chkHutiKeepSrc.Size = new System.Drawing.Size(216, 16);
            this.chkHutiKeepSrc.TabIndex = 5;
            this.chkHutiKeepSrc.Text = "元画像の色を完全に残す（特殊な場合）";
            this.chkHutiKeepSrc.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "σ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "ウィンドウ";
            // 
            // chkHutiSmooth
            // 
            this.chkHutiSmooth.AutoSize = true;
            this.chkHutiSmooth.Location = new System.Drawing.Point(8, 43);
            this.chkHutiSmooth.Name = "chkHutiSmooth";
            this.chkHutiSmooth.Size = new System.Drawing.Size(196, 16);
            this.chkHutiSmooth.TabIndex = 4;
            this.chkHutiSmooth.Text = "元画像とふちの境界をなめらかにする";
            this.chkHutiSmooth.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 12);
            this.label15.TabIndex = 8;
            this.label15.Text = "ふち打ち切りしきい値";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "色";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(88, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "透明度";
            // 
            // pbHutiColor
            // 
            this.pbHutiColor.BackColor = System.Drawing.Color.White;
            this.pbHutiColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbHutiColor.Location = new System.Drawing.Point(29, 18);
            this.pbHutiColor.Name = "pbHutiColor";
            this.pbHutiColor.Size = new System.Drawing.Size(53, 19);
            this.pbHutiColor.TabIndex = 4;
            this.pbHutiColor.TabStop = false;
            this.pbHutiColor.Click += new System.EventHandler(this.pbHutiColor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "ふちの太さ";
            // 
            // numHutiWidth
            // 
            this.numHutiWidth.Location = new System.Drawing.Point(66, 65);
            this.numHutiWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHutiWidth.Name = "numHutiWidth";
            this.numHutiWidth.Size = new System.Drawing.Size(53, 19);
            this.numHutiWidth.TabIndex = 6;
            this.numHutiWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numHutiWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numHutiAlpha
            // 
            this.numHutiAlpha.Location = new System.Drawing.Point(135, 18);
            this.numHutiAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numHutiAlpha.Name = "numHutiAlpha";
            this.numHutiAlpha.Size = new System.Drawing.Size(53, 19);
            this.numHutiAlpha.TabIndex = 3;
            this.numHutiAlpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numHutiAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "px";
            // 
            // chkHutidori
            // 
            this.chkHutidori.AutoSize = true;
            this.chkHutidori.Checked = true;
            this.chkHutidori.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHutidori.Location = new System.Drawing.Point(6, 0);
            this.chkHutidori.Name = "chkHutidori";
            this.chkHutidori.Size = new System.Drawing.Size(88, 16);
            this.chkHutidori.TabIndex = 0;
            this.chkHutidori.Text = "ふちどりを行う";
            this.chkHutidori.UseVisualStyleBackColor = true;
            this.chkHutidori.CheckedChanged += new System.EventHandler(this.chkHutidori_CheckedChanged);
            // 
            // rdoOutput32Bit
            // 
            this.rdoOutput32Bit.AutoSize = true;
            this.rdoOutput32Bit.Location = new System.Drawing.Point(6, 18);
            this.rdoOutput32Bit.Name = "rdoOutput32Bit";
            this.rdoOutput32Bit.Size = new System.Drawing.Size(81, 16);
            this.rdoOutput32Bit.TabIndex = 0;
            this.rdoOutput32Bit.Text = "32ビットPNG";
            this.rdoOutput32Bit.UseVisualStyleBackColor = true;
            this.rdoOutput32Bit.CheckedChanged += new System.EventHandler(this.rdoOutput32Bit_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkOutputSimplePNA);
            this.groupBox3.Controls.Add(this.rdoOutput24Bit);
            this.groupBox3.Controls.Add(this.rdoOutput32Bit);
            this.groupBox3.Controls.Add(this.pbOutputBackColor);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(12, 399);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 90);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "出力方法";
            // 
            // chkOutputSimplePNA
            // 
            this.chkOutputSimplePNA.AutoSize = true;
            this.chkOutputSimplePNA.Checked = true;
            this.chkOutputSimplePNA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOutputSimplePNA.Location = new System.Drawing.Point(107, 66);
            this.chkOutputSimplePNA.Name = "chkOutputSimplePNA";
            this.chkOutputSimplePNA.Size = new System.Drawing.Size(155, 16);
            this.chkOutputSimplePNA.TabIndex = 3;
            this.chkOutputSimplePNA.Text = "PNA不要の場合は作らない";
            this.chkOutputSimplePNA.UseVisualStyleBackColor = true;
            // 
            // rdoOutput24Bit
            // 
            this.rdoOutput24Bit.AutoSize = true;
            this.rdoOutput24Bit.Checked = true;
            this.rdoOutput24Bit.Location = new System.Drawing.Point(95, 19);
            this.rdoOutput24Bit.Name = "rdoOutput24Bit";
            this.rdoOutput24Bit.Size = new System.Drawing.Size(110, 16);
            this.rdoOutput24Bit.TabIndex = 1;
            this.rdoOutput24Bit.TabStop = true;
            this.rdoOutput24Bit.Text = "24ビットPNG+PNA";
            this.rdoOutput24Bit.UseVisualStyleBackColor = true;
            this.rdoOutput24Bit.CheckedChanged += new System.EventHandler(this.rdoOutput24Bit_CheckedChanged);
            // 
            // pbOutputBackColor
            // 
            this.pbOutputBackColor.BackColor = System.Drawing.Color.Lime;
            this.pbOutputBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOutputBackColor.Location = new System.Drawing.Point(152, 41);
            this.pbOutputBackColor.Name = "pbOutputBackColor";
            this.pbOutputBackColor.Size = new System.Drawing.Size(53, 19);
            this.pbOutputBackColor.TabIndex = 4;
            this.pbOutputBackColor.TabStop = false;
            this.pbOutputBackColor.Click += new System.EventHandler(this.pbOutputBackColor_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(105, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "背景色";
            // 
            // chkOutputBackup
            // 
            this.chkOutputBackup.AutoSize = true;
            this.chkOutputBackup.Checked = true;
            this.chkOutputBackup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOutputBackup.Location = new System.Drawing.Point(286, 414);
            this.chkOutputBackup.Name = "chkOutputBackup";
            this.chkOutputBackup.Size = new System.Drawing.Size(141, 16);
            this.chkOutputBackup.TabIndex = 9;
            this.chkOutputBackup.Text = "バックアップを残す（ .bak）";
            this.chkOutputBackup.UseVisualStyleBackColor = true;
            // 
            // lblPreview
            // 
            this.lblPreview.AllowDrop = true;
            this.lblPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPreview.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPreview.Location = new System.Drawing.Point(286, 12);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(196, 135);
            this.lblPreview.TabIndex = 4;
            this.lblPreview.Text = "プレビューをする場合はここに１つだけファイルをドロップして、「プレビューする」ボタンを押してください";
            this.lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPreview.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblPreview_DragDrop);
            this.lblPreview.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblPreview_DragEnter);
            // 
            // lblDo
            // 
            this.lblDo.AllowDrop = true;
            this.lblDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblDo.Location = new System.Drawing.Point(286, 271);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(196, 135);
            this.lblDo.TabIndex = 8;
            this.lblDo.Text = "処理を行う場合はここにファイルをドロップしてください（複数可）";
            this.lblDo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblDo_DragDrop);
            this.lblDo.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblDo_DragEnter);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(286, 437);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(196, 23);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "このプログラムについて";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // cdMain
            // 
            this.cdMain.AnyColor = true;
            this.cdMain.FullOpen = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(286, 188);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(196, 23);
            this.btnPreview.TabIndex = 6;
            this.btnPreview.Text = "プレビューする";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // txtPreviewFileName
            // 
            this.txtPreviewFileName.Location = new System.Drawing.Point(286, 150);
            this.txtPreviewFileName.Multiline = true;
            this.txtPreviewFileName.Name = "txtPreviewFileName";
            this.txtPreviewFileName.ReadOnly = true;
            this.txtPreviewFileName.Size = new System.Drawing.Size(196, 32);
            this.txtPreviewFileName.TabIndex = 5;
            // 
            // chkPreviewLayered
            // 
            this.chkPreviewLayered.AutoSize = true;
            this.chkPreviewLayered.Checked = true;
            this.chkPreviewLayered.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreviewLayered.Location = new System.Drawing.Point(286, 217);
            this.chkPreviewLayered.Name = "chkPreviewLayered";
            this.chkPreviewLayered.Size = new System.Drawing.Size(181, 16);
            this.chkPreviewLayered.TabIndex = 7;
            this.chkPreviewLayered.Text = "レイヤードウィンドウ（透明）で見る";
            this.chkPreviewLayered.UseVisualStyleBackColor = true;
            this.chkPreviewLayered.CheckedChanged += new System.EventHandler(this.chkPreviewLayered_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 495);
            this.Controls.Add(this.chkPreviewLayered);
            this.Controls.Add(this.chkOutputBackup);
            this.Controls.Add(this.txtPreviewFileName);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblDo);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbResize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "ふちどり。";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.gbResize.ResumeLayout(false);
            this.gbResize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResizeWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numResizeHeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUntiUnti)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHutiThreshold)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHutiSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHutiWindowSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHutiColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHutiWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHutiAlpha)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutputBackColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbResize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkResize;
        private System.Windows.Forms.TextBox txtResizeHeight;
        private System.Windows.Forms.TextBox txtResizeWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numResizeHeight;
        private System.Windows.Forms.NumericUpDown numResizeWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkUntiUnti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numUntiUnti;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkHutidori;
        private System.Windows.Forms.PictureBox pbHutiColor;
        private System.Windows.Forms.NumericUpDown numHutiAlpha;
        private System.Windows.Forms.RadioButton rdoOutput32Bit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkOutputBackup;
        private System.Windows.Forms.RadioButton rdoOutput24Bit;
        private System.Windows.Forms.PictureBox pbOutputBackColor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ColorDialog cdMain;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.TextBox txtPreviewFileName;
        private System.Windows.Forms.CheckBox chkPreviewLayered;
        private System.Windows.Forms.CheckBox chkOutputSimplePNA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numHutiWidth;
        private System.Windows.Forms.CheckBox chkHutiKeepSrc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkHutiSmooth;
        private System.Windows.Forms.NumericUpDown numHutiWindowSize;
        private System.Windows.Forms.ComboBox cboHutiMethod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numHutiSigma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numHutiThreshold;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chkUntiUntiUp;
        private System.Windows.Forms.CheckBox chkUntiUntiDrop;
        private System.Windows.Forms.ComboBox cboResizeMethod;

    }
}

