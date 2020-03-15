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

        }

        //using System.Drawing;
        const int pictureBoxWidth = 1000;
        const int pictureBoxHeight = 750;
        int FinalPictureWidth = 1000;
        int FinalPictureHeight = 750;
        float reSizeRate;

        //描画先とするImageオブジェクトを作成する
        Bitmap canvas = new Bitmap(pictureBoxWidth, pictureBoxHeight);
        Graphics g;
        Bitmap backupImage;

        private bool storeCurrentImage()
        {
            try
            {
                // 画像のバックアップを取得
                backupImage = new Bitmap(pictureBox1.Image);
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
            try
            {
                // 先にバックアップしていた画像で塗り潰す
                if (backupImage != null) g.DrawImage(backupImage, 0, 0);
                pictureBox1.Image = canvas;
            }
            catch
            {
                //pass
            }
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
                //リサイズ率が小さいほう
                reSizeRate = ((float)pictureBox1.Width / (float)img.Width) < ((float)pictureBox1.Height / (float)img.Height) ? (float)pictureBox1.Width / (float)img.Width : (float)pictureBox1.Height / (float)img.Height;

                if (reSizeRate > 1) reSizeRate = 1; //小さい画像は拡大しない
                //画像をcanvasの座標(0, 0)の位置に描画する
                float w = (float)img.Width;
                float h = (float)img.Height;
                FinalPictureHeight = (int)(h * reSizeRate);
                FinalPictureWidth = (int)(w * reSizeRate);
                g.DrawImage(img, 0, 0, (int)(w * reSizeRate), (int)(h * reSizeRate));
                //Imageオブジェクトのリソースを解放する
                img.Dispose();

                labelStartMsg1.Visible = false;
                labelStartMsg2.Visible = false;
                labelStartMsg3.Visible = false;
                labelStartMsg4.Visible = false;

                fillOutOfCanvas();
            }
            catch
            {
                //pass
            }
        }
        private void fillOutOfCanvas()
        {   //ImageオブジェクトのGraphicsオブジェクトを作成する
            g = Graphics.FromImage(canvas);
            SolidBrush brush = new SolidBrush(Color.Gainsboro);

            g.FillRectangle(brush, FinalPictureWidth, 0, 1000, 1000);
            g.FillRectangle(brush, 0, FinalPictureHeight, 1000, 1000);

            pictureBox1.Image = canvas;
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
            if (pictureBox1.Image != null)
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

                //描画先とするImageオブジェクトを作成する
                Bitmap canvas = new Bitmap(FinalPictureWidth, FinalPictureHeight);
                //ImageオブジェクトのGraphicsオブジェクトを作成する
                g = Graphics.FromImage(canvas);

                //トリミング
                Rectangle srcRect = new Rectangle(0, 0, FinalPictureWidth, FinalPictureHeight);
                //描画する部分の範囲。位置(0,0)、大きさX * Yで描画する
                Rectangle desRect = new Rectangle(0, 0, FinalPictureWidth, FinalPictureHeight);

                //画像の一部を描画する
                g.DrawImage(pictureBox1.Image, desRect, srcRect, GraphicsUnit.Pixel);

                string suffix = textBoxSuffix.Text;

                int suffix_no = 0;
                while (System.IO.File.Exists(FileName + suffix + (suffix_no == 0 ? "" : suffix_no.ToString()) + ".jpg"))
                {
                    suffix_no += 1;
                }

                canvas.Save(FileName + suffix + (suffix_no == 0 ? "" : suffix_no.ToString()) + ".jpg");
            }
        }

        private void buttonDrowEdgeLine_Click(object sender, EventArgs e)
        {
            if (!storeCurrentImage()) return;

            Color color;
            if (radioButtonDrowEdge_Red.Checked) color = Color.FromArgb(255, 0, 0);
            else if (radioButtonDrowEdge_Yellow.Checked) color = Color.FromArgb(255, 255, 0);
            else if (radioButtonDrowEdge_Green.Checked) color = Color.FromArgb(0, 255, 0);
            else if (radioButtonDrowEdge_Blue.Checked) color = Color.FromArgb(0, 0, 255);
            else color = Color.FromArgb(0, 0, 0);

            for (int x = 0; x < FinalPictureWidth; x++)
            {
                canvas.SetPixel(x, 0, color);
            }
            for (int y = 0; y < FinalPictureHeight; y++)
            {
                canvas.SetPixel(0, y, color);
            }
            for (int x = 0; x < FinalPictureWidth; x++)
            {
                canvas.SetPixel(x, FinalPictureHeight - 1, color);
            }
            for (int y = 0; y < FinalPictureHeight; y++)
            {
                canvas.SetPixel(FinalPictureWidth - 1, y, color);
            }
            pictureBox1.Image = canvas;
        }

        int FlagMask = 0;
        int[] Mask_address = new int[4]; //start x ,start y, end x, end y

        private void buttonDrowMask_Click(object sender, EventArgs e)
        {
            if (!storeCurrentImage()) return;

            FlagMask = 1;
            buttonDrowMask.Enabled = false;
            buttonSquereLine.Enabled = true;
        }

        private void buttonSquereLine_Click(object sender, EventArgs e)
        {
            if (!storeCurrentImage()) return;

            FlagMask = 3;
            buttonSquereLine.Enabled = false;
            buttonDrowMask.Enabled = true;
        }

        private void swap_address(ref int a, ref int b)
        {
            int tmp;
            tmp = a;
            a = b;
            b = tmp;
        }

        private void buttonSnappingTool_Click(object sender, EventArgs e)
        {
            try
            {
                //  using System.Diagnostics;
                var app = new ProcessStartInfo();
                app.FileName = "SnippingToolexe";
                app.UseShellExecute = true;

                Process.Start(app);
            }
            catch
            {
                MessageBox.Show("起動できませんでした。");
            }
        }

        private void buttonTrimming_Click(object sender, EventArgs e)
        {
            if (!storeCurrentImage()) return;
            Image img = pictureBox1.Image;
            if (img == null) return;

            //ImageオブジェクトのGraphicsオブジェクトを作成する
            g = Graphics.FromImage(canvas);

            //切り取る部分の範囲を決定する。
            int up = (int)numericUpDownTrimUp.Value;
            int down = (int)numericUpDownTrimDown.Value;
            int right = (int)numericUpDownTrimRight.Value;
            int left = (int)numericUpDownTrimLeft.Value;
            FinalPictureWidth -= (right + left);
            FinalPictureHeight -= (up + down);

            Rectangle srcRect = new Rectangle(left, up, FinalPictureWidth, FinalPictureHeight);
            //描画する部分の範囲。位置(0,0)、大きさX*Yで描画する
            Rectangle desRect = new Rectangle(0, 0, FinalPictureWidth, FinalPictureHeight);
            //画像の一部を描画する
            g.DrawImage(img, desRect, srcRect, GraphicsUnit.Pixel);

            fillOutOfCanvas();
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

        Point startPoint;
        Point endPoint;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!storeCurrentImage()) return;

            startPoint.X = e.Location.X;//配列の0番にクリックした座標を入れる
            startPoint.Y = e.Location.Y;//配列の1番にクリックした座標を入れる
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.FromArgb(100, 200, 0, 00));
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

            if (FlagMask == 3) //Line
            {
                //ImageオブジェクトのGraphicsオブジェクトを作成する
                g = Graphics.FromImage(canvas);

                // マウスの左ボタンが押されている場合のみ処理
                if ((Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left)
                {
                    // 座標を取得
                    endPoint.X = e.Location.X;
                    endPoint.Y = e.Location.Y;

                    // 描画
                    Point p0 = new Point(startPoint.X, startPoint.Y);
                    Point p1 = new Point(endPoint.X, startPoint.Y);
                    Point p2 = new Point(startPoint.X, endPoint.Y);
                    Point p3 = new Point(endPoint.X, endPoint.Y);

                    int size_x = Math.Abs(startPoint.X - endPoint.X);
                    int size_y = Math.Abs(startPoint.Y - endPoint.Y);

                    // 先にバックアップしていた画像で塗り潰す
                    if (backupImage != null) g.DrawImage(backupImage, 0, 0);

                    //Penオブジェクトの作成(幅1の黒色)
                    Pen p = new Pen(color, (float)numericUpDownLineWidth.Value);

                    g.DrawRectangle(p, Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y), size_x, size_y);
                    pictureBox1.Image = canvas;

                }

            }
            else if (FlagMask == 1) //Mask
            {
                //ImageオブジェクトのGraphicsオブジェクトを作成する
                g = Graphics.FromImage(canvas);

                // マウスの左ボタンが押されている場合のみ処理
                if ((Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left)
                {
                    // 座標を取得
                    endPoint.X = e.Location.X;
                    endPoint.Y = e.Location.Y;

                    // 描画
                    Point p0 = new Point(startPoint.X, startPoint.Y);
                    Point p1 = new Point(endPoint.X, startPoint.Y);
                    Point p2 = new Point(startPoint.X, endPoint.Y);
                    Point p3 = new Point(endPoint.X, endPoint.Y);

                    int size_x = Math.Abs(startPoint.X - endPoint.X);
                    int size_y = Math.Abs(startPoint.Y - endPoint.Y);

                    // 先にバックアップしていた画像で塗り潰す
                    if (backupImage != null) g.DrawImage(backupImage, 0, 0);

                    g.FillRectangle(brush, Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y), size_x, size_y);
                    pictureBox1.Image = canvas;
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void buttonTrimingValueReset_Click(object sender, EventArgs e)
        {
            numericUpDownTrimUp.Value = 0;
            numericUpDownTrimDown.Value = 0;
            numericUpDownTrimRight.Value = 0;
            numericUpDownTrimLeft.Value = 0;
        }
    }
}
