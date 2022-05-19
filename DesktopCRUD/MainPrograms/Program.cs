using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DesktopCRUD.Forms;

namespace DesktopCRUD.MainPrograms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //DataBase.Connection();
            Music.MusicPlayerStatus = true;
            var musicThreadStart = new ThreadStart(Music.StartPlay);
            var musicThread = new Thread(musicThreadStart);
            musicThread.Start();
            Application.Run(new Flights());
        }
    }
}