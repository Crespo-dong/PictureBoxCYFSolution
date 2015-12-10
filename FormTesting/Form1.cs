using System;
using System.Windows.Forms;

namespace FormTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == openFileDialogLoadImage.ShowDialog())
            {
                pictureBoxCYF.LoadImage(openFileDialogLoadImage.FileName);
            }
        }
    }
}
