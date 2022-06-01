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

namespace obra_social_oscor.Formulario.ABM
{
    public partial class frm_Profesional : Form
    {
        public frm_Profesional()
        {
            InitializeComponent();
        }

        private void frm_Profesional_Load(object sender, EventArgs e)
        {
            CargarComboCentros();
            btnAgregarPCE.Enabled = false;
            btnEditarPCE.Enabled = false;
            cmbEspecialidades.Enabled = false;
            cmbProfesionales.Enabled = false;
        }

        private void CargarComboCentros()
        {
            try
            {
                cmbCentros.DataSource = AD_Centro.ObtenerCentrosConEspSinProf();
                cmbCentros.DisplayMember = "DENOMINACION";
                cmbCentros.ValueMember = "COD_CENTRO";
                cmbCentros.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de Centros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbCentros_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarComboEspecialidades();
            cmbEspecialidades.Enabled = true;
            cmbProfesionales.Enabled = false;
        }

        private void CargarComboEspecialidades()
        {
            try
            {
                cmbEspecialidades.DataSource = AD_Especialidad.ObtenerEspecialidadesPorCentro2((int)cmbCentros.SelectedValue);
                cmbEspecialidades.DisplayMember = "NOMBRE";
                cmbEspecialidades.ValueMember = "COD_ESPECIALIDAD";
                cmbEspecialidades.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de Especialidades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbEspecialidades_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarComboProfesionales();
            cmbProfesionales.Enabled = true;
            CargarGrillaProfXEsp((int)cmbCentros.SelectedValue, (int)cmbEspecialidades.SelectedValue);
        }

        private void CargarComboProfesionales()
        {
            try
            {
                cmbProfesionales.DataSource = AD_Profesional.ObtenerProfesionalesParaAsignar();
                cmbProfesionales.DisplayMember = "NOMBRE_COMPLETO";
                cmbProfesionales.ValueMember = "MATRICULA";
                cmbProfesionales.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarGrillaProfXEsp(int codigoCentro, int codigoEspecialidad)
        {
            try
            {
                gdrProfXCentroXEsp.DataSource = AD_Profesional.ObtenerProfesionalesPorEspYCen(codigoCentro, codigoEspecialidad);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener profesionales...");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
