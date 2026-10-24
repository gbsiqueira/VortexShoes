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
        include('../Log.php'); // BOAS VINDAS MONSTRANDO O USUARIO LOGADO
        include('../mensagem.php'); // MENSAGEM DE ERRO OU SUCESSO
        ?>

        <div class="card bg-dark text-white">

          <div class="card-header d-flex justify-content-between">
            <h4 class="m-0">Cargos</h4>

            <a href="Inserir.php" class="btn btn-primary btn-sm">
              <i class="bi bi-plus"></i>

              Adicionar
            </a>

          </div>

          <?php
          // codigo para executar no banco
          $sql_cargo = "SELECT id_cargo FROM cargo";

          // o banco que eu quero que execute, e o comando
          $query_cargo = mysqli_query($conexao, $sql_cargo);

          // se tiver uma linha ou mais
          if (mysqli_num_rows($query_cargo) > 0) {
          ?>

            <div class="card-body">

              <div class="row pb-2">
                <!-- FILTRO POR STATUS -->
                <div class="col-2">
                  <form action="" method="get">

                  <!-- onchange seria quando mudar se opção, e o submit e para disparar o formulario -->
                    <select name="status" id="status" class="form-control" onchange="submit()">

                      <option value="">Status</option>
                      <!-- SE FOR O STATUS PEGO NO GET FOR IGUAL A X ELE FICA SEMPRE SELECIONADO -->
                      <option value="1" <?php if(isset($_GET['status']) && $_GET['status'] == '1') {echo 'selected';}?>>Ativo</option>
                      <option value="0" <?php if(isset($_GET['status']) && $_GET['status'] == '0') {echo 'selected';}?>>Inativo</option>

                    </select>

                  </form>

                </div>
                <!-- BUSCA POR NOME -->
                <div class="col-4">

                  <form action="" method="get">
                    <!-- TIPO SEARCH SO DE DA ENTER ELE ENTENDE QUE PRECISA FAZER UMA BUSCA, E NAO VAI PRECISAR DE UM BOTÃO -->
                    <input type="search" name="pesquisa" id="pesquisa" class="form-control" placeholder="Digite o cargo">
                  </form>

                </div>

              </div>

            </div>

            <?php  

              if(isset($_GET['pesquisa']) && $_GET['pesquisa'] != '')
              {
                  $pesquisa = "%" . $_GET['pesquisa'] . "%";

                  $sql = "SELECT * FROM cargo WHERE nome LIKE ?";

                  $stmt = mysqli_prepare($conexao, $sql);

                  mysqli_stmt_bind_param($stmt, 's', $pesquisa);

                  mysqli_stmt_execute($stmt);

                  $query = mysqli_stmt_get_result($stmt);

              }
              else if(isset($_GET['status']) && $_GET['status'] != '')
                {
                    $status = $_GET['status'];

                    $sql = "SELECT * FROM cargo WHERE status = ?";

                    $stmt = mysqli_prepare($conexao, $sql);

                    mysqli_stmt_bind_param($stmt, 'i', $status);

                    mysqli_stmt_execute($stmt);

                    $query = mysqli_stmt_get_result($stmt);
                }
              else
                {
                    $sql = "SELECT * FROM cargo";
                    
                  $query =  mysqli_query($conexao, $sql);
                }

              
                if(mysqli_num_rows($query) > 0 )
                  {

                  

            ?>
            <div class="card-body p-0">
              <!-- TABELA USA ESSSA TAG -->
              <table class="table table-striped table-dark">

                <!-- CABEÇALHO DA TABELA -->
                <thead class="table-dark">
                  <!-- TABLE ROW: LINHA DA TABELA -->
                  <tr class="text-center">
                    <!-- TABLE HEAD: TITULO DA COLUNA -->
                    <th>ID</th>
                    <th>Cargo</th>
                    <th>Observação</th>
                    <th>Status</th>
                    <th>Data Cadastro</th>
                    <th>Ações</th>
                  </tr>

                </thead>
                <!-- CORPO DA TABELA: DADOS -->
                <tbody>

                  <?php
                    foreach($query as $cargo)
                    {
                  ?>

                  <!-- LINHA DA TABELA -->
                  <tr class="text-center">
                    <!-- TABLE DATA: DADOS DA TABELA -->
                    <td><?php echo $cargo['id_cargo']?></td>
                    <td><?php echo $cargo['nome']?></td>
                    <td><?php echo $cargo['observacao']?></td>
                    <td>
                        <?php 
                          if($cargo['status'] == 1)
                            {
                              echo '<span class="badge rounded-pill text-bg-success">Ativo</span>';
                            }
                            else
                              {
                                  echo '<span class="badge rounded-pill text-bg-danger">Inativo</span>';
                              }
                        ?>

                    </td>
                    <!-- Função para formatar data, primeiro como voce quer que fique, e depois a data, strtotime vai converter uma data e hora para string -->
                    <td><?php echo date('d/m/Y', strtotime($cargo['data_cadastro']))?></td>
                    <td>
                        <!-- ENVIAR O ID NA URL  -->
                      <a href="editar.php?id_cargo=<?php echo $cargo['id_cargo']?>" class="btn btn-outline-success btn-sm" title="Editar"><i class="bi bi-pencil"></i></a>

                      <!-- FORM DO BOTAO EXCLUIR -->
                      <form action="acoes.php" method="post" class="d-inline">
                        <button type="submit" class="btn btn-outline-danger btn-sm" title="Excluir" name="deletarcargo" value="<?php echo $cargo['id_cargo'] ?>" onclick="return confirm('Tem certeza que deseja excluir o cargo <?php echo $cargo['nome']?> ?')"><i class="bi bi-trash"></i></button>
                      </form>

                    </td>
                  </tr>

                  <?php 
                    }

                  ?>

                </tbody>

              </table>

            </div>
            <?php 
                    }
                    else {  
                echo '<div class="alert alert-warning d-flex align-items-center justify-content-center" role="alert">
                  Nenhum registro encontrado
                </div>
              </div>';
                    }
            ?>

          <?php
          }
            // se nao
            else {  
              echo '<div class="alert alert-danger d-flex align-items-center justify-content-center" role="alert">
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
</body>

</html>