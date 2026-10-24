using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //TEM QUE ADICIONAR SEMPRE EM CLASSES NOVAS 

namespace VortexShoes
{
    class classFuncionario
    {
        public classFuncionario()
        {
             id_funcionario = 0;
             nome = null;
             nome_social = null;
             foto = null;
             data_nascimento = DateTime.Now;
             sexo = null;
             estado_civil = null;
             cpf = null;
             rg = null;
            salario = 0;
            endereco = null;
            numero = 0;
            complemento = null;
            bairro = null;
            cidade = null;
            estado = null;
            cep = null;
            telefone_residencial = null;
            telefone_celular = null;
            email = null;
            usuario = null;
            senha = null;
            tipo_acesso = 0;
            status = 0;
            data_cadastro = DateTime.Now;
            id_cargo = 0;
        }

        public int id_funcionario { get; set; }

        public string nome { get; set; }

        public string nome_social { get; set; }

        public string foto { get; set; }

        public DateTime data_nascimento { get; set; }

        public string sexo { get; set; }

        public string estado_civil { get; set; }

        public string cpf { get; set; }

        public string rg { get; set; }

        public decimal salario { get; set; }

        public string endereco { get; set; }

        public int numero { get; set; }

        public string complemento { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public string cep { get; set; }

        public string telefone_residencial { get; set; }

        public string telefone_celular { get; set; }

        public string email { get; set; }

        public string usuario { get; set; }

        public string senha { get; set; }

        public int tipo_acesso { get; set; }

        public int status { get; set; }

        public DateTime data_cadastro { get; set; }

        public int id_cargo { get; set; }

        //METODOS 
        //CAMPOS DATE: PROPRIEDADE .TOSTRING("yyyy-MM-dd")
        //CAMPOS DECIMAL: PROPRIEDADE .TOSTRING().REPLACE("," , ".")
        //NAO PODE MANDAR ASPAS SIMPLES EM CAMPO DO TIPO BIT

        public int InserirFuncionario()
        {
            string sql = $"INSERT INTO funcionario VALUES (0, '{nome}', '{nome_social}', '{foto}', '{data_nascimento.ToString("yyyy-MM-dd")}', '{sexo}', '{estado_civil}', '{cpf}', '{rg}', '{salario.ToString().Replace("," , ".")}', '{endereco}', {numero}, '{complemento}', '{bairro}', '{cidade}', '{estado}', '{cep}', '{telefone_residencial}', '{telefone_celular}', '{email}', '{usuario}', '{senha}', {tipo_acesso}, 1, NOW(), {id_cargo})";

            classConexao cConexao = new classConexao();

            //EXECUTA O METODO E RETORNA O RESULTADO
            return cConexao.ExecutaQuery(sql);
        }

        //CONSULTA DE FUNCIONÁRIO
        public DataTable BuscarFuncionario(string nome, string cpf, string sexo, string cidade, int status, DateTime inicio, DateTime fim, bool usardata, int cargo)
        {
            string sql = $"SELECT funcionario.id_funcionario 'ID', IF(funcionario.nome_social != '' AND funcionario.nome_social IS not NULL, funcionario.nome_social, funcionario.nome) 'Nome', funcionario.cpf 'CPF', funcionario.data_nascimento 'Data de Nascimento', cargo.nome 'Cargo', funcionario.sexo 'Sexo',  funcionario.cidade 'Cidade', funcionario.telefone_celular 'Celular' FROM funcionario INNER JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE 1=1 AND funcionario.status = {status}";

            if(!string.IsNullOrWhiteSpace(nome))
            {
                sql = $"{sql} AND funcionario.nome OR funcionario.nome_social LIKE '%{nome}%'";
            }

            if(!string.IsNullOrWhiteSpace(cpf))
            {
                sql = $"{sql} AND funcionario.cpf LIKE '{cpf}%'";
            }

            if(!string.IsNullOrWhiteSpace(sexo))
            {
                sql = $"{sql} AND funcionario.sexo = '{sexo}'";
            }

            if(!string.IsNullOrWhiteSpace(cidade))
            {
                sql = $"{sql} AND funcionario.cidade = '{cidade}'";
            }

            if(cargo != 0)
            {
                sql = $"{sql} AND funcionario.id_cargo = {cargo}";
            }

            if(usardata)
            {
                sql = $"{sql} AND funcionario.data_cadastro BETWEEN '{inicio.ToString("yyyy-MM-dd")}' AND '{fim.ToString("yyyy-MM-dd")}'";
            }


            classConexao cConexao = new classConexao();

            //EXECUTA O METODO E RETORNA O RESULTADO
            return cConexao.RetornaDados(sql);
        }

        

        //METODO PARA BUSCAR OS DADOS SELECIONADOS NO METODO DE CONSULTA
        public bool BuscarDadosFuncionarios(int id)
        {
            string sql = $"SELECT * FROM funcionario WHERE funcionario.id_funcionario = {id}";

            classConexao cConexao = new classConexao();

            //DATATABLE QUE RECEBERA TODOS OS DADOS DO FUNCIONARIO ESCOLHIDO PELO USUARIO
            DataTable tb = cConexao.RetornaDados(sql);

            //SE A CONSULTA RETORNOU DADOS, CONTANDO AS LINHAS COM .ROWS.COUNT
            if(tb.Rows.Count > 0)
            {
                //NECESSARIO CONVERTER TODOS OS TIPOS DE DADO, ATE MESMO STRING, A LINHA 0 SERIA POR QUE ELE SEMPRE VAI RETORNAR APENAS UMA LINHA, E DEPOIS SERIA O NOME DA COLUNA DO SEU BANCO
                id_funcionario = Convert.ToInt32(tb.Rows[0]["id_funcionario"]);

                nome = tb.Rows[0]["nome"].ToString();

                nome_social = tb.Rows[0]["nome_social"].ToString();

                foto = tb.Rows[0]["foto"].ToString();

                data_nascimento = Convert.ToDateTime(tb.Rows[0]["data_nascimento"]);

                sexo = tb.Rows[0]["sexo"].ToString();

                estado_civil = tb.Rows[0]["estado_civil"].ToString();

                cpf = tb.Rows[0]["cpf"].ToString();

                rg = tb.Rows[0]["rg"].ToString();

                salario = Convert.ToDecimal(tb.Rows[0]["salario"]);

                endereco = tb.Rows[0]["endereco"].ToString();

                numero = Convert.ToInt32(tb.Rows[0]["numero"]);

                complemento = tb.Rows[0]["complemento"].ToString();

                bairro = tb.Rows[0]["bairro"].ToString();

                cidade = tb.Rows[0]["cidade"].ToString();

                estado = tb.Rows[0]["estado"].ToString();

                cep = tb.Rows[0]["cep"].ToString();

                telefone_residencial = tb.Rows[0]["telefone_residencial"].ToString();

                telefone_celular = tb.Rows[0]["telefone_celular"].ToString();

                email = tb.Rows[0]["email"].ToString();

                usuario = tb.Rows[0]["usuario"].ToString();

                senha = tb.Rows[0]["senha"].ToString();

                tipo_acesso = Convert.ToInt32(tb.Rows[0]["tipo_acesso"]);

                status = Convert.ToInt32(tb.Rows[0]["status"]);

                data_cadastro = Convert.ToDateTime(tb.Rows[0]["data_cadastro"]);

                id_cargo = Convert.ToInt32(tb.Rows[0]["id_cargo"]);

                return true;
            }
             
            return false;

        }

        //UPDATE FUNCIONARIO
        public int AtualizarFuncionario()
        {
            string sql = $"UPDATE funcionario SET nome ='{nome}', nome_social = '{nome_social}', foto = '{foto}', data_nascimento = '{data_nascimento.ToString("yyyy-MM-dd")}', sexo = '{sexo}', estado_civil = '{estado_civil}', cpf = '{cpf}', rg = '{rg}', salario = '{salario.ToString().Replace("," , ".")}', endereco = '{endereco}', numero = {numero}, complemento = '{complemento}', bairro = '{bairro}', cidade = '{cidade}', estado = '{estado}', cep = '{cep}', telefone_residencial = '{telefone_residencial}', telefone_celular = '{telefone_celular}', email = '{email}', usuario = '{usuario}', senha = '{senha}', tipo_acesso = {tipo_acesso}, status = {status}, id_cargo = {id_cargo} WHERE id_funcionario ={id_funcionario}";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }

        //DELETAR FUNCIONARIO
        public int DeletarFuncionario()
        {
            string sql = $"DELETE FROM funcionario WHERE funcionario.id_funcionario = {id_funcionario}";

            classConexao cConexao = new classConexao();

            return cConexao.ExecutaQuery(sql);
        }


        //CIDADES CONSULTA
        public DataTable CarregarComboCidadeConsulta()
        {
            string sql = $"SELECT DISTINCT cidade FROM funcionario ORDER BY cidade";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(sql);
        }

        //RELATORIO
        public DataTable BuscarFuncionarioRelatorio(int status, string cidade, int cargo, string sexo, DateTime inicio, DateTime fim, bool usardata)
        {
            string sql = $"SELECT IF(funcionario.nome_social IS NOT NULL AND funcionario.nome_social != '', funcionario.nome_social, funcionario.nome) 'nome', funcionario.cpf, funcionario.data_nascimento, funcionario.sexo, funcionario.cidade, funcionario.telefone_celular, DATE(funcionario.data_cadastro) 'data_cadastro', cargo.nome 'id_cargo' FROM funcionario INNER JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE 1=1 AND funcionario.status = {status}";

            if(!string.IsNullOrWhiteSpace(cidade))
            {
                sql = $"{sql} AND cidade = '{cidade}'";
            }

            if (cargo != 0)
            {
                sql = $"{sql} AND cargo.id_cargo = {cargo}";

            }

            if (!string.IsNullOrWhiteSpace(sexo))
            {
                sql = $"{sql} AND funcionario.sexo = '{sexo}'";
            }

            if(usardata)
            {
                sql = $"{sql} AND funcionario.data_cadastro BETWEEN '{inicio.ToString("yyyy-MM-dd")}' AND '{fim.ToString("yyyy-MM-dd")}'";
            }

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }


        public int LoginFuncionario(string user, string senha)
        {
            string sql = $"SELECT funcionario.tipo_acesso FROM funcionario WHERE funcionario.usuario = '{user}' AND funcionario.senha = '{senha}'";

            classConexao cConexao = new classConexao();

            DataTable tb = cConexao.RetornaDados(sql);

            if(tb.Rows.Count > 0)
            {
                tipo_acesso = Convert.ToInt32(tb.Rows[0]["tipo_acesso"]);

                return Convert.ToInt32(tb.Rows[0]["tipo_acesso"]); 
            }

            return -1;

        }

        public DataTable BuscarVendaFuncionario()
        {
            string sql = $"SELECT funcionario.id_funcionario 'ID', IF(funcionario.nome_social IS NOT NULL AND funcionario.nome_social != '', funcionario.nome_social, funcionario.nome) 'Nome', funcionario.cpf FROM funcionario INNER JOIN cargo ON funcionario.id_cargo = cargo.id_cargo WHERE 1=1 AND funcionario.status = 1 AND cargo.nome = 'vendedor' ORDER BY funcionario.nome";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }

     

    }

}
