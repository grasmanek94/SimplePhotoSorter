using System;
using System.Windows.Forms;

namespace PhotoSorting
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new PhotoSortForm());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Applicatiefout opgetreden, foutmelding:\r\n" + ex.Message, "Fout");
            }
        }
    }
}
