using obra_social_oscor.AccesoADatos;
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

namespace obra_social_oscor.Formulario.ABM
{
    public partial class frm_Atenciones : Form
    {
        public frm_Atenciones()
        {
            InitializeComponent();
        }

        private void frm_Atenciones_Load(object sender, EventArgs e)
        {
            CargarComboCentros();           
            CargarComboPracticas();           
            cmb_esp_atencion.Enabled = false;
            cmb_prof_atencion.Enabled = false;           
            txt_importe_aten.Enabled = false;
            msk_fecha_aten.Enabled = false;
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
    }
}
