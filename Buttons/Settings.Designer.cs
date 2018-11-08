namespace ColorLinesGame
{
    partial class Settings
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
            this.smallSize = new System.Windows.Forms.RadioButton();
            this.mediumSize = new System.Windows.Forms.RadioButton();
            this.largeSize = new System.Windows.Forms.RadioButton();
            this.speedMovementTrackBar = new System.Windows.Forms.TrackBar();
            this.speedMovementLabel = new System.Windows.Forms.Label();
            this.boardSize = new System.Windows.Forms.GroupBox();
            this.speedMovement = new System.Windows.Forms.GroupBox();
            this.soundEffects = new System.Windows.Forms.GroupBox();
            this.soundOnOff = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.speedMovementTrackBar)).BeginInit();
            this.boardSize.SuspendLayout();
            this.speedMovement.SuspendLayout();
            this.soundEffects.SuspendLayout();
            this.SuspendLayout();
            // 
            // smallSize
            // 
            this.smallSize.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.smallSize.Location = new System.Drawing.Point(10, 25);
            this.smallSize.Name = "smallSize";
            this.smallSize.Size = new System.Drawing.Size(40, 20);
            this.smallSize.TabIndex = 0;
            this.smallSize.Text = "7";
            this.smallSize.UseVisualStyleBackColor = true;
            // 
            // mediumSize
            // 
            this.mediumSize.Checked = true;
            this.mediumSize.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mediumSize.Location = new System.Drawing.Point(65, 25);
            this.mediumSize.Name = "mediumSize";
            this.mediumSize.Size = new System.Drawing.Size(40, 20);
            this.mediumSize.TabIndex = 1;
            this.mediumSize.TabStop = true;
            this.mediumSize.Text = "9";
            this.mediumSize.UseVisualStyleBackColor = true;
            // 
            // largeSize
            // 
            this.largeSize.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.largeSize.Location = new System.Drawing.Point(120, 25);
            this.largeSize.Name = "largeSize";
            this.largeSize.Size = new System.Drawing.Size(40, 20);
            this.largeSize.TabIndex = 2;
            this.largeSize.Text = "11";
            this.largeSize.UseVisualStyleBackColor = true;
            // 
            // boardSize
            // 
            this.boardSize.BackColor = System.Drawing.Color.Transparent;
            this.boardSize.Controls.Add(this.smallSize);
            this.boardSize.Controls.Add(this.mediumSize);
            this.boardSize.Controls.Add(this.largeSize);
            this.boardSize.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.boardSize.Location = new System.Drawing.Point(10, 10);
            this.boardSize.Name = "boardSize";
            this.boardSize.Size = new System.Drawing.Size(160, 60);
            this.boardSize.TabIndex = 3;
            this.boardSize.TabStop = false;
            this.boardSize.Text = "Rozmiar planszy";
            contentPanel.Controls.Add(this.boardSize);
            // 
            // speedMovementTrackBar
            // 
            this.speedMovementTrackBar.AutoSize = false;
            this.speedMovementTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(219)))), ((int)(((byte)(149)))));
            this.speedMovementTrackBar.LargeChange = 0;
            this.speedMovementTrackBar.Location = new System.Drawing.Point(10, 25);
            this.speedMovementTrackBar.Maximum = 500;
            this.speedMovementTrackBar.Minimum = 50;
            this.speedMovementTrackBar.Name = "speedMovementTrackBar";
            this.speedMovementTrackBar.Size = new System.Drawing.Size(100, 30);
            this.speedMovementTrackBar.SmallChange = 0;
            this.speedMovementTrackBar.TabIndex = 4;
            this.speedMovementTrackBar.TickFrequency = 50;
            this.speedMovementTrackBar.Value = 50;
            this.speedMovementTrackBar.ValueChanged += new System.EventHandler(this.SpeedMovementTrackBar_ValueChanged);
            // 
            // speedMovementLabel
            // 
            this.speedMovementLabel.AutoSize = true;
            this.speedMovementLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speedMovementLabel.Location = new System.Drawing.Point(120, 25);
            this.speedMovementLabel.Name = "speedMovementLabel";
            this.speedMovementLabel.Size = new System.Drawing.Size(10, 20);
            this.speedMovementLabel.TabIndex = 5;
            this.speedMovementLabel.Text = "0";
            // 
            // speedMovement
            // 
            this.speedMovement.BackColor = System.Drawing.Color.Transparent;
            this.speedMovement.Controls.Add(this.speedMovementTrackBar);
            this.speedMovement.Controls.Add(this.speedMovementLabel);
            this.speedMovement.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.speedMovement.Location = new System.Drawing.Point(10, 80);
            this.speedMovement.Name = "speedMovement";
            this.speedMovement.Size = new System.Drawing.Size(160, 60);
            this.speedMovement.TabIndex = 6;
            this.speedMovement.TabStop = false;
            this.speedMovement.Text = "Szybkość ruchu";
            contentPanel.Controls.Add(this.speedMovement);
            // 
            // soundOnOff
            // 
            this.soundOnOff.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.soundOnOff.Location = new System.Drawing.Point(10, 25);
            this.soundOnOff.Name = "soundOnOff";
            this.soundOnOff.Size = new System.Drawing.Size(140, 20);
            this.soundOnOff.TabIndex = 7;
            this.soundOnOff.Text = "Włącz/wyłącz";
            this.soundOnOff.UseVisualStyleBackColor = true;
            // 
            // soundEffects
            // 
            this.soundEffects.BackColor = System.Drawing.Color.Transparent;
            this.soundEffects.Controls.Add(this.soundOnOff);
            this.soundEffects.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.soundEffects.Location = new System.Drawing.Point(10, 150);
            this.soundEffects.Name = "SoundEffects";
            this.soundEffects.Size = new System.Drawing.Size(160, 60);
            this.soundEffects.TabIndex = 8;
            this.soundEffects.TabStop = false;
            this.soundEffects.Text = "Dźwięki w grze";
            contentPanel.Controls.Add(this.soundEffects);
            
        }

        #endregion
        private System.Windows.Forms.RadioButton smallSize;
        private System.Windows.Forms.RadioButton mediumSize;
        private System.Windows.Forms.RadioButton largeSize;
        private System.Windows.Forms.TrackBar speedMovementTrackBar;
        private System.Windows.Forms.Label speedMovementLabel;
        private System.Windows.Forms.GroupBox boardSize;
        private System.Windows.Forms.GroupBox speedMovement;
        private System.Windows.Forms.GroupBox soundEffects;
        private System.Windows.Forms.CheckBox soundOnOff;

    }
}