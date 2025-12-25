using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hutidori {
    public partial class FrmPreview : Form , PreviewForm {
        private Color[] colors;
        private int colorindex;

        public FrmPreview() {
            InitializeComponent();
            colors = new Color[5];
            colors[0] = Color.FromArgb(255, 255, 255, 255);
            colors[1] = Color.FromArgb(255,   0,   0,   0);
            colors[2] = Color.FromArgb(255, 255,   0,   0);
            colors[3] = Color.FromArgb(255,   0, 255,   0);
            colors[4] = Color.FromArgb(255,   0,   0, 255);
            colorindex = -1;
            _rotateColor();
        }

        private void _rotateColor() {
            colorindex++;
            if (colorindex >= colors.Length) {
                colorindex = 0;
            }
            pbPreview.BackColor = colors[colorindex];
        }

        public void SetBitmap(Bitmap bmp) {
            pbPreview.Image = bmp;
            pbPreview.Width = bmp.Width;
            pbPreview.Height = bmp.Height;
            this.ClientSize = new Size(bmp.Width, bmp.Height);
            if (this.Visible == false) {
                this.Visible = true;
            }
        }

        private void FrmPreview_FormClosing(object sender, FormClosingEventArgs e) {
            this.Visible = false;
            e.Cancel = true;
        }

        private void pbPreview_DoubleClick(object sender, EventArgs e) {
            _rotateColor();
        }
    }
}
