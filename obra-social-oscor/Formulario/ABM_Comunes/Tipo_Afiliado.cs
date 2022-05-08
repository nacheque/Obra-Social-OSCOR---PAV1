using obra_social_oscor.Helpers;
using obra_social_oscor.Entidades;
using obra_social_oscor.AccesoADatos;
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
    public partial class frm_Tipo_Afiliado : Form
    {
        int global_codigoTipo;

        public frm_Tipo_Afiliado()
        {
            InitializeComponent();
        }

        private void btn_Salir_Tipo_Afiliado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Tipo_Afiliado_Load(object sender, EventArgs e)
        {
            btn_Editar_Tipo_Afiliado.Enabled = false;
            btn_Eliminar_Tipo_Afiliado.Enabled = false;
            CargarGrilla();
        }

        private void btn_Limpiar_Tipo_Afiliado_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }

        private void txt_Nombre_Tipo_Afiliado_TextChanged(object sender, EventArgs e)
        {
            //Validar.SoloLetras(e);
        }

        private void CargarGrilla()
        {
            try
            {
                grd_Tipo_Afiliado.Rows.Clear();
                List<TipoAfiliado> tipoAfiliados = Ne_TipoAfiliado.ObtenerListadoTipoAfiliado();
                for (int i = 0; i < tipoAfiliados.Count; i++)
                {
                    grd_Tipo_Afiliado.Rows.Add();
                    grd_Tipo_Afiliado.Rows[i].Cells[0].Value = tipoAfiliados[i].CodigoTipoAfiliado;
                    grd_Tipo_Afiliado.Rows[i].Cells[1].Value = tipoAfiliados[i].DescripcionTipoAfiliado;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de tipo de afiliado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private TipoAfiliado ObtenerDatosTipoAfiliado()
        {
            TipoAfiliado tipoAfiliado = new TipoAfiliado();
            tipoAfiliado.DescripcionTipoAfiliado = txt_Nombre_Tipo_Afiliado.Text;
            
            return tipoAfiliado;
        }

        private bool ExisteEnGrilla(string criterioABuscar)
        {
            bool resultado = false;

            for (int i = 0; i < grd_Tipo_Afiliado.Rows.Count; i++)
            {
                if (grd_Tipo_Afiliado.Rows[i].Cells["Descripcion"].Value.ToString().Equals(criterioABuscar, StringComparison.OrdinalIgnoreCase))
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        private void ReiniciarFormulario()
        {
            txt_Nombre_Tipo_Afiliado.Text = "";
            txt_Nombre_Tipo_Afiliado.Focus();
            btn_Editar_Tipo_Afiliado.Enabled = false;
            btn_Eliminar_Tipo_Afiliado.Enabled = false;
            btn_Agregar_Tipo_Afiliado.Enabled = true;            
        }

        private void CargarCampos(TipoAfiliado tipoAfiliado)
        {
            txt_Nombre_Tipo_Afiliado.Text = tipoAfiliado.DescripcionTipoAfiliado;            
        }

        private void grd_Tipo_Afiliado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grd_Tipo_Afiliado.Rows[indice];

            string nombreTipoAfiliado = filaSeleccionada.Cells["Descripcion"].Value.ToString();
            global_codigoTipo = int.Parse(filaSeleccionada.Cells["Codigo"].Value.ToString());
            ReiniciarFormulario();

            btn_Editar_Tipo_Afiliado.Enabled = true;
            btn_Eliminar_Tipo_Afiliado.Enabled = true;
            btn_Agregar_Tipo_Afiliado.Enabled = false;

            TipoAfiliado tipoAfiliado = new TipoAfiliado();
            tipoAfiliado.DescripcionTipoAfiliado = nombreTipoAfiliado;
            
            CargarCampos(tipoAfiliado);
        }
        
        private void btn_Agregar_Tipo_Afiliado_Click(object sender, EventArgs e)
        {
            if (!txt_Nombre_Tipo_Afiliado.Text.Equals(""))
            {
                if (!ExisteEnGrilla(txt_Nombre_Tipo_Afiliado.Text))
                {
                    TipoAfiliado tipoAfiliado = ObtenerDatosTipoAfiliado();
                    try
                    {
                        Ne_TipoAfiliado.AgregarTipoAfiliado(tipoAfiliado);
                        MessageBox.Show("Tipo de afiliado agregada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReiniciarFormulario();
                        CargarGrilla();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error al agregar tipo de afiliado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe una tipo afiliado con ese nombre...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de tipo de afiliado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Editar_Tipo_Afiliado_Click(object sender, EventArgs e)
        {
            if (!txt_Nombre_Tipo_Afiliado.Text.Equals(""))
            {
                if (!ExisteEnGrilla(txt_Nombre_Tipo_Afiliado.Text))
                {
                    TipoAfiliado tipoAfiliado = ObtenerDatosTipoAfiliado();
                    try
                    {
                        Ne_TipoAfiliado.ActualizarTipoAfiliado(tipoAfiliado, global_codigoTipo);
                        MessageBox.Show("Tipo de afiliado actualizada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReiniciarFormulario();
                        CargarGrilla();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error al actualizar tipo de afiliado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe una tipo de afiliado con ese nombre...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de tipo de afiliado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Eliminar_Tipo_Afiliado_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar la tipo de afiliado seleccionada?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    NE_Especialidad.EliminarEspecialidad(global_codigoTipo);
                    MessageBox.Show("Tipo de afiliado eliminada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReiniciarFormulario();
                    CargarGrilla();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Error al eliminar tipo de afiliado.\nLa especialidad esta asociada a un Centro...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar tipo de afiliado...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
