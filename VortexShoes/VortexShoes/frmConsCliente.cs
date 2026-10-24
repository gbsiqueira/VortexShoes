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
    public partial class frmConsCliente : Form
    {
        public frmConsCliente()
        {
            InitializeComponent();
        }

        private void btnLimparFlitros_Click(object sender, EventArgs e)
        {
            LimparFiltros();
        }

        private void LimparFiltros()
        {
            txtNome.Clear();
            cmbsexo.SelectedIndex = -1;
            cmbstatus.SelectedIndex = 0;
            cmbcidade.SelectedIndex = -1;
            mskCpf.Clear();
            ckdata.Checked = false;
            msktelefone.Clear();
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
            classCliente cCliente = new classCliente();

            string nome = null;

            if(!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                nome = txtNome.Text;
            }

            string cidade = null;

            if(cmbcidade.SelectedIndex != -1)
            {
                cidade = cmbcidade.SelectedValue.ToString();
            }

            string telefone = null;

            if(msktelefone.MaskCompleted)
            {
                telefone = msktelefone.Text;
            }

            string cpf = null;

            if(mskCpf.MaskCompleted)
            {
                cpf = mskCpf.Text;
            }

            string sexo = null; 

            if(cmbsexo.SelectedIndex != -1)
            {
                if(cmbsexo.SelectedIndex == 0)
                {
                    sexo = "m";
                }
                else if(cmbsexo.SelectedIndex == 1)
                {
                    sexo = "f";
                }
                else
                {
                    sexo = "n";
                }
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

            dgv.DataSource = cCliente.BuscarCliente(nome, cidade, telefone, cpf, sexo, status, inicio, fim, ckdata.Checked);
        }

        private void frmConsCliente_Load(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();

            cmbcidade.DataSource = cCliente.CarregarComboCons();
            cmbcidade.DisplayMember = "cidade";
            cmbcidade.ValueMember = "cidade";
            cmbcidade.SelectedIndex = -1;

            cmbsexo.Items.Add("Masculino");
            cmbsexo.Items.Add("Feminino");
            cmbsexo.Items.Add("Não Informado");
            cmbsexo.SelectedIndex = -1;

            cmbstatus.Items.Add("Ativo");
            cmbstatus.Items.Add("Inativo");
            cmbstatus.SelectedIndex = 0;

            dtpDataFinal.MaxDate = DateTime.Now;
            dtpDataInicial.MaxDate = DateTime.Now;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja editar ou excluir o funcionario selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes) return;

            classCliente cCliente = new classCliente();

            frmCadCliente fCliente = new frmCadCliente();

            

            if(cCliente.BuscarDadosCliente(Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value)))
            {
                fCliente.txtnome.Text = cCliente.nome;

                fCliente.txtnomesocial.Text = cCliente.nome_social;

                fCliente.txtemail.Text = cCliente.email;

                fCliente.txtid.Text = cCliente.id_cliente.ToString();

                fCliente.msktelefonecelular.Text = cCliente.telefone_cliente;

                fCliente.msktelefone2.Text = cCliente.telefone_cliente2;

                fCliente.mskcpf.Text = cCliente.cpf_cliente;

                fCliente.statuscli = cCliente.status_cliente;

                fCliente.dtdatanascimento.Value = cCliente.data_nascimento_cliente;

                fCliente.sexo = cCliente.sexo_cliente;

                fCliente.tipo_form = "atualização";


                classEndereco cEndereco = new classEndereco();

                List<classEndereco> listaEnderecos =  cEndereco.BuscarDadosEndereco(cCliente.id_cliente);

                if(listaEnderecos.Count > 0)
                {
                    fCliente.txtrua.Text = listaEnderecos[0].rua;

                    fCliente.txtcidade.Text = listaEnderecos[0].cidade;

                    fCliente.mskcep.Text = listaEnderecos[0].cep;

                    fCliente.txtnumero.Text = listaEnderecos[0].numero.ToString();

                    fCliente.txtcomplemento.Text = listaEnderecos[0].complemento;

                    fCliente.statusend1 = listaEnderecos[0].status;

                    fCliente.txtbairro.Text = listaEnderecos[0].bairro;

                    fCliente.estado = listaEnderecos[0].estado;

                    fCliente.txtidend.Text = listaEnderecos[0].id_endereco.ToString();

                    fCliente.statusend1 = listaEnderecos[0].status;
                }

                if(listaEnderecos.Count > 1)
                {
                    fCliente.txtrua2.Text = listaEnderecos[1].rua;

                    fCliente.txtcidade2.Text = listaEnderecos[1].cidade;

                    fCliente.mskcep2.Text = listaEnderecos[1].cep;

                    fCliente.txtnumero2.Text = listaEnderecos[1].numero.ToString();

                    fCliente.txtcomplemento2.Text = listaEnderecos[1].complemento;

                    fCliente.statusend2 = listaEnderecos[1].status;

                    fCliente.txtbairro2.Text = listaEnderecos[1].bairro;

                    fCliente.estado2 = listaEnderecos[1].estado;

                    fCliente.txtidend2.Text = listaEnderecos[1].id_endereco.ToString();

                    fCliente.statusend2 = listaEnderecos[1].status;

                    fCliente.gpaddres2.Visible = true;
                    fCliente.btnremoveaddress.Visible = true;
                }

                fCliente.ShowDialog();




            }



            

        }
    }
}
