namespace ProyWinC_Sem01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al curso: " + txtNombre.Text, "Bienvenida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Evaluamos la tecla pulsada
            if (e.KeyChar == 13) // Si se pulso ENTER
            {
                //Invocamos al evento click del boton btnSaludar
                btnSaludar.PerformClick();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Cerramos el formulario
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta = MessageBox.Show("¿Seguro de cerrar el formulario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Evaluamos la respuesta del usuario
            if(vrpta == DialogResult.No) 
            {
                // Cancelamos el cierre del formulario...
                e.Cancel = true;
            }
        }
    }
}
