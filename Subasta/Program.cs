using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Subasta.Modelo;


namespace Subasta
{
	static class Program
	{
		// lista de ofertantes
		public static List<Ofertante> ofer = new List<Ofertante>();

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
