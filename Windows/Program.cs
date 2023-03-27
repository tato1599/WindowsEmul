namespace Windows
{
    internal static class Program
    {
        public static Form1 f1 = null;
        public static InicioSesion f2 = null;
        public static Principalcs f3 = null;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}