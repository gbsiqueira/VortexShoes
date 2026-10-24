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
    public partial class frmCadFornecedor : Form
    {

        public string tipo_form;

        public int status;

        public frmCadFornecedor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtnome.Text) || string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("Por favor preencha o nome do fornecedor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblnome.ForeColor = Color.Red;
                lblemail.ForeColor = Color.Red;
            }
            else
            {
                classFornecedor cFornecedor = new classFornecedor();

                cFornecedor.nome_fornecedor = txtnome.Text;

                cFornecedor.observacao = txtobs.Text;

                cFornecedor.email = txtemail.Text;

                if(!mskcnpj.MaskCompleted)
                {
                    cFornecedor.cnpj = "";
                }
                else
                {
                    cFornecedor.cnpj = mskcnpj.Text;
                }


                if(cFornecedor.InserirFornecedor() == 1)
                {
                    MessageBox.Show($"Fornecedor: {cFornecedor.nome_fornecedor} foi cadastrado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimparCampos()
        {
            txtnome.Clear();
            txtobs.Clear();
            txtnome.Focus();
            txtemail.Clear();
            mskcnpj.Clear();
        }

        private void frmCadFornecedor_Load(object sender, EventArgs e)
        {
            cmbsts.Items.Add("Ativo");
            cmbsts.Items.Add("Inativo");

            cmbsts.SelectedIndex = 0;

            if (tipo_form == "atualização")
            {
                lbltitulo.Text = "Editar cargo";
                lblsubtitulo.Text = "Preencha as informações para editar o cargo";

                cmbsts.Enabled = true;

                if (status == 1)
                {
                    cmbsts.SelectedIndex = 0;
                }
                else
                {
                    cmbsts.SelectedIndex = 1;
                }

                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                btnedit.Enabled = true;
            }


        }

        private void btnedit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtnome.Text) || string.IsNullOrWhiteSpace(txtemail.Text))
            {
                MessageBox.Show("Por favor preencha o nome do fornecedor!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblnome.ForeColor = Color.Red;
                lblemail.ForeColor = Color.Red;
            }
            else
            {
                classFornecedor cFornecedor = new classFornecedor();

                cFornecedor.nome_fornecedor = txtnome.Text;

                cFornecedor.observacao = txtobs.Text;

                cFornecedor.email = txtemail.Text;
                
                if(cmbsts.SelectedIndex == 0)
                {
                    cFornecedor.status_fornecedor = 1;
                }
                else
                {
                    cFornecedor.status_fornecedor = 0;
                }

                if (!mskcnpj.MaskCompleted)
                {
                    cFornecedor.cnpj = "";
                }
                else
                {
                    cFornecedor.cnpj = mskcnpj.Text;
                }

                if (cFornecedor.AtualizarFornecedor(Convert.ToInt32(txtid.Text)) == 1)
                {
                    MessageBox.Show($"Fornecedor: {cFornecedor.nome_fornecedor} foi atualizado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Deseja deletar a categoria {txtnome.Text}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classFornecedor cFornecedor = new classFornecedor();

                if (cFornecedor.DeletarFornecedor(Convert.ToInt32(txtid.Text)) == 1)
                {
                    MessageBox.Show($"Fornecedor: {txtnome.Text} foi deletado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Não foi possivel deletar o fornecedor pois já existem produtos cadastrados!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
