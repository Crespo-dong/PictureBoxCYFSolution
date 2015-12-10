using System.ComponentModel;
using HalconDotNet;
using ViewROI;
using NLog;

namespace CYF.ImageProcessing.Tools
{
    partial class PictureBoxCYF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._hWindowControl = new HalconDotNet.HWindowControl();
            this.SuspendLayout();
            // 
            // _hWindowControl
            // 
            this._hWindowControl.BackColor = System.Drawing.Color.Black;
            this._hWindowControl.BorderColor = System.Drawing.Color.Black;
            this._hWindowControl.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this._hWindowControl.Location = new System.Drawing.Point(0, 0);
            this._hWindowControl.Name = "_hWindowControl";
            this._hWindowControl.Size = new System.Drawing.Size(320, 240);
            this._hWindowControl.TabIndex = 0;
            this._hWindowControl.WindowSize = new System.Drawing.Size(320, 240);
            // 
            // PictureBoxCYF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._hWindowControl);
            this.Name = "PictureBoxCYF";
            this.Size = new System.Drawing.Size(640, 640);
            this.ResumeLayout(false);

        }

        #endregion

        private static HImage _hSourceImage;
        private HWindowControl _hWindowControl;
        private HWindow _hWindow;
        private HWndCtrl _hWndCtrl;
        private static Logger _logger = LogManager.GetCurrentClassLogger();
    }
}
