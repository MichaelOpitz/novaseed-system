using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class ReporteVariedad : System.Web.UI.Page
    {
        private string codigo_variedad;

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
            if (Request.QueryString["codigo_variedad"] != null)
                codigo_variedad = Request.QueryString["codigo_variedad"];
            else
                codigo_variedad = "0";
        }

        protected void btnReporteVariedad_Click(object sender, EventArgs e)
        {
            DataSetNovaseed.variedadReporteDataTable dt = new DataSetNovaseed.variedadReporteDataTable();
            DataSetNovaseedTableAdapters.variedadReporteTableAdapter dta = new DataSetNovaseedTableAdapters.variedadReporteTableAdapter();
            dta.Fill(dt, codigo_variedad);

            ReportDataSource rds = new ReportDataSource();
            rds.Value = dt;
            rds.Name = "DataSet1";

            this.ReportViewer1.LocalReport.DataSources.Clear();
            this.ReportViewer1.LocalReport.DataSources.Add(rds);
            this.ReportViewer1.LocalReport.ReportEmbeddedResource = "ReporteVariedad.rdlc";
            this.ReportViewer1.LocalReport.ReportPath = @"ReporteVariedad.rdlc";
            this.ReportViewer1.LocalReport.Refresh();
        }
    }
}