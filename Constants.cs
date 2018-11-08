namespace ColorLinesGame
{
    public static class Constants
    {
        public static int NumBox()
        {
            return (int)Properties.Settings.Default["boardSize"];
        }

        public static int IntervalBall()
        {
            return (int)Properties.Settings.Default["speedMovement"];
        }

        public static int MinPoints()
        {
            return 5;
        }

        public static int AddBalls()
        {
            return 3;
        }
    }
}
