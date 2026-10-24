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
    public partial class frmCadCategoria : Form
    {

        public int status;
        public string tipo_form;

        public frmCadCategoria()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtnome.Text))
            {
                MessageBox.Show("Por favor preencha o nome da categoria", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblnome.ForeColor = Color.Red;
                txtnome.Focus();
            }
            else
            {
                classCategoria cCategoria = new classCategoria();

                cCategoria.nome = txtnome.Text;

                cCategoria.observacao = txtobs.Text;

                if(cCategoria.InserirCategoria() == 1)
                {
                    MessageBox.Show($"Categoria: {cCategoria.nome} foi cadastrado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void frmCadCategoria_Load(object sender, EventArgs e)
        {
            cmbsts.Items.Add("Ativo");
            cmbsts.Items.Add("Inativo");
            cmbsts.SelectedIndex = 0;

            if (tipo_form == "atualização")
            {
                lbltitulo.Text = "Editar marca";
                lblsubtitulo.Text = "Preencha as informações para editar o marca";

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Deseja deletar a categoria {txtnome.Text}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCategoria cCategoria = new classCategoria();

                if (cCategoria.DeletarCategoria(Convert.ToInt32(txtid.Text)) == 1)
                {
                    MessageBox.Show($"Categoria: {txtnome.Text} foi deletado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Não foi possivel deletar a categoria pois existem produtos cadastrados!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnome.Text))
            {
                MessageBox.Show("Por favor preencha o nome da categoria", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblnome.ForeColor = Color.Red;
                txtnome.Focus();
            }
            else
            {
                classCategoria cCategoria = new classCategoria();

                cCategoria.nome = txtnome.Text;

                cCategoria.observacao = txtobs.Text;

                if(cmbsts.SelectedIndex == 0)
                {
                    cCategoria.status = 1;
                }
                else
                {
                    cCategoria.status = 0;
                }

                if (cCategoria.AtualizarCategoria(Convert.ToInt32(txtid.Text)) == 1)
                {
                    MessageBox.Show($"Categoria: {cCategoria.nome} foi atualizado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
