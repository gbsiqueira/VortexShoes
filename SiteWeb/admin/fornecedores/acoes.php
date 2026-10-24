<?php 

require_once __DIR__ . "/../../conexao/conecta.php";

if(!isset($_SESSION))
  session_start();

if(isset($_POST['cadastrar']) && $_POST['cadastrar'] == "cadastrar_fornecedor")
  {
     $fornecedor = $_POST['fornecedor'];

     $observacao = $_POST['observacao'];

     $email = $_POST['email'];

     $cnpj = $_POST['cnpj'];

     $sql = "INSERT INTO fornecedor VALUES (0, ?, 1, NOW(), ?, ?, ?)";

     try
     {
        $stmt = mysqli_prepare($conexao, $sql);

          mysqli_stmt_bind_param($stmt, "ssss", $fornecedor, $observacao, $email, $cnpj);

           if(mysqli_stmt_execute($stmt))
              {
                $_SESSION['mensagem_verde'] = "Fornecedor(a) cadastrado com sucesso!";
              }
              else
                {
                   $_SESSION['mensagem'] = "Erro ao cadastrar!";
                }

     }
     catch(mysqli_sql_exception)
     {

      $_SESSION['mensagem'] = "Erro ao Cadastrar!";

     }

     header('Location: inserir.php');

  }




if(isset($_POST['editar']) && $_POST['editar'] == "editar_fornecedor")
  {
     $fornecedor = $_POST['fornecedor'];

     $observacao = $_POST['observacao'];

     $status = $_POST['status'];

     $email = $_POST['email'];

     $cnpj = $_POST['cnpj'];

     $id = $_POST['id_fornecedor'];

     $sql = "UPDATE fornecedor SET nome_fornecedor = ?, observacao = ?, status_fornecedor = ?, email = ?, cnpj = ? WHERE id_fornecedor = ?";

     try
     {
        $stmt = mysqli_prepare($conexao, $sql);

          mysqli_stmt_bind_param($stmt, "ssissi", $fornecedor, $observacao, $status, $email, $cnpj, $id);

           if(mysqli_stmt_execute($stmt))
              {
                $_SESSION['mensagem_verde'] = "Fornecedor(a) Editado com sucesso!";
              }
              else
                {
                   $_SESSION['mensagem'] = "Erro ao Editar!";
                }

     }
     catch(mysqli_sql_exception)
     {

      $_SESSION['mensagem'] = "Erro ao Editar!";

     }

     header('Location: Index.php');

  }

  if(isset($_POST['deletarfornecedor']))
    {
        $id_fornecedor = $_POST['deletarfornecedor'];

        $sql = "DELETE FROM fornecedor WHERE id_fornecedor = ?";

        $stmt = mysqli_prepare($conexao, $sql);

        mysqli_stmt_bind_param($stmt, "i", $id_fornecedor);

        if(mysqli_stmt_execute($stmt))
          {
              $_SESSION['mensagem_verde'] = "Fornecedor(a) Excluido(a) com Sucesso!";
              header('Location: index.php');
          }
          elseif(mysqli_stmt_errno($stmt) == 1451)
            {

              $sqlcount = "SELECT COUNT(*) AS total FROM fornecedor INNER JOIN produto ON produto.id_fornecedor = fornecedor.id_fornecedor WHERE produto.id_fornecedor = ?";

              $stmtcount = mysqli_prepare($conexao, $sqlcount);

              mysqli_stmt_bind_param($stmtcount, "i", $id_fornecedor);

              mysqli_stmt_execute($stmtcount);

              $resultado = mysqli_stmt_get_result($stmtcount);

              $dadoscount = mysqli_fetch_assoc($resultado);

              $fornecedorc = $dadoscount['total'];

              $_SESSION['mensagem_fk'] = "Esse(a) Fornecedor(a) está sendo utilizado em $fornecedorc Produto(s)";
              header('Location: index.php');
            }
            else
              {
                  $_SESSION['mensagem'] = "Erro ao Excluir!";
                  header('Location: index.php');
              }
    }

?>