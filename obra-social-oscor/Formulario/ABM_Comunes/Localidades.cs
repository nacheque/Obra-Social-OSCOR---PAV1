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
    public partial class frm_Localidades : Form
    {
        public frm_Localidades()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Localidades_Load(object sender, EventArgs e)
        {
            btnEditarLocalidad.Enabled = false;
            btnEliminarLocalidad.Enabled = false;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                gdrLocalidades.Rows.Clear();
                List<Localidad> localidades = NE_Localidades.ObtenerListadoLocalidades();
                for (int i = 0; i < localidades.Count; i++)
                {
                    gdrLocalidades.Rows.Add();
                    gdrLocalidades.Rows[i].Cells[0].Value = localidades[i].IdLocalidad;
                    gdrLocalidades.Rows[i].Cells[1].Value = localidades[i].NombreLocalidad;
                }
            }
            catch (Exception)
            {

                throw;
                //MessageBox.Show("Error al obtener el listado de localidades");
            }
        }
    }
}
