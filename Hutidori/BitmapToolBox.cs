using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace BitmapTool {
    public class BitmapByteArray : ICloneable {
        public byte[,] R;
        public byte[,] G;
        public byte[,] B;
        public byte[,] A;
        public int Width;
        public int Height;

        private BitmapByteArray() {
            this.R = null;
            this.G = null;
            this.B = null;
            this.A = null;
            this.Width = 0;
            this.Height = 0;
        }

        public BitmapByteArray(int w, int h) {
            this.R = new byte[w, h];
            this.G = new byte[w, h];
            this.B = new byte[w, h];
            this.A = new byte[w, h];
            this.Width = w;
            this.Height = h;
        }

        public unsafe Bitmap ToBitmap() {
            Bitmap bmp = new Bitmap(this.Width, this.Height, PixelFormat.Format32bppArgb);

            GraphicsUnit unit = GraphicsUnit.Pixel;
            RectangleF boundsF = bmp.GetBounds(ref unit);
            Rectangle bounds = new Rectangle((int)boundsF.Left, (int)boundsF.Top,
                (int)boundsF.Width, (int)boundsF.Height);
            BitmapData bitmapData = bmp.LockBits(bounds, ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);

            int xMax = bitmapData.Width;
            int yMax = bitmapData.Height;
            byte* pixelPtr = (byte*)bitmapData.Scan0.ToPointer();

            for (int y = 0; y < yMax; y++) {
                for (int x = 0; x < xMax; x++) {
                    byte* pixel = pixelPtr + (y * bitmapData.Stride) + x * 4;
                    *(pixel + 0) = this.B[x, y];
                    *(pixel + 1) = this.G[x, y];
                    *(pixel + 2) = this.R[x, y];
                    *(pixel + 3) = this.A[x, y];
                }
            }
            bmp.UnlockBits(bitmapData);
            return bmp;
        }

        public static unsafe BitmapByteArray FromBitmap(Bitmap bmp) {
            if (bmp.PixelFormat != PixelFormat.Format32bppArgb) {
                throw new ApplicationException("this is not 32bpp bitmap");
            }
            BitmapByteArray ba = new BitmapByteArray(bmp.Width, bmp.Height);

            GraphicsUnit unit = GraphicsUnit.Pixel;
            RectangleF boundsF = bmp.GetBounds(ref unit);
            Rectangle bounds = new Rectangle((int)boundsF.Left, (int)boundsF.Top,
                (int)boundsF.Width, (int)boundsF.Height);
            BitmapData bitmapData = bmp.LockBits(bounds, ImageLockMode.ReadWrite,
                PixelFormat.Format32bppArgb);

            int xMax = bitmapData.Width;
            int yMax = bitmapData.Height;
            byte* pixelPtr = (byte*)bitmapData.Scan0.ToPointer();

            for (int y = 0; y < yMax; y++) {
                for (int x = 0; x < xMax; x++) {
                    byte* pixel = pixelPtr + (y * bitmapData.Stride) + x * 4;
                    byte b = *(pixel + 0);
                    byte g = *(pixel + 1);
                    byte r = *(pixel + 2);
                    byte a = *(pixel + 3);

                    ba.R[x, y] = r;
                    ba.G[x, y] = g;
                    ba.B[x, y] = b;
                    ba.A[x, y] = a;
                }
            }
            bmp.UnlockBits(bitmapData);

            return ba;
        }


        #region ICloneable メンバ

        public object Clone() {
            BitmapByteArray bba = new BitmapByteArray();
            bba.R = (byte[,])this.R.Clone();
            bba.G = (byte[,])this.G.Clone();
            bba.B = (byte[,])this.B.Clone();
            bba.A = (byte[,])this.A.Clone();
            bba.Width = this.Width;
            bba.Height = this.Height;
            return bba;
        }

        #endregion
    }


    public static class BitmapToolBox {

        public static BitmapByteArray LoadBitmap(string filename) {
            if (!File.Exists(filename)) {
                throw new Exception("ファイル" + filename + "は存在しません");
            }

            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            Bitmap bmp = (Bitmap)Bitmap.FromStream(fs, false, true);
            bmp = To32Bpp(bmp);
            BitmapByteArray bba = BitmapByteArray.FromBitmap(bmp);
            if (fs != null) {
                fs.Close();
            }

            string pnafilename = Path.GetDirectoryName(filename) + "\\" + Path.GetFileNameWithoutExtension(filename) + ".pna";

            if (File.Exists(pnafilename)) {
                FileStream pfs = new FileStream(pnafilename, FileMode.Open, FileAccess.Read, FileShare.Read);
                Bitmap pbmp = (Bitmap)Bitmap.FromStream(pfs, false, true);
                pbmp = To32Bpp(pbmp);
                BitmapByteArray pbba = BitmapByteArray.FromBitmap(pbmp);
                if (pfs != null) {
                    pfs.Close();
                }
                ApplyPNA(bba, pbba);
            } else {
                ApplyOpaque(bba);
            }

            return bba;
        }

        public static void SaveBitmap32(string filename, BitmapByteArray bba, bool isBackup) {
            if (isBackup) {
                if (File.Exists(filename)) {
                    FileInfo fi = new FileInfo(filename);
                    fi.CopyTo(filename + ".bak", true);
                }
            }
            Bitmap bmp = bba.ToBitmap();
            bmp.Save(filename, ImageFormat.Png);
        }

        public static void SaveBitmap24(string filename, BitmapByteArray bba, bool isSimplePNA, Color backcolor, bool isBackup) {
            if (isBackup) {
                if (File.Exists(filename)) {
                    FileInfo fi = new FileInfo(filename);
                    fi.CopyTo(filename + ".bak", true);
                }
            }
            BitmapByteArray bba24 = Get24BBA(bba, backcolor);
            Bitmap bmp32 = bba24.ToBitmap();
            Bitmap bmp24 = To24Bpp(bmp32);
            bmp24.Save(filename, ImageFormat.Png);

            bool isSimple;
            BitmapByteArray bbaa = GetPNABBA(bba, out isSimple);

            if (isSimplePNA == true && isSimple == true) {
                //donothing
            } else {
                string pnafilename = Path.GetDirectoryName(filename) + "\\" + Path.GetFileNameWithoutExtension(filename) + ".pna";
                if (isBackup) {
                    if (File.Exists(pnafilename)) {
                        FileInfo fi = new FileInfo(pnafilename);
                        fi.CopyTo(pnafilename + ".bak", true);
                    }
                }
                Bitmap bmpa32 = bbaa.ToBitmap();
                Bitmap bmpa24 = To24Bpp(bmpa32);
                bmpa24.Save(pnafilename, ImageFormat.Png);
            }

        }

        private static BitmapByteArray Get24BBA(BitmapByteArray bba, Color backcolor) {
            BitmapByteArray newBba = (BitmapByteArray)bba.Clone();

            for (int y = 0; y < newBba.Height; y++) {
                for (int x = 0; x < newBba.Width; x++) {
                    if (newBba.A[x, y] == 0) {
                        newBba.R[x, y] = backcolor.R;
                        newBba.G[x, y] = backcolor.G;
                        newBba.B[x, y] = backcolor.B;
                        newBba.A[x, y] = 255;
                    } else {
                        newBba.A[x, y] = 255;
                    }

                }
            }
            return newBba;
        }


        private static BitmapByteArray GetPNABBA(BitmapByteArray bba, out bool isSimple) {
            BitmapByteArray newBba = new BitmapByteArray(bba.Width, bba.Height);

            isSimple = true;

            for (int y = 0; y < newBba.Height; y++) {
                for (int x = 0; x < newBba.Width; x++) {
                    newBba.R[x, y] = bba.A[x, y];
                    newBba.G[x, y] = bba.A[x, y];
                    newBba.B[x, y] = bba.A[x, y];
                    newBba.A[x, y] = 255;
                    if (bba.A[x, y] != 0 && bba.A[x, y] != 255) {
                        isSimple = false;
                    }
                }
            }
            return newBba;
        }


        private static void ApplyOpaque(BitmapByteArray bba) {
            byte a = bba.A[0, 0];
            byte r = bba.R[0, 0];
            byte g = bba.G[0, 0];
            byte b = bba.B[0, 0];

            for (int y = 0; y < bba.Height; y++) {
                for (int x = 0; x < bba.Width; x++) {
                    if (bba.A[x, y] == a &&
                        bba.R[x, y] == r &&
                        bba.G[x, y] == g &&
                        bba.B[x, y] == b ) {

                        bba.A[x, y] = 0;
                        bba.R[x, y] = 0;
                        bba.G[x, y] = 0;
                        bba.B[x, y] = 0;
                    }
                }
            }
        }

        private static unsafe void ApplyPNA(BitmapByteArray bba, BitmapByteArray pbba) {
            if (bba.Width != pbba.Width || bba.Height != pbba.Height) {
                throw new Exception("PNAの大きさがPNGと異なります");
            }

            for (int y = 0; y < bba.Height; y++) {
                for (int x = 0; x < bba.Width; x++) {
                    bba.A[x, y] = (byte)((pbba.R[x, y] + pbba.G[x, y] + pbba.B[x, y]) / 3);
                }
            }
        }

        public static Bitmap To32Bpp(Bitmap bmp) {
            Bitmap newBmp = new Bitmap(bmp.Width, bmp.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(newBmp);
            g.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 0, 0)), 0, 0, newBmp.Width, newBmp.Height);
            g.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
            g.Dispose();
            return newBmp;
        }

        public static Bitmap To24Bpp(Bitmap bmp) {
            Bitmap newBmp = new Bitmap(bmp.Width, bmp.Height, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(newBmp);
            g.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 0, 0)), 0, 0, newBmp.Width, newBmp.Height);
            g.DrawImage(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
            g.Dispose();
            return newBmp;
        }


        public static BitmapByteArray ResizeHQB(BitmapByteArray bba, int width, int height) {
            Bitmap srcBmp = bba.ToBitmap();
            Bitmap newBmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(newBmp);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawImage(srcBmp, new Rectangle(0, 0, width, height), new Rectangle(0, 0, srcBmp.Width, srcBmp.Height), GraphicsUnit.Pixel);
            g.Dispose();
            bba = BitmapByteArray.FromBitmap(newBmp); 
            return bba;
        }

        public static void UntiUntiAlias(BitmapByteArray bba, byte alpha,bool isDrop,bool isUp) {
            Threshold(bba, alpha, 255, 0, isUp, isDrop);
        }

        public static void Threshold(BitmapByteArray bba, byte alpha, byte big, byte small, bool isBig, bool isSmall) {
            for (int y = 0; y < bba.Height; y++) {
                for (int x = 0; x < bba.Width; x++) {
                    if (bba.A[x, y] < alpha) {
                        if (isSmall) {
                            bba.A[x, y] = small;
                        }
                    } else {
                        if (isBig) {
                            bba.A[x, y] = big;
                        }
                    }
                }
            }
        }

        public static BitmapByteArray OverWriteBBA(BitmapByteArray b1, BitmapByteArray b2) {
            if (b1.Width != b2.Width || b1.Height != b2.Height) {
                throw new Exception("BitmapByteArrayの大きさが異なります");
            }

            BitmapByteArray newbba = new BitmapByteArray(b1.Width, b1.Height);

            for (int y = 0; y < b1.Height; y++) {
                for (int x = 0; x < b1.Width; x++) {
                    if (b2.A[x, y] == 0) {
                        newbba.A[x, y] = b1.A[x, y];
                        newbba.R[x, y] = b1.R[x, y];
                        newbba.G[x, y] = b1.G[x, y];
                        newbba.B[x, y] = b1.B[x, y];
                    } else {
                        newbba.A[x, y] = b2.A[x, y];
                        newbba.R[x, y] = b2.R[x, y];
                        newbba.G[x, y] = b2.G[x, y];
                        newbba.B[x, y] = b2.B[x, y];
                    }
                }
            }

            return newbba;
        }

        public static BitmapByteArray PutBBA(BitmapByteArray b1, BitmapByteArray b2) {
            if (b1.Width != b2.Width || b1.Height != b2.Height) {
                throw new Exception("BitmapByteArrayの大きさが異なります");
            }

            BitmapByteArray newbba = new BitmapByteArray(b1.Width, b1.Height);

            for (int y = 0; y < b1.Height; y++) {
                for (int x = 0; x < b1.Width; x++) {
                    Color newcol = PutColor(
                        Color.FromArgb(b1.A[x, y], b1.R[x, y], b1.G[x, y], b1.B[x, y]),
                        Color.FromArgb(b2.A[x, y], b2.R[x, y], b2.G[x, y], b2.B[x, y])
                        );
                    newbba.A[x, y] = newcol.A;
                    newbba.R[x, y] = newcol.R;
                    newbba.G[x, y] = newcol.G;
                    newbba.B[x, y] = newcol.B;
                }
            }

            return newbba;
        }

        public static Color PutColor(Color dst, Color src) {
            double As = src.A / 255.0;
            double Ad = dst.A / 255.0;
            double newA = (As + (1.0 - As) * Ad);

            if (newA == 0) {
                return Color.FromArgb(0, 0, 0, 0);
            }

            return Color.FromArgb(
                (int)(newA * 255.0),
                (int)((As * src.R + (1.0 - As) * Ad * dst.R)/newA),
                (int)((As * src.G + (1.0 - As) * Ad * dst.G) / newA),
                (int)((As * src.B + (1.0 - As) * Ad * dst.B) / newA)
                );
        }

        /*
        public static Color MergeColor(Color src, Color dst, double dstRatioC, double dstRatioA) {
            double bunbo = (dstRatioC * dst.A + (1 - dstRatioC) * src.A);
            if (bunbo == 0) {
                return Color.FromArgb(0, 0, 0, 0);
            }

            return Color.FromArgb(
                (int)((dstRatioA * dst.A + (1 - dstRatioA) * src.A)),
                (int)((dstRatioC * dst.A * dst.R + (1 - dstRatioC) * src.A * src.R) / bunbo),
                (int)((dstRatioC * dst.A * dst.G + (1 - dstRatioC) * src.A * src.G) / bunbo),
                (int)((dstRatioC * dst.A * dst.B + (1 - dstRatioC) * src.A * src.B) / bunbo)
                );
        }
        public static BitmapByteArray MergeBBA(BitmapByteArray b1, BitmapByteArray b2, double dstratioC, double dstratioA) {
            if (b1.Width != b2.Width || b1.Height != b2.Height) {
                throw new Exception("BitmapByteArrayの大きさが異なります");
            }

            BitmapByteArray newbba = new BitmapByteArray(b1.Width, b1.Height);

            for (int y = 0; y < b1.Height; y++) {
                for (int x = 0; x < b1.Width; x++) {
                    Color newcol = MergeColor(
                        Color.FromArgb(b1.A[x, y], b1.R[x, y], b1.G[x, y], b1.B[x, y]),
                        Color.FromArgb(b2.A[x, y], b2.R[x, y], b2.G[x, y], b2.B[x, y]),
                        dstratioC,
                        dstratioA
                        );
                    newbba.A[x, y] = newcol.A;
                    newbba.R[x, y] = newcol.R;
                    newbba.G[x, y] = newcol.G;
                    newbba.B[x, y] = newcol.B;
                }
            }

            return newbba;
        }
         */


        public static BitmapByteArray ApplyFilter(BitmapByteArray bba, double[,] filter) {
            BitmapByteArray newbba = new BitmapByteArray(bba.Width, bba.Height);
            int fw = filter.GetLength(0) / 2;
            int fh = filter.GetLength(1) / 2;

            for (int y = 0; y < bba.Height; y++) {
                for (int x = 0; x < bba.Width; x++) {
                    double r = 0;
                    double g = 0;
                    double b = 0;
                    double a = 0;

                    for (int yy = -fh; yy <= fh; yy++) {
                        if (y + yy < 0 || y + yy >= bba.Height) continue;
                        for (int xx = -fw; xx <= fw; xx++) {
                            if (x + xx < 0 || x + xx >= bba.Width) continue;

                            r += bba.R[x + xx, y + yy] * filter[xx + fw, yy + fh];
                            g += bba.G[x + xx, y + yy] * filter[xx + fw, yy + fh];
                            b += bba.B[x + xx, y + yy] * filter[xx + fw, yy + fh];
                            a += bba.A[x + xx, y + yy] * filter[xx + fw, yy + fh];
                        }
                    }

                    newbba.R[x, y] = D2B(r);
                    newbba.G[x, y] = D2B(g);
                    newbba.B[x, y] = D2B(b);
                    newbba.A[x, y] = D2B(a);
                }
            }

            return newbba;
        }

        public static byte[,] ApplyFilterOne(byte[,] bba, double[,] filter) {
            int w = bba.GetLength(0);
            int h = bba.GetLength(1);

            byte[,] newbba = new byte[bba.GetLength(0), bba.GetLength(1)];
            int fw = filter.GetLength(0) / 2;
            int fh = filter.GetLength(1) / 2;

            for (int y = 0; y < h; y++) {
                for (int x = 0; x < w; x++) {
                    double s = 0;

                    for (int yy = -fh; yy <= fh; yy++) {
                        if (y + yy < 0 || y + yy >= h) continue;
                        for (int xx = -fw; xx <= fw; xx++) {
                            if (x + xx < 0 || x + xx >= w) continue;

                            s += (double)bba[x + xx, y + yy] * filter[xx + fw, yy + fh];
                        }
                    }

                    newbba[x, y] = D2B(s);
                }
            }

            return newbba;
        }

        public static byte D2B(double d) {
            if (d < 0) return 0;
            if (d > 255) return 255;
            return (byte)d;
        }

        public static double[,] CreateGaussianFilter(int windowSize,double sigma){
            if(windowSize<3 || windowSize%2==0){
                throw new ApplicationException("invalid window size");
            }

            int offset = (windowSize-1) / 2;
            double[,] ND = new double[offset*2+1,offset*2+1];
	
	        int size = offset*2+1;
	        double[] t = new double[size];
	        double k = 1.0 / Math.Sqrt(2.0 * Math.PI) / sigma;
	        double total = 0.0;
	        for (int i=0; i<size; i++) {
	            double x = i - offset;
	            t[i] = k / Math.Exp( x * x / (2 * sigma * sigma) );
	            total += t[i];
	        }
	        for (int i=0; i<size; i++) t[i] /= total;
	        for (int i=0; i<size; i++) {
	            for (int j=0; j<size; j++) {
		        ND[i,j] = t[i] * t[j];
	            }
	        }
            return ND;
        }

        public static double[,] CreateAvarageFilter(int windowSize) {
            if (windowSize < 3 || windowSize % 2 == 0) {
                throw new ApplicationException("invalid window size");
            }

            double[,] ND = new double[windowSize,windowSize];

            double p = 1.0 / (windowSize * windowSize);

            for (int i = 0; i < windowSize; i++) {
                for (int j = 0; j < windowSize; j++) {
                    ND[i, j] = p;
                }
            }
            return ND;
        }


        public static BitmapByteArray Hutidori(BitmapByteArray srcBBA, Color huti, bool isSmooth,int time,byte threshold,bool isGausian,int windowsize,double sigma,bool isKeepSrc) {
            if (time == 0) {
                return srcBBA;
            }
            
            //フィルタを作る
            double[,] filter = null;
            if (isGausian) {
                filter = CreateGaussianFilter(windowsize,sigma);
            } else {
                filter = CreateAvarageFilter(windowsize);
            }

            //縁取りのアルファを作る
            byte[,] oldA = null;
            byte[,] newA = null;
            for (int i = 0; i < time; i++) {
                if (i == 0) {
                    oldA = (byte[,])srcBBA.A.Clone();
                }

                newA = ApplyFilterOne(oldA, filter);
                for (int y = 0; y < srcBBA.Height; y++) {
                    for (int x = 0; x < srcBBA.Width; x++) {
                        int newa=oldA[x, y] + newA[x, y];
                        if (newa > 255) {
                            newa = 255;
                        }
                        newA[x, y] = (byte)newa;
                    }
                }
                oldA = newA;
            }

            //新アルファをフチの色で塗ったのを用意---1
            BitmapByteArray newAlphaBBA = new BitmapByteArray(srcBBA.Width, srcBBA.Height);
            for (int y = 0; y < srcBBA.Height; y++) {
                for (int x = 0; x < srcBBA.Width; x++) {
                    newAlphaBBA.R[x, y] = huti.R;
                    newAlphaBBA.G[x, y] = huti.G;
                    newAlphaBBA.B[x, y] = huti.B;
                    //アルファは新アルファとフチのアルファの乗算
                    newAlphaBBA.A[x, y] = (byte)(newA[x, y] * huti.A / 255);
                }
            }

            //return newAlphaBBA;

            BitmapByteArray plusBBA1 = null;

            if (isSmooth) {
                //元画像をぼかしたものを用意---2
                BitmapByteArray blurBBA = ApplyFilter(srcBBA, filter);
                //1に2を重ねる
                plusBBA1 = PutBBA(newAlphaBBA, blurBBA);
            } else {
                plusBBA1 = newAlphaBBA;
            }

            //スレッショルドで削る
            Threshold(plusBBA1, threshold, 0, 0, false, true);

            //元画像を重ねる
            BitmapByteArray plusBBA2;

            if (isKeepSrc) {
                plusBBA2 = OverWriteBBA(plusBBA1, srcBBA);
            } else {
                plusBBA2 = PutBBA(plusBBA1, srcBBA);
            }
            return plusBBA2;
        }

    }//end of class
}//end of namespace
