using System;
using System.Windows.Forms;

namespace ColorLinesGame.Buttons
{
    public partial class Quit : HorDialog
    {
        public Quit(string title, string message) : base(title, message)
        {
            InitializeComponent();
        }

        public override void OkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
