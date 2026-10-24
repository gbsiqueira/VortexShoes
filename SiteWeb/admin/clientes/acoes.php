<?php 

require_once __DIR__ . "/../../conexao/conecta.php";

if(!isset($_SESSION))
  {
    session_start();
  }

  if(isset($_POST['cadastrar']) && $_POST['cadastrar'] == "cadastrar_cliente")
    {
      $nome = $_POST['nome'];
      
      $nomesocial = $_POST['nomesocial'];

      $cpf = $_POST['cpf'];

      $sexo = $_POST['sexo'];

      $telefone = $_POST['telefone'];

      $telefone2 = $_POST['telefone2'];

      $email = $_POST['email'];

      $data_nascimento = $_POST['datanascimento'];

      $cep = $_POST['cep'];

      $rua = $_POST['rua'];

      $numero = $_POST['numero'];

      $bairro = $_POST['bairro'];

      $estado = $_POST['estado'];

      $cidade = $_POST['cidade'];

      $complemento = $_POST['complemento'];

      $sqlcliente = "INSERT INTO cliente VALUES (0, ?, ?, ?, ?, ?, NOW(), 1, ?, ?, ?)";

      $sqlendereco = "INSERT INTO endereco VALUES (0, ?, ?, ?, ?, ?, ?, ?, ?, 1, NOW())";
     
      // INICIA A TRANSACAO, QIE SEGURA AS INFORMAÇÕES MAS NAO CONFIRMA AINDA
      mysqli_begin_transaction($conexao);

      try
      {
        
      $stmt = mysqli_prepare($conexao, $sqlcliente);

      mysqli_stmt_bind_param($stmt, "ssssssss", $nome, $nomesocial, $cpf, $sexo, $data_nascimento, $email, $telefone, $telefone2);

      mysqli_stmt_execute($stmt);

      // PEGA O ULTIMO ID QUE O INSERT DE CIMA CRIOU
      $id_cliente = mysqli_insert_id($conexao);


      $stmt2 = mysqli_prepare($conexao, $sqlendereco);

      mysqli_stmt_bind_param($stmt2, "isisssss", $id_cliente, $bairro, $numero, $estado, $rua, $complemento, $cidade, $cep);

      mysqli_stmt_execute($stmt2);

      if(!empty($_POST['cep2']))
        {
          $cep2 = $_POST['cep2'];

          $rua2 = $_POST['rua2'];

          $numero2 = $_POST['numero2'];

          $bairro2 = $_POST['bairro2'];

          $estado2 = $_POST['estado2'];

          $cidade2 = $_POST['cidade2'];

          $complemento2 = $_POST['complemento2'];

            $sqlendereco2 = "INSERT INTO endereco VALUES (0, ?, ?, ?, ?, ?, ?, ?, ?, 1, NOW())";

            $stmt3 = mysqli_prepare($conexao, $sqlendereco2);

            mysqli_stmt_bind_param($stmt3, "isisssss", $id_cliente, $bairro2, $numero2, $estado2, $rua2, $complemento2, $cidade2, $cep2);

            mysqli_stmt_execute($stmt3);
        }


      // CONFIRMA TUDO SE ESTIVER CERTO
      mysqli_commit($conexao);

      $_SESSION['mensagem_verde'] = "Cadastro feito com Sucesso!";
    
      } 
      catch(mysqli_sql_exception)
      {
        // DESFAZ CASO TENHA ERRO
        mysqli_rollback($conexao);

        $_SESSION['mensagem'] = "Erro ao Cadastrar!";
      }


     header('Location: Inserir.php');
  }


     if(isset($_POST['editar']) && $_POST['editar'] == "editar_cliente")
    {
      $nome = $_POST['nome'];

      $nomesocial = $_POST['nomesocial'];

      $id_end1 = $_POST['id_end1'];

      $statusend1 = $_POST['status2'];

      $id_cliente = $_POST['id_cliente'];
      
      $status_cliente = $_POST['status'];

      $cpf = $_POST['cpf'];

      $sexo = $_POST['sexo'];

      $telefone = $_POST['telefone'];

      $telefone2 = $_POST['telefone2'];

      $email = $_POST['email'];

      $data_nascimento = $_POST['datanascimento'];

      $cep = $_POST['cep'];

      $rua = $_POST['rua'];

      $numero = $_POST['numero'];

      $bairro = $_POST['bairro'];

      $estado = $_POST['estado'];

      $cidade = $_POST['cidade'];

      $complemento = $_POST['complemento'];

      $sqlcliente = "UPDATE cliente SET nome_cliente = ?, nome_social = ?, cpf_cliente = ?, data_nascimento_cliente = ?, status_cliente = ?, email = ?, telefone_cliente = ?, telefone_cliente2 = ?, sexo_cliente = ? WHERE id_cliente = ?";

      $sqlendereco = "UPDATE endereco SET cep = ?, rua = ?, numero = ?, cidade = ?, estado = ?, bairro = ?, complemento = ?, status = ? WHERE id_endereco = ?";
     
      // INICIA A TRANSACAO, QIE SEGURA AS INFORMAÇÕES MAS NAO CONFIRMA AINDA
      mysqli_begin_transaction($conexao);

      try
      {
        
      $stmt = mysqli_prepare($conexao, $sqlcliente);

      mysqli_stmt_bind_param($stmt, "ssssissssi", $nome, $nomesocial, $cpf, $data_nascimento, $status_cliente, $email, $telefone, $telefone2, $sexo, $id_cliente);


      mysqli_stmt_execute($stmt);
      
      $stmt2 = mysqli_prepare($conexao, $sqlendereco);

      mysqli_stmt_bind_param($stmt2, "ssissssii", $cep, $rua, $numero, $cidade, $estado, $bairro, $complemento, $statusend1, $id_end1);

      mysqli_stmt_execute($stmt2);

      if(!empty($_POST['cep2']))
        {
          $cep2 = $_POST['cep2'];

          $id_end2 = $_POST['id_end2'] ?? null;

          $rua2 = $_POST['rua2'];

          $numero2 = $_POST['numero2'];

          $statusend2 = $_POST['status3'];

          $bairro2 = $_POST['bairro2'];
          
          $estado2 = $_POST['estado2'];

          $cidade2 = $_POST['cidade2'];

          $complemento2 = $_POST['complemento2'];

          if(!empty($id_end2))
            {
              $sqlendereco2 = "UPDATE endereco SET cep = ?, rua = ?, numero = ?, bairro = ?, estado = ?, cidade = ?, complemento = ?, status = ? WHERE id_endereco = ?";

            $stmt3 = mysqli_prepare($conexao, $sqlendereco2);

            mysqli_stmt_bind_param($stmt3, "ssissssii",  $cep2, $rua2, $numero2, $bairro2, $estado2, $cidade2, $complemento2, $statusend2, $id_end2);

            mysqli_stmt_execute($stmt3);
            }
            else
            {
              $sqlendereco2 = "INSERT INTO endereco VALUES (0, ?, ?, ?, ?, ?, ?, ?, ?, 1, NOW())";
              $stmt3 = mysqli_prepare($conexao, $sqlendereco2);
              mysqli_stmt_bind_param($stmt3, "isisssss", $id_cliente, $bairro2, $numero2, $estado2, $rua2, $complemento2, $cidade2, $cep2);
              mysqli_stmt_execute($stmt3);
            }

            
        }


      // CONFIRMA TUDO SE ESTIVER CERTO
      mysqli_commit($conexao);

      $_SESSION['mensagem_verde'] = "Cliente Editado com Sucesso!";
    
      } 
      catch(mysqli_sql_exception)
      {
        // DESFAZ CASO TENHA ERRO
        mysqli_rollback($conexao);

        $_SESSION['mensagem'] = "Erro ao Editar!";
      }

     header('Location: Index.php');

    }
 
    if(isset($_POST['deletarcliente']))
      {
        
        mysqli_report(MYSQLI_REPORT_ERROR | MYSQLI_REPORT_STRICT);

        mysqli_begin_transaction($conexao);

        $id_cliente = mysqli_escape_string($conexao, $_POST['deletarcliente']);

        try
        {

        

         $sqlendereco = "DELETE FROM endereco WHERE id_cliente = ?";
          $stmtend = mysqli_prepare($conexao, $sqlendereco);
          mysqli_stmt_bind_param($stmtend, "i", $id_cliente);
          mysqli_stmt_execute($stmtend);


        $sqlcliente = "DELETE FROM cliente WHERE id_cliente = ?";
        $stmt = mysqli_prepare($conexao, $sqlcliente);
        mysqli_stmt_bind_param($stmt, "i", $id_cliente);
        mysqli_stmt_execute($stmt);
        
        mysqli_commit($conexao);
         
          $_SESSION['mensagem_verde'] = "Cliente Excluído com Sucesso!";

          header('Location: index.php');

          
        }
        catch(mysqli_sql_exception $e)
        {
          mysqli_rollback($conexao);

          if($e->getCode() == 1451)
            {
                $_SESSION['mensagem_fk'] = "Não e Possível Excluir esse Cliente pois ele Possui Histórico de Vendas Cadastrados";
            }
            else
           {
                $_SESSION['mensagem'] = "Erro ao Excluir o cliente!";
          }
            
        }
      }
?>