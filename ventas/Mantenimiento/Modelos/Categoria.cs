using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantenimiento.Modelos
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Categoria(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}
