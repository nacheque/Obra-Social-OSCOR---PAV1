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
    public partial class frm_Afiliado : Form
    {
        int global_numeroAfiliado;
        public frm_Afiliado()
        {
            InitializeComponent();
        }

        private void btn_salir_afiliado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Afiliado_Load(object sender, EventArgs e)
        {
            btn_editar_afiliado.Enabled = false;
            btn_borrar_afiliado.Enabled = false;
            CargarGrilla();
            CargarComboTipoAfiliados();
        }        

        private void ReiniciarFormulario()
        {
            txt_apellido_afiliado.Text = "";
            txt_nombre_afiliado.Text = "";
            txt_monto_afiliado.Text = "";
            txt_apellido_afiliado.Focus();            
            dtp_fecha_nacimiento.Value = new DateTime(1990, 01, 01);
            cmb_tipo_afiliado.SelectedIndex = 0;           
            btn_editar_afiliado.Enabled = false;
            btn_borrar_afiliado.Enabled = false;
            btn_agregar_afiliado.Enabled = true;
        }

        private void CargarCampos(Afiliado afiliado)
        {
            txt_apellido_afiliado.Text = afiliado.ApellidoAfiliado;
            txt_nombre_afiliado.Text = afiliado.NombreAfiliado;
            dtp_fecha_nacimiento.Value = afiliado.FechaNacimientoAfiliado;
            cmb_tipo_afiliado.SelectedValue = afiliado.TipoAfiliado.CodigoTipoAfiliado;
            txt_monto_afiliado.Text = afiliado.MontoInscripcionAfiliado.ToString();
        }

        private void CargarComboTipoAfiliados()
        {
            try
            {
                cmb_tipo_afiliado.DataSource = AD_TipoAfiliado.ObtenerTipoAfiliado();
                cmb_tipo_afiliado.DisplayMember = "DESCRIPCION";
                cmb_tipo_afiliado.ValueMember = "COD_TIPO";
                cmb_tipo_afiliado.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de tipos de afiliados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrilla()
        {
            try
            {
                grd_Afi.Rows.Clear();
                List<Afiliado> afiliados = Ne_Afiliado.obtenerListadoAfiliado();
                
                for (int i = 0; i < afiliados.Count; i++)
                {
                    grd_Afi.Rows.Add();
                    grd_Afi.Rows[i].Cells[0].Value = afiliados[i].NumeroAfiliado;
                    grd_Afi.Rows[i].Cells[1].Value = afiliados[i].ApellidoAfiliado;
                    grd_Afi.Rows[i].Cells[2].Value = afiliados[i].NombreAfiliado;
                    grd_Afi.Rows[i].Cells[3].Value = afiliados[i].FechaNacimientoAfiliado.Date.ToShortDateString();
                    grd_Afi.Rows[i].Cells[4].Value = afiliados[i].FechaInscripcionAfiliado.Date.ToShortDateString();
                    grd_Afi.Rows[i].Cells[5].Value = afiliados[i].MontoInscripcionAfiliado;
                    grd_Afi.Rows[i].Cells[6].Value = afiliados[i].TipoAfiliado.DescripcionTipoAfiliado;
                    grd_Afi.Rows[i].Cells[7].Value = afiliados[i].TipoAfiliado.CodigoTipoAfiliado;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de afiliados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteEnGrilla(string nombre, string apellido, string fechaNacimiento)
        {
            bool resultado = false;

            for (int i = 0; i < grd_Afi.Rows.Count; i++)
            {
                if (grd_Afi.Rows[i].Cells["Nombre"].Value.ToString().Equals(nombre, StringComparison.OrdinalIgnoreCase) 
                    && grd_Afi.Rows[i].Cells["Apellido"].Value.ToString().Equals(apellido, StringComparison.OrdinalIgnoreCase)
                    && grd_Afi.Rows[i].Cells["fecha_nacimiento"].Value.ToString().Equals(fechaNacimiento, StringComparison.OrdinalIgnoreCase))
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        private bool ExisteEnGrillaEditar(string nombre, string apellido, string fechaNacimiento, float monto, int id_tipo_afiliado)
        {
            bool resultado = false;

            for (int i = 0; i < grd_Afi.Rows.Count; i++)
            {
                if (grd_Afi.Rows[i].Cells["Nombre"].Value.ToString().Equals(nombre, StringComparison.OrdinalIgnoreCase)
                    && grd_Afi.Rows[i].Cells["Apellido"].Value.ToString().Equals(apellido, StringComparison.OrdinalIgnoreCase)
                    && grd_Afi.Rows[i].Cells["fecha_nacimiento"].Value.ToString().Equals(fechaNacimiento, StringComparison.OrdinalIgnoreCase)
                    && float.Parse(grd_Afi.Rows[i].Cells["monto_inscripcion"].Value.ToString()) == monto
                    && int.Parse(grd_Afi.Rows[i].Cells["CodigoTipoAfiliado"].Value.ToString()) == id_tipo_afiliado)
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        private Afiliado ObtenerDatosAfiliado()
        {
            Afiliado afiliado = new Afiliado();
            afiliado.ApellidoAfiliado = txt_apellido_afiliado.Text;
            afiliado.NombreAfiliado = txt_nombre_afiliado.Text;
            afiliado.FechaNacimientoAfiliado = dtp_fecha_nacimiento.Value;
            afiliado.MontoInscripcionAfiliado = float.Parse(txt_monto_afiliado.Text);

            TipoAfiliado tipoAfiliado = new TipoAfiliado();
            tipoAfiliado.CodigoTipoAfiliado = (int) cmb_tipo_afiliado.SelectedValue;
            tipoAfiliado.DescripcionTipoAfiliado = cmb_tipo_afiliado.SelectedItem.ToString();

            afiliado.TipoAfiliado = tipoAfiliado;
            
            return afiliado;
        }

        private void grd_Afi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grd_Afi.Rows[indice];

            global_numeroAfiliado = int.Parse(filaSeleccionada.Cells["Nro_Afiliado"].Value.ToString());
            ReiniciarFormulario();

            btn_editar_afiliado.Enabled = true;
            btn_borrar_afiliado.Enabled = true;
            btn_agregar_afiliado.Enabled = false;

            Afiliado afiliado = new Afiliado();
            afiliado.ApellidoAfiliado = filaSeleccionada.Cells["Apellido"].Value.ToString();
            afiliado.NombreAfiliado = filaSeleccionada.Cells["nombre"].Value.ToString();
            afiliado.FechaNacimientoAfiliado = DateTime.Parse(filaSeleccionada.Cells["fecha_nacimiento"].Value.ToString());
            afiliado.MontoInscripcionAfiliado = float.Parse(filaSeleccionada.Cells["monto_inscripcion"].Value.ToString());

            TipoAfiliado tipoAfiliado = new TipoAfiliado();
            tipoAfiliado.CodigoTipoAfiliado = int.Parse(filaSeleccionada.Cells["CodigoTipoAfiliado"].Value.ToString());
            tipoAfiliado.DescripcionTipoAfiliado = filaSeleccionada.Cells["tipo_afiliado"].Value.ToString();

            afiliado.TipoAfiliado = tipoAfiliado;

            CargarCampos(afiliado);
        }

        private void btn_agregar_afiliado_Click(object sender, EventArgs e)
        {
            if(!txt_apellido_afiliado.Text.Equals("") && !txt_nombre_afiliado.Text.Equals("") && 
                !txt_monto_afiliado.Text.Equals("") && !dtp_fecha_nacimiento.Text.Equals("") && cmb_tipo_afiliado.SelectedIndex != -1)
            {
                if(!ExisteEnGrilla(txt_nombre_afiliado.Text, txt_apellido_afiliado.Text, dtp_fecha_nacimiento.Value.Date.ToShortDateString()))
                {
                    Afiliado afiliado = ObtenerDatosAfiliado();
                    
                    try
                    {
                        Ne_Afiliado.AgregarAfiliado(afiliado);
                        MessageBox.Show("Afiliado agregado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReiniciarFormulario();
                        CargarGrilla();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error al agregar Afiliado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un afiliado con el mismo nombre, apellido y fecha de nacimiento...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos para dar de alta un afiliado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_limpiar_afiliado_Click_1(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }

        private void txt_apellido_afiliado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txt_nombre_afiliado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txt_monto_afiliado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void btn_editar_afiliado_Click(object sender, EventArgs e)
        {
            if (!txt_apellido_afiliado.Text.Equals("") && !txt_nombre_afiliado.Text.Equals("") &&
                !txt_monto_afiliado.Text.Equals("") && !dtp_fecha_nacimiento.Text.Equals("") && cmb_tipo_afiliado.SelectedIndex != -1)
            {
                if (!ExisteEnGrillaEditar(txt_nombre_afiliado.Text, txt_apellido_afiliado.Text, dtp_fecha_nacimiento.Value.Date.ToShortDateString(),
                    float.Parse(txt_monto_afiliado.Text), (int) cmb_tipo_afiliado.SelectedValue))
                {
                    Afiliado afiliado = ObtenerDatosAfiliado();

                    try
                    {
                        Ne_Afiliado.ActualizarAfiliado(afiliado, global_numeroAfiliado);
                        MessageBox.Show("Afiliado actualizado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReiniciarFormulario();
                        CargarGrilla();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al actualizar Afiliado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un afiliado con el mismo nombre, apellido y fecha de nacimiento...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos para dar de alta un afiliado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_borrar_afiliado_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el afiliado seleccionado?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Ne_Afiliado.EliminarAfiliado(global_numeroAfiliado);
                    MessageBox.Show("Afiliado eliminado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReiniciarFormulario();
                    CargarGrilla();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Error al eliminar afiliado.\nEl mismo se encuentra asociado a atenciones o cuotas pagas...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar afiliado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
