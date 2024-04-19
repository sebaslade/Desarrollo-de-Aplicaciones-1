using System.Data;

namespace ProyWinC_Sem02
{
    public partial class frmCombos : Form
    {
        public frmCombos()
        {
            InitializeComponent();
        }

        private void frmCombos_Load(object sender, EventArgs e)
        {
            // Vector para cargos
            String[] MisCargos =
                {
                 "Gerente",
                 "Supervisor",
                 "Administrativo",
                 "Asistente",
                 "Auxiliar",
                 "Obrero",
                "Practicante"
               };
            // Enlazamos el vector al cboCargos..
            cboCargos.DataSource = MisCargos;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Codifique....
               
        }
    }
}
