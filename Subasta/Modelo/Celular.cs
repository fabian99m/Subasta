
using System;
namespace Subasta.Modelo
{
    [Serializable]
    class Celular
    {
       public int id { get; set; }
       public string marca {get; set;}
       public string gama {get; set;}
       public string modelo {get; set;}
       public float precio {get; set;}
       public int numero_oferta { get; set; }
       public float valorr_oferta { get; set; }

        public Celular() {
        }

        public Celular(int id, string marca, string gama, string modelo, float precio, int numero_oferta, float valorr_oferta)
        {
            this.id = id;
            this.marca = marca;
            this.gama = gama;
            this.modelo = modelo;
            this.precio = precio;
            this.numero_oferta = numero_oferta;
            this.valorr_oferta = valorr_oferta;
        }
    }
}
