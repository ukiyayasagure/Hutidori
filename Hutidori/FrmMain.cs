using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using BitmapTool;

namespace Hutidori {
    public partial class FrmMain : Form {
        PreviewForm frmPreview;
        int width, height;

        public FrmMain() {
            InitializeComponent();
            frmPreview = new PerPixelAlphaForm();
        }

        private void FrmMain_Load(object sender, EventArgs e) {
            FileInfo fi = null;
            Option option = null;
            try {
                fi = new FileInfo(Application.StartupPath + "\\option.xml");
                if (fi.Exists) {
                    System.Xml.Serialization.XmlSerializer xmls
                        = new System.Xml.Serialization.XmlSerializer(typeof(Option));
                    option = (Option)xmls.Deserialize(
                        fi.Open(FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
                } else {
                    option = null;
                }
            } catch (Exception ex) {
                string errstr = "オプション読み込みに失敗しました\r\n\r\n" + ex.ToString();
                Log(errstr + "\r\n");
                option = null;
            }

            if (option != null) {
                chkResize.Checked = option.isResize;
                numResizeWidth.Value = option.ResizeWidth;
                numResizeHeight.Value = option.ResizeHeight;
                cboResizeMethod.SelectedIndex = option.ResizeMethod;
                chkUntiUnti.Checked = option.isUntiUntiAlias;
                numUntiUnti.Value = option.UntiUntiAlias;
                chkUntiUntiDrop.Checked = option.isUntiUntiDrop;
                chkUntiUntiUp.Checked = option.isUntiUntiUp;
                chkHutidori.Checked = option.isHutidori;
                pbHutiColor.BackColor = Color.FromArgb(255, option.HutiColor_R, option.HutiColor_G, option.HutiColor_B);
                numHutiAlpha.Value = option.HutiColor_A;
                chkHutiSmooth.Checked = option.isHutiSmoothing;
                numHutiWidth.Value = option.HutiWidth;
                numHutiThreshold.Value = option.HutiThreshold;
                cboHutiMethod.SelectedIndex = option.HutiMethod;
                numHutiWindowSize.Value = option.HutiWindowSize;
                numHutiSigma.Value = (decimal)option.HutiSigma;
                chkHutiKeepSrc.Checked = option.isHutiKeepSrc;
                rdoOutput32Bit.Checked = option.isOutput32Bit;
                rdoOutput24Bit.Checked = !option.isOutput32Bit;
                pbOutputBackColor.BackColor = Color.FromArgb(255, option.OutputBackColor_R, option.OutputBackColor_G, option.OutputBackColor_B);
                chkOutputSimplePNA.Checked = option.isOutputSimplePNA;
                chkPreviewLayered.Checked = option.isPreviewLayered;
                chkOutputBackup.Checked = option.isOutputBackup;
            } else {
                cboHutiMethod.SelectedIndex = 0;
                cboResizeMethod.SelectedIndex = 0;
            }
            ResetStatus();
            ClearLog();
        }

        private void ResetStatus() {
            if (chkResize.Checked == false) {
                txtResizeHeight.Enabled = false;
                txtResizeWidth.Enabled = false;
                numResizeHeight.Enabled = false;
                numResizeWidth.Enabled = false;
                cboResizeMethod.Enabled = false;
            } else {
                txtResizeHeight.Enabled = true;
                txtResizeWidth.Enabled = true;
                numResizeHeight.Enabled = true;
                numResizeWidth.Enabled = true;
                cboResizeMethod.Enabled = true;
            }

            if (chkUntiUnti.Checked == false) {
                numUntiUnti.Enabled = false;
                chkUntiUntiDrop.Enabled = false;
                chkUntiUntiUp.Enabled = false;
            } else {
                numUntiUnti.Enabled = true;
                chkUntiUntiDrop.Enabled = true;
                chkUntiUntiUp.Enabled = true;
            }

            if (chkHutidori.Checked == false) {
                numHutiAlpha.Enabled = false;
                pbHutiColor.Enabled = false;
                chkHutiSmooth.Enabled = false;
                numHutiWidth.Enabled = false;
                numHutiThreshold.Enabled = false;
                cboHutiMethod.Enabled = false;
                numHutiWindowSize.Enabled = false;
                numHutiSigma.Enabled = false;
            } else {
                numHutiAlpha.Enabled = true;
                pbHutiColor.Enabled = true;
                chkHutiSmooth.Enabled = true;
                numHutiWidth.Enabled = true;
                numHutiThreshold.Enabled = true;
                cboHutiMethod.Enabled = true;
                numHutiWindowSize.Enabled = true;
                if (cboHutiMethod.SelectedIndex == 0) {
                    numHutiSigma.Enabled = true;
                } else {
                    numHutiSigma.Enabled = false;
                }
            }

            if (rdoOutput32Bit.Checked) {
                pbOutputBackColor.Enabled = false;
                chkOutputSimplePNA.Enabled = false;
            } else {
                pbOutputBackColor.Enabled = true;
                chkOutputSimplePNA.Enabled = true;
            }
        }

        private void chkResize_CheckedChanged(object sender, EventArgs e) {
            ResetStatus();
        }

        private void chkUntiUnti_CheckedChanged(object sender, EventArgs e) {
            ResetStatus();
        }

        private void chkHutidori_CheckedChanged(object sender, EventArgs e) {
            ResetStatus();
        }

        private void rdoHutiAlpha_CheckedChanged(object sender, EventArgs e) {
            ResetStatus();
        }

        private void rdoHutiColor_CheckedChanged(object sender, EventArgs e) {
            ResetStatus();
        }

        private void rdoOutput32Bit_CheckedChanged(object sender, EventArgs e) {
            ResetStatus();
        }

        private void rdoOutput24Bit_CheckedChanged(object sender, EventArgs e) {
            ResetStatus();
        }

        private void pbHutiColor_Click(object sender, EventArgs e) {
            SetColor(pbHutiColor);
        }

        private void pbOutputBackColor_Click(object sender, EventArgs e) {
            SetColor(pbOutputBackColor);
        }


        private void SetColor(PictureBox pb) {
            cdMain.Color = pb.BackColor;
            DialogResult result;
            result = cdMain.ShowDialog(this);
            if (result != DialogResult.OK) {
                return;
            }
            pb.BackColor = cdMain.Color;
        }

        private void txtResizeWidth_Validating(object sender, CancelEventArgs e) {
     //       if (!IsNumber(txtResizeWidth, 1, int.MaxValue)) {
       //         e.Cancel = true;
         //   }
        }

        private void txtResizeHeight_Validating(object sender, CancelEventArgs e) {
    //        if (!IsNumber(txtResizeHeight, 1, int.MaxValue)) {
      //          e.Cancel = true;
        //    }
        }

        private bool IsNumber(TextBox t, int min, int max) {
            int dummy = 0;
            bool isInt = int.TryParse(t.Text, out dummy);
            if (!isInt || dummy < min || dummy > max) {
                return false;
            } else {
                return true;
            }
        }

        private int ToInt(TextBox t) {
            int dummy = 0;
            int.TryParse(t.Text, out dummy);
            return dummy;
        }

        private void lblPreview_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                if (s.Length == 1) {
                    e.Effect = DragDropEffects.All;
                    return;
                }
            }
            e.Effect = DragDropEffects.None;
        }

        private void lblPreview_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                if (s.Length == 1 && _IsBitmap(s[0])) {
                    try {
                        txtPreviewFileName.Text = s[0];
                        Bitmap bmp = BitmapToolBox.LoadBitmap(s[0]).ToBitmap();
                        height = bmp.Height;
                        width = bmp.Width;
                        txtResizeHeight.Text = (height * (int)numResizeHeight.Value / 100).ToString();
                        txtResizeWidth.Text = (width * (int)numResizeWidth.Value / 100).ToString();
                        frmPreview.SetBitmap(bmp);
                        ((Form)frmPreview).Show();
                    } catch (Exception ex) {
                        string errstr = "ファイル" + s[0] + "の読み込みに失敗しました\r\n\r\n" + ex.ToString();
                        Error(errstr);
                        Log(errstr+"\r\n");
                    }
                }
            }
        }

        private bool _IsBitmap(string s) {
            string ext = Path.GetExtension(s).ToLower();
            if(ext!=".png" && ext!=".gif" && ext!=".jpg" && ext!=".bmp"){
                return false;
            }else{
                return true;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e) {
            if (txtPreviewFileName.Text == "") {
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            try {
                BitmapByteArray bba = BitmapToolBox.LoadBitmap(txtPreviewFileName.Text);
                bba = DoAll(bba);
                frmPreview.SetBitmap(bba.ToBitmap());
                ((Form)frmPreview).Show();
            } catch (Exception ex) {
                string errstr = "プレビュー画像の生成に失敗しました\r\n\r\n" + ex.ToString();
                Error(errstr);
                Log(errstr + "\r\n");
            }
            this.Cursor = Cursors.Default;
        }

        private BitmapByteArray DoAll(BitmapByteArray bba) {
            if (chkResize.Checked) {
                ResamplingService resamplingService = new ResamplingService();
                if (cboResizeMethod.SelectedIndex == 0) {
                    bba = BitmapToolBox.ResizeHQB(bba, ToInt(txtResizeWidth), ToInt(txtResizeHeight));
                } else {
                    switch (cboResizeMethod.SelectedIndex) {
                        case 1://Box
                            resamplingService.Filter = ResamplingFilters.Box;
                            break;
                        case 2://Triangle
                            resamplingService.Filter = ResamplingFilters.Triangle;
                            break;
                        case 3://Hermite
                            resamplingService.Filter = ResamplingFilters.Hermite;
                            break;
                        case 4://Bell
                            resamplingService.Filter = ResamplingFilters.Bell;
                            break;
                        case 5://CubicBSpline
                            resamplingService.Filter = ResamplingFilters.CubicBSpline;
                            break;
                        case 6://Lanczos3
                            resamplingService.Filter = ResamplingFilters.Lanczos3;
                            break;
                        case 7://Mitchell
                            resamplingService.Filter = ResamplingFilters.Mitchell;
                            break;
                        case 8://Cosine
                            resamplingService.Filter = ResamplingFilters.Cosine;
                            break;
                        case 9://CatmullRom
                            resamplingService.Filter = ResamplingFilters.CatmullRom;
                            break;
                        case 10://Quadratic
                            resamplingService.Filter = ResamplingFilters.Quadratic;
                            break;
                        case 11://QuadraticBSpline
                            resamplingService.Filter = ResamplingFilters.QuadraticBSpline;
                            break;
                        case 12://CubicConvolution
                            resamplingService.Filter = ResamplingFilters.CubicConvolution;
                            break;
                        case 13://Lanczos8
                            resamplingService.Filter = ResamplingFilters.Lanczos8;
                            break;
                    }
                    bba = resamplingService.Resample(bba, ToInt(txtResizeWidth), ToInt(txtResizeHeight));
                }

            }
            if (chkUntiUnti.Checked) {
                BitmapToolBox.UntiUntiAlias(bba, (byte)numUntiUnti.Value,chkUntiUntiDrop.Checked,chkUntiUntiUp.Checked);
            }
            if (chkHutidori.Checked) {
                bba = BitmapToolBox.Hutidori(bba,
                    Color.FromArgb((int)numHutiAlpha.Value, pbHutiColor.BackColor.R, pbHutiColor.BackColor.G, pbHutiColor.BackColor.B),
                    chkHutiSmooth.Checked,
                    (int)numHutiWidth.Value,
                    (byte)numHutiThreshold.Value,
                    (cboHutiMethod.SelectedIndex == 0),
                    (int)numHutiWindowSize.Value,
                    (double)numHutiSigma.Value,
                    chkHutiKeepSrc.Checked);

            }
            return bba;

        }

        private void numResizeWidth_ValueChanged(object sender, EventArgs e) {
            txtResizeWidth.Text = (width * (int)numResizeWidth.Value / 100).ToString();
        }

        private void numResizeHeight_ValueChanged(object sender, EventArgs e) {
            txtResizeHeight.Text = (height * (int)numResizeHeight.Value / 100).ToString();
        }

        private void chkPreviewLayered_CheckedChanged(object sender, EventArgs e) {
            if (chkPreviewLayered.Checked) {
                ((Form)frmPreview).Close();
                frmPreview = new PerPixelAlphaForm();
            } else {
                ((Form)frmPreview).Close();
                frmPreview = new FrmPreview();
            }
        }

        private void lblDo_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.All;
                return;
            }
            e.Effect = DragDropEffects.None;
        }

        private void lblDo_DragDrop(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                this.Cursor = Cursors.WaitCursor;
                bool isError = false;
                for (int i = 0; i < s.Length; i++) {
                    if (!_IsBitmap(s[i])) continue;
                    try {
                        txtPreviewFileName.Text = s[i];
                        Log("ファイル" + s[i] + "を処理します...");
                        BitmapByteArray bba = BitmapToolBox.LoadBitmap(s[i]);
                        height = bba.Height; 
                        width = bba.Width; 
                        txtResizeHeight.Text = (height * (int)numResizeHeight.Value / 100).ToString();
                        txtResizeWidth.Text = (width * (int)numResizeWidth.Value / 100).ToString();
                        bba = DoAll(bba);
                        Save(bba, s[i]);
                        Log("OK\r\n");
                    } catch (Exception ex) {
                        Log(ex.Message+"\r\n");
                        Log(ex.ToString() + "\r\n");
                        isError = true;
                    }
                }
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, s.Length + "ファイルの処理が終了しました。", "処理完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (isError) {
                    MessageBox.Show(this, "処理中にエラーが発生しました。\r\nログを表示します。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string logfilename = Application.StartupPath + "\\log.txt";
                    System.Diagnostics.Process.Start(logfilename);
                }

            }
        }

        private void Save(BitmapByteArray bba, string filename) {
            if (rdoOutput24Bit.Checked) {
                BitmapToolBox.SaveBitmap24(filename, bba, chkOutputSimplePNA.Checked, pbOutputBackColor.BackColor, chkOutputBackup.Checked);
            } else {
                BitmapToolBox.SaveBitmap32(filename, bba, chkOutputBackup.Checked);
            }
        }

        private void Error(string p) {
            MessageBox.Show(this, p, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Log(string p) {
            string logfilename = Application.StartupPath + "\\log.txt";
            StreamWriter sw = null;
            sw = new StreamWriter(File.Open(logfilename, FileMode.Append, FileAccess.Write, FileShare.ReadWrite),
                System.Text.Encoding.GetEncoding("Shift-JIS"));
            try {
                sw.Write(p);
            } finally {
                if (sw != null) { sw.Close(); }
            }
        }

        private void ClearLog() {
            string logfilename = Application.StartupPath + "\\log.txt";
            if (File.Exists(logfilename)) {
                File.Delete(logfilename);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e) {
            MessageBox.Show(this,
                "ふちどり。Version" + Application.ProductVersion + "\r\n" +
                "By " + Application.CompanyName,
                "このプログラムについて", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void cboMethod_SelectedIndexChanged(object sender, EventArgs e) {
            ResetStatus();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e) {
            Option option = new Option();
            option.isResize = chkResize.Checked;
            option.ResizeWidth = (int)numResizeWidth.Value;
            option.ResizeHeight = (int)numResizeHeight.Value;
            option.ResizeMethod = cboResizeMethod.SelectedIndex;
            option.isUntiUntiAlias = chkUntiUnti.Checked;
            option.UntiUntiAlias = (int)numUntiUnti.Value;
            option.isUntiUntiDrop = chkUntiUntiDrop.Checked;
            option.isUntiUntiUp = chkUntiUntiUp.Checked;
            option.isHutidori = chkHutidori.Checked;
            option.HutiColor_R = pbHutiColor.BackColor.R;
            option.HutiColor_G = pbHutiColor.BackColor.G;
            option.HutiColor_B = pbHutiColor.BackColor.B;
            option.HutiColor_A = (int)numHutiAlpha.Value;
            option.isHutiSmoothing = chkHutiSmooth.Checked;
            option.HutiWidth = (int)numHutiWidth.Value;
            option.HutiThreshold = (int)numHutiThreshold.Value;
            option.HutiMethod = cboHutiMethod.SelectedIndex;
            option.HutiWindowSize = (int)numHutiWindowSize.Value;
            option.HutiSigma = (double)numHutiSigma.Value;
            option.isHutiKeepSrc = chkHutiKeepSrc.Checked;
            option.isOutput32Bit = rdoOutput32Bit.Checked;
            option.OutputBackColor_R = pbOutputBackColor.BackColor.R;
            option.OutputBackColor_G = pbOutputBackColor.BackColor.G;
            option.OutputBackColor_B = pbOutputBackColor.BackColor.B;
            option.isOutputSimplePNA = chkOutputSimplePNA.Checked;
            option.isPreviewLayered = chkPreviewLayered.Checked;
            option.isOutputBackup = chkOutputBackup.Checked;

            FileInfo fi = null;
            try {
                fi = new FileInfo(Application.StartupPath + "\\option.xml");
                System.Xml.Serialization.XmlSerializer xmls
                    = new System.Xml.Serialization.XmlSerializer(typeof(Option));
                xmls.Serialize(fi.Open(FileMode.Create, FileAccess.Write, FileShare.ReadWrite),option);
            } catch (Exception ex) {
                string errstr = "オプション書き込みに失敗しました\r\n\r\n" + ex.ToString();
                Log(errstr + "\r\n");
            }
        }

        public static BitmapByteArray Hutidori(BitmapByteArray srcBBA, Color huti, bool isSmooth, int time, byte threshold, bool isGausian, int windowsize, double sigma, bool isKeepSrc) {
            if (time == 0) {
                return srcBBA;
            }

            //フィルタを作る
            double[,] filter = null;
            if (isGausian) {
                filter = BitmapToolBox.CreateGaussianFilter(windowsize, sigma);
            } else {
                filter = BitmapToolBox.CreateAvarageFilter(windowsize);
            }

            //縁取りのアルファを作る
            byte[,] oldA = null;
            byte[,] newA = null;
            for (int i = 0; i < time; i++) {
                if (i == 0) {
                    oldA = (byte[,])srcBBA.A.Clone();
                }

                newA = BitmapToolBox.ApplyFilterOne(oldA, filter);
                for (int y = 0; y < srcBBA.Height; y++) {
                    for (int x = 0; x < srcBBA.Width; x++) {
                        int newa = oldA[x, y] + newA[x, y];
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
                BitmapByteArray blurBBA = BitmapToolBox.ApplyFilter(srcBBA, filter);
                //1に2を重ねる
                plusBBA1 = BitmapToolBox.PutBBA(newAlphaBBA, blurBBA);
            } else {
                plusBBA1 = newAlphaBBA;
            }

            //スレッショルドで削る
            BitmapToolBox.Threshold(plusBBA1, threshold, 0, 0, false, true);

            //元画像を重ねる
            BitmapByteArray plusBBA2;

            if (isKeepSrc) {
                plusBBA2 = BitmapToolBox.OverWriteBBA(plusBBA1, srcBBA);
            } else {
                plusBBA2 = BitmapToolBox.PutBBA(plusBBA1, srcBBA);
            }
            return plusBBA2;
        }

    }//end of class

    public interface PreviewForm {
        void SetBitmap(Bitmap bmp);
    }

    public class Option {
        public bool isResize;
        public int ResizeWidth;
        public int ResizeHeight;
        public int ResizeMethod;
        public bool isUntiUntiAlias;
        public int UntiUntiAlias;
        public bool isUntiUntiDrop;
        public bool isUntiUntiUp;
        public bool isHutidori;
        public int HutiColor_R;
        public int HutiColor_G;
        public int HutiColor_B;
        public int HutiColor_A;
        public bool isHutiSmoothing;
        public int HutiWidth;
        public int HutiThreshold;
        public int HutiMethod;
        public int HutiWindowSize;
        public double HutiSigma;
        public bool isHutiKeepSrc;
        public bool isOutput32Bit;
        public int OutputBackColor_R;
        public int OutputBackColor_G;
        public int OutputBackColor_B;
        public bool isOutputSimplePNA;
        public bool isPreviewLayered;
        public bool isOutputBackup;
    }

}//end of namespace
