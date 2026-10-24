using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VortexShoes
{
    class classItensVenda
    {
        public classItensVenda()
        {
            id_item_venda = 0;

            id_produto = 0;

            id_pedido = 0;

            quantidade = 0;

            valor_total_item = 0;

            valor_item = 0;

        }

        //  VENDA

        public int id_item_venda { get; set; }

        public int id_pedido { get; set; }

        public int id_produto { get; set; }

        public int quantidade { get; set; }

        public decimal valor_total_item { get; set; }

        public decimal valor_item { get; set; }


        public bool CadastrarItemVenda()
        {
            string sql = $"INSERT INTO itens_venda VALUES(0, {id_produto}, {id_pedido}, {quantidade}, {valor_total_item.ToString().Replace(",", ".")}, {valor_item.ToString().Replace(",", ".")})";

            classConexao cConexao = new classConexao();

            if(cConexao.ExecutaQuery(sql) != 0)
            {
                return true;
            }

            return false;
        }

    }
}
