using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioParcialGuia8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] dni = new int[10];
        double[] consumo = new double[10];
        int cantidad = 0;

        private int Buscar(int dniv)
        {
            int posicion = -1,  c = 0;

            while(posicion == -1 && c < 10)
            {
                if (dni[c] == dniv)
                {
                    posicion = c;                       
                }
                c++;
            }
            return posicion;
        }

        private void Ordenar()
        {
            int aux;
            double auxMonto;

            for (int i = 0; i < cantidad-1; i++)
            {
                for ( int j = i+1; j < cantidad; j++)
                {

                    if (consumo[i] < consumo[j])
                    {
                        aux = dni[i];
                        dni[i] = j;
                        dni[j] = aux;
                        auxMonto= consumo[i];
                        consumo[i] = consumo[j];
                        consumo[j]=auxMonto;
                    }
                }

            }
        }

        private void btAgregarCliente_Click(object sender, EventArgs e)
        {
            CargarDatos ventanaDatos = new CargarDatos();
            int cantCarga = 0;
            if (ventanaDatos.ShowDialog() == DialogResult.OK)
            {
                dni[cantidad] = Convert.ToInt32(ventanaDatos.tbDni.Text);
                consumo[cantidad] = Convert.ToDouble(ventanaDatos.tbConsumo.Text);
                lbClientes.Items.Add(dni[cantidad].ToString());
                cantidad++;
            }
            ventanaDatos.Dispose();
            if (cantCarga == 10)
            {
                btAgregarCliente.Enabled = false;
            }

        }

        private void tbAgregarCompra_Click(object sender, EventArgs e)
        {
         
            CargarDatos ventanaDatos = new CargarDatos();

            if (ventanaDatos.ShowDialog() == DialogResult.OK)
            {
                int dni = Convert.ToInt32(ventanaDatos.tbDni.Text);
                double monto = Convert.ToDouble(ventanaDatos.tbConsumo.Text);


                int posicion = Buscar(dni);
                if (posicion != -1)
                {
                    this.consumo[posicion] += monto;
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado");
                }


            }

            ventanaDatos.Dispose();
        }

        private void lbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbResultados_Click(object sender, EventArgs e)
        {
            InformeFinal ventanaFinal = new InformeFinal();
            //ordenar mayor monto . Aplicar descuentos. 
            Ordenar();
            consumo[0] *=0.8;
            consumo[1] *= 0.8;
            for (int i = 2; i < 5; i++)
            {
                consumo[i] *= 0.85;

            }
            for (int i = 5; i < 10; i++)
            {
                consumo[i] *= 0.95;

            }
            for (int i = 0; i < cantidad; i++)
            {
                string conbinatedItems = "Dni: " + dni[i] + "    " + "Consumo: "+ consumo[i] ;
                ventanaFinal.lbLista.Items.Add(conbinatedItems);
            }
            ventanaFinal.ShowDialog();
            ventanaFinal.Dispose();

        }
    }
}
