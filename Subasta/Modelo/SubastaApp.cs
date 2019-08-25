using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subasta.Modelo
{
    [Serializable]
    class SubastaApp
    {
        public List<Ofertante> Ofer { get; set; }
        public List<Celular> Cel { get; set; }

        public SubastaApp() {
        }

        public SubastaApp(List<Ofertante> ofer, List<Celular> cel) {
            this.Ofer = ofer;
            this.Cel = cel;
        }
    }
}
