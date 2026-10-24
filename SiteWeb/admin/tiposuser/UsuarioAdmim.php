<?php

if (!isset($_SESSION)) {
  session_start();
}

// VERIFICANDO SE O USUARIO É ADMIN
if (!$_SESSION['TYPE'] != '1') {
  $_SESSION['naoAdm'] = "Apenas Administradores podem acessar essa área";
  header('Location: ../Index.php');
}

?>
