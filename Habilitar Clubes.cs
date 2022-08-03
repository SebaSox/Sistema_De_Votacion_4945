using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistemas_de_votacion
{
    public partial class Habilitar_Clubes : Form
    {
        public Habilitar_Clubes()
        {
            InitializeComponent();
        }
        private void Habilitar_Clubes_Load(object sender, EventArgs e)
        {
            CargarChecks();
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void CargarChecks()
        {
            //Cargar o sacar los clubes en este array
            string[] Clubes = {"Armstrong", "Capitán Bermudez","Casilda","Cañada de Gómez","Ceres EF","Colón",
                "Esperanza","Federal","Firmat","Fray Bentos","Gálvez","Gualeguaychú","Las Parejas EF",
                "María Susana","Paraná","Rafaela","Rosario","Rosario Norte","Rosario Plaza de la Bandera",
                "Rosario Sud","Salto","Salto Noreste","Salto Grande Concordia","San Javier","San Jorge EF","San Justo",
                "Santa Fe","Santo Tomé EF","Sunchales,Totoras","Venado Tuerto","Venado Tuerto 50°",
                "Villa Constitución"};

            foreach (var CheckClub in Clubes)
            {
                Clubes_Habilitados.Items.Add(CheckClub);
            }

        }
    }
}
