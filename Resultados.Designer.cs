
namespace Sistemas_de_votacion
{
    partial class Resultados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LdlNegativo = new System.Windows.Forms.Label();
            this.LblAbstencion = new System.Windows.Forms.Label();
            this.LblPositivo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LdlNegativo
            // 
            this.LdlNegativo.AutoSize = true;
            this.LdlNegativo.BackColor = System.Drawing.Color.Red;
            this.LdlNegativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LdlNegativo.Location = new System.Drawing.Point(96, 173);
            this.LdlNegativo.Name = "LdlNegativo";
            this.LdlNegativo.Size = new System.Drawing.Size(173, 189);
            this.LdlNegativo.TabIndex = 0;
            this.LdlNegativo.Text = "0";
            // 
            // LblAbstencion
            // 
            this.LblAbstencion.AutoSize = true;
            this.LblAbstencion.BackColor = System.Drawing.Color.Gainsboro;
            this.LblAbstencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAbstencion.Location = new System.Drawing.Point(429, 173);
            this.LblAbstencion.Name = "LblAbstencion";
            this.LblAbstencion.Size = new System.Drawing.Size(173, 189);
            this.LblAbstencion.TabIndex = 1;
            this.LblAbstencion.Text = "0";
            // 
            // LblPositivo
            // 
            this.LblPositivo.AutoSize = true;
            this.LblPositivo.BackColor = System.Drawing.Color.Lime;
            this.LblPositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPositivo.Location = new System.Drawing.Point(766, 173);
            this.LblPositivo.Name = "LblPositivo";
            this.LblPositivo.Size = new System.Drawing.Size(173, 189);
            this.LblPositivo.TabIndex = 2;
            this.LblPositivo.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Negativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Abstencion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(791, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Positivo";
            // 
            // Timer
            // 
            this.Timer.Interval = 5000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 533);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblPositivo);
            this.Controls.Add(this.LblAbstencion);
            this.Controls.Add(this.LdlNegativo);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LdlNegativo;
        private System.Windows.Forms.Label LblAbstencion;
        private System.Windows.Forms.Label LblPositivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Timer;
    }
}