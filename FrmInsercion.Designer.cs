
namespace appProyectoEstructuradeDatos2022
{
    partial class FrmInsercion
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
            this.tbIntercambios = new System.Windows.Forms.TextBox();
            this.tbArregloC = new System.Windows.Forms.TextBox();
            this.tbArregloO = new System.Windows.Forms.TextBox();
            this.tbComparaciones = new System.Windows.Forms.TextBox();
            this.LbIntercambios = new System.Windows.Forms.Label();
            this.LbComparaciones = new System.Windows.Forms.Label();
            this.LbArregloO = new System.Windows.Forms.Label();
            this.LbArregloC = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.BtnCerra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbIntercambios
            // 
            this.tbIntercambios.Location = new System.Drawing.Point(104, 121);
            this.tbIntercambios.Name = "tbIntercambios";
            this.tbIntercambios.Size = new System.Drawing.Size(62, 20);
            this.tbIntercambios.TabIndex = 51;
            // 
            // tbArregloC
            // 
            this.tbArregloC.Location = new System.Drawing.Point(104, 43);
            this.tbArregloC.Name = "tbArregloC";
            this.tbArregloC.Size = new System.Drawing.Size(383, 20);
            this.tbArregloC.TabIndex = 50;
            // 
            // tbArregloO
            // 
            this.tbArregloO.Location = new System.Drawing.Point(104, 69);
            this.tbArregloO.Name = "tbArregloO";
            this.tbArregloO.Size = new System.Drawing.Size(383, 20);
            this.tbArregloO.TabIndex = 49;
            // 
            // tbComparaciones
            // 
            this.tbComparaciones.Location = new System.Drawing.Point(104, 95);
            this.tbComparaciones.Name = "tbComparaciones";
            this.tbComparaciones.Size = new System.Drawing.Size(62, 20);
            this.tbComparaciones.TabIndex = 48;
            // 
            // LbIntercambios
            // 
            this.LbIntercambios.AutoSize = true;
            this.LbIntercambios.Location = new System.Drawing.Point(11, 130);
            this.LbIntercambios.Name = "LbIntercambios";
            this.LbIntercambios.Size = new System.Drawing.Size(67, 13);
            this.LbIntercambios.TabIndex = 47;
            this.LbIntercambios.Text = "Intercambios";
            // 
            // LbComparaciones
            // 
            this.LbComparaciones.AutoSize = true;
            this.LbComparaciones.Location = new System.Drawing.Point(11, 104);
            this.LbComparaciones.Name = "LbComparaciones";
            this.LbComparaciones.Size = new System.Drawing.Size(80, 13);
            this.LbComparaciones.TabIndex = 46;
            this.LbComparaciones.Text = "Comparaciones";
            // 
            // LbArregloO
            // 
            this.LbArregloO.AutoSize = true;
            this.LbArregloO.Location = new System.Drawing.Point(11, 76);
            this.LbArregloO.Name = "LbArregloO";
            this.LbArregloO.Size = new System.Drawing.Size(88, 13);
            this.LbArregloO.TabIndex = 45;
            this.LbArregloO.Text = "Arreglo ordenado";
            // 
            // LbArregloC
            // 
            this.LbArregloC.AutoSize = true;
            this.LbArregloC.Location = new System.Drawing.Point(11, 50);
            this.LbArregloC.Name = "LbArregloC";
            this.LbArregloC.Size = new System.Drawing.Size(76, 13);
            this.LbArregloC.TabIndex = 41;
            this.LbArregloC.Text = "Arreglo creado";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(63, 12);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(210, 20);
            this.txtTamaño.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tamaño";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(288, 9);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 42;
            this.btnCrear.Text = "Crear arreglo";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // BtnCerra
            // 
            this.BtnCerra.Location = new System.Drawing.Point(405, 147);
            this.BtnCerra.Name = "BtnCerra";
            this.BtnCerra.Size = new System.Drawing.Size(75, 23);
            this.BtnCerra.TabIndex = 52;
            this.BtnCerra.Text = "Cerrar";
            this.BtnCerra.UseVisualStyleBackColor = true;
            this.BtnCerra.Click += new System.EventHandler(this.BtnCerra_Click);
            // 
            // FrmInsercion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 182);
            this.Controls.Add(this.BtnCerra);
            this.Controls.Add(this.tbIntercambios);
            this.Controls.Add(this.tbArregloC);
            this.Controls.Add(this.tbArregloO);
            this.Controls.Add(this.tbComparaciones);
            this.Controls.Add(this.LbIntercambios);
            this.Controls.Add(this.LbComparaciones);
            this.Controls.Add(this.LbArregloO);
            this.Controls.Add(this.LbArregloC);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrear);
            this.Name = "FrmInsercion";
            this.Text = "FrmInsercion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIntercambios;
        private System.Windows.Forms.TextBox tbArregloC;
        private System.Windows.Forms.TextBox tbArregloO;
        private System.Windows.Forms.TextBox tbComparaciones;
        private System.Windows.Forms.Label LbIntercambios;
        private System.Windows.Forms.Label LbComparaciones;
        private System.Windows.Forms.Label LbArregloO;
        private System.Windows.Forms.Label LbArregloC;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button BtnCerra;
    }
}