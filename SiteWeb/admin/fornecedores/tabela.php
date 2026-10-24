<?php 

  require_once __DIR__ . "/../../conexao/conecta.php";

  // FILTROS

  $status = $_POST['status'];
  $nome = mysqli_escape_string($conexao, $_POST['nome']);

  $sql = "SELECT * FROM fornecedor WHERE 1=1";

  if($status != '')
    {
      // .= PARA CONCATENAR
        $sql .= " AND status_fornecedor = $status";
    }

    if(!empty($nome))
      {
        // .= PARA CONCATENAR
        $sql .= " AND nome_fornecedor LIKE '%$nome%'";
      }

      $query = mysqli_query($conexao, $sql);

      // se tiver uma linha ou mais
          if (mysqli_num_rows($query) > 0) {
  
?>

<table class="table table-striped table-dark">

                <!-- CABEÇALHO DA TABELA -->
                <thead class="table-dark">
                  <!-- TABLE ROW: LINHA DA TABELA -->
                  <tr class="text-center">
                    <!-- TABLE HEAD: TITULO DA COLUNA -->
                    <th>ID</th>
                    <th>Nome</th>
                    <th>Observação</th>
                    <th>Status</th>
                    <th>Data Cadastro</th>
                    <th>Ações</th>
                  </tr>

                </thead>
                <!-- CORPO DA TABELA: DADOS -->
                <tbody>

                  <?php
                    foreach($query as $fornecedor)
                    {
                  ?>

                  <!-- LINHA DA TABELA -->
                  <tr class="text-center">
                    <!-- TABLE DATA: DADOS DA TABELA -->
                    <td><?php echo $fornecedor['id_fornecedor']?></td>
                    <td><?php echo $fornecedor['nome_fornecedor']?></td>
                    <td><?php echo $fornecedor['observacao']?></td>
                    <td>
                        <?php 
                          if($fornecedor['status_fornecedor'] == 1)
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
                    <td><?php echo date('d/m/Y', strtotime($fornecedor['data_cadastro']))?></td>
                    <td>

                      <a href="editar.php?id_fornecedor=<?php echo $fornecedor['id_fornecedor'] ?>" class="btn btn-outline-success btn-sm" title="Editar"><i class="bi bi-pencil"></i></a>

                      <form action="acoes.php" method="post" class="d-inline">
                        <button type="submit" value="<?php echo $fornecedor['id_fornecedor']?>" name="deletarfornecedor" onclick="return confirm('Tem certeza que deseja excluir o fornecedor(a) <?php echo $fornecedor['nome_fornecedor']?>?')" class="btn btn-outline-danger btn-sm" title="Excluir"><i class="bi bi-trash"></i></button>
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
          // se nao
          else {
              echo '<div class="alert alert-warning d-flex align-items-center justify-content-center" role="alert">
    Nenhum registro encontrado
  </div>
</div>';
          }
          ?>