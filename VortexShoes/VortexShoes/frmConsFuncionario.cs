using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VortexShoes
{
    public partial class frmConsFuncionario : Form
    {
        
        public frmConsFuncionario()
        {
            InitializeComponent();
            this.AcceptButton = btPesquisar;           
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o formulário?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void formConsFuncionario_Load(object sender, EventArgs e)
        {
            cmbsexo.Items.Add("Masculino");
            cmbsexo.Items.Add("Feminino");
            cmbsexo.Items.Add("Não Informado");
            cmbsexo.SelectedIndex = -1;

            cmbstatus.Items.Add("Ativo");
            cmbstatus.Items.Add("Inativo");
            cmbstatus.SelectedIndex = 0;

            classCargo cCargo = new classCargo();

            //TRAZER ITENS EXTERNOS É O DATASOURCE, E COLOCA O METODO PARA CARREGAR A COMBO
            cmbcargo.DataSource = cCargo.CarregarCombo();
            //O QUE SERA EXIBIDO NA COMBO, COLOQUE O NOME DA COLUNA DO BANCO, TEM QUE SER IGUAL!
            cmbcargo.DisplayMember = "nome";
            //O QUE SERA ARMAZENADO NO BANCO DE DADOS
            cmbcargo.ValueMember = "id_cargo";
            //NAO VIR NENHUMA PRE SELECIONADA
            cmbcargo.SelectedIndex = -1;


            //CARREGAR COMBO CIDADE
            classFuncionario cFuncionario = new classFuncionario();
            cmbcidade.DataSource = cFuncionario.CarregarComboCidadeConsulta();
            cmbcidade.DisplayMember = "cidade";
            cmbcidade.ValueMember = "cidade";
            cmbcidade.SelectedIndex = -1;

        }

        private void LimparFiltros()
        {
            txtNome.Clear();
            cmbsexo.SelectedIndex = -1;
            cmbstatus.SelectedIndex = 0;
            cmbcidade.SelectedIndex = -1;
            cmbcargo.SelectedIndex = -1;
            mskCpf.Clear();
            ckdata.Checked = false;
        }

        


        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja editar ou excluir o funcionario selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes) return;

            classFuncionario cFuncionario = new classFuncionario();

            //INSTANCIAR O OBJETO DA CLASS FORM FUNCIONARIO
            frmCadFuncionario fFuncionario = new frmCadFuncionario();

            cFuncionario.BuscarDadosFuncionarios(Convert.ToInt32(dgvFuncionario.SelectedRows[0].Cells[0].Value));

            fFuncionario.txtidfuncionario.Text = cFuncionario.id_funcionario.ToString();

            fFuncionario.txtnome.Text = cFuncionario.nome;

            fFuncionario.txtnomesocial.Text = cFuncionario.nome_social;


            string nomeArquivo = cFuncionario.foto;

            string pastaRaizProjeto = Path.GetFullPath(
                Path.Combine(Application.StartupPath, @"..\..\..\..\"));

            string pastaFotos = Path.Combine(
                pastaRaizProjeto, "images-funcionarios");

            if (!string.IsNullOrWhiteSpace(nomeArquivo))
            {
                string caminhoCompleto = Path.Combine(pastaFotos, nomeArquivo);

                if (File.Exists(caminhoCompleto))
                {
                    using (Image imagem = Image.FromFile(caminhoCompleto))
                    {
                        fFuncionario.pctfoto.Image = new Bitmap(imagem);
                    }
                }
                else
                {
                    MessageBox.Show("Imagem não encontrada:\n" + caminhoCompleto);
                    fFuncionario.pctfoto.Image = null;
                }
            }
            else
            {
                fFuncionario.pctfoto.Image = null;
            }


            fFuncionario.data_nascimento = cFuncionario.data_nascimento;

            fFuncionario.sexo_funcionario = cFuncionario.sexo;

            fFuncionario.status = cFuncionario.status;

            if(cFuncionario.sexo == "m")
            {
                fFuncionario.cmbsexo.SelectedItem = "Masculino";
            }
            else if(cFuncionario.sexo == "f")
            {
                fFuncionario.cmbsexo.SelectedItem = "Feminino";
            }
            else
            {
                fFuncionario.cmbsexo.SelectedItem = "Não Informado";
            }


            fFuncionario.estado_civil = cFuncionario.estado_civil;

            fFuncionario.mskcpf.Text = cFuncionario.cpf.ToString();

            fFuncionario.mskrg.Text = cFuncionario.rg.ToString();

            fFuncionario.txtsalario.Text = cFuncionario.salario.ToString();

            fFuncionario.txtrua.Text = cFuncionario.endereco.ToString();

            fFuncionario.txtFunNumero.Text = cFuncionario.numero.ToString();

            fFuncionario.txtcomplemento.Text = cFuncionario.complemento.ToString();

            fFuncionario.txtbairro.Text = cFuncionario.bairro.ToString();

            fFuncionario.txtcidade.Text = cFuncionario.cidade.ToString();

            fFuncionario.estado = cFuncionario.estado;

            fFuncionario.mskcep.Text = cFuncionario.cep.ToString();

            fFuncionario.msktelefoneresidencial.Text = cFuncionario.telefone_residencial.ToString();

            fFuncionario.msktelefonecelular.Text = cFuncionario.telefone_celular.ToString();

            fFuncionario.txtemail.Text = cFuncionario.email.ToString();

            fFuncionario.txtusuario.Text = cFuncionario.usuario.ToString();

            fFuncionario.txtsenha.Text = cFuncionario.senha.ToString();

            fFuncionario.tipo_acesso = cFuncionario.tipo_acesso;

            if(fFuncionario.status == 1)
            {
                fFuncionario.cmbFunStatus.SelectedItem = "Ativo";
            }
            else
            {
                fFuncionario.cmbFunStatus.SelectedItem = "Inativo";
            }

            fFuncionario.data_cadastro = cFuncionario.data_cadastro;

            fFuncionario.cargo = cFuncionario.id_cargo;

            fFuncionario.tipo_form = "atualização";

            fFuncionario.ShowDialog();

        }
            

        private void btPesquisar_Click_1(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();

            string nome = "";

            if(!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                nome = txtNome.Text;
            }

            string cpf = "";

            if(mskCpf.MaskCompleted)
            {
                cpf = mskCpf.Text;
            }

            int status = 1;

            if(cmbstatus.SelectedIndex == 1)
            {
                status = 0;
            }
            

            string cidade = "";

            if (cmbcidade.SelectedIndex != -1)
            {
                cidade = cmbcidade.Text;
            }

            string sexo = "";

            if (cmbsexo.SelectedIndex != -1)
            {

                if (cmbsexo.SelectedIndex == 0)
                {
                    sexo = "m";
                }
                else if (cmbsexo.SelectedIndex == 1)
                {
                    sexo = "f";
                }
                else
                {
                    sexo = "n";
                }
            }

            DateTime inicio = new DateTime(1700, 1, 1);
            DateTime fim = new DateTime(1700, 1, 1);


            if (ckdata.Checked == true)
            {
                inicio = dtpDataInicial.Value;
                fim = dtpDataFinal.Value;

                if(inicio > fim)
                {
                    MessageBox.Show("A data inicial não pode ser maior que a data final!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            int cargo = 0;

            if(cmbcargo.SelectedIndex != 1)
            {
                cargo = Convert.ToInt32(cmbcargo.SelectedValue);
            }

            dgvFuncionario.DataSource = cFuncionario.BuscarFuncionario(nome, cpf, sexo, cidade, status, inicio, fim, ckdata.Checked, cargo);
        }

        private void btnLimparFlitros_Click(object sender, EventArgs e)
        {
            LimparFiltros();
        }

        private void dtpDataInicial_ValueChanged(object sender, EventArgs e)
        {
            dtpDataInicial.Format = DateTimePickerFormat.Short;
        }

        private void dtpDataFinal_ValueChanged(object sender, EventArgs e)
        {
            dtpDataFinal.Format = DateTimePickerFormat.Short;
        }

        private void ckdata_CheckedChanged(object sender, EventArgs e)
        {
            if(ckdata.Checked == true)
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

       
    }
}
