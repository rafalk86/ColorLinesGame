using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ColorLinesGame
{
    public partial class FinalScreen : HorDialog
    {
        int currentScore;
        int lastScore;
        List<Tuple<string, int>> resultList;

        public FinalScreen(string title, string message, int score) : base(title, message)
        {
            InitializeComponent();
            currentScore = score;
            lastScore = LastResult();

            if(!BetterScore())
            {
                messageLabel.Text = "Niestety nie uzyskałeś/aś wystarczającej ilości punktów, aby znaleźć się na liście.";
                cancelButton.Visible = false;
            }
            else
            {
                playerName.Visible = true;
                messageLabel.Size = new System.Drawing.Size(250, 60);
                messageLabel.Text = "Podaj swoje imię:";
            }
        }

        public override void OkButton_Click(object sender, EventArgs e)
        {
            if (!BetterScore())
            {
                Close();
            }
            else
            {
                if(playerName.Text == "")
                {
                    MessageBox.Show("Puste pole.");
                }
                else
                {
                    if(resultList == null)
                    {
                        resultList = new List<Tuple<string, int>>();
                    }
                    resultList.Add(new Tuple<string, int>(playerName.Text, currentScore));
                    string record = JsonConvert.SerializeObject(resultList);
                    Properties.Settings.Default["results"] = record;
                    Properties.Settings.Default.Save();
                    Close();
                }
            }
        }

        private bool BetterScore()
        {
            return (currentScore >= lastScore || resultList.Count < 10) ? true : false;
        }

        private int LastResult()
        {
            resultList = JsonConvert.DeserializeObject<List<Tuple<string, int>>>(Properties.Settings.Default.results);

            return (resultList == null) ? 0 : resultList.Min(c => c.Item2);
        }
    }
}
