<?php

require_once __DIR__ . "/../../conexao/conecta.php";

// VERIFICANDO SE EXITE USUARIO LOGADO
include_once __DIR__ . "/../tiposuser/UsuarioComum.php";

?>

<!DOCTYPE html>
<html lang="pt-br">

<head>

  <meta charset="UTF-8">

  <meta name="viewport" content="width=device-width, initial-scale=1.0">

  <title>PAINEL ADMINISTRATIVO</title>

  <!-- BOOTSTRAP CSS -->
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">

  <!-- BOOTSTRAP ICONS -->
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.13.1/font/bootstrap-icons.min.css">

  <!-- CUSTOMIZAÇÃO DO TEMPLATE -->
  <link rel="stylesheet" href="../../assets/css/dashboard.min.css">
  <link rel="stylesheet" href="../../assets/css/styles.min.css">


  <link rel="stylesheet" href="../../custom/css/background.css">


</head>

<body>

  <?php
  #Início TOPO
  include('../Topo.php');
  #Final TOPO
  ?>

  <div class="container-fluid">
    <div class="row">
      <?php
      #Início MENU
      include('../Navegacao.php');
      #Final MENU
      ?>

      <main class="ms-auto col-lg-10 px-md-4">
        <?php
        include('../Log.php');
        include('../mensagem.php'); //Adicionando a mensagem
        ?>

          <?php 
          
          if(isset($_GET['id_fornecedor']) && $_GET['id_fornecedor'] != '')
            {
                $id = $_GET['id_fornecedor'];

                $sql = "SELECT * FROM fornecedor WHERE id_fornecedor = $id";

                $query = mysqli_query($conexao, $sql);

                $fornecedor = mysqli_fetch_assoc($query)
          ?>

        <div class="card bg-dark text-white">

          <div class="card-header d-flex justify-content-between">
            <h4 class="m-0">Editar Fornecedor</h4>

            <a href="Index.php" class="btn btn-primary btn-sm">
              <i class="bi bi-arrow-left-short"></i>

              Voltar
            </a>

          </div>


          <div class="card-body">

            <form action="acoes.php" method="post">
              <div class="row">
                <div class="col-6">
                  <!-- FOR TEM QUE SER IGUAL O ID -->
                  <label for="fornecedor"><strong class="text-danger">*</strong> Nome: </label>
                  <!-- MAXLENGHT 40 CARACTERES, REQUIRED CAMPO OBRIGATÓRIO -->
                  <input type="text" name="fornecedor" id="fornecedor" class="form-control" maxlength="60" required value="<?php echo $fornecedor['nome_fornecedor']?>">

                </div>

                <div class="col-6">
                  <label for="status">Status: </label>
                  <!-- DISABLED PARA O USUARIO NAO CONSEGUIR MUDAR A OPÇÃO, EM OUTROS CASOS TEM QUE SER FEITO EM JS PORQUE SENAO O PHP IGNORA -->
                  <select name="status" id="status" class="form-control">
                    <option value="1" <?php if($fornecedor['status_fornecedor'] == 1) echo 'selected'?>>Ativo</option>
                    <option value="0" <?php if($fornecedor['status_fornecedor'] == 0) echo 'selected'?>]>>Inativo</option>
                  </select>
                </div>

                 <div class="col-6 mt-2">
                  <!-- FOR TEM QUE SER IGUAL O ID -->
                  <label for="email"><strong class="text-danger">*</strong> Email: </label>
                  <input type="email" name="email" id="email" class="form-control" maxlength="50" required value="<?php echo $fornecedor['email'] ?>">


                </div>

                <div class="col-6 mt-2">

                  <label for="cnpj"> CNPJ </label>
                  <input type="text" name="cnpj" id="cnpj" class="form-control" maxlength="18" data-mask="00.000.000/0000-00" value="<?php  echo $fornecedor['cnpj'] ?>">

                </div>

                <div class="col-12 mt-2">
                  <label for="observacao">Observação</label>
                  <!-- CAMPO DE TEXTO MAIOR -->
                  <textarea name="observacao" id="observacao" class="form-control" maxlength="100"><?php echo $fornecedor['observacao']?></textarea>

                  <input type="hidden" name="editar" value="editar_fornecedor">
                  <input type="hidden" name="id_fornecedor" value="<?php echo $id ?>">

                  <button type="submit" class="btn btn-primary mt-4">Editar</button>

                </div>

              </div>

            </form>

          </div>

        </div>

        <?php 
            }
            else
              {
                echo '<div class="alert alert-warning d-flex align-items-center justify-content-center" role="alert">
                  Fornecedor não encontrado
                </div>
              </div>';
              }
        ?>

      </main>

    </div>

  </div>

  <!-- JQUERY CDN -->
  <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.7.1/jquery.min.js" integrity="sha512-v2CJ7UaYy4JwqLDIrZUI/4hqeoQieOmAZNXBeQyjo21dadnwR+8ZaIJVT8EE2iyI61OV8e6M8PP2/4hpQINQ/g==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
  <!-- BOOTSTRAP JS -->
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>
  <!-- JQUERY MASK, BIBLIOTECA PARA MASCARAS DE INPUTS SITE TEM TODAS AS DOCUMENTAÇÕES -->
  <script src="../../assets/js/jquery.mask.min.js"></script>
</body>

</html>