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

namespace obra_social_oscor.Formulario.Reportes.Atenciones
{
    public partial class FrmHistoricoAtencionesAfiliado : Form
    {
        public FrmHistoricoAtencionesAfiliado()
        {
            InitializeComponent();
        }

        private void FrmHistoricoAtencionesAfiliado_Load(object sender, EventArgs e)
        {
            CargarComboAfiliados();
            CargarComboProfesionales();            
        }

        private void CargarComboAfiliados()
        {
            try
            {
                cmb_afiliado_reporte_aten.DataSource = AD_Afiliado.ObtenerAfiliadosReporte();
                cmb_afiliado_reporte_aten.DisplayMember = "NOMBRE_COMPLETO";
                cmb_afiliado_reporte_aten.ValueMember = "NRO_AFILIADO";
                cmb_afiliado_reporte_aten.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de Afiliados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboProfesionales()
        {
            try
            {
                cmb_prof_reporte_aten.DataSource = AD_Profesional.ObtenerProfesionalesParaAsignar();
                cmb_prof_reporte_aten.DisplayMember = "NOMBRE_COMPLETO";
                cmb_prof_reporte_aten.ValueMember = "MATRICULA";
                cmb_prof_reporte_aten.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de Profesionales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void report_aten_historico_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_generar_reporte_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            int numeroAfiliado = (int) cmb_afiliado_reporte_aten.SelectedValue;
            int matricula = (int) cmb_prof_reporte_aten.SelectedValue;

            string desde = dtp_desde.Value.ToShortDateString();
            string hasta = dtp_hasta.Value.ToShortDateString();      

            tabla = AD_Atencion.ObtenerAtencionesReporteHistorico(numeroAfiliado, matricula, desde, hasta);

            ReportDataSource ds = new ReportDataSource("DatosReportes", tabla);

            ReportParameter fechaHoraReporte = new ReportParameter("fechaReporte", DateTime.Now.ToString());


            report_aten_historico.LocalReport.DataSources.Clear();
            report_aten_historico.LocalReport.DataSources.Add(ds);
            report_aten_historico.LocalReport.SetParameters(fechaHoraReporte);
            report_aten_historico.LocalReport.Refresh();
            this.report_aten_historico.RefreshReport();
        }
    }
}
