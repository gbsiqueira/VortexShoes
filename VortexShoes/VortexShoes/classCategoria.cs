using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //TEM QUE ADICIONAR SEMPRE EM CLASSES NOVAS 

namespace VortexShoes
{
    class classCategoria
    {
        public classCategoria()
        {
            id_categoria = 0;

            nome = null;

            data_cadastro = DateTime.Now;

            status = 0;

            observacao = null;
        }

        public int id_categoria { get; set; }

        public string nome { get; set; }

        public DateTime data_cadastro { get; set; }

        public int status { get; set; }

        public string observacao { get; set; }


        public int InserirCategoria()
        {
            string sql = $"INSERT INTO categoria VALUES (0, '{nome}', NOW(), 1, '{observacao}')";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public DataTable CarregarComboCons()
        {
            string sql = "SELECT id_categoria, nome_categoria FROM categoria ORDER BY nome_categoria";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }

        public DataTable BuscarCategoria(int id, int status, DateTime inicio, DateTime fim, bool usardata)
        {
            string sql = $"SELECT categoria.id_categoria 'ID', categoria.nome_categoria 'Nome', categoria.status_categoria 'Status', COUNT(produto.id_categoria) 'N° de Cadastros em Produtos' FROM categoria LEFT JOIN produto ON produto.id_categoria = categoria.id_categoria WHERE 1=1 AND status_categoria = {status}";

            if(id != 0)
            {
                sql = $"{sql} AND categoria.id_categoria = {id}";
            }

            if(usardata)
            {
                sql = $"{sql} AND categoria.data_cadastro BETWEEN '{inicio.ToString("yyyy-MM-dd")}' AND '{fim.ToString("yyyy-MM-dd")}'";
            }

            sql = $"{sql} GROUP BY categoria.id_categoria";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }

        public bool BuscarDadosCategoria(int id)
        {
            string sql = $"SELECT * FROM categoria WHERE categoria.id_categoria = {id}";

            classConexao cConexao = new classConexao();

            DataTable tb = cConexao.RetornaDados(sql);

            if (tb.Rows.Count > 0)
            {

                id_categoria = Convert.ToInt32(tb.Rows[0]["id_categoria"]);

                nome = tb.Rows[0]["nome_categoria"].ToString();

                data_cadastro = Convert.ToDateTime(tb.Rows[0]["data_cadastro"]);

                observacao = tb.Rows[0]["observacao"].ToString();

                status = Convert.ToInt32(tb.Rows[0]["status_categoria"]);

                return true;
            }

            return false;

        }

        public int DeletarCategoria(int id)
        {
            string sql = $"DELETE FROM categoria WHERE categoria.id_categoria = {id}";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public DataTable CarregarCombo()
        {
            string sql = "SELECT id_categoria, nome_categoria FROM categoria WHERE status_categoria = 1 ORDER BY nome_categoria";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }

        public int AtualizarCategoria(int id)
        {
            string sql = $"UPDATE categoria SET nome_categoria = '{nome}', status_categoria = {status}, observacao = '{observacao}' WHERE id_categoria = {id}";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }
    }
}
