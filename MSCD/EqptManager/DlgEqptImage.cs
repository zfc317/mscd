using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace MSCD.UI.EqptManager
{
    public partial class DlgEqptImage : DevExpress.XtraEditors.XtraForm
    {
        private int _beginX;
        private int _beginY;

        private Image _oriImage;
        private Image _destImage;

        private float _zoom;
        private Point _startPoint = Point.Empty;
        private Point _viewPoint = Point.Empty;
        private bool _startMove = false;
        private int _w;
        private int _h;

        public DlgEqptImage(Image image)
        {
            InitializeComponent();
            _oriImage = image;
            _beginX = 0;
            _beginY = 0;
            _zoom = 100;
            //ZoomImage(false);
            pictureEdit1.MouseDown += new MouseEventHandler(pictureEdit1_MouseDown);
            pictureEdit1.MouseMove += new MouseEventHandler(pictureEdit1_MouseMove);
            pictureEdit1.MouseUp += new MouseEventHandler(pictureEdit1_MouseUp);
            pictureEdit1.MouseWheel += new MouseEventHandler(pictureEdit1_MouseWheel);
        }

        void pictureEdit1_MouseWheel(object sender, MouseEventArgs e)
        {
            if(e.Delta>0)
            {
                float min = pictureEdit1.Width / _oriImage.Width;
                float min_y = pictureEdit1.Height / _oriImage.Height;
                if (min < min_y) min = min_y;
                else min = min_y;
                _zoom += 10;
                if (_zoom > 200) _zoom = 200;
                ZoomImage(true);
            }
            else
            {
                float min = pictureEdit1.Width / _oriImage.Width;
                float min_y = pictureEdit1.Height / _oriImage.Height;
                if (min < min_y) min = min_y;
                else min = min_y;
                _zoom -= 10;
                if (_zoom < min) _zoom = min;
                ZoomImage(true);
            }
        }

        void pictureEdit1_MouseUp(object sender, MouseEventArgs e)
        {
            if(_startMove)
            {
                int x, y;
                x = _startPoint.X - e.X;
                y = _startPoint.Y - e.Y;
                if(x>0)
                {
                    if (_beginX + x <= _w - pictureEdit1.Width) _beginX += x;
                    else _beginX = _w - pictureEdit1.Width;
                }
                else
                {
                    if (_beginX + x <= 0) _beginX = 0;
                    else _beginX += x;
                }

                if(y>0)
                {
                    if (_beginY + y <= _h - pictureEdit1.Height) _beginY += y;
                    else _beginY = _h - pictureEdit1.Height;
                }
                else
                {
                    if (_beginY + y <= 0) _beginY = 0;
                    else _beginY += y;
                }
                ZoomImage(false);
            }
            _startMove = false;
        }

        void pictureEdit1_MouseMove(object sender, MouseEventArgs e)
        {
            _startMove = true;
        }

        void pictureEdit1_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            _startMove = true;
            _startPoint = e.Location;
        }

        private void ZoomImage(bool isZoom)
        {
            _w = Convert.ToInt32(_oriImage.Width*_zoom/100);
            _h = Convert.ToInt32(_oriImage.Height*_zoom/100);
            if (_w < 1 || _h < 1) return;
            if(isZoom)
            {
                if (_beginX + pictureEdit1.Width > _w) _beginX = _w - pictureEdit1.Width;
                if (_beginY + pictureEdit1.Height > _h) _beginY = _h - pictureEdit1.Height;
                if (_beginX < 0) _beginX = 0;
                if (_beginY < 0) _beginY = 0;
            }

            var resizeBmp = new Bitmap(_w, _h);
            var g = Graphics.FromImage(resizeBmp);
            g.InterpolationMode=InterpolationMode.NearestNeighbor;
            g.SmoothingMode=SmoothingMode.None;
            g.DrawImage(_oriImage,new Rectangle(0,0,_w,_h),new Rectangle(0,0,_oriImage.Width,_oriImage.Height),GraphicsUnit.Pixel );
            int ww, hh;
            ww = _w;
            hh = _h;
            if (pictureEdit1.Width < ww) ww = pictureEdit1.Width;
            if (pictureEdit1.Height < hh) hh = pictureEdit1.Height;
            pictureEdit1.Image = resizeBmp.Clone(new RectangleF((float) _beginX, (float) _beginY, ww, hh),
                                                 PixelFormat.Format24bppRgb);
            g.Dispose();
        }

    }
}