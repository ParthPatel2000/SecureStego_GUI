
namespace SecureStego
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Bar = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Panel();
            this.SendMenu = new System.Windows.Forms.Panel();
            this.CurrentBar1 = new System.Windows.Forms.Panel();
            this.BtnStegoImage = new System.Windows.Forms.Button();
            this.BtnKafka = new System.Windows.Forms.Button();
            this.BtnKey = new System.Windows.Forms.Button();
            this.BtnMessage = new System.Windows.Forms.Button();
            this.BtnImage = new System.Windows.Forms.Button();
            this.RecMenu = new System.Windows.Forms.Panel();
            this.CurrentBar2 = new System.Windows.Forms.Panel();
            this.BtnConsume = new System.Windows.Forms.Button();
            this.BtnKey2 = new System.Windows.Forms.Button();
            this.BtnRecMsg = new System.Windows.Forms.Button();
            this.BtnRecImg = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.BtnRec = new System.Windows.Forms.Button();
            this.HelpPanel = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.ImagePanel1 = new System.Windows.Forms.Panel();
            this.BtnSelImg1 = new System.Windows.Forms.Button();
            this.ImageBox1 = new System.Windows.Forms.PictureBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.MessagePanel1 = new System.Windows.Forms.Panel();
            this.BtnSaveMsg1 = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.MessageBox1 = new System.Windows.Forms.RichTextBox();
            this.Producer = new System.Windows.Forms.Panel();
            this.TopicBox1 = new System.Windows.Forms.RichTextBox();
            this.IpBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnOk1 = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Consumer = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.BtnSelStgImg = new System.Windows.Forms.Button();
            this.TopicBox2 = new System.Windows.Forms.RichTextBox();
            this.IpBox2 = new System.Windows.Forms.RichTextBox();
            this.BtnOk2 = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.ImagePanel2 = new System.Windows.Forms.Panel();
            this.PicturePath2 = new System.Windows.Forms.Label();
            this.ImageBox2 = new System.Windows.Forms.PictureBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.KeyPanel2 = new System.Windows.Forms.Panel();
            this.ShowKey2 = new System.Windows.Forms.Button();
            this.KeyBox2 = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.BtnSaveKey2 = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.BtnSaveKey1 = new System.Windows.Forms.Button();
            this.KeyPanel1 = new System.Windows.Forms.Panel();
            this.ShowKey1 = new System.Windows.Forms.Button();
            this.KeyBox1 = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.MessagePanel2 = new System.Windows.Forms.Panel();
            this.BtnSaveMsg2 = new System.Windows.Forms.Button();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.Label13 = new System.Windows.Forms.Label();
            this.StegoImgPanel = new System.Windows.Forms.Panel();
            this.BtnDownStegoImage = new System.Windows.Forms.Button();
            this.DispStegoImg = new System.Windows.Forms.PictureBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Bar.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SendMenu.SuspendLayout();
            this.RecMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.HelpPanel.SuspendLayout();
            this.ImagePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox1)).BeginInit();
            this.MessagePanel1.SuspendLayout();
            this.Producer.SuspendLayout();
            this.Consumer.SuspendLayout();
            this.ImagePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox2)).BeginInit();
            this.KeyPanel2.SuspendLayout();
            this.KeyPanel1.SuspendLayout();
            this.MessagePanel2.SuspendLayout();
            this.AboutPanel.SuspendLayout();
            this.StegoImgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DispStegoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // Bar
            // 
            this.Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.Bar.Controls.Add(this.Back);
            this.Bar.Controls.Add(this.btnMin);
            this.Bar.Controls.Add(this.btnCancel);
            resources.ApplyResources(this.Bar, "Bar");
            this.Bar.Name = "Bar";
            this.Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bar_MouseDown);
            this.Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bar_MouseMove);
            this.Bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bar_MouseUp);
            // 
            // Back
            // 
            this.Back.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Back, "Back");
            this.Back.ForeColor = System.Drawing.Color.Transparent;
            this.Back.Name = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            this.Back.MouseHover += new System.EventHandler(this.Back_MouseHover);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnMin, "btnMin");
            this.btnMin.ForeColor = System.Drawing.Color.Transparent;
            this.btnMin.Name = "btnMin";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            this.btnMin.MouseHover += new System.EventHandler(this.BtnMin_MouseHover);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            this.btnCancel.MouseHover += new System.EventHandler(this.BtnCancel_MouseHover);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Menu.Controls.Add(this.SendMenu);
            this.Menu.Controls.Add(this.RecMenu);
            this.Menu.Controls.Add(this.Logo);
            this.Menu.Controls.Add(this.BtnAbout);
            this.Menu.Controls.Add(this.BtnSend);
            this.Menu.Controls.Add(this.BtnRec);
            this.Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.Menu, "Menu");
            this.Menu.Name = "Menu";
            // 
            // SendMenu
            // 
            this.SendMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.SendMenu.Controls.Add(this.CurrentBar1);
            this.SendMenu.Controls.Add(this.BtnStegoImage);
            this.SendMenu.Controls.Add(this.BtnKafka);
            this.SendMenu.Controls.Add(this.BtnKey);
            this.SendMenu.Controls.Add(this.BtnMessage);
            this.SendMenu.Controls.Add(this.BtnImage);
            resources.ApplyResources(this.SendMenu, "SendMenu");
            this.SendMenu.Name = "SendMenu";
            // 
            // CurrentBar1
            // 
            this.CurrentBar1.BackColor = System.Drawing.Color.GreenYellow;
            resources.ApplyResources(this.CurrentBar1, "CurrentBar1");
            this.CurrentBar1.Name = "CurrentBar1";
            // 
            // BtnStegoImage
            // 
            this.BtnStegoImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.BtnStegoImage.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnStegoImage, "BtnStegoImage");
            this.BtnStegoImage.FlatAppearance.BorderSize = 0;
            this.BtnStegoImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.BtnStegoImage.Name = "BtnStegoImage";
            this.BtnStegoImage.UseVisualStyleBackColor = false;
            this.BtnStegoImage.Click += new System.EventHandler(this.BtnStegoImage_Click);
            // 
            // BtnKafka
            // 
            this.BtnKafka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.BtnKafka.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnKafka, "BtnKafka");
            this.BtnKafka.FlatAppearance.BorderSize = 0;
            this.BtnKafka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.BtnKafka.Name = "BtnKafka";
            this.BtnKafka.UseVisualStyleBackColor = false;
            this.BtnKafka.Click += new System.EventHandler(this.BtnKafka_Click);
            // 
            // BtnKey
            // 
            this.BtnKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.BtnKey.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnKey, "BtnKey");
            this.BtnKey.FlatAppearance.BorderSize = 0;
            this.BtnKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.BtnKey.Name = "BtnKey";
            this.BtnKey.UseVisualStyleBackColor = false;
            this.BtnKey.Click += new System.EventHandler(this.BtnKey_Click);
            // 
            // BtnMessage
            // 
            this.BtnMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.BtnMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnMessage, "BtnMessage");
            this.BtnMessage.FlatAppearance.BorderSize = 0;
            this.BtnMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.BtnMessage.Name = "BtnMessage";
            this.BtnMessage.UseVisualStyleBackColor = false;
            this.BtnMessage.Click += new System.EventHandler(this.BtnMessage_Click);
            // 
            // BtnImage
            // 
            this.BtnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.BtnImage.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnImage, "BtnImage");
            this.BtnImage.FlatAppearance.BorderSize = 0;
            this.BtnImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.UseVisualStyleBackColor = false;
            this.BtnImage.Click += new System.EventHandler(this.BtnImage_Click);
            // 
            // RecMenu
            // 
            this.RecMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.RecMenu.Controls.Add(this.CurrentBar2);
            this.RecMenu.Controls.Add(this.BtnConsume);
            this.RecMenu.Controls.Add(this.BtnKey2);
            this.RecMenu.Controls.Add(this.BtnRecMsg);
            this.RecMenu.Controls.Add(this.BtnRecImg);
            resources.ApplyResources(this.RecMenu, "RecMenu");
            this.RecMenu.Name = "RecMenu";
            // 
            // CurrentBar2
            // 
            this.CurrentBar2.BackColor = System.Drawing.Color.GreenYellow;
            resources.ApplyResources(this.CurrentBar2, "CurrentBar2");
            this.CurrentBar2.Name = "CurrentBar2";
            // 
            // BtnConsume
            // 
            this.BtnConsume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConsume.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnConsume, "BtnConsume");
            this.BtnConsume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.BtnConsume.Name = "BtnConsume";
            this.BtnConsume.UseVisualStyleBackColor = true;
            this.BtnConsume.Click += new System.EventHandler(this.BtnConsume_Click);
            // 
            // BtnKey2
            // 
            this.BtnKey2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnKey2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnKey2, "BtnKey2");
            this.BtnKey2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.BtnKey2.Name = "BtnKey2";
            this.BtnKey2.UseVisualStyleBackColor = true;
            this.BtnKey2.Click += new System.EventHandler(this.BtnKey2_Click);
            // 
            // BtnRecMsg
            // 
            this.BtnRecMsg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRecMsg.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnRecMsg, "BtnRecMsg");
            this.BtnRecMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.BtnRecMsg.Name = "BtnRecMsg";
            this.BtnRecMsg.UseVisualStyleBackColor = true;
            this.BtnRecMsg.Click += new System.EventHandler(this.BtnRecMsg_Click);
            // 
            // BtnRecImg
            // 
            this.BtnRecImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRecImg.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnRecImg, "BtnRecImg");
            this.BtnRecImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.BtnRecImg.Name = "BtnRecImg";
            this.BtnRecImg.UseVisualStyleBackColor = true;
            this.BtnRecImg.Click += new System.EventHandler(this.BtnRecImg_Click);
            // 
            // Logo
            // 
            this.Logo.Cursor = System.Windows.Forms.Cursors.No;
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            // 
            // BtnAbout
            // 
            this.BtnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnAbout, "BtnAbout");
            this.BtnAbout.FlatAppearance.BorderSize = 0;
            this.BtnAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(167)))), ((int)(((byte)(108)))));
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnSend
            // 
            this.BtnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSend.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnSend, "BtnSend");
            this.BtnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(61)))));
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // BtnRec
            // 
            this.BtnRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRec.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.BtnRec, "BtnRec");
            this.BtnRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(61)))));
            this.BtnRec.Name = "BtnRec";
            this.BtnRec.UseVisualStyleBackColor = true;
            this.BtnRec.Click += new System.EventHandler(this.BtnRec_Click);
            // 
            // HelpPanel
            // 
            this.HelpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this.HelpPanel, "HelpPanel");
            this.HelpPanel.Controls.Add(this.Label1);
            this.HelpPanel.Name = "HelpPanel";
            // 
            // Label1
            // 
            resources.ApplyResources(this.Label1, "Label1");
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.Label1.Name = "Label1";
            // 
            // ImagePanel1
            // 
            this.ImagePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(61)))));
            this.ImagePanel1.Controls.Add(this.BtnSelImg1);
            this.ImagePanel1.Controls.Add(this.ImageBox1);
            this.ImagePanel1.Controls.Add(this.Label2);
            resources.ApplyResources(this.ImagePanel1, "ImagePanel1");
            this.ImagePanel1.Name = "ImagePanel1";
            // 
            // BtnSelImg1
            // 
            this.BtnSelImg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.BtnSelImg1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnSelImg1, "BtnSelImg1");
            this.BtnSelImg1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.BtnSelImg1.Name = "BtnSelImg1";
            this.BtnSelImg1.UseVisualStyleBackColor = false;
            this.BtnSelImg1.Click += new System.EventHandler(this.BtnSelImg1_Click);
            // 
            // ImageBox1
            // 
            this.ImageBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(243)))), ((int)(((byte)(206)))));
            this.ImageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ImageBox1, "ImageBox1");
            this.ImageBox1.Name = "ImageBox1";
            this.ImageBox1.TabStop = false;
            // 
            // Label2
            // 
            resources.ApplyResources(this.Label2, "Label2");
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.Label2.Name = "Label2";
            // 
            // MessagePanel1
            // 
            this.MessagePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(61)))));
            this.MessagePanel1.Controls.Add(this.BtnSaveMsg1);
            this.MessagePanel1.Controls.Add(this.Label3);
            this.MessagePanel1.Controls.Add(this.MessageBox1);
            resources.ApplyResources(this.MessagePanel1, "MessagePanel1");
            this.MessagePanel1.Name = "MessagePanel1";
            // 
            // BtnSaveMsg1
            // 
            this.BtnSaveMsg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.BtnSaveMsg1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnSaveMsg1, "BtnSaveMsg1");
            this.BtnSaveMsg1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.BtnSaveMsg1.Name = "BtnSaveMsg1";
            this.BtnSaveMsg1.UseVisualStyleBackColor = false;
            this.BtnSaveMsg1.Click += new System.EventHandler(this.BtnSaveMsg1_Click);
            // 
            // Label3
            // 
            resources.ApplyResources(this.Label3, "Label3");
            this.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.Label3.Name = "Label3";
            // 
            // MessageBox1
            // 
            this.MessageBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.MessageBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.MessageBox1, "MessageBox1");
            this.MessageBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.MessageBox1.Name = "MessageBox1";
            // 
            // Producer
            // 
            this.Producer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(61)))));
            this.Producer.Controls.Add(this.TopicBox1);
            this.Producer.Controls.Add(this.IpBox1);
            this.Producer.Controls.Add(this.BtnOk1);
            this.Producer.Controls.Add(this.Label5);
            this.Producer.Controls.Add(this.Label6);
            resources.ApplyResources(this.Producer, "Producer");
            this.Producer.Name = "Producer";
            // 
            // TopicBox1
            // 
            this.TopicBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.TopicBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.TopicBox1, "TopicBox1");
            this.TopicBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.TopicBox1.Name = "TopicBox1";
            // 
            // IpBox1
            // 
            this.IpBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.IpBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.IpBox1, "IpBox1");
            this.IpBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.IpBox1.Name = "IpBox1";
            // 
            // BtnOk1
            // 
            this.BtnOk1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.BtnOk1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnOk1, "BtnOk1");
            this.BtnOk1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.BtnOk1.Name = "BtnOk1";
            this.BtnOk1.UseVisualStyleBackColor = false;
            this.BtnOk1.Click += new System.EventHandler(this.BtnOk1_Click);
            // 
            // Label5
            // 
            resources.ApplyResources(this.Label5, "Label5");
            this.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.Label5.Name = "Label5";
            // 
            // Label6
            // 
            resources.ApplyResources(this.Label6, "Label6");
            this.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.Label6.Name = "Label6";
            // 
            // Consumer
            // 
            this.Consumer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(61)))));
            this.Consumer.Controls.Add(this.label18);
            this.Consumer.Controls.Add(this.BtnSelStgImg);
            this.Consumer.Controls.Add(this.TopicBox2);
            this.Consumer.Controls.Add(this.IpBox2);
            this.Consumer.Controls.Add(this.BtnOk2);
            this.Consumer.Controls.Add(this.Label7);
            this.Consumer.Controls.Add(this.Label8);
            resources.ApplyResources(this.Consumer, "Consumer");
            this.Consumer.Name = "Consumer";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.label18.Name = "label18";
            // 
            // BtnSelStgImg
            // 
            this.BtnSelStgImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.BtnSelStgImg.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnSelStgImg, "BtnSelStgImg");
            this.BtnSelStgImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.BtnSelStgImg.Name = "BtnSelStgImg";
            this.BtnSelStgImg.UseVisualStyleBackColor = false;
            this.BtnSelStgImg.Click += new System.EventHandler(this.BtnSelStgImg_Click);
            // 
            // TopicBox2
            // 
            this.TopicBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.TopicBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.TopicBox2, "TopicBox2");
            this.TopicBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.TopicBox2.Name = "TopicBox2";
            // 
            // IpBox2
            // 
            this.IpBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.IpBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.IpBox2, "IpBox2");
            this.IpBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.IpBox2.Name = "IpBox2";
            // 
            // BtnOk2
            // 
            this.BtnOk2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.BtnOk2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnOk2, "BtnOk2");
            this.BtnOk2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.BtnOk2.Name = "BtnOk2";
            this.BtnOk2.UseVisualStyleBackColor = false;
            this.BtnOk2.Click += new System.EventHandler(this.BtnOk2_Click);
            // 
            // Label7
            // 
            resources.ApplyResources(this.Label7, "Label7");
            this.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.Label7.Name = "Label7";
            // 
            // Label8
            // 
            resources.ApplyResources(this.Label8, "Label8");
            this.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.Label8.Name = "Label8";
            // 
            // ImagePanel2
            // 
            this.ImagePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(61)))));
            this.ImagePanel2.Controls.Add(this.PicturePath2);
            this.ImagePanel2.Controls.Add(this.ImageBox2);
            this.ImagePanel2.Controls.Add(this.Label10);
            resources.ApplyResources(this.ImagePanel2, "ImagePanel2");
            this.ImagePanel2.Name = "ImagePanel2";
            // 
            // PicturePath2
            // 
            resources.ApplyResources(this.PicturePath2, "PicturePath2");
            this.PicturePath2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(101)))), ((int)(((byte)(47)))));
            this.PicturePath2.Name = "PicturePath2";
            // 
            // ImageBox2
            // 
            this.ImageBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.ImageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ImageBox2, "ImageBox2");
            this.ImageBox2.Name = "ImageBox2";
            this.ImageBox2.TabStop = false;
            // 
            // Label10
            // 
            resources.ApplyResources(this.Label10, "Label10");
            this.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.Label10.Name = "Label10";
            // 
            // KeyPanel2
            // 
            this.KeyPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(61)))));
            this.KeyPanel2.Controls.Add(this.ShowKey2);
            this.KeyPanel2.Controls.Add(this.KeyBox2);
            this.KeyPanel2.Controls.Add(this.Label14);
            this.KeyPanel2.Controls.Add(this.BtnSaveKey2);
            this.KeyPanel2.Controls.Add(this.Label9);
            resources.ApplyResources(this.KeyPanel2, "KeyPanel2");
            this.KeyPanel2.Name = "KeyPanel2";
            // 
            // ShowKey2
            // 
            this.ShowKey2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.ShowKey2.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ShowKey2, "ShowKey2");
            this.ShowKey2.Name = "ShowKey2";
            this.ShowKey2.UseVisualStyleBackColor = false;
            this.ShowKey2.Click += new System.EventHandler(this.ShowKey2_Click);
            // 
            // KeyBox2
            // 
            this.KeyBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.KeyBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.KeyBox2, "KeyBox2");
            this.KeyBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.KeyBox2.Name = "KeyBox2";
            // 
            // Label14
            // 
            resources.ApplyResources(this.Label14, "Label14");
            this.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label14.Name = "Label14";
            // 
            // BtnSaveKey2
            // 
            this.BtnSaveKey2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.BtnSaveKey2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnSaveKey2, "BtnSaveKey2");
            this.BtnSaveKey2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.BtnSaveKey2.Name = "BtnSaveKey2";
            this.BtnSaveKey2.UseVisualStyleBackColor = false;
            this.BtnSaveKey2.Click += new System.EventHandler(this.BtnSaveKey2_Click);
            // 
            // Label9
            // 
            resources.ApplyResources(this.Label9, "Label9");
            this.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.Label9.Name = "Label9";
            // 
            // Label4
            // 
            resources.ApplyResources(this.Label4, "Label4");
            this.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.Label4.Name = "Label4";
            // 
            // BtnSaveKey1
            // 
            this.BtnSaveKey1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.BtnSaveKey1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnSaveKey1, "BtnSaveKey1");
            this.BtnSaveKey1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.BtnSaveKey1.Name = "BtnSaveKey1";
            this.BtnSaveKey1.UseVisualStyleBackColor = false;
            this.BtnSaveKey1.Click += new System.EventHandler(this.BtnSaveKey1_Click);
            // 
            // KeyPanel1
            // 
            this.KeyPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(61)))));
            this.KeyPanel1.Controls.Add(this.ShowKey1);
            this.KeyPanel1.Controls.Add(this.KeyBox1);
            this.KeyPanel1.Controls.Add(this.Label17);
            this.KeyPanel1.Controls.Add(this.BtnSaveKey1);
            this.KeyPanel1.Controls.Add(this.Label4);
            resources.ApplyResources(this.KeyPanel1, "KeyPanel1");
            this.KeyPanel1.Name = "KeyPanel1";
            // 
            // ShowKey1
            // 
            this.ShowKey1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.ShowKey1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ShowKey1, "ShowKey1");
            this.ShowKey1.Name = "ShowKey1";
            this.ShowKey1.UseVisualStyleBackColor = false;
            this.ShowKey1.Click += new System.EventHandler(this.ShowKey1_Click);
            // 
            // KeyBox1
            // 
            this.KeyBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.KeyBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.KeyBox1, "KeyBox1");
            this.KeyBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.KeyBox1.Name = "KeyBox1";
            // 
            // Label17
            // 
            resources.ApplyResources(this.Label17, "Label17");
            this.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Label17.Name = "Label17";
            // 
            // MessagePanel2
            // 
            this.MessagePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(61)))));
            this.MessagePanel2.Controls.Add(this.BtnSaveMsg2);
            this.MessagePanel2.Controls.Add(this.Label12);
            this.MessagePanel2.Controls.Add(this.Label11);
            resources.ApplyResources(this.MessagePanel2, "MessagePanel2");
            this.MessagePanel2.Name = "MessagePanel2";
            // 
            // BtnSaveMsg2
            // 
            this.BtnSaveMsg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.BtnSaveMsg2.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnSaveMsg2, "BtnSaveMsg2");
            this.BtnSaveMsg2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.BtnSaveMsg2.Name = "BtnSaveMsg2";
            this.BtnSaveMsg2.UseVisualStyleBackColor = false;
            this.BtnSaveMsg2.Click += new System.EventHandler(this.BtnSaveMsg2_Click);
            // 
            // Label12
            // 
            resources.ApplyResources(this.Label12, "Label12");
            this.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(41)))));
            this.Label12.Name = "Label12";
            // 
            // Label11
            // 
            resources.ApplyResources(this.Label11, "Label11");
            this.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.Label11.Name = "Label11";
            // 
            // AboutPanel
            // 
            this.AboutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(61)))));
            resources.ApplyResources(this.AboutPanel, "AboutPanel");
            this.AboutPanel.Controls.Add(this.Label13);
            this.AboutPanel.Name = "AboutPanel";
            // 
            // Label13
            // 
            resources.ApplyResources(this.Label13, "Label13");
            this.Label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(61)))));
            this.Label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.Label13.Name = "Label13";
            // 
            // StegoImgPanel
            // 
            this.StegoImgPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(61)))));
            this.StegoImgPanel.Controls.Add(this.BtnDownStegoImage);
            this.StegoImgPanel.Controls.Add(this.DispStegoImg);
            this.StegoImgPanel.Controls.Add(this.Label16);
            resources.ApplyResources(this.StegoImgPanel, "StegoImgPanel");
            this.StegoImgPanel.Name = "StegoImgPanel";
            // 
            // BtnDownStegoImage
            // 
            this.BtnDownStegoImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.BtnDownStegoImage.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnDownStegoImage, "BtnDownStegoImage");
            this.BtnDownStegoImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.BtnDownStegoImage.Name = "BtnDownStegoImage";
            this.BtnDownStegoImage.UseVisualStyleBackColor = false;
            this.BtnDownStegoImage.Click += new System.EventHandler(this.BtnDownStegoImage_Click);
            // 
            // DispStegoImg
            // 
            this.DispStegoImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.DispStegoImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.DispStegoImg, "DispStegoImg");
            this.DispStegoImg.Name = "DispStegoImg";
            this.DispStegoImg.TabStop = false;
            // 
            // Label16
            // 
            resources.ApplyResources(this.Label16, "Label16");
            this.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(0)))), ((int)(((byte)(38)))));
            this.Label16.Name = "Label16";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(9)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.StegoImgPanel);
            this.Controls.Add(this.AboutPanel);
            this.Controls.Add(this.MessagePanel2);
            this.Controls.Add(this.KeyPanel2);
            this.Controls.Add(this.ImagePanel2);
            this.Controls.Add(this.Consumer);
            this.Controls.Add(this.Producer);
            this.Controls.Add(this.KeyPanel1);
            this.Controls.Add(this.MessagePanel1);
            this.Controls.Add(this.ImagePanel1);
            this.Controls.Add(this.HelpPanel);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Bar.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.SendMenu.ResumeLayout(false);
            this.RecMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.HelpPanel.ResumeLayout(false);
            this.HelpPanel.PerformLayout();
            this.ImagePanel1.ResumeLayout(false);
            this.ImagePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox1)).EndInit();
            this.MessagePanel1.ResumeLayout(false);
            this.MessagePanel1.PerformLayout();
            this.Producer.ResumeLayout(false);
            this.Producer.PerformLayout();
            this.Consumer.ResumeLayout(false);
            this.Consumer.PerformLayout();
            this.ImagePanel2.ResumeLayout(false);
            this.ImagePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox2)).EndInit();
            this.KeyPanel2.ResumeLayout(false);
            this.KeyPanel2.PerformLayout();
            this.KeyPanel1.ResumeLayout(false);
            this.KeyPanel1.PerformLayout();
            this.MessagePanel2.ResumeLayout(false);
            this.MessagePanel2.PerformLayout();
            this.AboutPanel.ResumeLayout(false);
            this.AboutPanel.PerformLayout();
            this.StegoImgPanel.ResumeLayout(false);
            this.StegoImgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DispStegoImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Bar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button BtnRec;
        private System.Windows.Forms.Panel SendMenu;
        private System.Windows.Forms.Button BtnMessage;
        private System.Windows.Forms.Button BtnImage;
        private System.Windows.Forms.Button BtnKafka;
        private System.Windows.Forms.Button BtnKey;
        private System.Windows.Forms.Panel RecMenu;
        private System.Windows.Forms.Button BtnConsume;
        private System.Windows.Forms.Button BtnKey2;
        private System.Windows.Forms.Button BtnRecMsg;
        private System.Windows.Forms.Button BtnRecImg;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Panel HelpPanel;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel ImagePanel1;
        private System.Windows.Forms.Button BtnSelImg1;
        private System.Windows.Forms.PictureBox ImageBox1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Panel MessagePanel1;
        private System.Windows.Forms.Button BtnSaveMsg1;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.RichTextBox MessageBox1;
        private System.Windows.Forms.Panel Producer;
        private System.Windows.Forms.RichTextBox TopicBox1;
        private System.Windows.Forms.RichTextBox IpBox1;
        private System.Windows.Forms.Button BtnOk1;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Panel Consumer;
        private System.Windows.Forms.RichTextBox TopicBox2;
        private System.Windows.Forms.RichTextBox IpBox2;
        private System.Windows.Forms.Button BtnOk2;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Panel ImagePanel2;
        private System.Windows.Forms.Label PicturePath2;
        private System.Windows.Forms.PictureBox ImageBox2;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Panel KeyPanel2;
        private System.Windows.Forms.Button BtnSaveKey2;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Button BtnSaveKey1;
        private System.Windows.Forms.Panel KeyPanel1;
        private System.Windows.Forms.Panel MessagePanel2;
        private System.Windows.Forms.Label Label12;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.Label Label13;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.Button BtnSaveMsg2;
        private System.Windows.Forms.Button BtnStegoImage;
        private System.Windows.Forms.Panel StegoImgPanel;
        private System.Windows.Forms.Button BtnDownStegoImage;
        private System.Windows.Forms.PictureBox DispStegoImg;
        private System.Windows.Forms.Label Label16;
        private System.Windows.Forms.Panel CurrentBar1;
        private System.Windows.Forms.Panel CurrentBar2;
        private System.Windows.Forms.Label Label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button BtnSelStgImg;
        private System.Windows.Forms.TextBox KeyBox1;
        private System.Windows.Forms.Button ShowKey1;
        private System.Windows.Forms.TextBox KeyBox2;
        private System.Windows.Forms.Button ShowKey2;
    }
}

