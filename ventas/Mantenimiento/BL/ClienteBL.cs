using Mantenimiento.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantenimiento.BL
{
    public class ClienteBL
    {
        public List<Cliente> ListadeCliente { get; set; }

        public ClienteBL()
        {
            ListadeCliente = new List<Cliente>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "Puerto Cortes");
            var ciudad2 = new Ciudad(2, "San Pedro Sula");

            var Cliente1 = new Cliente(1, "Juan Perez","9999-9999","calle JP2",ciudad1);
            var Cliente2 = new Cliente(2, "Maria Martinez","8888-8888","7 calle",ciudad2);
            

            ListadeCliente.Add(Cliente1);
            ListadeCliente.Add(Cliente2);
            
        }
    }
}
