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
    public partial class frm_Atenciones : Form
    {
        int global_nro_afiliado_seleccionado;
        string fecha_hora_atencion_seleccionada;

        public frm_Atenciones()
        {
            InitializeComponent();
        }

        private void frm_Atenciones_Load(object sender, EventArgs e)
        {
            CargarComboCentros();           
            CargarComboPracticas();
            CargarGrilla();
            cmb_esp_atencion.Enabled = false;
            cmb_prof_atencion.Enabled = false;           
            txt_importe_aten.Enabled = false;
            msk_fecha_aten.Enabled = false;
            btn_editar_atencion.Enabled = false;
            msk_fecha_aten.Text = DateTime.Now.ToShortDateString();
        }

        private void CargarComboCentros()
        {
            try
            {
                cmb_centro_atencion.DataSource = AD_Centro.ObtenerCentrosConEspYProf();
                cmb_centro_atencion.DisplayMember = "DENOMINACION";
                cmb_centro_atencion.ValueMember = "COD_CENTRO";
                cmb_centro_atencion.SelectedIndex = -1;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de Centros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       

        private void CargarComboPracticas()
        {
            try
            {
                cmb_practica_atencion.DataSource = AD_Practica.obtenerPracticas();
                cmb_practica_atencion.DisplayMember = "DESCRIPCION";
                cmb_practica_atencion.ValueMember = "ID_PRACTICA";
                cmb_practica_atencion.SelectedIndex = 0;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de Practicas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboResultadosEditar(int nro_afiliado)
        {
            try
            {
                cmb_resultados.DataSource = AD_Afiliado.ObtenerAfiliadoBusqueda("", "", nro_afiliado);
                cmb_resultados.DisplayMember = "NOMBRE_COMPLETO";
                cmb_resultados.ValueMember = "NRO_AFILIADO";
                cmb_resultados.SelectedIndex = -1;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de Afiliados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salir_atencion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_afi_atencion_Click(object sender, EventArgs e)
        {
            int numeroAfiliado;

            if (txt_num_afi_ate.Text.Trim().Equals(""))
            {
                numeroAfiliado = 0;
            }
            else {
                numeroAfiliado = int.Parse(txt_num_afi_ate.Text.Trim());
            }

            try
            {
                DataTable dataSource = AD_Afiliado.ObtenerAfiliadoBusqueda(txt_apellido_afi_atencion.Text.Trim(), txt_nombre_afi_atencion.Text.Trim()
                    , numeroAfiliado);

                if (dataSource.Rows.Count > 0)
                {
                    cmb_resultados.DataSource = dataSource;
                    cmb_resultados.DisplayMember = "NOMBRE_COMPLETO";
                    cmb_resultados.ValueMember = "NRO_AFILIADO";
                    cmb_resultados.SelectedIndex = 0;
                }
                else
                {
                    cmb_resultados.DataSource = new DataTable();
                    MessageBox.Show("No se encontraron resultados para los filtros ingresados", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }                
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de Afiliados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }        

        private void CargarComboEspecialidades()
        {
            try
            {
                cmb_esp_atencion.DataSource = AD_Especialidad.ObtenerEspecialidadesPorCentro((int)cmb_centro_atencion.SelectedValue);
                cmb_esp_atencion.DisplayMember = "NOMBRE";
                cmb_esp_atencion.ValueMember = "COD_ESPECIALIDAD";
                cmb_esp_atencion.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de Especialidades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_centro_atencion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_esp_atencion.Enabled = true;
            cmb_prof_atencion.Enabled = false;
            cmb_prof_atencion.SelectedIndex = -1;
            CargarComboEspecialidades();
        }

        private void cmb_esp_atencion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_prof_atencion.Enabled = true;
            CargarComboProfesionales();
        }

        private void CargarComboProfesionales()
        {
            try
            {
                cmb_prof_atencion.DataSource = AD_Profesional.ObtenerProfesionalesPorEspYCen((int)cmb_centro_atencion.SelectedValue, 
                    (int)cmb_esp_atencion.SelectedValue);
                cmb_prof_atencion.DisplayMember = "NOMBRE_COMPLETO";
                cmb_prof_atencion.ValueMember = "MATRICULA";
                cmb_prof_atencion.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de Profesionales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_limpiar_filtros_aten_Click(object sender, EventArgs e)
        {
            LimpiarFiltrosBusquedaAfiliado();
        }

        private void LimpiarFiltrosBusquedaAfiliado() {
            txt_num_afi_ate.Text = "";
            txt_nombre_afi_atencion.Text = "";
            txt_apellido_afi_atencion.Text = "";
        }

        private void txt_num_afi_ate_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txt_apellido_afi_atencion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txt_nombre_afi_atencion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void CargarGrilla()
        {
            try
            {
                grd_atenciones.Rows.Clear();
                List<Atencion> atenciones = NE_Atencion.obtenerListadoAtenciones();

                for (int i = 0; i < atenciones.Count; i++)
                {
                    grd_atenciones.Rows.Add();
                    grd_atenciones.Rows[i].Cells[0].Value = atenciones[i].Afiliado.NumeroAfiliado;
                    grd_atenciones.Rows[i].Cells[1].Value = atenciones[i].Afiliado.NombreCompleto;
                    grd_atenciones.Rows[i].Cells[2].Value = atenciones[i].FechaHoraAtencion;
                    grd_atenciones.Rows[i].Cells[3].Value = atenciones[i].Centro.CodigoCentro;
                    grd_atenciones.Rows[i].Cells[4].Value = atenciones[i].Centro.Denominacion;
                    grd_atenciones.Rows[i].Cells[5].Value = atenciones[i].Especialidad.CodigoEspecialidad;
                    grd_atenciones.Rows[i].Cells[6].Value = atenciones[i].Especialidad.NombreEspecialidad;
                    grd_atenciones.Rows[i].Cells[7].Value = atenciones[i].Profesional.Matricula;
                    grd_atenciones.Rows[i].Cells[8].Value = atenciones[i].Profesional.NombreCompleto;
                    grd_atenciones.Rows[i].Cells[9].Value = atenciones[i].Importe;
                    grd_atenciones.Rows[i].Cells[10].Value = atenciones[i].Practica.CodigoPractica;
                    grd_atenciones.Rows[i].Cells[11].Value = atenciones[i].Practica.DescripcionPractica;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de atenciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_agregar_atencion_Click(object sender, EventArgs e)
        {
            if (cmb_centro_atencion.SelectedIndex != -1 && cmb_esp_atencion.SelectedIndex != -1 && cmb_prof_atencion.SelectedIndex != -1 && 
                cmb_resultados.SelectedIndex != -1 && cmb_practica_atencion.SelectedIndex != -1)
            {              
                                    
                try
                {
                    Atencion atencion = ObtenerDatosAtencion();
                    if (atencion.Importe >= 0)
                    {
                        NE_Atencion.AgregarAtencion(atencion);
                        MessageBox.Show("Atencion agregada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReiniciarFormulario();
                        CargarGrilla();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al agregar Atencion...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                                        
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos para agregar la Atencion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Atencion ObtenerDatosAtencion()
        {
            Atencion atencion = new Atencion();

            Afiliado afiliado = new Afiliado();
            afiliado.NumeroAfiliado = (int)cmb_resultados.SelectedValue;

            atencion.Afiliado = afiliado;

            Centro centro = new Centro();
            centro.CodigoCentro = (int)cmb_centro_atencion.SelectedValue;

            atencion.Centro = centro;

            Especialidad especialidad = new Especialidad();
            especialidad.CodigoEspecialidad = (int)cmb_esp_atencion.SelectedValue;

            atencion.Especialidad = especialidad;

            Profesional profesional = new Profesional();
            profesional.Matricula = (int)cmb_prof_atencion.SelectedValue;

            atencion.Profesional = profesional;            

            Practica practica = new Practica();
            practica.CodigoPractica = (int)cmb_practica_atencion.SelectedValue;

            atencion.Practica = practica;

            try
            {
                atencion.Importe = CalcularImporteAtencion(practica.CodigoPractica, afiliado.NumeroAfiliado);
            }
            catch (Exception)
            {
                throw;
            }
            
            return atencion;
        }

        private float CalcularImporteAtencion(int idPractica, int numeroAfiliado) {
            float resultado = 0;
            float precioPractica = 0;            

            try
            {
                precioPractica = AD_Practica.obtenerPrecioPorIdPractica(idPractica);
                int idTipoAfiliado = AD_Afiliado.ObtenerIdTipoAfiliado(numeroAfiliado);
                int porcentajeCobertura = AD_Cobertura.ObtenerCoberturaPorTipoAfiliadoYPractica(idPractica, idTipoAfiliado);

                resultado = precioPractica - ((porcentajeCobertura * precioPractica) / 100);
                return resultado;
            }
            catch (System.NullReferenceException) {
                if (MessageBox.Show("El paciente no cuenta con cobertura para la practica seleccionada. Desea continuar de todos modos?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    return resultado = precioPractica;
                }
                else {
                    return -1;
                }                    
            }
            catch (Exception)
            {
                throw;
            }            
        }

        private void ReiniciarFormulario()
        {
            LimpiarFiltrosBusquedaAfiliado();
            btn_agregar_atencion.Enabled = true;
            btn_editar_atencion.Enabled = false;
            cmb_centro_atencion.SelectedIndex = -1;
            cmb_esp_atencion.SelectedIndex = -1;
            cmb_esp_atencion.Enabled = false;
            cmb_prof_atencion.SelectedIndex = -1;
            cmb_prof_atencion.Enabled = false;
            cmb_resultados.SelectedIndex = -1;
            txt_importe_aten.Text = "";
            cmb_practica_atencion.SelectedIndex = -1;
        }

        private void btn_limpiar_atencion_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }

        private void grd_atenciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow filaSeleccionada = grd_atenciones.Rows[indice];

                global_nro_afiliado_seleccionado = int.Parse(filaSeleccionada.Cells["nro_afiliado"].Value.ToString());
                fecha_hora_atencion_seleccionada = filaSeleccionada.Cells["fecha_hora"].Value.ToString();

                ReiniciarFormulario();

                cmb_esp_atencion.Enabled = true;
                cmb_prof_atencion.Enabled = true;
                btn_agregar_atencion.Enabled = false;
                btn_editar_atencion.Enabled = true;

                Atencion atencion = new Atencion();

                Afiliado afiliado = new Afiliado();
                afiliado.NumeroAfiliado = int.Parse(filaSeleccionada.Cells["nro_afiliado"].Value.ToString());

                atencion.Afiliado = afiliado;

                Centro centro = new Centro();
                centro.CodigoCentro = int.Parse(filaSeleccionada.Cells["cod_centro"].Value.ToString());

                atencion.Centro = centro;

                Especialidad especialidad = new Especialidad();
                especialidad.CodigoEspecialidad = int.Parse(filaSeleccionada.Cells["cod_especialidad"].Value.ToString());

                atencion.Especialidad = especialidad;

                Profesional profesional = new Profesional();
                profesional.Matricula = int.Parse(filaSeleccionada.Cells["matricula"].Value.ToString());

                atencion.Profesional = profesional;

                Practica practica = new Practica();
                practica.CodigoPractica = int.Parse(filaSeleccionada.Cells["id_practica"].Value.ToString());

                atencion.Practica = practica;
              
                atencion.Importe = float.Parse(filaSeleccionada.Cells["importe"].Value.ToString());
                atencion.FechaHoraAtencion = DateTime.Parse(filaSeleccionada.Cells["fecha_hora"].Value.ToString());

                CargarCampos(atencion);
            }
        }

        private void CargarCampos(Atencion atencion)
        {
            cmb_centro_atencion.SelectedValue = atencion.Centro.CodigoCentro;

            CargarComboEspecialidades();
            cmb_esp_atencion.SelectedValue = atencion.Especialidad.CodigoEspecialidad;

            CargarComboProfesionales();
            cmb_prof_atencion.SelectedValue = atencion.Profesional.Matricula;

            CargarComboResultadosEditar(atencion.Afiliado.NumeroAfiliado);
            cmb_resultados.SelectedValue = atencion.Afiliado.NumeroAfiliado;

            CargarComboPracticas();
            cmb_practica_atencion.SelectedValue = atencion.Practica.CodigoPractica;

            txt_importe_aten.Text = atencion.Importe.ToString();
            msk_fecha_aten.Text = atencion.FechaHoraAtencion.ToString();            
        }
    }
}
