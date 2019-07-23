using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventas
{
    public class cliente
    {
        public int Id { get; set; }
        public int NumeroC { get; set; }
        public string Nombre { get; set; }
        public Ciudad Ciudad { get; set; }
        public string Direccion { get; set; }
    }
}
