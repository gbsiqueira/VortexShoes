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
    public partial class frmCadProduto : Form
    {

        public string foto_produto, cor, tipo_form, fotoAtual;

        public int status, fornecedor, marca, categoria, destaque;

        public frmCadProduto()
        {
            InitializeComponent();
        }

        private void frmCadProduto_Load(object sender, EventArgs e)
        {
            classCategoria cCategoria = new classCategoria();
            classFornecedor cFornecedor = new classFornecedor();
            classMarca cMarca = new classMarca();


            cmbcategoria.DataSource = cCategoria.CarregarCombo();
            cmbcategoria.DisplayMember = "nome_categoria";
            cmbcategoria.ValueMember = "id_categoria";
            cmbcategoria.SelectedIndex = -1;

            cmbdestaque.Items.Add("Desativado");
            cmbdestaque.Items.Add("Ativado");
            cmbdestaque.SelectedIndex = 0;

            cmbfornecedor.DataSource = cFornecedor.CarregarCombo();
            cmbfornecedor.DisplayMember = "nome_fornecedor";
            cmbfornecedor.ValueMember = "id_fornecedor";
            cmbfornecedor.SelectedIndex = -1;

            cmbmarca.DataSource = cMarca.CarregarCombo();
            cmbmarca.DisplayMember = "nome_marca";
            cmbmarca.ValueMember = "id_marca";
            cmbmarca.SelectedIndex = -1;

            cmbstatus.Items.Add("Ativo");
            cmbstatus.Items.Add("Inativo");
            cmbstatus.SelectedIndex = 0;


            cmbcor.Items.Add("Amarelo");
            cmbcor.Items.Add("Azul");
            cmbcor.Items.Add("Bege");
            cmbcor.Items.Add("Branco");
            cmbcor.Items.Add("Cinza");
            cmbcor.Items.Add("Laranja");
            cmbcor.Items.Add("Marrom");
            cmbcor.Items.Add("Preto");
            cmbcor.Items.Add("Rosa");
            cmbcor.Items.Add("Roxo");
            cmbcor.Items.Add("Verde");
            cmbcor.Items.Add("Vermelho");
            cmbcor.SelectedIndex = -1;

            if (tipo_form == "atualização")
            {
                lbltitulo.Text = "Editar Produto";

                lbltitulo.Text = "Editar marca";
                lblsubtitulo.Text = "Preencha as informações para editar o marca";

                cmbstatus.Enabled = true;

                if (status == 1)
                {
                    cmbstatus.SelectedIndex = 0;
                }
                else
                {
                    cmbstatus.SelectedIndex = 1;
                }

                if(destaque == 1)
                {
                    cmbdestaque.SelectedIndex = 1;
                }
                else
                {
                    cmbdestaque.SelectedIndex = 0;
                }

                cmbmarca.SelectedValue = marca;
                cmbfornecedor.SelectedValue = fornecedor;
                cmbcategoria.SelectedValue = categoria;
                cmbcor.SelectedItem = cor;

                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                btnedit.Enabled = true;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Deseja deletar o Produto {txtnome.Text}?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                classProduto cProduto = new classProduto();

                int id = Convert.ToInt32(txtid.Text);

                if (cProduto.DeletarProduto(id) == 1)
                {
                    MessageBox.Show($"Produto(a): {txtnome.Text} foi excluído com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"O produto {txtnome.Text} não pode ser excluido pois possui histórico em vendas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtestoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnome.Text) || string.IsNullOrWhiteSpace(txttamanho.Text) || string.IsNullOrWhiteSpace(txtcustoproduto.Text) || string.IsNullOrWhiteSpace(txtvalorproduto.Text) || cmbcategoria.SelectedIndex == -1 || cmbfornecedor.SelectedIndex == -1 || cmbmarca.SelectedIndex == -1 || cmbcor.SelectedIndex == -1 || cmbdestaque.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtestoque.Text))
            {
                MessageBox.Show("Por Favor Preencher Todos os Campos Obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnome.Focus();
                lblnome.ForeColor = Color.Red;
                lbltamanho.ForeColor = Color.Red;
                lblcategoria.ForeColor = Color.Red;
                lblcustoproduto.ForeColor = Color.Red;
                lblvalorproduto.ForeColor = Color.Red;
                lblfornecedor.ForeColor = Color.Red;
                lblmarca.ForeColor = Color.Red;
                lblcor.ForeColor = Color.Red;
                lblstatus.ForeColor = Color.Red;
                lblimagemprincipal.ForeColor = Color.Red;
                lblprodutodestaque.ForeColor = Color.Red;
                lblestoque.ForeColor = Color.Red;
                return;
            }


            string custoLimpo = txtcustoproduto.Text.Replace("R$", "").Trim();
            string valorLimpo = txtvalorproduto.Text.Replace("R$", "").Trim();



            if (!decimal.TryParse(custoLimpo, out decimal custo) || !decimal.TryParse(valorLimpo, out decimal valor))
            {
                MessageBox.Show("Verifique os se os valores numericos informados estão corretos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcustoproduto.Focus();
                lblcustoproduto.ForeColor = Color.Red;
                lblvalorproduto.ForeColor = Color.Red;

                return;
            }


            if (custo > valor)
            {
                MessageBox.Show("O custo do produto não pode ser maior do que o valor de venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            classProduto cProduto = new classProduto();

            cProduto.nome_produto = txtnome.Text;


            cProduto.produto_foto1 = fotoAtual;

            if (!string.IsNullOrWhiteSpace(foto_produto) &&
                File.Exists(foto_produto))
            {
                string pastaRaizProjeto = Path.GetFullPath(
                    Path.Combine(Application.StartupPath, @"..\..\..\..\"));

                string pastaDestino = Path.Combine(
                    pastaRaizProjeto, "imagens-produtos");

                if (!Directory.Exists(pastaDestino))
                {
                    Directory.CreateDirectory(pastaDestino);
                }

                string nomeArquivo = Path.GetFileName(foto_produto);
                string caminhoFinal = Path.Combine(pastaDestino, nomeArquivo);

                File.Copy(foto_produto, caminhoFinal, overwrite: true);

                cProduto.produto_foto1 = nomeArquivo;
            }


            cProduto.cor = cmbcor.SelectedItem.ToString();

            cProduto.id_fornecedor = Convert.ToInt32(cmbfornecedor.SelectedValue);

            cProduto.id_marca = Convert.ToInt32(cmbmarca.SelectedValue);

            cProduto.id_categoria = Convert.ToInt32(cmbcategoria.SelectedValue);

            cProduto.preco_custo = custo;

            cProduto.preco_venda = valor;

            cProduto.tamanho = txttamanho.Text;

            if(cmbstatus.SelectedIndex == 0)
            {
                cProduto.status_produto = 1;
            }
            else
            {
                cProduto.status_produto = 0;
            }

            if(cmbdestaque.SelectedIndex == 0)
            {
                cProduto.destaque = 0;
            }
            else
            {
                cProduto.destaque = 1;
            }

            if (!int.TryParse(txtestoque.Text, out int estoque))
            {
                MessageBox.Show("Verifique o valor informado no campo estoque", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblestoque.ForeColor = Color.Red;
                return;
            }

            cProduto.estoque = estoque;


            if (!string.IsNullOrWhiteSpace(txtlucro.Text))
            {
                string lucroLimpo = txtlucro.Text.Replace("R$", "").Trim();

                if (decimal.TryParse(lucroLimpo, out decimal lucro))
                {
                    cProduto.lucro = lucro;
                }
                else
                {
                    cProduto.lucro = 0;
                }
            }



            if (cProduto.AtualizarProduto(Convert.ToInt32(txtid.Text)) != 1)
            {
                MessageBox.Show("Erro ao Atualizar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Produto: {cProduto.nome_produto} foi atualizado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

      

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnome.Text) || string.IsNullOrWhiteSpace(txttamanho.Text) || string.IsNullOrWhiteSpace(txtcustoproduto.Text) || string.IsNullOrWhiteSpace(txtvalorproduto.Text) || cmbcategoria.SelectedIndex == -1 || cmbfornecedor.SelectedIndex == -1 || cmbmarca.SelectedIndex == -1 || cmbcor.SelectedIndex == -1 || cmbdestaque.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtestoque.Text))
            {
                MessageBox.Show("Por Favor Preencher Todos os Campos Obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnome.Focus();
                lblnome.ForeColor = Color.Red;
                lbltamanho.ForeColor = Color.Red;
                lblcategoria.ForeColor = Color.Red;
                lblcustoproduto.ForeColor = Color.Red;
                lblvalorproduto.ForeColor = Color.Red;
                lblfornecedor.ForeColor = Color.Red;
                lblmarca.ForeColor = Color.Red;
                lblcor.ForeColor = Color.Red;
                lblstatus.ForeColor = Color.Red;
                lblimagemprincipal.ForeColor = Color.Red;
                lblprodutodestaque.ForeColor = Color.Red;
                return;
            }

            
            string custoLimpo = txtcustoproduto.Text.Replace("R$", "").Trim();
            string valorLimpo = txtvalorproduto.Text.Replace("R$", "").Trim();
            


            if (!decimal.TryParse(custoLimpo, out decimal custo) || !decimal.TryParse(valorLimpo, out decimal valor))
            {
                MessageBox.Show("Verifique os se os valores numericos informados estão corretos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcustoproduto.Focus();
                lblcustoproduto.ForeColor = Color.Red;
                lblvalorproduto.ForeColor = Color.Red;

                return;
            }


            if (custo > valor)
            {
                MessageBox.Show("O custo do produto não pode ser maior do que o valor de venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            classProduto cProduto = new classProduto();

            cProduto.nome_produto = txtnome.Text;

            
            if (!string.IsNullOrWhiteSpace(foto_produto) && File.Exists(foto_produto))
            {
                string pastaRaizProjeto = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\..\..\"));
                string pastaDestino = Path.Combine(pastaRaizProjeto, "imagens-produtos");

                if (!Directory.Exists(pastaDestino))
                {
                    Directory.CreateDirectory(pastaDestino);
                }

                string nomeArquivo = Path.GetFileName(foto_produto);
                string caminhoFinal = Path.Combine(pastaDestino, nomeArquivo);

                File.Copy(foto_produto, caminhoFinal, overwrite: true);

                cProduto.produto_foto1 = nomeArquivo;
            }
            else
            {
                MessageBox.Show("A foto do produto é obrigatória", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblimagemprincipal.ForeColor = Color.Red;
                return;
            }

            cProduto.cor = cmbcor.SelectedItem.ToString();

            cProduto.id_fornecedor = Convert.ToInt32(cmbfornecedor.SelectedValue);

            cProduto.id_marca = Convert.ToInt32(cmbmarca.SelectedValue);

            cProduto.id_categoria = Convert.ToInt32(cmbcategoria.SelectedValue);

            cProduto.preco_custo = custo;

            cProduto.preco_venda = valor;

            cProduto.tamanho = txttamanho.Text;

            cProduto.descricao = txtdescricao.Text;

            if (cmbdestaque.SelectedIndex == 0)
            {
                cProduto.destaque = 0;
            }
            else
            {
                cProduto.destaque = 1;
            }

            if(!int.TryParse(txtestoque.Text, out int estoque))
            {
                MessageBox.Show("Verifique o valor informado no campo estoque", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblestoque.ForeColor = Color.Red;
                return;
            }

            cProduto.estoque = estoque;

            if (!string.IsNullOrWhiteSpace(txtlucro.Text))
            {
                string lucroLimpo = txtlucro.Text.Replace("R$", "").Trim();

                if(decimal.TryParse(lucroLimpo, out decimal lucro))
                {
                    cProduto.lucro = lucro;
                }
                else
                {
                    cProduto.lucro = 0;
                }
            }

            if(cProduto.InserirProduto() != 1)
            {
                MessageBox.Show("Erro ao cadastrar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Produto: {cProduto.nome_produto} foi cadastrado com sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();


        }
      

        private void txtlucro_Leave(object sender, EventArgs e)
        {

            string textoCusto = txtcustoproduto.Text.Replace("R$", "").Trim();
            string textoLucro = txtlucro.Text.Replace("%", "").Trim();

            if (decimal.TryParse(textoCusto, out decimal custo) && decimal.TryParse(textoLucro, out decimal lucro))
            {
                decimal valorLucro = custo * (lucro / 100);
                decimal valorVenda = custo + valorLucro;


                txtvalorproduto.Text = valorVenda.ToString("N2");
            }
        }

        public void LimparCampos()
        {
            txtnome.Clear();
            txttamanho.Clear();
            cmbcor.SelectedIndex = -1;
            cmbcategoria.SelectedIndex = -1;
            cmbmarca.SelectedIndex = -1;
            cmbfornecedor.SelectedIndex = -1;
            txtlucro.Clear();
            txtvalorproduto.Clear();
            txtcustoproduto.Clear();
            pctfoto.Image = pctfoto.InitialImage;
            foto_produto = null;
            txtdescricao.Clear();
            cmbdestaque.SelectedIndex = 0;
            txtestoque.Clear();
        }

        private void PermitirApenasNumerosEVirgula_KeyPress(object sender, KeyPressEventArgs e)
        {
            string textoAtual = "";

            if (sender is TextBox txt)
            {
                textoAtual = txt.Text;
            }
            else if (sender is MaskedTextBox msk)
            {
                textoAtual = msk.Text;
            }
            else
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == ',' && textoAtual.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {   
            using (OpenFileDialog Oopenfiledialog = new OpenFileDialog())
            {
                Oopenfiledialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
                Oopenfiledialog.Title = "Selecione uma imagem para o funcionário";
                if (Oopenfiledialog.ShowDialog() == DialogResult.OK)
                {
                    //ARMAZENA O CAMINHO COMPLETO DA IMAGEM
                    foto_produto = Oopenfiledialog.FileName;

                    using (var stream = new FileStream(foto_produto, FileMode.Open, FileAccess.Read))
                    {
                        pctfoto.Image = Image.FromStream(stream);
                    }
                }
            }
        }
    }

}