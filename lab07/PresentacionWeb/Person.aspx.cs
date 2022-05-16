﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using System.Data;

namespace PresentacionWeb
{
    public partial class Person : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.GetAll();

            gvDatos.DataSource = dt;
            gvDatos.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            string buscar = txtBuscar.Text.Trim();

            dt = np.GetUsuario(Int32.Parse(buscar));


            gvDatos.DataSource = dt;
            gvDatos.DataBind();
        }

        protected void btnListar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.GetAll();

            gvDatos.DataSource = dt;
            gvDatos.DataBind();
        }
    }
}