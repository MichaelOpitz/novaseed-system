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
    public partial class ReporteVariedad : System.Web.UI.Page
    {
        private string codigo_variedad, nombre_variedad;

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
                if (Request.QueryString["codigo_variedad"] != null && Request.QueryString["nombre_variedad"] != null)
                {
                    codigo_variedad = Request.QueryString["codigo_variedad"];
                    nombre_variedad = Request.QueryString["nombre_variedad"];
                }
                else
                {
                    codigo_variedad = "0";
                    nombre_variedad = "0";
                }
                string nombre = codigo_variedad + "-" + nombre_variedad;

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
                CatalogVariedad cv = new CatalogVariedad();
                DataTable dt = new DataTable();
                dt.Clear();
                dt = cv.GetVariedadReporte(codigo_variedad).Tables[0];

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.ReportPath = @"ReporteVariedad.rdlc";
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
                response.AppendHeader("Content-Disposition", "attachment; filename =" + nombre + "_variedad." + extension);
                response.BinaryWrite(ms.ToArray());
                response.End();
            }
            catch (Exception ex)
            {
            }
        }
    }
}