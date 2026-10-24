<?php 

// CONEXAO COM O BANCO  
require_once __DIR__ . "/../../conexao/conecta.php";


$sql = "SELECT * FROM marca WHERE 1=1";

$status = $_POST['status'];

$nome = mysqli_escape_string($conexao, $_POST['nome']);

if($status != '')
  {
    $sql .= " AND marca.status_marca = $status";
  }

  if(!empty($nome))
    {
      $sql .= " AND marca.nome_marca LIKE '%$nome%'";
    }

    $query = mysqli_query($conexao, $sql);


    if(mysqli_num_rows($query) > 0)
      {

    

        
?>

<table class="table table-striped table-dark">

     <!-- CABEÇALHO DA TABELA -->
    <thead class="table-dark">
       <!-- TABLE ROW: LINHA DA TABELA -->
      <tr class="text-center">
         <!-- TABLE HEAD: TITULO DA COLUNA -->
        <th>ID</th>
        <th>Marca</th>
        <th>Observação</th>
        <th>Status</th>
        <th>Data Cadastro</th>
        <th>Ações</th>
      </tr>

    </thead>
    <!-- CORPO DA TABELA: DADOS -->
    <tbody>

      <?php
        foreach($query as $marca)
        {
      ?>

      <!-- LINHA DA TABELA -->
      <tr class="text-center">
        <!-- TABLE DATA: DADOS DA TABELA -->
        <td><?php echo $marca['id_marca']?></td>
        <td><?php echo $marca['nome_marca']?></td>
        <td><?php echo $marca['observacao']?></td>
        <td>
            <?php 
              if($marca['status_marca'] == 1)
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
        <td><?php echo date('d/m/Y', strtotime($marca['data_cadastro']))?></td>
        <td>

          <a href="editar.php?id_marca=<?php echo $marca['id_marca'] ?>" class="btn btn-outline-success btn-sm" title="Editar"><i class="bi bi-pencil"></i></a>


          <form action="acoes.php" method="post" class="d-inline">
            <button type="submit" class="btn btn-outline-danger btn-sm" title="Excluir" value="<?php echo $marca['id_marca'] ?>" name="deletarmarca" onclick="return confirm('Tem Certeza que Deseja Excluir a marca <?php echo $marca['nome_marca'] ?>?')"><i class="bi bi-trash"></i></button>
          </form>

        </td>
      </tr>

      <?php 
        }
       }
      
      else
        {
          echo '<div class="alert alert-warning d-flex align-items-center justify-content-center" role="alert">
          Nenhum registro encontrado
        </div>
      </div>';
        }


      ?>

    </tbody>

  </table>
