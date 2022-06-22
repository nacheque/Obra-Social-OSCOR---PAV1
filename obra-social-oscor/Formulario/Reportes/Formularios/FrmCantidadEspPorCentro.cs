using Microsoft.Reporting.WinForms;
using obra_social_oscor.AccesoADatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obra_social_oscor.Formulario.Reportes.Formularios
{
    public partial class FrmCantidadEspPorCentro : Form
    {
        public FrmCantidadEspPorCentro()
        {
            InitializeComponent();
        }

        private void report_cant_esp_por_centro_Load(object sender, EventArgs e)
        {

        }

        private void FrmCantidadEspPorCentro_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla = AD_Centro.ObtenerCantidadEspPorCentro();

            ReportDataSource ds = new ReportDataSource("CantidadEspecialidades", tabla);

            ReportParameter fechaHoraReporte = new ReportParameter("fechaReporte", DateTime.Now.ToString());

            report_cant_esp_por_centro.LocalReport.DataSources.Clear();
            report_cant_esp_por_centro.LocalReport.DataSources.Add(ds);
            report_cant_esp_por_centro.LocalReport.SetParameters(fechaHoraReporte);
            report_cant_esp_por_centro.LocalReport.Refresh();
            this.report_cant_esp_por_centro.RefreshReport();
        }
    }
}
