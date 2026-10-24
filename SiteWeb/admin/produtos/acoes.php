<?php

require_once __DIR__ . "/../../conexao/conecta.php";

if (!isset($_SESSION)) {
  session_start();
}

if (isset($_POST['cadastrar']) && $_POST['cadastrar'] == "cadastrar_produto") {
  $nome = $_POST['nome'];

  $fornecedor = $_POST['fornecedor'];

  $categoria = $_POST['categoria'];

  $marca = $_POST['marca'];
  
  $destaque = $_POST['destaque'];


    if(empty($_FILES['foto_produto']['name']))
    {
        $_SESSION['mensagem'] = "Coloque uma foto obrigatória";
        header('Location: inserir.php');
        exit();
    }

 
    $foto = basename($_FILES['foto_produto']['name']);
    $tmp1 = $_FILES['foto_produto']['tmp_name'];
    move_uploaded_file($tmp1, "../../../imagens-produtos/" . $foto);



    $foto2 = "";
    if (!empty($_FILES['foto_produto2']['name'])) {
        $foto2 = basename($_FILES['foto_produto2']['name']);
        move_uploaded_file($_FILES['foto_produto2']['tmp_name'], "../../../imagens-produtos/" . $foto2);
    }



    $foto3 = "";
    if (!empty($_FILES['foto_produto3']['name'])) {
        $foto3= basename($_FILES['foto_produto3']['name']);
        move_uploaded_file($_FILES['foto_produto3']['tmp_name'], "../../../imagens-produtos/" . $foto3);
    }



    $foto4= "";
    if (!empty($_FILES['foto_produto4']['name'])) {
        $foto4 = basename($_FILES['foto_produto4']['name']);
        move_uploaded_file($_FILES['foto_produto4']['tmp_name'], "../../../imagens-produtos/" . $foto4);
    }


  $custo_produto = str_replace(',' , '.' , $_POST['custo_produto']);

  $estoque = $_POST['estoque'];

  $lucro =  str_replace(',' , '.' , $_POST['lucro']);

  $tamanho =  str_replace(',' , '.' , $_POST['tamanho']);

  $valor_produto =  str_replace(',' , '.' , $_POST['valor_produto']);

  $promocao = $_POST['promocao'];

  $desconto_produto = str_replace(',' , '.' , $_POST['desconto_produto']);
  
  $valor_promocao =  str_replace(',' , '.' , $_POST['valor_promocao']);

  $cor = $_POST['cor'];

  $descricao = $_POST['descricao'];

  $sql = "INSERT INTO produto VALUES (0, ?, ?, ?, ?, ?, ?, ?, ?, NOW(), ?, ?, ?, ?, ?, ?, ?, 1, ?, ?, ?, ?)";

  try {


    
   
    $stmt = mysqli_prepare($conexao, $sql);

    mysqli_stmt_bind_param($stmt, "iiisssssssddiddssii", $marca, $categoria, $fornecedor, $nome, $foto, $foto2, $foto3, $foto4, $tamanho, $custo_produto, $lucro, $valor_produto, $promocao, $desconto_produto, $valor_promocao, $cor, $descricao, $destaque, $estoque);


    if (mysqli_stmt_execute($stmt)) {

      $_SESSION['mensagem_verde'] = "Produto Cadastrado com Sucesso";
    } else {

      $_SESSION['mensagem'] = "Erro ao Cadastrar!";
    }
  } catch (mysqli_sql_exception) {

    $_SESSION['mensagem'] = "Erro ao Cadastrar!";
  

  
  }
  header('Location: inserir.php');
}


if (isset($_POST['editar']) && $_POST['editar'] == "editar_produto") {



  $id_produto = $_POST['id_produto'];
  $nome = $_POST['nome'];
  $status = $_POST['status'];
  $fornecedor = $_POST['fornecedor'];
  $categoria = $_POST['categoria'];
  $marca = $_POST['marca'];
  $descricao = $_POST['descricao'];
  $destaque = $_POST['destaque'];
  $estoque = $_POST['estoque'];

  $sql_busca = "SELECT produto_foto1, produto_foto2, produto_foto3, produto_foto4 FROM produto WHERE id_produto = ?";
  $stmt_busca = mysqli_prepare($conexao, $sql_busca);
  mysqli_stmt_bind_param($stmt_busca, "i", $id_produto);
  mysqli_stmt_execute($stmt_busca);
  $res = mysqli_stmt_get_result($stmt_busca);
  $produto_atual = mysqli_fetch_assoc($res);

  if (!empty($_FILES['foto_produto']['name'])) {
      // Se enviou uma nova foto, faz o upload
      $foto = basename($_FILES['foto_produto']['name']);
      move_uploaded_file($_FILES['foto_produto']['tmp_name'], "../../../imagens-produtos/" . $foto);
  } else {
      $foto = $produto_atual['produto_foto1'];
  }

  if (!empty($_FILES['foto_produto2']['name'])) {
      $foto2 = basename($_FILES['foto_produto2']['name']);
      move_uploaded_file($_FILES['foto_produto2']['tmp_name'], "../../../imagens-produtos/" . $foto2);
  } else {
      $foto2 = $produto_atual['produto_foto2'];
  }

  if (!empty($_FILES['foto_produto3']['name'])) {
      $foto3 = basename($_FILES['foto_produto3']['name']);
      move_uploaded_file($_FILES['foto_produto3']['tmp_name'], "../../../imagens-produtos/" . $foto3);
  } else {
      $foto3 = $produto_atual['produto_foto3'];
  }

  if (!empty($_FILES['foto_produto4']['name'])) {
      $foto4 = basename($_FILES['foto_produto4']['name']);
      move_uploaded_file($_FILES['foto_produto4']['tmp_name'], "../../../imagens-produtos/" . $foto4);
  } else {
      $foto4 = $produto_atual['produto_foto4'];
  }

  $custo_produto = str_replace(',', '.', $_POST['custo_produto']);
  $lucro = str_replace(',', '.', $_POST['lucro']);
  $tamanho = str_replace(',', '.', $_POST['tamanho']);
  $valor_produto = str_replace(',', '.', $_POST['valor_produto']);
  $promocao = $_POST['promocao'];
  $desconto_produto = str_replace(',', '.', $_POST['desconto_produto']);
  $valor_promocao = str_replace(',', '.', $_POST['valor_promocao']);
  $cor = $_POST['cor'];

  $sql = "UPDATE produto SET nome_produto = ?, status_produto = ?, id_fornecedor = ?, id_marca = ?, id_categoria = ?, produto_foto1 = ?, produto_foto2 = ?, produto_foto3 = ?, produto_foto4 = ?, preco_custo = ?, lucro = ?, tamanho = ?, preco_venda = ?, promocao = ?, desconto = ?, preco_desconto = ?, cor = ?, descricao = ?, status_destaque = ?, estoque = ? WHERE id_produto = ?";

  try {
    $stmt = mysqli_prepare($conexao, $sql);

    mysqli_stmt_bind_param($stmt, "siiiissssddsdiddssiii", $nome, $status, $fornecedor, $marca, $categoria, $foto, $foto2, $foto3, $foto4, $custo_produto, $lucro, $tamanho, $valor_produto, $promocao, $desconto_produto, $valor_promocao, $cor, $descricao, $destaque, $estoque, $id_produto);

    if (mysqli_stmt_execute($stmt)) {
      $_SESSION['mensagem_verde'] = "Produto Editado com Sucesso!";
    } else {
      $_SESSION['mensagem'] = "Erro ao Editar Produto!";
    }
  } catch (mysqli_sql_exception $e) {
    $_SESSION['mensagem'] = "Erro ao Editar!";
  }

  header('Location: index.php');
}


if(isset($_POST['deletarproduto']))
  {
    
    $id_produto = $_POST['deletarproduto'];

    $sql = "DELETE FROM produto WHERE id_produto = ?";

    $stmt = mysqli_prepare($conexao, $sql);

    mysqli_stmt_bind_param($stmt, "i", $id_produto);

    if(mysqli_stmt_execute($stmt))
      {
          $_SESSION['mensagem_verde'] = "Produto Excluido com Sucesso!";
          header('Location: index.php');
      }
      elseif(mysqli_stmt_errno($stmt) == 1451)
        {
              // FAZER O BLOCO PARA CONTAR AS VENDAS QUE O PRODUTO TEM DEPOIS
              $_SESSION['mensagem'] = "Não e Possível Excluir esse Produto pois ele Possui Histórico de Vendas Cadastrados";
              header('Location: index.php');
        }
        else
          {
              $_SESSION['mensagem'] = "Erro ao Excluir!";
              header('Location: index.php');
          }

  }