namespace FaceRecognitionSystem
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skincbxnumber = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.btnsave = new CCWin.SkinControl.SkinButton();
            this.picbPreview = new AForge.Controls.PictureBox();
            this.vispShoot = new AForge.Controls.VideoSourcePlayer();
            this.btnPhotograph = new CCWin.SkinControl.SkinButton();
            this.btnShoot = new CCWin.SkinControl.SkinButton();
            this.btnConnect = new CCWin.SkinControl.SkinButton();
            this.skincbxRP = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skincbxCamera = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.skinComboBox1 = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox2 = new CCWin.SkinControl.SkinComboBox();
            this.skinTabControl1.SuspendLayout();
            this.skinTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.skinTabPage1);
            this.skinTabControl1.Controls.Add(this.skinTabPage2);
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(7, 35);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(1720, 896);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 0;
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.White;
            this.skinTabPage1.Controls.Add(this.skinComboBox2);
            this.skinTabPage1.Controls.Add(this.skinLabel7);
            this.skinTabPage1.Controls.Add(this.skinLabel6);
            this.skinTabPage1.Controls.Add(this.skinComboBox1);
            this.skinTabPage1.Controls.Add(this.skinLabel5);
            this.skinTabPage1.Controls.Add(this.textBox2);
            this.skinTabPage1.Controls.Add(this.skinButton2);
            this.skinTabPage1.Controls.Add(this.skincbxnumber);
            this.skinTabPage1.Controls.Add(this.skinLabel4);
            this.skinTabPage1.Controls.Add(this.textBox1);
            this.skinTabPage1.Controls.Add(this.skinLabel3);
            this.skinTabPage1.Controls.Add(this.skinButton1);
            this.skinTabPage1.Controls.Add(this.btnsave);
            this.skinTabPage1.Controls.Add(this.picbPreview);
            this.skinTabPage1.Controls.Add(this.vispShoot);
            this.skinTabPage1.Controls.Add(this.btnPhotograph);
            this.skinTabPage1.Controls.Add(this.btnShoot);
            this.skinTabPage1.Controls.Add(this.btnConnect);
            this.skinTabPage1.Controls.Add(this.skincbxRP);
            this.skinTabPage1.Controls.Add(this.skinLabel2);
            this.skinTabPage1.Controls.Add(this.skincbxCamera);
            this.skinTabPage1.Controls.Add(this.skinLabel1);
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(1720, 860);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = null;
            this.skinTabPage1.Text = "人脸检测";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("宋体", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(1499, 62);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(110, 16);
            this.skinLabel5.TabIndex = 29;
            this.skinLabel5.Text = "图像检测信息";
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.AcceptsTab = true;
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(1394, 86);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(313, 759);
            this.textBox2.TabIndex = 28;
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinButton2.Location = new System.Drawing.Point(1209, 264);
            this.skinButton2.MouseBack = null;
            this.skinButton2.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(79, 20);
            this.skinButton2.TabIndex = 27;
            this.skinButton2.Text = "选择图片";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skincbxnumber
            // 
            this.skincbxnumber.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skincbxnumber.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skincbxnumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skincbxnumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skincbxnumber.FormattingEnabled = true;
            this.skincbxnumber.ItemBorderColor = System.Drawing.Color.Blue;
            this.skincbxnumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.skincbxnumber.Location = new System.Drawing.Point(1258, 12);
            this.skincbxnumber.MouseColor = System.Drawing.Color.Blue;
            this.skincbxnumber.MouseGradientColor = System.Drawing.Color.Blue;
            this.skincbxnumber.Name = "skincbxnumber";
            this.skincbxnumber.Size = new System.Drawing.Size(115, 22);
            this.skincbxnumber.TabIndex = 26;
            this.skincbxnumber.WaterText = "";
            this.skincbxnumber.TextChanged += new System.EventHandler(this.skincbxnumber_TextChanged);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("宋体", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(1113, 15);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(153, 16);
            this.skinLabel4.TabIndex = 25;
            this.skinLabel4.Text = "检测人脸数量上限:";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(1119, 318);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(254, 527);
            this.textBox1.TabIndex = 24;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("宋体", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(1209, 296);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(76, 16);
            this.skinLabel3.TabIndex = 23;
            this.skinLabel3.Text = "检测信息";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinButton1.Location = new System.Drawing.Point(1301, 264);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(71, 20);
            this.skinButton1.TabIndex = 20;
            this.skinButton1.Text = " 检测";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnsave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnsave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnsave.DownBack = null;
            this.btnsave.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnsave.Location = new System.Drawing.Point(1119, 264);
            this.btnsave.MouseBack = null;
            this.btnsave.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnsave.Name = "btnsave";
            this.btnsave.NormlBack = null;
            this.btnsave.Size = new System.Drawing.Size(75, 20);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "录入数据库";
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // picbPreview
            // 
            this.picbPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picbPreview.Image = null;
            this.picbPreview.Location = new System.Drawing.Point(1119, 58);
            this.picbPreview.Name = "picbPreview";
            this.picbPreview.Size = new System.Drawing.Size(254, 162);
            this.picbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbPreview.TabIndex = 18;
            this.picbPreview.TabStop = false;
            // 
            // vispShoot
            // 
            this.vispShoot.Location = new System.Drawing.Point(19, 58);
            this.vispShoot.Name = "vispShoot";
            this.vispShoot.Size = new System.Drawing.Size(1078, 787);
            this.vispShoot.TabIndex = 17;
            this.vispShoot.Text = "videoSourcePlayer1";
            this.vispShoot.VideoSource = null;
            // 
            // btnPhotograph
            // 
            this.btnPhotograph.BackColor = System.Drawing.Color.Transparent;
            this.btnPhotograph.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnPhotograph.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnPhotograph.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnPhotograph.DownBack = null;
            this.btnPhotograph.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnPhotograph.Location = new System.Drawing.Point(756, 21);
            this.btnPhotograph.MouseBack = null;
            this.btnPhotograph.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnPhotograph.Name = "btnPhotograph";
            this.btnPhotograph.NormlBack = null;
            this.btnPhotograph.Size = new System.Drawing.Size(64, 20);
            this.btnPhotograph.TabIndex = 16;
            this.btnPhotograph.Text = "拍照";
            this.btnPhotograph.UseVisualStyleBackColor = false;
            this.btnPhotograph.Click += new System.EventHandler(this.btnPhotograph_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.BackColor = System.Drawing.Color.Transparent;
            this.btnShoot.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnShoot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnShoot.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnShoot.DownBack = null;
            this.btnShoot.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnShoot.Location = new System.Drawing.Point(648, 21);
            this.btnShoot.MouseBack = null;
            this.btnShoot.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.NormlBack = null;
            this.btnShoot.Size = new System.Drawing.Size(64, 20);
            this.btnShoot.TabIndex = 15;
            this.btnShoot.Text = "断开";
            this.btnShoot.UseVisualStyleBackColor = false;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnConnect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnConnect.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnConnect.DownBack = null;
            this.btnConnect.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnConnect.Location = new System.Drawing.Point(541, 21);
            this.btnConnect.MouseBack = null;
            this.btnConnect.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.NormlBack = null;
            this.btnConnect.Size = new System.Drawing.Size(64, 20);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // skincbxRP
            // 
            this.skincbxRP.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skincbxRP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skincbxRP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skincbxRP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skincbxRP.FormattingEnabled = true;
            this.skincbxRP.ItemBorderColor = System.Drawing.Color.Blue;
            this.skincbxRP.Location = new System.Drawing.Point(325, 18);
            this.skincbxRP.MouseColor = System.Drawing.Color.Blue;
            this.skincbxRP.MouseGradientColor = System.Drawing.Color.Blue;
            this.skincbxRP.Name = "skincbxRP";
            this.skincbxRP.Size = new System.Drawing.Size(159, 22);
            this.skincbxRP.TabIndex = 13;
            this.skincbxRP.WaterText = "";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("宋体", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(255, 21);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(68, 16);
            this.skinLabel2.TabIndex = 12;
            this.skinLabel2.Text = "分辨率:";
            // 
            // skincbxCamera
            // 
            this.skincbxCamera.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skincbxCamera.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skincbxCamera.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skincbxCamera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skincbxCamera.FormattingEnabled = true;
            this.skincbxCamera.ItemBorderColor = System.Drawing.Color.Blue;
            this.skincbxCamera.Location = new System.Drawing.Point(86, 17);
            this.skincbxCamera.MouseColor = System.Drawing.Color.Blue;
            this.skincbxCamera.MouseGradientColor = System.Drawing.Color.Blue;
            this.skincbxCamera.Name = "skincbxCamera";
            this.skincbxCamera.Size = new System.Drawing.Size(159, 22);
            this.skincbxCamera.TabIndex = 11;
            this.skincbxCamera.WaterText = "";
            this.skincbxCamera.SelectedIndexChanged += new System.EventHandler(this.skincbxCamera_SelectedIndexChanged);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("宋体", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(16, 19);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 16);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "摄像头:";
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.White;
            this.skinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage2.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Size = new System.Drawing.Size(1720, 860);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.TabItemImage = null;
            this.skinTabPage2.Text = "语音识别";
            // 
            // skinComboBox1
            // 
            this.skinComboBox1.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinComboBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox1.FormattingEnabled = true;
            this.skinComboBox1.ItemBorderColor = System.Drawing.Color.Blue;
            this.skinComboBox1.Items.AddRange(new object[] {
            "通用场景识别",
            "动物识别",
            "植物识别",
            "logo识别",
            "果蔬识别",
            "菜品识别"});
            this.skinComboBox1.Location = new System.Drawing.Point(1514, 9);
            this.skinComboBox1.MouseColor = System.Drawing.Color.Blue;
            this.skinComboBox1.MouseGradientColor = System.Drawing.Color.Blue;
            this.skinComboBox1.Name = "skinComboBox1";
            this.skinComboBox1.Size = new System.Drawing.Size(159, 22);
            this.skinComboBox1.TabIndex = 30;
            this.skinComboBox1.WaterText = "";
            this.skinComboBox1.SelectionChangeCommitted += new System.EventHandler(this.skinComboBox1_SelectionChangeCommitted);
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("宋体", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(1391, 11);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(85, 16);
            this.skinLabel6.TabIndex = 31;
            this.skinLabel6.Text = "识别类型:";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("宋体", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(1391, 43);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(119, 16);
            this.skinLabel7.TabIndex = 32;
            this.skinLabel7.Text = "返回词条数量:";
            // 
            // skinComboBox2
            // 
            this.skinComboBox2.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinComboBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox2.FormattingEnabled = true;
            this.skinComboBox2.ItemBorderColor = System.Drawing.Color.Blue;
            this.skinComboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.skinComboBox2.Location = new System.Drawing.Point(1514, 37);
            this.skinComboBox2.MouseColor = System.Drawing.Color.Blue;
            this.skinComboBox2.MouseGradientColor = System.Drawing.Color.Blue;
            this.skinComboBox2.Name = "skinComboBox2";
            this.skinComboBox2.Size = new System.Drawing.Size(159, 22);
            this.skinComboBox2.TabIndex = 33;
            this.skinComboBox2.WaterText = "";
            this.skinComboBox2.TextChanged += new System.EventHandler(this.skinComboBox2_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 937);
            this.Controls.Add(this.skinTabControl1);
            this.Name = "Main";
            this.Text = "人脸识别检测";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.skinTabControl1.ResumeLayout(false);
            this.skinTabPage1.ResumeLayout(false);
            this.skinTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage skinTabPage1;
        private CCWin.SkinControl.SkinTabPage skinTabPage2;
        private CCWin.SkinControl.SkinComboBox skincbxRP;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinComboBox skincbxCamera;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton btnPhotograph;
        private CCWin.SkinControl.SkinButton btnShoot;
        private CCWin.SkinControl.SkinButton btnConnect;
        private AForge.Controls.PictureBox picbPreview;
        private AForge.Controls.VideoSourcePlayer vispShoot;
        private CCWin.SkinControl.SkinButton btnsave;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private System.Windows.Forms.TextBox textBox1;
        private CCWin.SkinControl.SkinComboBox skincbxnumber;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinButton skinButton2;
        private System.Windows.Forms.TextBox textBox2;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinComboBox skinComboBox1;
        private CCWin.SkinControl.SkinComboBox skinComboBox2;
        private CCWin.SkinControl.SkinLabel skinLabel7;
    }
}