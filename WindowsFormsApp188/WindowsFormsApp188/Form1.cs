using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp188
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Fdatos datos = new Fdatos();
            string nombre;
            int dni = 0;
            int contDatos = 0;

            while (datos.ShowDialog() == DialogResult.OK && contDatos < 3)
            {
                listAlumnos.Items.Add($"{datos.tbNombre.Text}");
                listAlumnos.Items.Add($"{datos.tbDni.Text}");
                contDatos++;
                datos.tbNombre.Clear();
                datos.tbDni.Clear();
            }

            datos.Dispose();

        }

        private void Ver_Click(object sender, EventArgs e)
        {
            Fdatos ventanaVer = new Fdatos();
            ventanaVer.tbNombre.Text = listAlumnos.SelectedItem.ToString();
            ventanaVer.ShowDialog();
            ventanaVer.Dispose();
        }
    }
}
