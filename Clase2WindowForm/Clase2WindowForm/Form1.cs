using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase2WindowForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Form2 datos = new Form2();


            if(datos.ShowDialog() == DialogResult.OK)
            {
                ALUMNOS.Items.Add($"{datos.textBox1_TextChanged.}");
               
            }
           
            
        
        }

        private void Ver_Click(object sender, EventArgs e)
        {

        }

        private void ALUMNOS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
