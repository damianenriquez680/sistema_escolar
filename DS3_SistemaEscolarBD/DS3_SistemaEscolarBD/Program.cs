namespace DS3_SistemaEscolarBD
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Solo abrir el Splash Screen
            Application.Run(new Splashscreen());
        }
    }
}