using System;
using System.Data;
using System.Windows.Forms;
using Subasta.Modelo;
using static Subasta.Program;
using Subasta.Archivo;

namespace Subasta
{
    public partial class Form1 : Form
    {

        DataTable modelo;
        readonly Binario archivo = new Binario();

        public Form1()
        {
            InitializeComponent();
            archivo.Cargar();
            Iniciar();
            Graficar();
        }


        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
        /// <summary>
        /// / Guardar ofertantes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void GuardarOfertantes(object sender, EventArgs e)
        {
            if (ofer_nom.Text.Length == 0 | ofer_nom.Text.StartsWith(" "))
            {
                MessageBox.Show("Ingrese su nombre!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (ofer_ced.Text.Length == 0 | ofer_ced.Text.StartsWith(" "))
            {
                MessageBox.Show("Ingrese su cédula!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (ofer_dep.Text.Length == 0 | ofer_dep.Text.StartsWith(" "))
            {
                MessageBox.Show("Ingrese su deposito!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
               suba.Ofer.Add(new Ofertante(ofer_nom.Text, Int32.Parse(ofer_ced.Text), Convert.ToSingle(ofer_dep.Text)));
                MessageBox.Show("Ofertante guardado!", "Guardado!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ofer_nom.Text = ""; ofer_ced.Text = ""; ofer_dep.Text = "";
                Graficar();
                modelo.Dispose();          
            }
        }

        private void Iniciar()  {
            modelo = new DataTable();
            modelo.Columns.Add("Nombre");
            modelo.Columns.Add("Cedula");
            modelo.Columns.Add("Deposito");
            tabla.DataSource = modelo;  
        }

        /// <summary>
        /// 
        /// </summary>
        private void Graficar()
        {
            modelo.Clear();
            foreach (var i in suba.Ofer)
            {
                DataRow fila = modelo.NewRow();
                fila["Nombre"] = i.nombre;
                fila["Cedula"] = i.cedula;
                fila["Deposito"] = i.deposito;
                modelo.Rows.Add(fila);
               
            }
            modelo.Dispose();
        }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            archivo.Guardar();
            
        }
    }  
}
