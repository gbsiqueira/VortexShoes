<?php 

require_once __DIR__ . "/../../conexao/conecta.php";

$status = $_POST['status'];

$nome = mysqli_escape_string($conexao, $_POST['nome']);

$sql = "SELECT * FROM categoria WHERE 1=1";

if($status != '')
  {
    $sql .= " AND status_categoria = $status";
  }

  if(!empty($nome))
    {
      $sql .= " AND nome_categoria LIKE '%$nome%'";
    }
  

   $query = mysqli_query($conexao, $sql);


   if(mysqli_num_rows($query) > 0)
    {

?>
 
 
 
      <table class=" table table-striped table-dark">

                <!-- CABEÇALHO DA TABELA -->
                <thead class="table-dark ">
                  <!-- TABLE ROW: LINHA DA TABELA -->
                  <tr class="text-center">
                    <!-- TABLE HEAD: TITULO DA COLUNA -->
                    <th>ID</th>
                    <th>Categoria</th>
                    <th>Observação</th>
                    <th>Status</th>
                    <th>Data Cadastro</th>
                    <th>Ações</th>
                  </tr>

                </thead>
                <!-- CORPO DA TABELA: DADOS -->
                <tbody>

                  <?php
                    foreach($query as $categoria)
                    {
                  ?>

                  <!-- LINHA DA TABELA -->
                  <tr class="text-center">
                    <!-- TABLE DATA: DADOS DA TABELA -->
                    <td><?php echo $categoria['id_categoria']?></td>
                    <td><?php echo $categoria['nome_categoria']?></td>
                    <td><?php echo $categoria['observacao']?></td>
                    <td>
                        <?php 
                          if($categoria['status_categoria'] == 1)
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
                    <td><?php echo date('d/m/Y', strtotime($categoria['data_cadastro']))?></td>
                    <td>

                      <a href="editar.php?id_categoria=<?php echo $categoria['id_categoria']?>" class="btn btn-outline-success btn-sm" title="Editar"><i class="bi bi-pencil"></i></a>

                      
                      <form action="acoes.php" method="post" class="d-inline">

                        <button type="submit" class="btn btn-outline-danger btn-sm" title="Excluir" name="deletarcategoria" value="<?php echo $categoria['id_categoria'] ?>"><i class="bi bi-trash" onclick="return confirm('Tem certeza que deseja excluir a categoria <?php echo $categoria['nome_categoria']?>?')"></i></button>

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