using System;
using System.Diagnostics;
using System.IO;

namespace image_overlay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // select a file
            OpenFileDialog openFileDialogImage = new OpenFileDialog();

            //openFileDialogImage.InitialDirectory = "c:\\";
            openFileDialogImage.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
            openFileDialogImage.FilterIndex = 2;
            openFileDialogImage.RestoreDirectory = true;

            //get image path
            if (openFileDialogImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileImagePath = openFileDialogImage.FileName;
                labelImagePath.Text = "Image path [" + (fileImagePath) + "]";
                
                //! get more image info like widthg and high
                System.Drawing.Image imgDimensions = System.Drawing.Image.FromFile(fileImagePath);
                //! MessageBox.Show("Width: " + imgDimensions.Width + ", Height: " + imgDimensions.Height);
                string imageWidth = Convert.ToString(imgDimensions.Width);
                string imageHeight = Convert.ToString(imgDimensions.Height);

                //! print image info
                labelimageWidth.Text = ("image Weight :" + (imageWidth));
                labelImageHight.Text = ("Image Hight :" +(imageHeight));
                string compileOutput = ("[Rainmeter]\r\nUpdate=-1\r\n\r\n[MeterName]\r\nMeter=Image\r\nImageName=" + (fileImagePath) + "\r\nH=" + (imageHeight) + "\r\nW=" + (imageWidth) + "\r\nPreserveAspectRatio=1");
                richTextBox_compileOutput.Text = (compileOutput);

                //! compile it to *ini file
                
                
                //string RainMetterLocation = (System.IO.File.ReadAllText(@""));
                //string softwDirectory = Environment.CurrentDirectory;
                string appDirectory = Directory.GetCurrentDirectory(); //get app location



                //richTextBox_compileOutput.AppendText(appDirectory);
                //File.WriteAllText(@"C:\your_path\your_file", (compileOutput));

                string MyDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); //loock at decoumont folder
                string subFolderRainMeterPath = ((MyDocumentsPath) + (@"\Rainmeter\Skins\tst\tst1.ini"));




               System.IO.File.WriteAllText((subFolderRainMeterPath), (compileOutput));

                Process CmdRun = new Process();
                // Redirect the output stream of the child process.
                CmdRun.StartInfo.UseShellExecute = false;
                CmdRun.StartInfo.RedirectStandardOutput = true;
                CmdRun.StartInfo.FileName = @"C:\Users\max\Documents\Github_Unbreakable\readme-tools\image-overlay\Rainmeter-refresh.bat";
                CmdRun.Start();
                // Read the output stream first and then wait.
                //string output = CmdRun.StandardOutput.ReadToEnd();
                // CmdRun.WaitForExit();


                // cmd /c "cd /d C:\Program Files\Rainmeter && "Rainmeter.exe" !RefreshApp"

                //stem.Diagnostics.Process.Start("CMD.exe", "");

                /*
                string strCmdText;
                strCmdText = "cd /d C:\\Program Files\\Rainmeter && \"Rainmeter.exe\" !RefreshApp";
                System.Diagnostics.Process.Start("CMD.exe", strCmdText);
                






                var proc1 = new ProcessStartInfo();
                string anyCommand = @"cd /d C:\Program Files\Rainmeter && ""Rainmeter.exe"" !RefreshApp";
                proc1.UseShellExecute = true;
                proc1.WorkingDirectory = @"C:\Windows\System32";

                proc1.FileName = @"C:\Windows\System32\cmd.exe";
                proc1.Verb = "runas";
                proc1.Arguments = "/c " + anyCommand;
                proc1.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(proc1);
                */


            }






        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelimageWidth_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelImageHight_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}