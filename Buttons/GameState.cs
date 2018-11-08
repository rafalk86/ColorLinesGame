namespace ColorLinesGame.Buttons
{
    public class GameState
    {
        public int[,] boardState = new int[Constants.NumBox(), Constants.NumBox()];
        public int[] nextBallsState = new int[Constants.AddBalls()];
        public int pointsState = 0;
    }
}
