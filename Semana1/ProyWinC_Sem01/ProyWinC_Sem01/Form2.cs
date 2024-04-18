using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyWinC_Sem01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos que no se agreguen elementos repetidos ni en blanco...
            if (txtPais.Text.Trim() !=String.Empty && lstPaises.Items.Contains(txtPais.Text.Trim())==false) 
            {
                //Agregamos el texto ingresado en txtPais a la lista...
                lstPaises.Items.Add(txtPais.Text.Trim());
            }
            else
            {
                MessageBox.Show("Error, elemento en blanco o ya existe en la coloboración");
            }
            // Limpiamos el txtPais y le asignamos el enfoque..
            txtPais.Text = String.Empty;
            txtPais.Focus();
        }
    }
}
