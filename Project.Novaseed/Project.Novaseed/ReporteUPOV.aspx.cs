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
    public partial class ReporteUPOV : System.Web.UI.Page
    {        
        private string id_upovString, nombre_upov;
        private int id_upov;

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
                if (Request.QueryString["id_upov"] != null && Request.QueryString["nombre_upov"] != null)
                {
                    id_upovString = Request.QueryString["id_upov"];
                    nombre_upov = Request.QueryString["nombre_upov"];
                }
                else
                {
                    id_upovString = "0";
                    nombre_upov = "0";
                }
                id_upov = Int32.Parse(id_upovString);
                string nombre = id_upovString + "-" + nombre_upov;

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
                CatalogUPOV cu = new CatalogUPOV();
                DataTable dt = new DataTable();
                dt.Clear();
                dt = cu.GetUPOVReporte(id_upov).Tables[0];

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.ReportPath = @"ReporteUPOV.rdlc";
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
                response.AppendHeader("Content-Disposition", "attachment; filename =" + nombre + "_upov." + extension);
                response.BinaryWrite(ms.ToArray());
                response.End();
            }
            catch (Exception ex)
            {
            }
        }
    }
}