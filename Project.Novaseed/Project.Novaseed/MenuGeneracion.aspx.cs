﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project.BusinessRules;

namespace Project.Novaseed
{
    public partial class MenuGeneracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogCruzamiento cc = new CatalogCruzamiento();
            List<Project.BusinessRules.Cruzamiento> cruzamiento = cc.GetAñoCruzamiento_fn();

            if (!Page.IsPostBack)
            {
                this.ddlGeneracionAño.DataValueField = "ano_cruzamiento";
                this.ddlGeneracionAño.DataTextField = "ano_cruzamiento";
                this.ddlGeneracionAño.DataSource = cruzamiento;
                this.DataBind();
            }
        }

        private void AñoGeneracion()
        {
            int value = this.ddlGeneracionAño.SelectedIndex;
            if (value > 1)
                Response.Redirect("");
            else
                //ACA VA LA ALERTA
                value = 0;
        }

        protected void btnGeneracionCruzamiento_Click(object sender, EventArgs e)
        {
            AñoGeneracion();
        }

        protected void btnGeneracionVasos_Click(object sender, EventArgs e)
        {
            AñoGeneracion();
        }

        protected void btnGeneracionClones_Click(object sender, EventArgs e)
        {
            AñoGeneracion();
        }

        protected void btnGeneracionCodificacion_Click(object sender, EventArgs e)
        {
            AñoGeneracion();
        }

        protected void btnGeneracion6papas_Click(object sender, EventArgs e)
        {
            AñoGeneracion();
        }

        protected void btnGeneracion12papas_Click(object sender, EventArgs e)
        {
            AñoGeneracion();
        }

        protected void btnGeneracion24papas_Click(object sender, EventArgs e)
        {
            AñoGeneracion();
        }

        protected void btnGeneracion48papas_Click(object sender, EventArgs e)
        {
            AñoGeneracion();
        }

        protected void btnGeneracionUpov_Click(object sender, EventArgs e)
        {
            Response.Redirect("");
        }
    }
}