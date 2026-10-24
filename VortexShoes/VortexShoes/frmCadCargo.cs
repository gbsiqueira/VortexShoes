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
    public partial class frmCadCargo : Form
    {

        public int cargo, status;
        public string observacao, tipo_form;
        public DateTime data_cadastro;

        public frmCadCargo()
        {
            InitializeComponent();
        }

        private void frmCadCargo_Load(object sender, EventArgs e)
        {
            cmbstscargo.Items.Add("Ativo");
            cmbstscargo.Items.Add("Desativado");
            cmbstscargo.SelectedIndex = 0;


            if(tipo_form == "atualização")
            {
                lbltitulo.Text = "Editar cargo";
                lblsubtitulo.Text = "Preencha as informações para editar o cargo";

                cmbstscargo.Enabled = true;

                if (status == 1)
                {
                    cmbstscargo.SelectedIndex = 0;
                }
                else
                {
                    cmbstscargo.SelectedIndex = 1;
                }

                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                btnedit.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            

            if (MessageBox.Show($"Deseja deletar o cargo {txtnome.Text}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCargo cCargo = new classCargo();

                if (cCargo.DeletarCargo(Convert.ToInt32(txtid.Text)) == 1)
                {
                    MessageBox.Show($"Cargo: {txtnome.Text} foi deletado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Não foi possivel deletar o cargo pois existem funciónarios cadastrados!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            classCargo cCargo = new classCargo();

            cCargo.nome = txtnome.Text;
            cCargo.observacao = txtobs.Text;
            cCargo.status = 1;

            if(cmbstscargo.SelectedIndex == 1)
            {
                cCargo.status = 0;
            }

            if (cCargo.AtualizarCargo(Convert.ToInt32(txtid.Text)) == 1)
            {
                MessageBox.Show($"Cargo: {cCargo.nome} foi atualizado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show($"Erro ao atualizar!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            //CRIAR OBJETO DA CLASSE CARGO PARA USAR AS PROPRIEDADES E OS METODOS
            classCargo cCargo = new classCargo();

            //VERIFICAR SE OS CAMPOS OBRIGATORIOS QUE DEVEM SER PREENCHIDOS PELO USUARIO NÃO ESTÃO VAZIOS
            if (!string.IsNullOrWhiteSpace(txtnome.Text))
            {
                //ATRIBUIR AS PROPRIEDADES DO MEU OBJETO DE TODOS OS ELEMENTOS QUE PODEM SER PREENCHIDOS PELO USUARIO
                cCargo.nome = txtnome.Text;
                cCargo.observacao = txtobs.Text;

                if (cCargo.InserirCargo() == 1)
                {
                    MessageBox.Show($"Cargo: {cCargo.nome} foi cadastrado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor preencha o nome do cargo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblnome.ForeColor = Color.Red;
                txtnome.Focus();
            }
        }

        private void LimparCampos()
        {
            txtnome.Clear();
            txtobs.Clear();
            txtnome.Focus();
        }

    }
}
