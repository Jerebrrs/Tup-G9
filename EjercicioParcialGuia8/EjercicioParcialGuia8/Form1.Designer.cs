namespace EjercicioParcialGuia8
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAgregarCliente = new System.Windows.Forms.Button();
            this.bCargarCompra = new System.Windows.Forms.Button();
            this.tbResultados = new System.Windows.Forms.Button();
            this.tbSalir = new System.Windows.Forms.Button();
            this.lbClientes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btAgregarCliente
            // 
            this.btAgregarCliente.Location = new System.Drawing.Point(56, 34);
            this.btAgregarCliente.Name = "btAgregarCliente";
            this.btAgregarCliente.Size = new System.Drawing.Size(103, 23);
            this.btAgregarCliente.TabIndex = 0;
            this.btAgregarCliente.Text = "Cargar Ciente";
            this.btAgregarCliente.UseVisualStyleBackColor = true;
            this.btAgregarCliente.Click += new System.EventHandler(this.btAgregarCliente_Click);
            // 
            // bCargarCompra
            // 
            this.bCargarCompra.Location = new System.Drawing.Point(56, 83);
            this.bCargarCompra.Name = "bCargarCompra";
            this.bCargarCompra.Size = new System.Drawing.Size(103, 23);
            this.bCargarCompra.TabIndex = 1;
            this.bCargarCompra.Text = "Cargar Compra";
            this.bCargarCompra.UseVisualStyleBackColor = true;
            this.bCargarCompra.Click += new System.EventHandler(this.tbAgregarCompra_Click);
            // 
            // tbResultados
            // 
            this.tbResultados.Location = new System.Drawing.Point(56, 129);
            this.tbResultados.Name = "tbResultados";
            this.tbResultados.Size = new System.Drawing.Size(103, 23);
            this.tbResultados.TabIndex = 2;
            this.tbResultados.Text = "Ver Resultados";
            this.tbResultados.UseVisualStyleBackColor = true;
            this.tbResultados.Click += new System.EventHandler(this.tbResultados_Click);
            // 
            // tbSalir
            // 
            this.tbSalir.Location = new System.Drawing.Point(56, 177);
            this.tbSalir.Name = "tbSalir";
            this.tbSalir.Size = new System.Drawing.Size(103, 23);
            this.tbSalir.TabIndex = 3;
            this.tbSalir.Text = "Salir";
            this.tbSalir.UseVisualStyleBackColor = true;
            // 
            // lbClientes
            // 
            this.lbClientes.FormattingEnabled = true;
            this.lbClientes.Location = new System.Drawing.Point(216, 34);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(228, 173);
            this.lbClientes.TabIndex = 4;
            this.lbClientes.SelectedIndexChanged += new System.EventHandler(this.lbClientes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 258);
            this.Controls.Add(this.lbClientes);
            this.Controls.Add(this.tbSalir);
            this.Controls.Add(this.tbResultados);
            this.Controls.Add(this.bCargarCompra);
            this.Controls.Add(this.btAgregarCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAgregarCliente;
        private System.Windows.Forms.Button bCargarCompra;
        private System.Windows.Forms.Button tbResultados;
        private System.Windows.Forms.Button tbSalir;
        private System.Windows.Forms.ListBox lbClientes;
    }
}

