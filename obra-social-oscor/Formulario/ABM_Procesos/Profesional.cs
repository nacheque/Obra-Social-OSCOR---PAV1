using obra_social_oscor.AccesoADatos;
using obra_social_oscor.Entidades;
using obra_social_oscor.Negocio;
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
            btnEliminarrPCE.Enabled = false;
            cmbEspecialidades.Enabled = false;
            cmbProfesionales.Enabled = false;
        }

        private void CargarComboCentros()
        {
            try
            {
                cmbCentros.DataSource = AD_Centro.ObtenerCentrosConEsp();
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
            gdrProfXCentroXEsp.Rows.Clear();
            CargarComboEspecialidades();
            CargarGrillaProfXEsp((int)cmbCentros.SelectedValue, cmbCentros.SelectedItem.ToString());
            cmbEspecialidades.Enabled = true;
            cmbProfesionales.Enabled = false;
            cmbEspecialidades.Text = "";
            cmbProfesionales.Text = "";
        }

        private void CargarComboEspecialidades()
        {
            try
            {
                cmbEspecialidades.DataSource = AD_Especialidad.ObtenerEspecialidadesPorCentroSinProf((int)cmbCentros.SelectedValue);
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

        private void CargarGrillaProfXEsp(int codigoCentro, string nombreCentro)
        {
            try
            {
                Centro centro = new Centro();
                centro.CodigoCentro = codigoCentro;
                centro.Denominacion = nombreCentro;

                List<ProfesionalPorCentroPorEspecialidad> pces = NE_ProfXCentroXEsp.ObtenerListaDeProfXEspDeCentro(centro);
                for (int i = 0; i < pces.Count; i++)
                {
                    gdrProfXCentroXEsp.Rows.Add();
                    gdrProfXCentroXEsp.Rows[i].Cells[0].Value = pces[i].Centro.CodigoCentro;
                    gdrProfXCentroXEsp.Rows[i].Cells[1].Value = pces[i].Centro.Denominacion;
                    gdrProfXCentroXEsp.Rows[i].Cells[2].Value = pces[i].Especialidad.CodigoEspecialidad;
                    gdrProfXCentroXEsp.Rows[i].Cells[3].Value = pces[i].Especialidad.NombreEspecialidad;
                    gdrProfXCentroXEsp.Rows[i].Cells[4].Value = pces[i].Profesional.Matricula;
                    gdrProfXCentroXEsp.Rows[i].Cells[5].Value = pces[i].Profesional.NombreCompleto;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de profesionales...");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btnAgregarPCE_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ProfesionalPorCentroPorEspecialidad pce = ObtenerDatosPCE();
        //        NE_ProfXCentroXEsp.ArgegarProfesionalACentroConEspecialidad(pce);
        //        MessageBox.Show("Profesional asignado con exito...");
        //        CargarGrillaProfXEsp((int)cmbCentros.SelectedValue, cmbCentros.SelectedItem.ToString());
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Error al asignar profesional...");
        //    }
        //}


        private void btnAgregarPCE_Click_1(object sender, EventArgs e)
        {
            try
            {
                ProfesionalPorCentroPorEspecialidad pce = ObtenerDatosPCE();
                NE_ProfXCentroXEsp.ArgegarProfesionalACentroConEspecialidad(pce);
                MessageBox.Show("Profesional asignado con exito...");
                CargarGrillaProfXEsp((int)cmbCentros.SelectedValue, cmbCentros.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Error al asignar profesional...");
            }
        }

        //private void cmbProfesionales_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    btnAgregarPCE.Enabled = true;
        //}

        private void cmbProfesionales_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            btnAgregarPCE.Enabled = true;
        }

        private ProfesionalPorCentroPorEspecialidad ObtenerDatosPCE()
        {
            Centro centro = new Centro();
            centro.CodigoCentro = (int)cmbCentros.SelectedValue;

            Especialidad especialidad = new Especialidad();
            especialidad.CodigoEspecialidad = (int)cmbEspecialidades.SelectedValue;

            Profesional profesional = new Profesional();
            profesional.Matricula = (int)cmbProfesionales.SelectedValue;

            ProfesionalPorCentroPorEspecialidad pce = new ProfesionalPorCentroPorEspecialidad();
            pce.Centro = centro;
            pce.Especialidad = especialidad;
            pce.Profesional = profesional;

            return pce;

        }

        private void ReiniciarFormulario()
        {
            cmbCentros.SelectedIndex = -1;
            cmbCentros.Enabled = true;
            cmbEspecialidades.SelectedIndex = -1;
            cmbEspecialidades.Enabled = false;
            cmbProfesionales.SelectedIndex = -1;
            cmbProfesionales.Enabled = false;
            gdrProfXCentroXEsp.Rows.Clear();
        }

        private void btnReiniciarFormulario_Click_1(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }

        private void gdrProfXCentroXEsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow filaSeleccionada = gdrProfXCentroXEsp.Rows[indice];

                Centro centro = new Centro();
                centro.CodigoCentro = int.Parse(filaSeleccionada.Cells["CodigoCentro"].Value.ToString());
                centro.Denominacion = filaSeleccionada.Cells["NombreCentro"].Value.ToString();

                Especialidad esp = new Especialidad();
                esp.CodigoEspecialidad = int.Parse(filaSeleccionada.Cells["CodEsp"].Value.ToString());
                esp.NombreEspecialidad = filaSeleccionada.Cells["NombreEsp"].Value.ToString();

                Profesional prof = new Profesional();
                prof.Matricula = int.Parse(filaSeleccionada.Cells["Matricula"].Value.ToString());
                prof.Nombre = filaSeleccionada.Cells["NombreProfesional"].Value.ToString();

                ProfesionalPorCentroPorEspecialidad pce = new ProfesionalPorCentroPorEspecialidad();
                pce.Centro = centro;
                pce.Especialidad = esp;
                pce.Profesional = prof;

                //ReiniciarFormulario();
                CargarCampos(pce);
                cmbEspecialidades.Enabled = false;
                cmbProfesionales.Enabled = false;
                btnAgregarPCE.Enabled = false;
                btnEliminarrPCE.Enabled = true;
            }
        }

        private void CargarCampos(ProfesionalPorCentroPorEspecialidad pce)
        {
            cmbEspecialidades.Text = pce.Especialidad.NombreEspecialidad.ToString();
            cmbProfesionales.Text = pce.Profesional.Nombre.ToString();
        }
    }
}
