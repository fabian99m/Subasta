
using System;
namespace Subasta.Modelo
{   [Serializable]
    public class Ofertante
    {
        public string nombre { get; set; }
        public int cedula { get; set; }
        public float deposito { get; set; }

        public Ofertante()
        {
        }

        public Ofertante(string nombre, int cedula, float deposito)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.deposito = deposito;
        }

    }
}
