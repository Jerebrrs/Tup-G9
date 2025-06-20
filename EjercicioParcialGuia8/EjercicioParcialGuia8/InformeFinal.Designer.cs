namespace EjercicioParcialGuia8
{
    partial class InformeFinal
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
            this.lbLista = new System.Windows.Forms.ListBox();
            this.bSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(33, 23);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(332, 147);
            this.lbLista.TabIndex = 0;
            this.lbLista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bSalir
            // 
            this.bSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bSalir.Location = new System.Drawing.Point(149, 190);
            this.bSalir.Name = "bSalir";
            this.bSalir.Size = new System.Drawing.Size(75, 23);
            this.bSalir.TabIndex = 1;
            this.bSalir.Text = "Salir";
            this.bSalir.UseVisualStyleBackColor = true;
            // 
            // InformeFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 247);
            this.Controls.Add(this.bSalir);
            this.Controls.Add(this.lbLista);
            this.Name = "InformeFinal";
            this.Text = "InformeFinal";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bSalir;
        public System.Windows.Forms.ListBox lbLista;
    }
}