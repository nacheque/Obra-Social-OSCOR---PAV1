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

namespace obra_social_oscor.Formulario.ABM_Procesos
{
    public partial class frm_Pagos : Form
    {
        int global_numero_afiliado;
        int global_numero_cuota;
        int global_anio_cuota;

        public frm_Pagos()
        {
            InitializeComponent();
        }

        private void btn_salir_pagos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Pagos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            msk_fecha_pago.Enabled = false;
            msk_fecha_pago.Text = DateTime.Now.ToShortDateString();
            txt_total.Enabled = false;
            btn_eliminar_pago.Enabled = false;
        }

        private void CargarGrilla()
        {
            try
            {
                grd_pagos.Rows.Clear();
                List<CuotaPaga> cuotasPagas = NE_CuotaPaga.obtenerListadoCuotasPagas();

                for (int i = 0; i < cuotasPagas.Count; i++)
                {
                    grd_pagos.Rows.Add();
                    grd_pagos.Rows[i].Cells[0].Value = cuotasPagas[i].Afiliado.NumeroAfiliado;
                    grd_pagos.Rows[i].Cells[1].Value = cuotasPagas[i].Afiliado.NombreCompleto;
                    grd_pagos.Rows[i].Cells[2].Value = cuotasPagas[i].NumeroCuota;
                    grd_pagos.Rows[i].Cells[3].Value = cuotasPagas[i].AnioCuota;
                    grd_pagos.Rows[i].Cells[4].Value = cuotasPagas[i].FechaPago;
                    grd_pagos.Rows[i].Cells[5].Value = cuotasPagas[i].MontoEmergencia;
                    grd_pagos.Rows[i].Cells[6].Value = cuotasPagas[i].TotalPago;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de Cuotas Pagas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grd_pagos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow filaSeleccionada = grd_pagos.Rows[indice];

                global_numero_afiliado = int.Parse(filaSeleccionada.Cells["nro_afiliado"].Value.ToString());
                global_numero_cuota = int.Parse(filaSeleccionada.Cells["nro_cuota"].Value.ToString());
                global_anio_cuota = int.Parse(filaSeleccionada.Cells["anio"].Value.ToString());

                ReiniciarFormulario();
                
                txt_apellido_afi_cuota.Enabled = false;
                txt_monto_emerg.Enabled = false;
                txt_nombre_afi_cuota.Enabled = false;
                msk_anio_cuota.Enabled = false;
                msk_nro_cuota.Enabled = false;
                btn_agregar_pago.Enabled = false;
                btn_buscar_afi_cuota.Enabled = false;
                btn_limpiar_filtros_cuota.Enabled = false;
                txt_num_afi_cuota.Enabled = false;
                cmb_resultados_cuota.Enabled = false;
                btn_eliminar_pago.Enabled = true;

                CuotaPaga cuotaPaga = new CuotaPaga();

                Afiliado afiliado = new Afiliado();
                afiliado.NumeroAfiliado = int.Parse(filaSeleccionada.Cells["nro_afiliado"].Value.ToString());
                afiliado.NombreCompleto = filaSeleccionada.Cells["nombre_completo_afiliado"].Value.ToString();

                cuotaPaga.Afiliado = afiliado;

                cuotaPaga.NumeroCuota = int.Parse(filaSeleccionada.Cells["nro_cuota"].Value.ToString());
                cuotaPaga.AnioCuota = int.Parse(filaSeleccionada.Cells["anio"].Value.ToString());
                cuotaPaga.MontoEmergencia = float.Parse(filaSeleccionada.Cells["monto_emergencia"].Value.ToString());
                cuotaPaga.FechaPago = DateTime.Parse(filaSeleccionada.Cells["fecha_pago"].Value.ToString());
                cuotaPaga.TotalPago = float.Parse(filaSeleccionada.Cells["total"].Value.ToString());
                
                CargarCampos(cuotaPaga);
            }
        }

        private void ReiniciarFormulario() {
           
            txt_apellido_afi_cuota.Enabled = true;
            txt_monto_emerg.Enabled = true;
            txt_nombre_afi_cuota.Enabled = true;
            msk_anio_cuota.Enabled = true;
            msk_nro_cuota.Enabled = true;
            btn_agregar_pago.Enabled = true;
            btn_buscar_afi_cuota.Enabled = true;
            btn_limpiar_filtros_cuota.Enabled = true;
            txt_num_afi_cuota.Enabled = true;
            cmb_resultados_cuota.Enabled = true;
            btn_eliminar_pago.Enabled = false;
            cmb_resultados_cuota.SelectedIndex = -1;
            msk_fecha_pago.Text = DateTime.Now.ToShortDateString();
            msk_nro_cuota.Text = "";
            msk_anio_cuota.Text = "";
            txt_monto_emerg.Text = "";
            txt_total.Text = "";
            txt_apellido_afi_cuota.Text = "";
            txt_nombre_afi_cuota.Text = "";
            txt_num_afi_cuota.Text = "";
        }

        private void btn_limpiar_pago_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }

        private void CargarCampos(CuotaPaga cuotaPaga)
        {
            CargarComboResultadosEditar(cuotaPaga.Afiliado.NumeroAfiliado);
            cmb_resultados_cuota.SelectedValue = cuotaPaga.Afiliado.NumeroAfiliado;

            msk_nro_cuota.Text = cuotaPaga.NumeroCuota.ToString();
            msk_anio_cuota.Text = cuotaPaga.AnioCuota.ToString();
            txt_monto_emerg.Text = cuotaPaga.MontoEmergencia.ToString();
            msk_fecha_pago.Text = cuotaPaga.FechaPago.ToString();
            txt_total.Text = cuotaPaga.TotalPago.ToString();
        }

        private void CargarComboResultadosEditar(int nro_afiliado)
        {
            try
            {
                cmb_resultados_cuota.DataSource = AD_Afiliado.ObtenerAfiliadoBusqueda("", "", nro_afiliado);
                cmb_resultados_cuota.DisplayMember = "NOMBRE_COMPLETO";
                cmb_resultados_cuota.ValueMember = "NRO_AFILIADO";
                cmb_resultados_cuota.SelectedIndex = -1;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de Afiliados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_afi_cuota_Click(object sender, EventArgs e)
        {
            int numeroAfiliado;

            if (txt_num_afi_cuota.Text.Trim().Equals(""))
            {
                numeroAfiliado = 0;
            }
            else
            {
                numeroAfiliado = int.Parse(txt_num_afi_cuota.Text.Trim());
            }

            try
            {
                DataTable dataSource = AD_Afiliado.ObtenerAfiliadoBusqueda(txt_apellido_afi_cuota.Text.Trim(), txt_nombre_afi_cuota.Text.Trim()
                    , numeroAfiliado);

                if (dataSource.Rows.Count > 0)
                {
                    cmb_resultados_cuota.DataSource = dataSource;
                    cmb_resultados_cuota.DisplayMember = "NOMBRE_COMPLETO";
                    cmb_resultados_cuota.ValueMember = "NRO_AFILIADO";
                    cmb_resultados_cuota.SelectedIndex = 0;
                }
                else
                {
                    cmb_resultados_cuota.DataSource = new DataTable();
                    MessageBox.Show("No se encontraron resultados para los filtros ingresados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de Afiliados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiar_filtros_cuota_Click(object sender, EventArgs e)
        {
            LimpiarFiltrosBusquedaAfiliado();
        }

        private void LimpiarFiltrosBusquedaAfiliado()
        {
            txt_num_afi_cuota.Text = "";
            txt_nombre_afi_cuota.Text = "";
            txt_apellido_afi_cuota.Text = "";
        }

        private void btn_agregar_pago_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que quiere cargar el Pago?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!msk_nro_cuota.Text.Equals("") && !msk_anio_cuota.Text.Equals("") && !txt_monto_emerg.Text.Equals("") &&
               cmb_resultados_cuota.SelectedIndex != -1)
                {

                    try
                    {
                        CuotaPaga cuotaPaga = ObtenerDatosCuotaPaga();
                        if (cuotaPaga.TotalPago > 0)
                        {
                            NE_CuotaPaga.AgregarCuotaPaga(cuotaPaga);
                            MessageBox.Show("Pago realizado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReiniciarFormulario();
                            CargarGrilla();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al agregar Pago...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Debe completar todos los datos para agregar un Pago", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private CuotaPaga ObtenerDatosCuotaPaga()
        {
            CuotaPaga cuotaPaga = new CuotaPaga();

            Afiliado afiliado = new Afiliado();
            afiliado.NumeroAfiliado = (int) cmb_resultados_cuota.SelectedValue;

            cuotaPaga.Afiliado = afiliado;
            cuotaPaga.NumeroCuota = int.Parse(msk_nro_cuota.Text.Trim());
            cuotaPaga.AnioCuota = int.Parse(msk_anio_cuota.Text.Trim());
            cuotaPaga.MontoEmergencia = float.Parse(txt_monto_emerg.Text.Trim());
            
            cuotaPaga.TotalPago = CalcularTotalPago(afiliado.NumeroAfiliado, cuotaPaga.MontoEmergencia);            

            return cuotaPaga;
        }

        private float CalcularTotalPago(int numeroAfiliado, float montoEmergencia)
        {
            try
            {
                Afiliado afiliado = Ne_Afiliado.obtenerAfiliadoPorNumero(numeroAfiliado).First();

                int edadAfiliado = Validar.CalcularEdad(afiliado.FechaNacimientoAfiliado);
                int idTipoAfiliado = afiliado.TipoAfiliado.CodigoTipoAfiliado;

                ValorCuota valorCuota = NE_ValorCuota.ObtenerValorCuotaPorTipoAfiYEdad(idTipoAfiliado, edadAfiliado).First();

                float resultado = valorCuota.Monto + montoEmergencia;

                return resultado;
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Debe cargar un valor de cuota para el tipo de afiliado y rango de edad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al calcular el total a pagar...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void btn_eliminar_pago_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que quiere eliminar el Pago?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    NE_CuotaPaga.EliminarCuotaPaga(global_numero_afiliado, global_numero_cuota, global_anio_cuota);
                    MessageBox.Show("Pago eliminado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReiniciarFormulario();
                    CargarGrilla();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Error al eliminar pago.\nEl pago esta asociado a otra transaccion...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar pago...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void txt_monto_emerg_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
