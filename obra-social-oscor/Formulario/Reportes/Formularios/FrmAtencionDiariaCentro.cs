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
    public partial class FrmAtencionDiariaCentro : Form
    {
        public FrmAtencionDiariaCentro()
        {
            InitializeComponent();
        }

        private void FrmAtencionDiariaCentro_Load(object sender, EventArgs e)
        {
            CargarComboCentro();
            //this.reportViewer1.RefreshReport();
        }

        private void CargarComboCentro()
        {
            try
            {
                cmb_centro.DataSource = AD_Centro.ObtenerCentroReporte();                
                cmb_centro.DisplayMember = "DENOMINACION";
                cmb_centro.ValueMember = "COD_CENTRO";
                cmb_centro.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de Centro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_generar_reporte_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            int numeroCentro = (int) cmb_centro.SelectedValue;

            string fecha = dtp_fecha.Value.ToShortDateString();

            tabla = AD_Atencion.ObtenerReporteAtencionesCentros(numeroCentro, fecha);

            ReportDataSource ds = new ReportDataSource("DatosReportes", tabla);

            ReportParameter fechaHoraReporte = new ReportParameter("fechaReporte", DateTime.Now.ToString());

            reportAtencionDiariaCentro.LocalReport.DataSources.Clear();
            reportAtencionDiariaCentro.LocalReport.DataSources.Add(ds);
            reportAtencionDiariaCentro.LocalReport.SetParameters(fechaHoraReporte);
            reportAtencionDiariaCentro.LocalReport.Refresh();
            this.reportAtencionDiariaCentro.RefreshReport();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
