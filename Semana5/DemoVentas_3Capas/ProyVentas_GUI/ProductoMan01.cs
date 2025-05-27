﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Para los objetos DataTable, DataRow y DataView
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar...
using ProyVentas_BL;

namespace ProyVentas_GUI
{
    public partial class ProductoMan01 : Form
    {
        // Instancias
        ProductoBL objProductoBL = new ProductoBL();
        DataView dtv;

        public ProductoMan01()
        {
            InitializeComponent();
        }

        private void ProductoMan01_Load(object sender, EventArgs e)
        {
            // Para que el DataGridView solo muestre las columnas personalizadas
            dtgDatos.AutoGenerateColumns = false;

            //  Invocamos al metodo CargarDatos pasandole una cadena vacia ,
            //  lo cual hara que se muestren todos los productos por defecto al 
            //momento de cargar el formulario

            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {
            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objProductoBL.ListarProducto());
            dtv.RowFilter = "des_pro like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                ProductoMan02 objMan02 = new ProductoMan02();
                objMan02.ShowDialog();

                dtv = new DataView(objProductoBL.ListarProducto());
                CargarDatos(txtFiltro.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                ProductoMan03 objMan03 = new ProductoMan03();
                objMan03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objMan03.ShowDialog();

                dtv = new DataView(objProductoBL.ListarProducto());
                CargarDatos(txtFiltro.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                String strCodigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                // solicitar confirmacion del usuario
                DialogResult vrpta = MessageBox.Show("¿Seguro de eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Evaluamos la respuesta
                if (vrpta == DialogResult.Yes)
                {
                    if (objProductoBL.EliminarProducto(strCodigo) == true)
                    {
                        // Refresco en la grilla
                        CargarDatos(String.Empty);
                    }
                    else
                    {
                        throw new Exception("No se pudo eliminar el registro. Contacte con IT");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
