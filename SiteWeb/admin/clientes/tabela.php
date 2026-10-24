<?php 

require_once __DIR__ . "/../../conexao/conecta.php";

$status = $_POST['status'];

$cidade = $_POST['cidade'];

$sexo = $_POST['sexo'];

$cpf = mysqli_escape_string($conexao, $_POST['cpf']);

$nome = mysqli_escape_string($conexao, $_POST['nome']);


$sql = "SELECT cliente.id_cliente, if(cliente.nome_social != '' AND cliente.nome_social IS NOT NULL, cliente.nome_social, cliente.nome_cliente) 'nome', cliente.cpf_cliente, cliente.data_nascimento_cliente, cliente.status_cliente,  GROUP_CONCAT( DISTINCT endereco.cidade SEPARATOR ', ') AS cidades
FROM cliente 
INNER JOIN endereco 
ON cliente.id_cliente = endereco.id_cliente 
WHERE 1=1";

if($status != '')
  {
    $sql .= " AND status_cliente = $status";
  }

  if($sexo != '')
    {
      $sql .= " AND sexo_cliente = '$sexo'";
    }

    if($nome != '')
      {
          $sql .= " AND IF(cliente.nome_social IS NOT NULL AND cliente.nome_social != '', cliente.nome_social, cliente.nome_cliente) LIKE '%$nome%'";
      }

      if($cpf != '')
        {
            $sql .= " AND cpf_cliente LIKE '$cpf%'";
        }
      
        if($cidade != '')
          {
              $sql .= " AND endereco.cidade = '$cidade'";
          }

          $sql .= " GROUP BY cliente.id_cliente";

        

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
                    <th>Nome</th>
                    <th>CPF</th>
                    <th>Cidade</th>
                    <th>Data Nascimento</th>
                    <th>Status</th>
                    <th>Ações</th>
                  </tr>

                </thead>
                <!-- CORPO DA TABELA: DADOS -->
                <tbody>

                  <?php
                    foreach($query as $cliente)
                    {
                  ?>

                  <!-- LINHA DA TABELA -->
                  <tr class="text-center">
                    <!-- TABLE DATA: DADOS DA TABELA -->
                    <td><?php echo $cliente['id_cliente']?></td>
                    <td><?php echo $cliente['nome']?></td>
                    <td><?php echo $cliente['cpf_cliente']?></td>
                    <td><?php echo $cliente['cidades']?></td>
                    <td><?php echo date('d/m/Y', strtotime($cliente['data_nascimento_cliente']))?></td>
                    <td>
                        <?php 
                          if($cliente['status_cliente'] == 1)
                            {
                              echo '<span class="badge rounded-pill text-bg-success">Ativo</span>';
                            }
                            else
                              {
                                  echo '<span class="badge rounded-pill text-bg-danger">Inativo</span>';
                              }
                        ?>

                    </td>
                    <td>

                      <a href="editar.php?id_cliente=<?php echo $cliente['id_cliente'] ?>" class="btn btn-outline-success btn-sm" title="Editar"><i class="bi bi-pencil"></i></a>

                      <form action="acoes.php" method="post" class="d-inline">

                      <button type="submit" class="btn btn-outline-danger btn-sm" title="Excluir" name="deletarcliente" value="<?php echo $cliente['id_cliente'] ?>" onclick="return confirm('Tem certeza que deseja excluir o cliente <?php echo $cliente['nome_cliente']?>?')"><i class="bi bi-trash"></i></button>
      
                      </form>

                    </td>
                  </tr>

                  <?php 
                    }

                  ?>

                </tbody>

              </table>

<?php 
}
else
  {
             echo '<div class="alert alert-warning d-flex align-items-center justify-content-center" role="alert">
    Nenhum registro encontrado
  </div>
</div>';
  }

?>

