<?php 

  $servidor = "localhost";
  $usuario = "root";
  $senha = "";
  $banco = "vortexshoes";

  // Deve ser nessa ordem
  $conexao = mysqli_connect($servidor, $usuario, $senha, $banco);

  // se der qualquer numero de erro
    if(mysqli_connect_errno())
    {
      die("Falha na conexão: " .mysqli_connect_error());
    }

?>