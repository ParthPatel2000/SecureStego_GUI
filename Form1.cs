using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;



namespace SecureStego
{
    public partial class Main : Form
    {
        //
        // Variables for rounded corners of window
        //
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,
           int nTopRect,
           int nRighttRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
           );


        //
        // Main function
        //
        public Main()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }


        //
        // Func for hiding panels which hides all panels when window created
        //
        public void HidePanels()
        {
            SendMenu.Visible = false;
            RecMenu.Visible = false;
            ImagePanel1.Visible = false;
            ImagePanel2.Visible = false;
            StegoImgPanel.Visible = false;
            MessagePanel1.Visible = false;
            MessagePanel2.Visible = false;
            KeyPanel1.Visible = false;
            KeyPanel2.Visible = false;
            Producer.Visible = false;
            Consumer.Visible = false;
            AboutPanel.Visible = false;
            BtnAbout.Visible = false;
            CurrentBar1.Visible = false;
            CurrentBar2.Visible = false;
        }


        //
        // Main_Load function loads window initially at first run
        //
        private void Main_Load(object sender, EventArgs e)
        {
            HidePanels();
            BtnAbout.Visible = true;
        }

        //
        // Nav Buttons
        //
        ToolTip t = new ToolTip();

        //
        // For dragging the window
        //
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        //
        // Drag bar
        //
        private void Bar_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }
        private void Bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
        private void Bar_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        //
        //  Back button in navbar
        //
        private void Back_Click(object sender, EventArgs e)
        {
            HidePanels();
            Menu.Visible = true;
            HelpPanel.Visible = true;
            BtnAbout.Visible = true;
        }

        private void Back_MouseHover(object sender, EventArgs e)
        {
            t.Show("Go to main menu", Back);
        }

        //  Minimize window button in navbar
        private void BtnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        //
        //  Close window button in navbar
        //
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        // Hover
        //
        private void BtnCancel_MouseHover(object sender, EventArgs e)
        {
            t.Show("Close", btnCancel);
        }

        private void BtnMin_MouseHover(object sender, EventArgs e)
        {
            t.Show("Minimize", btnMin);
        }

        //
        // Menu button functions
        //
        private void BtnAbout_Click(object sender, EventArgs e)
        {
            HidePanels();
            AboutPanel.Visible = true;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            HidePanels();
            SendMenu.Visible = true;
        }

        private void BtnRec_Click(object sender, EventArgs e)
        {
            HidePanels();
            RecMenu.Visible = true;
        }

        //
        // Function to change current bar1 style, current-bar is used here to show active window open 
        //
        private void ChangeCurrentBar1(Button x)
        {
            CurrentBar1.Height = x.Height;
            CurrentBar1.Top = x.Top;
            CurrentBar1.Left = x.Left;
            CurrentBar1.BackColor = Color.GreenYellow;
            CurrentBar1.Visible = true;
        }

        //
        // Send Menu functions
        //
        private void BtnImage_Click(object sender, EventArgs e)
        {
            HidePanels();
            SendMenu.Visible = true;
            ChangeCurrentBar1(BtnImage);
            ImagePanel1.Visible = true;
            ImagePanel1.Dock = DockStyle.Fill;
        }

        private void BtnMessage_Click(object sender, EventArgs e)
        {
            HidePanels();
            SendMenu.Visible = true;
            ChangeCurrentBar1(BtnMessage);
            MessagePanel1.Visible = true;
            MessagePanel1.Dock = DockStyle.Fill;
        }

        private void BtnKey_Click(object sender, EventArgs e)
        {
            HidePanels();
            SendMenu.Visible = true;
            ChangeCurrentBar1(BtnKey);
            KeyPanel1.Visible = true;
            KeyPanel1.Dock = DockStyle.Fill;
        }

        private void BtnStegoImage_Click(object sender, EventArgs e)
        {
            HidePanels();
            SendMenu.Visible = true;
            ChangeCurrentBar1(BtnStegoImage);
            StegoImgPanel.Visible = true;
            StegoImgPanel.Dock = DockStyle.Fill;
        }

        private void BtnKafka_Click(object sender, EventArgs e)
        {
            HidePanels();
            SendMenu.Visible = true;
            ChangeCurrentBar1(BtnKafka);
            Producer.Visible = true;
            Producer.Dock = DockStyle.Fill;
        }

        //
        // Function to change current bar2 style, current-bar is used here to show active window open
        //
        private void ChangeCurrentBar2(Button x)
        {
            CurrentBar2.Height = x.Height;
            CurrentBar2.Top = x.Top;
            CurrentBar2.Left = x.Left;
            CurrentBar2.BackColor = Color.GreenYellow;
            CurrentBar2.Visible = true;
        }

        //
        // Recieve Menu functions
        //
        private void BtnConsume_Click(object sender, EventArgs e)
        {
            HidePanels();
            RecMenu.Visible = true;
            Consumer.Visible = true;
            ChangeCurrentBar2(BtnConsume);
            Consumer.Dock = DockStyle.Fill;
        }

        private void BtnRecImg_Click(object sender, EventArgs e)
        {
            HidePanels();
            RecMenu.Visible = true;
            ChangeCurrentBar2(BtnRecImg);
            ImagePanel2.Visible = true;
            ImagePanel2.Dock = DockStyle.Fill;
        }

        private void BtnKey2_Click(object sender, EventArgs e)
        {
            HidePanels();
            RecMenu.Visible = true;
            ChangeCurrentBar2(BtnKey2);
            KeyPanel2.Visible = true;
            KeyPanel2.Dock = DockStyle.Fill;
        }

        private void BtnRecMsg_Click(object sender, EventArgs e)
        {
            HidePanels();
            RecMenu.Visible = true;
            ChangeCurrentBar2(BtnRecMsg);
            MessagePanel2.Visible = true;
            MessagePanel2.Dock = DockStyle.Fill;
        }

        //
        //  Function to run python scripts
        //
        private void RunScript(String fileName)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("cd D:\\College\\GUI\\Secure Stego FINAL\\SecureStegoBackEnd\\venv\\Scripts");  // Give path of your Scripts in venv
            // Change path accordingly from D:\\...\\GUI\\ with your drive or folder path
            cmd.StandardInput.Flush();
            cmd.StandardInput.WriteLine("activate.bat");
            cmd.StandardInput.Flush();
            cmd.StandardInput.WriteLine("cd ../../");
            cmd.StandardInput.Flush();
            cmd.StandardInput.WriteLine(fileName);
            cmd.StandardInput.Close();
            cmd.WaitForExit();
   
        }

        private int RunScript_returncode(String fileName, int line_no)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("cd D:\\College\\GUI\\Secure Stego FINAL\\SecureStegoBackEnd\\venv\\Scripts");  // Give path of your Scripts in venv
            // Change path accordingly from D:\\...\\GUI\\ with your drive or folder path
            cmd.StandardInput.Flush();
            cmd.StandardInput.WriteLine("activate.bat");
            cmd.StandardInput.Flush();
            cmd.StandardInput.WriteLine("cd ../../");
            cmd.StandardInput.Flush();
            cmd.StandardInput.WriteLine(fileName);

            String line="";
            for (int i = 0; i <= line_no; i++)
            {
                line = cmd.StandardOutput.ReadLine();
                if (i == line_no)
                {

                    Debug.Write(i);
                    Debug.Write(":");
                    Debug.WriteLine(line);
                }

            }
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            return Int16.Parse(line);

        }


        //
        //  Declaring all variables to store data
        //
        private String imagePath = "";      // stores path of image 
        private String message = "";        // stores user message
        private String key = "";            // stores user input key
        private String stegoPath = "";      // stores path of generated stego image
        private String ip = "";             // stores ip address
        private String topic = "";          // stores topic name


        //
        // Save input Producer side
        //
        private void SaveData()
        {
          
            string data = "environment:\n  cover_image: " + imagePath + "\n  receive_path: "+ stegoPath +"\n  send_path: ../Sender Data/ \nkafka:\n  bootstrap_servers: " + ip + "\n  topic: " + topic + "\nkey: " + key;
            var path = @"D:\College\GUI\Secure Stego FINAL\SecureStegoBackEnd\config.yaml";	// Give path of SecureStegoBackEnd and save a config.yaml
            // Change path accordingly from D:\../\GUI\ with your drive or folder path
            File.WriteAllText(path, data);
        }


        //
        // Producer Data Input button func's
        //
        private void BtnSelImg1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.PNG)|*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                ImageBox1.ImageLocation = imagePath;
            }
            SaveData();
        }

        private void BtnSaveMsg1_Click(object sender, EventArgs e)
        {
            message = MessageBox1.Text;
            var path = @"D:\College\GUI\Secure Stego FINAL\SecureStegoBackEnd\Message.txt";	// Give path of SecureStegoBackEnd and save Message.txt
            // Change path accordingly from D:\...\GUI\ with your drive or folder path
            File.WriteAllText(path, message);
        }

        private String pythonFileName = "";          // stores .py file name

        private void ShowKey1_Click(object sender, EventArgs e)
        {
            if (KeyBox1.PasswordChar == '*')
            {
                KeyBox1.PasswordChar = '\0';
            }
            else if (KeyBox1.PasswordChar == '\0')
            {
                KeyBox1.PasswordChar = '*';
            }
        }
        private void BtnSaveKey1_Click(object sender, EventArgs e)
        {
            key = KeyBox1.Text;
            SaveData();
            if (imagePath!="" && message!="" && key!="")
            {
                pythonFileName = "python insert.py";
                RunScript(pythonFileName);
                // Display at DispStegoImage box and stego image path to label 15
                stegoPath = @"D:\College\GUI\Secure Stego FINAL\Sender Data\stg.PNG"; // Save Stego Image to Path given
                // Change path accordingly from D:\...\GUI\ with your drive or folder path
                DispStegoImg.ImageLocation = stegoPath;
                BtnStegoImage.PerformClick();
            }
            else
            {
                if(imagePath == "")
                {
                    MessageBox.Show("Please Select A Image");
                }
                else if(MessageBox1.Text == "")
                {
                    MessageBox.Show("Please Enter A Message");
                }
                else if (KeyBox1.Text == "")
                {
                    MessageBox.Show("Please Enter A Key");
                }
            }
        }

        private void BtnDownStegoImage_Click(object sender, EventArgs e)
        {
            Label15.Text = "\tPath of saved stego picture is: \n" + stegoPath;
        }

        private void BtnOk1_Click(object sender, EventArgs e)
        {
            ip = IpBox1.Text;
            topic = TopicBox1.Text;
            SaveData();
            if (IpBox1.Text != "" && TopicBox1.Text != "")
            {
                pythonFileName = "python kafka_producer.py";
                RunScript(pythonFileName);
            }
            else
            {
                if (IpBox1.Text == "")
                {
                    MessageBox.Show("Please Enter IP address");
                }
                else if (TopicBox1.Text == "")
                {
                    MessageBox.Show("Please Enter Topic name");
                }
            }
        }

        //
        // RECIEVER SIDE
        //
        private void BtnOk2_Click(object sender, EventArgs e)
        {
            ip = IpBox2.Text;
            topic = TopicBox2.Text;
            stegoPath = @"D:\College\GUI\Secure Stego FINAL\Received Data\rec.PNG";
            SaveData();
            if (IpBox2.Text!="" && TopicBox2.Text!="")
            {
                pythonFileName = "python kafka_consumer.py";
                int return_code = RunScript_returncode(pythonFileName,12);
                Debug.Write("return_code: ");
                Debug.WriteLine(return_code);
                if(return_code == 0)
                {
                    MessageBox.Show("No new messages");
                }
            }
            else
            {
                if(IpBox2.Text == "")
                {
                    MessageBox.Show("Please Enter IP address");
                }
                else if(TopicBox2.Text == "")
                {
                    MessageBox.Show("Please Enter Topic name");
                }
            }
            // display recieved stego image
            
            ImageBox2.ImageLocation = @"D:/College/GUI/Secure Stego FINAL/Received Data/rec.PNG";	// Save Stego Image to SecureStegoBackEnd recieved from Kafka
            // Change path accordingly from D:\...\GUI\ with your drive or folder path
        }

        private void BtnSelStgImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG files(*.PNG)|*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                stegoPath = ofd.FileName;
                ImageBox2.ImageLocation = stegoPath;
            }
            BtnRecImg.PerformClick();
            SaveData();
        }

        private void BtnSaveImg2_Click(object sender, EventArgs e)
        {
            // display path of downloaded stego image
            //PicturePath2.Text = "Path of saved stego picture is: \n" + stegoPath ;
        }

        private void ShowKey2_Click(object sender, EventArgs e)
        {
            if (KeyBox2.PasswordChar == '*')
            {
                KeyBox2.PasswordChar = '\0';
            }
            else if (KeyBox2.PasswordChar == '\0')
            {
                KeyBox2.PasswordChar = '*';
            }
        }
        private void BtnSaveKey2_Click(object sender, EventArgs e)
        {
            key = KeyBox2.Text;
            SaveData();
            if (KeyBox2.Text != "")
            {
                // use key to decode and display to label 12
                pythonFileName = "python extract.py";
                int return_code = RunScript_returncode(pythonFileName,10);
                if(return_code == 1)
                {
                    var path = @"D:\College\GUI\Secure Stego FINAL\Received Data\recieved.txt";
                    // Change path accordingly from D:\...\GUI\ with your drive or folder path
                    Label12.Text = "The Message is saved to text file :\n at \n" + path;
                    BtnRecMsg.PerformClick();
                }
                else if(return_code == 0)
                {
                    MessageBox.Show("Wrong key, Please re-enter the correct key");
                }
                else
                {
                    MessageBox.Show("The Keylength should be between 4 and 56, Please re-enter the correct key");
                }
            }
            else
            {
                if (KeyBox2.Text == "")
                {
                    MessageBox.Show("Please Enter Key");
                }
            }
        }

        private void BtnSaveMsg2_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", @"D:\College\GUI\Secure Stego FINAL\Received Data\recieved.txt");
            // Change path accordingly from D:\...\GUI\ with your drive or folder path
        }

    }   
}