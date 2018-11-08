namespace ColorLinesGame.Buttons
{
    partial class Save
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
            this.saveName = new System.Windows.Forms.TextBox();
            // 
            // saveName
            // 
            this.saveName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.saveName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.saveName.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveName.Location = new System.Drawing.Point(25, 60);
            this.saveName.Margin = new System.Windows.Forms.Padding(0);
            this.saveName.MaxLength = 10;
            this.saveName.Name = "saveName";
            this.saveName.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.saveName.Size = new System.Drawing.Size(200, 50);
            this.saveName.TabIndex = 0;
            contentPanel.Controls.Add(this.saveName);
        }

        #endregion
        private System.Windows.Forms.TextBox saveName;
    }
}