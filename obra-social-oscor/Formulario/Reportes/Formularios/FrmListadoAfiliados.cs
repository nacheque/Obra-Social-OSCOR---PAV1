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
    public partial class FrmListadoAfiliados : Form
    {
        public FrmListadoAfiliados()
        {
            InitializeComponent();
        }

        private void FrmListadoAfiliados_Load(object sender, EventArgs e)
        {

            this.reportViewerListadoAfiliados.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Afiliado.ObtenerListadoAfiliadosParaReporte();

            ReportDataSource ds = new ReportDataSource("ListadoAfiliados", tabla);

            reportViewerListadoAfiliados.LocalReport.DataSources.Clear();
            reportViewerListadoAfiliados.LocalReport.DataSources.Add(ds);
            reportViewerListadoAfiliados.LocalReport.Refresh();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
