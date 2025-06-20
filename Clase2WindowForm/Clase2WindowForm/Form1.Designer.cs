namespace Clase2WindowForm
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
            this.ALUMNOS = new System.Windows.Forms.ListBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.Ver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ALUMNOS
            // 
            this.ALUMNOS.FormattingEnabled = true;
            this.ALUMNOS.Location = new System.Drawing.Point(47, 162);
            this.ALUMNOS.Name = "ALUMNOS";
            this.ALUMNOS.Size = new System.Drawing.Size(120, 95);
            this.ALUMNOS.TabIndex = 0;
            this.ALUMNOS.SelectedIndexChanged += new System.EventHandler(this.ALUMNOS_SelectedIndexChanged);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(47, 28);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 1;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Ver
            // 
            this.Ver.Location = new System.Drawing.Point(47, 83);
            this.Ver.Name = "Ver";
            this.Ver.Size = new System.Drawing.Size(75, 23);
            this.Ver.TabIndex = 2;
            this.Ver.Text = "Ver";
            this.Ver.UseVisualStyleBackColor = true;
            this.Ver.Click += new System.EventHandler(this.Ver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 339);
            this.Controls.Add(this.Ver);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.ALUMNOS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ALUMNOS;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Ver;
    }
}

