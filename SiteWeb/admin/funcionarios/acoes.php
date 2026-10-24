<?php

// CONEXÃO COM O BANCO DE DADOS
require_once __DIR__ . "../../../conexao/conecta.php";

// iniciando uma sessao
if (!isset($_SESSION)) {
  session_start();
}

// CADASTRANDO UM NOVO FUNCIONARIO
if (isset($_POST['cadastrar']) && $_POST['cadastrar'] == "cadastrar_funcionario") {

  $nome = mysqli_escape_string($conexao, $_POST['nome']);

  $nome_social = mysqli_escape_string($conexao, $_POST['nomesocial']);

  //$foto = mysqli_escape_string($conexao, $_POST['fotoinput']); FOI FEITO ANTES

  $data_nascimento = mysqli_escape_string($conexao, $_POST['datanascimento']);

  $sexo = mysqli_escape_string($conexao, $_POST['sexo']);

  $estado_civil = mysqli_escape_string($conexao, $_POST['estadocivil']);

  $cpf = mysqli_escape_string($conexao, $_POST['cpf']);

  $rg = mysqli_escape_string($conexao, $_POST['rg']);

  //  MUDAR A , POR . ,primeiro vem oq voce quer tirar depois oq voce quer colocar e depois o campo que voce vai receber
  $salario = str_replace(',', '.', $_POST['salario']);

  $endereco = mysqli_escape_string($conexao, $_POST['rua']);

  $numero = mysqli_escape_string($conexao, $_POST['numero']);

  $complemento = mysqli_escape_string($conexao, $_POST['complemento']);

  $bairro = mysqli_escape_string($conexao, $_POST['bairro']);

  $cidade = mysqli_escape_string($conexao, $_POST['cidade']);

  $estado = mysqli_escape_string($conexao, $_POST['estado']);

  $cep = mysqli_escape_string($conexao, $_POST['cep']);

  $telefone_residencial = mysqli_escape_string($conexao, $_POST['telefoneresidencial']);

  $telefone_celular = mysqli_escape_string($conexao, $_POST['telefonecelular']);

  $email = mysqli_escape_string($conexao, $_POST['email']);

  $usuario = mysqli_escape_string($conexao, $_POST['usuario']);

  $senha = mysqli_escape_string($conexao, $_POST['senha']);

  $acesso = mysqli_escape_string($conexao, $_POST['acesso']);

  //$status = mysqli_escape_string($conexao, $_POST['status']); FOI FEITO ANTES

  //$data_cadastro = mysqli_escape_string($conexao, $_POST['data_cadastro']); FOI FEITO ANTES

  $cargo = mysqli_escape_string($conexao, $_POST['cargo']);

  //enviando a foto para o servidor 
  // PEGANDO O CAMINHO DA IMAGEM
  $foto = basename($_FILES['fotoinput']['name']);

  // SALVANDO UM CAMINHO TEMPORARIO NA PASTA 'TMP'
  $tmp = $_FILES['fotoinput']['tmp_name'];

  // CRIANDO CAMINHO PARA PASTA FINAL, DEVE TER A BARRA NO FINAL DO CAMINHO
  $final = "../../../images-funcionarios/" . $foto;

  // MOVENDO A IMAGEM DA PASTA TMP PARA A PASTA IMAGES
  move_uploaded_file($tmp, $final);


  //INSERT
  //BIT É SEM ASPAS
  $sql = "INSERT INTO funcionario VALUES (0, '$nome', '$nome_social', '$foto', '$data_nascimento', '$sexo', '$estado_civil', '$cpf', '$rg', '$salario', '$endereco', '$numero', '$complemento', '$bairro', '$cidade', '$estado', '$cep', '$telefone_residencial', '$telefone_celular', '$email', '$usuario', '$senha', $acesso, 1, NOW(), $cargo)";


  try {
    if (mysqli_query($conexao, $sql)) {
      $_SESSION['mensagem_verde'] = "Funcionário(a) Cadastrado(a) com Sucesso!";
    } else {
      $_SESSION['mensagem'] = "Erro ao Cadastrar!";
    }
  } catch (mysqli_sql_exception) {
    $_SESSION['mensagem'] = "Erro ao Cadastrar!";
  }

  header('Location: inserir.php');
}





// EDITANDO UM NOVO FUNCIONARIO
if (isset($_POST['editar']) && $_POST['editar'] == "editar_funcionario") {

  $id = mysqli_escape_string($conexao, $_POST['id_funcionario']);

  $nome = mysqli_escape_string($conexao, $_POST['nome']);

  $nome_social = mysqli_escape_string($conexao, $_POST['nomesocial']);

  //$foto = mysqli_escape_string($conexao, $_POST['fotoinput']); FOI FEITO ANTES

  $data_nascimento = mysqli_escape_string($conexao, $_POST['datanascimento']);

  $sexo = mysqli_escape_string($conexao, $_POST['sexo']);

  $estado_civil = mysqli_escape_string($conexao, $_POST['estadocivil']);

  $cpf = mysqli_escape_string($conexao, $_POST['cpf']);

  $rg = mysqli_escape_string($conexao, $_POST['rg']);

  //  MUDAR A , POR . ,primeiro vem oq voce quer tirar depois oq voce quer colocar e depois o campo que voce vai receber
  $salario = str_replace(',', '.', $_POST['salario']);

  $endereco = mysqli_escape_string($conexao, $_POST['rua']);

  $numero = mysqli_escape_string($conexao, $_POST['numero']);

  $complemento = mysqli_escape_string($conexao, $_POST['complemento']);

  $bairro = mysqli_escape_string($conexao, $_POST['bairro']);

  $cidade = mysqli_escape_string($conexao, $_POST['cidade']);

  $estado = mysqli_escape_string($conexao, $_POST['estado']);

  $cep = mysqli_escape_string($conexao, $_POST['cep']);

  $telefone_residencial = mysqli_escape_string($conexao, $_POST['telefoneresidencial']);

  $telefone_celular = mysqli_escape_string($conexao, $_POST['telefonecelular']);

  $email = mysqli_escape_string($conexao, $_POST['email']);

  $usuario = mysqli_escape_string($conexao, $_POST['usuario']);

  $senha = mysqli_escape_string($conexao, $_POST['senha']);

  $acesso = mysqli_escape_string($conexao, $_POST['acesso']);

  $status = mysqli_escape_string($conexao, $_POST['status']);

  //$data_cadastro = mysqli_escape_string($conexao, $_POST['data_cadastro']); FOI FEITO ANTES

  $cargo = mysqli_escape_string($conexao, $_POST['cargo']);

  $foto = mysqli_escape_string($conexao, $_POST['fotoatual']);

  if($_POST['remover_foto'] == '1')
    {
        $foto = '';
    }

  if (!empty($_FILES['fotoinput']['name'])) {
    $foto = basename($_FILES['fotoinput']['name']);

    $tmp = $_FILES['fotoinput']['tmp_name'];

    $final = "../../../images-funcionarios/" . $foto;

    move_uploaded_file($tmp, $final);
  }




  //INSERT
  //BIT É SEM ASPAS
  $sql = "UPDATE funcionario SET nome = '$nome', nome_social = '$nome_social', data_nascimento = '$data_nascimento', estado_civil = '$estado_civil', cpf = '$cpf', rg = '$rg', salario = '$salario', endereco = '$endereco', numero = $numero, complemento = '$complemento', bairro = '$bairro', cidade = '$cidade', estado = '$estado', cep = '$cep', telefone_residencial = '$telefone_residencial', telefone_celular = '$telefone_celular', email = '$email', usuario = '$usuario', senha = '$senha', tipo_acesso = $acesso, status = $status, id_cargo = $cargo, foto = '$foto'";

  $sql .= " WHERE id_funcionario = $id";

  try {
    if (mysqli_query($conexao, $sql)) {
      $_SESSION['mensagem_verde'] = "Funcionário(a) Editado(a) com Sucesso!";
    } else {
      $_SESSION['mensagem'] = "Erro ao Editar!";
    }
  } catch (mysqli_sql_exception) {
    $_SESSION['mensagem'] = "Erro ao Editar!";
  }

  header('Location: Index.php');
}


if (isset($_POST['deletarfuncionario'])) {
  $id_funcionario = $_POST['deletarfuncionario'];

  $sql = "DELETE FROM funcionario WHERE id_funcionario = ?";

  $stmt = mysqli_prepare($conexao, $sql);

  mysqli_stmt_bind_param($stmt, "i", $id_funcionario);

  if (mysqli_stmt_execute($stmt)) {
    $_SESSION['mensagem_verde'] = "Funcionário(a) Excluido(a) com Sucesso!";
    header('Location: index.php');
  } elseif (mysqli_stmt_error($stmt) == 1451) {
    $sqlcount = "SELECT COUNT(*) AS total FROM venda INNER JOIN funcionario ON funcionario.id_funcionario = venda.id_funcionario WHERE id_funcionario = ?";

    $stmtcount = mysqli_prepare($conexao, $sql);

    mysqli_stmt_bind_param($stmtcount, "i", $id_funcionario);

    mysqli_stmt_execute($stmtcount);

    // $resultado = mysqli_stmt_get_result($stmtcount);

    // $dadoscount = mysqli_fetch_assoc($resultado);

    // $funcionarioc = $dadoscount['total'];

    $_SESSION['mensagem_fk'] = "Não e Possível Excluir esse Funcionário pois ele Possui Histórico de Vendas Cadastrados";

    header('Location: index.php');
  } else {
    $_SESSION['mensagem'] = "Erro ao Excluir!";
    header('Location: index.php');
  }
}
