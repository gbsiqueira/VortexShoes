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
    public partial class frmConsProduto : Form
    {
        public frmConsProduto()
        {
            InitializeComponent();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();

            string nome = null;

            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                nome = txtNome.Text;
            }

            int marca = 0;

            if (cmbmarca.SelectedIndex != -1)
            {
                marca = Convert.ToInt32(cmbmarca.SelectedValue);
            }

            int fornecedor = 0;

            if (cmbfornecedor.SelectedIndex != -1)
            {
                fornecedor = Convert.ToInt32(cmbfornecedor.SelectedValue);
            }

            int categoria = 0;

            if (cmbcategoria.SelectedIndex != -1)
            {
                categoria = Convert.ToInt32(cmbcategoria.SelectedValue);
            }

            int status = 1;

            if (cmbstatus.SelectedIndex != 0)
            {
                status = 0;
            }

            string tamanho = null;

            if (cmbtamanho.SelectedIndex != -1)
            {
                tamanho = cmbtamanho.SelectedValue.ToString();
            }

            string cor = null;

            if (cmbcor.SelectedIndex != -1)
            {
                cor = cmbcor.SelectedItem.ToString();
            }

            decimal minvalue = 0;
            decimal maxvalue = 0;

            string textomin = txtvalmin.Text.Replace("R$", "").Trim();
            string textomax = txtvalormax.Text.Replace("R$", "").Trim();

            if (!string.IsNullOrWhiteSpace(txtvalmin.Text) && !string.IsNullOrWhiteSpace(txtvalormax.Text))
            {
                if (!decimal.TryParse(textomin, out minvalue) || !decimal.TryParse(textomax, out maxvalue))
                {
                    MessageBox.Show("Por favor Verifique se os valores numéricos informados estão corretos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (minvalue > maxvalue)
            {
                MessageBox.Show("O valor minimo não deve ser maior que o maximo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgv.DataSource = cProduto.BuscarProduto(nome, marca, fornecedor, categoria, tamanho, cor, status, minvalue, maxvalue);
        }

        private void frmConsProduto_Load(object sender, EventArgs e)
        {
            classCategoria cCategoria = new classCategoria();
            classFornecedor cFornecedor = new classFornecedor();
            classMarca cMarca = new classMarca();
            classProduto cProduto = new classProduto();


            cmbcategoria.DataSource = cCategoria.CarregarComboCons();
            cmbcategoria.DisplayMember = "nome_categoria";
            cmbcategoria.ValueMember = "id_categoria";
            cmbcategoria.SelectedIndex = -1;

            cmbfornecedor.DataSource = cFornecedor.CarregarComboCons();
            cmbfornecedor.DisplayMember = "nome_fornecedor";
            cmbfornecedor.ValueMember = "id_fornecedor";
            cmbfornecedor.SelectedIndex = -1;

            cmbmarca.DataSource = cMarca.CarregarComboCons();
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


            cmbtamanho.DisplayMember = "tamanho";
            cmbtamanho.ValueMember = "tamanho";
            cmbtamanho.DataSource = cProduto.CarregarComboTamanho();
            cmbtamanho.SelectedIndex = -1;
        }

        private void btnLimparFlitros_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            cmbtamanho.SelectedIndex = -1;
            cmbmarca.SelectedIndex = -1;
            cmbfornecedor.SelectedIndex = -1;
            cmbcategoria.SelectedIndex = -1;
            cmbstatus.SelectedIndex = 0;
            txtvalmin.Clear();
            txtvalormax.Clear();
            cmbcor.SelectedIndex = -1;
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

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja editar ou excluir o funcionario selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes) return;

            classProduto cProduto = new classProduto();

            frmCadProduto fProduto = new frmCadProduto();

            cProduto.BuscarDadosProduto(Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value));


            fProduto.fotoAtual = cProduto.produto_foto1;

            string nomeArquivo = cProduto.produto_foto1;

            string pastaRaizProjeto = Path.GetFullPath(
                Path.Combine(Application.StartupPath, @"..\..\..\..\"));

            string pastaFotos = Path.Combine(
                pastaRaizProjeto, "imagens-produtos");

            if (!string.IsNullOrWhiteSpace(nomeArquivo))
            {
                string caminhoCompleto = Path.Combine(pastaFotos, nomeArquivo);

                if (File.Exists(caminhoCompleto))
                {
                    FileInfo arquivoInfo = new FileInfo(caminhoCompleto);

                    // Verifica se o arquivo não está vazio
                    if (arquivoInfo.Length > 0)
                    {
                        try
                        {
                            using (var fs = new FileStream(caminhoCompleto, FileMode.Open, FileAccess.Read))
                            {
                                using (var imgTemp = Image.FromStream(fs))
                                {
                                    fProduto.pctfoto.Image = new Bitmap(imgTemp);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("O arquivo de imagem está corrompido ou em formato inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            fProduto.pctfoto.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("O arquivo de imagem está vazio (0 bytes).", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        fProduto.pctfoto.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Imagem não encontrada:\n" + caminhoCompleto, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fProduto.pctfoto.Image = null;
                }

                fProduto.txtnome.Text = cProduto.nome_produto;

                fProduto.cor = cProduto.cor;

                fProduto.txttamanho.Text = cProduto.tamanho;

                fProduto.marca = cProduto.id_marca;

                fProduto.categoria = cProduto.id_categoria;

                fProduto.fornecedor = cProduto.id_fornecedor;

                fProduto.txtcustoproduto.Text = cProduto.preco_custo.ToString();

                fProduto.txtlucro.Text = cProduto.lucro.ToString();

                fProduto.txtvalorproduto.Text = cProduto.preco_venda.ToString();

                fProduto.status = cProduto.status_produto;

                fProduto.tipo_form = "atualização";

                fProduto.txtid.Text = cProduto.id_produto.ToString();

                fProduto.txtdescricao.Text = cProduto.descricao;

                fProduto.destaque = cProduto.destaque;

                fProduto.txtestoque.Text = cProduto.estoque.ToString();

                fProduto.ShowDialog();

            }
        }
    }
}
