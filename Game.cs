using AStarAlgorithm;
using ColorLinesGame.Buttons;
using ColorLinesGame.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace ColorLinesGame
{
    public partial class Game : Form
    {
        // data to serialize
        public static int[,] matrix; // 2d array of board
        public static int[] drawnBalls; // list of balls waiting to add to board
        public static int score; // sum of points

        // variables
        bool isPath; // check if path is available
        float cell; // size of single cell
        int activeBall; // value of marked ball
        int oldX, oldY, newX, newY; // cordinates old and new positions
        int index; // number of neighboring balls
        int buttonIndex; // number to show buttons in path

        // fields
        Button[,] boardButtons; // array of buttons on board
        Image[] ballColors; // array of balls available in game

        // objects
        List<Tuple<int, int>> orderedNodes; // list of coordianates of path for ball
        List<Tuple<int, int>> emptyCoordinates; // list of coordianates where balls can be added
        List<Tuple<int, int>> toRemove; // list of coordianates to remove ball
        Random rand; // responsible for draw next balls
        SoundPlayer player; // responsible for sound in game

        public Game()
        {
            InitializeComponent();
            CreateGame();
            NextBalls();
            AddBalls();
            UpdateView();
        }

        public Game(int[,] m, int[] nb, int pts)
        {
            InitializeComponent();
            CreateGame();
            matrix = m;
            drawnBalls = nb;
            score = pts;
            scoreLabel.Text = score.ToString();
            UpdateView();
        }

        private void Game_Load(int[,] m, int[] nb, int pts, object sender, EventArgs e)
        {

        }

        private void CreateGame()
        {
            matrix = new int[Constants.NumBox(), Constants.NumBox()];
            cell = gameBoard.Width / Constants.NumBox();
            ballColors = new Image[] { Resources.ball1, Resources.ball2, Resources.ball3, Resources.ball4, Resources.ball5 };
            boardButtons = new Button[Constants.NumBox(), Constants.NumBox()];
            player = new SoundPlayer();
            rand = new Random();
            orderedNodes = new List<Tuple<int, int>>();
            emptyCoordinates = new List<Tuple<int, int>>();
            toRemove = new List<Tuple<int, int>>();
            drawnBalls = new int[Constants.AddBalls()];
            buttonIndex = 0;
            score = 0;
            index = 1;
            
            // create board
            for (int i = 0; i < Constants.NumBox(); i++)
            {
                for (int j = 0; j < Constants.NumBox(); j++)
                {
                    float locX = j * cell;
                    float locY = i * cell;
                    boardButtons[j, i] = new Button();
                    boardButtons[j, i].Left = (int)locX;
                    boardButtons[j, i].Top = (int)locY;
                    boardButtons[j, i].Width = (int)cell;
                    boardButtons[j, i].Height = (int)cell;
                    boardButtons[j, i].Click += new EventHandler(GameBoard_Click);
                    gameBoard.Controls.Add(boardButtons[j, i]);
                }
            }
        }

        private void GameBoard_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int x = (int)(b.Location.X / cell);
            int y = (int)(b.Location.Y / cell);

            if (matrix[x, y] != 0) // field to select ball
            {
                activeBall = matrix[x, y];
                oldX = x;
                oldY = y;
            }
            else if (matrix[x, y] == 0 && activeBall != 0) // empty field with active ball
            {
                CreatePath(oldX, oldY, x, y);   
            }
        }

        private void CreatePath(int startX, int startY, int endX, int endY) //ok
        {
            orderedNodes.Clear();
            int curX = endX;
            int curY = endY;

            var grid = new Grid2D(matrix, startX, startY, endX, endY);
            var searchPath = new AStar(grid.Start, grid.Goal);

            isPath = searchPath.Run().ToString() == "Failed" ? false : true;
            if (isPath)
            {
                var pathElements = grid.Print(searchPath.GetPath());
                int numElements = pathElements.Count;

                while (orderedNodes.Count != numElements)
                {
                    for (int i = 0; i < pathElements.Count; i++)
                    {
                        if (Math.Abs(pathElements[i].Item1 - curX) + Math.Abs(pathElements[i].Item2 - curY) == 1)
                        {
                            orderedNodes.Add(new Tuple<int, int>(pathElements[i].Item1, pathElements[i].Item2));
                            curX = pathElements[i].Item1;
                            curY = pathElements[i].Item2;
                            pathElements.RemoveAt(i);
                        }
                    }
                }
                orderedNodes.Reverse();
                orderedNodes.Add(new Tuple<int, int>(endX, endY));
                newX = endX;
                newY = endY;
                moveBall.Start();
                moveBall.Interval = Constants.IntervalBall();
            }
            else
            {
                PlaySounds((bool)Properties.Settings.Default["effectOn"], Resources.error);
            }
        }

        private void PlaySounds(bool effectOn, System.IO.Stream sound)
        {
            if (effectOn)
            {
                player.Stream = sound;
                player.Play();
            } 
        }

        private bool IsGameOver()
        {
            for (int i = 0; i < Constants.NumBox(); i++)
            {
                for (int j = 0; j < Constants.NumBox(); j++)
                {
                    if (matrix[j, i] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void MoveBall_Tick(object sender, EventArgs e)
        {
            boardButtons[orderedNodes[buttonIndex].Item1, orderedNodes[buttonIndex].Item2].Image = ballColors[activeBall - 1];
            //PlaySounds((bool)Properties.Settings.Default["effectOn"], Resources.move);

            if (buttonIndex == 0)
            {
                boardButtons[oldX, oldY].Image = null;
            }
            else if (buttonIndex > 0)
            {
                boardButtons[orderedNodes[buttonIndex - 1].Item1, orderedNodes[buttonIndex - 1].Item2].Image = null;
            }
            buttonIndex++;

            if (buttonIndex == orderedNodes.Count)
            {
                moveBall.Stop();
                buttonIndex = 0;
                matrix[newX, newY] = activeBall;
                matrix[oldX, oldY] = 0;
                activeBall = 0;
                RemoveBalls();
                AddBalls();
                UpdateView();
                
                if(toRemove.Count >= Constants.MinPoints())UpdateScore(toRemove.Count);

                if (IsGameOver())
                {
                    PlaySounds((bool)Properties.Settings.Default["effectOn"], Resources.gameover);
                    FinalScreen gameOver = new FinalScreen("Koniec gry", "Podaj swoje imię:", score);
                    gameOver.ShowDialog();
                }
            }
        }

        private void AppearBall_Tick(object sender, EventArgs e)
        {
            
        }

        private void NextBalls()
        {
            Array.Clear(drawnBalls, 0, drawnBalls.Length);

            for (int i = 0; i < Constants.AddBalls(); i++)
            {
                drawnBalls[i] = rand.Next(1, Constants.MinPoints() + 1); // random.next() method never returns value of upper bound
            }
        }

        private void AddBalls()
        {
            int exactNum = 0;
            emptyCoordinates.Clear();

            for (int i = 0; i < Constants.NumBox(); i++)
            {
                for (int j = 0; j < Constants.NumBox(); j++)
                {
                    if (matrix[j, i] == 0)
                    {
                        emptyCoordinates.Add(new Tuple<int, int>(j, i));
                    }
                }
            }

            exactNum = emptyCoordinates.Count < Constants.AddBalls() ? emptyCoordinates.Count : Constants.AddBalls();

            for (int i = 0; i < exactNum; i++)
            {
                int EmptyIndex = rand.Next(0, emptyCoordinates.Count - 1);
                matrix[emptyCoordinates[EmptyIndex].Item1, emptyCoordinates[EmptyIndex].Item2] = drawnBalls[i];
                emptyCoordinates.RemoveAt(EmptyIndex);
            }
            NextBalls();
            RemoveBalls();
        }

        private void RemoveBalls()
        {
            toRemove.Clear();

            // 0 - horizontal, 1 - vertical, 2 - diagonal
            Line(0);
            Line(1);
            //Line(2);

            for (int i = 0; i < toRemove.Count(); i++)
            {
                matrix[toRemove[i].Item1, toRemove[i].Item2] = 0;
            }

            toRemove = toRemove.Distinct().ToList(); // removes duplicates
            if (toRemove.Count >= Constants.MinPoints()) UpdateScore(toRemove.Count);
        }

        private void Line(int ver) // do uzupelnienia diagonalne
        {
            int a = 0, b = 0, aNext = 0, bNext = 0, aRemove = 0, bRemove = 0;
            bool isNext = false;

            for (int i = 0; i < Constants.NumBox(); i++)
            {
                index = 1;

                for (int j = 0; j < Constants.NumBox() - 1; j++)
                {
                    switch(ver)
                    {
                        case 0:
                            a = j;
                            b = i;
                            aNext = j + 1;
                            bNext = i;
                            break;
                        case 1:
                            a = i;
                            b = j;
                            aNext = i;
                            bNext = j + 1;
                            break;
                        case 2:
                            //////////////////////
                            break;
                    }

                    if (matrix[a, b] == matrix[aNext, bNext] && matrix[a, b] != 0)
                    {
                        index++;
                        isNext = true;
                        if (aNext == Constants.NumBox() - 1 && ver == 0)
                        {
                            isNext = false;
                            a = aNext;
                        }
                        else if (bNext == Constants.NumBox() - 1 && ver == 1)
                        {
                            isNext = false;
                            b = bNext;
                        }
                    }
                    else
                    {
                        isNext = false;
                    }

                    if (!isNext)
                    {
                        if(index >= Constants.MinPoints())
                        {
                            for (int k = 0; k < index; k++)
                            {
                                switch (ver)
                                {
                                    case 0:
                                        aRemove = a - k;
                                        bRemove = b;
                                        break;
                                    case 1:
                                        aRemove = a;
                                        bRemove = b - k;
                                        break;
                                    case 2:
                                        //////////////////////
                                        break;
                                }
                                toRemove.Add(new Tuple<int, int>(aRemove, bRemove));
                            }
                            index = 1;
                        }
                        index = 1;
                    }
                }
            }          
        }

        private void UpdateView()
        {
            ballImage1.Image = ballColors[drawnBalls[0] - 1];
            ballImage2.Image = ballColors[drawnBalls[1] - 1];
            ballImage3.Image = ballColors[drawnBalls[2] - 1];

            for (int i = 0; i < Constants.NumBox(); i++)
            {
                for (int j = 0; j < Constants.NumBox(); j++)
                {
                    if (matrix[j, i] != 0)
                    {
                        boardButtons[j, i].Image = ballColors[matrix[j, i] - 1];
                    }
                    else
                    {
                        boardButtons[j, i].Image = null;
                    }
                }
            }
        }

        private void UpdateScore(int addPoints)
        {
            score += addPoints * 2 - Constants.MinPoints();
            scoreLabel.Text = score.ToString();

            PlaySounds((bool)Properties.Settings.Default["effectOn"], Resources.points);
        }
    
        private void NewGame_Click(object sender, EventArgs e)
        {
            NewGame newGame = new NewGame("Nowa gra", "Czy na pewno chcesz zacząć nową grę?");
            newGame.ShowDialog();
        }

        private void UndoMove_Click(object sender, EventArgs e)
        {
            UndoMove undoMove = new UndoMove("Cofnij", "Czy na pewno chcesz cofnąć ruch?");
            undoMove.ShowDialog();
        }

        private void LeaderBoards_Click(object sender, EventArgs e)
        {
            Leaderboard leaderboard = new Leaderboard("Wyniki");
            leaderboard.ShowDialog();
        }

        private void SaveGame_Click(object sender, EventArgs e)
        {
            Save save = new Save("Zapisz", "Podaj nazwę, pod jaką chcesz zapisać grę:");
            save.ShowDialog();
        }

        private void LoadGame_Click(object sender, EventArgs e)
        {
            Load load = new Load("Wczytaj");
            load.ShowDialog();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings("Ustawienia");
            settings.ShowDialog();
        }

        private void Information_Click(object sender, EventArgs e)
        {
            Information information = new Information("Informacje", "Nazwa gry: Kulki v.1.0\nAutor: Rafał Kluziński\n");
            information.ShowDialog();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Quit quit = new Quit("Wyjście", "Czy na pewno chcesz wyjść z gry?");
            quit.ShowDialog();
        }
    }
}
