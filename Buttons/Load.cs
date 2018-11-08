using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ColorLinesGame.Buttons
{
    public partial class Load : VerDialog
    {
        string savesPath = Directory.GetCurrentDirectory() + "\\" + "Saves" + "\\";
        string[] files;
        GameState savedFile;

        public Load(string title) : base(title)
        {
            InitializeComponent();
            LoadGames();
        }

        public override void OkButton_Click(object sender, EventArgs e)
        {
            if (files.Length > 0)
            {
                string getSave = gameList.GetItemText(gameList.SelectedItem);

                // deserialize JSON directly from a file
                using (StreamReader file = File.OpenText(savesPath + getSave + ".json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    savedFile = (GameState)serializer.Deserialize(file, typeof(GameState));
                }

                // run saved game
                Thread task = new Thread(new ThreadStart(() =>
                {
                    Application.Run(new Game(savedFile.boardState, savedFile.nextBallsState, savedFile.pointsState));
                }));
                task.Start();

                Application.Exit();
                Close();
            }
            else
            {
                Close();
            } 
        }

        private void LoadGames()
        {
            gameList.Items.Clear();

            if (!Directory.Exists(savesPath))
            {
                Directory.CreateDirectory(savesPath);
            }

            files = Directory.GetFiles(savesPath);

            if(files.Length > 0)
            {
                foreach (string file in files)
                {
                    gameList.Items.Add(Path.GetFileNameWithoutExtension(file));
                }
                gameList.Visible = true;
                messageLabel.Visible = false;
            }
            else
            {
                cancelButton.Visible = false;
                messageLabel.Text = "Brak plików z zapisami";
            }
        }
    }
}
