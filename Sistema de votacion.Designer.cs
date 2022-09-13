
namespace Sistemas_de_votacion
{
    partial class Sistema_de_votacion
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nReunionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtNumReu = new System.Windows.Forms.ToolStripTextBox();
            this.habilitarClubesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.LblNumReu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblClubesHabilitados = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.TxtClubesHabilitados = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nReunionToolStripMenuItem,
            this.habilitarClubesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nReunionToolStripMenuItem
            // 
            this.nReunionToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.nReunionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtNumReu});
            this.nReunionToolStripMenuItem.Name = "nReunionToolStripMenuItem";
            this.nReunionToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.nReunionToolStripMenuItem.Text = "N° Reunion";
            // 
            // TxtNumReu
            // 
            this.TxtNumReu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtNumReu.Name = "TxtNumReu";
            this.TxtNumReu.Size = new System.Drawing.Size(100, 27);
            this.TxtNumReu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumReu_KeyPress);
            this.TxtNumReu.TextChanged += new System.EventHandler(this.FunNReu);
            // 
            // habilitarClubesToolStripMenuItem
            // 
            this.habilitarClubesToolStripMenuItem.Name = "habilitarClubesToolStripMenuItem";
            this.habilitarClubesToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.habilitarClubesToolStripMenuItem.Text = "Habilitar Clubes";
            this.habilitarClubesToolStripMenuItem.Click += new System.EventHandler(this.habilitarClubesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de reunion";
            // 
            // LblNumReu
            // 
            this.LblNumReu.AutoSize = true;
            this.LblNumReu.Location = new System.Drawing.Point(164, 76);
            this.LblNumReu.Name = "LblNumReu";
            this.LblNumReu.Size = new System.Drawing.Size(16, 17);
            this.LblNumReu.TabIndex = 2;
            this.LblNumReu.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clubes habilitados";
            // 
            // LblClubesHabilitados
            // 
            this.LblClubesHabilitados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblClubesHabilitados.AutoSize = true;
            this.LblClubesHabilitados.Location = new System.Drawing.Point(164, 127);
            this.LblClubesHabilitados.Name = "LblClubesHabilitados";
            this.LblClubesHabilitados.Size = new System.Drawing.Size(16, 17);
            this.LblClubesHabilitados.TabIndex = 4;
            this.LblClubesHabilitados.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Por la positiva de:";
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Location = new System.Drawing.Point(30, 349);
            this.TxtConsulta.Multiline = true;
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(391, 118);
            this.TxtConsulta.TabIndex = 6;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(446, 349);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(105, 118);
            this.BtnEnviar.TabIndex = 7;
            this.BtnEnviar.Text = "Enviar";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // TxtClubesHabilitados
            // 
            this.TxtClubesHabilitados.Enabled = false;
            this.TxtClubesHabilitados.Location = new System.Drawing.Point(33, 148);
            this.TxtClubesHabilitados.Multiline = true;
            this.TxtClubesHabilitados.Name = "TxtClubesHabilitados";
            this.TxtClubesHabilitados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtClubesHabilitados.Size = new System.Drawing.Size(511, 164);
            this.TxtClubesHabilitados.TabIndex = 8;
            // 
            // Sistema_de_votacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 504);
            this.Controls.Add(this.TxtClubesHabilitados);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.TxtConsulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblClubesHabilitados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblNumReu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Sistema_de_votacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de votacion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nReunionToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox TxtNumReu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNumReu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.ToolStripMenuItem habilitarClubesToolStripMenuItem;
        public System.Windows.Forms.Label LblClubesHabilitados;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.TextBox TxtClubesHabilitados;
    }
}