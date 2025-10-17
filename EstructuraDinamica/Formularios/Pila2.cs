using EstructuraDinamica.Formularios.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstructuraDinamica.Formularios
{
    public partial class Pila2 : Form
    {
        Stack<Expediente> pila = new Stack<Expediente>();
        public Pila2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Expediente est = new Expediente();
            est.Nombres = tbNombres.Text;
            est.Apellidos = tbApellidos.Text;
            est.Promedio = int.Parse(tbPromedio.Text);

            pila.Push(est);




        }


        private void LlenarList()
        {
            lbPromedios.Items.Clear();
            foreach(Expediente est in pila)
            {
                lbPromedios.Items.Add(est.Promedio);
            }
        }



    }
}
