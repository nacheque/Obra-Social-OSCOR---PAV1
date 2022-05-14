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
    public partial class frm_Barrios : Form
    {
        int globalCodigoBarrio;

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
            CargarGrilla();
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

        private bool ExisteEnGrilla(string criterioABuscar)
        {
            bool resultado = false;

            for (int i = 0; i < gdrBarrios.RowCount; i++)
            {
                if (gdrBarrios.Rows[i].Cells["NombreBarrio"].Value.ToString().Equals(criterioABuscar, StringComparison.OrdinalIgnoreCase))
                {
                    // la comparacion del if devuelve true o false si el criterio esta en alguna celda de la grilla ignorando maysc y minsc
                    resultado = true;
                    break;
                }
            }


            return resultado;
        }

        private void btnAgregarBarrio_Click(object sender, EventArgs e)
        {
            if (!txtNombreBarrio.Text.Equals(""))
            {
                if (!ExisteEnGrilla(txtNombreBarrio.Text))
                {
                    Barrio barrio = ObtenerDatosBarrio();
                    try
                    {
                        NE_Barrio.AgregarBarrio(barrio);
                        MessageBox.Show("Barrio Agregado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReiniciarFormulario();
                        CargarGrilla();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al dar de alta barrio...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ya hay un barrio con el nombre que intenta agregar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre del barrio a agregar", "Adertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarBarrio_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que quiere eliminar este barrio?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    NE_Barrio.EliminarBarrio(globalCodigoBarrio);
                    MessageBox.Show("Barrio dado de Baja con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReiniciarFormulario();
                    CargarGrilla();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Error al eliminar barrio.\nEl barrio esta asociado a un Profesional o un Centro...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al dar de baja barrio...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se dara de baja al barrio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Barrio ObtenerDatosBarrio()
        {
            Barrio barrio = new Barrio();

            barrio.NombreBarrio = txtNombreBarrio.Text;

            return barrio;
        }

        private void ReiniciarFormulario()
        {
            txtNombreBarrio.Text = "";
            txtNombreBarrio.Focus();
            btnEditarBarrio.Enabled = false;
            btnEliminarBarrio.Enabled = false;
            btnAgregarBarrio.Enabled = true;
        }

        private void txtNombreBarrio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void btnLimpiarCamposBarrio_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }


        private void gdrBarrios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrBarrios.Rows[indice];

            string nombreBarrio = filaSeleccionada.Cells["NombreBarrio"].Value.ToString();
            globalCodigoBarrio = int.Parse(filaSeleccionada.Cells["CodigoBarrio"].Value.ToString());
            ReiniciarFormulario();

            btnAgregarBarrio.Enabled = false;
            btnEditarBarrio.Enabled = true;
            btnEliminarBarrio.Enabled = true;

            Barrio barrio = new Barrio();
            barrio.NombreBarrio = nombreBarrio;

            CargarCampos(barrio);
        }

        private void CargarCampos(Barrio barrio)
        {
            txtNombreBarrio.Text = barrio.NombreBarrio;
        }
    }
}
