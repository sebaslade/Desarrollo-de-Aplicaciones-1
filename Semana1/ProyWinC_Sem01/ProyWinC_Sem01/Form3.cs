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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Creamos un vector de tipo Single de 3 posiciones
            Single[] notas = new Single[3];
            // Una variable para almacenar el promedio calculado
            Single promedio = 0;

            // Guardamos las 3 notas en el vector
            notas[0] = Convert.ToSingle(txtN1.Text.Trim());
            notas[1] = Convert.ToSingle(txtN1.Text.Trim());
            notas[2] = Convert.ToSingle(txtN1.Text.Trim());

            // Ordenamos el vector en forma ascendente, de tal forma que en la posición
            // 0 del vector quede en la forma más baja

            Array.Sort(notas);

            // Preguntamos por el tipo de curso
            if(optTeoria.Checked == true)
            {
                // Si es teoria calculamos en función de las 3 letras
                promedio = (notas[0] + notas[1] + notas[2])/3;
            }
            else
            {
                // Si es de práctica primero demuestra la nota a eliminar, las más baja, es decir
                // la que esta en la posición 0 del vector notas
                MessageBox.Show("Se elimino la nota: " + notas[0], "Message");
                // Y calculamos el promedio tomando las 2 notas más altas ubicadas
                // en la posición 1 y 2 del vector notas
                promedio = (notas[1] + notas[2])/2;
            }

            // Mostramos el promedio
            lblPromedio.Text = promedio.ToString();

            // Si el promedio es aprobatorio se pinta en azul de lo contrario en rojo
            if(promedio >= 13)
            {
                lblPromedio.ForeColor = Color.Green;
            }
            else
            {
                lblPromedio.ForeColor = Color.Red;
            }
        }
    }
}
