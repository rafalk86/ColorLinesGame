using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ColorLinesGame.Buttons
{
    public partial class Leaderboard : VerDialog
    {
        public Leaderboard(string title) : base(title)
        {
            InitializeComponent();
            LoadResults();
            cancelButton.Visible = false;
        }

        private void LoadResults()
        {
            var players = JsonConvert.DeserializeObject<List<Tuple<string, int>>>(Properties.Settings.Default.results);

            if (players != null)
            {
                players.Sort((x, y) => y.Item2.CompareTo(x.Item2));

                for(int i = 0; i < players.Count; i++)
                {
                    playerList.Items.Add(new ListViewItem(new[] { i+1+".", players[i].Item1, players[i].Item2.ToString() }));
                }
                playerList.Visible = true;
                messageLabel.Visible = false;
            }
            else
            {
                messageLabel.Text = "Lista wyników jest pusta";
            }
        }

        private void PlayerList_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = playerList.Columns[e.ColumnIndex].Width;
        }

        private void PlayerList_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (StringFormat sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                switch (e.ColumnIndex)
                {
                    case 0:
                        e.Graphics.DrawString("P.", playerList.Font,
                            Brushes.Black, e.Bounds, sf);
                        break;
                    case 1:
                        e.Graphics.DrawString("Imię", playerList.Font,
                            Brushes.Black, e.Bounds, sf);
                        break;
                    case 2:
                        e.Graphics.DrawString("Punkty", playerList.Font,
                            Brushes.Black, e.Bounds, sf);
                        break;
                }
            }
        }

        private void PlayerList_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void PlayerList_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
