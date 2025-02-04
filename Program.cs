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

            //Application.Run(new SalesMan());
            //Application.Run(new AddGames());
            Application.Run(new SalesMan("yusuf", "123456", "salesman"));


            //Application.Run(new AddGames());
            //Application.Run(new Admin_Homepage());
            //Application.Run(new Manager_Homepage("ankon","123456","manager"));
            //Application.Run(new All_Role());
            //Application.Run(new CartPage(5,"yusuf", "123456"));
            //Application.Run(new Manager_all_product());
            //Application.Run(new SalesMan("ankon", "yusuf"));
            //Application.Run(new Login("a"));
            //Application.Run(new RegisterPage());
            //Application.Run(new Manager_Activity());    

        }
    }
}