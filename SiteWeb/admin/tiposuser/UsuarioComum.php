<?php

if (!isset($_SESSION)) {
  session_start();
}

// VERIFICANDO SE EXISTE USUARIO LOGADO PARA PERMITIR ACESSO
if (!$_SESSION['USER']) {
  $_SESSION['naoAutorizado'] = "Apenas usuários logados podem acessar esta área";
  header('Location: ../Index.php');
}

?>
