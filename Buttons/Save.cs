using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace ColorLinesGame.Buttons
{
    public partial class Save : HorDialog
    {
        public Save(string title, string message) : base(title, message)
        {
            InitializeComponent();
            messageLabel.Size = new System.Drawing.Size(250, 60);
        }

        public override void OkButton_Click(object sender, EventArgs e)
        {
            if (saveName.Text == "")
            {
                MessageBox.Show("Puste pole.");
            }
            else
            {
                GameState saveState = new GameState
                {
                    boardState = Game.matrix,
                    nextBallsState = Game.drawnBalls,
                    pointsState = Game.score
                };

                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Saves");

                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                // serialize JSON directly to a file
                using (StreamWriter file = File.CreateText(filePath + "\\" + saveName.Text + ".json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, saveState);
                }
                Close();
            } 
        }
    }
}
