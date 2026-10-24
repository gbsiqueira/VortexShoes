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
    public partial class frmVenda : Form
    {
        //variavel global para o valor total da venda
        private List<classItensVenda> ListaItensVenda = new List<classItensVenda>();

        private decimal valorTotal = 0;

        public frmVenda()
        {
            InitializeComponent();
        }       

        private void formVenda_Load(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();

            //CARREGAR DATA DA VENDA
            lbldata.Text = DateTime.Now.ToShortDateString();

            //COMBO FORMA DE PAGAMENTO
            cmbFormaPagamento.Items.Add("Cartão de Crédito");
            cmbFormaPagamento.Items.Add("Cartão de Débito");
            cmbFormaPagamento.Items.Add("Dinheiro");
            cmbFormaPagamento.Items.Add("Pix");
            cmbFormaPagamento.SelectedIndex = -1;

            cmbFuncionario.DataSource = cFuncionario.BuscarVendaFuncionario();
            cmbFuncionario.ValueMember = "ID";
            cmbFuncionario.DisplayMember = "Nome";
            cmbFuncionario.SelectedIndex = -1;
        }

        private void btBuscaCliente_Click_1(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();

            string nome = null;

            if (!string.IsNullOrWhiteSpace(txtPesqCliente.Text))
            {
                nome = txtPesqCliente.Text;
            }

            

            dgvCliente.DataSource = cCliente.BuscarVendaCliente(nome);
        }

        private void btBuscaProduto_Click_1(object sender, EventArgs e)
        {
            classProduto cProduto = new classProduto();

            string nome = null;

            if (!string.IsNullOrWhiteSpace(txtPesqProduto.Text))
            {
                nome = txtPesqProduto.Text;
            }

            dgvProduto.DataSource = cProduto.BuscarProdutoVenda(nome);
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            classProduto cProduto = new classProduto();

            int idProduto = Convert.ToInt32(dgvProduto.Rows[e.RowIndex].Cells[0].Value);

            if (cProduto.BuscarDadosProduto(idProduto))
            {
                txtProduto.Text = cProduto.nome_produto;
                txtestoque.Text = cProduto.estoque.ToString();
                txtvalor.Text = cProduto.preco_venda.ToString("N2");
                txtqntd.Text = "1";

                txtqntd.Select();
            }
        }

        private void CalcularVenda()
        {
            lblquantidade.ForeColor = Color.White;

            if (string.IsNullOrWhiteSpace(txtProduto.Text))
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(txtqntd.Text) || txtqntd.Text == "0")
            {
                MessageBox.Show("Informe uma quantidade maior que 0", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblquantidade.ForeColor = Color.Red;
                txtqntd.Text = "1";
                txtqntd.Select();
                return;
            }

            decimal valor = 0;

            decimal.TryParse(txtvalor.Text, out valor);

            if (!int.TryParse(txtqntd.Text, out int quantidade))
            {
                MessageBox.Show("O valor informado não e válido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblquantidade.ForeColor = Color.Red;
                txtqntd.Text = "1";
                txtqntd.Select();
                return;
            }

           

            int estoque = Convert.ToInt32(txtestoque.Text);

            if (quantidade > estoque)
            {
                MessageBox.Show("A quantidade informada e maior do que o estoque atual", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblquantidade.ForeColor = Color.Red;
                txtqntd.Text = "1";
                txtqntd.Select();
                return;
            }

            decimal valorPagar = valor * quantidade;
            txttotal.Text = valorPagar.ToString();
        }

      

       private void AtualizarGrid()
       {
            classProduto cProduto = new classProduto();

            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("ID"));
            dt.Columns.Add(new DataColumn("Produto"));
            dt.Columns.Add(new DataColumn("Quantidade"));
            dt.Columns.Add(new DataColumn("Valor Unitário"));
            dt.Columns.Add(new DataColumn("Valor Total"));

            foreach(classItensVenda item in ListaItensVenda)
            {
                dt.Rows.Add(item.id_produto, cProduto.BuscaNomeProduto(item.id_produto), item.quantidade, item.valor_item, item.valor_total_item);
                dt.AcceptChanges();
            }

            dgvitens.DataSource = dt;

       }

        private void AdicionarItem()
        {
            if(dgvProduto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            classItensVenda cItensVenda = new classItensVenda();

            int idProduto = Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value);
            int quantidade = Convert.ToInt32(txtqntd.Text);
            decimal valorUnitario = Convert.ToDecimal(txtvalor.Text);

            cItensVenda.id_produto = idProduto;
            cItensVenda.quantidade = quantidade;
            cItensVenda.valor_item = valorUnitario;

            cItensVenda.valor_total_item = valorUnitario * quantidade;

            ListaItensVenda.Add(cItensVenda);

            valorTotal += cItensVenda.valor_total_item;

            txtValorTotal.Text = valorTotal.ToString("N2");

            txtQtdeItens.Text = ListaItensVenda.Count.ToString();

            AtualizarGrid();

            CalcularVenda();

            txtProduto.Text = "";
            txtestoque.Text = "";
            txtvalor.Text = "";
            txtqntd.Text = "1";
            txttotal.Text = "";
            
        }


        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtProduto.Text))
            {
                MessageBox.Show("Selecione algum produto na Grid!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblpro.ForeColor = Color.Red;
                return;
            }

            classItensVenda cItemVenda = new classItensVenda();

            AdicionarItem();

            CalcularDescontoTotal();

             
        }

        private void CalcularDescontoTotal()
        {
            decimal percentualDesconto = 0;

            decimal.TryParse(txtPercentualDesconto.Text, out percentualDesconto);

            if (percentualDesconto < 0)
            {
                percentualDesconto = 0;
            }

            if (percentualDesconto > 100)
            {
                percentualDesconto = 100;
            }

            decimal valorDesconto = valorTotal * percentualDesconto / 100;

            decimal totalVenda = valorTotal - valorDesconto;

            
            txtTotalDesconto.Text = valorDesconto.ToString("N2");

            txtTotalVenda.Text = totalVenda.ToString("N2");
        }


        private void txtPercentualDesconto_TextChanged(object sender, EventArgs e)
        {
            CalcularDescontoTotal();
        }

        private void txtPercentualDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void LimparCampos()
        {
            txtPesqProduto.Clear();
            txtPesqCliente.Clear();
            cmbFuncionario.SelectedIndex = -1;
            dgvCliente.DataSource = null;
            dgvitens.DataSource = null;
            dgvProduto.DataSource = null;
            ListaItensVenda.Clear(); //LIMPANDO A LISTA
            AtualizarGrid(); //DEPOIS ATUALIZA A GRID
            txtProduto.Clear();

            valorTotal = 0;
            txtvalor.Text = "0,00";

            txtTotalDesconto.Text = "0,00";
            txtPercentualDesconto.Text = "0,00";
            txtqntd.Text = "1";
            txtValorTotal.Text = "0,00";
            txtQtdeItens.Text = "0";

            cmbFormaPagamento.SelectedIndex = -1;
            cmbFuncionario.SelectedIndex = -1;
        }

        public void CalculaEstoque(int quantidade, int id)
        {
            classProduto cProduto = new classProduto();

            cProduto.BuscarDadosProduto(id);

            int estoque = cProduto.estoque;

            cProduto.AtualizarEstoque(estoque - quantidade, id);
        }

        private void txtqntd_TextChanged(object sender, EventArgs e)
        {
            CalcularVenda();
        }

        private void ValidarCampos()
        {
            lblfunc.ForeColor = Color.Red;
            lblpro.ForeColor = Color.Red;
            lblcli.ForeColor = Color.Red;
            lblFormaPagamento.ForeColor = Color.Red;
            lblitens.ForeColor = Color.Red;
        }


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            CalcularDescontoTotal();
        }

        private void btFechaVend_Click(object sender, EventArgs e)
        {
            if (dgvCliente.DataSource == null || dgvProduto.DataSource == null || cmbFuncionario.SelectedIndex == -1 || cmbFormaPagamento.SelectedIndex == -1 || dgvitens.DataSource == null)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ValidarCampos();
                return;
            }

            classVenda cVenda = new classVenda();

            cVenda.id_funcionario = Convert.ToInt32(cmbFuncionario.SelectedValue);
            cVenda.id_cliente = Convert.ToInt32(dgvCliente.SelectedCells[0].Value);
            cVenda.valor_total = Convert.ToDecimal(txtValorTotal.Text);

            if (!string.IsNullOrWhiteSpace(txtPercentualDesconto.Text))
            {
                cVenda.desconto = Convert.ToDecimal(txtPercentualDesconto.Text);
            }
            else
            {
                cVenda.desconto = 0;
            }

            cVenda.tipo_pagamento = cmbFormaPagamento.Text;
            int idpedido = cVenda.RealizarVenda();

            if (idpedido < 1)
            {
                MessageBox.Show("Erro ao Realizar a venda!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (classItensVenda Itens in ListaItensVenda)
            {
                Itens.id_pedido = idpedido;
                Itens.CadastrarItemVenda();
                CalculaEstoque(Itens.quantidade, Itens.id_produto);
            }

            MessageBox.Show("Venda Realizada com Sucesso!", "VortexShoes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();

        }
    }
}
