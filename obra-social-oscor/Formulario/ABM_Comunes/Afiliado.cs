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
    public partial class frm_Afiliado : Form
    {
        public frm_Afiliado()
        {
            InitializeComponent();
        }

        private void btn_salir_afiliado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Afiliado_Load(object sender, EventArgs e)
        {
            btn_editar_afiliado.Enabled = false;
            btn_borrar_afiliado.Enabled = false;
            //cmb_tipo_afiliado
        }

        private void btn_limpiar_afiliado_Click(object sender, EventArgs e)
        {
            ReiniciarFormulario();
        }

        private void ReiniciarFormulario()
        {
            txt_apellido_afiliado.Text = "";
            txt_apellido_afiliado.Focus();
            txt_nombre_afiliado.Text = "";
            dtp_fecha_nacimiento.Value = DateTime.Today;
            //tipoAfiliado
            dtp_fecha_inscripcion.Value = DateTime.Today;
            txt_monto_afiliado.Text = "";
            btn_editar_afiliado.Enabled = false;
            btn_borrar_afiliado.Enabled = false;
        }
    }
}
