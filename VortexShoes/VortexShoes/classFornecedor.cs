using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //TEM QUE ADICIONAR SEMPRE EM CLASSES NOVAS 


namespace VortexShoes
{
    class classFornecedor
    {
        public classFornecedor()
        {
            id_fornecedor = 0;

            nome_fornecedor = null;

            observacao = null;

            data_cadastro = DateTime.Now;

            status_fornecedor = 0;

            email = null;

            cnpj = null;
        }

        public int id_fornecedor { get; set; }

        public string nome_fornecedor { get; set; }

        public DateTime data_cadastro { get; set; }

        public string observacao { get; set; }

        public int status_fornecedor { get; set; }

        public string email { get; set; }

        public string cnpj { get; set; }

        public int InserirFornecedor()
        {
            string sql = $"INSERT INTO fornecedor VALUES (0, '{nome_fornecedor}', 1, NOW(), '{observacao}', '{email}', '{cnpj}')";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public DataTable CarregarComboCons()
        {
            string sql = "SELECT id_fornecedor, nome_fornecedor FROM fornecedor ORDER BY nome_fornecedor";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
            
        }

        public DataTable BuscarFornecedor(int id, int status, DateTime inicio, DateTime fim, bool usardata)
        {
            string sql = $"SELECT fornecedor.id_fornecedor 'ID', fornecedor.nome_fornecedor 'Nome', fornecedor.status_fornecedor 'Status', COUNT(produto.id_fornecedor) 'N° de Cadastros em Produtos' FROM fornecedor LEFT JOIN produto ON produto.id_fornecedor = fornecedor.id_fornecedor WHERE 1=1 AND status_fornecedor = {status}";

            if(id != 0)
            {
                sql = $"{sql} AND fornecedor.id_fornecedor = {id}";
            }
            
            if(usardata)
            {
                sql = $"{sql} AND fornecedor.data_cadastro BETWEEN '{inicio.ToString("yyyy-MM-dd")}' AND '{fim.ToString("yyyy-MM-dd")}'";
            }


            sql = $"{sql} GROUP BY fornecedor.id_fornecedor";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }
        
        public bool BuscarDadosFornecedor(int id)
        {
            string sql = $"SELECT * FROM fornecedor WHERE id_fornecedor = {id}";

            classConexao cConexao = new classConexao();

            DataTable tb = cConexao.RetornaDados(sql);

            if(tb.Rows.Count > 0)
            {
                id_fornecedor = Convert.ToInt32(tb.Rows[0]["id_fornecedor"]);

                nome_fornecedor = tb.Rows[0]["nome_fornecedor"].ToString();

                status_fornecedor = Convert.ToInt32(tb.Rows[0]["status_fornecedor"]);

                cnpj = tb.Rows[0]["cnpj"].ToString();

                observacao = tb.Rows[0]["observacao"].ToString();

                email = tb.Rows[0]["email"].ToString();

                return true;
            }

            return false;
        }

        public int DeletarFornecedor(int id)
        {
            string sql = $"DELETE FROM fornecedor WHERE id_fornecedor = {id}";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public int AtualizarFornecedor(int id)
        {
            string sql = $"UPDATE fornecedor SET nome_fornecedor = '{nome_fornecedor}', email = '{email}', cnpj = '{cnpj}', status_fornecedor = {status_fornecedor}, observacao = '{observacao}' WHERE id_fornecedor = {id}";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public DataTable CarregarCombo()
        {
            string sql = "SELECT id_fornecedor, nome_fornecedor FROM fornecedor WHERE status_fornecedor = 1 ORDER BY nome_fornecedor";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }
    }
}
