using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace VortexShoes
{
    class classDashboard
    {
        public int ContarProdutos()
        {
            string sql = $"SELECT COUNT(*) FROM produto";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQueryID(sql);
        }

        public int ContarClientes()
        {
            string sql = $"SELECT COUNT(*) FROM cliente WHERE status_cliente = 1";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQueryID(sql);
        }

        public int VendasSemana()
        {
            string sql = $"SELECT COUNT(*) AS vendas_semana FROM venda WHERE YEARWEEK(data_pedido, 1) = YEARWEEK(CURDATE(), 1); ";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQueryID(sql);
        }

        public int ProdutosVendidos()
        {
            string sql = $"SELECT COUNT(*) FROM itens_venda";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQueryID(sql);
        }

        public int FornecedoreAtivo()
        {
            string sql = $"SELECT COUNT(*) FROM fornecedor WHERE status_fornecedor = 1";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQueryID(sql);
        }

        public int VendasHoje()
        {
            string sql = $"SELECT COUNT(*) FROM venda WHERE data_pedido = CURDATE()";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQueryID(sql);
        }

    }
}
