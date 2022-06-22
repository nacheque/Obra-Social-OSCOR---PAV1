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
    public partial class FrmPorcentajePracticas : Form
    {
        public FrmPorcentajePracticas()
        {
            InitializeComponent();
        }

        private void FrmPorcentajePracticas_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();           

            tabla = AD_Practica.ObtenerPorcentajeDePracticas();

            ReportDataSource ds = new ReportDataSource("PorcentajePracticas", tabla);

            ReportParameter fechaHoraReporte = new ReportParameter("fechaReporte", DateTime.Now.ToString());

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.SetParameters(fechaHoraReporte);
            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
