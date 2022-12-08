
namespace appProyectoEstructuradeDatos2022
{
    partial class FrmListaCircular
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.btnVaciarLista = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminarNodo = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(335, 221);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(77, 32);
            this.BtnCerrar.TabIndex = 9;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnVaciarLista
            // 
            this.btnVaciarLista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciarLista.Location = new System.Drawing.Point(214, 178);
            this.btnVaciarLista.Name = "btnVaciarLista";
            this.btnVaciarLista.Size = new System.Drawing.Size(89, 53);
            this.btnVaciarLista.TabIndex = 17;
            this.btnVaciarLista.Text = "Vaciar lista";
            this.btnVaciarLista.UseVisualStyleBackColor = true;
            // 
            // btnContar
            // 
            this.btnContar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContar.Location = new System.Drawing.Point(214, 106);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(89, 30);
            this.btnContar.TabIndex = 16;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminar.Location = new System.Drawing.Point(94, 73);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(114, 26);
            this.txtEliminar.TabIndex = 15;
            // 
            // btnEliminarNodo
            // 
            this.btnEliminarNodo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarNodo.Location = new System.Drawing.Point(214, 73);
            this.btnEliminarNodo.Name = "btnEliminarNodo";
            this.btnEliminarNodo.Size = new System.Drawing.Size(89, 30);
            this.btnEliminarNodo.TabIndex = 14;
            this.btnEliminarNodo.Text = "Eliminar dato";
            this.btnEliminarNodo.UseVisualStyleBackColor = true;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(314, 36);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(14, 20);
            this.lblLista.TabIndex = 13;
            this.lblLista.Text = "-";
            // 
            // txtNodo
            // 
            this.txtNodo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodo.Location = new System.Drawing.Point(94, 36);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(114, 26);
            this.txtNodo.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(214, 34);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(89, 30);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // FrmListaCircular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 264);
            this.Controls.Add(this.btnVaciarLista);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnEliminarNodo);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.BtnCerrar);
            this.Name = "FrmListaCircular";
            this.Text = "FrmListaCircular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button btnVaciarLista;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button btnEliminarNodo;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button btnGuardar;
    }
}