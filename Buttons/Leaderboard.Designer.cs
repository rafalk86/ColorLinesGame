namespace ColorLinesGame.Buttons
{
    partial class Leaderboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerList = new System.Windows.Forms.ListView();
            this.positionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playerHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pointsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            // 
            // playerList
            // 
            this.playerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.positionHeader,
            this.playerHeader,
            this.pointsHeader });
            this.playerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.playerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerList.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerList.Location = new System.Drawing.Point(0, 0);
            this.playerList.Name = "playerList";
            this.playerList.OwnerDraw = true;
            this.playerList.Size = new System.Drawing.Size(180, 280);
            this.playerList.TabIndex = 0;
            this.playerList.View = System.Windows.Forms.View.Details;
            this.playerList.Visible = false;
            this.playerList.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.PlayerList_ColumnWidthChanging);
            this.playerList.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.PlayerList_DrawColumnHeader);
            this.playerList.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.PlayerList_DrawItem);
            this.playerList.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.PlayerList_DrawSubItem);
            contentPanel.Controls.Add(playerList);
            // 
            // positionHeader
            // 
            this.positionHeader.Width = 20;
            // 
            // playerHeader
            // 
            this.playerHeader.Width = 100;
            this.playerHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pointsHeader
            // 
            this.pointsHeader.Width = 60;
            this.pointsHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        }

        #endregion
        private System.Windows.Forms.ListView playerList;
        private System.Windows.Forms.ColumnHeader positionHeader;
        private System.Windows.Forms.ColumnHeader playerHeader;
        private System.Windows.Forms.ColumnHeader pointsHeader;
    }
}