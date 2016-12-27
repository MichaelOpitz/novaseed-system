using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class ReporteProduccion : System.Web.UI.Page
    {
        private string valorAñoString;
        private int id_produccion;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string user = this.Session["user"].ToString();
                if (user.Equals(""))
                    Response.Redirect("Login.aspx");
            }
            catch (Exception ex)
            {
                Response.Redirect("Login.aspx");
            }

            //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
            if (Request.QueryString["id_produccion"] != null)
                valorAñoString = Request.QueryString["id_produccion"];
            else
                valorAñoString = "0";
            id_produccion = Int32.Parse(valorAñoString);
        }

        protected void btnReporteProduccion_Click(object sender, EventArgs e)
        {
            DataSetNovaseed.produccionReporteDataTable dt = new DataSetNovaseed.produccionReporteDataTable();
            DataSetNovaseedTableAdapters.produccionReporteTableAdapter dta = new DataSetNovaseedTableAdapters.produccionReporteTableAdapter();                        
            dta.Fill(dt, id_produccion);

            ReportDataSource rds = new ReportDataSource();
            rds.Value = dt;
            rds.Name = "DataSet1";

            this.ReportViewer1.LocalReport.DataSources.Clear();
            this.ReportViewer1.LocalReport.DataSources.Add(rds);
            this.ReportViewer1.LocalReport.ReportEmbeddedResource = "ReporteProduccion.rdlc";
            this.ReportViewer1.LocalReport.ReportPath = @"ReporteProduccion.rdlc";
            this.ReportViewer1.LocalReport.Refresh();
        }
    }
}