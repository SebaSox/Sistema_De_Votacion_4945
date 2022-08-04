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
    public partial class Sistema_de_votacion : Form
    {
        public Sistema_de_votacion()
        {
            InitializeComponent();
            TxtNumReu.Text = LblNumReu.Text;
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
            Resultados Resul = new Resultados();
            AddOwnedForm(Resul);
            this.Hide();
            Resul.ShowDialog();
            this.Show();
        }
    }
}
