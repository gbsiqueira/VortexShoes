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
    public partial class frmConsFornecedor : Form
    {
        public frmConsFornecedor()
        {
            InitializeComponent();
        }

        private void btnLimparFlitros_Click(object sender, EventArgs e)
        {
            LimparFiltros();
        }

        private void LimparFiltros()
        {
            cmbstatus.SelectedIndex = 0;
            cmbfornecedor.SelectedIndex = -1;
            ckdata.Checked = false;
        }

        private void frmConsFornecedor_Load(object sender, EventArgs e)
        {
            classFornecedor cFornecedor = new classFornecedor();

            cmbfornecedor.DataSource = cFornecedor.CarregarComboCons();

            cmbfornecedor.ValueMember = "id_fornecedor";

            cmbfornecedor.DisplayMember = "nome_fornecedor";

            cmbfornecedor.SelectedIndex = -1;

            cmbstatus.Items.Add("Ativo");
            cmbstatus.Items.Add("Inativo");
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

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classFornecedor cFornecedor = new classFornecedor();

            int id = 0;

            if(cmbfornecedor.SelectedIndex != -1)
            {
                id = Convert.ToInt32(cmbfornecedor.SelectedValue);
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

            dgv.DataSource =  cFornecedor.BuscarFornecedor(id, status, inicio, fim, ckdata.Checked);

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja editar ou excluir o fornecedor selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes) return;

            classFornecedor cFornecedor = new classFornecedor();

            frmCadFornecedor fFornecedor = new frmCadFornecedor();

            cFornecedor.BuscarDadosFornecedor(Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value));

            fFornecedor.mskcnpj.Text = cFornecedor.cnpj;

            fFornecedor.txtnome.Text = cFornecedor.nome_fornecedor;

            fFornecedor.txtobs.Text = cFornecedor.observacao;

            fFornecedor.txtemail.Text = cFornecedor.email;

            fFornecedor.status = cFornecedor.status_fornecedor;

            fFornecedor.txtid.Text = cFornecedor.id_fornecedor.ToString();

            fFornecedor.tipo_form = "atualização";

            fFornecedor.ShowDialog();
        }
    }
}
