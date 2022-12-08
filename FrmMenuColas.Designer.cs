
namespace appProyectoEstructuradeDatos2022
{
    partial class FrmMenuColas
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
            this.BtnBicola = new System.Windows.Forms.Button();
            this.BtnColaCircular = new System.Windows.Forms.Button();
            this.BtnColaDinamica = new System.Windows.Forms.Button();
            this.BtnColadeprioridad = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.LblMenuColas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBicola
            // 
            this.BtnBicola.Location = new System.Drawing.Point(27, 139);
            this.BtnBicola.Name = "BtnBicola";
            this.BtnBicola.Size = new System.Drawing.Size(106, 61);
            this.BtnBicola.TabIndex = 0;
            this.BtnBicola.Text = "Bicola";
            this.BtnBicola.UseVisualStyleBackColor = true;
            this.BtnBicola.Click += new System.EventHandler(this.BtnBicola_Click);
            // 
            // BtnColaCircular
            // 
            this.BtnColaCircular.Location = new System.Drawing.Point(166, 139);
            this.BtnColaCircular.Name = "BtnColaCircular";
            this.BtnColaCircular.Size = new System.Drawing.Size(106, 61);
            this.BtnColaCircular.TabIndex = 1;
            this.BtnColaCircular.Text = "Cola Circular";
            this.BtnColaCircular.UseVisualStyleBackColor = true;
            this.BtnColaCircular.Click += new System.EventHandler(this.BtnColaCircular_Click);
            // 
            // BtnColaDinamica
            // 
            this.BtnColaDinamica.Location = new System.Drawing.Point(296, 139);
            this.BtnColaDinamica.Name = "BtnColaDinamica";
            this.BtnColaDinamica.Size = new System.Drawing.Size(106, 61);
            this.BtnColaDinamica.TabIndex = 2;
            this.BtnColaDinamica.Text = "Cola Dinamica";
            this.BtnColaDinamica.UseVisualStyleBackColor = true;
            this.BtnColaDinamica.Click += new System.EventHandler(this.BtnColaDinamica_Click);
            // 
            // BtnColadeprioridad
            // 
            this.BtnColadeprioridad.Location = new System.Drawing.Point(421, 139);
            this.BtnColadeprioridad.Name = "BtnColadeprioridad";
            this.BtnColadeprioridad.Size = new System.Drawing.Size(106, 61);
            this.BtnColadeprioridad.TabIndex = 3;
            this.BtnColadeprioridad.Text = "Cola de Prioridad";
            this.BtnColadeprioridad.UseVisualStyleBackColor = true;
            this.BtnColadeprioridad.Click += new System.EventHandler(this.BtnColadeprioridad_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(508, 251);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 4;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LblMenuColas
            // 
            this.LblMenuColas.AutoSize = true;
            this.LblMenuColas.Location = new System.Drawing.Point(251, 36);
            this.LblMenuColas.Name = "LblMenuColas";
            this.LblMenuColas.Size = new System.Drawing.Size(63, 13);
            this.LblMenuColas.TabIndex = 5;
            this.LblMenuColas.Text = "Menu Colas";
            // 
            // FrmMenuColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 277);
            this.Controls.Add(this.LblMenuColas);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnColadeprioridad);
            this.Controls.Add(this.BtnColaDinamica);
            this.Controls.Add(this.BtnColaCircular);
            this.Controls.Add(this.BtnBicola);
            this.Name = "FrmMenuColas";
            this.Text = "FrmMenuColas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBicola;
        private System.Windows.Forms.Button BtnColaCircular;
        private System.Windows.Forms.Button BtnColaDinamica;
        private System.Windows.Forms.Button BtnColadeprioridad;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label LblMenuColas;
    }
}