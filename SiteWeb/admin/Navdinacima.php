<?php 

  // PEGAR O QUE ESTA APÓS O NOME HOST DA URL USANDO A VARIAVEL SUPER GLOBAL
   $url_parcial = $_SERVER['REQUEST_URI'];

   // CRIA UM ARRAY USANDO UMA FUNÇÃO E USA A / COMO SEPARADOR, INDICE 0 SERIA VAZIO PORQUE DEPOIS DA PRIMEIRA BARRA NAO TEM NADA
    $caminho = explode("/", $url_parcial);

    // RECONHECE SE ESTA ONLINE OU APENAS NO HOST
    $url = "http://" . $_SERVER['HTTP_HOST'] . "/" . $caminho[1] . "/" . $caminho[2] . "/" . $caminho[3];

    // http://localhost/VortexShoes/Painel_Administrativo/admin/

?>