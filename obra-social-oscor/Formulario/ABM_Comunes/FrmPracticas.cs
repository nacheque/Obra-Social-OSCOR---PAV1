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
    public partial class FrmPracticas : Form
    {
        //variable global
        int global_codigoPractica;

        public FrmPracticas()
        {
            InitializeComponent();
        }

        private void Practicas_Load(object sender, EventArgs e)
        {
            cargarGrilla();
            btn_Editar_Pract.Enabled = false;
            btn_Eliminar_Pract.Enabled = false;
            
        }



        private void cargarGrilla()
        {
            try
            {
                dgv_Pract.Rows.Clear();
                List<Practica> practicas = NE_Practica.obtenerListadoPracticas();
                for (int i = 0; i < practicas.Count; i++)
                {
                    dgv_Pract.Rows.Add();
                    dgv_Pract.Rows[i].Cells[0].Value = practicas[i].CodigoPractica;
                    dgv_Pract.Rows[i].Cells[1].Value = practicas[i].DescripcionPractica;
                    dgv_Pract.Rows[i].Cells[2].Value = practicas[i].PrecioPractica;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener listado de Practicas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Limpiar_Pract_Click(object sender, EventArgs e)
        {
            reiniciarFormulario();
        }

        private void reiniciarFormulario()
        {
            txt_Nombre_Pract.Text = "";
            txt_Precio_Pract.Text = "";
            txt_Nombre_Pract.Focus();
            btn_Editar_Pract.Enabled = false;
            btn_Eliminar_Pract.Enabled = false;
            btn_Agregar_Pract.Enabled = true;

        }

        private bool ExisteEnGrilla(string criterioABuscar)
        {
            bool resultado = false;

            for (int i = 0; i < dgv_Pract.Rows.Count; i++)
            {
                if (dgv_Pract.Rows[i].Cells["Descripcion"].Value.ToString().Equals(criterioABuscar, StringComparison.OrdinalIgnoreCase))
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        private Practica ObtenerDatosPractica()
        {
            Practica practica = new Practica();

            practica.DescripcionPractica = txt_Nombre_Pract.Text; //le otorgo una descripción a mi objeto Práctica
            practica.PrecioPractica = int.Parse(txt_Precio_Pract.Text);

            return practica;
        }       

        private void btn_Agregar_Pract_Click(object sender, EventArgs e)
        {
            if (!txt_Nombre_Pract.Text.Equals("") || !txt_Precio_Pract.Text.Equals("")) 
            {
                if (!ExisteEnGrilla(txt_Nombre_Pract.Text))
                {
                    Practica practica = ObtenerDatosPractica();
                    try
                    {
                        NE_Practica.agregarPractica(practica);
                        //NE_Especialidad.AgregarEspecialidad(especialidad);
                        MessageBox.Show("Práctica agregada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MessageBox.Show("Especialidad agregada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reiniciarFormulario();
                        cargarGrilla();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al agregar Practica...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe una Practica con ese nombre...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de Practica y su precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Salir_Pract_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Nombre_Pract_Key_Press(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void dgv_Pract_Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice >= 0)
            {
                DataGridViewRow filaSeleccionada = dgv_Pract.Rows[indice];

                string nombrePractica = filaSeleccionada.Cells["Descripcion"].Value.ToString();
                string precioPractica = filaSeleccionada.Cells["PrecioPract"].Value.ToString();
                global_codigoPractica = int.Parse(filaSeleccionada.Cells["IdPractica"].Value.ToString());
                reiniciarFormulario();

                btn_Editar_Pract.Enabled = true;
                btn_Eliminar_Pract.Enabled = true;
                btn_Agregar_Pract.Enabled = false;

                Practica practica = new Practica();
                practica.DescripcionPractica = nombrePractica;
                practica.PrecioPractica = float.Parse(precioPractica);
                cargarCampos(practica);
            }
        }

        private void cargarCampos(Practica practica)
        {
            txt_Nombre_Pract.Text = practica.DescripcionPractica;
            txt_Precio_Pract.Text = practica.PrecioPractica.ToString();
        }

        private void btn_Eliminar_Pract_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar la Practica seleccionada?", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    NE_Practica.eliminarPractica(global_codigoPractica);                    
                    MessageBox.Show("Practica eliminada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reiniciarFormulario();
                    cargarGrilla();
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("Error al eliminar Practica.\nLa Practica esta asociada a un Centro...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al eliminar Practica...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Editar_Pract_Click(object sender, EventArgs e)
        {
            if (!txt_Nombre_Pract.Text.Equals(""))
            {
                if (!ExisteEnGrilla(txt_Nombre_Pract.Text))
                {
                    Practica practica = ObtenerDatosPractica();                    
                    try
                    {
                        NE_Practica.actualizarPractica(practica, global_codigoPractica);                        
                        MessageBox.Show("Práctica actualizada con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reiniciarFormulario();
                        cargarGrilla();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Error al actualizar Práctica...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe una Práctica con ese nombre...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de Práctica", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
