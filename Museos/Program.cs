namespace Museos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Nos aseguramos de que el archivo de base de datos existe
            new AppDbContext().Database.EnsureCreated();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(Form1.Instance);
        }
    }
}