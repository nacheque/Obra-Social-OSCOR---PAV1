using obra_social_oscor.Formulario.ABM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace obra_social_oscor
{
    public partial class frm_Escritorio : Form
    {
        public frm_Escritorio()
        {
            InitializeComponent();
        }

        private void frm_Escritorio_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_afiliado_Click(object sender, EventArgs e)
        {
            frm_Afiliado ventana = new frm_Afiliado();
            ventana.ShowDialog();
        }

        private void btn_Centro_Click(object sender, EventArgs e)
        {
            frm_Centro ventana = new frm_Centro();
            ventana.ShowDialog();
        }

        private void btn_Profesional_Click(object sender, EventArgs e)
        {
            frm_Profesional ventana = new frm_Profesional();
            ventana.ShowDialog();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
