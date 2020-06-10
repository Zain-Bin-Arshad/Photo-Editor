namespace PhotoEditor
{
    partial class Form1
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
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.blue_textBox = new System.Windows.Forms.TextBox();
            this.green_textBox = new System.Windows.Forms.TextBox();
            this.red_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.lbloriginalSize = new System.Windows.Forms.Label();
            this.lblModifiedSize = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.DomainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.btnCrop = new System.Windows.Forms.Button();
            this.btnMakeSelection = new System.Windows.Forms.Button();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.Label5 = new System.Windows.Forms.Label();
            this.DomainUpDownBrightness = new System.Windows.Forms.DomainUpDown();
            this.TrackBarBrightness = new System.Windows.Forms.TrackBar();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.btnRotateHorizantal = new System.Windows.Forms.Button();
            this.btnRotatevertical = new System.Windows.Forms.Button();
            this.btnRotateLeft = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.edgeButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).BeginInit();
            this.TabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 24);
            this.SplitContainer1.Name = "SplitContainer1";
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.AutoScroll = true;
            this.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.SplitContainer1.Panel1.Controls.Add(this.PictureBox1);
            this.SplitContainer1.Panel1.Resize += new System.EventHandler(this.SplitContainer1_Panel1_Resize);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.TabControl1);
            this.SplitContainer1.Size = new System.Drawing.Size(931, 533);
            this.SplitContainer1.SplitterDistance = 610;
            this.SplitContainer1.TabIndex = 6;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(3, 22);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(585, 452);
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
            this.PictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.PictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.PictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.tabPage5);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(317, 533);
            this.TabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.label10);
            this.TabPage1.Controls.Add(this.label9);
            this.TabPage1.Controls.Add(this.blue_textBox);
            this.TabPage1.Controls.Add(this.green_textBox);
            this.TabPage1.Controls.Add(this.red_textBox);
            this.TabPage1.Controls.Add(this.label8);
            this.TabPage1.Controls.Add(this.label6);
            this.TabPage1.Controls.Add(this.label3);
            this.TabPage1.Controls.Add(this.button5);
            this.TabPage1.Controls.Add(this.label14);
            this.TabPage1.Controls.Add(this.label13);
            this.TabPage1.Controls.Add(this.label12);
            this.TabPage1.Controls.Add(this.button4);
            this.TabPage1.Controls.Add(this.Label7);
            this.TabPage1.Controls.Add(this.lbloriginalSize);
            this.TabPage1.Controls.Add(this.lblModifiedSize);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.btnOk);
            this.TabPage1.Controls.Add(this.DomainUpDown1);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(309, 507);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Resize";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(220, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Click on Image for Component Colors:";
            // 
            // blue_textBox
            // 
            this.blue_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blue_textBox.ForeColor = System.Drawing.Color.Blue;
            this.blue_textBox.Location = new System.Drawing.Point(216, 401);
            this.blue_textBox.Name = "blue_textBox";
            this.blue_textBox.Size = new System.Drawing.Size(32, 20);
            this.blue_textBox.TabIndex = 27;
            // 
            // green_textBox
            // 
            this.green_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.green_textBox.ForeColor = System.Drawing.Color.Lime;
            this.green_textBox.Location = new System.Drawing.Point(140, 401);
            this.green_textBox.Name = "green_textBox";
            this.green_textBox.Size = new System.Drawing.Size(32, 20);
            this.green_textBox.TabIndex = 26;
            // 
            // red_textBox
            // 
            this.red_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.red_textBox.ForeColor = System.Drawing.Color.Red;
            this.red_textBox.Location = new System.Drawing.Point(69, 401);
            this.red_textBox.Name = "red_textBox";
            this.red_textBox.Size = new System.Drawing.Size(32, 20);
            this.red_textBox.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(216, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Blue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(137, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(69, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Red";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(91, 303);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 27);
            this.button5.TabIndex = 21;
            this.button5.Text = "Detect Rectangles";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(94, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Co-ordinates";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(99, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Modified Image:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(99, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Origional Image:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(112, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 28);
            this.button4.TabIndex = 17;
            this.button4.Text = "Detect Text";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(86, 437);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(0, 13);
            this.Label7.TabIndex = 8;
            // 
            // lbloriginalSize
            // 
            this.lbloriginalSize.AutoSize = true;
            this.lbloriginalSize.Location = new System.Drawing.Point(99, 146);
            this.lbloriginalSize.Name = "lbloriginalSize";
            this.lbloriginalSize.Size = new System.Drawing.Size(0, 13);
            this.lbloriginalSize.TabIndex = 7;
            // 
            // lblModifiedSize
            // 
            this.lblModifiedSize.AutoSize = true;
            this.lblModifiedSize.Location = new System.Drawing.Point(99, 206);
            this.lblModifiedSize.Name = "lblModifiedSize";
            this.lblModifiedSize.Size = new System.Drawing.Size(0, 13);
            this.lblModifiedSize.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(27, 240);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(0, 13);
            this.Label4.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(216, 49);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(51, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // DomainUpDown1
            // 
            this.DomainUpDown1.Location = new System.Drawing.Point(131, 49);
            this.DomainUpDown1.Name = "DomainUpDown1";
            this.DomainUpDown1.Size = new System.Drawing.Size(75, 20);
            this.DomainUpDown1.TabIndex = 2;
            this.DomainUpDown1.SelectedItemChanged += new System.EventHandler(this.DomainUpDown1_SelectedItemChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(8, 188);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(0, 13);
            this.Label2.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(8, 28);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Tag = "";
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.btnCrop);
            this.TabPage3.Controls.Add(this.btnMakeSelection);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(309, 507);
            this.TabPage3.TabIndex = 2;
            this.TabPage3.Text = "Crop";
            this.TabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCrop
            // 
            this.btnCrop.Location = new System.Drawing.Point(107, 53);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(75, 26);
            this.btnCrop.TabIndex = 1;
            this.btnCrop.Text = "Crop";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // btnMakeSelection
            // 
            this.btnMakeSelection.Location = new System.Drawing.Point(104, 24);
            this.btnMakeSelection.Name = "btnMakeSelection";
            this.btnMakeSelection.Size = new System.Drawing.Size(78, 23);
            this.btnMakeSelection.TabIndex = 0;
            this.btnMakeSelection.Text = "Select Area";
            this.btnMakeSelection.UseVisualStyleBackColor = true;
            this.btnMakeSelection.Click += new System.EventHandler(this.btnMakeSelection_Click);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.Label5);
            this.TabPage2.Controls.Add(this.DomainUpDownBrightness);
            this.TabPage2.Controls.Add(this.TrackBarBrightness);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(309, 507);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Brightness";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(28, 48);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(88, 18);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "Brightness";
            // 
            // DomainUpDownBrightness
            // 
            this.DomainUpDownBrightness.Location = new System.Drawing.Point(162, 101);
            this.DomainUpDownBrightness.Name = "DomainUpDownBrightness";
            this.DomainUpDownBrightness.ReadOnly = true;
            this.DomainUpDownBrightness.Size = new System.Drawing.Size(61, 20);
            this.DomainUpDownBrightness.TabIndex = 1;
            // 
            // TrackBarBrightness
            // 
            this.TrackBarBrightness.BackColor = System.Drawing.Color.White;
            this.TrackBarBrightness.Location = new System.Drawing.Point(17, 100);
            this.TrackBarBrightness.Maximum = 100;
            this.TrackBarBrightness.Minimum = -100;
            this.TrackBarBrightness.Name = "TrackBarBrightness";
            this.TrackBarBrightness.Size = new System.Drawing.Size(139, 45);
            this.TrackBarBrightness.TabIndex = 0;
            this.TrackBarBrightness.Scroll += new System.EventHandler(this.TrackBarBrightness_Scroll);
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.btnRotateRight);
            this.TabPage4.Controls.Add(this.btnRotateHorizantal);
            this.TabPage4.Controls.Add(this.btnRotatevertical);
            this.TabPage4.Controls.Add(this.btnRotateLeft);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(309, 507);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Rotate";
            this.TabPage4.UseVisualStyleBackColor = true;
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.Location = new System.Drawing.Point(17, 79);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(122, 23);
            this.btnRotateRight.TabIndex = 3;
            this.btnRotateRight.Text = "Rotate right";
            this.btnRotateRight.UseVisualStyleBackColor = true;
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // btnRotateHorizantal
            // 
            this.btnRotateHorizantal.Location = new System.Drawing.Point(163, 50);
            this.btnRotateHorizantal.Name = "btnRotateHorizantal";
            this.btnRotateHorizantal.Size = new System.Drawing.Size(122, 23);
            this.btnRotateHorizantal.TabIndex = 2;
            this.btnRotateHorizantal.Text = "Rotate horizantal";
            this.btnRotateHorizantal.UseVisualStyleBackColor = true;
            this.btnRotateHorizantal.Click += new System.EventHandler(this.btnRotateHorizantal_Click);
            // 
            // btnRotatevertical
            // 
            this.btnRotatevertical.Location = new System.Drawing.Point(163, 79);
            this.btnRotatevertical.Name = "btnRotatevertical";
            this.btnRotatevertical.Size = new System.Drawing.Size(122, 23);
            this.btnRotatevertical.TabIndex = 1;
            this.btnRotatevertical.Text = "Rotate vertical";
            this.btnRotatevertical.UseVisualStyleBackColor = true;
            this.btnRotatevertical.Click += new System.EventHandler(this.btnRotatevertical_Click);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.Location = new System.Drawing.Point(17, 50);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(122, 23);
            this.btnRotateLeft.TabIndex = 0;
            this.btnRotateLeft.Text = "Rotate left";
            this.btnRotateLeft.UseVisualStyleBackColor = true;
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.edgeButton);
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(309, 507);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Filters";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // edgeButton
            // 
            this.edgeButton.Location = new System.Drawing.Point(207, 24);
            this.edgeButton.Name = "edgeButton";
            this.edgeButton.Size = new System.Drawing.Size(75, 23);
            this.edgeButton.TabIndex = 3;
            this.edgeButton.Text = "Edge ";
            this.edgeButton.UseVisualStyleBackColor = true;
            this.edgeButton.Click += new System.EventHandler(this.edgeButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Chrome";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Revert";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "GreyScale";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.ToolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.UndoToolStripMenuItem.Text = "Undo";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(931, 24);
            this.MenuStrip1.TabIndex = 5;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "Resize Ratio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 557);
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "Form1";
            this.Text = "Photo Editor by Zain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage3.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarBrightness)).EndInit();
            this.TabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.Button btnCrop;
        internal System.Windows.Forms.Button btnMakeSelection;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.DomainUpDown DomainUpDownBrightness;
        internal System.Windows.Forms.TrackBar TrackBarBrightness;
        internal System.Windows.Forms.TabPage TabPage4;
        internal System.Windows.Forms.Button btnRotateRight;
        internal System.Windows.Forms.Button btnRotateHorizantal;
        internal System.Windows.Forms.Button btnRotatevertical;
        internal System.Windows.Forms.Button btnRotateLeft;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnOk;
        internal System.Windows.Forms.DomainUpDown DomainUpDown1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button edgeButton;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.Button button4;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label lbloriginalSize;
        internal System.Windows.Forms.Label lblModifiedSize;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox blue_textBox;
        private System.Windows.Forms.TextBox green_textBox;
        private System.Windows.Forms.TextBox red_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

