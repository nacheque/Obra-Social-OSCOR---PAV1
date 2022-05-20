using obra_social_oscor.AccesoADatos;
using obra_social_oscor.Entidades;
using obra_social_oscor.Negocio;
using obra_social_oscor.Helpers;
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
    public partial class FrmCobertura : Form
    {
        public FrmCobertura()
        {
            InitializeComponent();
        }

        private void btn_salir_cobertura_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCobertura_Load(object sender, EventArgs e)
        {
            btn_editar_cobertura.Enabled = false;
            btn_borrar_cobertura.Enabled = false;
            CargarGrilla();
            CargarComboTipoAfiliados();
            CargarComboPractica();
        }

        private void CargarComboTipoAfiliados()
        {
            try
            {
                cmb_tipo_afiliado.DataSource = AD_TipoAfiliado.ObtenerTipoAfiliado();
                cmb_tipo_afiliado.DisplayMember = "DESCRIPCION";
                cmb_tipo_afiliado.ValueMember = "COD_TIPO";
                cmb_tipo_afiliado.SelectedIndex = -1;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de tipos de afiliados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboPractica()
        {
            try
            {
                cmb_practica.DataSource = AD_Practica.obtenerPracticas();
                cmb_practica.DisplayMember = "DESCRIPCION";
                cmb_practica.ValueMember = "ID_PRACTICA";
                cmb_practica.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de tipos de practicas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrilla()
        {
            try
            {
                grd_cobertura.Rows.Clear();
                List<Cobertura> coberturas = NE_Cobertura.obtenerListadoCobertura();

                for (int i = 0; i < coberturas.Count; i++)
                {
                    grd_cobertura.Rows.Add();
                    grd_cobertura.Rows[i].Cells[0].Value = coberturas[i].TipoAfiliado.CodigoTipoAfiliado;
                    grd_cobertura.Rows[i].Cells[1].Value = coberturas[i].TipoAfiliado.DescripcionTipoAfiliado;
                    grd_cobertura.Rows[i].Cells[2].Value = coberturas[i].Practica.CodigoPractica;
                    grd_cobertura.Rows[i].Cells[3].Value = coberturas[i].Practica.DescripcionPractica;
                    grd_cobertura.Rows[i].Cells[4].Value = coberturas[i].Practica.PrecioPractica;
                    grd_cobertura.Rows[i].Cells[5].Value = coberturas[i].Porcentaje;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de coberturas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReiniciarFormulario()
        {
            cmb_tipo_afiliado.SelectedIndex = -1;
            cmb_practica.SelectedIndex = -1;
            txtPorcCobertura.Text = "";
            btn_editar_cobertura.Enabled = false;
            btn_borrar_cobertura.Enabled = false;
            btn_agregar_cobertura.Enabled = true;
            if (cmb_tipo_afiliado.Enabled == false && cmb_practica.Enabled == false)
            {
                cmb_tipo_afiliado.Enabled = true;
                cmb_practica.Enabled = true;
            }
        }

        private void btn_limpiar_cobertura_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }

        private void CargarCampos(Cobertura cobertura)
        {
            cmb_tipo_afiliado.SelectedValue = cobertura.TipoAfiliado.CodigoTipoAfiliado;
            cmb_practica.SelectedValue = cobertura.Practica.CodigoPractica;
            txtPorcCobertura.Text = cobertura.Porcentaje.ToString();            
        }

        private bool ExisteEnGrilla(string id_tipo_afiliado, string id_practica)
        {
            bool resultado = false;

            for (int i = 0; i < grd_cobertura.Rows.Count; i++)
            {
                if (grd_cobertura.Rows[i].Cells["CodigoTipoAfiliado"].Value.ToString() == id_tipo_afiliado
                    && grd_cobertura.Rows[i].Cells["CodigoPractica"].Value.ToString() == id_practica)
                {
                    resultado = true;
                    break;
                }
            }
            
            return resultado;
        }

        private bool ExisteEnGrillaEditar(string id_tipo_afiliado, string id_practica, int porcentaje)
        {
            bool resultado = false;

            for (int i = 0; i < grd_cobertura.Rows.Count; i++)
            {
                if (grd_cobertura.Rows[i].Cells["CodigoTipoAfiliado"].Value.ToString() == id_tipo_afiliado
                    && grd_cobertura.Rows[i].Cells["CodigoPractica"].Value.ToString() == id_practica
                    && int.Parse(grd_cobertura.Rows[i].Cells["Porcentaje"].Value.ToString()) == porcentaje)
                {
                    resultado = true;                    
                    break;
                }
            }            
            return resultado;
        }

        private Cobertura ObtenerDatosCobertura()
        {
            Cobertura cobertura = new Cobertura();
            TipoAfiliado tipoAfiliado = new TipoAfiliado();
            tipoAfiliado.CodigoTipoAfiliado = (int)cmb_tipo_afiliado.SelectedValue;
            tipoAfiliado.DescripcionTipoAfiliado = cmb_tipo_afiliado.SelectedText;
            cobertura.TipoAfiliado = tipoAfiliado;
            Practica practica = new Practica();
            practica.CodigoPractica = (int)cmb_practica.SelectedValue;
            practica.DescripcionPractica = cmb_practica.SelectedText;
            cobertura.Practica = practica;
            cobertura.Porcentaje = int.Parse(txtPorcCobertura.Text);

            return cobertura;
        }

        private void grd_cobertura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grd_cobertura.Rows[indice];

            //global_numeroCobertura = int.Parse(filaSeleccionada.Cells["id_tipo_Afiliado"].Value.ToString());
            ReiniciarFormulario();

            btn_editar_cobertura.Enabled = true;
            btn_borrar_cobertura.Enabled = true;
            btn_agregar_cobertura.Enabled = false;

            Cobertura cobertura = new Cobertura();
            TipoAfiliado tipoAfiliado = new TipoAfiliado();
            tipoAfiliado.CodigoTipoAfiliado = int.Parse(filaSeleccionada.Cells["CodigoTipoAfiliado"].Value.ToString());
            tipoAfiliado.DescripcionTipoAfiliado = filaSeleccionada.Cells["DescripcionTipoAfiliado"].Value.ToString();
            cobertura.TipoAfiliado = tipoAfiliado;
            Practica practica = new Practica();
            practica.CodigoPractica = int.Parse(filaSeleccionada.Cells["CodigoPractica"].Value.ToString());
            practica.DescripcionPractica = filaSeleccionada.Cells["DescripcionPractica"].Value.ToString();
            cobertura.Practica = practica;
            cobertura.Porcentaje = int.Parse(filaSeleccionada.Cells["Porcentaje"].Value.ToString());

            CargarCampos(cobertura);
            bloquearComboBox();
        }

        private void btn_agregar_cobertura_Click(object sender, EventArgs e)
        {
            if (cmb_tipo_afiliado.SelectedIndex != -1 && cmb_practica.SelectedIndex != -1 && txtPorcCobertura.Text != "")
            {
                if (int.Parse(txtPorcCobertura.Text) >= 0 && int.Parse(txtPorcCobertura.Text) <= 100)
                {
                    if (!ExisteEnGrilla(cmb_tipo_afiliado.SelectedValue.ToString(), cmb_practica.SelectedValue.ToString()))
                    {
                        Cobertura cobertura = ObtenerDatosCobertura();
                        try
                        {
                            NE_Cobertura.AgregarCobertura(cobertura);
                            MessageBox.Show("Cobertura agregada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReiniciarFormulario();
                            CargarGrilla();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Error al agregar a la Cobertura...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe la cobertura que desea agregar");
                    }
                }
                else
                {
                    MessageBox.Show("El porcentaje que desea ingresar no es correcto, por favor ingrese un valor entre 0 y 100", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos para dar de alta una cobertura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_editar_cobertura_Click(object sender, EventArgs e)
        {
            if (cmb_tipo_afiliado.SelectedIndex != -1 && cmb_practica.SelectedIndex != -1 && txtPorcCobertura.Text != "")
            {
                if (int.Parse(txtPorcCobertura.Text) >= 0 && int.Parse(txtPorcCobertura.Text) <= 100)
                {
                    if (!ExisteEnGrillaEditar(cmb_tipo_afiliado.SelectedValue.ToString(), cmb_practica.SelectedValue.ToString(), int.Parse(txtPorcCobertura.Text)))
                    {
                        Cobertura cobertura = ObtenerDatosCobertura();
                        
                        try
                        {
                            NE_Cobertura.ActualizarCobertura(cobertura, int.Parse(cmb_tipo_afiliado.SelectedValue.ToString()), int.Parse(cmb_practica.SelectedValue.ToString()));
                            MessageBox.Show("Cobertura actualizada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);                            
                            ReiniciarFormulario();                            
                            CargarGrilla();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Error al actualizar Cobertura...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe la cobertura que desea modificar");
                    }
                }
                else
                {
                    MessageBox.Show("El porcentaje que desea modificar no es correcto, por favor ingrese un valor entre 0 y 100", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos para dar de alta una cobertura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_borrar_cobertura_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar la cobertura seleccionada?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    NE_Cobertura.EliminarCobertura(int.Parse(cmb_tipo_afiliado.SelectedValue.ToString()), int.Parse(cmb_practica.SelectedValue.ToString()));
                    MessageBox.Show("Cobertura eliminada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReiniciarFormulario();
                    CargarGrilla();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Error al eliminar cobertura.\nLa misma se encuentra asociada a atenciones o cuotas pagas...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar cobertura...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bloquearComboBox()
        {
            cmb_tipo_afiliado.Enabled = false;
            cmb_practica.Enabled = false;
        }

        private void txt_txtPorcCobertura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
