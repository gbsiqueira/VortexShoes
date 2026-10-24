<?php

// CONEXÃO COM O BANCO
require_once __DIR__ . "/../../conexao/conecta.php";

if (!isset($_SESSION)) {
  session_start();
}

if (isset($_POST['cadastrar']) && $_POST['cadastrar'] == "cadastrar_categoria") {

  $categoria = $_POST['categoria'];

  $observacao = $_POST['observacao'];

  $sql = "INSERT INTO categoria VALUES (0, ?, NOW(), 1, ?)";

  try {

    $stmt = mysqli_prepare($conexao, $sql);

    mysqli_stmt_bind_param($stmt, "ss", $categoria, $observacao);

    if (mysqli_stmt_execute($stmt)) {
      $_SESSION['mensagem_verde'] = "Categoria cadastrada com sucesso!";
    } else {
      $_SESSION['mensagem'] = "Erro ao cadastrar!";
    }
  } catch (mysqli_sql_exception) {
    $_SESSION['mensagem'] = "Erro ao cadastrar!";
  }

  header('Location: inserir.php');
}









if (isset($_POST['editar']) && $_POST['editar'] == "editar_categoria") {

  $categoria = $_POST['categoria'];

  $observacao = $_POST['observacao'];

  $status = $_POST['status'];

  $id = $_POST['id_categoria'];

  $sql = "UPDATE categoria SET nome_categoria = ?, observacao = ?, status_categoria = ? WHERE id_categoria = ?";

  try {

    $stmt = mysqli_prepare($conexao, $sql);

    mysqli_stmt_bind_param($stmt, "ssii", $categoria, $observacao, $status, $id);

    if (mysqli_stmt_execute($stmt)) {
      $_SESSION['mensagem_verde'] = "Categoria editada com sucesso!";
    } else {
      $_SESSION['mensagem'] = "Erro ao editar!";
    }
  } catch (mysqli_sql_exception) {
    $_SESSION['mensagem'] = "Erro ao editar!";
  }



  header('Location: Index.php');
}


if (isset($_POST['deletarcategoria'])) {

  $id_categoria = $_POST['deletarcategoria'];

  $sql = "DELETE FROM categoria WHERE id_categoria = ?";

   $stmt = mysqli_prepare($conexao, $sql);

   mysqli_stmt_bind_param($stmt, "i", $id_categoria);

   

  if (mysqli_stmt_execute($stmt)) {
    $_SESSION['mensagem_verde'] = "Categoria Excluida com Sucesso!";
    header('Location: index.php');
  } elseif (mysqli_errno($conexao) == 1451) {

      $sqlcount = "SELECT COUNT(*) AS total FROM categoria INNER JOIN produto ON produto.id_categoria = categoria.id_categoria WHERE categoria.id_categoria = $id_categoria";

      $resultadocount = mysqli_query($conexao, $sqlcount);

      $dadoscategoria = mysqli_fetch_assoc($resultadocount);

      $categoriatotal = $dadoscategoria['total'];

      $_SESSION['mensagem_fk'] = "Essa categoria está sendo usada em $categoriatotal produto(s)";

      header('Location: index.php');
  } else {

      $_SESSION['mensagem'] = "Erro ao excluir!";
      header("Location: index.php");
  }
}
