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
            try
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

                // Leemos el archivo XML
                DataSet dts = new DataSet(); // Dataset es un espacio en memoria donde puedo guardar tablas
                dts.ReadXml("MisDistritos.xml");

                // Enlazamos el cboDistritos a la tabla 0 del DataSet
                cboDistrito.DataSource = dts.Tables[0];
                cboDistrito.ValueMember = "cod_dis";//Campo de Valor
                cboDistrito.DisplayMember = "nom_dis"; //Campo de despliegue
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit(); //Salimos de la aplicación
            }
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique...
                //Validamos las reglas de negocio:
                if (mskDni.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 dígitos");
                }
                if(txtNomApe.Text.Trim().Length == 0)
                {
                    throw new Exception("Los nombres y apellidos son obligatorios");
                }
                if(lstEC.SelectedIndex <= 0)
                {
                    throw new Exception("Debe seleccionar estado civil");
                }
                //
                TimeSpan intervalo = DateTime.Now.Date - dtpFecNac.Value.Date;
                if ((intervalo.Days / 365) < 18)
                {
                    throw new Exception("Usted debe ser mayor de edad");
                }

                // Una vez las validaciones esten OK se ejecutará lo siguiente:
                // Desarrolle la rutina para mostrar el sueldo del trabajador
                // segun su cargo:
                // Gerente: 5000 - Supervisor: 3500 - Administrativo: 2000 - Asistente : 1600
                // Auxiliar: 1200 - Obrero: 900 - Practicante : 700
                // Mostramos el sueldo dependiente del cargo (por el selectedindex)

                Single sngSueldo = 0;
                switch (cboCargos.SelectedIndex)
                {
                    case 0://Gerente
                        sngSueldo = 5000;
                        break;
                    case 1://Supervisor
                        sngSueldo = 3500;
                        break;
                    case 2://Administrativo
                        sngSueldo = 2000;
                        break;
                    case 3://Asistente
                        sngSueldo = 1600;
                        break;
                    case 4://Auxiliar
                        sngSueldo = 1200;
                        break;
                    case 5://Obrero
                        sngSueldo = 900;
                        break;
                    case 6://Practicante
                        sngSueldo = 700;
                        break;
                }
                //lblSueldo.Text = sngSueldo.ToString("C2"); //-> Aparecera en sueldo monetario con 2 decimales .00
                lblSueldo.Text = sngSueldo.ToString("###0.00 soles");

                // Desarrolle la rutina para mostrar la bonificacion del trabajador segun su EC:
                // Soltero: 100 ,Casado o Conviviente: 200 
                // En otro caso: 300               
                // Mostramos bonificacion (por SelectedItem)

                Single sngBonificacion = 0;
                if (lstEC.SelectedItem.ToString() == "Soltero")
                {
                    sngBonificacion = 100;
                }
                else if (lstEC.SelectedItem.ToString() == "Casado" || lstEC.SelectedItem.ToString() == "Conviviente")
                {
                    sngBonificacion = 200;
                }
                else { sngBonificacion = 300; }
                lblBonificacion.Text = sngBonificacion.ToString("##0.00 soles");

                // Mostramos el código del distrito seleccionado desde cboDistrito...
                lblCodDistrito.Text = cboDistrito.SelectedValue.ToString();

                // Calculamos la edad
                lblEdad.Text = (intervalo.Days / 365).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("No olvidarse que la prox es la EP1");
            }
        }
    }
}
