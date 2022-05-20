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
    public partial class FrmValorCuota : Form
    {
        public FrmValorCuota()
        {
            InitializeComponent();
        }

        private void btnSalirVC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmValorCuota_Load(object sender, EventArgs e)
        {
            btnEditarVC.Enabled = false;
            btnEliminarVC.Enabled = false;
            CargarComboTipoAfiliado();
            CargarGrilla();
        }

        private void CargarComboTipoAfiliado()
        {
            cmbTipoAfiliado.DataSource = AD_TipoAfiliado.ObtenerTipoAfiliado();
            cmbTipoAfiliado.DisplayMember = "DESCRIPCION";
            cmbTipoAfiliado.ValueMember = "COD_TIPO";
            cmbTipoAfiliado.SelectedIndex = -1;
        }

        private void CargarGrilla()
        {
            try
            {
                gdrValoresC.Rows.Clear();
                List<ValorCuota> valoresCuotas = NE_ValorCuota.ObtenerTablaValorCuota();
                for (int i = 0; i < valoresCuotas.Count; i++)
                {
                    gdrValoresC.Rows.Add();
                    gdrValoresC.Rows[i].Cells[0].Value = valoresCuotas[i].TipoAfiliado.CodigoTipoAfiliado;
                    gdrValoresC.Rows[i].Cells[1].Value = valoresCuotas[i].TipoAfiliado.DescripcionTipoAfiliado;
                    gdrValoresC.Rows[i].Cells[2].Value = valoresCuotas[i].EdadDesde;
                    gdrValoresC.Rows[i].Cells[3].Value = valoresCuotas[i].EdadHasta;
                    gdrValoresC.Rows[i].Cells[4].Value = valoresCuotas[i].Monto;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro al obtener listado de valores de cuotas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReiniciarFormVC_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }

        private void ReiniciarFormulario()
        {
            txtEdadDesde.Text = "";
            txtEdadHasta.Text = "";
            cmbTipoAfiliado.SelectedIndex = -1;
            txtMonto.Text = "";
            txtEdadDesde.Focus();
        }

        private bool ExisteEnGrilla(string edadDesde, string edadHasta, int tipoAfiliado)
        {
            bool resultado = false;

            for (int i = 0; i < gdrValoresC.Rows.Count; i++)
            {
                if (int.Parse(gdrValoresC.Rows[i].Cells["EdadDesde"].Value.ToString()) == int.Parse(edadDesde)
                    && int.Parse(gdrValoresC.Rows[i].Cells["EdadHasta"].Value.ToString()) == int.Parse(edadHasta)
                    && int.Parse(gdrValoresC.Rows[i].Cells["CodigoTipoAfiliado"].Value.ToString()) == tipoAfiliado)
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        private bool ValidarCamposVacios()
        {
            bool resultado = false;
            if (txtEdadDesde.Text.Equals("") || txtEdadHasta.Text.Equals("")
                || cmbTipoAfiliado.SelectedIndex == -1 || txtMonto.Text.Equals(""))
            {
                resultado = true;
            }

            return resultado;
        }

        private ValorCuota ObtenerDatosVC()
        {
            TipoAfiliado tipoAfiliado = new TipoAfiliado();
            //tipoAfiliado.CodigoTipoAfiliado = cmbTipoAfiliado.SelectedIndex + 1;
            tipoAfiliado.CodigoTipoAfiliado = (int) cmbTipoAfiliado.SelectedValue;
            tipoAfiliado.DescripcionTipoAfiliado = cmbTipoAfiliado.SelectedItem.ToString();

            ValorCuota valorCuota = new ValorCuota();
            valorCuota.EdadDesde = int.Parse(txtEdadDesde.Text);
            valorCuota.EdadHasta = int.Parse(txtEdadHasta.Text);
            valorCuota.TipoAfiliado = tipoAfiliado;
            valorCuota.Monto = int.Parse(txtMonto.Text);

            return valorCuota;

        }

        private void btnAgregarVC_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposVacios())
            {
                if (!ExisteEnGrilla(txtEdadDesde.Text, txtEdadHasta.Text, int.Parse(cmbTipoAfiliado.SelectedValue.ToString())))
                {
                    ValorCuota valorCuota = ObtenerDatosVC();

                    try
                    {
                        NE_ValorCuota.AgregarVC(valorCuota);
                        MessageBox.Show("Valor de Cuota agregado con exito", "Infrmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReiniciarFormulario();
                        CargarGrilla();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error al agregar valor de cuota...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ya hay una couta asignada a ese rango de edades...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtEdadDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtEdadHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        int globalIdTipoAfiliado;
        int globalEdadDesde;

        private void gdrValoresC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrValoresC.Rows[indice];

            globalIdTipoAfiliado = int.Parse(filaSeleccionada.Cells["CodigoTipoAfiliado"].Value.ToString());
            globalEdadDesde = int.Parse(filaSeleccionada.Cells["EdadDesde"].Value.ToString());

            ReiniciarFormulario();

            btnAgregarVC.Enabled = false;
            btnEditarVC.Enabled = true;
            txtEdadDesde.Enabled = false;
            cmbTipoAfiliado.Enabled = false;

            TipoAfiliado tipoAfiliado = new TipoAfiliado();
            tipoAfiliado.CodigoTipoAfiliado = int.Parse(filaSeleccionada.Cells["CodigoTipoAfiliado"].Value.ToString());
            tipoAfiliado.DescripcionTipoAfiliado = filaSeleccionada.Cells["TipoAfiliado"].Value.ToString();

            ValorCuota valorCuota = new ValorCuota();
            valorCuota.TipoAfiliado = tipoAfiliado;
            valorCuota.EdadDesde = int.Parse(filaSeleccionada.Cells["EdadDesde"].Value.ToString());
            valorCuota.EdadHasta = int.Parse(filaSeleccionada.Cells["EdadHasta"].Value.ToString());
            valorCuota.Monto = float.Parse(filaSeleccionada.Cells["Monto"].Value.ToString());

            CargarCampos(valorCuota);
        }

        private void CargarCampos(ValorCuota valorCuota)
        {
            txtEdadDesde.Text = valorCuota.EdadDesde.ToString();
            txtEdadHasta.Text = valorCuota.EdadHasta.ToString();
            txtMonto.Text = valorCuota.Monto.ToString();
            cmbTipoAfiliado.SelectedIndex = valorCuota.TipoAfiliado.CodigoTipoAfiliado - 1;
        }

        private void btnEditarVC_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposVacios())
            {
                if (!ExisteEnGrilla(txtEdadDesde.Text, txtEdadHasta.Text, int.Parse(cmbTipoAfiliado.SelectedValue.ToString())))
                {
                    ValorCuota valorCuota = ObtenerDatosVC();
                    try
                    {
                        NE_ValorCuota.ActualizarVC(valorCuota, globalIdTipoAfiliado, globalEdadDesde);
                        MessageBox.Show("Valor de Cuota actualizado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReiniciarFormulario();
                        CargarGrilla();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error al editar valor de cuota...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ya hay un valor de cuota para esas edades y tipo de afiliado...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
