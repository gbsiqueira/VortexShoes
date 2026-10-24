using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VortexShoes
{
    public partial class frmCadCliente : Form
    {

        public string tipo_form, estado, estado2, sexo;
        public int statuscli, statusend1, statusend2;

        public int idEndereco1 = 0;
        public int idEndereco2 = 0;

        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            gpaddres2.Visible = true;
            btnremoveaddress.Visible = true;
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            gpaddres2.Visible = false;
            btnremoveaddress.Visible = false;
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SE A TECLA NAO FOR UMA TECLA NUMERICA, OU O BACKSPACE QUE SERIA O 8
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                //NAO DEIXA DIGITAR
                e.Handled = true;
            }
        }

        private void txtnumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SE A TECLA NAO FOR UMA TECLA NUMERICA, OU O BACKSPACE QUE SERIA O 8
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                //NAO DEIXA DIGITAR
                e.Handled = true;
            }
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
          
            cmbestado.Items.Add("SP");
            cmbestado.Items.Add("AC");
            cmbestado.Items.Add("AL");
            cmbestado.Items.Add("AP");
            cmbestado.Items.Add("AM");
            cmbestado.Items.Add("BA");
            cmbestado.Items.Add("CE");
            cmbestado.Items.Add("DF");
            cmbestado.Items.Add("ES");
            cmbestado.Items.Add("GO");
            cmbestado.Items.Add("MA");
            cmbestado.Items.Add("MT");
            cmbestado.Items.Add("MS");
            cmbestado.Items.Add("MG");
            cmbestado.Items.Add("PA");
            cmbestado.Items.Add("PB");
            cmbestado.Items.Add("PR");
            cmbestado.Items.Add("PE");
            cmbestado.Items.Add("PI");
            cmbestado.Items.Add("RJ");
            cmbestado.Items.Add("RN");
            cmbestado.Items.Add("RS");
            cmbestado.Items.Add("RO");
            cmbestado.Items.Add("RR");
            cmbestado.Items.Add("SC");
            cmbestado.Items.Add("SE");
            cmbestado.Items.Add("TO");

            cmbestado.SelectedIndex = -1;

            cmbstatuscli.Items.Add("Ativo");
            cmbstatuscli.Items.Add("Inativo");


            cmbstatusend.Items.Add("Ativo");
            cmbstatusend.Items.Add("Inativo");

            cmbstatusend2.Items.Add("Ativo");
            cmbstatusend2.Items.Add("Inativo");

            cmbestado2.Items.Add("SP");
            cmbestado2.Items.Add("AC");
            cmbestado2.Items.Add("AL");
            cmbestado2.Items.Add("AP");
            cmbestado2.Items.Add("AM");
            cmbestado2.Items.Add("BA");
            cmbestado2.Items.Add("CE");
            cmbestado2.Items.Add("DF");
            cmbestado2.Items.Add("ES");
            cmbestado2.Items.Add("GO");
            cmbestado2.Items.Add("MA");
            cmbestado2.Items.Add("MT");
            cmbestado2.Items.Add("MS");
            cmbestado2.Items.Add("MG");
            cmbestado2.Items.Add("PA");
            cmbestado2.Items.Add("PB");
            cmbestado2.Items.Add("PR");
            cmbestado2.Items.Add("PE");
            cmbestado2.Items.Add("PI");
            cmbestado2.Items.Add("RJ");
            cmbestado2.Items.Add("RN");
            cmbestado2.Items.Add("RS");
            cmbestado2.Items.Add("RO");
            cmbestado2.Items.Add("RR");
            cmbestado2.Items.Add("SC");
            cmbestado2.Items.Add("SE");
            cmbestado2.Items.Add("TO");

            cmbestado2.SelectedIndex = -1;


            cmbsexo.Items.Add("Masculino");
            cmbsexo.Items.Add("Feminino");
            cmbsexo.Items.Add("Não Informado");
            cmbsexo.SelectedIndex = -1;

            dtdatanascimento.MaxDate = DateTime.Now;


            if(tipo_form == "atualização")
            {

                lbltitulo.Text = "Editar cliente";
                lblsubtitulo.Text = "Preencha as informações para editar o cargo";


                cmbstatusend.Enabled = true;
                cmbstatusend2.Enabled = true;
                cmbstatuscli.Enabled = true;

                if (sexo == "m")
                {
                    cmbsexo.SelectedIndex = 0;
                }
                else if(sexo == "f")
                {
                    cmbsexo.SelectedIndex = 1;
                }
                else
                {
                    cmbsexo.SelectedIndex = 2;
                }


                if(statuscli == 1)
                {
                    cmbstatuscli.SelectedIndex = 0;
                }
                else
                {
                    cmbstatuscli.SelectedIndex = 1;
                }

                if (statusend1 == 1)
                {
                    cmbstatusend.SelectedIndex = 0;
                }
                else
                {
                    cmbstatusend.SelectedIndex = 1;
                }

                if (statusend2 == 1)
                {
                    cmbstatusend2.SelectedIndex = 0;
                }
                else if(statusend2 == 0)
                {
                    cmbstatusend2.SelectedIndex = 1;
                }
                else
                {
                    cmbstatusend2.SelectedIndex = 0;
                }

                cmbestado.SelectedItem = estado;

                cmbestado2.SelectedItem = estado2;

                btncadastrar.Enabled = false;
                btnedit.Enabled = true;
                btnDelete.Enabled = true;
                

            }
        }

        private void MudarStatus()
        {
            if(cmbstatuscli.SelectedIndex == 1)
            {
                cmbstatusend.SelectedIndex = 1;
                cmbstatusend2.SelectedIndex = 1;
            }
        }


        private void btncadastrar_Click(object sender, EventArgs e)

        {
            if (!ValidarCliente())
            {
                MessageBox.Show("Por favor Preencha todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CamposObrigatorios();
                return;
            }

            if (btnremoveaddress.Visible)
            {
                //CamposObrigatorios OBRIGATÓRIOS DO ENDEREÇO 2
                if (!ValidarEndereco2())
                {
                    MessageBox.Show("Por favor Preencha todos os campos obrigatórios do segundo endereço ou remova-o", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CamposObrigatoriosEndereco2();
                    return;
                }
                
            }

                classCliente cCliente = new classCliente();
                classEndereco cEndereco = new classEndereco();
            


                cCliente.nome = txtnome.Text;
                cCliente.nome_social = txtnomesocial.Text;
                cCliente.cpf_cliente = mskcpf.Text;
                cCliente.data_nascimento_cliente = Convert.ToDateTime(dtdatanascimento.Text);
                cCliente.telefone_cliente = msktelefonecelular.Text;
                cCliente.email = txtemail.Text;
                if(!msktelefone2.MaskCompleted)
                {
                    cCliente.telefone_cliente2 = "";
                }
                else
                {
                    cCliente.telefone_cliente2 = msktelefone2.Text;
                }
                
                if(cmbsexo.SelectedIndex == 0)
                {
                    cCliente.sexo_cliente = "m";
                }
                else if(cmbsexo.SelectedIndex == 1)
                {
                    cCliente.sexo_cliente = "f";
                }
                else
                {
                    cCliente.sexo_cliente = "n";
                }

                cEndereco.id_cliente = cCliente.InserirCliente();


                if (cEndereco.id_cliente == 0)
                {
                    MessageBox.Show("Erro ao cadastrar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    
                    cEndereco.cep = mskcep.Text;
                    cEndereco.bairro = txtbairro.Text;

                    if(!int.TryParse(txtnumero.Text, out int numero))
                    {
                        MessageBox.Show("Insira o número da casa é apenas numero", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cEndereco.numero = numero;
                    cEndereco.estado = cmbestado.SelectedItem.ToString();
                    cEndereco.cidade = txtcidade.Text;
                    cEndereco.complemento = txtcomplemento.Text;
                    cEndereco.rua = txtrua.Text;

                    if (cEndereco.InserirEndereco() == 0)
                    {
                        MessageBox.Show("Erro ao cadastrar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cEndereco.DeletarCliente();
                        return;
                    }

                    if(btnremoveaddress.Visible)
                    {
                        classEndereco cEndereco2 = new classEndereco();

                        if (!int.TryParse(txtnumero2.Text, out int numero2))
                        {
                            MessageBox.Show("Insira o número da casa é apenas numero", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        cEndereco2.id_cliente = cEndereco.id_cliente;
                         cEndereco2.numero = numero2;
                        cEndereco2.bairro = txtbairro2.Text;
                        cEndereco2.rua = txtrua2.Text;
                        cEndereco2.estado = cmbestado2.SelectedItem.ToString();
                        cEndereco2.cidade = txtcidade2.Text;
                        cEndereco2.cep = mskcep2.Text;
                        cEndereco2.complemento = txtcomplemento2.Text;

                        if(cEndereco2.InserirEndereco() == 0)
                        {
                            MessageBox.Show("Erro ao cadastrar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cEndereco2.DeletarTudo();
                            return;
                        }

                    }


                    MessageBox.Show($"Cliente: {cCliente.nome} foi cadastrado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (!ValidarCliente())
            {
                MessageBox.Show("Por favor Preencha todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CamposObrigatorios();
                return;
            }

            if (btnremoveaddress.Visible)
            {
                //CamposObrigatorios OBRIGATÓRIOS DO ENDEREÇO 2
                if (!ValidarEndereco2())
                {
                    MessageBox.Show("Por favor Preencha todos os campos obrigatórios do segundo endereço ou remova-o", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CamposObrigatoriosEndereco2();
                    return;
                }

            }

            classCliente cCliente = new classCliente();
            classEndereco cEndereco = new classEndereco();



            cCliente.nome = txtnome.Text;
            cCliente.nome_social = txtnomesocial.Text;
            cCliente.cpf_cliente = mskcpf.Text;
            cCliente.data_nascimento_cliente = Convert.ToDateTime(dtdatanascimento.Text);
            cCliente.telefone_cliente = msktelefonecelular.Text;
            cCliente.email = txtemail.Text;

            if (!msktelefone2.MaskCompleted)
            {
                cCliente.telefone_cliente2 = "";
            }
            else
            {
                cCliente.telefone_cliente2 = msktelefone2.Text;
            }

            if (cmbsexo.SelectedIndex == 0)
            {
                cCliente.sexo_cliente = "m";
            }
            else if (cmbsexo.SelectedIndex == 1)
            {
                cCliente.sexo_cliente = "f";
            }
            else
            {
                cCliente.sexo_cliente = "n";
            }

            if(cmbstatuscli.SelectedIndex == 0)
            {
                cCliente.status_cliente = 1;
            }
            else
            {
                cCliente.status_cliente = 0;
            }

            if(cCliente.AtualizarCliente(Convert.ToInt32(txtid.Text)) != 1)
            {
                MessageBox.Show("Erro ao editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            cEndereco.cep = mskcep.Text;
            cEndereco.bairro = txtbairro.Text;

            if (!int.TryParse(txtnumero.Text, out int numero))
            {
                MessageBox.Show("Insira o número da casa é apenas numero", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cEndereco.numero = numero;
            cEndereco.estado = cmbestado.SelectedItem.ToString();
            cEndereco.cidade = txtcidade.Text;
            cEndereco.complemento = txtcomplemento.Text;
            cEndereco.rua = txtrua.Text;

            if (cmbstatusend.SelectedIndex == 0)
            {
                cEndereco.status = 1;
            }
            else
            {
                cEndereco.status = 0;
            }

            if (cEndereco.AtualizarEndereco(Convert.ToInt32(txtidend.Text)) != 1)
            {
                MessageBox.Show("Erro ao editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnremoveaddress.Visible)
            {
                classEndereco cEndereco2 = new classEndereco();

                if (!int.TryParse(txtnumero2.Text, out int numero2))
                {
                    MessageBox.Show("Insira o número da casa é apenas numero", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cEndereco2.numero = numero2;
                cEndereco2.bairro = txtbairro2.Text;
                cEndereco2.rua = txtrua2.Text;
                cEndereco2.estado = cmbestado2.SelectedItem.ToString();
                cEndereco2.cidade = txtcidade2.Text;
                cEndereco2.cep = mskcep2.Text;
                cEndereco2.complemento = txtcomplemento2.Text;

                if(cmbstatusend2.SelectedIndex == 0)
                {
                    cEndereco2.status = 1;
                }
                else
                {
                    cEndereco2.status = 0;
                }

                if (int.TryParse(txtidend2.Text, out int idEnd2) && idEnd2 > 0)
                {
                    if (cEndereco2.AtualizarEndereco(idEnd2) != 1)
                    {
                        MessageBox.Show("Erro ao editar o endereço 2!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {

                    cEndereco2.id_cliente = Convert.ToInt32(txtid.Text);

                    if (cEndereco2.InserirEndereco() != 1)
                    {

                        MessageBox.Show("Erro ao editar o endereço 2!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }

            if(!string.IsNullOrWhiteSpace(txtnomesocial.Text))
            {
                MessageBox.Show($"Cliente: {cCliente.nome_social} foi atualizado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            MessageBox.Show($"Cliente: {cCliente.nome} foi atualizado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string nomeexibição;

            if (!string.IsNullOrWhiteSpace(txtnomesocial.Text))
            {
                nomeexibição = txtnomesocial.Text;
            }
            else
            {
                nomeexibição = txtnome.Text;
            }

            if (MessageBox.Show($"Deseja deletar o cliente {nomeexibição}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classCliente cCliente = new classCliente();
                classEndereco cEndereco = new classEndereco();

                if (cCliente.DeletarCliente(Convert.ToInt32(txtid.Text)) == 1 && cEndereco.DeletarEndereco(Convert.ToInt32(txtid.Text)) == 1)
                {
                    MessageBox.Show($"Cliente: {nomeexibição} foi deletado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Erro ao deletar o cliente!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cmbstatuscli_SelectedIndexChanged(object sender, EventArgs e)
        {
            MudarStatus();
        }

        private void mskcep_Leave(object sender, EventArgs e)
        {
            string cepLimpo = mskcep.Text.Replace("-", "").Replace(" ", "").Trim();

            if (cepLimpo.Length == 8)
            {
                try
                {
                    using (DataSet ds = new DataSet())
                    {
                        ds.ReadXml($"https://viacep.com.br/ws/{cepLimpo}/xml/");

                        if (!ds.Tables[0].Columns.Contains("erro"))
                        {
                            txtrua.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                            txtbairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                            txtcidade.Text = ds.Tables[0].Rows[0]["localidade"].ToString();
                            cmbestado.SelectedItem = ds.Tables[0].Rows[0]["uf"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao consultar CEP: {ex.Message}");
                }
            }
        }

        private void mskcep2_Leave(object sender, EventArgs e)
        {
            string cepLimpo = mskcep2.Text.Replace("-", "").Replace(" ", "").Trim();

            if (cepLimpo.Length == 8)
            {
                try
                {
                    using (DataSet ds = new DataSet())
                    {
                        ds.ReadXml($"https://viacep.com.br/ws/{cepLimpo}/xml/");

                        if (!ds.Tables[0].Columns.Contains("erro"))
                        {
                            txtrua2.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                            txtbairro2.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                            txtcidade2.Text = ds.Tables[0].Rows[0]["localidade"].ToString();
                            cmbestado2.SelectedItem = ds.Tables[0].Rows[0]["uf"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao consultar CEP: {ex.Message}");
                }
            }
        }

        public void CamposObrigatorios()
        {
            lblbairro.ForeColor = Color.Red;
            lblnome.ForeColor = Color.Red;
            lblnumero.ForeColor = Color.Red;
            lblcidade.ForeColor = Color.Red;
            lblcep.ForeColor = Color.Red;
            lblsexo.ForeColor = Color.Red;
            lbltelcelular.ForeColor = Color.Red;
            lblcpf.ForeColor = Color.Red;
            lbldatanascimento.ForeColor = Color.Red;
            lblestado.ForeColor = Color.Red;
            lblrua.ForeColor = Color.Red;
            lblemail.ForeColor = Color.Red;
        }

        public void LimparCampos()
        {
            txtnome.Clear();
            txtrua.Clear();
            txtnumero.Clear();
            cmbestado.SelectedIndex = -1;
            cmbsexo.SelectedIndex = -1;
            txtemail.Clear();
            txtcidade.Clear();
            txtbairro.Clear();
            txtcomplemento.Clear();
            txtnumero.Clear();
            mskcep.Clear();
            mskcpf.Clear();
            msktelefone2.Clear();
            msktelefonecelular.Clear();
            txtbairro2.Clear();
            txtnumero2.Clear();
            txtcomplemento2.Clear();
            txtrua2.Clear();
            mskcep2.Clear();
            cmbestado2.SelectedIndex = -1;
            txtcidade2.Clear();
            txtnomesocial.Clear();
        }



        public void CamposObrigatoriosEndereco2()
        {
            lblbairro2.ForeColor = Color.Red;
            lblrua2.ForeColor = Color.Red;
            lblestado2.ForeColor = Color.Red;
            lblnumero2.ForeColor = Color.Red;
            lblcidade2.ForeColor = Color.Red;
            lblcep2.ForeColor = Color.Red;
        }

        private bool ValidarCliente()
        {
            if (string.IsNullOrWhiteSpace(txtnome.Text) || !mskcpf.MaskCompleted || !mskcep.MaskCompleted || !msktelefonecelular.MaskCompleted || cmbsexo.SelectedIndex == -1 || cmbestado.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtbairro.Text) || string.IsNullOrWhiteSpace(txtrua.Text) || string.IsNullOrWhiteSpace(txtnumero.Text) || string.IsNullOrWhiteSpace(txtcidade.Text) || string.IsNullOrWhiteSpace(txtemail.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidarEndereco2()
        {
            //CamposObrigatorios OBRIGATORIOS DO ENDEREÇO 2
            if (string.IsNullOrWhiteSpace(txtbairro2.Text) || string.IsNullOrWhiteSpace(txtcidade2.Text) || string.IsNullOrWhiteSpace(txtnumero2.Text) || cmbestado2.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtrua2.Text) || !mskcep2.MaskCompleted)
            {
                
                return false;
            }
            else
            {
                return true;
            }
        }

       

    }
}
