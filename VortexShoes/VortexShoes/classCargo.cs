using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace VortexShoes
{
    class classCargo
    {
        //INICIALIZAR AS PROPRIEDADES DA CLASSE
        //O METODO CONSTRUTOR PRECISA DE O MESMO NOME DA CLASSE

       public classCargo()
       {
            //LIMPANDO AS VARIAVEIS

            id_cargo = 0; //campo numerico int ou decimal

            nome = null;

            observacao = null; //string null

            status = 0; //bit 0 

            data_cadastro = DateTime.Now; //horario de agora
       }

        //PROPRIEDADES: LER, ARMAZENAR E CALCULAR OS DADOS QUE SERÃO ENVIADOS OU RETORNADOS DO BD
        //MESMO NOME E TIPO DE DADO DOS CAMPOS DO BANCO DE DADOS
        //ATALHO PARA CRIAR PROPRIEDADES: PROP TAB TAB

        public int id_cargo { get; set; }

        public string nome { get; set; }

        public string observacao { get; set; }

        public int status { get; set; }

        public DateTime data_cadastro { get; set; }

        //MÉTODOS: FUNCIONALIDADES DO SISTEMA, TIPOS DE METODOS (INT, BOOL, STRING, VOID, DATATABLE)

        //METODO PARA CADASTRAR CARGO
        public int InserirCargo()
        {
            //VARIAVEL DO COMANDO SQL USANDO INTERPOLAÇÃO
            string Sql = $"INSERT INTO cargo VALUES (0, '{nome}', '{observacao}', 1, NOW());";

            //SEM USAR A INTERPOLAÇÃO
            //string sql = "INSERT INTO cargo VALUES (0, '"+nome+"', '"+observacao+"', 1, NOW());";

            //CRIAR O OBJETO DA CLASSE CONEXÃO PARA O METODO QUE VAI EXECUTAR O COMANDO QUE ESCREVEMOS - METODO EXECUTAQUERY();

            classConexao cConexao = new classConexao();

            //CHAMAR O OBJETO DA CLASSE CONEXÃO QUE VAI EXECUTAR O COMANDO
            //RETURN
            return cConexao.ExecutaQuery(Sql);
        }

        public DataTable CarregarCombo()
        {
            string sql = "SELECT id_cargo, nome FROM cargo ORDER BY nome;";

            classConexao cConexao = new classConexao();

            //METODO PARA SELECTS QUE RETORNA VARIOS DADOS
            return cConexao.RetornaDados(sql);
        }

        public DataTable BuscarCargo(int id, int status, DateTime inicio, DateTime fim, bool usardata)
        {
            string sql = $"SELECT cargo.id_cargo 'ID', cargo.nome 'Cargo', cargo.status 'Status', COUNT(funcionario.id_cargo) 'N° de Funcionários Cadastrados' FROM cargo LEFT JOIN funcionario ON funcionario.id_cargo = cargo.id_cargo WHERE 1=1 AND cargo.status = {status}";

            if(id != 0)
            {
                sql = $"{sql} AND cargo.id_cargo = {id}";
            }

            if(usardata)
            {
                sql = $"{sql} AND cargo.data_cadastro BETWEEN '{inicio.ToString("yyyy-MM-dd")}' AND '{fim.ToString("yyyy-MM-dd")}'";
            }

            sql = $"{sql} GROUP BY cargo.id_cargo";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }

        public int DeletarCargo(int id)
        {
            string sql = $"DELETE FROM cargo WHERE cargo.id_cargo = {id}";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        public bool BuscarDadosCargo(int id)
        {
            string sql = $"SELECT * FROM cargo WHERE cargo.id_cargo = {id}";

            classConexao cConexao = new classConexao();

            DataTable tb = cConexao.RetornaDados(sql);

            if(tb.Rows.Count > 0)
            {

                id_cargo = Convert.ToInt32(tb.Rows[0]["id_cargo"]);

                nome = tb.Rows[0]["nome"].ToString();

                data_cadastro = Convert.ToDateTime(tb.Rows[0]["data_cadastro"]);

                observacao = tb.Rows[0]["observacao"].ToString();

                status = Convert.ToInt32(tb.Rows[0]["status"]);


                return true;

            }

            return false;
        }

        public int AtualizarCargo(int id)
        {
            string sql = $"UPDATE cargo SET nome = '{nome}', observacao = '{observacao}', status = {status} WHERE id_cargo = {id}";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }
    }
}
