using Mantenimiento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantenimiento.BL
{
    public class CategoriaBL
    {
        public List<Categoria> ListadeCategoria { get; set; }

        public CategoriaBL()
        {
            ListadeCategoria = new List<Categoria>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var categoria1 = new Categoria(1, "laptops");
            var categoria2 = new Categoria(2, "accesorios");

            ListadeCategoria.Add(categoria1);
            ListadeCategoria.Add(categoria2);
        }
    }
}
