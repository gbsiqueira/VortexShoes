<?php 

// O dir e para meio que retornar onde o arquivo esta dentro, require once ele tenta a conexão apenas uma vez
  require_once __DIR__ . "/../../conexao/conecta.php";

  if(!isset($_SESSION))
    {
        session_start();
    }


    // FILTROS
    $sexo = $_POST['sexo'];
    $status = $_POST['status'];
    $cargo = $_POST['cargo'];
    $cidade = $_POST['cidade'];
    $nome = mysqli_escape_string($conexao, $_POST['nome']);

    //CAMPO DE BUSCA
      
// CODIGO SQL
$sql = "SELECT funcionario.id_funcionario, funcionario.foto, IF(funcionario.nome_social != '' AND funcionario.nome_social IS NOT NULL, funcionario.nome_social, funcionario.nome) 'nome', funcionario.nome_social, cargo.nome 'cargo', funcionario.data_cadastro, funcionario.status
FROM funcionario 
INNER JOIN cargo ON cargo.id_cargo = funcionario.id_cargo 
WHERE 1=1";

// filtro por sexo, !empty se for diferente de vazio no php no caso de string, .= concatenando e atribuindo entao ele nao vai sobrepor ela e sim apenas adicionar mais coisas, TEM QUE DEIXAR O ESPAÇO DENTRO DAS ASPAS DUPLAS " "
if(!empty($sexo))
{
  $sql .= " AND funcionario.sexo = '$sexo'";
}

// se for diferente de vazio agora ja que e bit
  if($status != '')
    {
      $sql .= " AND funcionario.status = $status";
    }

  if($cargo != '')
    {
        $sql .= " AND funcionario.id_cargo = $cargo";
    }

  if(!empty($cidade))
    {
      $sql .= " AND funcionario.cidade = '$cidade'";
    }

    if(!empty($nome))
      {
          $sql .= " AND IF(funcionario.nome_social IS NOT NULL AND funcionario.nome_social != '', funcionario.nome_social, funcionario.nome) LIKE '%$nome%'";
      }


// A FUNÇÃO DO MYSQL_QUERY REALIZA A CONEXÃO COM O BANCO DE DADOS E EXECUTA O COMANDO SQL
$query = mysqli_query($conexao, $sql);

if(mysqli_num_rows($query) > 0)
{


?>
 
 
 <!-- PARA ATUALIZAR APENAS UMA PARTE DO SITE QUE NO CASO SERIA A TABELA CRIA UM NIOVO ARQUIVO E COLA A TABLE INTEIRA AQUI -->
 
 <table class="table table-striped table-dark">

              <!-- CABEÇALHO DA TABELA -->
              <thead class="table-dark">
                <!-- TABLE ROW: LINHA DA TABELA -->
                <tr class="text-center">
                  <!-- TABLE HEAD: TITULO DA COLUNA -->
                  <th>ID</th>
                  <th>Foto</th>
                  <th>Nome</th>
                  <th>Cargo</th>
                  <th>Data Cadastro</th>
                  <th>Status</th>
                  <?php if($_SESSION['TYPE'] == '1')
                    {
                      ?>
                  <th>Ações</th>
                  <?php 

                  }

                  ?>
                </tr>

              </thead>
              <!-- CORPO DA TABELA: DADOS -->
              <tbody>

                <?php 
                foreach($query as $funcionario)
                  {

                  
                ?>
              
                <!-- LINHA DA TABELA -->
                <tr class="text-center">
                  <!-- TABLE DATA: DADOS DA TABELA -->
                  <td><?php echo $funcionario['id_funcionario']?></td>

                  <td>
                    <?php 

                  if($funcionario['foto'] != '')
                    {
                      echo '<img src="../../../images-funcionarios/'. $funcionario['foto'] .'" alt="'. $funcionario['nome'] .'" class="img-funcionario">';
                    }
                  else
                    {
                      echo '<img src="../../assets/img/placeholder-funcionario.png" alt="'. $funcionario['nome'] .'" class="img-funcionario">';
                    }
                    ?>
                  </td>

                  <td><?php echo $funcionario['nome']?></td>

                  <!-- APELIDO PRO NOME CARGO -->
                  <td><?php echo $funcionario['cargo']?></td>
                  <td><?php echo date('d/m/Y', strtotime($funcionario['data_cadastro']))?></td>
                  <td><?php
                    if($funcionario['status'] == 1)
                            {
                              echo '<span class="badge rounded-pill text-bg-success">Ativo</span>';
                            }
                            else
                              {
                                  echo '<span class="badge rounded-pill text-bg-danger">Inativo</span>';
                              }
                       ?>
                  </td>
                  <?php 
                  if($_SESSION['TYPE'] == '1')
                    {
                      
                      ?>
                  <td>

                    <a href="editar.php?id_funcionario=<?php echo $funcionario['id_funcionario']?>" class="btn btn-outline-success btn-sm" title="Editar"><i class="bi bi-pencil"></i></a>

                    <form action="acoes.php" method="post" class="d-inline">
                      <button type="submit" class="btn btn-outline-danger btn-sm" title="Excluir" name="deletarfuncionario" value="<?php echo $funcionario['id_funcionario'] ?>" onclick="return confirm('Tem certeza que deseja excluir o funcionário(a) <?php echo $funcionario['nome']?> ?')"><i class="bi bi-trash"></i></button>
                    </form>
                  

                  </td>
                  <?php 
                  }
                  ?>
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
            
