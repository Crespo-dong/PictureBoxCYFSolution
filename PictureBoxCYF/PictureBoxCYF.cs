using HalconDotNet;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ViewROI;

namespace CYF.ImageProcessing.Tools
{
    public partial class PictureBoxCYF : UserControl
    {
        public PictureBoxCYF()
        {
            InitializeComponent();
            InitializeMyComponent();
        }

        private void InitializeMyComponent()
        {
            // hWindowControl
            _hWindowControl.Width = Width;
            _hWindowControl.Height = Height;

            // hWndCtrl
            _hWndCtrl = new HWndCtrl(_hWindowControl);
            ROIController roiController = new ROIController();
            _hWndCtrl.useROIController(roiController);
            _hWndCtrl.setViewState(HWndCtrl.MODE_VIEW_MOVE);

            // hWindow
            _hWindow = _hWindowControl.HalconWindow;
        }

        public bool LoadImage(string imagePath)
        {
            if (string.IsNullOrEmpty(imagePath)) return false;

            try
            {
                _hSourceImage?.Dispose();
                _hSourceImage = new HImage(imagePath);
                _hWndCtrl.addIconicVar(_hSourceImage);

                double scaleFactor;
                Get1stScaleFactor(out scaleFactor);
                _hWndCtrl.zoomImage(scaleFactor);
                _hWndCtrl.repaint();
                Focus();
            }
            catch (Exception exception)
            {
                _logger.Error("LoadImage error" + "\r\n   " + exception);
                return false;
            }

            return true;
        }

        public bool LoadImage(Bitmap bitmap)
        {
            if (null == bitmap) return false;

            try
            {
                _hSourceImage?.Dispose();
                Rectangle rectangle = new Rectangle(0, 0, bitmap.Width, bitmap.Height);
                BitmapData bitmapData = bitmap.LockBits(rectangle, ImageLockMode.ReadOnly, bitmap.PixelFormat);

                switch (bitmap.PixelFormat)
                {
                    case PixelFormat.Format8bppIndexed:
                        _hSourceImage = new HImage("byte", bitmap.Width, bitmap.Height, bitmapData.Scan0);
                        bitmap.UnlockBits(bitmapData);
                        break;

                    case PixelFormat.Format24bppRgb:
                        _hSourceImage = new HImage();
                        _hSourceImage.GenImageInterleaved(bitmapData.Scan0, "rgb", bitmap.Width, bitmap.Height, -1,
                            "byte", 0, 0, 0, 0, -1, 0);
                        bitmap.UnlockBits(bitmapData);
                        break;

                    default:
                        return false;
                }

                _hWndCtrl.addIconicVar(_hSourceImage);

                double scaleFactor;
                Get1stScaleFactor(out scaleFactor);
                _hWndCtrl.zoomImage(scaleFactor);
                _hWndCtrl.repaint();
                Focus();
            }
            catch (Exception exception)
            {
                _logger.Error("LoadImage error" + "\r\n   " + exception);
                return false;
            }

            return true;
        }

        public bool LoadImage(IntPtr imagePointer, int imageWidth, int imageHeight, PixelFormat pixelFormat)
        {
            if (IntPtr.Zero == imagePointer) return false;

            try
            {
                _hSourceImage?.Dispose();

                switch (pixelFormat)
                {
                    case PixelFormat.Format8bppIndexed:
                        _hSourceImage = new HImage("byte", imageWidth, imageHeight, imagePointer);
                        break;

                    case PixelFormat.Format24bppRgb:
                        _hSourceImage = new HImage();
                        _hSourceImage.GenImageInterleaved(imagePointer, "rgb", imageWidth, imageHeight, -1, "byte", 0, 0,
                            0, 0, -1, 0);
                        break;

                    default:
                        return false;
                }

                _hWndCtrl.addIconicVar(_hSourceImage);

                double scaleFactor;
                Get1stScaleFactor(out scaleFactor);
                _hWndCtrl.zoomImage(scaleFactor);
                _hWndCtrl.repaint();
                Focus();
            }
            catch (Exception exception)
            {
                _logger.Error("LoadImage error" + "\r\n   " + exception);
                return false;
            }

            return true;
        }

        private void Get1stScaleFactor(out double scaleFactor)
        {
            scaleFactor = 1.0;

            try
            {
                int imageWidth, imageHeight;
                _hSourceImage.GetImageSize(out imageWidth, out imageHeight);
                int row, column, windowWidth, windowHeight;
                _hWindow.GetWindowExtents(out row, out column, out windowWidth, out windowHeight);
                double wFactor = (double) imageWidth/windowWidth;
                double hFactor = (double) imageHeight/windowHeight;
                scaleFactor = wFactor < hFactor ? wFactor : hFactor;
            }
            catch (Exception exception)
            {
                _logger.Error("Get1stScaleFactor error" + "\r\n   " + exception);
            }
        }
    }
}