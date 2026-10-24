<?php

// CONEXAO COM BANCO
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

  
  <!-- CSS -->
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

        <!-- IF COMECA AQUI -->
        <!-- VERIFICANDO SE CHEGOU O ID CARGO PELA URL, SE CHEGOU VOCE CRIA UMA VARIAVEL PARA O ID, E DEPOIS CRIA UM SLQ PRA CONSULTAR O QUE JA POSSUI NO BANCO -->
       <?php 
       if(isset($_GET['id_cargo']) && $_GET['id_cargo'] !='')
        {
            $id = $_GET['id_cargo'];

            $sql = "SELECT * FROM cargo WHERE id_cargo = $id";

            $query = mysqli_query($conexao, $sql);
          
            // NAO VAI SER FOREACH PORQUE NAO E UMM LOOPING, SERIA APENAS UMA LINHA QUE VAI RETORNAR, TRANSFORMAR AS INFORMAÇÕES EM UM ARRAY ASSOCIATIVO
            $cargo = mysqli_fetch_assoc($query);
        
       ?>
        <div class="card bg-dark text-white">

          <div class="card-header d-flex justify-content-between">
            <h4 class="m-0">Editar Cargo</h4>

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
                  <label for="cargo" class="mb-1"><strong class="text-danger">*</strong> Cargo: </label>
                  <!-- MAXLENGHT 40 CARACTERES, REQUIRED CAMPO OBRIGATÓRIO -->
                   <!-- VALUE PARA O CAMPO JA VIR PREENCHIDO -->
                  <input type="text" name="cargo" id="cargo" class="form-control" maxlength="40" value="<?php echo $cargo['nome']?>" required>

                </div>

                <div class="col-6">
                  <label for="status" class="mb-1">Status: </label>
                  <!-- DISABLED PARA O USUARIO NAO CONSEGUIR MUDAR A OPÇÃO, EM OUTROS CASOS TEM QUE SER FEITO EM JS PORQUE SENAO O PHP IGNORA -->
                   <!-- QUANDO VOCE PRECISAR MUDAR O VALUE E FOR SELECT -->
                  <select name="status" id="status" class="form-control">
                    <option value="1" <?php if($cargo['status'] == 1) echo 'selected'?>>Ativo</option>
                    <option value="0" <?php if($cargo['status'] == 0) echo 'selected'?>>Inativo</option>
                  </select>
                </div>

                <div class= "col-12 mt-2">
                  <label for= "observacao" class="mb-1">Observação</label>
                  <!-- CAMPO DE TEXTO MAIOR -->
                   <!-- TEXT AREA NAO TEM O ATRIBUTO VALUE, ENTAO VOCE DEVE COLOCAR DENTRO DA ABERTURA E FECHAMENTO DA TAG-->
                  <textarea name="observacao" id="observacao" class="form-control" maxlength="100"><?php echo $cargo['observacao']?></textarea>

                  <!-- MUDAR PARA EDITAR -->
                  <input type="hidden" name="editar" value="editar_cargo">
                  <!-- ID DO CARGO -->  
                  <input type="hidden" name="id_cargo" value="<?php echo $id?>">

                  <!-- MUDAR O TEXT -->
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
                   Cargo não encontrada
                </div>
              </div>';
          }
        
        ?>

        <!-- TERMINA AQUI -->
      </main>

    </div>

  </div>

  <!-- JQUERY CDN -->
  <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.7.1/jquery.min.js" integrity="sha512-v2CJ7UaYy4JwqLDIrZUI/4hqeoQieOmAZNXBeQyjo21dadnwR+8ZaIJVT8EE2iyI61OV8e6M8PP2/4hpQINQ/g==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
  <!-- BOOTSTRAP JS -->
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>
</body>

</html>