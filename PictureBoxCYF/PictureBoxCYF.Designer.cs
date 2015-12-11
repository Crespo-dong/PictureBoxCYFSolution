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

        

        // class HWindow
        // Represents an instance of a HALCON window.
        private HWindow _hWindow;

        // Provides a HALCON window for your Windows Forms application
        // class HWindowControl : UserControl
        // {
        //    private HWindow window;
        // }
        private HWindowControl _hWindowControl;

        // This class works as a wrapper class for the HALCON window
        // HWindow. HWndCtrl is in charge of the visualization.
        // You can move and zoom the visible image part by using GUI component 
        // inputs or with the mouse. The class HWndCtrl uses a graphics stack 
        // to manage the iconic objects for the display. Each object is linked 
        // to a graphical context, which determines how the object is to be drawn.
        // The context can be changed by calling changeGraphicSettings().
        // The graphical "modes" are defined by the class GraphicsContext and 
        // map most of the dev_set_* operators provided in HDevelop.
        // class HWndCtrl
        // {
        //     private HWindowControl viewPort;
        // }
        private HWndCtrl _hWndCtrl;

        private static HImage _hSourceImage;
        private static Logger _logger = LogManager.GetCurrentClassLogger();
    }
}
