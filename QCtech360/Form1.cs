using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QCtech360
{
    public partial class Form1 : Form
    {
        private bool isZoomed = false;
        private Size originalSize;
        private Point originalLocation;
        private Control originalParent;
        private string modelFolder = @"C:\cacao\";
        private Process proc;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
     

            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;

            originalSize = pictureBox4.Size;
            originalLocation = pictureBox4.Location;
            originalParent = pictureBox4.Parent;



        }


        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {


            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {



                folderDialog.Description = "Select a folder";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Show selected folder path in label
                    textBox1.Text = folderDialog.SelectedPath;
                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel3.Visible = true;
            panel3.BringToFront();
            panel4.Visible = false;
            toolStripStatusLabel1.Text = "Prediction model in process...";
            EnabledPanelContents(panel1, false);
            if (demoToolStripMenuItem.Checked)
            {
                await Task.Delay(5000);

                panel4.Visible = true;
                panel4.BringToFront();
                toolStripStatusLabel1.Text = "Prediction Model Done....";
                EnabledPanelContents(panel1, true);
                MessageBox.Show("Prediction Model Done.", "Model Done :-)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string exePath = "";
                string picture_url = "";

                if (radioButton1.Checked)
                {
                    exePath = @"CacaoPredictionsOriginal.exe";
                }
                else if (radioButton2.Checked)
                {
                    exePath = @"CacaoPredictionsOriginal.exe";
                }
                else if (radioButton3.Checked)
                {
                    exePath = @"CacaoPredictionsOriginal.exe";
                }

                if (!string.IsNullOrEmpty(exePath))
                {


                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = modelFolder + exePath,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        RedirectStandardInput = true,
                        CreateNoWindow = true

                    };

                    proc = new Process();
                    proc.StartInfo = psi;

                    // Událost pro průběžný výstup
                    proc.OutputDataReceived += (s, ev) =>
                    {
                        if (!string.IsNullOrEmpty(ev.Data))
                        {
                            this.Invoke(new Action(() =>
                            {
                                textBox3.AppendText(ev.Data + Environment.NewLine);
                                picture_url = ev.Data;
                            }));
                        }
                    };
                  
                    // Událost pro chyby
                    proc.ErrorDataReceived += (s, ev) =>
                    {   
                        if (!string.IsNullOrEmpty(ev.Data))
                        {
                            this.Invoke(new Action(() =>
                            {
                                textBox3.AppendText(ev.Data + Environment.NewLine);
                                picture_url = ev.Data;
                               /*
                                try
                                {
                                    proc.StandardInput.WriteLine(); // posílá Enter
                                    proc.StandardInput.Flush();
                                }
                                catch (Exception ex)
                                {
                                    // může se hodit pro debugging
                                    Debug.WriteLine("Error writing to stdin: " + ex.Message);
                                }
                               */
                            }));
                        }
                    };

                    // Událost po ukončení procesu
                    proc.Exited += (s, ev) =>
                    {
                        this.Invoke(new Action(() =>
                        {
                            textBox3.AppendText(Environment.NewLine + "--- Process Done ---" + Environment.NewLine);
                            panel4.Visible = true;
                            panel4.BringToFront();
                            picture_url = picture_url.Substring(55);
                            pictureBox4.Image = Image.FromFile(picture_url);
                            // MessageBox.Show(picture_url);
                            toolStripStatusLabel1.Text = "Prediction Model Done....";
                            EnabledPanelContents(panel1, true);
                            MessageBox.Show("Prediction Model Done.", "Model Done :-)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }));
                    };

                    proc.EnableRaisingEvents = true;

                    proc.Start();
                    proc.BeginOutputReadLine();
                    proc.BeginErrorReadLine();

                }

                else
                {
                    MessageBox.Show("Model not selected.");
                }

            }



        }
        private void EnabledPanelContents(Panel panel, bool enabled)
        {
            foreach (Control ctrl in panel.Controls)
            {
                ctrl.Enabled = enabled;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void languanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            string folderPath = textBox2.Text;

            if (System.IO.Directory.Exists(folderPath))
            {
                System.Diagnostics.Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show("Folder not found: " + folderPath);
            }


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (!isZoomed)
            {
                this.Controls.Add(pictureBox4);
                pictureBox4.BringToFront();
                // zoom in 
                pictureBox4.Size = new Size(
                    (int)(originalSize.Width * 2),
                    (int)(originalSize.Height * 2)
                );

                int centerX = (this.ClientSize.Width - pictureBox4.Width) / 2;
                int centerY = (this.ClientSize.Height - pictureBox4.Height) / 2;
                pictureBox4.Location = new Point(centerX, centerY);
                pictureBox4.BringToFront();
                isZoomed = true;
            }
            else
            {
                // restore original
                originalParent.Controls.Add(pictureBox4);
                pictureBox4.Size = originalSize;
                pictureBox4.Location = originalLocation;
                isZoomed = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                Clipboard.SetText(textBox1.Text);
                MessageBox.Show("Copied to clipboard!", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Textbox is empty.");
            }


        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var url = "https://cacaotech.eu/docs/QCtech360-doc-www.pdf";

            try
            {
                // Needed on .NET Core to open with default browser
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't open the website: " + ex.Message);
            }
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var url = "https://cacaotech.eu/";

            try
            {
                // Needed on .NET Core to open with default browser
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't open the website: " + ex.Message);
            }

        }

        private void versioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string version = Application.ProductVersion; // auto app version
            string appName = Application.ProductName;    // app name from project
            string website = "https://www.cacaotech.eu";

            string message = $"{appName}\nVersion: {version}\n\nVisit our website:\n{website}";

            MessageBox.Show(message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {



                folderDialog.Description = "Select a folder";
                folderDialog.ShowNewFolderButton = true;

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // Show selected folder path in label
                    textBox1.Text = folderDialog.SelectedPath;
                }
            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string folderPath = textBox2.Text;

            if (System.IO.Directory.Exists(folderPath))
            {
                System.Diagnostics.Process.Start("explorer.exe", folderPath);
            }
            else
            {
                MessageBox.Show("Folder not found: " + folderPath);
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                Clipboard.SetText(textBox1.Text);
                MessageBox.Show("Copied to clipboard!", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Textbox is empty.");
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void oprtionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void demoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
