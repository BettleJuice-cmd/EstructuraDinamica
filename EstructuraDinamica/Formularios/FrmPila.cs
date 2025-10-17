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
    public partial class FrmPila : Form
    {
        Stack<int> pila = new Stack<int>(); //Creacion de la pila 
        public FrmPila()
        {
            InitializeComponent();
        }

        private void FrmPila_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int elemento = int.Parse(tbNumero.Text);
            pila.Push(elemento); //Agrega un elemento a la pila

            lblPila.Text = MostrarElementos();

            tbNumero.Clear();
            tbNumero.Focus();

        }

        private string MostrarElementos()
        {
            string msn = "";
            foreach (int i in pila)
            {
                msn += " " + i.ToString() + " |";
            }

            return msn;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
           
            pila.Pop();

            lblPila.Text = MostrarElementos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show($"{pila.Peek()}", "Ultimo elemento ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Pila vacia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}
