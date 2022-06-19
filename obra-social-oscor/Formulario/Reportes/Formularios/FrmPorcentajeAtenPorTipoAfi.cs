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
    public partial class FrmPorcentajeAtenPorTipoAfi : Form
    {
        public FrmPorcentajeAtenPorTipoAfi()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPorcentajeAtenPorTipoAfi_Load(object sender, EventArgs e)
        {

        }

        private void btn_generar_estadistica_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            string desde = dtp_desde.Value.ToShortDateString();
            string hasta = dtp_hasta.Value.ToShortDateString();

            tabla = AD_Atencion.ObtenerPorcentajeAtencionesPorTipoAfi(desde, hasta);

            ReportDataSource ds = new ReportDataSource("PorcentajeAtencionesTipoAfi", tabla);

            ReportParameter fechaHoraReporte = new ReportParameter("fechaReporte", DateTime.Now.ToString());


            report_porcentaje_aten_tipo.LocalReport.DataSources.Clear();
            report_porcentaje_aten_tipo.LocalReport.DataSources.Add(ds);
            report_porcentaje_aten_tipo.LocalReport.SetParameters(fechaHoraReporte);
            report_porcentaje_aten_tipo.LocalReport.Refresh();
            this.report_porcentaje_aten_tipo.RefreshReport();
        }
    }
}
