using App.Core.Services;
using App.WindowsApp.Forms;


namespace App.WindowsApp


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
            var productService = new InMemoryProductService();
            Application.Run(new MainForm(productService));
        }
    }

}