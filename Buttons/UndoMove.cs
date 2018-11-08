using System;
using System.Windows.Forms;

namespace ColorLinesGame.Buttons
{
    public partial class UndoMove : HorDialog
    {
        public UndoMove(string title, string message) : base(title, message)
        {
            InitializeComponent();
        }

        public override void OkButton_Click(object sender, EventArgs e)
        {
            ///////////////////////////
            MessageBox.Show("Funkcja tymczasowo niedostępna :(");
        }
    }
}
