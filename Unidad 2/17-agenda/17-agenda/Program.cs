using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace _17_agenda
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<Models.AgendaContext,
                Migrations.Configuration>());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
