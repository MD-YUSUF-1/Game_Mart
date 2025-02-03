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

            //Application.Run(new SalesMan("a","b"));

//Application.Run(new AddGames());
            //Application.Run(new SalesMan("ankon", "yusuf"));


            //Application.Run(new AddGames());
<<<<<<< HEAD
           // Application.Run(new Admin_Homepage());
            Application.Run(new All_Role());
            //Application.Run(new CartPage());
=======
            //Application.Run(new Admin_Homepage());
            //Application.Run(new All_Role());
<<<<<<< HEAD
            Application.Run(new CartPage(5));
>>>>>>> d9162b54196e2c9a623d09307cf4d31237c9833f
=======
            Application.Run(new CartPage(5,"yusuf","123456"));
>>>>>>> 5c782ecbccc090ebd1e4ab54d177f325ed692f07

            //Application.Run(new SalesMan("ankon", "yusuf"));
            //Application.Run(new Login("a"));


        }
    }
}