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
            
            Habilitar_Clubes v1 = new Habilitar_Clubes();
            this.Hide();
            v1.ShowDialog();
            this.Show();
        }
    }
}
