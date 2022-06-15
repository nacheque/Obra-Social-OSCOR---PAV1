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
    public partial class FrmListadoProfesionales2 : Form
    {
        public FrmListadoProfesionales2()
        {
            InitializeComponent();
        }

        private void FrmListadoReportes_Load(object sender, EventArgs e)
        {

            this.reportViewerListProf.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewerListProf_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Profesional.ObtenerListadoProfesionalesParaReporte();

            ReportDataSource ds = new ReportDataSource("ListadoProfesionales", tabla);

            ReportParameter fechaHoraReporte = new ReportParameter("fechaReporte", DateTime.Now.ToString());

            reportViewerListProf.LocalReport.DataSources.Clear();
            reportViewerListProf.LocalReport.DataSources.Add(ds);
            reportViewerListProf.LocalReport.SetParameters(fechaHoraReporte);
            reportViewerListProf.LocalReport.Refresh();
        }
    }
}
