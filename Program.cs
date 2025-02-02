namespace ProjectWin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new AddGames());
            //Application.Run(new SalesMan("a","b"));
=======
Application.Run(new AddGames());
            //Application.Run(new SalesMan("ankon", "yusuf"));
>>>>>>> fa77ec117b3c23374e61ae8ab89ed0548f6b0270
        }
    }
}