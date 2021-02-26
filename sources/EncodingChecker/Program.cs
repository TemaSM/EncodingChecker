using System;
using System.Threading;
using System.Windows.Forms;
using SharpRaven;

namespace EncodingChecker
{
    internal static class Program
    {
        public static RavenClient ravenClient;
        [STAThread]
        private static void Main()
        {
            Application.ThreadException += OnApplicationThreadException;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ravenClient = new RavenClient("https://09c4c97e7db24bc99ea8b59d5bb484d5@o535078.ingest.sentry.io/5654022");
            Application.Run(new MainForm());
        }

        private static void OnApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}