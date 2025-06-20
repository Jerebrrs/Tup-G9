namespace EjercicioParcialGuia8
{
    partial class CargarDatos
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
            this.tbAceptar = new System.Windows.Forms.Button();
            this.tbCancelar = new System.Windows.Forms.Button();
            this.lbCargarDni = new System.Windows.Forms.Label();
            this.lbcargarConsumo = new System.Windows.Forms.Label();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.tbConsumo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbAceptar
            // 
            this.tbAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.tbAceptar.Location = new System.Drawing.Point(81, 187);
            this.tbAceptar.Name = "tbAceptar";
            this.tbAceptar.Size = new System.Drawing.Size(75, 23);
            this.tbAceptar.TabIndex = 0;
            this.tbAceptar.Text = "Aceptar";
            this.tbAceptar.UseVisualStyleBackColor = true;
            this.tbAceptar.Click += new System.EventHandler(this.tbAceptar_Click);
            // 
            // tbCancelar
            // 
            this.tbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tbCancelar.Location = new System.Drawing.Point(230, 187);
            this.tbCancelar.Name = "tbCancelar";
            this.tbCancelar.Size = new System.Drawing.Size(75, 23);
            this.tbCancelar.TabIndex = 1;
            this.tbCancelar.Text = "Cancelar";
            this.tbCancelar.UseVisualStyleBackColor = true;
            // 
            // lbCargarDni
            // 
            this.lbCargarDni.AutoSize = true;
            this.lbCargarDni.Location = new System.Drawing.Point(78, 74);
            this.lbCargarDni.Name = "lbCargarDni";
            this.lbCargarDni.Size = new System.Drawing.Size(57, 13);
            this.lbCargarDni.TabIndex = 2;
            this.lbCargarDni.Text = "Cargar Dni";
            // 
            // lbcargarConsumo
            // 
            this.lbcargarConsumo.AutoSize = true;
            this.lbcargarConsumo.Location = new System.Drawing.Point(78, 128);
            this.lbcargarConsumo.Name = "lbcargarConsumo";
            this.lbcargarConsumo.Size = new System.Drawing.Size(85, 13);
            this.lbcargarConsumo.TabIndex = 3;
            this.lbcargarConsumo.Text = "Cargar Consumo";
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(204, 71);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(101, 20);
            this.tbDni.TabIndex = 4;
            this.tbDni.TextChanged += new System.EventHandler(this.tbDni_TextChanged);
            // 
            // tbConsumo
            // 
            this.tbConsumo.Location = new System.Drawing.Point(204, 121);
            this.tbConsumo.Name = "tbConsumo";
            this.tbConsumo.Size = new System.Drawing.Size(101, 20);
            this.tbConsumo.TabIndex = 5;
            // 
            // CargarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 260);
            this.Controls.Add(this.tbConsumo);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.lbcargarConsumo);
            this.Controls.Add(this.lbCargarDni);
            this.Controls.Add(this.tbCancelar);
            this.Controls.Add(this.tbAceptar);
            this.Name = "CargarDatos";
            this.Text = "CargarDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tbAceptar;
        private System.Windows.Forms.Button tbCancelar;
        private System.Windows.Forms.Label lbCargarDni;
        private System.Windows.Forms.Label lbcargarConsumo;
        public System.Windows.Forms.TextBox tbDni;
        public System.Windows.Forms.TextBox tbConsumo;
    }
}