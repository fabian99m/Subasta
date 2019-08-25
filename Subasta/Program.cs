using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Subasta.Modelo;


namespace Subasta
{
    static class Program
    {
        // Objecto de subasta
       public static SubastaApp suba = new SubastaApp(new List<Ofertante>(), new List<Celular>());

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
