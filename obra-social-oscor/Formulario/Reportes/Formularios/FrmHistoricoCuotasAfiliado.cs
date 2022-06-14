using Microsoft.Reporting.WinForms;
using obra_social_oscor.AccesoADatos;
using obra_social_oscor.Helpers;
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
    public partial class FrmHistoricoCuotasAfiliado : Form
    {
        public FrmHistoricoCuotasAfiliado()
        {
            InitializeComponent();
        }

        private void FrmHistoricoCuotasAfiliado_Load(object sender, EventArgs e)
        {
            CargarComboAfiliados();
        }

        private void CargarComboAfiliados()
        {
            try
            {
                cmb_afi_hist_cuota.DataSource = AD_Afiliado.ObtenerAfiliadosReporte();
                cmb_afi_hist_cuota.DisplayMember = "NOMBRE_COMPLETO";
                cmb_afi_hist_cuota.ValueMember = "NRO_AFILIADO";
                cmb_afi_hist_cuota.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de Afiliados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Salir_reporte_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_generar_reporte_cuota_afi_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            int numeroAfiliado = (int) cmb_afi_hist_cuota.SelectedValue;            

            string desde = Fechas.ConvertirFechaEnStringParaQuery(dtp_desde_report.Value.ToShortDateString());
            string hasta = Fechas.ConvertirFechaEnStringParaQuery(dtp_hasta_report.Value.ToShortDateString());

            tabla = AD_CuotaPaga.ObtenerCuotasPagasReporteHistorico(numeroAfiliado, desde, hasta);

            ReportDataSource ds = new ReportDataSource("DatosCuotasHistorico", tabla);

            ReportParameter fechaHoraReporte = new ReportParameter("fechaReporte", DateTime.Now.ToLongDateString());

            report_cuota_historico.LocalReport.DataSources.Clear();
            report_cuota_historico.LocalReport.DataSources.Add(ds);
            report_cuota_historico.LocalReport.SetParameters(fechaHoraReporte);
            report_cuota_historico.LocalReport.Refresh();
            this.report_cuota_historico.RefreshReport();
        }
    }
}
