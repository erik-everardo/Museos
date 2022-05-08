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
            IronBarCode.License.LicenseKey = "IRONBARCODE.ERIKEVERARDO.6191-47C4EAE892-CO3YDNN2IAWJZBZ-ECZAB5UOFDM4-KGGYRXFB6WRB-73T3ZKGNX7FK-X6BZ2LIWMZP6-YCVBJH-TMPJJQTLUYCFUA-DEPLOYMENT.TRIAL-NHZSBS.TRIAL.EXPIRES.07.JUN.2022";
            Application.Run(Form1.Instance);
        }
    }
}