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
    public partial class MenuProduccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CatalogUPOV cu = new CatalogUPOV();
            List<Project.BusinessRules.UPOV> upov = cu.GetAñoUPOVProduccion_fn();

            if (!Page.IsPostBack)
            {
                this.chartProduccion.Visible = false;

                this.ddlProduccionAño.DataValueField = "ano_upov";
                this.ddlProduccionAño.DataTextField = "ano_upov";
                this.ddlProduccionAño.DataSource = upov;
                this.DataBind();
            }
        }

        private void AñoGeneracion(string url)
        {
            string año = this.ddlProduccionAño.SelectedValue;
            Response.Redirect(url + "?valor=" + año);
        }

        protected void btnMenuProduccionIngresar_Click(object sender, EventArgs e)
        {
            AñoGeneracion("ProduccionSeleccionIngresar.aspx");
        }

        protected void btnMenuProduccionFiltrar_Click(object sender, EventArgs e)
        {
            AñoGeneracion("ProduccionFiltrar.aspx");
        }

        //------------------------------------------------Estadísticas--------------------------------------------------
        protected void btnEstadisticaPorcentaje_Click(object sender, EventArgs e)
        {
            Estadisticas("ranking");
        }

        protected void btnEstadisticaCiudad_Click(object sender, EventArgs e)
        {
            Estadisticas("ciudad");
        }

        protected void btnEstadisticaDestino_Click(object sender, EventArgs e)
        {
            Estadisticas("destino");
        }

        protected void btnEstadisticaFertilidad_Click(object sender, EventArgs e)
        {
            Estadisticas("fertilidad");
        }

        public void Estadisticas(string nombre_estadistica)
        {
            CatalogProduccion cp = new CatalogProduccion();
            this.chartProduccion.Visible = true;
            string value = this.ddlProduccionAño.SelectedValue;

            List<string> nombreArray = new List<string>();
            List<Int32> cantidadArray = new List<Int32>();
            // Arreglos del Grafico
            List<Project.BusinessRules.Produccion> produccion = new List<Produccion>();
            if (nombre_estadistica == "ranking")
            {
                produccion = cp.GetRankingVariedad(Int32.Parse(value));
                this.chartProduccion.Titles.Add("Ranking de Variedades por Relación Standard");
            }
            if (nombre_estadistica == "ciudad")
            {
                produccion = cp.GetCiudad(Int32.Parse(value));
                this.chartProduccion.Titles.Add("Estadística de las Ciudad en Producción");
            }
            if (nombre_estadistica == "destino")
            {
                produccion = cp.GetDestino(Int32.Parse(value));
                this.chartProduccion.Titles.Add("Estadística de los Destinos en Producción");
            }
            if (nombre_estadistica == "fertilidad")
            {
                produccion = cp.GetFertilidad(Int32.Parse(value));
                this.chartProduccion.Titles.Add("Estadística de las Fertilidades en Producción");
            }
            for (int i = 0; i < produccion.Count; i++)
            {
                nombreArray.Add(produccion[i].Nombre_estadistica.ToString());
                cantidadArray.Add(produccion[i].Cantidad_estadistica);
            }
            // Se modifica la Paleta de Colores a utilizar por el control.
            this.chartProduccion.Palette = ChartColorPalette.SeaGreen;
            // Se agrega un titulo al Grafico.
            
            this.chartProduccion.Titles[0].Alignment = ContentAlignment.MiddleCenter;
            this.chartProduccion.Titles[0].Font = new Font("Trebuchet MS", 14, FontStyle.Bold);

            this.chartProduccion.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Trebuchet MS", 12, FontStyle.Bold);
            this.chartProduccion.Series[0].Font = new Font("Trebuchet MS", 12, FontStyle.Bold);
            this.chartProduccion.Series[0].Points.DataBindXY(nombreArray, cantidadArray);
            this.chartProduccion.Series[0]["LabelStyle"] = "Bottom";
            this.chartProduccion.ChartAreas[0].AxisX.LabelStyle.Angle = 45;
            this.chartProduccion.ChartAreas[0].Area3DStyle.Enable3D = true;
            this.chartProduccion.DataBind();
        }
    }
}