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
            CargarCombo();
        }

        private void btn_limpiar_afiliado_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }

        private void ReiniciarFormulario()
        {
            txt_apellido_afiliado.Text = "";
            txt_apellido_afiliado.Focus();
            //txt_nombre_afiliado.Text = "";
            //dtp_fecha_nacimiento.Value = DateTime.Today;
            //cmb_tipo_afiliado.Enabled = false;
            //dtp_fecha_inscripcion.Value = DateTime.Today;
            //txt_monto_afiliado.Text = "";
            //btn_editar_afiliado.Enabled = false;
            //btn_borrar_afiliado.Enabled = false;
        }

        private void CargarCampos(Afiliado afiliado)
        {
            txt_apellido_afiliado.Text = afiliado.ApellidoAfiliado;
            txt_nombre_afiliado.Text = afiliado.NombreAfiliado;
            //dtp_fecha_nacimiento.Value = afiliado.FechaNacimientoAfiliado;
            //cmb_tipo_afiliado.SelectedIndex = afiliado.TipoAfiliadoAfiliado;
            //dtp_fecha_inscripcion.Value = afiliado.FechaInscripcionAfiliado;
            //txt_monto_afiliado.Text = afiliado.MontoInscripcionAfiliado.ToString();
        }

        private void CargarCombo()
        {
            try
            {
                cmb_tipo_afiliado.DataSource = AD_TipoAfiliado.ObtenerTipoAfiliado();
                cmb_tipo_afiliado.DisplayMember = "Descripcion";
                cmb_tipo_afiliado.ValueMember = "Id";
                cmb_tipo_afiliado.SelectedIndex = -1;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de afiliados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    grd_Afi.Rows[i].Cells[3].Value = afiliados[i].FechaNacimientoAfiliado;
                    grd_Afi.Rows[i].Cells[4].Value = afiliados[i].TipoAfiliadoAfiliado;
                    grd_Afi.Rows[i].Cells[5].Value = afiliados[i].FechaInscripcionAfiliado;
                    grd_Afi.Rows[i].Cells[6].Value = afiliados[i].MontoInscripcionAfiliado;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de afiliados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteEnGrilla(string criterioABuscar)
        {
            bool resultado = false;

            for (int i = 0; i < grd_Afi.Rows.Count; i++)
            {
                if (grd_Afi.Rows[i].Cells["Apellido"].Value.ToString().Equals(criterioABuscar, StringComparison.OrdinalIgnoreCase))
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
            //afiliado.NombreAfiliado = txt_nombre_afiliado.Text;
            
            return afiliado;
        }

        private void grd_Afi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grd_Afi.Rows[indice];

            string apellidoAfiliado = filaSeleccionada.Cells["Apellido"].Value.ToString();
            global_numeroAfiliado = int.Parse(filaSeleccionada.Cells["Nro_Afiliado"].Value.ToString());
            ReiniciarFormulario();

            btn_editar_afiliado.Enabled = true;
            btn_borrar_afiliado.Enabled = true;
            btn_agregar_afiliado.Enabled = false;

            Afiliado afiliado = new Afiliado();
            afiliado.ApellidoAfiliado = apellidoAfiliado;            

            CargarCampos(afiliado);
        }

        private void btn_agregar_afiliado_Click(object sender, EventArgs e)
        {
            if(!txt_apellido_afiliado.Text.Equals(""))
            {
                if(!ExisteEnGrilla(txt_apellido_afiliado.Text))
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
                    MessageBox.Show("Ya existe un afiliado con ese apellido...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un apellido de afiliado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
