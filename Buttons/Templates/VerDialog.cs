using System;
using System.Windows.Forms;

namespace ColorLinesGame
{
    public partial class VerDialog : Form
    {
        public VerDialog(string title)
        {
            InitializeComponent();
            titleLabel.Text = title;
        }

        [Obsolete("Designer only", true)]
        private VerDialog()
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
