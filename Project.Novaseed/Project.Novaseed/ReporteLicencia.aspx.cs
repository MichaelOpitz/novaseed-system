using Microsoft.Reporting.WebForms;
using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class ReporteLicencia : System.Web.UI.Page
    {
        private string id_produccionString, nombre_produccion;
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

            try
            {
                //PREGUNTA SI ES DISTINTO DE NULL PORQUE EL USUARIO PUEDE ESCRIBIR DESDE LA URL Y NO TENDRÍA AÑO ASIGNADO
                if (Request.QueryString["id_produccion"] != null && Request.QueryString["nombre_produccion"] != null)
                {
                    id_produccionString = Request.QueryString["id_produccion"];
                    nombre_produccion = Request.QueryString["nombre_produccion"];
                }
                else
                {
                    id_produccionString = "0";
                    nombre_produccion = "0";
                }
                id_produccion = Int32.Parse(id_produccionString);
                string nombre = id_produccionString + "-" + nombre_produccion;

                //Método para llamar el archivo
                SetupReport(this.ReportViewer1);
                //Método para exportar a PDF
                RenderReport(this.ReportViewer1, Response, nombre.Replace(" ", ""));
            }
            catch (Exception ex)
            {
            }
        }

        private void SetupReport(ReportViewer reportViewer)
        {
            try
            {
                CatalogProduccion cp = new CatalogProduccion();
                DataTable dt = new DataTable();
                dt.Clear();
                dt = cp.GetLicenciaReporte(id_produccion).Tables[0];

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.ReportPath = @"ReporteLicencia.rdlc";
                reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            }
            catch (Exception ex)
            {
            }
        }

        private void RenderReport(ReportViewer reportViewer, HttpResponse response, string nombre)
        {
            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;
                byte[] bytes = reportViewer.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamids, out warnings);

                MemoryStream ms = new MemoryStream(bytes);
                response.ContentType = mimeType;
                response.AppendHeader("Content-Disposition", "attachment; filename =" + nombre + "_licencia." + extension);
                response.BinaryWrite(ms.ToArray());
                response.End();
            }
            catch (Exception ex)
            {
            }
        }
    }
}