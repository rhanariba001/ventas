using Mantenimiento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantenimiento.BL
{
    public class CiudadBL
    {
        public List<Ciudad> ListadeCiudad { get; set; }

        public CiudadBL()
        {
            ListadeCiudad = new List<Ciudad>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Puerto Cortes");
            var ciudad2 = new Ciudad(2, "San Pedro Sula");

            ListadeCiudad.Add(ciudad1);
            ListadeCiudad.Add(ciudad2);
        }
    }
}
