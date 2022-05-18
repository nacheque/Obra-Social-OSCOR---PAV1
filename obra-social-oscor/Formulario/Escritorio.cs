using obra_social_oscor.Formulario.ABM;
using obra_social_oscor.Formulario.ABM_Comunes;
using obra_social_oscor.Formulario.ABM_Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obra_social_oscor
{
    public partial class frm_Escritorio : Form
    {
        public frm_Escritorio()
        {
            InitializeComponent();
        }

        private void frm_Escritorio_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
        }

        private void btn_afiliado_Click(object sender, EventArgs e)
        {
            frm_Atenciones ventana = new frm_Atenciones();
            ventana.ShowDialog();
        }

        private void btn_Centro_Click(object sender, EventArgs e)
        {
            frm_Centro ventana = new frm_Centro();
            ventana.ShowDialog();
        }

        private void btn_Profesional_Click(object sender, EventArgs e)
        {
            frm_Profesional ventana = new frm_Profesional();
            ventana.ShowDialog();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Centros_Click(object sender, EventArgs e)
        {

        }

        private void btn_Pagos_Click(object sender, EventArgs e)
        {
            frm_Pagos ventana = new frm_Pagos();
            ventana.ShowDialog();
        }

        private void gestionDeEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Especialidades ventana = new frm_Especialidades();
            ventana.ShowDialog();
        }

        private void gestionDeBarriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Barrios ventana = new frm_Barrios();
            ventana.ShowDialog();
        }

        private void gestionDeAfliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Afiliado ventana = new frm_Afiliado();
            ventana.ShowDialog();
        }

        private void gestionDeTipoDeAfiliadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Tipo_Afiliado ventana = new frm_Tipo_Afiliado();
            ventana.ShowDialog();
        }

        private void gestionDeLocalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Localidades ventana = new frm_Localidades();
            ventana.ShowDialog();
        }

        private void gestionDeProfesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfesionales ventana = new FrmProfesionales();
            ventana.ShowDialog();
        }
    }
}
