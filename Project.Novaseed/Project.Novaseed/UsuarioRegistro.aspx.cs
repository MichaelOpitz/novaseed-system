using Project.BusinessRules;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace Project.Novaseed
{
    public partial class UsuarioRegistro : System.Web.UI.Page
    {
        private int contUsuarioConectado;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                contUsuarioConectado = 0;

                CatalogUsuario cu = new CatalogUsuario();
                this.chartRegistroUsuario.Visible = true;

                List<Int32> conectadoArray = new List<Int32>();
                List<Int32> no_conectadoArray = new List<Int32>();
                // Arreglos del Grafico
                List<Project.BusinessRules.Usuario> usuario = cu.GetUsuariosConectados();
                this.chartRegistroUsuario.Titles.Add("Registro de Usuarios Conectados y NO Conectados por Día");
                this.chartRegistroUsuario.Titles[0].Font = new Font("Trebuchet MS", 14, FontStyle.Bold);
                for (int i = 0; i < usuario.Count; i++)
                {
                    conectadoArray.Add(usuario[i].Conectado);
                    no_conectadoArray.Add(usuario[i].No_conectado);
                }

                double[] yValues = { conectadoArray[0], no_conectadoArray[0] };
                string[] xValues = { "Conectados", "NO Conectados" };
                this.chartRegistroUsuario.Series["Default"].Points.DataBindXY(xValues, yValues);

                this.chartRegistroUsuario.Series["Default"].Points[0].Color = Color.PaleGreen;
                this.chartRegistroUsuario.Series["Default"].Points[1].Color = Color.LawnGreen;

                this.chartRegistroUsuario.Series["Default"].ChartType = SeriesChartType.Pie;
                this.chartRegistroUsuario.Series["Default"]["PieLabelStyle"] = "Disabled";
                this.chartRegistroUsuario.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;
                this.chartRegistroUsuario.Legends[0].Enabled = true;

                if (!IsPostBack)
                {
                    this.gdvUsuario.DataSource = cu.GetUsuarioRegistro();
                    this.DataBind();
                }
            }
            catch (Exception ex)
            {
            }
        }

        /*
         * Llena la grilla del usuario
         */
        private void PoblarGrilla()
        {
            CatalogUsuario cu = new CatalogUsuario();
            this.gdvUsuario.DataSource = cu.GetUsuarioRegistro();
            this.gdvUsuario.DataBind();
        }

        /*
         * LLENA CON LOS CONTROLES ESPECIFICOS EL GRIDVIEW USUARIO
         */
        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            try
            {
                CatalogUsuario cu = new CatalogUsuario();
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    int indexUsuarioConectado = cu.GetUsuarioEstaConectado(contUsuarioConectado);

                    if (indexUsuarioConectado == 1)
                        e.Row.BackColor = Color.LightGreen;
                    else
                        e.Row.BackColor = Color.FromArgb(255, 204, 203);
                    contUsuarioConectado = contUsuarioConectado + 1;
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}