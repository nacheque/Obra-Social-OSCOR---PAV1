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

namespace obra_social_oscor.Formulario.ABM_Procesos
{
    public partial class FrmEditarEspCentro : Form
    {
        int global_centro_para_editar;
        int global_codigo_especialidad;

        public FrmEditarEspCentro(int codigoCentro)
        {
            InitializeComponent();
            this.global_centro_para_editar = codigoCentro;
        }

        private void FrmEditarEspCentro_Load(object sender, EventArgs e)
        {
            CargarComboEspecialidades();
            CargarEspecialidadesDelCentro();
        }

        private void btn_salir_centro_esp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarEspecialidadesDelCentro() {
            grd_esp_centro_editar.Rows.Clear();
            List<EspecialidadPorCentro> especialidadesPorCentros = NE_EspecialidadPorCentro.ObtenerListadoEspecialidadesPorCentros(global_centro_para_editar);
            foreach (EspecialidadPorCentro especialidadPorCentro in especialidadesPorCentros)
            {
                grd_esp_centro_editar.Rows.Add(especialidadPorCentro.Especialidad.CodigoEspecialidad, especialidadPorCentro.Especialidad.NombreEspecialidad);
            }
        }

        private void CargarComboEspecialidades()
        {
            try
            {
                cmb_esp_centro_editar.DataSource = AD_Especialidad.ObtenerEspecialidades();
                cmb_esp_centro_editar.DisplayMember = "NOMBRE";
                cmb_esp_centro_editar.ValueMember = "COD_ESPECIALIDAD";
                cmb_esp_centro_editar.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de especialidades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_agregar_esp_centro_editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea agregar al centro la Especialidad seleccionada?", "Advertencia",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (!ExisteEnGrilla(cmb_esp_centro_editar.GetItemText(cmb_esp_centro_editar.SelectedItem)))
                {
                    EspecialidadPorCentro especialidadPorCentro = ObtenerDatosEspecialidadPorCentro();
                    try
                    {
                        NE_EspecialidadPorCentro.AgregarEspecialidadPorCentro(especialidadPorCentro);
                        MessageBox.Show("Especialidad agregada al centro con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarEspecialidadesDelCentro();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al agregar especialidad al centro...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe una especialidad con ese nombre en el centro...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }              
        }

        private bool ExisteEnGrilla(string criterioABuscar)
        {
            bool resultado = false;

            for (int i = 0; i < grd_esp_centro_editar.Rows.Count; i++)
            {
                if (grd_esp_centro_editar.Rows[i].Cells["Nombre"].Value.ToString().Equals(criterioABuscar, StringComparison.OrdinalIgnoreCase))
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        private EspecialidadPorCentro ObtenerDatosEspecialidadPorCentro()
        {
            EspecialidadPorCentro especialidadPorCentro = new EspecialidadPorCentro();

            Especialidad especialidad = new Especialidad();
            especialidad.CodigoEspecialidad = (int)cmb_esp_centro_editar.SelectedValue;

            Centro centro = new Centro();
            centro.CodigoCentro = global_centro_para_editar;

            especialidadPorCentro.Especialidad = especialidad;
            especialidadPorCentro.Centro = centro;            

            return especialidadPorCentro;
        }

        private void btn_eliminar_esp_editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar del centro la especialidad seleccionada?", "Advertencia",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    NE_EspecialidadPorCentro.EliminarEspecialidadPorCentro(global_codigo_especialidad, global_centro_para_editar);
                    MessageBox.Show("Especialidad eliminada del centro con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEspecialidadesDelCentro();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Error al eliminar especialidad.\nLa especialidad esta asociada a un Profesional o Atencion...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar especialidad del centro...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void grd_esp_centro_editar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow filaSeleccionada = grd_esp_centro_editar.Rows[indice];
                
                global_codigo_especialidad = int.Parse(filaSeleccionada.Cells["id_especialidad"].Value.ToString());                
            }
        }
    }
}
