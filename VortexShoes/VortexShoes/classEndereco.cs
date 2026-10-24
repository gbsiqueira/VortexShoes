using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //TEM QUE ADICIONAR SEMPRE EM CLASSES NOVAS 

namespace VortexShoes
{
    class classEndereco
    {
        public classEndereco()
        {
            id_endereco = 0;

            id_cliente = 0;

            bairro = null;

            numero = 0;

            estado = null;

            rua = null;

            complemento = null;

            cidade = null;

            cep = null;

            status = 0;

            data_cadastro = DateTime.Now;
        }

        public int id_endereco { get; set; }

        public int id_cliente { get; set; }

        public string bairro { get; set; }

        public int numero { get; set; }

        public string estado { get; set; }

        public string rua { get; set; }

        public string complemento { get; set; }

        public string cidade { get; set; }

        public string cep { get; set; }
        
        public int status { get; set; }

        public DateTime data_cadastro { get; set; }

        public int InserirEndereco()
        {
            string sql = $"INSERT INTO endereco VALUES (0, {id_cliente}, '{bairro}', {numero}, '{estado}', '{rua}', '{complemento}', '{cidade}', '{cep}', 1, NOW())";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public int DeletarCliente()
        {
            string sqldelete = $"DELETE FROM cliente WHERE id_cliente = {id_cliente};";


            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sqldelete);
        }

        public int DeletarTudo()
        {

            classConexao cConexao = new classConexao();

            string sql = $"DELETE FROM endereco WHERE id_cliente = {id_cliente}";
            cConexao.ExecutaQuery(sql);

            string sqlend = $"DELETE FROM cliente WHERE id_cliente = {id_cliente}";
            return cConexao.ExecutaQuery(sqlend);
            
        }

        public int AtualizarEndereco(int id)
        {
            string sql = $"UPDATE endereco SET cidade = '{cidade}', bairro = '{bairro}', estado = '{estado}', numero = {numero}, cep = '{cep}', status = {status}, complemento = '{complemento}', rua = '{rua}' WHERE id_endereco = {id}";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public int DeletarEndereco(int id)
        {
            string sql = $"UPDATE endereco SET status = 0 WHERE id_cliente = {id}";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public List<classEndereco> BuscarDadosEndereco(int id)
        {
            List<classEndereco> lista = new List<classEndereco>();

            string sql = $"SELECT * FROM endereco WHERE id_cliente = {id}";

            classConexao cConexao = new classConexao();

            DataTable dt = cConexao.RetornaDados(sql);

            foreach(DataRow row in dt.Rows)
            {
                classEndereco cEndereco = new classEndereco();

                cEndereco.id_endereco = Convert.ToInt32(row["id_endereco"]);

                cEndereco.status = Convert.ToInt32(row["status"]);

                cEndereco.id_cliente = Convert.ToInt32(row["id_cliente"]);

                cEndereco.numero = Convert.ToInt32(row["numero"]);

                cEndereco.complemento = row["complemento"].ToString();

                cEndereco.bairro = row["bairro"].ToString();

                cEndereco.cidade = row["cidade"].ToString();

                cEndereco.estado = row["estado"].ToString();

                cEndereco.cep = row["cep"].ToString();

                cEndereco.rua = row["rua"].ToString();

                lista.Add(cEndereco);
            }

            return lista;
        }


       
    }
}
