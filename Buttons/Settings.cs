using System;
using System.Windows.Forms;

namespace ColorLinesGame
{
    public partial class Settings : VerDialog
    {
        public Settings(string a) : base(a)
        {
            InitializeComponent();
            GetValues();
        }

        private void GetValues()
        {
            messageLabel.Visible = false;

            switch (Constants.NumBox())
            {
                case 7:
                    smallSize.Checked = true;
                    break;
                case 9:
                    mediumSize.Checked = true;
                    break;
                case 11:
                    largeSize.Checked = true;
                    break;
            }
            speedMovementTrackBar.Value = Constants.IntervalBall();
            speedMovementLabel.Text = Constants.IntervalBall().ToString();
            soundOnOff.Checked = (bool)Properties.Settings.Default["effectOn"];
        }

        public override void OkButton_Click(object sender, EventArgs e)
        {
            var RadioValue = smallSize.Checked ? smallSize.Text : mediumSize.Checked ? mediumSize.Text : largeSize.Text;

            if(Int32.Parse(RadioValue) != Constants.NumBox())
            {
                MessageBox.Show("Nastąpiła zmiana rozmiaru planszy. Aby zaszła zmiana, gra musi zostać zrestartowana.");
            }
            Properties.Settings.Default["boardSize"] = Int32.Parse(RadioValue);
            Properties.Settings.Default["speedMovement"] = Int32.Parse(speedMovementLabel.Text);
            Properties.Settings.Default["effectOn"] = soundOnOff.Checked;
            Properties.Settings.Default.Save();
            Close();
        }

        private void SpeedMovementTrackBar_ValueChanged(object sender, EventArgs e)
        {
            speedMovementLabel.Text = speedMovementTrackBar.Value.ToString();
        }
    }
}
