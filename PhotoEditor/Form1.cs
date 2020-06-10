/*This application is developed by Zain bin Arshad FA16-BCS-204
  It has basic photo editing capbilties, if you find any bug, or have some recommendation
  feel free to discuss it with developer at "ch.zainbinarhsad@gmail.com"*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
namespace PhotoEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] r = new int[10000, 10000];
        int[,] b = new int[10000, 10000];
        int[,] g = new int[10000, 10000];
        private Image image;
        private Size OriginalImageSize;
        private Size ModifiedImageSize;

        public DashStyle cropDashStyle = DashStyle.DashDot;
        public Pen cropPen;
        int cropX;
        int cropY;
        int cropWidth;
        int cropHeight;
        public bool Makeselection = false;
        public bool CreateText = false;


        //open image
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dlog = new OpenFileDialog();
            Dlog.Title = "Select Image";  //title of the delection dialoge box
            if (Dlog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(Dlog.FileName); //create image from the given file 
                LoadImage();
            }
        }

        //load the image specified in open file dialog box
        private void LoadImage()
        {
            int imageWidth = image.Width;
            int imagehieght = image.Height;
            //seting picture box dimensions according to image dimensions, for elegency
            PictureBox1.Width = imageWidth;
            PictureBox1.Height = imagehieght;
            PictureBox1.Image = image;
            PictureBoxLocation();
            OriginalImageSize = new Size(imageWidth, imagehieght);
            SetResizeInfo();
        }

        private void PictureBoxLocation()
        {
            int _x = 0;
            int _y = 0;
            //adusting the picture box auto-size
            if (SplitContainer1.Panel1.Width > PictureBox1.Width)
            {
                _x = (SplitContainer1.Panel1.Width - PictureBox1.Width) / 2;
            }
            if (SplitContainer1.Panel1.Height > PictureBox1.Height)
            {
                _y = (SplitContainer1.Panel1.Height - PictureBox1.Height) / 2;
            }
            PictureBox1.Location = new Point(_x, _y);
        }

        private void SetResizeInfo()
        {

            lbloriginalSize.Text = OriginalImageSize.ToString();
            lblModifiedSize.Text = ModifiedImageSize.ToString();

        }

        private void SplitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            PictureBoxLocation();
        }

        // resize Ok butn is pressed
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap bm_source = new Bitmap(PictureBox1.Image);
                Bitmap bm_dest = new Bitmap(Convert.ToInt32(ModifiedImageSize.Width),
                                            Convert.ToInt32(ModifiedImageSize.Height)); //make a bitmap for the result
                Graphics gr_dest = Graphics.FromImage(bm_dest); //making a grpahic result for the bitmap 
                gr_dest.DrawImage(bm_source, 0, 0, bm_dest.Width + 1, bm_dest.Height + 1); // copying sourc image in destination bitmap

                //displaying the resized photo
                PictureBox1.Image = bm_dest;
                PictureBox1.Width = bm_dest.Width;
                PictureBox1.Height = bm_dest.Height;
                PictureBoxLocation();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private void DomainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            int percentage = 0;
            try
            {
                percentage = Convert.ToInt32(DomainUpDown1.Text);
                ModifiedImageSize = new Size((OriginalImageSize.Width * percentage) / 100, (OriginalImageSize.Height * percentage) / 100);
                SetResizeInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

        }
        private void BindDomainIUpDown()
        {
            for (int i = 1; i <= 999; i++)
            {
                DomainUpDown1.Items.Add(i);
            }
            DomainUpDown1.Text = "100";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindDomainIUpDown();
        }

        # region  Crop Image



        private void btnMakeSelection_Click(object sender, EventArgs e)
        {
            Makeselection = true;
            btnCrop.Enabled = true;

        }

        private void btnCrop_Click(object sender, EventArgs e)
        {

            Cursor = Cursors.Default;

            try
            {
                if (cropWidth < 1)
                {
                    return;
                }
                Rectangle rect = new Rectangle(cropX, cropY, cropWidth, cropHeight);
                //we define a rectangle with  help ofalready calculated points
                Bitmap OriginalImage = new Bitmap(PictureBox1.Image, PictureBox1.Width, PictureBox1.Height);
                //Original image
                Bitmap _img = new Bitmap(cropWidth, cropHeight);
                // for cropinf image
                Graphics g = Graphics.FromImage(_img);
                // create graphics
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                //set image attributes
                g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);

                PictureBox1.Image = _img;
                PictureBox1.Width = _img.Width;
                PictureBox1.Height = _img.Height;
                PictureBoxLocation();
                btnCrop.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (TabControl1.SelectedIndex == 4)
            {
                Point TextStartLocation = e.Location;
                if (CreateText)
                {
                    Cursor = Cursors.IBeam;
                }
            }
            else
            {
                Cursor = Cursors.Default;
                if (Makeselection)
                {
                    try
                    {
                        if (e.Button == System.Windows.Forms.MouseButtons.Left)
                        {
                            Cursor = Cursors.Cross;
                            cropX = e.X;
                            cropY = e.Y;

                            cropPen = new Pen(Color.Black, 1);
                            cropPen.DashStyle = DashStyle.DashDotDot;
                        }
                        PictureBox1.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }


        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (Makeselection)
            {
                Cursor = Cursors.Default;
            }

        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TabControl1.SelectedIndex == 4)
            {
                Point TextStartLocation = e.Location;
                if (CreateText)
                {
                    Cursor = Cursors.IBeam;
                }
            }
            else
            {
                Cursor = Cursors.Default;
                if (Makeselection)
                {

                    try
                    {
                        if (PictureBox1.Image == null)
                            return;


                        if (e.Button == System.Windows.Forms.MouseButtons.Left)
                        {
                            PictureBox1.Refresh();
                            cropWidth = e.X - cropX;
                            cropHeight = e.Y - cropY;
                            PictureBox1.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }

        }
        # endregion

        private void TrackBarBrightness_Scroll(object sender, EventArgs e)
        {
            DomainUpDownBrightness.Text = TrackBarBrightness.Value.ToString();
            float value = TrackBarBrightness.Value * 0.01f;
            float[][] colorMatrixElements =  // seting matix for brightness adjustmnts
            {
                new float[] { 1,0, 0,0, 0},
                new float[] { 0,1, 0,0, 0},
                new float[] {0, 0,1,0,0},
                new float[] { 0,0,0,1,0},
                new float[] {value, value, value, 0, 1 }
            };
			//this class cant be inherited
            ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            Image _img = image;
            Graphics _g = default(Graphics);
            Bitmap bm_dest = new Bitmap(Convert.ToInt32(_img.Width), Convert.ToInt32(_img.Height));
            _g = Graphics.FromImage(bm_dest);
            _g.DrawImage(_img, new Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes);
            PictureBox1.Image = bm_dest;

        }

		// rotating of the oicture is done here
        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            PictureBox1.Refresh();
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            PictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            PictureBox1.Refresh();
        }

        private void btnRotateHorizantal_Click(object sender, EventArgs e)
        {
            PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            PictureBox1.Refresh();
        }

        private void btnRotatevertical_Click(object sender, EventArgs e)
        {
            PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            PictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //greyscale is pressed 
        private void button1_Click_1(object sender, EventArgs e)
        {
            int average;
            Bitmap btmp = new Bitmap(PictureBox1.Image);
            for (int i = 0; i < btmp.Width; i++)
            {
                for (int j = 0; j < btmp.Height; j++)
                {
                    r[i, j] = btmp.GetPixel(i, j).R;  // only gets Red component of the selection
                    g[i, j] = btmp.GetPixel(i, j).G;  // only gets green component of the selection
                    b[i, j] = btmp.GetPixel(i, j).B;  // only gets blue component of the selection
                    average = (r[i, j] + g[i, j] + b[i, j]) / 3;
                    btmp.SetPixel(i, j, Color.FromArgb(average, average, average));
                }
            }
            PictureBox1.Image = btmp;
        }

        //revert is pressed
        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap btmp = new Bitmap(PictureBox1.Image);

            for (int i = 0; i < btmp.Width; i++)
            {
                for (int j = 0; j < btmp.Height; j++)
                {
                    btmp.SetPixel(i, j, Color.FromArgb(r[i, j], g[i, j], b[i, j]));
                }
            }
            PictureBox1.Image = btmp;
        }

        //chrome is pressed
        private void button3_Click(object sender, EventArgs e)
        {
            int red;
            Bitmap btmp = new Bitmap(PictureBox1.Image);
            for (int i = 0; i < btmp.Width; i++)
            {
                for (int j = 0; j < btmp.Height; j++)
                {
                    r[i, j] = btmp.GetPixel(i, j).R;  // only gets Red component of the selection4
                    red = r[i, j] + 50;
                    if (red > 255)
                        red = 255;
                    g[i, j] = btmp.GetPixel(i, j).G;  // only gets green component of the selection
                    b[i, j] = btmp.GetPixel(i, j).B;  // only gets blue component of the selection


                    btmp.SetPixel(i, j, Color.FromArgb(red, g[i, j], b[i, j]));
                }
            }
            PictureBox1.Image = btmp;
        }
			
		// finding the edge of the objects
        private void edgeButton_Click(object sender, EventArgs e)
        {

            int total;
            Bitmap bmp = new Bitmap(PictureBox1.Image);
            Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
			// setting the pixles to WHITE
            for (int i = 1; i < bmp.Width - 1; i++)
			{
                for (int j = 1; j < bmp.Height - 1; j++)
                {
                    bmp2.SetPixel(i, j, Color.White);
                }
			}
				
            for (int i = 1; i < bmp.Width - 1; i++)
                for (int j = 1; j < bmp.Height - 1; j++)
                {

                    total = Math.Abs(bmp.GetPixel(i, j).R - bmp.GetPixel(i - 1, j - 1).R + bmp.GetPixel(i, j).G - bmp.GetPixel(i - 1, j - 1).G + bmp.GetPixel(i, j).B - bmp.GetPixel(i - 1, j - 1).B);


                    if (total > 90)
                        bmp2.SetPixel(i, j, Color.Black);


                    total = Math.Abs(bmp.GetPixel(i, j).R - bmp.GetPixel(i, j - 1).R + bmp.GetPixel(i, j).G - bmp.GetPixel(i, j - 1).G + bmp.GetPixel(i, j).B - bmp.GetPixel(i, j - 1).B);


                    if (total > 90)
                        bmp2.SetPixel(i, j, Color.Black);

                    total = Math.Abs(bmp.GetPixel(i, j).R - bmp.GetPixel(i + 1, j - 1).R + bmp.GetPixel(i, j).G - bmp.GetPixel(i + 1, j - 1).G + bmp.GetPixel(i, j).B - bmp.GetPixel(i + 1, j - 1).B);


                    if (total > 90)
                        bmp2.SetPixel(i, j, Color.Black);


                    ///////////////////////////////////////////////////////////////////////////


                    total = Math.Abs(bmp.GetPixel(i, j).R - bmp.GetPixel(i - 1, j).R + bmp.GetPixel(i, j).G - bmp.GetPixel(i - 1, j).G + bmp.GetPixel(i, j).B - bmp.GetPixel(i - 1, j).B);


                    if (total > 90)
                        bmp2.SetPixel(i, j, Color.Black);

                    total = Math.Abs(bmp.GetPixel(i, j).R - bmp.GetPixel(i - 1, j + 1).R + bmp.GetPixel(i, j).G - bmp.GetPixel(i - 1, j + 1).G + bmp.GetPixel(i, j).B - bmp.GetPixel(i - 1, j + 1).B);


                    if (total > 90)
                        bmp2.SetPixel(i, j, Color.Black);

                    ///////////////////////////////////////////////////////////////////////////////////

                    total = Math.Abs(bmp.GetPixel(i, j).R - bmp.GetPixel(i, j + 1).R + bmp.GetPixel(i, j).G - bmp.GetPixel(i, j + 1).G + bmp.GetPixel(i, j).B - bmp.GetPixel(i, j + 1).B);


                    if (total > 90)
                        bmp2.SetPixel(i, j, Color.Black);

                    /////////////////////////////////////////////////////////////////////////////////////

                    total = Math.Abs(bmp.GetPixel(i, j).R - bmp.GetPixel(i + 1, j + 1).R + bmp.GetPixel(i, j).G - bmp.GetPixel(i + 1, j + 1).G + bmp.GetPixel(i, j).B - bmp.GetPixel(i + 1, j + 1).B);


                    if (total > 90)
                        bmp2.SetPixel(i, j, Color.Black);

                    ////////////////////////////////////////////////////////////////////////////////////

                    total = Math.Abs(bmp.GetPixel(i, j).R - bmp.GetPixel(i + 1, j + 1).R + bmp.GetPixel(i, j).G - bmp.GetPixel(i + 1, j + 1).G + bmp.GetPixel(i, j).B - bmp.GetPixel(i + 1, j + 1).B);


                    if (total > 90)
                        bmp2.SetPixel(i, j, Color.Black);

                    total = Math.Abs(bmp.GetPixel(i, j).R - bmp.GetPixel(i + 1, j).R + bmp.GetPixel(i, j).G - bmp.GetPixel(i + 1, j).G + bmp.GetPixel(i, j).B - bmp.GetPixel(i + 1, j).B);


                    if (total > 90)
                        bmp2.SetPixel(i, j, Color.Black);
                }
            PictureBox1.Image = bmp2;
        }

        int x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0, x4 = 0, y4 = 0;
        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
           Bitmap bmp =  new Bitmap(PictureBox1.Image);
            red_textBox.Text = bmp.GetPixel(e.X, e.Y).R.ToString();
            green_textBox.Text = bmp.GetPixel(e.X, e.Y).G.ToString();
            blue_textBox.Text = bmp.GetPixel(e.X, e.Y).B.ToString();
        }

        // detect rectangles
        private void button5_Click_1(object sender, EventArgs e)
        {
            int x2 = 0, y2 = 0;
            try
            {
                Bitmap bmp = new Bitmap(PictureBox1.Image);
                for (int i = 1; i < bmp.Width; i++)
                {
                    for (int j = 1; j < bmp.Height; j++)
                    {
                        if ((bmp.GetPixel(i, j).R < 10) && (bmp.GetPixel(i, j - 1).R > 200) && (bmp.GetPixel(i - 1, j).R > 200))
                        {
                            for (int a = i; a < bmp.Width; a++)
                            {
                                if (bmp.GetPixel(a, j).R < 10 && (bmp.GetPixel(a + 1, j).R > 200))
                                {
                                    x2 = a;
                                    break;
                                }
                            }

                            for (int b = j; b < bmp.Height; b++)
                            {
                                if (bmp.GetPixel(i, b).R < 10 && (bmp.GetPixel(i, b + 1).R > 200))
                                {
                                    y2 = b;
                                    break;
                                }
                            }
                        }
                    }
                }

                if ((bmp.GetPixel(x2, y2).R < 10) && (bmp.GetPixel(x2 + 1, y2).R > 200) && (bmp.GetPixel(x2, y2 + 1).R > 200))
                {
                    MessageBox.Show("Rectangles has been detected");
                }
                else
                {
                    MessageBox.Show("Rectangles has not been detected");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }

        }


        int x11 = 0, y11 = 0, x22 = 0, y22 = 0, x33 = 0, y33 = 0, x44 = 0, y44 = 0;
        // this only detects TWO words that are Black in color
        private void button4_Click(Object sender, EventArgs e)
        {
            try
            {
                Pen draw = new Pen(Color.Black);
                draw.Width = 2; // setting width for prominent reslts
                Bitmap bmp = new Bitmap(PictureBox1.Image);
                //graphics class to draw rectangle
                Graphics graphics = PictureBox1.CreateGraphics();
                bool exit = false, word = false, widthWise = false;
                int count = 0, lower = -1;
                x11 = y11 = x22 = y22 = x33 = y33 = x44 = y44 = 0;
                x1 = y1 = x2 = y2 = x3 = y3 = x4 = y4 = 0;
                //divide image into two parts each containing a word
                //then word detection is implemented on these two parts separately
                for (int j = 0; j < bmp.Height; j++)
                {
                    for (int i = 0; i < bmp.Width; i++)
                    {
                        if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            word = true;
                        
                        if (word)
                        {
                            if (!(bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10))
                                count++;
                            else
                                count = 0;

                            if (count == image.Width * 5)
                            {
                                lower = j;
                                word = false;
                                widthWise = true;
                                break;
                            }
                        }
                    }
                    if (lower == j)
                        break;
                }
                
                //checking that there is a word under first word
                for (int j = lower; j < bmp.Height; j++)
                {
                    for (int i = 0; i < bmp.Width; i++)
                    {
                        if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                        {
                            widthWise = true;
                            break;
                        }
                        else
                            widthWise = false;
                    }
                    if (widthWise) break;
                        
                }

                // if words are side by side
                if (!(widthWise))
                {
                    exit = word = false;
                    count = 0;
                    for (int i = 0; i < bmp.Width; i++)
                    {
                        for (int j = 0; j < bmp.Height; j++)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                                word = true;

                            if (word)
                            {
                                if (!(bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10))
                                {
                                    count++;
                                }
                                else
                                    count = 0;

                                if (count == bmp.Height * 10)
                                {
                                    lower = i;
                                    word = false;
                                    break;
                                }
                            }
                        }
                        if (lower == i)
                            break;
                    }
                }

                if (lower == -1)
                    lower = 0;

                //draw rectangles for words that are Up Down
                if (widthWise)
                {
                    //left pixels of first word
                    for (int i = 0; i < bmp.Width; i++)
                    {
                        for (int j = 0; j < lower; j++)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            {
                                x1 = i;
                                y1 = j;
                                exit = true;
                                break;
                            }
                        }
                        if (exit)
                        {
                            exit = false;
                            break;
                        }
                    }
                    //top most pixel of first word
                    for (int j = 0; j < lower; j++)
                    {
                        for (int i = 0; i < bmp.Width; i++)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            {
                                x2 = i;
                                y2 = j;
                                exit = true;
                                break;
                            }
                        }
                        if (exit)
                        {
                            exit = false;
                            break;
                        }
                    }

                    //right pixel of first word
                    for (int i = bmp.Width - 1; i >= 0; i--)
                    {
                        for (int j = lower - 1; j >= 0; j--)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            {
                                x3 = i;
                                y3 = j;
                                exit = true;
                                break;
                            }
                        }
                        if (exit)
                        {
                            exit = false;
                            break;
                        }
                    }

                    //bottom pixel of first word
                    for (int j = lower - 1; j >= 0; j--)
                    {
                        for (int i = 0; i < bmp.Width; i++)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            {
                                x4 = i;
                                y4 = j;
                                exit = true;
                                break;
                            }
                        }
                        if (exit)
                        {
                            exit = false;
                            break;
                        }
                    }

                    //left pixels of second word
                    for (int i = 0; i < bmp.Width; i++)
                    {
                        for (int j = lower; j < bmp.Height; j++)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            {
                                x11 = i;
                                y11 = j;
                                exit = true;
                                break;
                            }
                        }
                        if (exit)
                        {
                            exit = false;
                            break;
                        }
                    }

                    //top most pixel of secnd word
                    for (int j = lower; j < bmp.Height; j++)
                    {
                        for (int i = 0; i < bmp.Width; i++)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            {
                                x22 = i;
                                y22 = j;
                                exit = true;
                                break;
                            }
                        }
                        if (exit)
                        {
                            exit = false;
                            break;
                        }
                    }

                    //right pixel of secnd word
                    for (int i = bmp.Width - 1; i >= 0; i--)
                    {
                        for (int j = bmp.Height - 1; j >= lower; j--)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            {
                                x33 = i;
                                y33 = j;
                                exit = true;
                                break;
                            }
                        }
                        if (exit)
                        {
                            exit = false;
                            break;
                        }
                    }

                    //bottom pixel of secnd word
                    for (int j = bmp.Height - 1; j >= lower; j--)
                    {
                        for (int i = 0; i < bmp.Width; i++)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            {
                                x44 = i;
                                y44 = j;
                                exit = true;
                                break;
                            }
                        }
                        if (exit)
                        {
                            exit = false;
                            break;
                        }
                    }
                }
                else  // draw rectagnles for words that are side by side
                {
                    //left pixel of first word
                    for (int i = 0; i < lower; i++)
                    {
                        for (int j = 0; j < bmp.Height; j++)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            {
                                x1 = i;
                                y1 = j;
                                exit = true;
                                break;
                            }
                        }
                        if (exit)
                        {
                            exit = false;
                            break;
                        }
                    }

                    //top most pixel of first word
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        for (int i = 0; i < lower; i++)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            {
                                x2 = i;
                                y2 = j;
                                exit = true;
                                break;
                            }
                        }
                        if (exit)
                        {
                            exit = false;
                            break;
                        }
                    }

                    //right pixel of first word
                    for (int i = lower; i >= 0; i--)
                    {
                        for (int j = 0; j < bmp.Height; j++)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            {
                                x3 = i;
                                y3 = j;
                                exit = true;
                                break;
                            }
                        }
                        if (exit)
                        {
                            exit = false;
                            break;
                        }
                    }

                    //bottom pixel of first word
                    for (int j = bmp.Height - 1; j > 0; j--)
                    {
                        for (int i = 0; i < lower; i++)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            {
                                x4 = i;
                                y4 = j;
                                exit = true;
                                break;
                            }
                        }
                        if (exit)
                        {
                            exit = false;
                            break;
                        }
                    }
                    //SECOND WORD

                    //left pixel of second word
                    for (int i = lower; i < bmp.Width; i++)
                    {
                        for (int j = 0; j < bmp.Height; j++)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            {
                                x11 = i;
                                y11 = j;
                                exit = true;
                                break;
                            }
                        }
                        if (exit)
                        {
                            exit = false;
                            break;
                        }
                    }

                    //top most pixel of second word
                    for (int j = 0; j < bmp.Height; j++)
                    {
                        for (int i = lower; i < bmp.Width; i++)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            {
                                x22 = i;
                                y22 = j;
                                exit = true;
                                break;
                            }
                        }
                        if (exit)
                        {
                            exit = false;
                            break;
                        }
                    }

                    //right pixel of second word
                    for (int i = bmp.Width - 1; i > lower; i--)
                    {
                        for (int j = 0; j < bmp.Height; j++)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            {
                                x33 = i;
                                y33 = j;
                                exit = true;
                                break;
                            }
                        }
                        if (exit)
                        {
                            exit = false;
                            break;
                        }
                    }

                    //bottom pixel of second word
                    for (int j = bmp.Height - 1; j > 0; j--)
                    {
                        for (int i = lower; i < bmp.Width; i++)
                        {
                            if (bmp.GetPixel(i, j) == Color.Black || bmp.GetPixel(i, j).R < 10)
                            {
                                x44 = i;
                                y44 = j;
                                exit = true;
                                break;
                            }
                        }
                        if (exit)
                        {
                            exit = false;
                            break;
                        }
                    }
                }

                graphics.DrawRectangle(draw, x1, y2, x3 - x1, y4 - y2); //drawing rectangle around first word
                graphics.DrawRectangle(draw, x11, y22, x33 - x11, y44 - y22); //drawing rectangle around second word

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
