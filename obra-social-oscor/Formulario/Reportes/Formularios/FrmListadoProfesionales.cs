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
    public partial class FrmListadoProfesionales : Form
    {
        public FrmListadoProfesionales()
        {
            InitializeComponent();
        }

        private void FrmListadoProfesionales_Load(object sender, EventArgs e)
        {

            this.reportViewerListProf.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Profesional.ObtenerListadoProfesionalesParaReporte();

            ReportDataSource ds = new ReportDataSource("ListadoProfesionales", tabla);

            reportViewerListProf.LocalReport.DataSources.Clear();
            reportViewerListProf.LocalReport.DataSources.Add(ds);
            reportViewerListProf.LocalReport.Refresh();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
