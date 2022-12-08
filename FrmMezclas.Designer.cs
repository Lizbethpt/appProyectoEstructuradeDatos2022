
namespace appProyectoEstructuradeDatos2022
{
    partial class FrmMezclas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRDescendenteDirecta = new System.Windows.Forms.Button();
            this.btnRAscendenteDirecta = new System.Windows.Forms.Button();
            this.lblEstadisticaNombre = new System.Windows.Forms.Label();
            this.lvwOrdenado = new System.Windows.Forms.ListView();
            this.lblStadistica = new System.Windows.Forms.Label();
            this.lvwMostar = new System.Windows.Forms.ListView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRecAsc = new System.Windows.Forms.Button();
            this.txtElementos = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mezcla Directa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mezcla Natural:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(535, 96);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 23);
            this.btnLimpiar.TabIndex = 27;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnRDescendenteDirecta
            // 
            this.btnRDescendenteDirecta.Location = new System.Drawing.Point(198, 188);
            this.btnRDescendenteDirecta.Name = "btnRDescendenteDirecta";
            this.btnRDescendenteDirecta.Size = new System.Drawing.Size(161, 23);
            this.btnRDescendenteDirecta.TabIndex = 26;
            this.btnRDescendenteDirecta.Text = "Recorrido Descendente";
            this.btnRDescendenteDirecta.UseVisualStyleBackColor = true;
            // 
            // btnRAscendenteDirecta
            // 
            this.btnRAscendenteDirecta.Location = new System.Drawing.Point(198, 159);
            this.btnRAscendenteDirecta.Name = "btnRAscendenteDirecta";
            this.btnRAscendenteDirecta.Size = new System.Drawing.Size(161, 23);
            this.btnRAscendenteDirecta.TabIndex = 25;
            this.btnRAscendenteDirecta.Text = "Recorrido Ascendente";
            this.btnRAscendenteDirecta.UseVisualStyleBackColor = true;
            // 
            // lblEstadisticaNombre
            // 
            this.lblEstadisticaNombre.AutoSize = true;
            this.lblEstadisticaNombre.Location = new System.Drawing.Point(431, 182);
            this.lblEstadisticaNombre.Name = "lblEstadisticaNombre";
            this.lblEstadisticaNombre.Size = new System.Drawing.Size(13, 13);
            this.lblEstadisticaNombre.TabIndex = 24;
            this.lblEstadisticaNombre.Text = "--";
            // 
            // lvwOrdenado
            // 
            this.lvwOrdenado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwOrdenado.HideSelection = false;
            this.lvwOrdenado.Location = new System.Drawing.Point(0, 38);
            this.lvwOrdenado.Name = "lvwOrdenado";
            this.lvwOrdenado.Size = new System.Drawing.Size(732, 35);
            this.lvwOrdenado.TabIndex = 23;
            this.lvwOrdenado.UseCompatibleStateImageBehavior = false;
            // 
            // lblStadistica
            // 
            this.lblStadistica.AutoSize = true;
            this.lblStadistica.Font = new System.Drawing.Font("Playbill", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStadistica.Location = new System.Drawing.Point(427, 142);
            this.lblStadistica.Name = "lblStadistica";
            this.lblStadistica.Size = new System.Drawing.Size(32, 40);
            this.lblStadistica.TabIndex = 22;
            this.lblStadistica.Text = "---";
            // 
            // lvwMostar
            // 
            this.lvwMostar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwMostar.HideSelection = false;
            this.lvwMostar.Location = new System.Drawing.Point(0, 0);
            this.lvwMostar.Name = "lvwMostar";
            this.lvwMostar.Size = new System.Drawing.Size(732, 38);
            this.lvwMostar.TabIndex = 21;
            this.lvwMostar.UseCompatibleStateImageBehavior = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(444, 96);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(85, 23);
            this.btnMostrar.TabIndex = 20;
            this.btnMostrar.Text = "Mostrar Vector";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Numero de elementos del vector:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Recorrido Descendente";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnRecAsc
            // 
            this.btnRecAsc.Location = new System.Drawing.Point(15, 159);
            this.btnRecAsc.Name = "btnRecAsc";
            this.btnRecAsc.Size = new System.Drawing.Size(161, 23);
            this.btnRecAsc.TabIndex = 17;
            this.btnRecAsc.Text = "Recorrido Ascendente";
            this.btnRecAsc.UseVisualStyleBackColor = true;
            // 
            // txtElementos
            // 
            this.txtElementos.Location = new System.Drawing.Point(245, 99);
            this.txtElementos.Name = "txtElementos";
            this.txtElementos.Size = new System.Drawing.Size(77, 20);
            this.txtElementos.TabIndex = 16;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(353, 96);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(85, 23);
            this.btnCrear.TabIndex = 15;
            this.btnCrear.Text = "Crear Vector";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(645, 237);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 30;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmMezclas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 272);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRDescendenteDirecta);
            this.Controls.Add(this.btnRAscendenteDirecta);
            this.Controls.Add(this.lblEstadisticaNombre);
            this.Controls.Add(this.lvwOrdenado);
            this.Controls.Add(this.lblStadistica);
            this.Controls.Add(this.lvwMostar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRecAsc);
            this.Controls.Add(this.txtElementos);
            this.Controls.Add(this.btnCrear);
            this.Name = "FrmMezclas";
            this.Text = "FrmMezclas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRDescendenteDirecta;
        private System.Windows.Forms.Button btnRAscendenteDirecta;
        private System.Windows.Forms.Label lblEstadisticaNombre;
        private System.Windows.Forms.ListView lvwOrdenado;
        private System.Windows.Forms.Label lblStadistica;
        private System.Windows.Forms.ListView lvwMostar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRecAsc;
        private System.Windows.Forms.TextBox txtElementos;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button BtnCerrar;
    }
}