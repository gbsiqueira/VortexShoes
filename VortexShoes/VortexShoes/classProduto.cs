using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace VortexShoes
{
    class classProduto
    {


        public classProduto()
        {
            id_produto = 0;

            id_marca = 0;

            id_categoria = 0;

            id_fornecedor = 0;

            nome_produto = null;

            produto_foto1 = null;

            produto_foto2 = null;

            produto_foto3 = null;

            produto_foto4 = null;

            data_cadastro = DateTime.Now;

            tamanho = null;

            descricao = null;

            preco_custo = 0;

            lucro = 0;

            preco_venda = 0;

            status_produto = 0;

            destaque = 0;

            estoque = 0;
        }

        public int id_produto { get; set; }

        public int id_marca { get; set; }

        public int id_categoria { get; set; }

        public int id_fornecedor { get; set; }

        public string nome_produto { get; set; }


        public string produto_foto1 { get; set; }

        public string produto_foto2 { get; set; }

        public string produto_foto3 { get; set; }

        public string produto_foto4 { get; set; }

        public DateTime data_cadastro { get; set; }

        public string tamanho { get; set; }


        public decimal preco_custo { get; set; }


        public decimal lucro { get; set; }

        public decimal preco_venda { get; set; }

        public int status_produto { get; set; }

        public string cor { get; set; }

        public string descricao { get; set; }

        public int destaque { get; set; }

        public int estoque { get; set; }

        public DataTable BuscarProduto(string nome, int marca, int fornecedor, int categoria, string tamanho, string cor, int status, decimal minvalue, decimal maxvalue)
        {
            string sql = $"SELECT produto.id_produto 'ID', produto.nome_produto 'Nome', marca.nome_marca 'Marca', fornecedor.nome_fornecedor 'Fornecedor', categoria.nome_categoria 'Categoria', produto.status_produto 'Status', produto.preco_venda, COUNT(itens_venda.id_produto) 'Quantidade de Vendas' FROM produto LEFT JOIN fornecedor ON produto.id_fornecedor = fornecedor.id_fornecedor LEFT JOIN categoria ON categoria.id_categoria = produto.id_categoria LEFT JOIN marca ON marca.id_marca = produto.id_marca LEFT JOIN itens_venda ON produto.id_produto = itens_venda.id_produto WHERE 1=1 AND produto.status_produto = {status}";

            if (!string.IsNullOrWhiteSpace(nome))
            {
                sql = $"{sql} AND produto.nome_produto LIKE '%{nome}%'";
            }

            if (marca != 0)
            {
                sql = $"{sql} AND marca.id_marca = {marca}";
            }

            if (fornecedor != 0)
            {
                sql = $"{sql} AND fornecedor.id_fornecedor = {fornecedor}";
            }

            if (categoria != 0)
            {
                sql = $"{sql} AND categoria.id_categoria = {categoria}";
            }

            if (!string.IsNullOrWhiteSpace(tamanho))
            {
                sql = $"{sql} AND produto.tamanho = '{tamanho}'";
            }

            if (!string.IsNullOrWhiteSpace(cor))
            {
                sql = $"{sql} AND produto.cor = '{cor}'";
            }

            if (minvalue != 0 && maxvalue != 0)
            {
                sql = $"{sql} AND produto.preco_venda BETWEEN {minvalue.ToString().Replace(",", ".")} AND {maxvalue.ToString().Replace(",", ".")}";
            }

            sql = $"{sql} GROUP BY produto.id_produto ORDER BY produto.nome_produto";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }


        public int InserirProduto()
        {
            string sql = $"INSERT INTO produto VALUES (0, {id_marca}, {id_categoria}, {id_fornecedor}, '{nome_produto}', '{produto_foto1}', '{produto_foto2}', '{produto_foto3}', '{produto_foto4}', NOW(), '{tamanho}', {preco_custo.ToString().Replace(",", ".")}, {lucro}, '{preco_venda.ToString().Replace(",", ".")}', 0, 0, 0, 1, '{cor}', '{descricao}', {destaque}, {estoque})";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public DataTable CarregarComboTamanho()
        {
            string sql = "SELECT DISTINCT produto.tamanho FROM produto ORDER BY produto.tamanho";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }


        public bool BuscarDadosProduto(int id)
        {
            string sql = $"SELECT * FROM produto WHERE id_produto = {id}";

            classConexao cConexao = new classConexao();

            DataTable dt = cConexao.RetornaDados(sql);

            if (dt.Rows.Count > 0)
            {
                id_produto = Convert.ToInt32(dt.Rows[0]["id_produto"]);

                id_categoria = Convert.ToInt32(dt.Rows[0]["id_categoria"]);

                id_fornecedor = Convert.ToInt32(dt.Rows[0]["id_fornecedor"]);

                id_marca = Convert.ToInt32(dt.Rows[0]["id_marca"]);

                nome_produto = dt.Rows[0]["nome_produto"].ToString();

                produto_foto1 = dt.Rows[0]["produto_foto1"].ToString();

                tamanho = dt.Rows[0]["tamanho"].ToString();

                preco_custo = Convert.ToDecimal(dt.Rows[0]["preco_custo"]);

                lucro = Convert.ToDecimal(dt.Rows[0]["lucro"]);

                preco_venda = Convert.ToDecimal(dt.Rows[0]["preco_venda"]);

                status_produto = Convert.ToInt32(dt.Rows[0]["status_produto"]);

                cor = dt.Rows[0]["cor"].ToString();

                descricao = dt.Rows[0]["descricao"].ToString();

                destaque = Convert.ToInt32(dt.Rows[0]["status_destaque"]);

                estoque = Convert.ToInt32(dt.Rows[0]["estoque"]);



                return true;
            }

            return false;
        }

        public int DeletarProduto(int id)
        {
            string sql = $"DELETE FROM produto WHERE id_produto = {id}";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public int AtualizarProduto(int id)
        {
            string sql = $"UPDATE produto SET id_marca = {id_marca}, id_categoria = {id_categoria}, id_fornecedor = {id_fornecedor}, nome_produto = '{nome_produto}', produto_foto1 = '{produto_foto1}', tamanho = '{tamanho}', preco_custo = {preco_custo.ToString().Replace(",", ".")}, lucro = {lucro.ToString().Replace(",", ".")}, preco_venda = '{preco_venda.ToString().Replace(",", ".")}', status_produto = {status_produto}, cor = '{cor}', descricao = '{descricao}', status_destaque = {destaque}, estoque = {estoque} WHERE id_produto = {id}";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public DataTable BuscarProdutoRelatorio(int marca, int fornecedor, int categoria, string cor, int status, decimal minvalue, decimal maxvalue)
        {
            string sql = $"SELECT produto.nome_produto, categoria.nome_categoria 'id_categoria', marca.nome_marca 'id_marca', fornecedor.nome_fornecedor 'id_fornecedor', produto.cor, CONCAT('R$ ', FORMAT(preco_venda, 2, 'pt_BR')) 'preco_venda' FROM produto INNER JOIN marca ON produto.id_marca = marca.id_marca INNER JOIN fornecedor ON fornecedor.id_fornecedor = produto.id_fornecedor INNER JOIN categoria ON categoria.id_categoria = produto.id_categoria WHERE 1=1 AND status_produto = {status}";

            if (marca != 0)
            {
                sql = $"{sql} AND marca.id_marca = {marca}";
            }

            if (fornecedor != 0)
            {
                sql = $"{sql} AND fornecedor.id_fornecedor = {fornecedor}";
            }

            if (categoria != 0)
            {
                sql = $"{sql} AND categoria.id_categoria = {categoria}";
            }

            if (!string.IsNullOrWhiteSpace(cor))
            {
                sql = $"{sql} AND produto.cor = '{cor}'";
            }

            if (maxvalue > 0)
            {
                sql = $"{sql} AND preco_venda BETWEEN {minvalue} AND {maxvalue}";
            }

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }

        public DataTable BuscarProdutoVenda(string produto)
        {
            string sql = $"SELECT produto.id_produto 'ID', produto.nome_produto 'Nome', marca.nome_marca 'Marca', categoria.nome_categoria 'Categoria', IF(produto.desconto > 0, preco_desconto, preco_venda) 'Preco' FROM produto INNER JOIN marca ON produto.id_marca = marca.id_marca INNER JOIN categoria ON categoria.id_categoria = produto.id_categoria WHERE 1=1 AND produto.status_produto = 1 AND produto.nome_produto LIKE '%{produto}%' AND produto.estoque > 0";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }


        public string BuscaNomeProduto(int id)
        {
            string sql = $"SELECT nome_produto from produto WHERE id_produto = {id}";

            classConexao cConexao = new classConexao();

            DataTable dt = cConexao.RetornaDados(sql);

            if(dt.Rows.Count > 0)
            {
                nome_produto = dt.Rows[0]["nome_produto"].ToString();
            }

            return nome_produto;
        }

        public bool AtualizarEstoque(int estoque, int id)
        {
            string sql = $"UPDATE produto SET estoque = {estoque} WHERE id_produto = {id}";

            classConexao cConexao = new classConexao();

            if(cConexao.ExecutaQuery(sql) != 0)
            {
                return true;
            }

            return false;
        }

        

    }
}
    


