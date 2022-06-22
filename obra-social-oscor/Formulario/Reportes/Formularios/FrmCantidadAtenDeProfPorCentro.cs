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
    public partial class FrmCantidadAtenDeProfPorCentro : Form
    {
        public FrmCantidadAtenDeProfPorCentro()
        {
            InitializeComponent();
        }

        private void FrmCantidadAtenDeProfPorCentro_Load(object sender, EventArgs e)
        {
            
        }

        private void report_cantidad_profxcentro_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla = AD_ProfXCentroXEsp.ObtenerCantidadProfXCentro();

            ReportDataSource ds = new ReportDataSource("DatosEstaditicas", tabla);

            ReportParameter fechaHoraReporte = new ReportParameter("fechaReporte", DateTime.Now.ToString());

            report_cantidad_profxcentro.LocalReport.DataSources.Clear();
            report_cantidad_profxcentro.LocalReport.DataSources.Add(ds);
            report_cantidad_profxcentro.LocalReport.SetParameters(fechaHoraReporte);
            report_cantidad_profxcentro.LocalReport.Refresh();
            this.report_cantidad_profxcentro.RefreshReport();
        }
    }
}
