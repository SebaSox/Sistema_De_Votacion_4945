﻿using System;
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
        
        //es obvio
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //boton de confirmar envia los datos
        private void BtnConfirmar_Click(object sender, EventArgs e)
        {

            List<string> Habilitados = new List<string>();
            string tempo;

            for (int i = 0; i < Clubes_Habilitados.Items.Count; i++)
            {
                if (Clubes_Habilitados.GetItemChecked(i) == true)
                {
                    tempo = Clubes_Habilitados.Items[i].ToString();
                    Habilitados.Add(tempo);
                }
            }
            if (Habilitados.Count() == 0 )
            {
                MessageBox.Show("Selecciona algun club antes de oprimir este boton");
            }
            else
            {
                //el owner sirve para enviar datos al form padre
                Sistema_de_votacion SisVot = Owner as Sistema_de_votacion;
                SisVot.ActualizarLbl(Habilitados);
                this.Close();
            }
        }

        //esto llama a la funcion de abajo para conseguir los nombres de los clubes
        private void Habilitar_Clubes_Load(object sender, EventArgs e)
        {
            CargarChecks();
        }
        //aca se encuentran los nombres de los clubes que hay que cargar (posteriormente los pondre
        //en la base de datos)
        private void CargarChecks()
        {

            //Cargar o sacar los clubes en este array
            string[] Clubes = {"Armstrong", "Capitán Bermudez","Casilda","Cañada de Gómez","Ceres EF","Colón",
                "Esperanza","Federal","Firmat","Fray Bentos","Gálvez","Gualeguaychú","Las Parejas EF",
                "María Susana","Paraná","Rafaela","Rosario","Rosario Norte","Rosario Plaza de la Bandera",
                "Rosario Sud","Salto","Salto Noreste","Salto Grande Concordia","San Javier","San Jorge EF",
                "San Justo","Santa Fe","Santo Tomé EF","Sunchales,Totoras","Venado Tuerto","Venado Tuerto 50°",
                "Villa Constitución"};
            foreach (var CheckClub in Clubes)
            {
                Clubes_Habilitados.Items.Add(CheckClub);
            }

        }
        //reiniciar los checks
        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            Clubes_Habilitados.Items.Clear();
            CargarChecks();
        }
    }
}


