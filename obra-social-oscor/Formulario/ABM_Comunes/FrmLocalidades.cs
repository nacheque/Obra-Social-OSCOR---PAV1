using obra_social_oscor.Entidades;
using obra_social_oscor.Helpers;
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

namespace obra_social_oscor.Formulario.ABM_Comunes
{
    public partial class frm_Localidades : Form
    {
        int globalCodigoLoc;

        public frm_Localidades()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Localidades_Load(object sender, EventArgs e)
        {
            btnEditarLocalidad.Enabled = false;
            btnEliminarLocalidad.Enabled = false;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                gdrLocalidades.Rows.Clear();
                List<Localidad> localidades = NE_Localidades.ObtenerListadoLocalidades();
                for (int i = 0; i < localidades.Count; i++)
                {
                    gdrLocalidades.Rows.Add();
                    gdrLocalidades.Rows[i].Cells[0].Value = localidades[i].IdLocalidad;
                    gdrLocalidades.Rows[i].Cells[1].Value = localidades[i].NombreLocalidad;
                }
            }
            catch (Exception)
            {

                throw;
                //MessageBox.Show("Error al obtener el listado de localidades");
            }
        }

        private void gdrLocalidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrLocalidades.Rows[indice];

            string nombreLocalidad = filaSeleccionada.Cells["NombreLocalidad"].Value.ToString();
            globalCodigoLoc = int.Parse(filaSeleccionada.Cells["Codigo"].Value.ToString());

            btnAgregarLocalidad.Enabled = false;
            btnEditarLocalidad.Enabled = true;
            btnEliminarLocalidad.Enabled = true;

            Localidad localidad = new Localidad();
            localidad.NombreLocalidad = nombreLocalidad;

            CargarCampos(localidad);
        }

        private void CargarCampos(Localidad localidad)
        {
            txtNombreLocalidad.Text = localidad.NombreLocalidad;
        }

        private void btnAgregarLocalidad_Click(object sender, EventArgs e)
        {
            if (!txtNombreLocalidad.Text.Equals(""))
            {
                if (!ExisteEnGrilla(txtNombreLocalidad.Text))
                {
                    Localidad localidad = ObtenerDatosLocalidad();
                    try
                    {
                        NE_Localidades.AgregarLocalidad(localidad);
                        MessageBox.Show("Localidad agregada con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReiniciarFormulario();
                        CargarGrilla();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error al agregar Localidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Esta Localidad ya existe...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el nombre Localidad...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ExisteEnGrilla(string criterio)
        {
            bool resultado = false;

            for (int i = 0; i < gdrLocalidades.Rows.Count; i++)
            {
                if (gdrLocalidades.Rows[i].Cells["NombreLocalidad"].Value.ToString().Equals(criterio, StringComparison.OrdinalIgnoreCase))
                {
                    resultado = true;
                    break;
                }

            }

            return resultado;
        }

        private void ReiniciarFormulario()
        {
            txtNombreLocalidad.Text = "";
            txtNombreLocalidad.Focus();
            btnAgregarLocalidad.Enabled = true;
            btnEditarLocalidad.Enabled = false;
            btnEliminarLocalidad.Enabled = false;
        }

        private void txtNombreLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private Localidad ObtenerDatosLocalidad()
        {
            Localidad localidad = new Localidad();
            localidad.NombreLocalidad = txtNombreLocalidad.Text;

            return localidad;
        }

        private void btnEditarLocalidad_Click(object sender, EventArgs e)
        {
            if (!txtNombreLocalidad.Text.Equals(""))
            {
                if (!ExisteEnGrilla(txtNombreLocalidad.Text))
                {
                    Localidad localidad = ObtenerDatosLocalidad();
                    try
                    {
                        NE_Localidades.EditarLocalidad(localidad, globalCodigoLoc);
                        MessageBox.Show("Localidad editada con exito");
                        ReiniciarFormulario();
                        CargarGrilla();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error al editar Localidad...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("La localidad ya existe...");
                }
            }
            else
            {
                MessageBox.Show("Debe agregar el nombre de la Localidad...");
            }
        }

        private void btnEliminarLocalidad_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que quiere eliminar esta Localidad?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    NE_Localidades.EliminarLocalidad(globalCodigoLoc);
                    MessageBox.Show("Localidad Eliminada con exito");
                    ReiniciarFormulario();
                    CargarGrilla();
                }
                catch (InvalidOperationException)
                {

                    MessageBox.Show("La localidad se encuentra asociada a un Centro o un Profesional...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception)
                {
                    MessageBox.Show("Error al eliminar Localidad...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
    }
}
