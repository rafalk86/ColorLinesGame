using System;
using System.Windows.Forms;

namespace ColorLinesGame
{
    public partial class HorDialog : Form
    {
        public HorDialog(string title, string message)
        {
            InitializeComponent();
            titleLabel.Text = title;
            messageLabel.Text = message;
        }

        [Obsolete("Designer only", true)]
        private HorDialog()
        {
            InitializeComponent();
        }

        public virtual void OkButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public virtual void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
