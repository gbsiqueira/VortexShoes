using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //TEM QUE ADICIONAR SEMPRE EM CLASSES NOVAS 

namespace VortexShoes
{
    class classMarca
    {
        public classMarca()
        {
            id_marca = 0;

            status = 0;

            nome = null;

            data_cadastro = DateTime.Now;

            observacao = null;

        }

        public int id_marca { get; set; }

        public int status { get; set; }

        public string nome { get; set; }

        public DateTime data_cadastro { get; set; }

        public string observacao { get; set; }

        public int InserirMarca()
        {
            string sql = $"INSERT INTO marca VALUES (0, 1, '{nome}', NOW(), '{observacao}')";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public DataTable CarregarCombo()
        {
            string sql = $"SELECT id_marca, nome_marca FROM marca WHERE status_marca = 1 ORDER BY nome_marca";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }

        public DataTable BuscarMarca(int marca, int status, DateTime inicio, DateTime fim, bool usardata)
        {
            string sql = $"SELECT marca.id_marca 'ID', marca.nome_marca 'Nome', marca.status_marca 'Status', COUNT(produto.id_marca) 'N° de Cadastros em Produtos' FROM marca LEFT JOIN produto ON produto.id_marca = marca.id_marca WHERE 1=1 AND status_marca = {status}";

            if(marca != 0)
            {
                sql = $"{sql} AND marca.id_marca = {marca}";
            }

            if(usardata)
            {
                sql = $"{sql} AND marca.data_cadastro BETWEEN '{inicio.ToString("yyyy-MM-dd")}' AND '{fim.ToString("yyyy-MM-dd")}'";
            }

            sql = $"{sql} GROUP BY marca.id_marca";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
          
        }

        public bool BuscarDadosMarca(int id)
        {
            string sql = $"SELECT * FROM marca WHERE marca.id_marca = {id}";

            classConexao cConexao = new classConexao();

            DataTable tb = cConexao.RetornaDados(sql);

            if (tb.Rows.Count > 0)
            {

                id_marca = Convert.ToInt32(tb.Rows[0]["id_marca"]);

                nome = tb.Rows[0]["nome_marca"].ToString();

                data_cadastro = Convert.ToDateTime(tb.Rows[0]["data_cadastro"]);

                observacao = tb.Rows[0]["observacao"].ToString();

                status = Convert.ToInt32(tb.Rows[0]["status_marca"]);

                return true;
            }

            return false;
        }

        public int AtualizarMarca(int id)
        {
            string sql = $"UPDATE marca SET nome_marca = '{nome}', status_marca = {status}, observacao = '{observacao}', status_marca = {status} WHERE id_marca = {id}";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }
        
        public int DeletarMarca(int id)
        {
            string sql = $"DELETE FROM marca WHERE id_marca = {id}";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public DataTable CarregarComboCons()
        {
            string sql = $"SELECT id_marca, nome_marca FROM marca ORDER BY nome_marca";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }

    }
}
