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
    public partial class Resultados : Form
    {
        IntermediarioSQL c = new IntermediarioSQL();
        
        public Resultados()
        {
            InitializeComponent();
        }
        public string IdReunion;
        private void Resultados_Load(object sender, EventArgs e)
        {
            //comienza el timer cada X tiempo ya estipulado antes
            IdReunion = c.ConsultarPregunta();
            Timer.Start();
        }
        public int Contador = 0;
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            
            LblNegativo.Text = c.ActualizarResultados("1", IdReunion);
            LblAbstencion.Text = c.ActualizarResultados("2", IdReunion);
            LblPositivo.Text = c.ActualizarResultados("3", IdReunion);


            if (Int32.Parse(LblTotales.Text) != Contador)
            {
                
                Contador = Int32.Parse(LblNegativo.Text)+ Int32.Parse(LblAbstencion.Text) + 
                    Int32.Parse(LblPositivo.Text);
                LblFaltantes.Text = Contador.ToString();
            }
            else
            {
                Timer.Stop();
                Contador = Int32.Parse(LblNegativo.Text) + Int32.Parse(LblAbstencion.Text) +
                    Int32.Parse(LblPositivo.Text);
                LblFaltantes.Text = Contador.ToString();
                LblFaltantes.ForeColor = Color.Lime;
                BtnReanudar.Enabled = false;
                BtnDetener.Enabled = false;
            }
            
        }

        private void BtnDetener_Click(object sender, EventArgs e)
        {
            Timer.Stop();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            this.Close();
        }

        private void BtnReanudar_Click(object sender, EventArgs e)
        {
            Timer.Start();
        }
    }
}
