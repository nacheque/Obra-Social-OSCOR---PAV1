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
    public partial class FrmValorCuota : Form
    {
        public FrmValorCuota()
        {
            InitializeComponent();
        }

        private void btnSalirVC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmValorCuota_Load(object sender, EventArgs e)
        {
            btnEditarVC.Enabled = false;
            btnEliminarVC.Enabled = false;
            CargarComboTipoAfiliado();
            CargarGrilla();
        }

        private void CargarComboTipoAfiliado()
        {
            cmbTipoAfiliado.DataSource = AD_TipoAfiliado.ObtenerTipoAfiliado();
            cmbTipoAfiliado.DisplayMember = "DESCRIPCION";
            cmbTipoAfiliado.ValueMember = "COD_TIPO";
            cmbTipoAfiliado.SelectedIndex = -1;
        }

        private void CargarGrilla()
        {
            try
            {
                gdrValoresC.Rows.Clear();
                List<ValorCuota> valoresCuotas = NE_ValorCuota.ObtenerTablaValorCuota();
                for (int i = 0; i < valoresCuotas.Count; i++)
                {
                    gdrValoresC.Rows.Add();
                    gdrValoresC.Rows[i].Cells[0].Value = valoresCuotas[i].TipoAfiliado.DescripcionTipoAfiliado;
                    gdrValoresC.Rows[i].Cells[1].Value = valoresCuotas[i].EdadDesde;
                    gdrValoresC.Rows[i].Cells[2].Value = valoresCuotas[i].EdadHasta;
                    gdrValoresC.Rows[i].Cells[3].Value = valoresCuotas[i].Monto;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        
    }
}
