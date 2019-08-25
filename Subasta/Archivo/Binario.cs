using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using static Subasta.Program;
using Subasta.Modelo;

namespace Subasta.Archivo
{
    public class Binario {
        private readonly string DireccionArchivo = Environment.CurrentDirectory + @"\Datos.cfg";

        public Binario(){

        }

        public void Guardar()
        {
            BinaryFormatter BF = new BinaryFormatter();
            FileStream Archivo = File.OpenWrite(DireccionArchivo);
            BF.Serialize(Archivo, suba);
            Archivo.Close();
            Console.WriteLine("Archivo escrito exitosament1e!");
        }

        public void Cargar()
        {
            if (!File.Exists(DireccionArchivo))
                return;
            BinaryFormatter BF = new BinaryFormatter();
            FileStream Archivo = File.Open(DireccionArchivo, FileMode.Open);
            suba = (SubastaApp)BF.Deserialize(Archivo);
            Archivo.Close();
        }
    }
}
