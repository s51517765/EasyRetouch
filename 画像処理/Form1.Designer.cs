namespace 画像処理
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGetClipbord = new System.Windows.Forms.Button();
            this.buttonFileOpen = new System.Windows.Forms.Button();
            this.buttonSnappingTool = new System.Windows.Forms.Button();
            this.buttonSetImage2Clipboard = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numericUpDownCutSketchDelay = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label_ImgSize = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDownOutputSize = new System.Windows.Forms.NumericUpDown();
            this.textBoxSuffix = new System.Windows.Forms.TextBox();
            this.labelSuffix = new System.Windows.Forms.Label();
            this.buttonTrapezoidalCorrect = new System.Windows.Forms.Button();
            this.groupBoxTransparent = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownTransBlue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTransGreen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTransRed = new System.Windows.Forms.NumericUpDown();
            this.checkBoxTransparent = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonOutputPNG = new System.Windows.Forms.RadioButton();
            this.radioButtonOutputJPG = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonRotate270deg = new System.Windows.Forms.Button();
            this.buttonFlipX = new System.Windows.Forms.Button();
            this.buttonRotate90deg = new System.Windows.Forms.Button();
            this.buttonFlipY = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownBlurSize = new System.Windows.Forms.NumericUpDown();
            this.buttonBlur = new System.Windows.Forms.Button();
            this.groupBoxTrimming = new System.Windows.Forms.GroupBox();
            this.buttonTrimingValueReset = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownTrimLeft = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTrimRight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTrimDown = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTrimUp = new System.Windows.Forms.NumericUpDown();
            this.buttonTrimming = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownLineWidth = new System.Windows.Forms.NumericUpDown();
            this.radioButtonSqLine_Black = new System.Windows.Forms.RadioButton();
            this.radioButtonSqLine_Blue = new System.Windows.Forms.RadioButton();
            this.radioButtonSqLine_Green = new System.Windows.Forms.RadioButton();
            this.buttonSquereLine = new System.Windows.Forms.Button();
            this.radioButtonSqLine_Yellow = new System.Windows.Forms.RadioButton();
            this.radioButtonSqLine_Red = new System.Windows.Forms.RadioButton();
            this.groupBoxDrowMask = new System.Windows.Forms.GroupBox();
            this.radioButtonDrowMask_Black = new System.Windows.Forms.RadioButton();
            this.radioButtonDrowMask_Blue = new System.Windows.Forms.RadioButton();
            this.radioButtonDrowMask_Green = new System.Windows.Forms.RadioButton();
            this.buttonDrowMask = new System.Windows.Forms.Button();
            this.radioButtonDrowMask_Yellow = new System.Windows.Forms.RadioButton();
            this.radioButtonDrowMask_Red = new System.Windows.Forms.RadioButton();
            this.groupBoxDrowEdge = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButtonDrowEdge_Blue = new System.Windows.Forms.RadioButton();
            this.radioButtonDrowEdge_Black = new System.Windows.Forms.RadioButton();
            this.radioButtonDrowEdge_Green = new System.Windows.Forms.RadioButton();
            this.radioButtonDrowEdge_Yellow = new System.Windows.Forms.RadioButton();
            this.radioButtonDrowEdge_Red = new System.Windows.Forms.RadioButton();
            this.numericUpDownSurroundLineWidth = new System.Windows.Forms.NumericUpDown();
            this.buttonDrowEdgeLine = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelStartMsg1 = new System.Windows.Forms.Label();
            this.labelStartMsg2 = new System.Windows.Forms.Label();
            this.labelStartMsg4 = new System.Windows.Forms.Label();
            this.labelStartMsg3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUndo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCutSketchDelay)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutputSize)).BeginInit();
            this.groupBoxTransparent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransRed)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlurSize)).BeginInit();
            this.groupBoxTrimming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimUp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineWidth)).BeginInit();
            this.groupBoxDrowMask.SuspendLayout();
            this.groupBoxDrowEdge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurroundLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(113, 15);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(900, 22);
            this.textBoxFileName.TabIndex = 0;
            this.textBoxFileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFileName_KeyDown);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSave.ForeColor = System.Drawing.Color.Blue;
            this.buttonSave.Location = new System.Drawing.Point(1216, 750);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(169, 79);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Souce File";
            // 
            // buttonGetClipbord
            // 
            this.buttonGetClipbord.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonGetClipbord.Location = new System.Drawing.Point(1186, 12);
            this.buttonGetClipbord.Name = "buttonGetClipbord";
            this.buttonGetClipbord.Size = new System.Drawing.Size(138, 48);
            this.buttonGetClipbord.TabIndex = 14;
            this.buttonGetClipbord.Text = "Get Clipbord";
            this.buttonGetClipbord.UseVisualStyleBackColor = true;
            this.buttonGetClipbord.Click += new System.EventHandler(this.buttonGetClipbord_Click);
            // 
            // buttonFileOpen
            // 
            this.buttonFileOpen.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonFileOpen.Image = global::画像処理.Properties.Resources.フォルダ;
            this.buttonFileOpen.Location = new System.Drawing.Point(1024, 12);
            this.buttonFileOpen.Name = "buttonFileOpen";
            this.buttonFileOpen.Size = new System.Drawing.Size(108, 46);
            this.buttonFileOpen.TabIndex = 21;
            this.buttonFileOpen.UseVisualStyleBackColor = true;
            this.buttonFileOpen.Click += new System.EventHandler(this.buttonFileOpen_Click);
            // 
            // buttonSnappingTool
            // 
            this.buttonSnappingTool.BackgroundImage = global::画像処理.Properties.Resources.snapping1;
            this.buttonSnappingTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSnappingTool.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSnappingTool.Location = new System.Drawing.Point(1332, 12);
            this.buttonSnappingTool.Name = "buttonSnappingTool";
            this.buttonSnappingTool.Size = new System.Drawing.Size(55, 48);
            this.buttonSnappingTool.TabIndex = 20;
            this.buttonSnappingTool.UseVisualStyleBackColor = true;
            this.buttonSnappingTool.Click += new System.EventHandler(this.buttonSnappingTool_Click);
            // 
            // buttonSetImage2Clipboard
            // 
            this.buttonSetImage2Clipboard.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSetImage2Clipboard.ForeColor = System.Drawing.Color.Blue;
            this.buttonSetImage2Clipboard.Location = new System.Drawing.Point(1064, 770);
            this.buttonSetImage2Clipboard.Name = "buttonSetImage2Clipboard";
            this.buttonSetImage2Clipboard.Size = new System.Drawing.Size(138, 59);
            this.buttonSetImage2Clipboard.TabIndex = 30;
            this.buttonSetImage2Clipboard.Text = " Set imge to Clipbord";
            this.buttonSetImage2Clipboard.UseVisualStyleBackColor = true;
            this.buttonSetImage2Clipboard.Click += new System.EventHandler(this.buttonSetImage2Clipboard_Click);
            // 
            // numericUpDownCutSketchDelay
            // 
            this.numericUpDownCutSketchDelay.Location = new System.Drawing.Point(1324, 66);
            this.numericUpDownCutSketchDelay.Name = "numericUpDownCutSketchDelay";
            this.numericUpDownCutSketchDelay.Size = new System.Drawing.Size(54, 22);
            this.numericUpDownCutSketchDelay.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1242, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 15);
            this.label14.TabIndex = 26;
            this.label14.Text = "Delay (sec)";
            // 
            // label_ImgSize
            // 
            this.label_ImgSize.AutoSize = true;
            this.label_ImgSize.Location = new System.Drawing.Point(854, 803);
            this.label_ImgSize.Name = "label_ImgSize";
            this.label_ImgSize.Size = new System.Drawing.Size(96, 15);
            this.label_ImgSize.TabIndex = 51;
            this.label_ImgSize.Text = "width x height";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.textBoxSuffix);
            this.panel2.Controls.Add(this.labelSuffix);
            this.panel2.Controls.Add(this.buttonTrapezoidalCorrect);
            this.panel2.Controls.Add(this.groupBoxTransparent);
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBoxTrimming);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBoxDrowMask);
            this.panel2.Controls.Add(this.groupBoxDrowEdge);
            this.panel2.Location = new System.Drawing.Point(956, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 647);
            this.panel2.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 651);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 53;
            this.label8.Text = "Suffix";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDownOutputSize);
            this.groupBox5.Location = new System.Drawing.Point(165, 619);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(128, 73);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Output size max";
            // 
            // numericUpDownOutputSize
            // 
            this.numericUpDownOutputSize.Location = new System.Drawing.Point(16, 40);
            this.numericUpDownOutputSize.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownOutputSize.Name = "numericUpDownOutputSize";
            this.numericUpDownOutputSize.Size = new System.Drawing.Size(62, 22);
            this.numericUpDownOutputSize.TabIndex = 34;
            this.numericUpDownOutputSize.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // textBoxSuffix
            // 
            this.textBoxSuffix.Location = new System.Drawing.Point(307, 669);
            this.textBoxSuffix.Name = "textBoxSuffix";
            this.textBoxSuffix.Size = new System.Drawing.Size(100, 22);
            this.textBoxSuffix.TabIndex = 48;
            this.textBoxSuffix.Text = "_retouch_";
            // 
            // labelSuffix
            // 
            this.labelSuffix.AutoSize = true;
            this.labelSuffix.Location = new System.Drawing.Point(-717, 637);
            this.labelSuffix.Name = "labelSuffix";
            this.labelSuffix.Size = new System.Drawing.Size(44, 15);
            this.labelSuffix.TabIndex = 49;
            this.labelSuffix.Text = "Suffix";
            // 
            // buttonTrapezoidalCorrect
            // 
            this.buttonTrapezoidalCorrect.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonTrapezoidalCorrect.Location = new System.Drawing.Point(49, 702);
            this.buttonTrapezoidalCorrect.Name = "buttonTrapezoidalCorrect";
            this.buttonTrapezoidalCorrect.Size = new System.Drawing.Size(127, 65);
            this.buttonTrapezoidalCorrect.TabIndex = 56;
            this.buttonTrapezoidalCorrect.Text = "Trapezoidal Correct";
            this.buttonTrapezoidalCorrect.UseVisualStyleBackColor = true;
            this.buttonTrapezoidalCorrect.Visible = false;
            // 
            // groupBoxTransparent
            // 
            this.groupBoxTransparent.Controls.Add(this.label13);
            this.groupBoxTransparent.Controls.Add(this.label12);
            this.groupBoxTransparent.Controls.Add(this.label11);
            this.groupBoxTransparent.Controls.Add(this.numericUpDownTransBlue);
            this.groupBoxTransparent.Controls.Add(this.numericUpDownTransGreen);
            this.groupBoxTransparent.Controls.Add(this.numericUpDownTransRed);
            this.groupBoxTransparent.Controls.Add(this.checkBoxTransparent);
            this.groupBoxTransparent.Enabled = false;
            this.groupBoxTransparent.Location = new System.Drawing.Point(13, 564);
            this.groupBoxTransparent.Name = "groupBoxTransparent";
            this.groupBoxTransparent.Size = new System.Drawing.Size(132, 128);
            this.groupBoxTransparent.TabIndex = 55;
            this.groupBoxTransparent.TabStop = false;
            this.groupBoxTransparent.Text = "Transparent";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 15);
            this.label13.TabIndex = 45;
            this.label13.Text = "B";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 15);
            this.label12.TabIndex = 44;
            this.label12.Text = "G";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "R";
            // 
            // numericUpDownTransBlue
            // 
            this.numericUpDownTransBlue.Location = new System.Drawing.Point(45, 99);
            this.numericUpDownTransBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownTransBlue.Name = "numericUpDownTransBlue";
            this.numericUpDownTransBlue.Size = new System.Drawing.Size(68, 22);
            this.numericUpDownTransBlue.TabIndex = 43;
            this.numericUpDownTransBlue.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numericUpDownTransGreen
            // 
            this.numericUpDownTransGreen.Location = new System.Drawing.Point(45, 71);
            this.numericUpDownTransGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownTransGreen.Name = "numericUpDownTransGreen";
            this.numericUpDownTransGreen.Size = new System.Drawing.Size(68, 22);
            this.numericUpDownTransGreen.TabIndex = 42;
            this.numericUpDownTransGreen.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numericUpDownTransRed
            // 
            this.numericUpDownTransRed.Location = new System.Drawing.Point(45, 43);
            this.numericUpDownTransRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownTransRed.Name = "numericUpDownTransRed";
            this.numericUpDownTransRed.Size = new System.Drawing.Size(68, 22);
            this.numericUpDownTransRed.TabIndex = 27;
            this.numericUpDownTransRed.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // checkBoxTransparent
            // 
            this.checkBoxTransparent.AutoSize = true;
            this.checkBoxTransparent.Location = new System.Drawing.Point(11, 21);
            this.checkBoxTransparent.Name = "checkBoxTransparent";
            this.checkBoxTransparent.Size = new System.Drawing.Size(70, 19);
            this.checkBoxTransparent.TabIndex = 41;
            this.checkBoxTransparent.Text = "Enable";
            this.checkBoxTransparent.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonOutputPNG);
            this.groupBox4.Controls.Add(this.radioButtonOutputJPG);
            this.groupBox4.Location = new System.Drawing.Point(223, 512);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(129, 76);
            this.groupBox4.TabIndex = 54;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output Format";
            // 
            // radioButtonOutputPNG
            // 
            this.radioButtonOutputPNG.AutoSize = true;
            this.radioButtonOutputPNG.Location = new System.Drawing.Point(16, 46);
            this.radioButtonOutputPNG.Name = "radioButtonOutputPNG";
            this.radioButtonOutputPNG.Size = new System.Drawing.Size(57, 19);
            this.radioButtonOutputPNG.TabIndex = 1;
            this.radioButtonOutputPNG.Text = "PNG";
            this.radioButtonOutputPNG.UseVisualStyleBackColor = true;
            // 
            // radioButtonOutputJPG
            // 
            this.radioButtonOutputJPG.AutoSize = true;
            this.radioButtonOutputJPG.Checked = true;
            this.radioButtonOutputJPG.Location = new System.Drawing.Point(16, 21);
            this.radioButtonOutputJPG.Name = "radioButtonOutputJPG";
            this.radioButtonOutputJPG.Size = new System.Drawing.Size(55, 19);
            this.radioButtonOutputJPG.TabIndex = 0;
            this.radioButtonOutputJPG.TabStop = true;
            this.radioButtonOutputJPG.Text = "JPG";
            this.radioButtonOutputJPG.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonRotate270deg);
            this.groupBox3.Controls.Add(this.buttonFlipX);
            this.groupBox3.Controls.Add(this.buttonRotate90deg);
            this.groupBox3.Controls.Add(this.buttonFlipY);
            this.groupBox3.Location = new System.Drawing.Point(222, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 171);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rotation";
            // 
            // buttonRotate270deg
            // 
            this.buttonRotate270deg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRotate270deg.BackgroundImage")));
            this.buttonRotate270deg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRotate270deg.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRotate270deg.Location = new System.Drawing.Point(112, 21);
            this.buttonRotate270deg.Name = "buttonRotate270deg";
            this.buttonRotate270deg.Size = new System.Drawing.Size(75, 62);
            this.buttonRotate270deg.TabIndex = 27;
            this.buttonRotate270deg.UseVisualStyleBackColor = true;
            this.buttonRotate270deg.Click += new System.EventHandler(this.buttonRotate270deg_Click);
            // 
            // buttonFlipX
            // 
            this.buttonFlipX.BackgroundImage = global::画像処理.Properties.Resources.RightLeft1;
            this.buttonFlipX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFlipX.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonFlipX.Location = new System.Drawing.Point(112, 101);
            this.buttonFlipX.Name = "buttonFlipX";
            this.buttonFlipX.Size = new System.Drawing.Size(75, 62);
            this.buttonFlipX.TabIndex = 28;
            this.buttonFlipX.UseVisualStyleBackColor = true;
            this.buttonFlipX.Click += new System.EventHandler(this.buttonFlipX_Click);
            // 
            // buttonRotate90deg
            // 
            this.buttonRotate90deg.BackgroundImage = global::画像処理.Properties.Resources.RotateRight1;
            this.buttonRotate90deg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRotate90deg.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRotate90deg.Location = new System.Drawing.Point(20, 22);
            this.buttonRotate90deg.Name = "buttonRotate90deg";
            this.buttonRotate90deg.Size = new System.Drawing.Size(75, 62);
            this.buttonRotate90deg.TabIndex = 26;
            this.buttonRotate90deg.UseVisualStyleBackColor = true;
            this.buttonRotate90deg.Click += new System.EventHandler(this.buttonRotate90deg_Click);
            // 
            // buttonFlipY
            // 
            this.buttonFlipY.BackgroundImage = global::画像処理.Properties.Resources.upDown2;
            this.buttonFlipY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFlipY.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonFlipY.Location = new System.Drawing.Point(20, 101);
            this.buttonFlipY.Name = "buttonFlipY";
            this.buttonFlipY.Size = new System.Drawing.Size(75, 62);
            this.buttonFlipY.TabIndex = 25;
            this.buttonFlipY.UseVisualStyleBackColor = true;
            this.buttonFlipY.Click += new System.EventHandler(this.buttonFlipY_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.numericUpDownBlurSize);
            this.groupBox2.Controls.Add(this.buttonBlur);
            this.groupBox2.Location = new System.Drawing.Point(222, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 130);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Blur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Size";
            // 
            // numericUpDownBlurSize
            // 
            this.numericUpDownBlurSize.Location = new System.Drawing.Point(119, 98);
            this.numericUpDownBlurSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownBlurSize.Name = "numericUpDownBlurSize";
            this.numericUpDownBlurSize.Size = new System.Drawing.Size(68, 22);
            this.numericUpDownBlurSize.TabIndex = 26;
            this.numericUpDownBlurSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // buttonBlur
            // 
            this.buttonBlur.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBlur.Location = new System.Drawing.Point(6, 22);
            this.buttonBlur.Name = "buttonBlur";
            this.buttonBlur.Size = new System.Drawing.Size(75, 100);
            this.buttonBlur.TabIndex = 22;
            this.buttonBlur.Text = "Blur";
            this.buttonBlur.UseVisualStyleBackColor = true;
            this.buttonBlur.Click += new System.EventHandler(this.buttonBlur_Click);
            // 
            // groupBoxTrimming
            // 
            this.groupBoxTrimming.Controls.Add(this.buttonTrimingValueReset);
            this.groupBoxTrimming.Controls.Add(this.label6);
            this.groupBoxTrimming.Controls.Add(this.label5);
            this.groupBoxTrimming.Controls.Add(this.label4);
            this.groupBoxTrimming.Controls.Add(this.label3);
            this.groupBoxTrimming.Controls.Add(this.numericUpDownTrimLeft);
            this.groupBoxTrimming.Controls.Add(this.numericUpDownTrimRight);
            this.groupBoxTrimming.Controls.Add(this.numericUpDownTrimDown);
            this.groupBoxTrimming.Controls.Add(this.numericUpDownTrimUp);
            this.groupBoxTrimming.Controls.Add(this.buttonTrimming);
            this.groupBoxTrimming.Location = new System.Drawing.Point(222, 4);
            this.groupBoxTrimming.Name = "groupBoxTrimming";
            this.groupBoxTrimming.Size = new System.Drawing.Size(200, 195);
            this.groupBoxTrimming.TabIndex = 46;
            this.groupBoxTrimming.TabStop = false;
            this.groupBoxTrimming.Text = "Trimming";
            // 
            // buttonTrimingValueReset
            // 
            this.buttonTrimingValueReset.Location = new System.Drawing.Point(119, 156);
            this.buttonTrimingValueReset.Name = "buttonTrimingValueReset";
            this.buttonTrimingValueReset.Size = new System.Drawing.Size(75, 28);
            this.buttonTrimingValueReset.TabIndex = 25;
            this.buttonTrimingValueReset.Text = "Reaset";
            this.buttonTrimingValueReset.UseVisualStyleBackColor = true;
            this.buttonTrimingValueReset.Click += new System.EventHandler(this.buttonTrimingValueReset_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "L";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "D";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "U";
            // 
            // numericUpDownTrimLeft
            // 
            this.numericUpDownTrimLeft.Location = new System.Drawing.Point(126, 112);
            this.numericUpDownTrimLeft.Name = "numericUpDownTrimLeft";
            this.numericUpDownTrimLeft.Size = new System.Drawing.Size(68, 22);
            this.numericUpDownTrimLeft.TabIndex = 9;
            // 
            // numericUpDownTrimRight
            // 
            this.numericUpDownTrimRight.Location = new System.Drawing.Point(126, 84);
            this.numericUpDownTrimRight.Name = "numericUpDownTrimRight";
            this.numericUpDownTrimRight.Size = new System.Drawing.Size(68, 22);
            this.numericUpDownTrimRight.TabIndex = 8;
            // 
            // numericUpDownTrimDown
            // 
            this.numericUpDownTrimDown.Location = new System.Drawing.Point(126, 53);
            this.numericUpDownTrimDown.Name = "numericUpDownTrimDown";
            this.numericUpDownTrimDown.Size = new System.Drawing.Size(68, 22);
            this.numericUpDownTrimDown.TabIndex = 7;
            // 
            // numericUpDownTrimUp
            // 
            this.numericUpDownTrimUp.Location = new System.Drawing.Point(126, 24);
            this.numericUpDownTrimUp.Name = "numericUpDownTrimUp";
            this.numericUpDownTrimUp.Size = new System.Drawing.Size(68, 22);
            this.numericUpDownTrimUp.TabIndex = 6;
            // 
            // buttonTrimming
            // 
            this.buttonTrimming.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonTrimming.Location = new System.Drawing.Point(6, 34);
            this.buttonTrimming.Name = "buttonTrimming";
            this.buttonTrimming.Size = new System.Drawing.Size(75, 100);
            this.buttonTrimming.TabIndex = 4;
            this.buttonTrimming.Text = "Trim";
            this.buttonTrimming.UseVisualStyleBackColor = true;
            this.buttonTrimming.Click += new System.EventHandler(this.buttonTrimming_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownLineWidth);
            this.groupBox1.Controls.Add(this.radioButtonSqLine_Black);
            this.groupBox1.Controls.Add(this.radioButtonSqLine_Blue);
            this.groupBox1.Controls.Add(this.radioButtonSqLine_Green);
            this.groupBox1.Controls.Add(this.buttonSquereLine);
            this.groupBox1.Controls.Add(this.radioButtonSqLine_Yellow);
            this.groupBox1.Controls.Add(this.radioButtonSqLine_Red);
            this.groupBox1.Location = new System.Drawing.Point(13, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 192);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Squere border Line";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "LineWidth";
            // 
            // numericUpDownLineWidth
            // 
            this.numericUpDownLineWidth.Location = new System.Drawing.Point(111, 154);
            this.numericUpDownLineWidth.Name = "numericUpDownLineWidth";
            this.numericUpDownLineWidth.Size = new System.Drawing.Size(66, 22);
            this.numericUpDownLineWidth.TabIndex = 14;
            this.numericUpDownLineWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // radioButtonSqLine_Black
            // 
            this.radioButtonSqLine_Black.AutoSize = true;
            this.radioButtonSqLine_Black.Location = new System.Drawing.Point(109, 121);
            this.radioButtonSqLine_Black.Name = "radioButtonSqLine_Black";
            this.radioButtonSqLine_Black.Size = new System.Drawing.Size(63, 19);
            this.radioButtonSqLine_Black.TabIndex = 9;
            this.radioButtonSqLine_Black.Text = "Black";
            this.radioButtonSqLine_Black.UseVisualStyleBackColor = true;
            // 
            // radioButtonSqLine_Blue
            // 
            this.radioButtonSqLine_Blue.AutoSize = true;
            this.radioButtonSqLine_Blue.Location = new System.Drawing.Point(109, 96);
            this.radioButtonSqLine_Blue.Name = "radioButtonSqLine_Blue";
            this.radioButtonSqLine_Blue.Size = new System.Drawing.Size(57, 19);
            this.radioButtonSqLine_Blue.TabIndex = 3;
            this.radioButtonSqLine_Blue.Text = "Blue";
            this.radioButtonSqLine_Blue.UseVisualStyleBackColor = true;
            // 
            // radioButtonSqLine_Green
            // 
            this.radioButtonSqLine_Green.AutoSize = true;
            this.radioButtonSqLine_Green.Location = new System.Drawing.Point(109, 71);
            this.radioButtonSqLine_Green.Name = "radioButtonSqLine_Green";
            this.radioButtonSqLine_Green.Size = new System.Drawing.Size(67, 19);
            this.radioButtonSqLine_Green.TabIndex = 2;
            this.radioButtonSqLine_Green.Text = "Green";
            this.radioButtonSqLine_Green.UseVisualStyleBackColor = true;
            // 
            // buttonSquereLine
            // 
            this.buttonSquereLine.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSquereLine.Location = new System.Drawing.Point(6, 41);
            this.buttonSquereLine.Name = "buttonSquereLine";
            this.buttonSquereLine.Size = new System.Drawing.Size(75, 100);
            this.buttonSquereLine.TabIndex = 6;
            this.buttonSquereLine.Text = "Drow Line";
            this.buttonSquereLine.UseVisualStyleBackColor = true;
            this.buttonSquereLine.Click += new System.EventHandler(this.buttonSquereLine_Click);
            // 
            // radioButtonSqLine_Yellow
            // 
            this.radioButtonSqLine_Yellow.AutoSize = true;
            this.radioButtonSqLine_Yellow.Location = new System.Drawing.Point(109, 46);
            this.radioButtonSqLine_Yellow.Name = "radioButtonSqLine_Yellow";
            this.radioButtonSqLine_Yellow.Size = new System.Drawing.Size(69, 19);
            this.radioButtonSqLine_Yellow.TabIndex = 1;
            this.radioButtonSqLine_Yellow.Text = "Yellow";
            this.radioButtonSqLine_Yellow.UseVisualStyleBackColor = true;
            // 
            // radioButtonSqLine_Red
            // 
            this.radioButtonSqLine_Red.AutoSize = true;
            this.radioButtonSqLine_Red.Checked = true;
            this.radioButtonSqLine_Red.Location = new System.Drawing.Point(109, 21);
            this.radioButtonSqLine_Red.Name = "radioButtonSqLine_Red";
            this.radioButtonSqLine_Red.Size = new System.Drawing.Size(52, 19);
            this.radioButtonSqLine_Red.TabIndex = 0;
            this.radioButtonSqLine_Red.TabStop = true;
            this.radioButtonSqLine_Red.Text = "Red";
            this.radioButtonSqLine_Red.UseVisualStyleBackColor = true;
            // 
            // groupBoxDrowMask
            // 
            this.groupBoxDrowMask.Controls.Add(this.radioButtonDrowMask_Black);
            this.groupBoxDrowMask.Controls.Add(this.radioButtonDrowMask_Blue);
            this.groupBoxDrowMask.Controls.Add(this.radioButtonDrowMask_Green);
            this.groupBoxDrowMask.Controls.Add(this.buttonDrowMask);
            this.groupBoxDrowMask.Controls.Add(this.radioButtonDrowMask_Yellow);
            this.groupBoxDrowMask.Controls.Add(this.radioButtonDrowMask_Red);
            this.groupBoxDrowMask.Location = new System.Drawing.Point(13, 206);
            this.groupBoxDrowMask.Name = "groupBoxDrowMask";
            this.groupBoxDrowMask.Size = new System.Drawing.Size(200, 151);
            this.groupBoxDrowMask.TabIndex = 47;
            this.groupBoxDrowMask.TabStop = false;
            this.groupBoxDrowMask.Text = "Area Mask";
            // 
            // radioButtonDrowMask_Black
            // 
            this.radioButtonDrowMask_Black.AutoSize = true;
            this.radioButtonDrowMask_Black.Location = new System.Drawing.Point(109, 121);
            this.radioButtonDrowMask_Black.Name = "radioButtonDrowMask_Black";
            this.radioButtonDrowMask_Black.Size = new System.Drawing.Size(63, 19);
            this.radioButtonDrowMask_Black.TabIndex = 9;
            this.radioButtonDrowMask_Black.Text = "Black";
            this.radioButtonDrowMask_Black.UseVisualStyleBackColor = true;
            // 
            // radioButtonDrowMask_Blue
            // 
            this.radioButtonDrowMask_Blue.AutoSize = true;
            this.radioButtonDrowMask_Blue.Location = new System.Drawing.Point(109, 96);
            this.radioButtonDrowMask_Blue.Name = "radioButtonDrowMask_Blue";
            this.radioButtonDrowMask_Blue.Size = new System.Drawing.Size(57, 19);
            this.radioButtonDrowMask_Blue.TabIndex = 3;
            this.radioButtonDrowMask_Blue.Text = "Blue";
            this.radioButtonDrowMask_Blue.UseVisualStyleBackColor = true;
            // 
            // radioButtonDrowMask_Green
            // 
            this.radioButtonDrowMask_Green.AutoSize = true;
            this.radioButtonDrowMask_Green.Location = new System.Drawing.Point(109, 71);
            this.radioButtonDrowMask_Green.Name = "radioButtonDrowMask_Green";
            this.radioButtonDrowMask_Green.Size = new System.Drawing.Size(67, 19);
            this.radioButtonDrowMask_Green.TabIndex = 2;
            this.radioButtonDrowMask_Green.Text = "Green";
            this.radioButtonDrowMask_Green.UseVisualStyleBackColor = true;
            // 
            // buttonDrowMask
            // 
            this.buttonDrowMask.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonDrowMask.Location = new System.Drawing.Point(6, 41);
            this.buttonDrowMask.Name = "buttonDrowMask";
            this.buttonDrowMask.Size = new System.Drawing.Size(75, 100);
            this.buttonDrowMask.TabIndex = 6;
            this.buttonDrowMask.Text = "Drow Mask";
            this.buttonDrowMask.UseVisualStyleBackColor = true;
            this.buttonDrowMask.Click += new System.EventHandler(this.buttonDrowMask_Click);
            // 
            // radioButtonDrowMask_Yellow
            // 
            this.radioButtonDrowMask_Yellow.AutoSize = true;
            this.radioButtonDrowMask_Yellow.Checked = true;
            this.radioButtonDrowMask_Yellow.Location = new System.Drawing.Point(109, 46);
            this.radioButtonDrowMask_Yellow.Name = "radioButtonDrowMask_Yellow";
            this.radioButtonDrowMask_Yellow.Size = new System.Drawing.Size(69, 19);
            this.radioButtonDrowMask_Yellow.TabIndex = 1;
            this.radioButtonDrowMask_Yellow.TabStop = true;
            this.radioButtonDrowMask_Yellow.Text = "Yellow";
            this.radioButtonDrowMask_Yellow.UseVisualStyleBackColor = true;
            // 
            // radioButtonDrowMask_Red
            // 
            this.radioButtonDrowMask_Red.AutoSize = true;
            this.radioButtonDrowMask_Red.Location = new System.Drawing.Point(109, 21);
            this.radioButtonDrowMask_Red.Name = "radioButtonDrowMask_Red";
            this.radioButtonDrowMask_Red.Size = new System.Drawing.Size(52, 19);
            this.radioButtonDrowMask_Red.TabIndex = 0;
            this.radioButtonDrowMask_Red.Text = "Red";
            this.radioButtonDrowMask_Red.UseVisualStyleBackColor = true;
            // 
            // groupBoxDrowEdge
            // 
            this.groupBoxDrowEdge.Controls.Add(this.label9);
            this.groupBoxDrowEdge.Controls.Add(this.radioButtonDrowEdge_Blue);
            this.groupBoxDrowEdge.Controls.Add(this.radioButtonDrowEdge_Black);
            this.groupBoxDrowEdge.Controls.Add(this.radioButtonDrowEdge_Green);
            this.groupBoxDrowEdge.Controls.Add(this.radioButtonDrowEdge_Yellow);
            this.groupBoxDrowEdge.Controls.Add(this.radioButtonDrowEdge_Red);
            this.groupBoxDrowEdge.Controls.Add(this.numericUpDownSurroundLineWidth);
            this.groupBoxDrowEdge.Controls.Add(this.buttonDrowEdgeLine);
            this.groupBoxDrowEdge.Location = new System.Drawing.Point(13, 4);
            this.groupBoxDrowEdge.Name = "groupBoxDrowEdge";
            this.groupBoxDrowEdge.Size = new System.Drawing.Size(200, 194);
            this.groupBoxDrowEdge.TabIndex = 45;
            this.groupBoxDrowEdge.TabStop = false;
            this.groupBoxDrowEdge.Text = "Surround Line";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 50;
            this.label9.Text = "LineWidth";
            // 
            // radioButtonDrowEdge_Blue
            // 
            this.radioButtonDrowEdge_Blue.AutoSize = true;
            this.radioButtonDrowEdge_Blue.Location = new System.Drawing.Point(109, 96);
            this.radioButtonDrowEdge_Blue.Name = "radioButtonDrowEdge_Blue";
            this.radioButtonDrowEdge_Blue.Size = new System.Drawing.Size(57, 19);
            this.radioButtonDrowEdge_Blue.TabIndex = 3;
            this.radioButtonDrowEdge_Blue.Text = "Blue";
            this.radioButtonDrowEdge_Blue.UseVisualStyleBackColor = true;
            // 
            // radioButtonDrowEdge_Black
            // 
            this.radioButtonDrowEdge_Black.AutoSize = true;
            this.radioButtonDrowEdge_Black.Location = new System.Drawing.Point(109, 121);
            this.radioButtonDrowEdge_Black.Name = "radioButtonDrowEdge_Black";
            this.radioButtonDrowEdge_Black.Size = new System.Drawing.Size(63, 19);
            this.radioButtonDrowEdge_Black.TabIndex = 5;
            this.radioButtonDrowEdge_Black.Text = "Black";
            this.radioButtonDrowEdge_Black.UseVisualStyleBackColor = true;
            // 
            // radioButtonDrowEdge_Green
            // 
            this.radioButtonDrowEdge_Green.AutoSize = true;
            this.radioButtonDrowEdge_Green.Location = new System.Drawing.Point(109, 71);
            this.radioButtonDrowEdge_Green.Name = "radioButtonDrowEdge_Green";
            this.radioButtonDrowEdge_Green.Size = new System.Drawing.Size(67, 19);
            this.radioButtonDrowEdge_Green.TabIndex = 2;
            this.radioButtonDrowEdge_Green.Text = "Green";
            this.radioButtonDrowEdge_Green.UseVisualStyleBackColor = true;
            // 
            // radioButtonDrowEdge_Yellow
            // 
            this.radioButtonDrowEdge_Yellow.AutoSize = true;
            this.radioButtonDrowEdge_Yellow.Location = new System.Drawing.Point(109, 46);
            this.radioButtonDrowEdge_Yellow.Name = "radioButtonDrowEdge_Yellow";
            this.radioButtonDrowEdge_Yellow.Size = new System.Drawing.Size(69, 19);
            this.radioButtonDrowEdge_Yellow.TabIndex = 1;
            this.radioButtonDrowEdge_Yellow.Text = "Yellow";
            this.radioButtonDrowEdge_Yellow.UseVisualStyleBackColor = true;
            // 
            // radioButtonDrowEdge_Red
            // 
            this.radioButtonDrowEdge_Red.AutoSize = true;
            this.radioButtonDrowEdge_Red.Checked = true;
            this.radioButtonDrowEdge_Red.Location = new System.Drawing.Point(109, 21);
            this.radioButtonDrowEdge_Red.Name = "radioButtonDrowEdge_Red";
            this.radioButtonDrowEdge_Red.Size = new System.Drawing.Size(52, 19);
            this.radioButtonDrowEdge_Red.TabIndex = 0;
            this.radioButtonDrowEdge_Red.TabStop = true;
            this.radioButtonDrowEdge_Red.Text = "Red";
            this.radioButtonDrowEdge_Red.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSurroundLineWidth
            // 
            this.numericUpDownSurroundLineWidth.Location = new System.Drawing.Point(113, 155);
            this.numericUpDownSurroundLineWidth.Name = "numericUpDownSurroundLineWidth";
            this.numericUpDownSurroundLineWidth.Size = new System.Drawing.Size(53, 22);
            this.numericUpDownSurroundLineWidth.TabIndex = 38;
            this.numericUpDownSurroundLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonDrowEdgeLine
            // 
            this.buttonDrowEdgeLine.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonDrowEdgeLine.Location = new System.Drawing.Point(6, 34);
            this.buttonDrowEdgeLine.Name = "buttonDrowEdgeLine";
            this.buttonDrowEdgeLine.Size = new System.Drawing.Size(75, 100);
            this.buttonDrowEdgeLine.TabIndex = 4;
            this.buttonDrowEdgeLine.Text = "Drow Edge";
            this.buttonDrowEdgeLine.UseVisualStyleBackColor = true;
            this.buttonDrowEdgeLine.Click += new System.EventHandler(this.buttonDrowEdgeLine_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(8, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1125, 1125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // labelStartMsg1
            // 
            this.labelStartMsg1.AutoSize = true;
            this.labelStartMsg1.BackColor = System.Drawing.Color.Gainsboro;
            this.labelStartMsg1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStartMsg1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelStartMsg1.Location = new System.Drawing.Point(20, 199);
            this.labelStartMsg1.Name = "labelStartMsg1";
            this.labelStartMsg1.Size = new System.Drawing.Size(872, 60);
            this.labelStartMsg1.TabIndex = 46;
            this.labelStartMsg1.Text = "画像ファイルをドラッグドロップまたは、";
            // 
            // labelStartMsg2
            // 
            this.labelStartMsg2.AutoSize = true;
            this.labelStartMsg2.BackColor = System.Drawing.Color.Gainsboro;
            this.labelStartMsg2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStartMsg2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelStartMsg2.Location = new System.Drawing.Point(28, 371);
            this.labelStartMsg2.Name = "labelStartMsg2";
            this.labelStartMsg2.Size = new System.Drawing.Size(641, 60);
            this.labelStartMsg2.TabIndex = 47;
            this.labelStartMsg2.Text = "Drag and Drop image file";
            // 
            // labelStartMsg4
            // 
            this.labelStartMsg4.AutoSize = true;
            this.labelStartMsg4.BackColor = System.Drawing.Color.Gainsboro;
            this.labelStartMsg4.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStartMsg4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelStartMsg4.Location = new System.Drawing.Point(28, 434);
            this.labelStartMsg4.Name = "labelStartMsg4";
            this.labelStartMsg4.Size = new System.Drawing.Size(795, 60);
            this.labelStartMsg4.TabIndex = 48;
            this.labelStartMsg4.Text = "or get image file from Clipbord.";
            // 
            // labelStartMsg3
            // 
            this.labelStartMsg3.AutoSize = true;
            this.labelStartMsg3.BackColor = System.Drawing.Color.Gainsboro;
            this.labelStartMsg3.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStartMsg3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelStartMsg3.Location = new System.Drawing.Point(20, 264);
            this.labelStartMsg3.Name = "labelStartMsg3";
            this.labelStartMsg3.Size = new System.Drawing.Size(877, 60);
            this.labelStartMsg3.TabIndex = 49;
            this.labelStartMsg3.Text = "クリップボードから画像を取得します。";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.labelStartMsg3);
            this.panel1.Controls.Add(this.labelStartMsg4);
            this.panel1.Controls.Add(this.labelStartMsg2);
            this.panel1.Controls.Add(this.labelStartMsg1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-1, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 754);
            this.panel1.TabIndex = 46;
            // 
            // buttonUndo
            // 
            this.buttonUndo.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonUndo.ForeColor = System.Drawing.Color.Red;
            this.buttonUndo.Location = new System.Drawing.Point(971, 770);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(80, 59);
            this.buttonUndo.TabIndex = 51;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1412, 833);
            this.Controls.Add(this.label_ImgSize);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.numericUpDownCutSketchDelay);
            this.Controls.Add(this.buttonSetImage2Clipboard);
            this.Controls.Add(this.buttonFileOpen);
            this.Controls.Add(this.buttonSnappingTool);
            this.Controls.Add(this.buttonGetClipbord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1430, 900);
            this.MinimumSize = new System.Drawing.Size(1430, 880);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Easy Retouch      *Ver.2025-09-21";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCutSketchDelay)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutputSize)).EndInit();
            this.groupBoxTransparent.ResumeLayout(false);
            this.groupBoxTransparent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransRed)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlurSize)).EndInit();
            this.groupBoxTrimming.ResumeLayout(false);
            this.groupBoxTrimming.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrimUp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLineWidth)).EndInit();
            this.groupBoxDrowMask.ResumeLayout(false);
            this.groupBoxDrowMask.PerformLayout();
            this.groupBoxDrowEdge.ResumeLayout(false);
            this.groupBoxDrowEdge.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSurroundLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetClipbord;
        private System.Windows.Forms.Button buttonSnappingTool;
        private System.Windows.Forms.Button buttonFileOpen;
        private System.Windows.Forms.Button buttonSetImage2Clipboard;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown numericUpDownCutSketchDelay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_ImgSize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelStartMsg1;
        private System.Windows.Forms.Label labelStartMsg2;
        private System.Windows.Forms.Label labelStartMsg4;
        private System.Windows.Forms.Label labelStartMsg3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDownOutputSize;
        private System.Windows.Forms.TextBox textBoxSuffix;
        private System.Windows.Forms.Label labelSuffix;
        private System.Windows.Forms.Button buttonTrapezoidalCorrect;
        private System.Windows.Forms.GroupBox groupBoxTransparent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownTransBlue;
        private System.Windows.Forms.NumericUpDown numericUpDownTransGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownTransRed;
        private System.Windows.Forms.CheckBox checkBoxTransparent;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonOutputPNG;
        private System.Windows.Forms.RadioButton radioButtonOutputJPG;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonRotate270deg;
        private System.Windows.Forms.Button buttonFlipX;
        private System.Windows.Forms.Button buttonRotate90deg;
        private System.Windows.Forms.Button buttonFlipY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownBlurSize;
        private System.Windows.Forms.Button buttonBlur;
        private System.Windows.Forms.GroupBox groupBoxTrimming;
        private System.Windows.Forms.Button buttonTrimingValueReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownTrimLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownTrimRight;
        private System.Windows.Forms.NumericUpDown numericUpDownTrimDown;
        private System.Windows.Forms.NumericUpDown numericUpDownTrimUp;
        private System.Windows.Forms.Button buttonTrimming;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownLineWidth;
        private System.Windows.Forms.RadioButton radioButtonSqLine_Black;
        private System.Windows.Forms.RadioButton radioButtonSqLine_Blue;
        private System.Windows.Forms.RadioButton radioButtonSqLine_Green;
        private System.Windows.Forms.Button buttonSquereLine;
        private System.Windows.Forms.RadioButton radioButtonSqLine_Yellow;
        private System.Windows.Forms.RadioButton radioButtonSqLine_Red;
        private System.Windows.Forms.GroupBox groupBoxDrowMask;
        private System.Windows.Forms.RadioButton radioButtonDrowMask_Black;
        private System.Windows.Forms.RadioButton radioButtonDrowMask_Blue;
        private System.Windows.Forms.RadioButton radioButtonDrowMask_Green;
        private System.Windows.Forms.Button buttonDrowMask;
        private System.Windows.Forms.RadioButton radioButtonDrowMask_Yellow;
        private System.Windows.Forms.RadioButton radioButtonDrowMask_Red;
        private System.Windows.Forms.GroupBox groupBoxDrowEdge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButtonDrowEdge_Blue;
        private System.Windows.Forms.RadioButton radioButtonDrowEdge_Black;
        private System.Windows.Forms.RadioButton radioButtonDrowEdge_Green;
        private System.Windows.Forms.RadioButton radioButtonDrowEdge_Yellow;
        private System.Windows.Forms.RadioButton radioButtonDrowEdge_Red;
        private System.Windows.Forms.NumericUpDown numericUpDownSurroundLineWidth;
        private System.Windows.Forms.Button buttonDrowEdgeLine;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
    }
}

