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

namespace obra_social_oscor.Formulario.ABM
{
    public partial class frm_Centro : Form
    {
        int global_especialidad_seleccionada;
        int global_cod_centro_seleccionado;

        public frm_Centro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Centro_Load(object sender, EventArgs e)
        {
            CargarComboBarrios();
            CargarComboLocalidades();
            CargarComboEspecialidades();
            CargarComboPropio();
            CargarGrilla();
            btn_eliminar_esp.Enabled = false;
        }

        private void CargarComboBarrios()
        {
            try
            {
                cmb_barrio_centro.DataSource = AD_Barrio.ObtenerBarrios();
                cmb_barrio_centro.DisplayMember = "BARRIO";
                cmb_barrio_centro.ValueMember = "ID_BARRIO";
                cmb_barrio_centro.SelectedIndex = 0;

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
                cmb_loc_centro.DataSource = AD_Localidad.ObtenerLocalidades();
                cmb_loc_centro.DisplayMember = "LOCALIDAD";
                cmb_loc_centro.ValueMember = "ID_LOCALIDAD";
                cmb_loc_centro.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de localidades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboEspecialidades()
        {
            try
            {
                cmb_esp_centro.DataSource = AD_Especialidad.ObtenerEspecialidades();
                cmb_esp_centro.DisplayMember = "NOMBRE";
                cmb_esp_centro.ValueMember = "COD_ESPECIALIDAD";
                cmb_esp_centro.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de especialidades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboPropio()
        {       

            cmb_propio.Items.Add("SI");
            cmb_propio.Items.Add("NO");
            cmb_propio.SelectedIndex = 0;                        
        }

        private void CargarGrilla()
        {
            try
            {
                grd_centros.Rows.Clear();
                List<Centro> centros = NE_Centro.obtenerListadoCentros();

                for (int i = 0; i < centros.Count; i++)
                {
                    grd_centros.Rows.Add();
                    grd_centros.Rows[i].Cells[0].Value = centros[i].CodigoCentro;
                    grd_centros.Rows[i].Cells[1].Value = centros[i].Denominacion;
                    grd_centros.Rows[i].Cells[2].Value = centros[i].Calle;
                    grd_centros.Rows[i].Cells[3].Value = centros[i].Numero;
                    grd_centros.Rows[i].Cells[4].Value = centros[i].Barrio.IdBarrio;
                    grd_centros.Rows[i].Cells[5].Value = centros[i].Barrio.NombreBarrio;
                    grd_centros.Rows[i].Cells[6].Value = centros[i].Localidad.IdLocalidad;
                    grd_centros.Rows[i].Cells[7].Value = centros[i].Localidad.NombreLocalidad;
                    grd_centros.Rows[i].Cells[8].Value = centros[i].Telefono;
                    grd_centros.Rows[i].Cells[9].Value = centros[i].Mail;
                    grd_centros.Rows[i].Cells[10].Value = centros[i].Propio;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de centros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salir_centro_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_agregar_centro_Click(object sender, EventArgs e)
        {
            if (!txt_denom_centro.Text.Equals("") && !txt_calle_centro.Text.Equals("") &&
               !txt_nro_calle_centro.Text.Equals("") && !msk_txt_telefono_centro.Text.Equals("") && !txt_mail_centro.Text.Equals(""))
            {
                if (ExisteEspecialidadEnGrilla())
                {
                    if (Validar.IsValidEmail(txt_mail_centro.Text))
                    {
                        string mensajeError = ExisteEnGrilla(msk_txt_telefono_centro.Text, txt_denom_centro.Text, txt_mail_centro.Text,
                            txt_calle_centro.Text, txt_nro_calle_centro.Text);
                        if (mensajeError == "")
                        {
                            Centro centro = ObtenerDatosCentro();
                            List<EspecialidadPorCentro> especialidadesCentro = ObtenerDatosEspecialidadesCentroAgregar();
                            try
                            {
                                NE_Centro.AgregarCentro(centro, especialidadesCentro);
                                MessageBox.Show("Centro agregado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ReiniciarFormulario();
                                CargarGrilla();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Error al agregar Centro...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show(mensajeError, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Formato de mail invalido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Debe agregar al menos una especialidad al centro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos para dar de alta un centro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ExisteEspecialidadEnGrilla() {
            bool resultado = true;

            if (grd_esp_centro.Rows.Count == 0) {
                resultado = false;
            }

            return resultado;
        }

        private string ExisteEnGrilla(string telefono, string denominacion, string email, string calle, string numero)
        {
            string mensajeError = "";

            for (int i = 0; i < grd_centros.Rows.Count; i++)
            {
                if (grd_centros.Rows[i].Cells["telefono"].Value.ToString().Equals(telefono))
                {
                    mensajeError = "Ya existe un centro con el mismo telefono";
                    break;
                }
                else if (grd_centros.Rows[i].Cells["denominacion"].Value.ToString().Equals(denominacion))
                {
                    mensajeError = "Ya existe un centro con la misma denominacion";
                    break;
                }
                else if (grd_centros.Rows[i].Cells["mail"].Value.ToString().Equals(email))
                {
                    mensajeError = "Ya existe un centro con el mismo mail";
                    break;
                }
                else if (grd_centros.Rows[i].Cells["calle"].Value.ToString().Equals(calle, StringComparison.OrdinalIgnoreCase)
                    && grd_centros.Rows[i].Cells["numero"].Value.ToString().Equals(numero))
                {
                    mensajeError = "Ya existe un centro con esa direccion";
                    break;
                }
            }

            return mensajeError;
        }

        private Centro ObtenerDatosCentro()
        {
            Centro centro = new Centro();
            centro.Denominacion = txt_denom_centro.Text.Trim();
            centro.Calle = txt_calle_centro.Text.Trim();
            centro.Numero = int.Parse(txt_nro_calle_centro.Text.Trim());
            centro.Telefono = msk_txt_telefono_centro.Text.Trim();
            centro.Mail = txt_mail_centro.Text.Trim();
            centro.Propio = cmb_propio.GetItemText(cmb_propio.SelectedItem);            

            Barrio barrio = new Barrio();
            barrio.IdBarrio = (int) cmb_barrio_centro.SelectedValue;
            barrio.NombreBarrio = cmb_barrio_centro.GetItemText(cmb_barrio_centro.SelectedItem);

            Localidad localidad = new Localidad();
            localidad.IdLocalidad = (int) cmb_loc_centro.SelectedValue;
            localidad.NombreLocalidad = cmb_loc_centro.GetItemText(cmb_loc_centro.SelectedItem);

            centro.Barrio = barrio;
            centro.Localidad = localidad;

            return centro;
        }

        private List<EspecialidadPorCentro> ObtenerDatosEspecialidadesCentroAgregar() {
            List<EspecialidadPorCentro> especialidadesPorCentros = new List<EspecialidadPorCentro>();
            int ultimoIdCentroEnBaseDeDatos = AD_Centro.ObtenerUltimoIdCentro();

            for (int i = 0; i < grd_esp_centro.Rows.Count; i++)
            {
                EspecialidadPorCentro especialidadPorCentro = new EspecialidadPorCentro();

                Centro centro = new Centro();
                centro.CodigoCentro = ultimoIdCentroEnBaseDeDatos + 1;

                Especialidad especialidad = new Especialidad();
                especialidad.CodigoEspecialidad = int.Parse(grd_esp_centro.Rows[i].Cells["id_especialidad"].Value.ToString());

                especialidadPorCentro.Centro = centro;
                especialidadPorCentro.Especialidad = especialidad;

                especialidadesPorCentros.Add(especialidadPorCentro);
            }

            return especialidadesPorCentros;
        }

        private void ReiniciarFormulario()
        {
            txt_denom_centro.Text = "";
            txt_calle_centro.Text = "";
            txt_mail_centro.Text = "";
            msk_txt_telefono_centro.Text = "";
            txt_nro_calle_centro.Text = "";
            txt_denom_centro.Focus();
            cmb_barrio_centro.SelectedIndex = 0;
            cmb_loc_centro.SelectedIndex = 0;
            cmb_propio.SelectedIndex = 0;
            btn_eliminar_esp.Enabled = false;
            grd_esp_centro.Rows.Clear();            
        }

        private void btn_agregar_esp_centro_Click(object sender, EventArgs e)
        {
            if (!ExisteEspecialidadEnGrilla(cmb_esp_centro.GetItemText(cmb_esp_centro.SelectedItem)))
            {
                grd_esp_centro.Rows.Add(cmb_esp_centro.SelectedValue, cmb_esp_centro.GetItemText(cmb_esp_centro.SelectedItem));
            }
            else
            {
                MessageBox.Show("Ya existe esa especialidad en la grilla", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                                   
        }

        private bool ExisteEspecialidadEnGrilla(string nombre)            
        {
            bool resultado = false;

            for (int i = 0; i < grd_esp_centro.Rows.Count; i++)
            {
                if (grd_esp_centro.Rows[i].Cells["nombre"].Value.ToString().Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    resultado = true;
                    break;
                }
                
            }

            return resultado;
        }

        private void btn_limpiar_centro_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }

        private void grd_esp_centro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            global_especialidad_seleccionada = e.RowIndex;
            btn_eliminar_esp.Enabled = true;
        }

        private void btn_eliminar_esp_Click(object sender, EventArgs e)
        {
            if (grd_esp_centro.Rows.Count > 0 && (grd_esp_centro.Rows.Count - 1) >= global_especialidad_seleccionada && global_especialidad_seleccionada >= 0)
            {
                DataGridViewRow filaSeleccionada = grd_esp_centro.Rows[global_especialidad_seleccionada];
                grd_esp_centro.Rows.Remove(filaSeleccionada);
            }
            else {
                MessageBox.Show("Debe seleccionar una especialidad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_denom_centro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txt_calle_centro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txt_nro_calle_centro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void grd_centros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow filaSeleccionada = grd_centros.Rows[indice];

                global_cod_centro_seleccionado = int.Parse(filaSeleccionada.Cells["cod_centro"].Value.ToString());
                ReiniciarFormulario();

                btn_eliminar_esp.Enabled = true;                

                Centro centro = new Centro();
                centro.CodigoCentro = int.Parse(filaSeleccionada.Cells["cod_centro"].Value.ToString());
                centro.Denominacion = filaSeleccionada.Cells["denominacion"].Value.ToString();
                centro.Calle = filaSeleccionada.Cells["calle"].Value.ToString();
                centro.Numero = int.Parse(filaSeleccionada.Cells["numero"].Value.ToString());
                centro.Telefono = filaSeleccionada.Cells["telefono"].Value.ToString();
                centro.Mail = filaSeleccionada.Cells["mail"].Value.ToString();
                centro.Propio = filaSeleccionada.Cells["propio"].Value.ToString();

                Barrio barrio = new Barrio();
                barrio.IdBarrio = int.Parse(filaSeleccionada.Cells["id_barrio"].Value.ToString());
                barrio.NombreBarrio = filaSeleccionada.Cells["barrio"].Value.ToString();

                Localidad localidad = new Localidad();
                localidad.IdLocalidad = int.Parse(filaSeleccionada.Cells["id_localidad"].Value.ToString());
                localidad.NombreLocalidad = filaSeleccionada.Cells["localidad"].Value.ToString();

                centro.Barrio = barrio;
                centro.Localidad = localidad;

                List<EspecialidadPorCentro> especialidadesPorCentro = NE_EspecialidadPorCentro.ObtenerListadoEspecialidadesPorCentros(centro.CodigoCentro);
                
                CargarCampos(centro, especialidadesPorCentro);
            }            
        }

        private void CargarCampos(Centro centro, List<EspecialidadPorCentro> especialidadesPorCentros)
        {
            txt_denom_centro.Text = centro.Denominacion;
            txt_calle_centro.Text = centro.Calle;
            txt_nro_calle_centro.Text = centro.Numero.ToString();
            msk_txt_telefono_centro.Text = centro.Telefono;
            txt_mail_centro.Text = centro.Mail;
            cmb_barrio_centro.SelectedValue = centro.Barrio.IdBarrio;
            cmb_loc_centro.SelectedValue = centro.Localidad.IdLocalidad;
            cmb_propio.SelectedIndex = cmb_propio.Items.IndexOf(centro.Propio);
            
            foreach (EspecialidadPorCentro especialidadPorCentro in especialidadesPorCentros)
            {
                grd_esp_centro.Rows.Add(especialidadPorCentro.Especialidad.CodigoEspecialidad, especialidadPorCentro.Especialidad.NombreEspecialidad);
            }            
        }
    }
}
