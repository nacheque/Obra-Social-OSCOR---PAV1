using obra_social_oscor.Formulario.Reportes.Atenciones;
using obra_social_oscor.Formulario.Reportes.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obra_social_oscor.Formulario.Reportes
{
    public partial class FrmEscritorioReportes : Form
    {
        public FrmEscritorioReportes()
        {
            InitializeComponent();
        }

        private void btn_Salir_reportes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void historicoDeAtencionesPorAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistoricoAtencionesAfiliado ventana = new FrmHistoricoAtencionesAfiliado();
            ventana.ShowDialog();
        }

        private void historicoDeCuotasPagasPorAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistoricoCuotasAfiliado ventana = new FrmHistoricoCuotasAfiliado();
            ventana.ShowDialog();
        }

        private void reporteDeAtencionesDiariaPorAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtencionDiariaAfiliado ventana = new FrmAtencionDiariaAfiliado();
            ventana.ShowDialog();
        }

        private void reporteDeAtencionesDiariaPorCentroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtencionDiariaCentro ventana = new FrmAtencionDiariaCentro();
            ventana.ShowDialog();
        }

        private void listadoCuotasPagasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoCuotasPagas ventana = new FrmListadoCuotasPagas();
            ventana.ShowDialog();
        }
    }
}
