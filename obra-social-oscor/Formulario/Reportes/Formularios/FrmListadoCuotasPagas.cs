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
    public partial class FrmListadoCuotasPagas : Form
    {
        public FrmListadoCuotasPagas()
        {
            InitializeComponent();
        }

        private void FrmListadoCuotasPagas_Load(object sender, EventArgs e)
        {

            this.reporteListadoCuotas.RefreshReport();
        }

        private void reporteListadoCuotas_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();                      

            tabla = AD_CuotaPaga.ObtenerCuotasPagasReporte();

            ReportDataSource ds = new ReportDataSource("DatosCuotasPagas", tabla);

            ReportParameter fechaHoraReporte = new ReportParameter("fechaReporte", DateTime.Now.ToString());

            reporteListadoCuotas.LocalReport.DataSources.Clear();
            reporteListadoCuotas.LocalReport.DataSources.Add(ds);
            reporteListadoCuotas.LocalReport.SetParameters(fechaHoraReporte);
            reporteListadoCuotas.LocalReport.Refresh();
            this.reporteListadoCuotas.RefreshReport();
        }
    }
}
