using System;
using System.Threading;
using System.Windows.Forms;

namespace ColorLinesGame
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread task = new Thread(new ThreadStart(() =>
            {
                Application.Run(new Game());
            }));
            task.Start();
        }
    }
}
