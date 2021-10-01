using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 画像処理
{
    class trapezoidal : Form1
    {
        int imgSizeX, imgSizeY;

        private double solve_squere_line(bool isPictureSmall, float reSizeRate, System.Drawing.Point px0, System.Drawing.Point px1, System.Drawing.Point px2, System.Drawing.Point px3, ref int[] x, ref int[] y)
        {
            double[] px_ = { px0.X, px1.X, px2.X, px3.X };
            double[] py_ = { px0.Y, px1.Y, px2.Y, px3.Y };
            if (isPictureSmall)
            {
                for (int i = 0; i < px_.Length; i++)
                {
                    px_[i] = px_[i] * pictureBoxPreviewRate;
                    py_[i] = py_[i] * pictureBoxPreviewRate;
                }
            }
            else
            {
                for (int i = 0; i < px_.Length; i++)
                {
                    px_[i] = px_[i] / reSizeRate * pictureBoxPreviewRate;
                    py_[i] = py_[i] / reSizeRate * pictureBoxPreviewRate;
                }
            }

            System.Drawing.Point COG = new System.Drawing.Point(); //Center of Gravity
            COG.X = (int)(px_[0] + px_[1] + px_[2] + px_[3]) / 4;
            COG.Y = (int)(py_[0] + py_[1] + py_[2] + py_[3]) / 4;

            double min = 1.01;
            double max = 1000;
            double rate = min + max / 2;

            double[] px = new double[4];
            double[] py = new double[4];

            while (true) //点が画像の中なら
            {
                for (int i = 0; i < 4; i++)
                {
                    px[i] = rate * (px_[i] - COG.X) + COG.X;
                    py[i] = rate * (py_[i] - COG.Y) + COG.Y;
                }

                //画像のサイズの中かどうか
                for (int i = 0; i < 4; i++)
                {
                    if (px[i] < 1 || imgSizeX - 1 < px[i] || py[i] < 1 || imgSizeY - 1 < py[i])
                    {
                        //画像の外
                        max = rate;
                        rate = min + (rate - min) / 2;
                        break;
                    }
                    if (i == 3)
                    {
                        min = rate;
                        rate = rate + (max - rate) / 2;
                    }
                }
                if (Math.Abs(max - min) < 0.00001) break; //MaxとMinが一致したら
            }
            for (int i = 0; i < 4; i++)
            {
                if (!isPictureSmall)
                {
                    px[i] *= reSizeRate;
                    py[i] *= reSizeRate;
                }
                x[i] = (int)px[i];
                y[i] = (int)py[i];
            }
            return rate;
        }

        public Bitmap main(bool isPictureSmall, Bitmap canvas, float reSizeRate, System.Drawing.Point px0, System.Drawing.Point px1, System.Drawing.Point px2, System.Drawing.Point px3, ref double rate, int FinalPictureWidth, int FinalPictureHeight)
        {
            Image img = canvas;

            imgSizeX = FinalPictureWidth;
            imgSizeY = FinalPictureHeight;

            int[] x = new int[4];
            int[] y = new int[4];

            rate = solve_squere_line(isPictureSmall, reSizeRate, px0, px1, px2, px3, ref x, ref y);
            px0.X = x[0];
            px0.Y = y[0];
            px1.X = x[1];
            px1.Y = y[1];
            px2.X = x[2];
            px2.Y = y[2];
            px3.X = x[3];
            px3.Y = y[3];

            // 四角形で切り取って表示
            System.Drawing.Point[] p2pt = { px0, px1, px2, px3 };

            // p2の四角形を引き伸ばして表示する
            Mat src_img = BitmapConverter.ToMat((Bitmap)img);
            Mat dst_img = src_img;

            // 四角形の変換前と変換後の対応する頂点をそれぞれセットする
            Point2f[] src_pt = new Point2f[4];
            src_pt[0] = new Point2f(px0.X, px0.Y);
            src_pt[1] = new Point2f(px1.X, px1.Y);
            src_pt[2] = new Point2f(px2.X, px2.Y);
            src_pt[3] = new Point2f(px3.X, px3.Y);

            Point2f[] dst_pt = new Point2f[4];
            dst_pt[0] = new Point2f(0, 0);      //左上
            dst_pt[1] = new Point2f(0, imgSizeY);    //左下
            dst_pt[2] = new Point2f(imgSizeX, imgSizeY);  //右下
            dst_pt[3] = new Point2f(imgSizeX, 0);    //右上

            Mat map_matrix = Cv2.GetPerspectiveTransform(src_pt, dst_pt);

            // 指定された透視投影変換行列により，cvWarpPerspectiveを用いて画像を変換させる
            OpenCvSharp.Size mysize = new OpenCvSharp.Size(imgSizeX, imgSizeY);
            InterpolationFlags OIFLiner = InterpolationFlags.Linear;
            BorderTypes OBTDefault = BorderTypes.Default;
            Cv2.WarpPerspective(src_img, dst_img, map_matrix, mysize, OIFLiner, OBTDefault);
            dst_img.SaveImage("trapezoidal.jpg");
            return dst_img.ToBitmap();
        }
    }

}
