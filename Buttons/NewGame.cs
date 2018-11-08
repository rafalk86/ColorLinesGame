using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ColorLinesGame.Buttons
{
    public partial class NewGame : HorDialog
    {
        public NewGame(string title, string message) : base(title, message)
        {
            InitializeComponent();
        }

        public override void OkButton_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);
            Application.Exit();
        }
    }
}
