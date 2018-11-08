namespace ColorLinesGame
{
    partial class Game
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.gameBoard = new System.Windows.Forms.Panel();
            this.gameBoardFrame = new System.Windows.Forms.Panel();
            this.nextBallsLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.moveBall = new System.Windows.Forms.Timer(this.components);
            this.appearBall = new System.Windows.Forms.Timer(this.components);
            this.quit = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.loadGame = new System.Windows.Forms.Button();
            this.saveGame = new System.Windows.Forms.Button();
            this.leaderboard = new System.Windows.Forms.Button();
            this.undoMove = new System.Windows.Forms.Button();
            this.newGame = new System.Windows.Forms.Button();
            this.ballsFrame = new System.Windows.Forms.Panel();
            this.ballImage3 = new System.Windows.Forms.PictureBox();
            this.ballImage1 = new System.Windows.Forms.PictureBox();
            this.ballImage2 = new System.Windows.Forms.PictureBox();
            this.pointsFrame = new System.Windows.Forms.Panel();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameBoardFrame.SuspendLayout();
            this.ballsFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ballImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballImage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballImage2)).BeginInit();
            this.pointsFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameBoard
            // 
            this.gameBoard.BackColor = System.Drawing.Color.White;
            this.gameBoard.Location = new System.Drawing.Point(10, 10);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.Size = new System.Drawing.Size(540, 540);
            this.gameBoard.TabIndex = 7;
            this.gameBoard.Click += new System.EventHandler(this.GameBoard_Click);
            // 
            // gameBoardFrame
            // 
            this.gameBoardFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gameBoardFrame.Controls.Add(this.gameBoard);
            this.gameBoardFrame.Location = new System.Drawing.Point(20, 60);
            this.gameBoardFrame.Name = "gameBoardFrame";
            this.gameBoardFrame.Size = new System.Drawing.Size(560, 560);
            this.gameBoardFrame.TabIndex = 6;
            // 
            // nextBallsLabel
            // 
            this.nextBallsLabel.AutoSize = true;
            this.nextBallsLabel.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextBallsLabel.Location = new System.Drawing.Point(600, 220);
            this.nextBallsLabel.Name = "nextBallsLabel";
            this.nextBallsLabel.Size = new System.Drawing.Size(113, 31);
            this.nextBallsLabel.TabIndex = 9;
            this.nextBallsLabel.Text = "Następne";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pointsLabel.Location = new System.Drawing.Point(600, 74);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(83, 31);
            this.pointsLabel.TabIndex = 8;
            this.pointsLabel.Text = "Punkty";
            // 
            // moveBall
            // 
            this.moveBall.Tick += new System.EventHandler(this.MoveBall_Tick);
            // 
            // appearBall
            // 
            this.appearBall.Tick += new System.EventHandler(this.AppearBall_Tick);
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.Transparent;
            this.quit.BackgroundImage = global::ColorLinesGame.Properties.Resources.quit;
            this.quit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit.FlatAppearance.BorderSize = 0;
            this.quit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit.Location = new System.Drawing.Point(405, 6);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(48, 48);
            this.quit.TabIndex = 17;
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // information
            // 
            this.information.BackColor = System.Drawing.Color.Transparent;
            this.information.BackgroundImage = global::ColorLinesGame.Properties.Resources.info;
            this.information.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.information.Cursor = System.Windows.Forms.Cursors.Hand;
            this.information.FlatAppearance.BorderSize = 0;
            this.information.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.information.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.information.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.information.Location = new System.Drawing.Point(350, 6);
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(48, 48);
            this.information.TabIndex = 16;
            this.information.UseVisualStyleBackColor = false;
            this.information.Click += new System.EventHandler(this.Information_Click);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.Color.Transparent;
            this.settings.BackgroundImage = global::ColorLinesGame.Properties.Resources.settings;
            this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Location = new System.Drawing.Point(295, 6);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(48, 48);
            this.settings.TabIndex = 15;
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // loadGame
            // 
            this.loadGame.BackColor = System.Drawing.Color.Transparent;
            this.loadGame.BackgroundImage = global::ColorLinesGame.Properties.Resources.load;
            this.loadGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loadGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadGame.FlatAppearance.BorderSize = 0;
            this.loadGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.loadGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadGame.Location = new System.Drawing.Point(240, 6);
            this.loadGame.Name = "loadGame";
            this.loadGame.Size = new System.Drawing.Size(48, 48);
            this.loadGame.TabIndex = 14;
            this.loadGame.UseVisualStyleBackColor = false;
            this.loadGame.Click += new System.EventHandler(this.LoadGame_Click);
            // 
            // saveGame
            // 
            this.saveGame.BackColor = System.Drawing.Color.Transparent;
            this.saveGame.BackgroundImage = global::ColorLinesGame.Properties.Resources.save;
            this.saveGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveGame.FlatAppearance.BorderSize = 0;
            this.saveGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveGame.Location = new System.Drawing.Point(185, 6);
            this.saveGame.Name = "saveGame";
            this.saveGame.Size = new System.Drawing.Size(48, 48);
            this.saveGame.TabIndex = 13;
            this.saveGame.UseVisualStyleBackColor = false;
            this.saveGame.Click += new System.EventHandler(this.SaveGame_Click);
            // 
            // leaderboard
            // 
            this.leaderboard.BackColor = System.Drawing.Color.Transparent;
            this.leaderboard.BackgroundImage = global::ColorLinesGame.Properties.Resources.leaderboard;
            this.leaderboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.leaderboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leaderboard.FlatAppearance.BorderSize = 0;
            this.leaderboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.leaderboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.leaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaderboard.Location = new System.Drawing.Point(130, 6);
            this.leaderboard.Name = "leaderboard";
            this.leaderboard.Size = new System.Drawing.Size(48, 48);
            this.leaderboard.TabIndex = 12;
            this.leaderboard.UseVisualStyleBackColor = false;
            this.leaderboard.Click += new System.EventHandler(this.LeaderBoards_Click);
            // 
            // undoMove
            // 
            this.undoMove.BackColor = System.Drawing.Color.Transparent;
            this.undoMove.BackgroundImage = global::ColorLinesGame.Properties.Resources.undo;
            this.undoMove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.undoMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.undoMove.FlatAppearance.BorderSize = 0;
            this.undoMove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.undoMove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.undoMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.undoMove.Location = new System.Drawing.Point(75, 6);
            this.undoMove.Name = "undoMove";
            this.undoMove.Size = new System.Drawing.Size(48, 48);
            this.undoMove.TabIndex = 11;
            this.undoMove.UseVisualStyleBackColor = false;
            this.undoMove.Click += new System.EventHandler(this.UndoMove_Click);
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.Color.Transparent;
            this.newGame.BackgroundImage = global::ColorLinesGame.Properties.Resources.newgame;
            this.newGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newGame.FlatAppearance.BorderSize = 0;
            this.newGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGame.Location = new System.Drawing.Point(20, 6);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(48, 48);
            this.newGame.TabIndex = 10;
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // ballsFrame
            // 
            this.ballsFrame.BackColor = System.Drawing.Color.Transparent;
            this.ballsFrame.BackgroundImage = global::ColorLinesGame.Properties.Resources.banner;
            this.ballsFrame.Controls.Add(this.ballImage3);
            this.ballsFrame.Controls.Add(this.ballImage1);
            this.ballsFrame.Controls.Add(this.ballImage2);
            this.ballsFrame.Location = new System.Drawing.Point(600, 260);
            this.ballsFrame.Name = "ballsFrame";
            this.ballsFrame.Size = new System.Drawing.Size(180, 80);
            this.ballsFrame.TabIndex = 0;
            // 
            // ballImage3
            // 
            this.ballImage3.BackColor = System.Drawing.Color.Transparent;
            this.ballImage3.Location = new System.Drawing.Point(123, 16);
            this.ballImage3.Name = "ballImage3";
            this.ballImage3.Size = new System.Drawing.Size(48, 48);
            this.ballImage3.TabIndex = 3;
            this.ballImage3.TabStop = false;
            // 
            // ballImage1
            // 
            this.ballImage1.BackColor = System.Drawing.Color.Transparent;
            this.ballImage1.Location = new System.Drawing.Point(9, 16);
            this.ballImage1.Name = "ballImage1";
            this.ballImage1.Size = new System.Drawing.Size(48, 48);
            this.ballImage1.TabIndex = 1;
            this.ballImage1.TabStop = false;
            // 
            // ballImage2
            // 
            this.ballImage2.BackColor = System.Drawing.Color.Transparent;
            this.ballImage2.Location = new System.Drawing.Point(66, 16);
            this.ballImage2.Name = "ballImage2";
            this.ballImage2.Size = new System.Drawing.Size(48, 48);
            this.ballImage2.TabIndex = 2;
            this.ballImage2.TabStop = false;
            // 
            // pointsFrame
            // 
            this.pointsFrame.BackColor = System.Drawing.Color.Transparent;
            this.pointsFrame.BackgroundImage = global::ColorLinesGame.Properties.Resources.banner;
            this.pointsFrame.Controls.Add(this.scoreLabel);
            this.pointsFrame.Location = new System.Drawing.Point(600, 114);
            this.pointsFrame.Name = "pointsFrame";
            this.pointsFrame.Size = new System.Drawing.Size(180, 80);
            this.pointsFrame.TabIndex = 4;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreLabel.Location = new System.Drawing.Point(10, 5);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(160, 60);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 640);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.information);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.loadGame);
            this.Controls.Add(this.saveGame);
            this.Controls.Add(this.leaderboard);
            this.Controls.Add(this.undoMove);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.nextBallsLabel);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.ballsFrame);
            this.Controls.Add(this.pointsFrame);
            this.Controls.Add(this.gameBoardFrame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kulki v.1.0";
            this.gameBoardFrame.ResumeLayout(false);
            this.ballsFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ballImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballImage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballImage2)).EndInit();
            this.pointsFrame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel gameBoardFrame;
        private System.Windows.Forms.Panel gameBoard;
        private System.Windows.Forms.Panel pointsFrame;
        private System.Windows.Forms.Panel ballsFrame;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox ballImage3;
        private System.Windows.Forms.PictureBox ballImage1;
        private System.Windows.Forms.PictureBox ballImage2;
        private System.Windows.Forms.Timer moveBall;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label nextBallsLabel;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button undoMove;
        private System.Windows.Forms.Button leaderboard;
        private System.Windows.Forms.Button saveGame;
        private System.Windows.Forms.Button loadGame;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button information;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Timer appearBall;
    }
}

