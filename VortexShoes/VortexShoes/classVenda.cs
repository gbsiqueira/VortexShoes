using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VortexShoes
{
    class classVenda
    {
        public classVenda()
        {
            id_pedido = 0;

            id_funcionario = 0;

            id_cliente = 0;

            data_pedido = DateTime.Now;

            valor_total = 0;

            desconto = 0;

            tipo_pagamento = null;
        }

        //VENDA
        public int id_pedido { get; set; }

        public int id_funcionario { get; set; }

        public int id_cliente { get; set; }

        public DateTime data_pedido { get; set; }

        public decimal valor_total { get; set; }

        public decimal desconto { get; set; }

        public string tipo_pagamento { get; set; }




        public int RealizarVenda()
        {
            string sql = $"INSERT INTO venda VALUES(0, {id_funcionario}, {id_cliente}, NOW(), {valor_total.ToString().Replace(",", ".")}, {desconto.ToString().Replace(",", ".")},  '{tipo_pagamento}'); SELECT LAST_INSERT_ID()";

            classConexao cConexao = new classConexao();

            int id = cConexao.ExecutaQueryID(sql);

            return id;

        }

    }
}
