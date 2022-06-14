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
    public partial class FrmAtencionDiariaAfiliado : Form
    {
        public FrmAtencionDiariaAfiliado()
        {
            InitializeComponent();
        }

        private void FrmAtencionDiariaAfiliado_Load(object sender, EventArgs e)
        {
            CargarComboAfiliado();
            //this.reportAtencionDiariaAfiliado.RefreshReport();
        }

        private void CargarComboAfiliado()
        {
            try
            {
                cmb_afiliado.DataSource = AD_Afiliado.ObtenerAfiliadosReporte();
                cmb_afiliado.DisplayMember = "NOMBRE_COMPLETO";
                cmb_afiliado.ValueMember = "NRO_AFILIADO";
                cmb_afiliado.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de Afiliado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_generarReportAfiliado_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            int numeroAfiliado = (int)cmb_afiliado.SelectedValue;

            string fecha = dtp_fecha.Value.ToString("dd/MM/yyyy");

            tabla = AD_Atencion.ObtenerReporteAtencionesAfiliado(numeroAfiliado, fecha);

            ReportDataSource ds = new ReportDataSource("DatosReportes", tabla);

            reportAtencionDiariaAfiliado.LocalReport.DataSources.Clear();
            reportAtencionDiariaAfiliado.LocalReport.DataSources.Add(ds);
            reportAtencionDiariaAfiliado.LocalReport.Refresh();
            this.reportAtencionDiariaAfiliado.RefreshReport();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
