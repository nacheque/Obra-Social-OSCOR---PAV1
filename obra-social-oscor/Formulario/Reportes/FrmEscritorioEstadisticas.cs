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
    public partial class FrmEscritorioEstadisticas : Form
    {
        public FrmEscritorioEstadisticas()
        {
            InitializeComponent();
        }

        private void btn_Salir_estadisticas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cantidadDeAtencionesPorTipoDeAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCantidadAtenPorTipoAfiliado ventana = new FrmCantidadAtenPorTipoAfiliado();
            ventana.ShowDialog();
        }

        private void porcentajeDeAtencionesPorTipoDeAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPorcentajeAtenPorTipoAfi ventana = new FrmPorcentajeAtenPorTipoAfi();
            ventana.ShowDialog();
        }

        private void cantidadDeEspecialidadesPorCentroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCantidadEspPorCentro ventana = new FrmCantidadEspPorCentro();
            ventana.ShowDialog();
        }

        private void porcentajeDePracticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPorcentajePracticas ventana = new FrmPorcentajePracticas();
            ventana.ShowDialog();
        }
    }
}
