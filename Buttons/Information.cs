namespace ColorLinesGame.Buttons
{
    public partial class Information : HorDialog
    {
        public Information(string title, string message) : base(title, message)
        {
            InitializeComponent();
            cancelButton.Visible = false;
        }
    }
}
