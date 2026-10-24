using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //TEM QUE ADICIONAR SEMPRE EM CLASSES NOVAS 

namespace VortexShoes
{
    class classCliente
    {
        public classCliente()
        {
            id_cliente = 0;

            nome = null;

            nome_social = null;

            cpf_cliente = null;

            sexo_cliente = null;

            data_nascimento_cliente = DateTime.Now;

            data_cadastro = DateTime.Now;

            status_cliente = 0;

            email = null;

            telefone_cliente = null;

            telefone_cliente2 = null;
        }

        public int id_cliente { get; set; }

        public string nome { get; set; }

        public string nome_social { get; set; }

        public string cpf_cliente { get; set; }

        public string sexo_cliente { get; set; }

        public DateTime data_nascimento_cliente { get; set; }

        public DateTime data_cadastro { get; set; }

        public int status_cliente { get; set; }

        public string email { get; set; }

        public string telefone_cliente { get; set; }

        public string telefone_cliente2 { get; set; }


        public int InserirCliente()
        {
            string sql = $"INSERT INTO cliente VALUES (0, '{nome}','{nome_social}', '{cpf_cliente}', '{sexo_cliente}', '{data_nascimento_cliente.ToString("yyyy-MM-dd")}', NOW(), 1, '{email}', '{telefone_cliente}', '{telefone_cliente2}'); SELECT LAST_INSERT_ID();";

            classConexao cConexao = new classConexao();

            int IDgerado = cConexao.ExecutaQueryID(sql); 

            return IDgerado;
        }

        public DataTable BuscarCliente(string nome, string cidade, string telefone, string cpf, string sexo, int status, DateTime inicio, DateTime fim, bool usardata)
        {
            string sql = $"SELECT cliente.id_cliente 'ID', IF(cliente.nome_social != '' AND cliente.nome_social IS NOT NULL, cliente.nome_social, cliente.nome_cliente) 'Nome', cliente.cpf_cliente 'CPF', cliente.sexo_cliente 'Sexo', COUNT(venda.id_cliente) 'Quantidade de Compras' FROM cliente LEFT JOIN venda ON cliente.id_cliente = venda.id_cliente INNER JOIN endereco ON endereco.id_cliente = cliente.id_cliente WHERE 1=1 AND cliente.status_cliente = {status}";

            if(nome != null)
            {
                sql = $"{sql} AND (cliente.nome_cliente LIKE '%{nome}%' OR cliente.nome_social LIKE '%{nome}%')";
            }

            if(cidade != null)
            {
                sql = $"{sql} AND endereco.cidade LIKE '%{cidade}%'";
            }

            if(telefone != null)
            {
                sql = $"{sql} AND cliente.telefone_cliente = '{telefone}' OR cliente.telefone_cliente2 = '{telefone}'";
            }

            if(cpf != null)
            {
                sql = $"{sql} AND cliente.cpf_cliente = '{cpf}'";
            }

            if(sexo != null)
            {
                sql = $"{sql} AND cliente.sexo_cliente = '{sexo}'";
            }

            if(usardata)
            {
                sql = $"{sql} AND cliente.data_nascimento_cliente BETWEEN '{inicio.ToString("yyyy-MM-dd")}' AND '{fim.ToString("yyyy-MM-dd")}'";
            }

            sql = $"{sql} GROUP BY cliente.id_cliente";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }

        public DataTable CarregarComboCons()
        {
            string sql = "SELECT DISTINCT endereco.cidade FROM endereco";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }

        public bool BuscarDadosCliente(int id)
        {
            string sql = $"SELECT * FROM cliente WHERE id_cliente = {id}";


            classConexao cConexao = new classConexao();

            DataTable tb = cConexao.RetornaDados(sql);

            if(tb.Rows.Count > 0)
            {
                id_cliente = Convert.ToInt32(tb.Rows[0]["id_cliente"]);

                nome = tb.Rows[0]["nome_cliente"].ToString();

                nome_social = tb.Rows[0]["nome_social"].ToString();

                cpf_cliente = tb.Rows[0]["cpf_cliente"].ToString();

                sexo_cliente = tb.Rows[0]["sexo_cliente"].ToString();

                data_nascimento_cliente = Convert.ToDateTime(tb.Rows[0]["data_nascimento_cliente"]);

                status_cliente = Convert.ToInt32(tb.Rows[0]["status_cliente"]); 

                email = tb.Rows[0]["email"].ToString();

                telefone_cliente = tb.Rows[0]["telefone_cliente"].ToString();

                telefone_cliente2 = tb.Rows[0]["telefone_cliente2"].ToString();

                return true;
            }

            return false;
        }

        public int AtualizarCliente(int id)
        {
            string sql = $"UPDATE cliente SET nome_cliente = '{nome}', nome_social = '{nome_social}', cpf_cliente = '{cpf_cliente}', sexo_cliente = '{sexo_cliente}', data_nascimento_cliente = '{data_nascimento_cliente.ToString("yyyy-MM-dd")}', status_cliente = {status_cliente}, email = '{email}', telefone_cliente = '{telefone_cliente}', telefone_cliente2 = '{telefone_cliente2}' WHERE id_cliente = {id}";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public int DeletarCliente(int id)
        {
            string sql = $"UPDATE cliente SET status_cliente = 0 WHERE id_cliente = {id}";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public DataTable BuscarClienteRelatorio(int status, string cidade, string sexo, int idade1, int idade2, DateTime inicio, DateTime fim, bool usardata)
        {
            string sql = $"SELECT IF(cliente.nome_social IS NOT NULL AND cliente.nome_social != '', cliente.nome_social, cliente.nome_cliente) 'nome', cliente.cpf_cliente, cliente.telefone_cliente, cliente.sexo_cliente, cliente.email, cliente.data_nascimento_cliente, cliente.status_cliente FROM cliente INNER JOIN endereco ON cliente.id_cliente = endereco.id_cliente WHERE 1=1 AND status_cliente = {status}";

            if(!string.IsNullOrWhiteSpace(cidade))
            {
                sql = $"{sql} AND endereco.cidade = '{cidade}'";
            }

            if (!string.IsNullOrWhiteSpace(sexo))
            {
                sql = $"{sql} AND cliente.sexo_cliente = '{sexo}'";
            }

            if(usardata)
            {
                sql = $"{sql} AND cliente.data_nascimento_cliente BETWEEN '{inicio.ToString("yyyy-MM-dd")}' AND '{fim.ToString("yyyy-MM-dd")}'";
            }

            if(idade2 > 0)
            {
                sql = $"{sql} AND TIMESTAMPDIFF(YEAR, data_nascimento_cliente, CURDATE()) BETWEEN {idade1} AND {idade2}";
            }


            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }
        

        public DataTable BuscarVendaCliente(string nome)
        {
            string sql = $"SELECT cliente.id_cliente 'ID', IF(cliente.nome_social IS NOT NULL AND cliente.nome_social != '', cliente.nome_social, cliente.nome_cliente) 'Nome', cliente.cpf_cliente FROM cliente WHERE 1=1 AND cliente.status_cliente = 1";

            if(!string.IsNullOrWhiteSpace(nome))
            {
                sql = $"{sql} AND IF(cliente.nome_social IS NOT NULL AND cliente.nome_social != '', cliente.nome_social, cliente.nome_cliente) LIKE '%{nome}%'";
            }

            sql = $"{sql} ORDER BY cliente.nome_cliente";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }
    }
}
