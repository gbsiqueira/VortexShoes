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
    public partial class frmCadMarca : Form
    {

        public string tipo_form;
        public int status;

        public frmCadMarca()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnome.Text))
            {
                MessageBox.Show("Por favor preencha o nome da marca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblnome.ForeColor = Color.Red;
                txtnome.Focus();
            }
            else
            {
                classMarca cMarca = new classMarca();

                cMarca.nome = txtnome.Text;

                cMarca.observacao = txtobs.Text;

                if (cMarca.InserirMarca() == 1)
                {
                    MessageBox.Show($"Marca: {cMarca.nome} foi cadastrado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmCadMarca_Load(object sender, EventArgs e)
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

            if (MessageBox.Show($"Deseja deletar a marca {txtnome.Text}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classMarca cMarca = new classMarca();

                if (cMarca.DeletarMarca(Convert.ToInt32(txtid.Text)) == 1)
                {
                    MessageBox.Show($"Marca: {txtnome.Text} foi deletado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Não foi possivel deletar a marca pois existem produtos cadastrados!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnome.Text))
            {
                MessageBox.Show("Por favor preencha o nome da marca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblnome.ForeColor = Color.Red;
                txtnome.Focus();
            }
            else
            {
                classMarca cMarca = new classMarca();

                cMarca.nome = txtnome.Text;

                cMarca.observacao = txtobs.Text;

                if(cmbsts.SelectedIndex == 0)
                {
                    cMarca.status = 1;
                }
                else
                {
                    cMarca.status = 0;
                }

                if (cMarca.AtualizarMarca(Convert.ToInt32(txtid.Text)) == 1)
                {
                    MessageBox.Show($"Marca: {cMarca.nome} foi atualizado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
