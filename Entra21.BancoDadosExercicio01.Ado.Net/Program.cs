using Entra21.BancoDadosExercicio01.Ado.Net.Views;

namespace Entra21.BancoDadosExercicio01.Ado.Net
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
            Application.Run(new MenuPrincipalForm());
        }
    }
}