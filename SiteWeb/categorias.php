<?php

require_once __DIR__ . "/conexao/conecta.php";

$id_categoria = (isset($_GET['id_categoria']) && $_GET['id_categoria'] != '') ? (int) $_GET['id_categoria'] : 0;


$pgnqtd = 12;

$paginaatual = isset($_GET['pagina']) ? (int) $_GET['pagina'] : 1;

if ($paginaatual < 1) {
  $paginaatual = 1;
}

if ($id_categoria > 0) {

  $sql_count = "SELECT COUNT(*) AS total FROM produto WHERE produto.id_categoria = $id_categoria AND status_produto = 1";

  $query_count = mysqli_query($conexao, $sql_count);
  $result_count = mysqli_fetch_assoc($query_count);

  $quantidade = $result_count['total'];

  $paginafinal = ceil($quantidade / $pgnqtd);

  if ($paginaatual > $paginafinal && $paginafinal > 0) {
    $paginaatual = $paginafinal;
  }
} else {
  $paginafinal = 0;
}

$valorinicial = ($paginaatual - 1) * $pgnqtd;
?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>VortexShoes</title>

  <!-- favicon -->
  <link rel="icon" type="image/jpg" href="assets/img/favicon.jpg">

  <!-- CSS  -->
  <link rel="stylesheet" href="custom/css/style.css">

  <!-- FontAwesome (Icones) -->
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/7.0.1/css/all.min.css"
    integrity="sha512-2SwdPD6INVrV/lHTZbO2nodKhrnDdJK9/kg2XD1r9uGqPo1cUbujc+IYdlYdEErWNu69gVcYgdxlmVmzTWnetw=="
    crossorigin="anonymous" referrerpolicy="no-referrer" />


  <!-- POPPINS FONT -->
  <link rel="preconnect" href="https://fonts.googleapis.com">
  <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
  <link
    href="https://fonts.googleapis.com/css2?family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap"
    rel="stylesheet">

  <!-- INTER FONT -->
  <link rel="preconnect" href="https://fonts.googleapis.com">
  <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
  <link
    href="https://fonts.googleapis.com/css2?family=Inter:ital,opsz,wght@0,14..32,100..900;1,14..32,100..900&family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap"
    rel="stylesheet">

  <!-- bootstrap -->
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet"
    integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">

  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.13.1/font/bootstrap-icons.min.css">



  <!-- FONT ANTON -->
  <link rel="preconnect" href="https://fonts.googleapis.com">
  <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
  <link href="https://fonts.googleapis.com/css2?family=Anton&display=swap" rel="stylesheet">


</head>

<body id="produtospage">



  <!-- INCIO CABEÇALHO -->

  <?php include_once __DIR__ . "/header.php" ?>

  <section id="produtos-lista">

    <?php

    if ($id_categoria > 0) {




    ?>



      <div class="container mt-3">

        <p class="caminhopage"><a href="index.php">Home</a>><a href="produtos.php">Produtos</a></p>
        <a class="produtoscaminho" href="produtos.php">Produtos</a>

        <?php

        // CORRIGIDO: id_categoria agora é inteiro validado, evitando SQL quebrado/injeção
        $sql = "SELECT produto.id_produto, produto.produto_foto1, produto.nome_produto, produto.preco_venda, produto.promocao, produto.preco_desconto FROM produto INNER JOIN categoria ON produto.id_categoria = categoria.id_categoria WHERE status_produto = 1 AND categoria.id_categoria = $id_categoria LIMIT $valorinicial, $pgnqtd";

        $query = mysqli_query($conexao, $sql);

        if (mysqli_num_rows($query) > 0) {

        ?>

          <div class="container-site">



            <?php

            foreach ($query as $produto) {

            ?>

              <div class="card-produto mt-2">

                <div class="img-card">
                  <a href="produtopage.php?id=<?php echo $produto['id_produto'] ?>"> <img src="<?php echo "../imagens-produtos/" . $produto['produto_foto1'] ?>"
                      alt="<?php echo $produto['nome_produto'] ?>"></a>
                </div>

                <div class="espec-card">

                  <div class="nome-preco">

                    <h5 class="nome-tenis-card mt-2">
                      <?php echo $produto['nome_produto'] ?>
                    </h5>

                    <p class="preco-tenis-card">
                      <?php
                      if ($produto['promocao'] == 0) {
                        // Formata o preço de venda normal
                        echo "R$ " . number_format($produto['preco_venda'], 2, ',', '.');
                      } else {
                        // Formata o preço com desconto
                        echo "R$ " . number_format($produto['preco_desconto'], 2, ',', '.');
                        echo '<br>';
                        // Formata o preço antigo riscado
                        echo '<span class="text-decoration-line-through text-secondary">R$ ' . number_format($produto['preco_venda'], 2, ',', '.') . '</span> ';
                      }
                      ?>
                    </p>



                  </div>

                  <div class="botao-card">
                    <a href="produtopage.php?id=<?php echo $produto['id_produto'] ?>"><i class="fa-solid fa-circle-arrow-right"></i></a>
                  </div>

                </div>

              </div>

            <?php

            }

            ?>





          </div>




          <!-- PAGINAÇÃO -->
          <div class="col-12 mt-5">
            <?php if ($paginafinal > 1) { ?>
              <nav>
                <ul class="pagination justify-content-center">

                  <?php if ($paginaatual > 1) { ?>
                    <li class="page-item">
                      <!-- CORRIGIDO: mantém id_categoria ao trocar de página -->
                      <a href="?id_categoria=<?php echo $id_categoria ?>&pagina=<?php echo $paginaatual - 1 ?>" class="page-link"><i class="bi bi-arrow-left"></i></a>
                    </li>

                  <?php  }
                  for ($i = 1; $i <= $paginafinal; $i++) { ?>

                    <li class="page-item">
                      <a href="?id_categoria=<?php echo $id_categoria ?>&pagina=<?php echo $i ?>" class="page-link"><?php echo $i ?></a>
                    </li>

                  <?php }
                  if ($paginaatual < $paginafinal) { ?>
                    <li class="page-item">
                      <a href="?id_categoria=<?php echo $id_categoria ?>&pagina=<?php echo $paginaatual + 1 ?>" class="page-link"><i class="bi bi-arrow-right"></i></a>
                    </li>
                  <?php  } ?>

                </ul>
              </nav>
            <?php  } ?>
          </div>






      </div>

    <?php
        } else {
          echo '<div class="alert alert-warning d-flex align-items-center justify-content-center" role="alert">
    Nenhum produto cadastrado
  </div>
</div>';
        }
    ?>

    </div>

  <?php

    } else {
      echo '<div class="alert alert-warning d-flex align-items-center justify-content-center" role="alert">
    Nenhuma categoria Encontrada
  </div>
</div>';
    }

  ?>



  </section>


  <?php include_once __DIR__ . "/footer.php" ?>



  <!-- LINKANDO JS -->
  <script src="custom/js/javascript.js"></script>




</body>


</html>