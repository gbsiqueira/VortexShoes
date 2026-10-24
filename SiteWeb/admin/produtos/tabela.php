<?php

require_once __DIR__ . "/../../conexao/conecta.php";

$status = $_POST['status'];

$nome = mysqli_escape_string($conexao, $_POST['nome']);

$marca = $_POST['marca'];

$categoria = $_POST['categoria'];

$fornecedor = $_POST['fornecedor'];

$sql = "SELECT * FROM produto INNER JOIN categoria ON produto.id_categoria = categoria.id_categoria WHERE 1=1";

if ($status != '') {
  $sql .= " AND produto.status_produto = $status";
}

if (!empty($nome)) {
  $sql .= " AND produto.nome_produto LIKE '%$nome%'";
}

if (!empty($marca)) {
  $sql .= " AND id_marca = $marca";
}

if (!empty($categoria)) {
  $sql .= " AND categoria.id_categoria = $categoria";
}

if ($fornecedor != '') {
  $sql .= " AND id_fornecedor = $fornecedor";
}


$query = mysqli_query($conexao, $sql);

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
        <th>Categoria</th>
        <th>Valor</th>
        <th>Promoção</th>
        <th>Destaque</th>
        <th>Status</th>
        <th>Ações</th>
      </tr>

    </thead>
    <!-- CORPO DA TABELA: DADOS -->
    <tbody>

      <?php
      foreach ($query as $produto) {
      ?>

        <!-- LINHA DA TABELA -->
        <tr class="text-center">
          <!-- TABLE DATA: DADOS DA TABELA -->
          <td><?php echo $produto['id_produto'] ?></td>
          <td><?php echo $produto['nome_produto'] ?></td>
          <td><?php echo $produto['nome_categoria'] ?></td>
          <td><?php echo str_replace('.', ',', $produto['preco_venda']) ?></td>
          <td>
            <?php
            if ($produto['promocao'] == 1) {
              echo '<span class="badge rounded-pill text-bg-success">Ativo</span>';
            } else {
              echo '<span class="badge rounded-pill text-bg-danger">Inativo</span>';
            }
            ?>

          </td>
          <td>
            <?php
            if ($produto['status_destaque'] == 1) {
              echo '<span class="badge rounded-pill text-bg-success">Ativo</span>';
            } else {
              echo '<span class="badge rounded-pill text-white text-bg-warning">Inativo</span>';
            }
            ?>

          </td>
          <td>
            <?php
            if ($produto['status_produto'] == 1) {
              echo '<span class="badge rounded-pill text-bg-success">Ativo</span>';
            } else {
              echo '<span class="badge rounded-pill text-bg-danger">Inativo</span>';
            }
            ?>

          </td>
          <td>

            <a href="editar.php?id_produto=<?php echo $produto['id_produto'] ?>" class="btn btn-outline-success btn-sm" title="Editar"><i class="bi bi-pencil"></i></a>


          <form action="acoes.php" method="post" class="d-inline">
            <button type="submit" value="<?php echo $produto['id_produto']?>" name="deletarproduto" onclick="return confirm('Tem certeza que deseja excluir o produto <?php echo $produto['nome_produto']?>?')" class="btn btn-outline-danger btn-sm" title="Excluir"><i class="bi bi-trash"></i></button>
          </form>

          </td>
        </tr>

      <?php
      }

      ?>

    </tbody>

  </table>

<?php
} else {
  echo '<div class="alert alert-warning d-flex align-items-center justify-content-center" role="alert">
          Nenhum registro encontrado
        </div>
      </div>';
}

?>