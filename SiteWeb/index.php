<?php

require_once __DIR__ . "/conexao/conecta.php";

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


  <!-- FONT ANTON -->
  <link rel="preconnect" href="https://fonts.googleapis.com">
  <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
  <link href="https://fonts.googleapis.com/css2?family=Anton&display=swap" rel="stylesheet">


</head>

<body>

  <!-- HEADER -->

  <?php include_once __DIR__ . "/header.php" ?>


  <!-- BANNER -->
  <section class="banner">
    <div class="container-site">

      <h1 class="text-uppercase">Descubra seu proximo <br> par favorito
      </h1>
      <p>Estilo, conforto e qualidade em cada passo os melhores tênis estão aqui!</p>


      <a href="produtos.php">Ver Produtos <i class="fa-solid fa-arrow-right"></i></a>

    </div>

  </section>


  <section id="produtos-populares">

    <div class="container-site">

      <div class="caminho">

        <h2 id="vt" class="sub-titulo-section text-center">
          Produtos Mais Populares!
        </h2>

        <p class="text-center">Veja os produtos mais vendidos do site!</p>

      </div>

      <?php

      $sql = "SELECT id_produto FROM produto";

      $query = mysqli_query($conexao, $sql);

      if (mysqli_num_rows($query) > 0) {


      ?>


        <div class="cards-produtos-populares">

          <?php

          $sql = "SELECT produto.nome_produto, produto.preco_venda, produto.produto_foto1, produto.id_produto, produto.promocao, produto.preco_desconto, COUNT(itens_venda.id_produto) 'vendas' FROM produto LEFT JOIN itens_venda ON produto.id_produto = itens_venda.id_produto WHERE status_produto = 1 GROUP BY produto.id_produto ORDER BY vendas DESC";

          $query = mysqli_query($conexao, $sql);

          $produto = mysqli_fetch_assoc($query);

          foreach ($query as $produto) {

          ?>

            <div class="card-produto mb-3">

              <div class="img-card">
                <a href="produtopage.php?id=<?php echo $produto['id_produto'] ?>"> <img src="<?php echo "../imagens-produtos/" . $produto['produto_foto1'] ?>"
                    alt="<?php echo $produto['nome_produto'] ?>"></a>
              </div>

              <div class="espec-card">

                <div class="nome-preco">
                  <h5 class="nome-tenis-card mt-2">
                    <?php echo $produto['nome_produto']; ?>
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

          <?php } ?>

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



  </section>



  <section id="produtos-populares">

    <div class="container-site">

      <div class="caminho">

        <h2 id="vt" class="sub-titulo-section text-center">
          Lançamentos
        </h2>

        <p class="text-center">Veja os produtos recentemente lançados!</p>

      </div>

      <?php

      $sql = "SELECT produto.id_produto, produto.nome_produto, produto.produto_foto1, produto.preco_venda, produto.data_cadastro, produto.promocao, produto.preco_desconto FROM produto WHERE status_produto = 1 ORDER BY produto.data_cadastro DESC LIMIT 10";

      $query = mysqli_query($conexao, $sql);

      if (mysqli_num_rows($query) > 0) {

      ?>


        <div class="cards-produtos-populares">

          <?php

          foreach ($query as $produto) {



          ?>

            <div class="card-produto mb-3">

              <div class="img-card">
                <a href="produtopage.php?id=<?php echo $produto['id_produto'] ?>"><img src="<?php echo "../imagens-produtos/" . $produto['produto_foto1'] ?>"
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

      <?php
      } else {
        echo '<div class="alert alert-warning d-flex align-items-center justify-content-center" role="alert">
    Nenhum produto cadastrado
  </div>
</div>';
      }

      ?>

    </div>

  </section>




  <section id="produto-promocao" class="py-5">

    <div class="container-site">

      <h2 class="text-center sub-titulo-section text-center titulo-promocao">Produto em Destaque</h2>

      <p class="text-center mb-5">O produto em destaque do site!</p>

      <?php
      $sql = "SELECT * FROM produto WHERE status_destaque = 1 AND status_produto = 1 ORDER BY produto.data_cadastro DESC LIMIT 1";
      $query = mysqli_query($conexao, $sql);

      if (mysqli_num_rows($query) > 0) {
        $produtopromo = mysqli_fetch_assoc($query);
      ?>

        <div class="row align-items-center g-4 promocao-box">

          <!-- Imagem do produto -->
          <div class="col-lg-6 text-center">
            <img src="../imagens-produtos/<?php echo $produtopromo['produto_foto1']; ?>"
              alt="<?php echo $produtopromo['nome_produto']; ?>"
              class="img-fluid promocao-imagem-principal">
          </div>

          <!-- Informações do produto -->
          <div class="col-lg-6">

            <span class="badge-promocao mb-3">Oferta Especial</span>

            <h3 class="promocao-nome"><?php echo $produtopromo['nome_produto']; ?></h3>

            <p class="promocao-descricao">
              <?php echo $produtopromo['descricao']; ?>
            </p>

            <div class="d-flex align-items-center flex-wrap gap-3 mb-4">

              <?php if ($produtopromo['promocao'] == 1) { ?>

                <span class="promocao-preco-novo">
                  R$ <?php echo number_format($produtopromo['preco_desconto'], 2, ',', '.'); ?>
                </span>

                <span class="promocao-preco-antigo">
                  R$ <?php echo number_format($produtopromo['preco_venda'], 2, ',', '.'); ?>
                </span>

              <?php }else{ ?>

                <span class="promocao-preco-novo">
                  R$ <?php echo number_format($produtopromo['preco_venda'], 2, ',', '.'); ?>
                </span>

              <?php }?>



            </div>

            <a href="produtopage.php?id=<?php echo $produtopromo['id_produto']; ?>" class="botao-promocao">
              Ver Produto <i class="fa-solid fa-arrow-right ms-2"></i>
            </a>

          </div>

        </div>

      <?php
      } else {
      ?>

        <div class="alert alert-warning text-center" role="alert">
          Nenhum produto em destaque no momento
        </div>

      <?php
      }
      ?>

    </div>


    <section id="produtos-populares">

      <div class="container-site">

        <div class="caminho">

          <h2 id="vt" class="sub-titulo-section text-center">
            Produtos em promoção
          </h2>

          <p class="text-center">Outros produtos em promoção</p>

        </div>

        <?php

        $sql = "SELECT id_produto FROM produto WHERE promocao = 1 AND status_produto = 1 LIMIT 6";

        $query = mysqli_query($conexao, $sql);

        if (mysqli_num_rows($query) > 0) {


        ?>


          <div class="cards-produtos-populares">

            <?php

            $sql = "SELECT * FROM produto WHERE promocao = 1 AND status_produto = 1 LIMIT 6";

            $query = mysqli_query($conexao, $sql);

            $produto = mysqli_fetch_assoc($query);

            foreach ($query as $produto) {

            ?>

              <div class="card-produto mb-3">

                <div class="img-card">
                  <a href="produtopage.php?id=<?php echo $produto['id_produto'] ?>"> <img src="<?php echo "../imagens-produtos/" . $produto['produto_foto1'] ?>"
                      alt="<?php echo $produto['nome_produto'] ?>"></a>
                </div>

                <div class="espec-card">

                  <div class="nome-preco">
                    <h5 class="nome-tenis-card mt-2">
                      <?php echo $produto['nome_produto']; ?>
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

            <?php } ?>

          </div>

        <?php
        } else {
          echo '<div class="alert alert-warning d-flex align-items-center justify-content-center" role="alert">
        Nenhum produto em promoção no momento
      </div>
    </div>';
        }

        ?>

      </div>



    </section>







  </section>

  <!-- FOOTER -->
  <?php include_once __DIR__ . "/footer.php" ?>






  <!-- LINKANDO JS -->
  <script src="custom/js/javascript.js"></script>

  <script src="custom/js/carrosel.js"></script>

</body>

</html>