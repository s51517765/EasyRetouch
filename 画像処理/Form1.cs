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

        Color[,] pic = new Color[pictureBoxWidth, pictureBoxHeight];

        //描画先とするImageオブジェクトを作成する
        Bitmap canvas = new Bitmap(pictureBoxWidth, pictureBoxHeight);

        private void storeCurrentImage()
        {
            // https://dobon.net/vb/dotnet/graphics/imagefromfile.html
            try
            {
                Image img = pictureBox1.Image;
                Bitmap bitmap = new Bitmap(img);


                for (int x = 0; x < FinalPictureWidth; x++)
                {
                    for (int y = 0; y < FinalPictureHeight; y++)
                    {
                        pic[x, y] = bitmap.GetPixel(x, y);
                    }
                }
            }
            catch
            {
                //pass
            }
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < FinalPictureWidth; x++)
            {
                for (int y = 0; y < FinalPictureHeight; y++)
                {
                    canvas.SetPixel(x, y, pic[x, y]);
                }
            }
            pictureBox1.Image = canvas;
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

                //Graphicsオブジェクトのリソースを解放する
                g.Dispose();

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
            Graphics g = Graphics.FromImage(canvas);
            SolidBrush brush = new SolidBrush(Color.Gainsboro);

            g.FillRectangle(brush, FinalPictureWidth, 0, 1000, 700);
            g.FillRectangle(brush, 0, FinalPictureHeight, 1000, 700);
            g.Dispose();
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
                Graphics g = Graphics.FromImage(canvas);

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
            storeCurrentImage();

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
            storeCurrentImage();

            FlagMask = 1;
            buttonDrowMask.Enabled = false;
            buttonSquereLine.Enabled = true;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            storeCurrentImage();

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

            if (FlagMask == 1)
            {
                Mask_address[0] = e.Location.X;//配列の0番にクリックした座標を入れる
                Mask_address[1] = e.Location.Y;//配列の1番にクリックした座標を入れる
                FlagMask = 2;

                //ImageオブジェクトのGraphicsオブジェクトを作成する
                Graphics g = Graphics.FromImage(canvas);

                //Penオブジェクトの作成(幅1の黒色)
                Pen p = new Pen(brush, 1);
                g.DrawRectangle(p, Mask_address[0], Mask_address[1], 1, 1);
                g.Dispose();
            }
            else if (FlagMask == 2)
            {
                Mask_address[2] = e.Location.X;//配列の2番に現在の座標を入れる
                Mask_address[3] = e.Location.Y;//配列の3番に現在の座標を入れる

                if (Mask_address[0] > Mask_address[2]) swap_address(ref Mask_address[0], ref Mask_address[2]);
                if (Mask_address[1] > Mask_address[3]) swap_address(ref Mask_address[1], ref Mask_address[3]);

                //ImageオブジェクトのGraphicsオブジェクトを作成する
                Graphics g = Graphics.FromImage(canvas);

                //Penオブジェクトの作成(幅1の黒色)
                Pen p = new Pen(Color.Black, 1);
                //長方形を描く
                int size_x = Mask_address[2] - Mask_address[0];
                int size_y = Mask_address[3] - Mask_address[1];
                if (size_x > 0 && size_y > 0)
                {
                    g.FillRectangle(brush, Mask_address[0], Mask_address[1], size_x, size_y);
                }
                else if (size_x < 0 && size_y < 0)
                {
                    g.FillRectangle(brush, Mask_address[2], Mask_address[3], -size_x, -size_y);
                }
                //リソースを解放する
                p.Dispose();
                g.Dispose();

                buttonDrowMask.Enabled = true;
                FlagMask = 0;

                fillOutOfCanvas();
            }
            else if (FlagMask == 3)
            {
                Mask_address[0] = e.Location.X;//配列の0番にクリックした座標を入れる
                Mask_address[1] = e.Location.Y;//配列の1番にクリックした座標を入れる
                FlagMask = 4;

                //ImageオブジェクトのGraphicsオブジェクトを作成する
                Graphics g = Graphics.FromImage(canvas);

                //Penオブジェクトの作成(幅1の黒色)
                Pen p = new Pen(color, 1);
                g.DrawRectangle(p, Mask_address[0], Mask_address[1], 1, 1);
                g.Dispose();
            }
            else if (FlagMask == 4)
            {
                Mask_address[2] = e.Location.X;//配列の2番に現在の座標を入れる
                Mask_address[3] = e.Location.Y;//配列の3番に現在の座標を入れる

                if (Mask_address[0] > Mask_address[2]) swap_address(ref Mask_address[0], ref Mask_address[2]);
                if (Mask_address[1] > Mask_address[3]) swap_address(ref Mask_address[1], ref Mask_address[3]);

                //ImageオブジェクトのGraphicsオブジェクトを作成する
                Graphics g = Graphics.FromImage(canvas);

                //Penオブジェクトの作成(幅** Color)
                Pen p = new Pen(color, (float)numericUpDownLineWidth.Value);
                //長方形を描く
                int size_x = Mask_address[2] - Mask_address[0];
                int size_y = Mask_address[3] - Mask_address[1];
                if (size_x > 0 && size_y > 0)
                {
                    g.DrawRectangle(p, Mask_address[0], Mask_address[1], size_x, size_y);

                }
                else if (size_x < 0 && size_y < 0)
                {
                    g.FillRectangle(brush, Mask_address[2], Mask_address[3], -size_x, -size_y);
                }
                //リソースを解放する
                p.Dispose();
                g.Dispose();

                buttonSquereLine.Enabled = true;
                FlagMask = 0;

                fillOutOfCanvas();
            }
        }
        private void swap_address(ref int a, ref int b)
        {
            int tmp;
            tmp = a;
            a = b;
            b = tmp;
        }

        private void buttonSquereLine_Click(object sender, EventArgs e)
        {
            storeCurrentImage();

            FlagMask = 3;
            buttonSquereLine.Enabled = false;
            buttonDrowMask.Enabled = true;
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
            storeCurrentImage();
            Image img = pictureBox1.Image;
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

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

            //Graphicsオブジェクトのリソースを解放する
            g.Dispose();

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
    }
}
