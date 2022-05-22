using obra_social_oscor.AccesoADatos;
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
    public partial class frm_Especialidades : Form
    {
        int global_codigoEspecialidad;

        public frm_Especialidades()
        {
            InitializeComponent();
        }

        private void btn_Salir_Esp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Especialidades_Load(object sender, EventArgs e)
        {
            btn_Editar_Esp.Enabled = false;
            btn_Eliminar_Esp.Enabled = false;
            CargarGrilla();
        }

        private void btn_Limpiar_Esp_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }

        private void txt_Nombre_Esp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void grd_Esp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow filaSeleccionada = grd_Esp.Rows[indice];

                string nombreEspecialidad = filaSeleccionada.Cells["Nombre"].Value.ToString();
                global_codigoEspecialidad = int.Parse(filaSeleccionada.Cells["Codigo"].Value.ToString());
                ReiniciarFormulario();

                btn_Editar_Esp.Enabled = true;
                btn_Eliminar_Esp.Enabled = true;
                btn_Agregar_Esp.Enabled = false;

                Especialidad especialidad = new Especialidad();
                especialidad.NombreEspecialidad = nombreEspecialidad;

                CargarCampos(especialidad);
            }
        }

        private void btn_Agregar_Esp_Click(object sender, EventArgs e)
        {            
            if (!txt_Nombre_Esp.Text.Equals(""))
            {
                if (!ExisteEnGrilla(txt_Nombre_Esp.Text))
                {
                    Especialidad especialidad = ObtenerDatosEspecialidad();
                    try
                    {
                        NE_Especialidad.AgregarEspecialidad(especialidad);
                        MessageBox.Show("Especialidad agregada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReiniciarFormulario();
                        CargarGrilla();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error al agregar especialidad...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                }
                else
                {
                    MessageBox.Show("Ya existe una especialidad con ese nombre...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de especialidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Editar_Esp_Click(object sender, EventArgs e)
        {
            if (!txt_Nombre_Esp.Text.Equals(""))
            {
                if (!ExisteEnGrilla(txt_Nombre_Esp.Text))
                {
                    Especialidad especialidad = ObtenerDatosEspecialidad();
                    try
                    {
                        NE_Especialidad.ActualizarEspecialidad(especialidad, global_codigoEspecialidad);
                        MessageBox.Show("Especialidad actualizada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReiniciarFormulario();
                        CargarGrilla();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error al actualizar especialidad...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe una especialidad con ese nombre...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de especialidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Eliminar_Esp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar la especialidad seleccionada?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    NE_Especialidad.EliminarEspecialidad(global_codigoEspecialidad);
                    MessageBox.Show("Especialidad eliminada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReiniciarFormulario();
                    CargarGrilla();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Error al eliminar especialidad.\nLa especialidad esta asociada a un Centro...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar especialidad...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void CargarGrilla() {
            try
            {
                grd_Esp.Rows.Clear();
                List<Especialidad> especialidades = NE_Especialidad.ObtenerListadoEspecialidades();
                for (int i = 0; i < especialidades.Count; i++)
                {
                    grd_Esp.Rows.Add();
                    grd_Esp.Rows[i].Cells[0].Value = especialidades[i].CodigoEspecialidad;
                    grd_Esp.Rows[i].Cells[1].Value = especialidades[i].NombreEspecialidad;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de especialidades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }        

        private Especialidad ObtenerDatosEspecialidad() {
            Especialidad especialidad = new Especialidad();
           
            especialidad.NombreEspecialidad = txt_Nombre_Esp.Text;           

            return especialidad;
        }        

        private bool ExisteEnGrilla(string criterioABuscar)
        {
            bool resultado = false;

            for (int i = 0; i < grd_Esp.Rows.Count; i++)
            {
                if (grd_Esp.Rows[i].Cells["Nombre"].Value.ToString().Equals(criterioABuscar, StringComparison.OrdinalIgnoreCase))
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        private void ReiniciarFormulario() {
            txt_Nombre_Esp.Text = "";
            txt_Nombre_Esp.Focus();
            btn_Editar_Esp.Enabled = false;
            btn_Eliminar_Esp.Enabled = false;
            btn_Agregar_Esp.Enabled = true;
        }

        private void CargarCampos(Especialidad especialidad) {
            txt_Nombre_Esp.Text = especialidad.NombreEspecialidad;
        }

        private void grd_Esp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
