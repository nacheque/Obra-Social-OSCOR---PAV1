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
    public partial class frm_Barrios : Form
    {
        public frm_Barrios()
        {
            InitializeComponent();
        }

        private void btnSalirBarrios_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Barrios_Load(object sender, EventArgs e)
        {
            btnEditarBarrio.Enabled = false;
            btnEliminarBarrio.Enabled = false;
            //CargarGrilla();  //Genera problemas al cargar
            CargarGrillaH(); //toma directamente los datos el DataTable desde el AD_Barrio (es como lo hace Horestein)
        }

        private void CargarGrilla()
        {
            try
            {
                gdrBarrios.Rows.Clear();
                List<Barrio> barrios = NE_Barrio.ObtenerListadoBarrios();
                for (int i = 0; i < barrios.Count; i++)
                {
                    gdrBarrios.Rows.Add();
                    gdrBarrios.Rows[i].Cells[0].Value = barrios[i].IdBarrio;
                    gdrBarrios.Rows[i].Cells[1].Value = barrios[i].NombreBarrio;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener listado de barrios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrillaH()
        {
            try
            {
                gdrBarrios.DataSource = AD_Barrio.ObtenerBarrios();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener los barrios");
            }
        }
    }
}
