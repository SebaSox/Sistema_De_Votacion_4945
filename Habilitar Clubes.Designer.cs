
namespace Sistemas_de_votacion
{
    partial class Habilitar_Clubes
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
            this.Clubes_Habilitados = new System.Windows.Forms.CheckedListBox();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.BtnReiniciar = new System.Windows.Forms.Button();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clubes_Habilitados
            // 
            this.Clubes_Habilitados.ColumnWidth = 200;
            this.Clubes_Habilitados.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.Clubes_Habilitados.FormattingEnabled = true;
            this.Clubes_Habilitados.Location = new System.Drawing.Point(12, 12);
            this.Clubes_Habilitados.MultiColumn = true;
            this.Clubes_Habilitados.Name = "Clubes_Habilitados";
            this.Clubes_Habilitados.Size = new System.Drawing.Size(901, 554);
            this.Clubes_Habilitados.TabIndex = 0;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Red;
            this.BtnCerrar.Location = new System.Drawing.Point(964, 374);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(218, 133);
            this.BtnCerrar.TabIndex = 34;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // BtnReiniciar
            // 
            this.BtnReiniciar.BackColor = System.Drawing.Color.DarkOrange;
            this.BtnReiniciar.Location = new System.Drawing.Point(964, 206);
            this.BtnReiniciar.Name = "BtnReiniciar";
            this.BtnReiniciar.Size = new System.Drawing.Size(218, 124);
            this.BtnReiniciar.TabIndex = 35;
            this.BtnReiniciar.Text = "Reiniciar";
            this.BtnReiniciar.UseVisualStyleBackColor = false;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnConfirmar.Location = new System.Drawing.Point(964, 38);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(218, 122);
            this.BtnConfirmar.TabIndex = 36;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            // 
            // Habilitar_Clubes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 600);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.BtnReiniciar);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.Clubes_Habilitados);
            this.Name = "Habilitar_Clubes";
            this.Text = "Habilitar_Clubes";
            this.Load += new System.EventHandler(this.Habilitar_Clubes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Clubes_Habilitados;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button BtnReiniciar;
        private System.Windows.Forms.Button BtnConfirmar;
    }
}