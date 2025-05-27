using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem09
{
    public partial class TestPlanilla : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Alineamos los textBox de resultado hacia la derecha
            txtSueldo.Attributes["style"] = "TEXT-ALIGN: right";
            txtBonificaciones.Attributes["style"] = "TEXT-ALIGN: right";
            txtDescuentos.Attributes["style"] = "TEXT-ALIGN: right";
            txtPago.Attributes["style"] = "TEXT-ALIGN: right";
            txtMinutosTard.Attributes["style"] = "TEXT-ALIGN: right";
        }

        protected void btnCalcularPago_Click(object sender, EventArgs e)
        {
            try
            {
                // Validamos ....
                if (lstArea.SelectedValue == "0")
                {
                    throw new Exception("Debe seleccionar un area");
                }
                if (cboNivel.SelectedValue == "0")
                {
                    throw new Exception("Debe seleccionar un nivel");
                }
                if (cboEC.SelectedValue == "0")
                {
                    throw new Exception("Debe seleccionar un estado civil");
                }

                if (txtMinutosTard.Text == String.Empty)
                {
                    throw new Exception("Debe ingresar un valor para minutos de tardanza, asi sea 0.");
                }

                if(txtNombre.Text.Trim() == String.Empty) 
                {
                    throw new Exception("Debe ingresar nombre y apellido del colaborador.");
                }

                // CALCULO DEL SUELDO: El sueldo que depende del area
                Single sngSueldo = 0;
                switch (Convert.ToInt16(lstArea.SelectedValue))
                {
                    case 1:  // Informatica 
                        sngSueldo = 3500;
                        break;
                    case 2:// Logistica
                        sngSueldo = 2000;
                        break;
                    case 3: // Marketing 
                        sngSueldo = 2500;
                        break;
                    case 4: // Contabilidad
                        sngSueldo = 1900;
                        break;
                }

                //CALCULO DEL ESTADO CIVIL : Se establece una bonificacion por el estado civil

                Single sngBoniEstadoCivil = 0;
                if (cboEC.SelectedValue == "1") //Soltero
                {
                    sngBoniEstadoCivil = 100;
                }
                else if (cboEC.SelectedValue == "2")// Casado
                {
                    sngBoniEstadoCivil = 200;
                }
                else if (cboEC.SelectedValue == "3")// Viudo
                {
                    sngBoniEstadoCivil = 300;
                }
                else if (cboEC.SelectedValue == "4")// Divorciado
                {
                    sngBoniEstadoCivil = 500;
                }
                else if (cboEC.SelectedValue == "5")// Conviviente
                {
                    sngBoniEstadoCivil = 200;
                }

                //BONIFICACION POR HIJO: Se establece una bonificacion por el Numero de Hijos (200 SOLES POR HIJO)
                Single sngBoniNumHijos;
                sngBoniNumHijos = 200 * Convert.ToInt16(cboHijos.Text);

                //CALCULO DE BONIFICACION POR NIVEL: Se establece la bonificacion por el nivel
                Single sngBoniNivel = 0;
                switch (Convert.ToInt16(cboNivel.SelectedValue))
                {
                    case 1: // Cursando
                        sngBoniNivel = 150;
                        break;
                    case 2: // Egresado
                        sngBoniNivel = 200;
                        break;
                    case 3: // Bachiller
                        sngBoniNivel = 300;
                        break;
                    case 4: // Titulado
                        sngBoniNivel = 400;
                        break;
                }

                //CALCULO DE APORTE A ESSALUD: Si aporta a ESSALUD se establece un descuento del 10% del sueldo.
                Single sngDestESSalud = 0;
                if (chkESSalud.Checked)
                {
                    sngDestESSalud = sngSueldo * 10 / 100;
                }

                //CALCULO DE APORTE A AFP: Si aporta a AFP  se establece un descuento del 18% del sueldo.
                Single sngDestAFP = 0;
                if (chkAFP.Checked)
                {
                    sngDestAFP = sngSueldo * 18 / 100;
                }

                // CALCULO DE LOS MINUTOS DE TARDANZA
                // Se aplica segun la condicion del colaborador. Para empezar todos tienen 5 minutos de tolerancia
                // Pasados los 5 minutos la regla del descuento por tardanza es esta:
                // De a 6 a 10 minutos se aplica un descuento de 30 soles para estable, 20 para contratados y  5 para practicantes
                // Desde el minuto 10 en adelante el descuento sera de 100 soles para el estable, 50 para el contratado y 10 para el practicante

                Single sngMontoTard = 0;
                Int16 intMinutos = Convert.ToInt16(txtMinutosTard.Text);

                if (intMinutos <= 5)// Tolerancia de 5 minutos
                {
                    sngMontoTard = 0;
                }
                else if (intMinutos <= 10)// Pasados los 5 hasta los 10 minutos...
                {
                    if (optEsta.Checked)
                    {
                        sngMontoTard = 30;
                    }
                    else if (optCont.Checked)
                    {
                        sngMontoTard = 20;
                    }
                    else
                    {
                        sngMontoTard = 5;
                    }
                }
                else // Pasados los 10 minutos...
                {
                    if (optEsta.Checked)
                    {
                        sngMontoTard = 100;
                    }
                    else if (optCont.Checked)
                    {
                        sngMontoTard = 50;
                    }
                    else
                    {
                        sngMontoTard = 10;
                    }
                }

                // CALCULAMOS EL TOTAL DE BONIFICACIONES
                Single sngTotBonif = sngBoniNumHijos + sngBoniEstadoCivil + sngBoniNivel;
                // CALCULAMOS EL TOTAL DE DESCUENTOS
                Single sngTotDesc = sngDestAFP + sngDestESSalud + sngMontoTard;
                // CALCULO DEL NETO A PAGAR = SUELDO+ TOTOAL BONIFICACIONES - TOTAL DE DESCUENTOS
                Single sngNetoPagar = sngSueldo + sngTotBonif - sngTotDesc;


                // Mostramos resultados con formato de miles y 2 decimales ("#,##0.00")
                txtSueldo.Text = sngSueldo.ToString("#,##0.00");
                txtBonificaciones.Text = sngTotBonif.ToString("#,##0.00");
                txtDescuentos.Text = sngTotDesc.ToString("#,##0.00");
                txtPago.Text = sngNetoPagar.ToString("#,##0.00");

                // Mensaje de conformidad...
                lblMensaje.ForeColor = System.Drawing.Color.Blue;
                lblMensaje.Text = "Neto a pagar correctamente calculado";
            }

            catch (Exception ex)
            {
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }
    }
}