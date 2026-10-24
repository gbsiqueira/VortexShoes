<?php

require_once __DIR__ . "/../conexao/conecta.php";

if (!isset($_SESSION)) {
  session_start();
}

if (isset($_POST['usuario']) && $_POST['usuario'] != '' && isset($_POST['senha']) && $_POST['senha'] != '') {
  // LOGIN
  $usuario = $_POST['usuario'];
  $senha = $_POST['senha'];

  $sql = "SELECT * FROM funcionario WHERE usuario = ? AND senha = ? AND status = 1";

  $stmt = mysqli_prepare($conexao, $sql);

  mysqli_stmt_bind_param($stmt, "ss", $usuario, $senha);

  mysqli_stmt_execute($stmt);

  $query = mysqli_stmt_get_result($stmt);

  $funcionario = mysqli_fetch_assoc($query);

  //echo $funcionario['usuario']; TESTE 

  if (isset($funcionario)) {
    $_SESSION['ID'] = $funcionario['id_funcionario'];
  }


  if (isset($funcionario)) {
    $_SESSION['USER'] = $funcionario['usuario'];
  }

  if (isset($funcionario)) {
    $_SESSION['TYPE'] = $funcionario['tipo_acesso'];
  }

  if (isset($funcionario)) {
    $_SESSION['NAME'] = $funcionario['usuario'];

    header('Location: Admin.php');
  }
  else
    {
      $_SESSION['loginErro'] = "Usuário ou senha inválidos";
      header('Location: index.php');
    }



} 
else
{
  $_SESSION['LoginVazio'] = "Informe usuário e senha";
  header('Location: Index.php');
}
