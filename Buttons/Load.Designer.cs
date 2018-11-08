namespace ColorLinesGame.Buttons
{
    partial class Load
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
            this.gameList = new System.Windows.Forms.ListBox();
            // 
            // gameList
            // 
            this.gameList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.gameList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameList.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameList.Location = new System.Drawing.Point(0, 0);
            this.gameList.Name = "gameList";
            this.gameList.Size = new System.Drawing.Size(180, 280);
            this.gameList.TabIndex = 0;
            this.gameList.Visible = false;
            contentPanel.Controls.Add(gameList);
        }

        #endregion
        private System.Windows.Forms.ListBox gameList;
    }
}