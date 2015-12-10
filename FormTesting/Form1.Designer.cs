namespace FormTesting
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxCYF = new CYF.ImageProcessing.Tools.PictureBoxCYF();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.openFileDialogLoadImage = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // pictureBoxCYF
            // 
            this.pictureBoxCYF.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxCYF.Name = "pictureBoxCYF";
            this.pictureBoxCYF.Size = new System.Drawing.Size(640, 640);
            this.pictureBoxCYF.TabIndex = 0;
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(667, 12);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(108, 62);
            this.buttonLoadImage.TabIndex = 1;
            this.buttonLoadImage.Text = "Load Image";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // openFileDialogLoadImage
            // 
            this.openFileDialogLoadImage.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 654);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.pictureBoxCYF);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CYF.ImageProcessing.Tools.PictureBoxCYF pictureBoxCYF;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogLoadImage;
    }
}

