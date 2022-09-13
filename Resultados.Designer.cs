
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
            this.LblNegativo = new System.Windows.Forms.Label();
            this.LblAbstencion = new System.Windows.Forms.Label();
            this.LblPositivo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.BtnDetener = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnReanudar = new System.Windows.Forms.Button();
            this.LblFaltantes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblTotales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblNegativo
            // 
            this.LblNegativo.AutoSize = true;
            this.LblNegativo.BackColor = System.Drawing.Color.Red;
            this.LblNegativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblNegativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNegativo.Location = new System.Drawing.Point(731, 173);
            this.LblNegativo.MinimumSize = new System.Drawing.Size(266, 189);
            this.LblNegativo.Name = "LblNegativo";
            this.LblNegativo.Size = new System.Drawing.Size(266, 189);
            this.LblNegativo.TabIndex = 0;
            this.LblNegativo.Text = "0";
            // 
            // LblAbstencion
            // 
            this.LblAbstencion.AutoSize = true;
            this.LblAbstencion.BackColor = System.Drawing.Color.Gainsboro;
            this.LblAbstencion.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAbstencion.Location = new System.Drawing.Point(398, 173);
            this.LblAbstencion.MinimumSize = new System.Drawing.Size(266, 189);
            this.LblAbstencion.Name = "LblAbstencion";
            this.LblAbstencion.Size = new System.Drawing.Size(266, 189);
            this.LblAbstencion.TabIndex = 1;
            this.LblAbstencion.Text = "0";
            // 
            // LblPositivo
            // 
            this.LblPositivo.AutoSize = true;
            this.LblPositivo.BackColor = System.Drawing.Color.Lime;
            this.LblPositivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPositivo.Location = new System.Drawing.Point(65, 173);
            this.LblPositivo.MinimumSize = new System.Drawing.Size(266, 189);
            this.LblPositivo.Name = "LblPositivo";
            this.LblPositivo.Size = new System.Drawing.Size(266, 189);
            this.LblPositivo.TabIndex = 2;
            this.LblPositivo.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(776, 367);
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
            this.label3.Location = new System.Drawing.Point(121, 366);
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
            // BtnDetener
            // 
            this.BtnDetener.Location = new System.Drawing.Point(97, 439);
            this.BtnDetener.Name = "BtnDetener";
            this.BtnDetener.Size = new System.Drawing.Size(172, 69);
            this.BtnDetener.TabIndex = 6;
            this.BtnDetener.Text = "Detener Votacion";
            this.BtnDetener.UseVisualStyleBackColor = true;
            this.BtnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(763, 439);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(176, 69);
            this.BtnCerrar.TabIndex = 7;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnReanudar
            // 
            this.BtnReanudar.Location = new System.Drawing.Point(430, 439);
            this.BtnReanudar.Name = "BtnReanudar";
            this.BtnReanudar.Size = new System.Drawing.Size(172, 69);
            this.BtnReanudar.TabIndex = 8;
            this.BtnReanudar.Text = "Reanudar Votacion";
            this.BtnReanudar.UseVisualStyleBackColor = true;
            this.BtnReanudar.Click += new System.EventHandler(this.BtnReanudar_Click);
            // 
            // LblFaltantes
            // 
            this.LblFaltantes.AutoSize = true;
            this.LblFaltantes.BackColor = System.Drawing.SystemColors.Control;
            this.LblFaltantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFaltantes.ForeColor = System.Drawing.Color.Red;
            this.LblFaltantes.Location = new System.Drawing.Point(547, 45);
            this.LblFaltantes.Name = "LblFaltantes";
            this.LblFaltantes.Size = new System.Drawing.Size(87, 95);
            this.LblFaltantes.TabIndex = 9;
            this.LblFaltantes.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 95);
            this.label5.TabIndex = 10;
            this.label5.Text = "|";
            // 
            // LblTotales
            // 
            this.LblTotales.AutoSize = true;
            this.LblTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotales.Location = new System.Drawing.Point(387, 45);
            this.LblTotales.Name = "LblTotales";
            this.LblTotales.Size = new System.Drawing.Size(134, 95);
            this.LblTotales.TabIndex = 11;
            this.LblTotales.Text = "34";
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 533);
            this.Controls.Add(this.LblTotales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblFaltantes);
            this.Controls.Add(this.BtnReanudar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnDetener);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblPositivo);
            this.Controls.Add(this.LblAbstencion);
            this.Controls.Add(this.LblNegativo);
            this.Name = "Resultados";
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.Resultados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNegativo;
        private System.Windows.Forms.Label LblAbstencion;
        private System.Windows.Forms.Label LblPositivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button BtnDetener;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnReanudar;
        private System.Windows.Forms.Label LblFaltantes;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label LblTotales;
    }
}