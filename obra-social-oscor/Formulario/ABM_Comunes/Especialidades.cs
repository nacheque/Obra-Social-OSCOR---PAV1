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
    public partial class frm_Especialidades : Form
    {
        public frm_Especialidades()
        {
            InitializeComponent();
        }

        private void btn_Salir_Esp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Especialidades_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla() {
            try
            {
                grd_Esp.Rows.Clear();
                List<Especialidad> especialidades = NE_Especialidad.ObtenerListadoEspecialidades();
                for (int i = 0; i < especialidades.Count; i++)
                {
                    grd_Esp.Rows.Add();
                    grd_Esp.Rows[i].Cells[0].Value = especialidades[i].CodigoEspecialidad;
                    grd_Esp.Rows[i].Cells[1].Value = especialidades[i].NombreEspecialidad;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener listado de especialidades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void txt_Nombre_Esp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }
    }
}
