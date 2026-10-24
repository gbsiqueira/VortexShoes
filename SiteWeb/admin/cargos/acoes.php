<!-- conexão com o banco -->
<?php

  // O dir e para meio que retornar onde o arquivo esta dentro, require once ele tenta a conexão apenas uma vez
  require_once __DIR__ . "/../../conexao/conecta.php";


  // iniciando uma sessao
  if (!isset($_SESSION)) {
    session_start();
  }

  // editando
  if (isset($_POST['cadastrar']) && $_POST['cadastrar'] == "cadastrar_cargo") {
    // nao deixar caracteres errados ser enviados pro banco
    $cargo = mysqli_real_escape_string($conexao, $_POST['cargo']);

    // nao deixar caracteres errados ser enviados pro banco
    $observacao = mysqli_real_escape_string($conexao, $_POST['observacao']);;

    // comando para inserir os dados
    $sql = "INSERT INTO cargo VALUES (0, '$cargo', '$observacao', 1, NOW())";

   try
   {
       // se conseguir fazer a conexao e executar o sql sem erros
    if (mysqli_query($conexao, $sql)) {
      //header('Location: Index.php'); COMO TAVA ANTES
      $_SESSION['mensagem_verde'] = "Cargo cadastrado com sucesso!";
    } else {
      // mensagem de erro
      //die("erro: " . $sql . "<br>" . mysqli_error($conexao)); COMO TAVA ANTES
      $_SESSION['mensagem'] = "Erro ao cadastrar!";
    }
   }
   catch(mysqli_sql_exception)
   {
      $_SESSION['mensagem'] = "Erro ao cadastrar!";
   }

   header('Location: Inserir.php');

  }

   // editando um novo cargo
  if (isset($_POST['editar']) && $_POST['editar'] == "editar_cargo") {
    // nao deixar caracteres errados ser enviados pro banco
    $id_cargo = mysqli_real_escape_string($conexao, $_POST['id_cargo']);

    $cargo = mysqli_real_escape_string($conexao, $_POST['cargo']);

    // nao deixar caracteres errados ser enviados pro banco
    $observacao = mysqli_real_escape_string($conexao, $_POST['observacao']);

    $status = mysqli_real_escape_string($conexao, $_POST['status']);

    // comando para atualizar os dados, não esquece do where
    $sql = "UPDATE cargo SET nome = '$cargo', observacao = '$observacao', status = $status WHERE id_cargo = $id_cargo";

   try
   {
       // se conseguir fazer a conexao e executar o sql sem erros
    if (mysqli_query($conexao, $sql)) {
      //header('Location: Index.php'); COMO TAVA ANTES
      $_SESSION['mensagem_verde'] = "Cargo atualizado com sucesso!";
    } else {
      // mensagem de erro
      //die("erro: " . $sql . "<br>" . mysqli_error($conexao)); COMO TAVA ANTES
      $_SESSION['mensagem'] = "Erro ao atualizar!";
    }
   }
   catch(mysqli_sql_exception)
   {
      $_SESSION['mensagem'] = "Erro ao atualizar!";
   }
    // MUDA PARA INDEX
   header('Location: Index.php');

  }

  //delete de cargo
  if(isset($_POST['deletarcargo']))
    {
        $id_cargo = mysqli_escape_string($conexao, $_POST['deletarcargo']);

        $sql = "DELETE FROM cargo WHERE id_cargo = ?";
        // EM UM CENARIO REAL SERIA MELHOR APENAS INATIVALO MUDANDO O STATUS, E NAO APAGANDO

        $stmt = mysqli_prepare($conexao, $sql);

        mysqli_stmt_bind_param($stmt, "i", $id_cargo);

        if(mysqli_stmt_execute($stmt))
          {
              $_SESSION['mensagem_verde'] = "Cargo Excluido com Sucesso!";
              header("Location: index.php");
          }
          elseif(mysqli_stmt_errno($stmt) == 1451)
            {

              $sqlcount = "SELECT COUNT(*) AS total FROM cargo INNER JOIN funcionario ON funcionario.id_cargo = cargo.id_cargo WHERE cargo.id_cargo = ?";

              $stmtcount = mysqli_prepare($conexao, $sqlcount);

              mysqli_stmt_bind_param($stmtcount, "i", $id_cargo);

              mysqli_stmt_execute($stmtcount);

             $resultado = mysqli_stmt_get_result($stmtcount);

             $dadoscount = mysqli_fetch_assoc($resultado);

             $funcionarios = $dadoscount['total'];

              $_SESSION['mensagem_fk'] = "Esse cargo está sendo utilizado em $funcionarios Funcionário(s)";

              header("Location: index.php");

            }
          else
            {
              $_SESSION['mensagem'] = "Erro ao excluir!";
              header("Location: index.php");

            }

    }
?>