using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem11.DemoAJAXToolKit
{
    public partial class DemoCalendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecNac = Convert.ToDateTime(TextBox1.Text);
                DateTime fecHoy = DateTime.Now.Date;

                // Hallamos el intervalo transcurrido...
                TimeSpan intervalo = fecHoy - fecNac;
                Int32 intDias = intervalo.Days;
                Single edad = intDias / 365;

                // Mostramos la edad
                lblEdad.Text = edad.ToString();
            }
            catch(Exception ex)
            {
                lblEdad.Text = "Error:" + ex.Message;
            }
        }
    }
}