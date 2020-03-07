using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace SimuladorSegurosResidenciais
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //try
            //{
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);                
            Application.Run(new Form1());
                //var assembly = Assembly.GetExecutingAssembly();
                //var stream = assembly.GetManifestResourceStream("states.txt");
                //var fileStream = File.Create(@"C:\states.txt");
                //stream.Seek(0, SeekOrigin.Begin);
                //stream.CopyTo(fileStream);
                //fileStream.Close();
            //} catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
