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
    public partial class frmRelProduto : Form
    {
        public frmRelProduto()
        {
            InitializeComponent();
        }

        private void frmRelProduto_Load(object sender, EventArgs e)
        {
            this.rtpproduto.RefreshReport();

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

        }

        private void LimparCampos()
        {
            cmbmarca.SelectedIndex = -1;
            cmbfornecedor.SelectedIndex = -1;
            cmbcategoria.SelectedIndex = -1;
            cmbstatus.SelectedIndex = 0;
            txtvalmin.Clear();
            txtvalormax.Clear();
            cmbcor.SelectedIndex = -1;
        }

        private void btnLimparFlitros_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();

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
                    MessageBox.Show("Por favor Verifique se os valores numericos informados estão corretos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (minvalue > maxvalue)
            {
                MessageBox.Show("O valor minimo não deve ser maior que o maximo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

               classProdutoBindingSource.DataSource  = cProduto.BuscarProdutoRelatorio(marca, fornecedor, categoria, cor, status, minvalue, maxvalue);
            this.rtpproduto.RefreshReport();
        }
    }
}
