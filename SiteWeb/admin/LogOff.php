<?php 

if (!isset($_SESSION)) {
  session_start();
}


unset($_SESSION['USER'], $_SESSION['TYPE']);

$_SESSION['logOFF'] = "LogOff realizado com sucesso!";

header('Location: ../Index.php');

?>