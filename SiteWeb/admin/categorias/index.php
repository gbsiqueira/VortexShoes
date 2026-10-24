<!-- conexão com o banco -->
<?php

// O dir e para meio que retornar onde o arquivo esta dentro, require once ele tenta a conexão apenas uma vez
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
        include ('../Mensagem.php');
        ?>

        <div class="card bg-dark text-white">

          <div class="card-header d-flex justify-content-between">
            <h4 class="m-0">Categorias</h4>

            <a href="Inserir.php" class="btn btn-primary btn-sm">
              <i class="bi bi-plus"></i>

              Adicionar
            </a>

          </div>

          <?php
          // codigo para executar no banco
          $sql = "SELECT id_categoria FROM categoria";

          // o banco que eu quero que execute, e o comando
          $query = mysqli_query($conexao, $sql);

          // se tiver uma linha ou mais
          if (mysqli_num_rows($query) > 0) {
          ?>

            <div class="card-body">

              <div class="row pb-2">
                <!-- FILTRO POR STATUS -->
                <div class="col-2">
                  

                    <select name="status" id="status" class="form-control" onchange="Buscar()">

                      <option value="">Status </option>
                      <option value="1">Ativo </option>
                      <option value="0">Inativo </option>

                    </select>

                 

                </div>
                <!-- BUSCA POR NOME -->
                <div class="col-4">

                    <!-- TIPO SEARCH SO DE DA ENTER ELE ENTENDE QUE PRECISA FAZER UMA BUSCA, E NAO VAI PRECISAR DE UM BOTÃO -->
                    <input type="search" name="pesquisa" id="pesquisa" class="form-control" placeholder="Digite a categoria">
                 

                </div>

              </div>

            </div>

            <div class="card-body p-0">
              <!-- TABELA USA ESSSA TAG -->
               <div id="table"></div>
          

            </div>

          <?php
          }
          // se nao
          else {
              echo '<div class="alert alert-warning d-flex align-items-center justify-content-center" role="alert">
    Nenhum registro encontrado
  </div>
</div>';
          }
          ?>

        </div>

      </main>

    </div>

  </div>



<!-- fechar a conexão do banco -->
 <?php mysqli_close($conexao)?>

  <!-- JQUERY CDN -->
  <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.7.1/jquery.min.js" integrity="sha512-v2CJ7UaYy4JwqLDIrZUI/4hqeoQieOmAZNXBeQyjo21dadnwR+8ZaIJVT8EE2iyI61OV8e6M8PP2/4hpQINQ/g==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
  <!-- BOOTSTRAP JS -->
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>

  <script>

    function Listar(status, nome)
  {
    $('#table').text('Carregando...')

    $.ajax({

    url: "tabela.php",
    method: "Post",
    data:
    {
      status, nome
    },
    dataType: "html",

    success : function(resultado)
    {
      $('#table').html(resultado);
    }

    })
  }

  $(document).ready(function(){

  Listar()

  $('#pesquisa').keyup(function(){

  let pesquisa = $(this).val();

  let status = $('#status').val();

  Listar(status, pesquisa);

  })

  })

  function Buscar()
  {
      let status = $('#status').val();

      let pesquisa = $('#pesquisa').val();
      
      Listar(status, pesquisa);
  }


  </script>

</body>

</html>