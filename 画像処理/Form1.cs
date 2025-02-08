using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using OpenCvSharp;
using Size = System.Drawing.Size;
using System.Windows.Media.Imaging;

namespace 画像処理

// https://dobon.net/vb/dotnet/graphics/createimage.html
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //必要dllの有無チェック
            string[] dllList = { "OpenCvSharp.dll", "OpenCvSharp.Extensions.dll", @"dll\x86\opencv_videoio_ffmpeg453.dll", @"dll\x86\OpenCvSharpExtern.dll", @"dll\x64\opencv_videoio_ffmpeg453_64.dll", @"dll\x64\OpenCvSharpExtern.dll" };
            string[] tmp = new string[dllList.Length];
            int i = 0;
            foreach (string file in dllList)
            {
                if (!System.IO.File.Exists(file))
                {
                    tmp[i] = file;
                    i++;
                }
            }
            if (i != 0)
            {
                // ***** Win11 要対応 *******
                MessageBox.Show(String.Join(System.Environment.NewLine, tmp) + "is not find. This is the file needed to run!");
            }
        }

        //using System.Drawing;
        const int pictureBoxWidth = 3600;
        const int pictureBoxHeight = 3600;
        const int pictureBox2Width = 900;
        const int pictureBox2Height = 900;
        public int pictureBoxPreviewRate = pictureBoxWidth / pictureBox2Width;
        int FinalPictureWidth = pictureBoxWidth;
        int FinalPictureHeight = pictureBoxHeight;
        int previousPictureWidth;
        int previousPictureHeight;
        float reSizeRate;
        bool isPictureSmall = false;

        //出力画像用Imageオブジェクトを作成する
        Bitmap canvas = new Bitmap(pictureBoxWidth, pictureBoxHeight);
        Graphics g;
        Bitmap backupImage;
        //描画先とするImageオブジェクトを作成する
        Bitmap canvas2 = new Bitmap(pictureBox2Width, pictureBox2Height);
        Graphics g2;
        Bitmap backupImage2;
        private bool storeCurrentImage()
        {
            if (pictureBox2.Image == null) return false;
            try
            {
                // 画像のバックアップを取得
                backupImage = new Bitmap(canvas);
                backupImage2 = new Bitmap(canvas2);
                previousPictureWidth = FinalPictureWidth;
                previousPictureHeight = FinalPictureHeight;
                return true;
            }
            catch
            {
                MessageBox.Show("No Image!");
                return false;
            }
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            if (backupImage == null) return;
            FinalPictureWidth = previousPictureWidth;
            FinalPictureHeight = previousPictureHeight;

            try
            {
                // 先にバックアップしていた画像で塗り潰す
                g.DrawImage(backupImage, 0, 0);
                canvas2 = new Bitmap(canvas, pictureBox2Width, pictureBox2Height);

                pictureBox2.Image = canvas2;
            }
            catch
            {
                //pass
            }
            update_LabelImgSize();
        }
        private void update_LabelImgSize()
        {
            if (isPictureSmall) label_ImgSize.Text = (FinalPictureWidth / 4).ToString("f0") + " x " + (FinalPictureHeight / 4).ToString("f0");
            else if (reSizeRate > 1) label_ImgSize.Text = (FinalPictureWidth / reSizeRate).ToString("f0") + " x " + (FinalPictureHeight / reSizeRate).ToString("f0");
            else label_ImgSize.Text = FinalPictureWidth.ToString("f0") + " x " + FinalPictureHeight.ToString("f0");
        }

        private void PreviewDrowPicture(Image defImg = null)
        {
            try
            {
                //ImageオブジェクトのGraphicsオブジェクトを作成する
                Graphics g = Graphics.FromImage(canvas);

                //画像ファイルを読み込んで、Imageオブジェクトとして取得する
                Image img;
                if (defImg == null)
                {
                    img = Image.FromFile(textBoxFileName.Text);
                }
                else
                {
                    img = defImg;
                }

                //画像がPreviewエリアより小さいとき
                if (Math.Max(img.Width, img.Height) < canvas2.Height)
                {
                    reSizeRate = (float)Math.Max(img.Width, img.Height) / (float)pictureBoxWidth;
                }
                else
                {
                    //リサイズ率が小さいほう
                    reSizeRate = Math.Min((float)canvas.Width / (float)img.Width, (float)canvas.Height / (float)img.Height);
                }

                //画像がPreviewエリアより小さいとき
                if (Math.Max(img.Width, img.Height) < canvas2.Height)
                {
                    isPictureSmall = true;
                    FinalPictureHeight = img.Height * pictureBoxPreviewRate;
                    FinalPictureWidth = img.Width * pictureBoxPreviewRate;
                }
                else
                {
                    isPictureSmall = false;
                    float w = (float)img.Width;
                    float h = (float)img.Height;
                    FinalPictureHeight = (int)(h * reSizeRate);
                    FinalPictureWidth = (int)(w * reSizeRate);
                }

                //画像をcanvasの座標(0, 0)の位置に描画する
                g.DrawImage(img, 0, 0, FinalPictureWidth, FinalPictureHeight);
                //Imageオブジェクトのリソースを解放する
                img.Dispose();

                labelStartMsg1.Visible = false;
                labelStartMsg2.Visible = false;
                labelStartMsg3.Visible = false;
                labelStartMsg4.Visible = false;

                fillOutOfCanvas();
                previousPictureHeight = FinalPictureHeight;
                previousPictureWidth = FinalPictureWidth;
            }
            catch
            {
                //pass
            }
            update_LabelImgSize();
        }
        private void fillOutOfCanvas()
        {   //ImageオブジェクトのGraphicsオブジェクトを作成する
            g = Graphics.FromImage(canvas);
            SolidBrush brush = new SolidBrush(Color.Gainsboro);

            g.FillRectangle(brush, FinalPictureWidth, 0, pictureBoxWidth, pictureBoxHeight);
            g.FillRectangle(brush, 0, FinalPictureHeight, pictureBoxWidth, pictureBoxHeight);

            canvas2 = new Bitmap(canvas, pictureBox2Width, pictureBox2Height);
            g2 = Graphics.FromImage(canvas2);
            pictureBox2.Image = canvas2;
        }

        private void buttonGetClipbord_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                Image img = Clipboard.GetImage();
                PreviewDrowPicture(img);
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            //コントロール内にドロップされたとき実行される
            //ドロップされたすべてのファイル名を取得する
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            //textBoxに追加する
            textBoxFileName.Text = fileName[0];

            PreviewDrowPicture();
            storeCurrentImage();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            //コントロール内にドラッグされたとき実行される
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                //ドラッグされたデータ形式を調べ、ファイルのときはコピーとする
                e.Effect = DragDropEffects.Copy;
            else
                //ファイル以外は受け付けない
                e.Effect = DragDropEffects.None;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                int kakuchoshi = textBoxFileName.Text.IndexOf(".");
                string FileName;
                if (kakuchoshi == -1)
                {
                    // https://dobon.net/vb/dotnet/file/getfolderpath.html
                    FileName = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\EasyRetouch.jpg";
                    textBoxFileName.Text = FileName;
                }
                else
                {
                    FileName = textBoxFileName.Text.Substring(0, kakuchoshi);
                }

                string suffix = textBoxSuffix.Text;
                int suffix_no = 0;


                Bitmap canvas0 = FinalResize(canvas);
                if (radioButtonOutputJPG.Checked)
                {
                    while (System.IO.File.Exists(FileName + suffix + (suffix_no == 0 ? "" : suffix_no.ToString()) + ".jpg"))
                    {
                        suffix_no += 1;
                    }
                    canvas0.Save(FileName + suffix + (suffix_no == 0 ? "" : suffix_no.ToString()) + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else
                {
                    while (System.IO.File.Exists(FileName + suffix + (suffix_no == 0 ? "" : suffix_no.ToString()) + ".png"))
                    {
                        suffix_no += 1;
                    }
                    if (checkBoxTransparent.Checked)
                    {
                        int r = (int)numericUpDownTransRed.Value;
                        int g = (int)numericUpDownTransGreen.Value;
                        int b = (int)numericUpDownTransBlue.Value;
                        //近似色または近接ドットの処理は不要か？
                        canvas0.MakeTransparent(Color.FromArgb(r, g, b));
                    }
                    canvas0.Save(FileName + suffix + (suffix_no == 0 ? "" : suffix_no.ToString()) + ".png", System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        private void buttonDrowEdgeLine_Click(object sender, EventArgs e)
        {
            //p = new Pen(color, (float)numericUpDownLineWidth.Value * pictureBoxPreviewRate);
            int width = (int)numericUpDownSurroundLineWidth.Value * pictureBoxPreviewRate;

            if (!storeCurrentImage()) return;

            Color color;
            if (radioButtonDrowEdge_Red.Checked) color = Color.FromArgb(255, 0, 0);
            else if (radioButtonDrowEdge_Yellow.Checked) color = Color.FromArgb(255, 255, 0);
            else if (radioButtonDrowEdge_Green.Checked) color = Color.FromArgb(0, 255, 0);
            else if (radioButtonDrowEdge_Blue.Checked) color = Color.FromArgb(0, 0, 255);
            else color = Color.FromArgb(0, 0, 0);

            for (int x = 0; x < FinalPictureWidth; x++)
            {
                for (int y = 0; y < width; y++)
                    canvas.SetPixel(x, y, color);
            }
            for (int y = 0; y < FinalPictureHeight; y++)
            {
                for (int x = 0; x < width; x++)
                    canvas.SetPixel(x, y, color);
            }
            for (int x = 0; x < FinalPictureWidth; x++)
            {
                for (int y = 0; y < width; y++)
                    canvas.SetPixel(x, FinalPictureHeight - 1 - y, color);
            }
            for (int y = 0; y < FinalPictureHeight; y++)
            {
                for (int x = 0; x < width; x++)
                    canvas.SetPixel(FinalPictureWidth - 1 - x, y, color);
            }
            pictureBox2.Image = canvas;
        }

        int FlagMask = 0;
        int[] Mask_address = new int[4]; //start x ,start y, end x, end y

        private void buttonDrowMask_Click(object sender, EventArgs e)
        {
            FlagMask = 1;
            buttonDrowMask.Enabled = false;
            buttonSquereLine.Enabled = true;
            buttonBlur.Enabled = true;
            buttonTrapezoidalCorrect.Enabled = true;
        }

        private void buttonSquereLine_Click(object sender, EventArgs e)
        {
            FlagMask = 3;
            buttonSquereLine.Enabled = false;
            buttonDrowMask.Enabled = true;
            buttonBlur.Enabled = true;
            buttonTrapezoidalCorrect.Enabled = true;
        }
        private void buttonBlur_Click(object sender, EventArgs e)
        {
            FlagMask = 2;
            buttonBlur.Enabled = false;
            buttonSquereLine.Enabled = true;
            buttonDrowMask.Enabled = true;
            buttonTrapezoidalCorrect.Enabled = true;
        }

        private void buttonSnappingTool_Click(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Minimized;
                Thread.Sleep((int)numericUpDownCutSketchDelay.Value * 1000);
                System.Diagnostics.Process.Start("ms-screenclip:");
            }
            catch
            {
                MessageBox.Show("起動できませんでした。");
            }
        }

        private void buttonTrimming_Click(object sender, EventArgs e)
        {
            if (!storeCurrentImage()) return;
            Graphics g = Graphics.FromImage(canvas);

            //切り取る部分の範囲を決定する。
            int up = (int)numericUpDownTrimUp.Value * pictureBoxPreviewRate;
            int down = (int)numericUpDownTrimDown.Value * pictureBoxPreviewRate;
            int right = (int)numericUpDownTrimRight.Value * pictureBoxPreviewRate;
            int left = (int)numericUpDownTrimLeft.Value * pictureBoxPreviewRate;
            FinalPictureWidth -= (right + left);
            FinalPictureHeight -= (up + down);

            //切り取る部分の範囲を決定する、開始位置、大きさX*Y
            Rectangle srcRect = new Rectangle(left, up, FinalPictureWidth, FinalPictureHeight);
            //描画する部分の範囲。位置(0,0)、大きさX*Yで描画する
            Rectangle desRect = new Rectangle(0, 0, FinalPictureWidth, FinalPictureHeight);
            //画像の一部を描画する
            g.DrawImage(canvas, desRect, srcRect, GraphicsUnit.Pixel);

            fillOutOfCanvas();
            update_LabelImgSize();
        }

        private void buttonFileOpen_Click(object sender, EventArgs e)
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();
            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                textBoxFileName.Text = ofd.FileName;
                PreviewDrowPicture();
            }
        }

        // MouseMove -> MouseUpでつかう
        System.Drawing.Point startPoint;
        System.Drawing.Point endPoint;
        int size_x = 0;
        int size_y = 0;
        Pen p;
        SolidBrush brush;

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (!storeCurrentImage()) return;

            startPoint.X = e.Location.X;//クリックした座標を入れる
            startPoint.Y = e.Location.Y;//クリックした座標を入れる
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            // マウスの左ボタンが押されている場合のみ処理
            if ((Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left)
            {
                canvas2 = new Bitmap(canvas, pictureBox2Width, pictureBox2Height);
                g2 = Graphics.FromImage(canvas2);

                brush = new SolidBrush(Color.FromArgb(100, 200, 0, 00));
                if (radioButtonDrowMask_Red.Checked) brush.Color = Color.FromArgb(255, 0, 0);
                else if (radioButtonDrowMask_Yellow.Checked) brush.Color = Color.FromArgb(255, 255, 0);
                else if (radioButtonDrowMask_Green.Checked) brush.Color = Color.FromArgb(0, 255, 0);
                else if (radioButtonDrowMask_Blue.Checked) brush.Color = Color.FromArgb(0, 0, 255);
                else brush.Color = Color.FromArgb(0, 0, 0);

                Color color;
                if (radioButtonSqLine_Red.Checked) color = Color.FromArgb(255, 0, 0);
                else if (radioButtonSqLine_Yellow.Checked) color = Color.FromArgb(255, 255, 0);
                else if (radioButtonSqLine_Green.Checked) color = Color.FromArgb(0, 255, 0);
                else if (radioButtonSqLine_Blue.Checked) color = Color.FromArgb(0, 0, 255);
                else color = Color.FromArgb(0, 0, 0);

                p = new Pen(color, (float)numericUpDownLineWidth.Value);

                if (FlagMask == 3) //Line
                {
                    // 座標を取得
                    endPoint.X = e.Location.X;
                    endPoint.Y = e.Location.Y;

                    size_x = Math.Abs(startPoint.X - endPoint.X);
                    size_y = Math.Abs(startPoint.Y - endPoint.Y);

                    // 先にバックアップしていた画像で塗り潰す
                    if (backupImage2 != null) g2.DrawImage(backupImage2, 0, 0);
                    g2.DrawRectangle(p, Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y), size_x, size_y);
                    pictureBox2.Image = canvas2;

                }
                else if (FlagMask == 1) //Mask
                {
                    // 座標を取得
                    endPoint.X = e.Location.X;
                    endPoint.Y = e.Location.Y;

                    size_x = Math.Abs(startPoint.X - endPoint.X);
                    size_y = Math.Abs(startPoint.Y - endPoint.Y);

                    // 先にバックアップしていた画像で塗り潰す
                    if (backupImage2 != null) g2.DrawImage(backupImage2, 0, 0);
                    g2.FillRectangle(brush, Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y), size_x, size_y);
                    pictureBox2.Image = canvas2;
                }
                else if (FlagMask == 2)//ぼかし
                {
                    // 座標を取得
                    endPoint.X = e.Location.X;
                    endPoint.Y = e.Location.Y;

                    size_x = Math.Abs(startPoint.X - endPoint.X);
                    size_y = Math.Abs(startPoint.Y - endPoint.Y);

                    // 先にバックアップしていた画像で塗り潰す
                    if (backupImage2 != null) g2.DrawImage(backupImage2, 0, 0);

                    //Penオブジェクトの作成
                    color = Color.FromArgb(250, 100, 150);
                    p = new Pen(color, 2);

                    g2.DrawRectangle(p, Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y), size_x, size_y);
                    pictureBox2.Image = canvas2;
                }
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (FlagMask == 1) //Mask
            {
                brush = new SolidBrush(Color.FromArgb(100, 200, 0, 00));
                if (radioButtonDrowMask_Red.Checked) brush.Color = Color.FromArgb(255, 0, 0);
                else if (radioButtonDrowMask_Yellow.Checked) brush.Color = Color.FromArgb(255, 255, 0);
                else if (radioButtonDrowMask_Green.Checked) brush.Color = Color.FromArgb(0, 255, 0);
                else if (radioButtonDrowMask_Blue.Checked) brush.Color = Color.FromArgb(0, 0, 255);
                else brush.Color = Color.FromArgb(0, 0, 0);
                g.FillRectangle(brush, Math.Min(startPoint.X * pictureBoxPreviewRate, endPoint.X * pictureBoxPreviewRate), Math.Min(startPoint.Y * pictureBoxPreviewRate, endPoint.Y * pictureBoxPreviewRate), size_x * pictureBoxPreviewRate, size_y * pictureBoxPreviewRate);

            }
            else if (FlagMask == 3) //Line
            {
                Color color;
                if (radioButtonSqLine_Red.Checked) color = Color.FromArgb(255, 0, 0);
                else if (radioButtonSqLine_Yellow.Checked) color = Color.FromArgb(255, 255, 0);
                else if (radioButtonSqLine_Green.Checked) color = Color.FromArgb(0, 255, 0);
                else if (radioButtonSqLine_Blue.Checked) color = Color.FromArgb(0, 0, 255);
                else color = Color.FromArgb(0, 0, 0);
                p = new Pen(color, (float)numericUpDownLineWidth.Value * pictureBoxPreviewRate);
                g.DrawRectangle(p, Math.Min(startPoint.X * pictureBoxPreviewRate, endPoint.X * pictureBoxPreviewRate), Math.Min(startPoint.Y * pictureBoxPreviewRate, endPoint.Y * pictureBoxPreviewRate), size_x * pictureBoxPreviewRate, size_y * pictureBoxPreviewRate);
            }
            else if (FlagMask == 2)
            {
                // 先にバックアップしていた画像で塗り潰す
                if (backupImage2 != null) g2.DrawImage(backupImage2, 0, 0);
                int blur_size = (int)numericUpDownBlurSize.Value;
                blur_size *= Math.Max(canvas.Size.Height, canvas.Size.Width) / Math.Max(canvas2.Size.Height, canvas2.Size.Width);

                startPoint.X *= pictureBoxPreviewRate;
                startPoint.Y *= pictureBoxPreviewRate;
                endPoint.X *= pictureBoxPreviewRate;
                endPoint.Y *= pictureBoxPreviewRate;
                size_x *= pictureBoxPreviewRate;
                size_y *= pictureBoxPreviewRate;

                if (endPoint.X > FinalPictureWidth) endPoint.X = FinalPictureWidth;
                else if (endPoint.X < 0) endPoint.X = 0;
                if (endPoint.Y > FinalPictureHeight) endPoint.Y = FinalPictureHeight;
                else if (endPoint.Y < 0) endPoint.Y = 0;

                int tmp = Math.Min(size_x, size_y);
                blur_size = Math.Min(tmp, blur_size);
                if (blur_size == 0) return;

                for (int x = 0; x <= size_x - blur_size / 2; x += blur_size)
                {
                    for (int y = 0; y <= size_y - blur_size / 2; y += blur_size)
                    {
                        int red = 0;
                        int green = 0;
                        int blue = 0;
                        for (int y1 = 0; y1 < blur_size; y1++)
                        {
                            for (int x1 = 0; x1 < blur_size; x1++)
                            {
                                red += canvas.GetPixel(Math.Max(Math.Min(startPoint.X, endPoint.X) + x, 0) + x1, Math.Max(Math.Min(startPoint.Y, endPoint.Y) + y, 0) + y1).R;
                                green += canvas.GetPixel(Math.Max(Math.Min(startPoint.X, endPoint.X) + x, 0) + x1, Math.Max(Math.Min(startPoint.Y, endPoint.Y) + y, 0) + y1).G;
                                blue += canvas.GetPixel(Math.Max(Math.Min(startPoint.X, endPoint.X) + x, 0) + x1, Math.Max(Math.Min(startPoint.Y, endPoint.Y) + y, 0) + y1).B;
                            }
                        }
                        red /= (int)Math.Pow(blur_size, 2);
                        green /= (int)Math.Pow(blur_size, 2);
                        blue /= (int)Math.Pow(blur_size, 2);
                        SolidBrush brush = new SolidBrush(Color.FromArgb(100, red, green, blue));

                        brush.Color = Color.FromArgb(red, green, blue);
                        g.FillRectangle(brush, Math.Min(startPoint.X, endPoint.X) + x, Math.Min(startPoint.Y, endPoint.Y) + y, Math.Min(blur_size, Math.Max(startPoint.X, endPoint.X) - x), Math.Min(blur_size, Math.Max(startPoint.Y, endPoint.Y) - y));
                    }
                }
            }
            if (FlagMask != 0)
            {
                canvas2 = new Bitmap(canvas, pictureBox2Width, pictureBox2Height);
                pictureBox2.Image = canvas2;
            }
        }

        private void buttonTrimingValueReset_Click(object sender, EventArgs e)
        {
            numericUpDownTrimUp.Value = 0;
            numericUpDownTrimDown.Value = 0;
            numericUpDownTrimRight.Value = 0;
            numericUpDownTrimLeft.Value = 0;
        }

        private void swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        private void buttonRotate180deg_Click(object sender, EventArgs e)
        {
            if (!storeCurrentImage()) return;
            swap(ref FinalPictureHeight, ref FinalPictureWidth);
            canvas.RotateFlip(RotateFlipType.Rotate180FlipY);
            canvas2 = new Bitmap(canvas, pictureBox2Width, pictureBox2Height);
            pictureBox2.Image = canvas2;
        }

        private void buttonRotate90deg_Click(object sender, EventArgs e)
        {
            if (!storeCurrentImage()) return;
            swap(ref FinalPictureHeight, ref FinalPictureWidth);
            canvas.RotateFlip(RotateFlipType.Rotate270FlipY);
            canvas.RotateFlip(RotateFlipType.Rotate180FlipY);

            //切り取る部分の範囲を決定する、開始位置、大きさX*Y
            Rectangle srcRect = new Rectangle(pictureBoxWidth - FinalPictureWidth, 0, FinalPictureWidth, FinalPictureHeight);
            //描画する部分の範囲。位置(0,0)、大きさX*Yで描画する
            Rectangle desRect = new Rectangle(0, 0, FinalPictureWidth, FinalPictureHeight);
            //画像の一部を描画する
            g.DrawImage(canvas, desRect, srcRect, GraphicsUnit.Pixel);
            canvas2 = new Bitmap(canvas, pictureBox2Width, pictureBox2Height);
            fillOutOfCanvas();
            update_LabelImgSize();
        }

        private void buttonRotate270deg_Click(object sender, EventArgs e)
        {
            if (!storeCurrentImage()) return;
            swap(ref FinalPictureHeight, ref FinalPictureWidth);
            canvas.RotateFlip(RotateFlipType.Rotate90FlipY);
            canvas.RotateFlip(RotateFlipType.Rotate180FlipY);

            //切り取る部分の範囲を決定する、開始位置、大きさX*Y
            Rectangle srcRect = new Rectangle(0, pictureBoxHeight - FinalPictureHeight, FinalPictureWidth, FinalPictureHeight);
            //描画する部分の範囲。位置(0,0)、大きさX*Yで描画する
            Rectangle desRect = new Rectangle(0, 0, FinalPictureWidth, FinalPictureHeight);
            //画像の一部を描画する
            g.DrawImage(canvas, desRect, srcRect, GraphicsUnit.Pixel);

            fillOutOfCanvas();
            update_LabelImgSize();
        }

        private void buttonFlipY_Click(object sender, EventArgs e)
        {
            if (!storeCurrentImage()) return;
            canvas.RotateFlip(RotateFlipType.Rotate180FlipX);
            //切り取る部分の範囲を決定する、開始位置XY、大きさX*Y
            Rectangle srcRect = new Rectangle(0, pictureBoxHeight - FinalPictureHeight, FinalPictureWidth, FinalPictureHeight);
            //描画する部分の範囲。位置(0,0)、大きさX*Yで描画する
            Rectangle desRect = new Rectangle(0, 0, FinalPictureWidth, FinalPictureHeight);
            //画像の一部を描画する
            g.DrawImage(canvas, desRect, srcRect, GraphicsUnit.Pixel);

            fillOutOfCanvas();
        }

        private void buttonFlipX_Click(object sender, EventArgs e)
        {
            if (!storeCurrentImage()) return;
            canvas.RotateFlip(RotateFlipType.Rotate180FlipY);
            //切り取る部分の範囲を決定する、開始位置XY、大きさX*Y
            Rectangle srcRect = new Rectangle(pictureBoxWidth - FinalPictureWidth, 0, FinalPictureWidth, FinalPictureHeight);
            //描画する部分の範囲。位置(0,0)、大きさX*Yで描画する
            Rectangle desRect = new Rectangle(0, 0, FinalPictureWidth, FinalPictureHeight);
            //画像の一部を描画する
            g.DrawImage(canvas, desRect, srcRect, GraphicsUnit.Pixel);

            fillOutOfCanvas();
        }

        private Bitmap FinalResize(Bitmap canvas)
        {
            //トリミング
            Rectangle srcRect = new Rectangle(0, 0, FinalPictureWidth, FinalPictureHeight);
            //描画する部分の範囲。位置(0,0)、大きさX * Yで描画する
            Rectangle desRect = new Rectangle(0, 0, srcRect.Width, srcRect.Height);

            //最終出力用
            Bitmap canvas0 = new Bitmap(FinalPictureWidth, FinalPictureHeight);
            Graphics g0 = Graphics.FromImage(canvas0);

            //画像の一部を描画する
            g0.DrawImage(canvas, desRect, srcRect, GraphicsUnit.Pixel);

            if (isPictureSmall) //アルゴリズムとして失敗したかも
            {
                canvas0 = new Bitmap(canvas0, (int)(FinalPictureWidth / pictureBoxPreviewRate), (int)(FinalPictureHeight / pictureBoxPreviewRate));
            }
            else
            {
                float finalResizeRate = Math.Min((float)numericUpDownOutputSize.Value / (float)FinalPictureWidth, (float)numericUpDownOutputSize.Value / (float)FinalPictureHeight);
                canvas0 = new Bitmap(canvas0, (int)(FinalPictureWidth * finalResizeRate), (int)(FinalPictureHeight * finalResizeRate));
            }
            return canvas0;
        }

        private void buttonSetImage2Clipboard_Click(object sender, EventArgs e)
        {
            Bitmap canvas0 = FinalResize(canvas);
            Clipboard.SetImage(canvas0);
        }

        private void textBoxFileName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter) return;
            if (File.Exists(textBoxFileName.Text))
            {
                PreviewDrowPicture();
            }
        }

        private void radioButtonOutputPNG_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOutputPNG.Checked)
            {
                groupBoxTransparent.Enabled = true;
            }
            else
            {
                groupBoxTransparent.Enabled = false;
                checkBoxTransparent.Checked = false;
            }
        }

        System.Drawing.Point px0;   //直したい台形の座標
        System.Drawing.Point px1;
        System.Drawing.Point px2;
        System.Drawing.Point px3;

        int countTrapezoidal = -1;

        private void buttonTrapezoidalCorrect_Click(object sender, EventArgs e)
        {
            countTrapezoidal = 0;
            buttonDrowMask.Enabled = true;
            buttonSquereLine.Enabled = true;
            buttonBlur.Enabled = true;
            buttonTrapezoidalCorrect.Enabled = false;
        }

        private void point_normarize(ref System.Drawing.Point px0, ref System.Drawing.Point px1, ref System.Drawing.Point px2, ref System.Drawing.Point px3)
        {
            System.Drawing.Point[] p = { px0, px1, px2, px3 };

            //左上の点を求める
            int[] x_y = { px0.X + px0.Y, px1.X + px1.Y, px2.X + px2.Y, px3.X + px3.Y };

            int tmp = 100000;
            int idx = 0;
            for (int i = 0; i < 4; i++)
            {
                if (x_y[i] < tmp)
                {
                    tmp = x_y[i];
                    idx = i;
                }
            }
            //左周りか右回りか
            int[] y = { px0.Y, px1.Y, px2.Y, px3.Y };

            if (y[(idx + 1) % 4] - y[idx] > y[(idx + 3) % 4] - y[idx])
            {
                //左回り
                px0 = p[idx];
                px1 = p[(idx + 1) % 4];
                px2 = p[(idx + 2) % 4];
                px3 = p[(idx + 3) % 4];
            }
            else
            {
                //右回り
                px0 = p[idx];
                px1 = p[(idx + 3) % 4];
                px2 = p[(idx + 2) % 4];
                px3 = p[(idx + 1) % 4];
            }
        }

        private void TrapezoidalCorrect()
        {
            point_normarize(ref px0, ref px1, ref px2, ref px3);

            int aveWidth = (px2.X + px3.X - px0.X - px1.X) / 2;
            int aveHight = (px1.Y + px2.Y - px3.Y - px0.Y) / 2;

            trapezoidal trapezoidal = new trapezoidal();
            double rate = 1;

            //canvas.Save("input.jpg"); //debug用
            Bitmap canvas_tmp = trapezoidal.main(isPictureSmall, canvas, reSizeRate, px0, px1, px2, px3, ref rate, FinalPictureWidth, FinalPictureHeight);
            g = Graphics.FromImage(canvas);

            FinalPictureWidth = (int)(aveWidth * rate * pictureBoxPreviewRate); //元の画像の切り抜いた部分の拡大率を保持
            FinalPictureHeight = (int)(aveHight * rate * pictureBoxPreviewRate);

            canvas_tmp = new Bitmap(canvas_tmp, FinalPictureWidth, FinalPictureHeight);
            //切り取る部分の範囲を決定する、開始位置、大きさX*Y
            Rectangle srcRect = new Rectangle(0, 0, FinalPictureWidth, FinalPictureHeight);
            //描画する部分の範囲。位置(0,0)、大きさX*Yで描画する
            Rectangle desRect = new Rectangle(0, 0, FinalPictureWidth, FinalPictureHeight);
            //画像の一部を描画する
            g.DrawImage(canvas_tmp, desRect, srcRect, GraphicsUnit.Pixel);

            fillOutOfCanvas();
            countTrapezoidal = -1;
            buttonTrapezoidalCorrect.Enabled = true;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (countTrapezoidal == -1) return;

            //Penオブジェクトの作成
            Color color = Color.FromArgb(250, 100, 150);
            p = new Pen(color, 4);
            if (countTrapezoidal == 0)
            {
                px0 = new System.Drawing.Point(e.Location.X, e.Location.Y);
                g2.DrawLine(p, px0, px0);
            }
            else if (countTrapezoidal == 1)
            {
                px1 = new System.Drawing.Point(e.Location.X, e.Location.Y);
                g2.DrawLine(p, px0, px1);
            }
            else if (countTrapezoidal == 2)
            {
                px2 = new System.Drawing.Point(e.Location.X, e.Location.Y);
                g2.DrawLine(p, px1, px2);
            }
            else if (countTrapezoidal == 3)
            {
                px3 = new System.Drawing.Point(e.Location.X, e.Location.Y);
                g2.DrawLine(p, px2, px3);
                g2.DrawLine(p, px3, px0);
                pictureBox2.Image = canvas2;
                Application.DoEvents();
                TrapezoidalCorrect();
            }
            pictureBox2.Image = canvas2;
            countTrapezoidal += 1;
        }
    }
}
