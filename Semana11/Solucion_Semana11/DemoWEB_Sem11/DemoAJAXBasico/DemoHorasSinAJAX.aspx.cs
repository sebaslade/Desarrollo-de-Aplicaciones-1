﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWEB_Sem11.DemoAJAXBasico
{
    public partial class DemoHorasSinAjax : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = DateTime.Now.ToLongTimeString();
            TextBox2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}