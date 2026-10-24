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

<body id="produtospage">



    <!-- INCIO CABEÇALHO -->

    <?php include_once __DIR__ . "/header.php" ?>

    <section id="produto">

        <div class="container">

            <?php

            if (isset($_GET['id']) && $_GET['id'] != '') {

                $id = $_GET['id'];

                $sql = "SELECT * FROM produto WHERE id_produto = ? ";

                $stmt = mysqli_prepare($conexao, $sql);

                mysqli_stmt_bind_param($stmt, "i", $id);

                mysqli_stmt_execute($stmt);

                $result = mysqli_stmt_get_result($stmt);

                $produto = mysqli_fetch_assoc($result);

                $marca = $produto['id_marca'];

                if (mysqli_num_rows($result) > 0) {


            ?>

                    <div class="container-site">

                        <div id="carouselExampleFade" class="carousel slide carousel-fade imagem-maior-div mb-3 mb-md-0">
                            <div class="carousel-inner">
                                <div class="carousel-item active">
                                    <img src="<?php echo "../imagens-produtos/" . $produto['produto_foto1'] ?>" class="d-block w-100" alt="<?php echo $produto['nome_produto'] ?>">
                                </div>

                                <?php
                                if ($produto['produto_foto2'] != '' && $produto['produto_foto2'] != null) {
                                    echo '<div class="carousel-item">
                <img src="../imagens-produtos/' . $produto['produto_foto2'] . '" class="d-block w-100" alt="...">
                </div>';
                                }

                                ?>

                                <?php
                                if ($produto['produto_foto3'] != '' && $produto['produto_foto3'] != null) {
                                    echo '<div class="carousel-item">
                <img src="../imagens-produtos/' . $produto['produto_foto3'] . '" class="d-block w-100" alt="...">
                </div>';
                                }

                                ?>

                                <?php
                                if ($produto['produto_foto4'] != '' && $produto['produto_foto4'] != null) {
                                    echo '<div class="carousel-item">
                <img src="../imagens-produtos/' . $produto['produto_foto4'] . '" class="d-block w-100" alt="...">
                </div>';
                                }

                                ?>

                            </div>
                            <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleFade" data-bs-slide="prev">
                                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                                <span class="visually-hidden">Previous</span>
                            </button>
                            <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleFade" data-bs-slide="next">
                                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                                <span class="visually-hidden">Next</span>
                            </button>
                        </div>



                        <div class="info-produto-div text-md-start">
                            <h3 id="Nometenisproduto"><?php echo $produto['nome_produto'] ?></h3>
                            <h3 id="valortenisproduto">
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
                            </h3>

                            <div class="tamanho text-center text-lg-start">

                                <h5 class="mt-3 mt-md-4 text-md-start">Tamanho</h5>

                                <div class="tamanhos justify-content-md-start m-md-0">

                                    <span class="tamanhospan"><?php echo $produto['tamanho']; ?></span>

                                </div>

                            </div>

                            <div class="botoes-produto">

                                <div class="botao justify-content-md-start">
                                    <a href="#"><?php if ($produto['status_produto'] == 1) {
                                                    echo "Adicionar ao carrinho";
                                                } else {
                                                    echo "Produto Indisponível";
                                                } ?></a>
                                </div>

                                <div class="botao justify-content-md-start">
                                    <a href="#">Adicionar aos Favoritos</a>
                                </div>

                            </div>


                            <div class="especificacoes-prod text-center text-md-start mt-4">

                                <h4>Descrição</h4>

                                <p><?php echo $produto['descricao'] ?></p>

                            </div>



                        </div>




                    </div>

                <?php
                } else {
                    echo '<div class="alert alert-warning d-flex align-items-center justify-content-center" role="alert">
    produto não encontrado
  </div>
</div>';
                } ?>

            <?php
            } else {
                echo '<div class="alert alert-warning d-flex align-items-center justify-content-center" role="alert">
    produto não encontrado
  </div>
</div>';
            }

            ?>

            <div class="caminho mb-5">

                <h2 id="vt" class="sub-titulo-section">
                    Produtos Relacionados
                </h2>

                <p class="text-lg-start">Você também pode gostar de...</p>

            </div>

            <?php

            $sql = "SELECT produto.id_produto, produto.nome_produto, produto.produto_foto1, produto.preco_venda, produto.data_cadastro, produto.promocao, produto.preco_desconto FROM produto WHERE status_produto = 1 AND produto.id_produto != $id AND produto.id_marca = $marca GROUP BY produto.id_produto DESC LIMIT 6";

            

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

                                    <h5 class="nome-tenis-card">
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
    Nenhum produto encontrado
  </div>
</div>';
            }

            ?>







        </div>




        </div>



    </section>





    <!-- FOOTER -->
    <?php include_once __DIR__ . "/footer.php" ?>



    <!-- LINKANDO JS -->
    <script src="custom/js/javascript.js"></script>

    <script src="custom/js/carrosel.js"></script>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>

    


</body>


</html>