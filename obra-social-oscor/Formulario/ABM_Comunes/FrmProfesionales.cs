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
    public partial class FrmProfesionales : Form
    {
        int global_matriculaProfesional;

        public FrmProfesionales()
        {
            InitializeComponent();
        }

        private void btn_salir_profesional_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grp_box_profesionales_Enter(object sender, EventArgs e)
        {

        }

        private void FrmProfesionales_Load(object sender, EventArgs e)
        {
            btn_editar_profesional.Enabled = false;
            btn_borrar_profesional.Enabled = false;
            CargarGrilla();
            CargarComboBarrios();
            CargarComboLocalidades();
        }

        private void CargarGrilla() {
            try
            {
                grd_Profesionales.Rows.Clear();
                List<Profesional> profesionales = NE_Profesional.obtenerListadoProfesionales();

                for (int i = 0; i < profesionales.Count; i++)
                {
                    grd_Profesionales.Rows.Add();
                    grd_Profesionales.Rows[i].Cells[0].Value = profesionales[i].Matricula;
                    grd_Profesionales.Rows[i].Cells[1].Value = profesionales[i].Apellido;
                    grd_Profesionales.Rows[i].Cells[2].Value = profesionales[i].Nombre;
                    grd_Profesionales.Rows[i].Cells[3].Value = profesionales[i].Calle;
                    grd_Profesionales.Rows[i].Cells[4].Value = profesionales[i].NumeroCalle;
                    grd_Profesionales.Rows[i].Cells[5].Value = profesionales[i].Barrio.NombreBarrio;
                    grd_Profesionales.Rows[i].Cells[6].Value = profesionales[i].Barrio.IdBarrio;
                    grd_Profesionales.Rows[i].Cells[7].Value = profesionales[i].Localidad.NombreLocalidad;
                    grd_Profesionales.Rows[i].Cells[8].Value = profesionales[i].Localidad.IdLocalidad;
                    grd_Profesionales.Rows[i].Cells[9].Value = profesionales[i].Telefono;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de profesionales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboBarrios()
        {
            try
            {
                cmb_barrios_prof.DataSource = AD_Barrio.ObtenerBarrios();
                cmb_barrios_prof.DisplayMember = "BARRIO";
                cmb_barrios_prof.ValueMember = "ID_BARRIO";
                cmb_barrios_prof.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de barrios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboLocalidades()
        {
            try
            {
                cmb_localidad_prof.DataSource = AD_Localidad.ObtenerLocalidades();
                cmb_localidad_prof.DisplayMember = "LOCALIDAD";
                cmb_localidad_prof.ValueMember = "ID_LOCALIDAD";
                cmb_localidad_prof.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de barrios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_agregar_profesional_Click(object sender, EventArgs e)
        {
            if (!txt_apellido_profesional.Text.Equals("") && !txt_nombre_profesional.Text.Equals("") &&
               !txt_calle_profesional.Text.Equals("") && !txt_nro_calle_prof.Text.Equals("") && !msk_txt_telefono_prof.Text.Equals(""))
            {
                string mensajeError = ExisteEnGrilla(txt_calle_profesional.Text, txt_nro_calle_prof.Text, msk_txt_telefono_prof.Text);
                if (mensajeError == "")
                {
                    Profesional profesional = ObtenerDatosProfesional();
                    try
                    {
                        NE_Profesional.AgregarProfesional(profesional);
                        MessageBox.Show("Profesional agregado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReiniciarFormulario();
                        CargarGrilla();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error al agregar Profesional...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(mensajeError, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos para dar de alta un profesional", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private string ExisteEnGrilla(string calle, string numeroCalle, string telefono)
        {
            string mensajeError = "";

            for (int i = 0; i < grd_Profesionales.Rows.Count; i++)
            {
                if (grd_Profesionales.Rows[i].Cells["telefono"].Value.ToString().Equals(telefono))
                {
                    mensajeError = "Ya existe un profesional con el mismo telefono";
                    break;
                }
                else if (grd_Profesionales.Rows[i].Cells["Calle"].Value.ToString().Equals(calle, StringComparison.OrdinalIgnoreCase)
                    && grd_Profesionales.Rows[i].Cells["nro_calle"].Value.ToString().Equals(numeroCalle))
                {
                    mensajeError = "Ya existe un profesional con esa direccion";
                    break;
                }
            }

            return mensajeError;
        }

        private string ExisteEnGrillaEditar(string calle, string numeroCalle, string telefono, int matricula)
        {
            string mensajeError = "";

            for (int i = 0; i < grd_Profesionales.Rows.Count; i++)
            {
                if (int.Parse(grd_Profesionales.Rows[i].Cells["matricula"].Value.ToString()) == matricula) {
                    continue;
                }
                if (grd_Profesionales.Rows[i].Cells["telefono"].Value.ToString().Equals(telefono))
                {
                    mensajeError = "Ya existe un profesional con el mismo telefono";
                    break;
                }
                else if (grd_Profesionales.Rows[i].Cells["Calle"].Value.ToString().Equals(calle, StringComparison.OrdinalIgnoreCase)
                    && grd_Profesionales.Rows[i].Cells["nro_calle"].Value.ToString().Equals(numeroCalle))
                {
                    mensajeError = "Ya existe un profesional con esa direccion";
                    break;
                }
            }

            return mensajeError;
        }

        private Profesional ObtenerDatosProfesional()
        {
            Profesional profesional = new Profesional();
            profesional.Apellido = txt_apellido_profesional.Text;
            profesional.Nombre = txt_nombre_profesional.Text;
            profesional.Calle = txt_calle_profesional.Text;
            profesional.NumeroCalle = int.Parse(txt_nro_calle_prof.Text);
            profesional.Telefono = msk_txt_telefono_prof.Text;

            Barrio barrio = new Barrio();
            barrio.IdBarrio = (int)cmb_barrios_prof.SelectedValue;
            barrio.NombreBarrio = cmb_barrios_prof.SelectedItem.ToString();

            Localidad localidad = new Localidad();
            localidad.IdLocalidad = (int)cmb_localidad_prof.SelectedValue;
            localidad.NombreLocalidad = cmb_localidad_prof.SelectedItem.ToString();

            profesional.Barrio = barrio;
            profesional.Localidad = localidad;

            return profesional;
        }

        private void ReiniciarFormulario()
        {
            txt_apellido_profesional.Text = "";
            txt_nombre_profesional.Text = "";
            txt_calle_profesional.Text = "";
            txt_nro_calle_prof.Text = "";
            msk_txt_telefono_prof.Text = "";
            txt_apellido_profesional.Focus();
            cmb_barrios_prof.SelectedIndex = 0;
            cmb_localidad_prof.SelectedIndex = 0;
            btn_editar_profesional.Enabled = false;
            btn_borrar_profesional.Enabled = false;
            btn_agregar_profesional.Enabled = true;
        }

        private void btn_limpiar_profesional_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }

        private void txt_apellido_profesional_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txt_nombre_profesional_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txt_calle_profesional_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txt_nro_calle_prof_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void grd_Profesionales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow filaSeleccionada = grd_Profesionales.Rows[indice];

                global_matriculaProfesional = int.Parse(filaSeleccionada.Cells["matricula"].Value.ToString());
                ReiniciarFormulario();

                btn_editar_profesional.Enabled = true;
                btn_borrar_profesional.Enabled = true;
                btn_agregar_profesional.Enabled = false;

                Profesional profesional = new Profesional();
                profesional.Apellido = filaSeleccionada.Cells["Apellido"].Value.ToString();
                profesional.Nombre = filaSeleccionada.Cells["nombre"].Value.ToString();
                profesional.Calle = filaSeleccionada.Cells["calle"].Value.ToString();
                profesional.NumeroCalle = int.Parse(filaSeleccionada.Cells["nro_calle"].Value.ToString());
                profesional.Telefono = filaSeleccionada.Cells["telefono"].Value.ToString();

                Barrio barrio = new Barrio();
                barrio.IdBarrio = int.Parse(filaSeleccionada.Cells["id_barrio"].Value.ToString());
                barrio.NombreBarrio = filaSeleccionada.Cells["barrio"].Value.ToString();

                Localidad localidad = new Localidad();
                localidad.IdLocalidad = int.Parse(filaSeleccionada.Cells["id_localidad"].Value.ToString());
                localidad.NombreLocalidad = filaSeleccionada.Cells["localidad"].Value.ToString();

                profesional.Barrio = barrio;
                profesional.Localidad = localidad;

                CargarCampos(profesional);
            }
        }

        private void CargarCampos(Profesional profesional)
        {
            txt_apellido_profesional.Text = profesional.Apellido;
            txt_nombre_profesional.Text = profesional.Nombre;
            txt_calle_profesional.Text = profesional.Calle;
            txt_nro_calle_prof.Text = profesional.NumeroCalle.ToString();
            cmb_barrios_prof.SelectedValue = profesional.Barrio.IdBarrio;
            cmb_localidad_prof.SelectedValue = profesional.Localidad.IdLocalidad;
            msk_txt_telefono_prof.Text = profesional.Telefono;
        }

        private void btn_borrar_profesional_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el profesional seleccionado?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    NE_Profesional.EliminarProfesional(global_matriculaProfesional);
                    MessageBox.Show("Profesional eliminado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReiniciarFormulario();
                    CargarGrilla();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Error al eliminar profesional.\nEl mismo se encuentra asociado a atenciones o a centros...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar profesional...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_editar_profesional_Click(object sender, EventArgs e)
        {
            if (!txt_apellido_profesional.Text.Equals("") && !txt_nombre_profesional.Text.Equals("") &&
               !txt_calle_profesional.Text.Equals("") && !txt_nro_calle_prof.Text.Equals("") && !msk_txt_telefono_prof.Text.Equals(""))
            {
                string mensajeError = ExisteEnGrillaEditar(txt_calle_profesional.Text, txt_nro_calle_prof.Text, msk_txt_telefono_prof.Text, global_matriculaProfesional);
                if (mensajeError == "")
                {
                    Profesional profesional = ObtenerDatosProfesional();
                    try
                    {
                        NE_Profesional.EditarProfesional(profesional, global_matriculaProfesional);
                        MessageBox.Show("Profesional editado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReiniciarFormulario();
                        CargarGrilla();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error al editar Profesional...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(mensajeError, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos para editar un profesional", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
