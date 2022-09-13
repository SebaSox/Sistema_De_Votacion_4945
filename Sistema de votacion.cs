using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using intermediario;


namespace Sistemas_de_votacion
{
    public partial class Sistema_de_votacion : Form
    {
        IntermediarioSQL c = new IntermediarioSQL();
        public List<string> HabilitadosEnSistema = new List<string>();
        public Sistema_de_votacion()
        {     
            InitializeComponent();
            TxtNumReu.Text = LblNumReu.Text;
            TxtConsulta.Text = "";
        }

        private void FunNReu(object sender, EventArgs e)
        {
            if (TxtNumReu.Text != null)
            {
                LblNumReu.Text = TxtNumReu.Text;
            }
            else
            {
                LblNumReu.Text = "0";
            }
        }

        private void habilitarClubesToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            Habilitar_Clubes Clubes = new Habilitar_Clubes();
            AddOwnedForm(Clubes);
            this.Hide();
            Clubes.ShowDialog();
            this.Show();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (TxtClubesHabilitados.Text != "")
            {
                if (TxtConsulta.Text !="")
                {
                    c.GenerarPregunta(Int32.Parse(LblNumReu.Text), TxtConsulta.Text, TxtClubesHabilitados.Text);
                    Resultados Resul = new Resultados();
                    AddOwnedForm(Resul);
                    this.Hide();
                    Resul.LblTotales.Text =this.LblClubesHabilitados.Text;
                    Resul.ShowDialog();
                    TxtConsulta.Text = "";
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tienes que escribir una pregunta previamente");
                }
            }
            else
            {
                MessageBox.Show("Tienes que seleccionar los clubes habilitados previamente");
            }   
        }
        
        public void ActualizarLbl(List<string> Habilitados)
        { 
            TxtClubesHabilitados.Text = "";
            LblClubesHabilitados.Text = Habilitados.Count().ToString();
            foreach (var item in Habilitados)
            {
                TxtClubesHabilitados.Text = TxtClubesHabilitados.Text + item + ",  ";
            }
            HabilitadosEnSistema.AddRange(Habilitados);
        }

        private void TxtNumReu_KeyPress(object sender, KeyPressEventArgs e)
        {
            Herramientas.SoloNumeros(e);
        }
    }
}
