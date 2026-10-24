<?php

// CONEXÃO COM O BANCO
require_once __DIR__ . "/../../conexao/conecta.php";

if (!isset($_SESSION)) {
  session_start();
}

if (isset($_POST['cadastrar']) && $_POST['cadastrar'] == "cadastrar_marca") {

  $marca = $_POST['marca'];

  $observacao = $_POST['observacao'];


  $sql = "INSERT INTO marca VALUES (0, 1, ?, NOW(), ?)";

  try {

    $stmt = mysqli_prepare($conexao, $sql);

    mysqli_stmt_bind_param($stmt, "ss", $marca, $observacao);

    if (mysqli_stmt_execute($stmt)) {

      $_SESSION['mensagem_verde'] = "Marca Cadastrada com Sucesso!";
    } 
    else {

      $_SESSION['mensagem'] = "Erro ao Cadastrar!";
    }

  } 
  catch (mysqli_sql_exception) {

    $_SESSION['mensagem'] = "Erro ao Cadastrar!";
  }

  header('Location: inserir.php');
}



if (isset($_POST['editar']) && $_POST['editar'] == "editar_marca") {

  $marca = $_POST['marca'];

  $observacao = $_POST['observacao'];

  $id = $_POST['id_marca'];

  $status = $_POST['status'];


  $sql = "UPDATE marca SET nome_marca = ?, status_marca = ?, observacao = ? WHERE id_marca = ?";

  try {

    $stmt2 = mysqli_prepare($conexao, $sql);

    mysqli_stmt_bind_param($stmt2, "sisi", $marca, $status, $observacao, $id);

 

    if (mysqli_stmt_execute($stmt2)) {

      $_SESSION['mensagem_verde'] = "Marca Editada com Sucesso!";
    } 
    else {

      $_SESSION['mensagem'] = "Erro ao Editar!";
    }

  } 
  catch (mysqli_sql_exception) {

    $_SESSION['mensagem'] = "Erro ao Editar!";
  }

  header('Location: Index.php');
}


if(isset($_POST['deletarmarca']))
  {
      $id_marca = $_POST['deletarmarca'];

      $sql = "DELETE FROM marca WHERE id_marca = ?";

      $stmt = mysqli_prepare($conexao, $sql);

      mysqli_stmt_bind_param($stmt, "i", $id_marca);

      if(mysqli_stmt_execute($stmt))
        {
            $_SESSION['mensagem_verde'] = "Marca Excluida com Sucesso!";
            header('Location: index.php');
        }
        elseif(mysqli_stmt_errno($stmt) == 1451)
          {
                $sqlcount = "SELECT COUNT(*) AS total FROM marca INNER JOIN produto ON produto.id_marca = marca.id_marca WHERE marca.id_marca = ?";

                $stmtcount = mysqli_prepare($conexao, $sqlcount);

                mysqli_stmt_bind_param($stmtcount, "i", $id_marca);

                mysqli_stmt_execute($stmtcount);

                $resultado = mysqli_stmt_get_result($stmtcount);

                $dados = mysqli_fetch_assoc($resultado);

                $marcac = $dados['total'];

                $_SESSION['mensagem_fk'] = "Essa Marca está sendo utilizada em $marcac Produto(s)";

                header('Location: index.php');
          }
          else
            {
                $_SESSION['mensagem'] = "Erro ao Excluir!";
                header('Location: index.php');
            }
  }