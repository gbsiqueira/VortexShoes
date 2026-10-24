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
using System.Net.Http;
using System.Text.RegularExpressions;

namespace VortexShoes
{
    public partial class frmCadFuncionario : Form
    {

        public string fotofun, fotoatual;

        //VARIAVEIS QUE SERAM USADAS NO FORM DE CONSULTA 
        //TIPO - MANEIRA QUE O FORM SERÁ ABERTO
        //OUTRAS - SERAO OS DADOS QUE VIRIAM DO BANCO

        public string tipo_form, estado_civil, estado, sexo_funcionario;
        public int cargo, tipo_acesso, status;
        public DateTime data_cadastro, data_nascimento;

        public frmCadFuncionario()
        {
            InitializeComponent();
        }

        private void frmCadFuncionario_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBOS
            //ESTADO CIVIL
            //DROPDOWNLIST A PROPRIEDADE PARA NAO DEIXAR O USUARIO ESCREVER LIVREMENTE NA CMB
            cmbFunEstadoCivil.Items.Add("Selecione Estado Civil");
            cmbFunEstadoCivil.Items.Add("Solteiro(a)");
            cmbFunEstadoCivil.Items.Add("Casado(a)");
            cmbFunEstadoCivil.Items.Add("Divorciado(a)");
            cmbFunEstadoCivil.Items.Add("Viúvo(a)");
            cmbFunEstadoCivil.Items.Add("Separado(a) Judicialmente");
            cmbFunEstadoCivil.Items.Add("União Estável");

            cmbFunStatus.Items.Add("Ativo");
            cmbFunStatus.Items.Add("Inativo");


            cmbFunEstadoCivil.SelectedIndex = 0;

            cmbFunTipoAcesso.Items.Add("Comum");
            cmbFunTipoAcesso.Items.Add("Administrador");

            cmbFunTipoAcesso.SelectedIndex = 0;

            cmbFunEstado.Items.Add("SP");
            cmbFunEstado.Items.Add("AC");
            cmbFunEstado.Items.Add("AL");
            cmbFunEstado.Items.Add("AP");
            cmbFunEstado.Items.Add("AM");
            cmbFunEstado.Items.Add("BA");
            cmbFunEstado.Items.Add("CE");
            cmbFunEstado.Items.Add("DF");
            cmbFunEstado.Items.Add("ES");
            cmbFunEstado.Items.Add("GO");
            cmbFunEstado.Items.Add("MA");
            cmbFunEstado.Items.Add("MT");
            cmbFunEstado.Items.Add("MS");
            cmbFunEstado.Items.Add("MG");
            cmbFunEstado.Items.Add("PA");
            cmbFunEstado.Items.Add("PB");
            cmbFunEstado.Items.Add("PR");
            cmbFunEstado.Items.Add("PE");
            cmbFunEstado.Items.Add("PI");
            cmbFunEstado.Items.Add("RJ");
            cmbFunEstado.Items.Add("RN");
            cmbFunEstado.Items.Add("RS");
            cmbFunEstado.Items.Add("RO");
            cmbFunEstado.Items.Add("RR");
            cmbFunEstado.Items.Add("SC");
            cmbFunEstado.Items.Add("SE");
            cmbFunEstado.Items.Add("TO");

            cmbFunEstado.SelectedItem = "SP";

            //OBJETO DA CLASSE CARGO PARA USAR O METODO CARREGARCOMBO
            classCargo cCargo = new classCargo();

            //TRAZER ITENS EXTERNOS É O DATASOURCE, E COLOCA O METODO PARA CARREGAR A COMBO
            cmbcargo.DataSource = cCargo.CarregarCombo();
            //O QUE SERA EXIBIDO NA COMBO, COLOQUE O NOME DA COLUNA DO BANCO, TEM QUE SER IGUAL!
            cmbcargo.DisplayMember = "nome";
            //O QUE SERA ARMAZENADO NO BANCO DE DADOS
            cmbcargo.ValueMember = "id_cargo";
            //NAO VIR NENHUMA PRE SELECIONADA
            cmbcargo.SelectedIndex = -1;


            cmbsexo.Items.Add("Masculino");
            cmbsexo.Items.Add("Feminino");
            cmbsexo.Items.Add("Não Informado");
            cmbsexo.SelectedIndex = -1;

            dtdatanascimento.MaxDate = DateTime.Now;

            dtcadastro.Text = DateTime.Now.ToString();

            if(tipo_form == "atualização")
            {
                lbltitulo.Text = "Editar Funcionario";
                lblsubtitulo.Text = "Preencha as informações para editar o funcionario";

                cmbFunStatus.Enabled = true;
                btncadastrar.Enabled = false;
                btnedit.Enabled = true;
                btnDelete.Enabled = true;

                dtcadastro.Text = data_cadastro.ToString();
                cmbFunEstado.SelectedItem = estado;
                cmbFunEstadoCivil.SelectedItem = estado_civil;
                cmbcargo.SelectedValue = cargo;
                dtdatanascimento.Text = data_nascimento.ToString();

                if(tipo_acesso == 0)
                {
                    cmbFunTipoAcesso.SelectedItem = "Comum";
                }
                else
                {
                    cmbFunTipoAcesso.SelectedItem = "Administrador";
                }

               
                if(sexo_funcionario == "m")
                {
                    cmbsexo.SelectedIndex = 0;
                }
                else if(sexo_funcionario == "f")
                {
                    cmbsexo.SelectedIndex = 1;
                }
                else
                {
                    cmbsexo.SelectedIndex = 2;
                }

                if (status == 1)
                {
                    cmbFunStatus.SelectedItem = "Ativo";
                }
                else
                {
                    cmbFunStatus.SelectedItem = "Inativo";
                }

            }

        }
        

        private void btnedit_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE OS CAMPOS OBRIGATORIOS FORAM PREENCHIDOS PELO USUÁRIO
            if (string.IsNullOrWhiteSpace(txtnome.Text) || !mskcep.MaskCompleted || string.IsNullOrWhiteSpace(txtusuario.Text) || string.IsNullOrWhiteSpace(txtemail.Text) || string.IsNullOrWhiteSpace(txtsenha.Text) || cmbFunTipoAcesso.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtrua.Text) || string.IsNullOrWhiteSpace(txtbairro.Text) || string.IsNullOrWhiteSpace(cmbFunEstado.Text) || string.IsNullOrWhiteSpace(txtFunNumero.Text) || string.IsNullOrWhiteSpace(txtcidade.Text) || cmbcargo.SelectedIndex == -1 || !mskcpf.MaskCompleted || cmbsexo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor Preencha todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CamposObrigatoriosFuncionario();
            }
            else
            {

                if (!msktelefonecelular.MaskCompleted && !msktelefoneresidencial.MaskCompleted)
                {
                    MessageBox.Show("Ao menos um campo telefone deve ser preenchido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbltelefoneresidencial.ForeColor = Color.Red;
                    lbltelcelular.ForeColor = Color.Red;
                    return;
                }

                //PASSAR PARA O OBJETO TODOS OS CAMPOS QUE O USUARIO PODE PREENCHER
                classFuncionario cFuncionario = new classFuncionario();

                cFuncionario.nome = txtnome.Text;
                cFuncionario.nome_social = txtnomesocial.Text;

                //VE SE NAO ESTA VAZIO E SE O ARQUIVO EXISTE MESMO
                if (!string.IsNullOrWhiteSpace(fotofun) && File.Exists(fotofun))
                {
                    //PROCURA O NIVEL DA PASTA QUE TEM O ARQUIVO
                    string pastaRaizProjeto = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\..\"));
                    //DIZ O NOME DA PASTA
                    string pastaDestino = Path.Combine(pastaRaizProjeto, "images-funcionarios");

                    //CRIA A PASTA SE POR ALGUM MOTIVO ELA NAO EXISTIR
                    if (!Directory.Exists(pastaDestino))
                    {
                        Directory.CreateDirectory(pastaDestino);
                    }

                    string nomeArquivo = Path.GetFileName(fotofun);
                    string caminhoFinal = Path.Combine(pastaDestino, nomeArquivo);

                    //COPIA O ARQUIVO PARA A PASTA IMGFUNCIONARIO
                    File.Copy(fotofun, caminhoFinal, overwrite: true);

                    cFuncionario.foto = nomeArquivo;
                }

                cFuncionario.data_nascimento = Convert.ToDateTime(dtdatanascimento.Text);

                //cmbsexo
                if (cmbsexo.SelectedIndex == 0)
                {
                    cFuncionario.sexo = "m";
                }
                else if (cmbsexo.SelectedIndex == 1)
                {
                    cFuncionario.sexo = "f";
                }
                else
                {
                    cFuncionario.sexo = "n";
                }

                //ESTADO CIVIL
                if (cmbFunEstadoCivil.SelectedIndex == 0)
                {
                    cFuncionario.estado_civil = "";
                }
                else
                {
                    cFuncionario.estado_civil = cmbFunEstadoCivil.SelectedItem.ToString();
                }

                cFuncionario.cpf = mskcpf.Text;

                //RG MASCARA E CAMPO NAO OBRIGATORIO
                if (!mskrg.MaskCompleted)
                {
                    cFuncionario.rg = "";

                }
                else
                {
                    cFuncionario.rg = mskrg.Text;
                }


                //CAMPO DECIMAL NAO OBRIGATORIO NO BANCO DE DADOS
                if (string.IsNullOrWhiteSpace(txtsalario.Text))
                {
                    cFuncionario.salario = 0;
                }
                else
                {
                    //CONVERTER O SALARIO
                    if (decimal.TryParse(txtsalario.Text, out decimal salario))
                    {
                        cFuncionario.salario = salario;

                        if (salario > 99999.99m)
                        {
                            MessageBox.Show("O salário excede o valor permitido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }

                cFuncionario.endereco = txtrua.Text;

                //CONVERTER O NUMERO
                if (int.TryParse(txtFunNumero.Text, out int numero))
                {
                    cFuncionario.numero = numero;
                }

                cFuncionario.complemento = txtcomplemento.Text;
                cFuncionario.bairro = txtbairro.Text;
                cFuncionario.cidade = txtcidade.Text;

                //ESTADO, CONVERTE EM STRING
                cFuncionario.estado = cmbFunEstado.SelectedItem.ToString();
                cFuncionario.cep = mskcep.Text;

                //CAMPOS TELEFONE
                if (!msktelefoneresidencial.MaskCompleted)
                {
                    cFuncionario.telefone_residencial = "";
                }
                else
                {
                    cFuncionario.telefone_residencial = msktelefoneresidencial.Text;
                }

                if (!msktelefonecelular.MaskCompleted)
                {
                    cFuncionario.telefone_celular = "";
                }
                else
                {
                    cFuncionario.telefone_celular = msktelefonecelular.Text;
                }

                cFuncionario.email = txtemail.Text;
                cFuncionario.usuario = txtusuario.Text;
                cFuncionario.senha = txtsenha.Text;

                //TIPO ACESSO
                cFuncionario.tipo_acesso = cmbFunTipoAcesso.SelectedIndex;

                //CODIGO CARGO
                cFuncionario.id_cargo = Convert.ToInt32(cmbcargo.SelectedValue);

                cFuncionario.id_funcionario = Convert.ToInt32(txtidfuncionario.Text);

                //IF PARA STATUS
               if(cmbFunStatus.SelectedIndex == 0)
               {
                    cFuncionario.status = 1;
               }
               else
               {
                    cFuncionario.status = 0;
               }

                cFuncionario.foto = fotoatual;

                if (!string.IsNullOrWhiteSpace(fotofun) && File.Exists(fotofun))
                {
                    string pastaRaizProjeto = Path.GetFullPath(
                        Path.Combine(Application.StartupPath, @"..\..\..\..\"));

                    string pastaDestino = Path.Combine(
                        pastaRaizProjeto, "images-funcionarios");

                    if (!Directory.Exists(pastaDestino))
                    {
                        Directory.CreateDirectory(pastaDestino);
                    }

                    string nomeArquivo = Path.GetFileName(fotofun);
                    string caminhoFinal = Path.Combine(pastaDestino, nomeArquivo);

                    File.Copy(fotofun, caminhoFinal, overwrite: true);

                    cFuncionario.foto = nomeArquivo;
                }



                //CHAMANDO METÓDO
                if (cFuncionario.AtualizarFuncionario() == 1)
                {
                    if (cFuncionario.nome_social == "")
                    {
                        MessageBox.Show($"Funcionário(a): {cFuncionario.nome} foi atualizado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Funcionário(a): {cFuncionario.nome_social} foi atualizado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
                else
                {
                    MessageBox.Show("Erro ao atualizar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Deseja deletar o funcionário(a) {txtnome.Text}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classFuncionario cFuncionario = new classFuncionario();

                cFuncionario.id_funcionario = Convert.ToInt32(txtidfuncionario.Text);

                if(cFuncionario.DeletarFuncionario() == 1)
                {
                    MessageBox.Show($"Funcionário(a): {txtnome.Text} foi excluído com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Funcionário(a) não pode ser excluído pois possui registro em vendas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE OS CAMPOS OBRIGATORIOS FORAM PREENCHIDOS PELO USUÁRIO
            if (string.IsNullOrWhiteSpace(txtnome.Text) || !mskcep.MaskCompleted || string.IsNullOrWhiteSpace(txtusuario.Text) || string.IsNullOrWhiteSpace(txtemail.Text) || string.IsNullOrWhiteSpace(txtsenha.Text) || cmbFunTipoAcesso.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtrua.Text) || string.IsNullOrWhiteSpace(txtbairro.Text) || string.IsNullOrWhiteSpace(cmbFunEstado.Text) || string.IsNullOrWhiteSpace(txtFunNumero.Text) || string.IsNullOrWhiteSpace(txtcidade.Text) || cmbcargo.SelectedIndex == -1 || !mskcpf.MaskCompleted || cmbsexo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor Preencha todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CamposObrigatoriosFuncionario();
            }
            else
            {

                if (!msktelefonecelular.MaskCompleted && !msktelefoneresidencial.MaskCompleted)
                {
                    MessageBox.Show("Ao menos um campo telefone deve ser preenchido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbltelefoneresidencial.ForeColor = Color.Red;
                    lbltelcelular.ForeColor = Color.Red;
                    return;
                }

                //PASSAR PARA O OBJETO TODOS OS CAMPOS QUE O USUARIO PODE PREENCHER
                classFuncionario cFuncionario = new classFuncionario();

                cFuncionario.nome = txtnome.Text;
                cFuncionario.nome_social = txtnomesocial.Text;

                //VE SE NAO ESTA VAZIO E SE O ARQUIVO EXISTE MESMO
                if (!string.IsNullOrWhiteSpace(fotofun) && File.Exists(fotofun))
                {
                    //PROCURA O NIVEL DA PASTA QUE TEM O ARQUIVO
                    string pastaRaizProjeto = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\..\"));
                    //DIZ O NOME DA PASTA
                    string pastaDestino = Path.Combine(pastaRaizProjeto, "images-funcionarios");

                    //CRIA A PASTA SE POR ALGUM MOTIVO ELA NAO EXISTIR
                    if (!Directory.Exists(pastaDestino))
                    {
                        Directory.CreateDirectory(pastaDestino);
                    }

                    string nomeArquivo = Path.GetFileName(fotofun);
                    string caminhoFinal = Path.Combine(pastaDestino, nomeArquivo);

                    //COPIA O ARQUIVO PARA A PASTA IMGFUNCIONARIO
                    File.Copy(fotofun, caminhoFinal, overwrite: true);

                    cFuncionario.foto = nomeArquivo;
                }

                cFuncionario.data_nascimento = Convert.ToDateTime(dtdatanascimento.Text);

                //cmbsexo
                if (cmbsexo.SelectedIndex == 0)
                {
                    cFuncionario.sexo = "m";
                }
                else if (cmbsexo.SelectedIndex == 1)
                {
                    cFuncionario.sexo = "f";
                }
                else
                {
                    cFuncionario.sexo = "n";
                }

                //ESTADO CIVIL
                if (cmbFunEstadoCivil.SelectedIndex == 0)
                {
                    cFuncionario.estado_civil = "";
                }
                else
                {
                    cFuncionario.estado_civil = cmbFunEstadoCivil.SelectedItem.ToString();
                }

                cFuncionario.cpf = mskcpf.Text;

                //RG MASCARA E CAMPO NAO OBRIGATORIO
                if (!mskrg.MaskCompleted)
                {
                    cFuncionario.rg = "";

                }
                else
                {
                    cFuncionario.rg = mskrg.Text;
                }


                //CAMPO DECIMAL NAO OBRIGATORIO NO BANCO DE DADOS
                if (string.IsNullOrWhiteSpace(txtsalario.Text))
                {
                    cFuncionario.salario = 0;
                }
                else
                {
                    //CONVERTER O SALARIO
                    if (decimal.TryParse(txtsalario.Text, out decimal salario))
                    {
                        cFuncionario.salario = salario;

                        if(salario > 99999.99m)
                        {
                            MessageBox.Show("O salário excede o valor permitido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }

                cFuncionario.endereco = txtrua.Text;

                //CONVERTER O NUMERO
                if (int.TryParse(txtFunNumero.Text, out int numero))
                {
                    cFuncionario.numero = numero;
                }

                cFuncionario.complemento = txtcomplemento.Text;
                cFuncionario.bairro = txtbairro.Text;
                cFuncionario.cidade = txtcidade.Text;

                //ESTADO, CONVERTE EM STRING
                cFuncionario.estado = cmbFunEstado.SelectedItem.ToString();
                cFuncionario.cep = mskcep.Text;

                //CAMPOS TELEFONE
                if (!msktelefoneresidencial.MaskCompleted)
                {
                    cFuncionario.telefone_residencial = "";
                }
                else
                {
                    cFuncionario.telefone_residencial = msktelefoneresidencial.Text;
                }

                if (!msktelefonecelular.MaskCompleted)
                {
                    cFuncionario.telefone_celular = "";
                }
                else
                {
                    cFuncionario.telefone_celular = msktelefonecelular.Text;
                }

                cFuncionario.email = txtemail.Text;
                cFuncionario.usuario = txtusuario.Text;
                cFuncionario.senha = txtsenha.Text;

                //TIPO ACESSO
                cFuncionario.tipo_acesso = cmbFunTipoAcesso.SelectedIndex;

                //CODIGO CARGO
                cFuncionario.id_cargo = Convert.ToInt32(cmbcargo.SelectedValue);

                //CHAMANDO METÓDO
                if (cFuncionario.InserirFuncionario() == 1)
                {
                    if (cFuncionario.nome_social == "")
                    {
                        MessageBox.Show($"Funcionário(a): {cFuncionario.nome} foi cadastrado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show($"Funcionário(a): {cFuncionario.nome_social} foi cadastrado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }

                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void mskcep_Leave(object sender, EventArgs e)
        {
            BuscarCep();
        }

    

        private void CamposObrigatoriosFuncionario()
        {
            lblnome.ForeColor = Color.Red;
            lbldatanascimento.ForeColor = Color.Red;
            lblcpf.ForeColor = Color.Red;
            lblsexo.ForeColor = Color.Red;
            lblcep.ForeColor = Color.Red;
            lblrua.ForeColor = Color.Red;
            lblbairro.ForeColor = Color.Red;
            lblnumero.ForeColor = Color.Red;
            lblestado.ForeColor = Color.Red;
            lblcidade.ForeColor = Color.Red;
            lblcargo.ForeColor = Color.Red;
            lblstatus.ForeColor = Color.Red;
            lblemail.ForeColor = Color.Red;
            lblsenha.ForeColor = Color.Red;
            lblusuario.ForeColor = Color.Red;
            lbltipoacesso.ForeColor = Color.Red;
            lblnome.ForeColor = Color.Red;
        }

        private void LimparCampos()
        {
            txtbairro.Clear();
            txtcidade.Clear();
            txtcomplemento.Clear();
            txtemail.Clear();
            txtfoto.Clear();
            txtFunNumero.Clear();
            txtnome.Clear();
            txtnomesocial.Clear();
            txtrua.Clear();
            txtsalario.Clear();
            txtsenha.Clear();
            txtusuario.Clear();
            mskcep.Clear();
            mskcpf.Clear();
            msktelefoneresidencial.Clear();
            mskrg.Clear();
            msktelefonecelular.Clear();
            txtnome.Focus();
            cmbFunEstado.SelectedItem = "SP";
            cmbsexo.SelectedIndex = -1;
            cmbFunTipoAcesso.SelectedIndex = 0;
            cmbFunEstadoCivil.SelectedIndex = 0;
            cmbcargo.SelectedIndex = -1;
            fotofun = "";
            pctfoto.Image = null;
           
        }

        //PROPRIEDADE KEY PRESS, AO DIGITAR
        private void txtFunNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //SE A TECLA NAO FOR UMA TECLA NUMERICA, OU O BACKSPACE QUE SERIA O 8
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                //NAO DEIXA DIGITAR
                e.Handled = true;
            }
        }

        private void txtsalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MESMA IDEIA, MAS FOI LIBERADA A VIRGULA = 44, E PONTO = 46
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            //ABRE A JANELA DO WINDOWS PARA A ESCOLHA DE UM ARQUIVO
            using (OpenFileDialog Oopenfiledialog = new OpenFileDialog())
            {
                //APLICA UM FILTRO QUE PERMITE O USUARIO VER APENAS ARQUIVOS COM ESSAS EXTENSOES
                Oopenfiledialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
                //TITIULO DA JANELA
                Oopenfiledialog.Title = "Selecione uma imagem para o funcionário";
                //SE O USUARIO ESCOLHER UM ARQUIVO E APERTAR OK
                if (Oopenfiledialog.ShowDialog() == DialogResult.OK)
                {
                    //ARMAZENA O CAMINHO COMPLETO DA IMAGEM
                    fotofun = Oopenfiledialog.FileName;

                    using (var stream = new FileStream(fotofun, FileMode.Open, FileAccess.Read))
                    {
                        pctfoto.Image = Image.FromStream(stream);
                    }
                }
            }
        }

        private async Task BuscarCep()
        {
            // Remove qualquer caracter não numérico do campo mskcep
            string cep = Regex.Replace(mskcep.Text ?? "", @"[^\d]", "");

            // O CEP precisa de ter exatamente 8 dígitos para ser válido
            if (cep.Length != 8)
            {
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();

                        // Verifica se o ViaCEP retornou erro (CEP inexistente)
                        if (jsonResponse.Contains("\"erro\": true") || jsonResponse.Contains("\"erro\": \"true\""))
                        {
                            MessageBox.Show("CEP não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Função auxiliar para extrair o valor das chaves do JSON
                        string ExtrairValorJson(string json, string chave)
                        {
                            string padrao = $"\"{chave}\":\\s*\"(.*?)\"";
                            Match match = Regex.Match(json, padrao);
                            return match.Success ? match.Groups[1].Value : "";
                        }

                        string logradouro = ExtrairValorJson(jsonResponse, "logradouro");
                        string bairro = ExtrairValorJson(jsonResponse, "bairro");
                        string localidade = ExtrairValorJson(jsonResponse, "localidade"); // Cidade
                        string uf = ExtrairValorJson(jsonResponse, "uf");

                        // Preenche os campos do formulário
                        if (!string.IsNullOrWhiteSpace(logradouro)) txtrua.Text = logradouro;
                        if (!string.IsNullOrWhiteSpace(bairro)) txtbairro.Text = bairro;
                        if (!string.IsNullOrWhiteSpace(localidade)) txtcidade.Text = localidade;

                        if (!string.IsNullOrWhiteSpace(uf))
                        {
                            // Seleciona a UF na ComboBox se ela existir na lista
                            int index = cmbFunEstado.FindStringExact(uf);
                            if (index != -1)
                            {
                                cmbFunEstado.SelectedIndex = index;
                            }
                        }

                        // Move o foco para o campo do número do endereço
                        txtFunNumero.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar o CEP: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
