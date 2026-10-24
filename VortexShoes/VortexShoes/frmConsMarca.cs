using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VortexShoes
{
    public partial class frmConsMarca : Form
    {

       
        public frmConsMarca()
        {
            InitializeComponent();
        }

        private void frmConsMarca_Load(object sender, EventArgs e)
        {
            classMarca cMarca = new classMarca();

            cmbmarca.DataSource = cMarca.CarregarComboCons();
            cmbmarca.ValueMember = "id_marca";
            cmbmarca.DisplayMember = "nome_marca";

            cmbmarca.SelectedIndex = -1;

            cmbstatus.Items.Add("Ativo");
            cmbstatus.Items.Add("Desativado");
            cmbstatus.SelectedIndex = 0;

        }

        private void ckdata_CheckedChanged(object sender, EventArgs e)
        {
            if (ckdata.Checked == true)
            {
                dtpDataFinal.Visible = true;
                dtpDataInicial.Visible = true;
                lblate.Visible = true;
                lblde.Visible = true;
            }
            else
            {
                dtpDataInicial.Visible = false;
                dtpDataFinal.Visible = false;
                lblate.Visible = false;
                lblde.Visible = false;
            }
        }

        private void btnLimparFlitros_Click(object sender, EventArgs e)
        {
            LimparFiltros();
        }

        private void LimparFiltros()
        {
            cmbstatus.SelectedIndex = 0;
            cmbmarca.SelectedIndex = -1;
            ckdata.Checked = false;
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classMarca cMarca = new classMarca();

            int marca = 0;

            if(cmbmarca.SelectedIndex != -1)
            {
                marca = Convert.ToInt32(cmbmarca.SelectedValue);
            }

            int status = 1;

            if(cmbstatus.SelectedIndex == 1)
            {
                status = 0;
            }

            DateTime inicio = new DateTime(1700, 1, 1);
            DateTime fim = new DateTime(1700, 1, 1);


            if (ckdata.Checked == true)
            {
                inicio = dtpDataInicial.Value;
                fim = dtpDataFinal.Value;

                if (inicio > fim)
                {
                    MessageBox.Show("A data inicial não pode ser maior que a data final!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            dgv.DataSource =  cMarca.BuscarMarca(marca, status, inicio, fim, ckdata.Checked);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja editar ou excluir a marca selecionada?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes) return;

            frmCadMarca fMarca = new frmCadMarca();

            classMarca cMarca = new classMarca();

            cMarca.BuscarDadosMarca(Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value));

            fMarca.txtid.Text = cMarca.id_marca.ToString();

            fMarca.txtnome.Text = cMarca.nome;

            fMarca.txtobs.Text = cMarca.observacao;

            fMarca.status = cMarca.status;

            fMarca.tipo_form = "atualização";

            fMarca.ShowDialog();
        }
    }
}
