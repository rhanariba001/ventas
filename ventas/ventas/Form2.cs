using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Ciudad1 = new Ciudad();
            Ciudad1.Id = 10;
            Ciudad1.Nombre = "unahvs";

            var ciudad2 = new Ciudad();
            ciudad2.Id = 12;
            ciudad2.Nombre = "ceu";

            var ciudad3 = new Ciudad();
            ciudad3.Id = 14;
            ciudad3.Nombre = "cafeteria";

            var cliente1 = new cliente();
            cliente1.Id = 15;
            cliente1.Nombre = "ronaldo";
            cliente1.NumeroC = 98765432;
            cliente1.Ciudad = Ciudad1;
            cliente1.Direccion = "la lima";

            var cliente2 = new cliente();
            cliente2.Id = 15;
            cliente2.Nombre = "pedro";
            cliente2.NumeroC = 98674637;
            cliente2.Ciudad = ciudad2;
            cliente2.Direccion = "sps";

            var cliente3 = new cliente();
            cliente3.Id = 15;
            cliente3.Nombre = "julio";
            cliente3.NumeroC = 98736466;
            cliente3.Ciudad = ciudad3;
            cliente3.Direccion = "choloma";

            var listadeclientes = new List<cliente>();
            listadeclientes.Add(cliente1);
            listadeclientes.Add(cliente2);
            listadeclientes.Add(cliente3);


            foreach (var c in listadeclientes)
            {
                MessageBox.Show("\nNombre: "+c.Nombre + " \nCiudad: " + c.Ciudad.Nombre + "\nNumero: " + c.NumeroC + "\nDireccion: " + c.Direccion);

            }
        }
    }
}
