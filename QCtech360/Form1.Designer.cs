namespace QCtech360
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            process1 = new System.Diagnostics.Process();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button4 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label2 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            button2 = new Button();
            button5 = new Button();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            textBox2 = new TextBox();
            panel5 = new Panel();
            label7 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            imageList3 = new ImageList(components);
            imageList4 = new ImageList(components);
            pictureBox2 = new PictureBox();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            menuStrip1 = new MenuStrip();
            oprtionToolStripMenuItem = new ToolStripMenuItem();
            demoToolStripMenuItem = new ToolStripMenuItem();
            languanToolStripMenuItem = new ToolStripMenuItem();
            englishToolStripMenuItem = new ToolStripMenuItem();
            sssToolStripMenuItem = new ToolStripMenuItem();
            authorsToolStripMenuItem = new ToolStripMenuItem();
            versioToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UseCredentialsForNetworkingOnly = false;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            process1.Exited += process1_Exited;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 141);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 297);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(10, 220);
            button4.Margin = new Padding(2, 1, 2, 1);
            button4.Name = "button4";
            button4.Size = new Size(119, 22);
            button4.TabIndex = 12;
            button4.Text = "Choose folder";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(127, 246);
            button1.Name = "button1";
            button1.Size = new Size(218, 47);
            button1.TabIndex = 11;
            button1.Text = "Run Prediction Model";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(8, 195);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 10;
            label1.Text = "NIRS data";
            label1.Click += label1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 9.75F);
            textBox1.Location = new Point(134, 219);
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Horizontal;
            textBox1.Size = new Size(320, 25);
            textBox1.TabIndex = 9;
            textBox1.Text = "C:\\cacao\\data";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton6);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(8, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 168);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(11, 143);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(326, 23);
            radioButton6.TabIndex = 12;
            radioButton6.TabStop = true;
            radioButton6.Text = "Model 6: Cultivar Classification (Cacao Pulp )";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.CheckAlign = ContentAlignment.TopLeft;
            radioButton5.Location = new Point(11, 119);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(296, 23);
            radioButton5.TabIndex = 11;
            radioButton5.TabStop = true;
            radioButton5.Text = "Model 5: pH snd Brix Level (Cacao Pulp)";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(11, 94);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(340, 23);
            radioButton4.TabIndex = 10;
            radioButton4.TabStop = true;
            radioButton4.Text = "Model 4: Fat Content (Fermented Cacao Beans)";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(11, 69);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(379, 23);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Model 3: Moisture Content (Fermented Cacao Beans)";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(11, 44);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(406, 23);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Model 2: Origin Determination (Fermented Cacao Beans)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 19);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(407, 23);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Model 1: Cut Test Classification (Fermented Cacao Beans)";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(8, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 23);
            label2.TabIndex = 5;
            label2.Text = "Prediction Model";
            label2.Click += label2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(textBox2);
            panel4.Location = new Point(0, 439);
            panel4.Name = "panel4";
            panel4.Size = new Size(480, 146);
            panel4.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(18, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 6;
            label4.Text = "Results";
            label4.Click += label4_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(22, 41);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(203, 22);
            button2.TabIndex = 15;
            button2.Text = "Copy Folder path to clipboard ...";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_2;
            // 
            // button5
            // 
            button5.Location = new Point(22, 70);
            button5.Margin = new Padding(2, 1, 2, 1);
            button5.Name = "button5";
            button5.Size = new Size(107, 22);
            button5.TabIndex = 14;
            button5.Text = "Open folder";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(301, 122);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 13;
            label5.Text = "Click to enlarge image";
            label5.Click += label5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.predictions_pie_chart_O_VSW_MI_20250920_211322;
            pictureBox4.Location = new Point(301, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(162, 116);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9.75F);
            textBox2.Location = new Point(137, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(141, 25);
            textBox2.TabIndex = 10;
            textBox2.Text = "C:\\cacao\\results";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label7);
            panel5.Location = new Point(0, 439);
            panel5.Name = "panel5";
            panel5.Size = new Size(475, 145);
            panel5.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(6, 6);
            label7.Name = "label7";
            label7.Size = new Size(90, 23);
            label7.TabIndex = 6;
            label7.Text = "No results";
            label7.Click += label7_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // imageList3
            // 
            imageList3.ColorDepth = ColorDepth.Depth32Bit;
            imageList3.ImageSize = new Size(16, 16);
            imageList3.TransparentColor = Color.Transparent;
            // 
            // imageList4
            // 
            imageList4.ColorDepth = ColorDepth.Depth32Bit;
            imageList4.ImageSize = new Size(16, 16);
            imageList4.TransparentColor = Color.Transparent;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.animace_bez_textu_480px_15fps;
            pictureBox2.Location = new Point(181, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 113);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(6, 2);
            label3.Name = "label3";
            label3.Size = new Size(272, 23);
            label3.TabIndex = 6;
            label3.Text = "Prediction model in process wait";
            label3.Click += label3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { oprtionToolStripMenuItem, languanToolStripMenuItem, sssToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(483, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // oprtionToolStripMenuItem
            // 
            oprtionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { demoToolStripMenuItem });
            oprtionToolStripMenuItem.Name = "oprtionToolStripMenuItem";
            oprtionToolStripMenuItem.Size = new Size(56, 20);
            oprtionToolStripMenuItem.Text = "Option";
            oprtionToolStripMenuItem.Click += oprtionToolStripMenuItem_Click;
            // 
            // demoToolStripMenuItem
            // 
            demoToolStripMenuItem.Checked = true;
            demoToolStripMenuItem.CheckOnClick = true;
            demoToolStripMenuItem.CheckState = CheckState.Checked;
            demoToolStripMenuItem.Name = "demoToolStripMenuItem";
            demoToolStripMenuItem.Size = new Size(140, 22);
            demoToolStripMenuItem.Text = "Demo mode";
            demoToolStripMenuItem.Click += demoToolStripMenuItem_Click;
            // 
            // languanToolStripMenuItem
            // 
            languanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { englishToolStripMenuItem });
            languanToolStripMenuItem.Name = "languanToolStripMenuItem";
            languanToolStripMenuItem.Size = new Size(71, 20);
            languanToolStripMenuItem.Text = "Language";
            languanToolStripMenuItem.Click += languanToolStripMenuItem_Click;
            // 
            // englishToolStripMenuItem
            // 
            englishToolStripMenuItem.Checked = true;
            englishToolStripMenuItem.CheckState = CheckState.Checked;
            englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            englishToolStripMenuItem.Size = new Size(112, 22);
            englishToolStripMenuItem.Text = "English";
            // 
            // sssToolStripMenuItem
            // 
            sssToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { authorsToolStripMenuItem, versioToolStripMenuItem });
            sssToolStripMenuItem.Name = "sssToolStripMenuItem";
            sssToolStripMenuItem.Size = new Size(52, 20);
            sssToolStripMenuItem.Text = "About";
            // 
            // authorsToolStripMenuItem
            // 
            authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            authorsToolStripMenuItem.Size = new Size(116, 22);
            authorsToolStripMenuItem.Text = "Authors";
            authorsToolStripMenuItem.Click += authorsToolStripMenuItem_Click;
            // 
            // versioToolStripMenuItem
            // 
            versioToolStripMenuItem.Name = "versioToolStripMenuItem";
            versioToolStripMenuItem.Size = new Size(116, 22);
            versioToolStripMenuItem.Text = "Versio";
            versioToolStripMenuItem.Click += versioToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._3b0197900da63e268bf7427196a75ffc12cab5b4;
            pictureBox3.Location = new Point(360, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(115, 91);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(0, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(479, 101);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 439);
            panel3.Name = "panel3";
            panel3.Size = new Size(475, 146);
            panel3.TabIndex = 10;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 611);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(483, 22);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(152, 17);
            toolStripStatusLabel1.Text = "Select model and NIRS data";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(2, 585);
            textBox3.Margin = new Padding(2, 1, 2, 1);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(476, 23);
            textBox3.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(483, 633);
            Controls.Add(textBox3);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            ForeColor = Color.Black;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "QCtech360";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Diagnostics.Process process1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox2;
        private ImageList imageList1;
        private ImageList imageList2;
        private ImageList imageList3;
        private ImageList imageList4;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sssToolStripMenuItem;
        private ToolStripMenuItem authorsToolStripMenuItem;
        private ToolStripMenuItem versioToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox3;
        private ToolStripMenuItem languanToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private Panel panel3;
        private Panel panel2;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel panel4;
        private Label label4;
        private TextBox textBox2;
        private PictureBox pictureBox4;
        private Label label5;
        private Button button4;
        private Button button5;
        private Button button2;
        private Panel panel5;
        private Label label7;
        private TextBox textBox3;
        private ToolStripMenuItem oprtionToolStripMenuItem;
        private ToolStripMenuItem demoToolStripMenuItem;
    }
}
