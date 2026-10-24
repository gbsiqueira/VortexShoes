  <?php

  // CONEXÃO COM O BANCO
  require_once __DIR__ . "../../../conexao/conecta.php";

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
    <link rel="stylesheet" href="../../custom/css/style.css">

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
          include('../Log.php');
          include('../mensagem.php'); //Adicionando a mensagem
          ?>

          <?php
          if (isset($_GET['id_produto']) && $_GET['id_produto'] != '') {
            $id_produto = $_GET['id_produto'];

            $sql = "SELECT * FROM produto WHERE id_produto = $id_produto";

            $query = mysqli_query($conexao, $sql);

            $produto = mysqli_fetch_assoc($query);


          ?>

            <div class="card bg-dark text-white">

              <div class="card-header d-flex justify-content-between">
                <h4 class="m-0">Editar Produto</h4>

                <a href="Index.php" class="btn btn-primary btn-sm">
                  <i class="bi bi-arrow-left-short"></i>

                  Voltar
                </a>

              </div>


              <div class="card-body">

                <!-- ENCTYPE E PARA TRABALHAR COM ENVIO DE ARQUIVOS -->
                <form action="acoes.php" method="post" enctype="multipart/form-data" id="formProduto">
                  <div class="row g-4">

                    <!-- COLUNA DAS IMAGENS (MANTIDA COMO ESTAVA) -->
                    <div class="col-12 col-lg-4 order-lg-2">
                      <div class="upload-imagem card bg-dark text-white p-4">

                        <!-- IMAGEM PRINCIPAL -->
                        <h5 class="pb-1"><strong class="text-danger fs-5">*</strong> Imagem Principal</h5>

                        <label for="foto_produto">
                          <?php if (!empty($produto['produto_foto1'])): ?>
                            <img src="../../../imagens-produtos/<?php echo $produto['produto_foto1']; ?>" alt="Imagem Principal" class="img-preview">
                          <?php else: ?>
                            <i class="bi bi-cloud-arrow-up"></i>
                            <strong>Clique para adicionar uma nova imagem</strong>
                            <span>PNG, JPG ou WEBP</span>
                          <?php endif; ?>
                        </label>

                        <input type="file" id="foto_produto" name="foto_produto" accept="image/png, image/jpeg, image/webp">


                        <!-- IMAGENS ADICIONAIS -->
                        <h5 class="pt-4">Imagens Adicionais (máx.3)</h5>

                        <div class="imagens-extras d-flex justify-content-around">

                          <!-- FOTO EXTRA 2 -->
                          <div class="imagem-extra mt-3">
                            <label for="foto_produto2" class="d-flex justify-content-center align-items-center">
                              <?php if (!empty($produto['produto_foto2'])): ?>
                                <img src="../../../imagens-produtos/<?php echo $produto['produto_foto2']; ?>" alt="Foto 2" class="img-preview-extra">
                              <?php else: ?>
                                <i class="bi bi-plus"></i>
                              <?php endif; ?>
                            </label>
                          </div>
                          <input type="file" id="foto_produto2" name="foto_produto2" accept="image/png, image/jpeg, image/webp">

                          <!-- FOTO EXTRA 3 -->
                          <div class="imagem-extra mt-3">
                            <label for="foto_produto3" class="d-flex justify-content-center align-items-center">
                              <?php if (!empty($produto['produto_foto3'])): ?>
                                <img src="../../../imagens-produtos/<?php echo $produto['produto_foto3']; ?>" alt="Foto 3" class="img-preview-extra">
                              <?php else: ?>
                                <i class="bi bi-plus"></i>
                              <?php endif; ?>
                            </label>
                          </div>
                          <input type="file" id="foto_produto3" name="foto_produto3" accept="image/png, image/jpeg, image/webp">

                          <!-- FOTO EXTRA 4 -->
                          <div class="imagem-extra mt-3">
                            <label for="foto_produto4" class="d-flex justify-content-center align-items-center">
                              <?php if (!empty($produto['produto_foto4'])): ?>
                                <img src="../../../imagens-produtos/<?php echo $produto['produto_foto4']; ?>" alt="Foto 4" class="img-preview-extra">
                              <?php else: ?>
                                <i class="bi bi-plus"></i>
                              <?php endif; ?>
                            </label>
                          </div>
                          <input type="file" id="foto_produto4" name="foto_produto4" accept="image/png, image/jpeg, image/webp">

                        </div>

                        <!-- MENSAGEM INFORMATIVA -->
                        <div class="mensagem-imagens card d-flex flex-row pt-2 mt-5 justify-content-around text-dark">
                          <i class="bi bi-info-circle fs-5"></i>
                          <p class="col-10 mb-0">Se não selecionar nenhuma nova imagem, a imagem atual será mantida.</p>
                        </div>

                      </div>
                    </div>

                    <!-- COLUNA DOS DADOS -->
                    <div class="col-12 col-lg-8 order-lg-1">
                      <div class="d-flex flex-column gap-4">

                        <!-- INFORMAÇÕES DO PRODUTO -->
                        <div class="card text-bg-dark">
                          <div class="card-header fw-semibold">
                            Informações do Produto
                          </div>
                          <div class="card-body">
                            <div class="row g-3">

                              <div class="col-md-8">
                                <!-- FOR TEM QUE SER IGUAL O ID -->
                                <label for="nome" class="form-label"><strong class="text-danger">*</strong> Nome</label>
                                <!-- MAXLENGHT 60 CARACTERES, REQUIRED CAMPO ORIGATÓRIO -->
                                <input type="text" name="nome" id="nome" class="form-control" maxlength="50" required placeholder="Digite o nome do produto" value="<?php echo $produto['nome_produto'] ?>">
                              </div>

                              <div class="col-md-2">
                                <label for="status" class="form-label">Status</label>
                                <select name="status" id="status" class="form-select">
                                  <option value="1" <?php if ($produto['status_produto'] == 1) echo 'selected' ?>>Ativo</option>
                                  <option value="0" <?php if ($produto['status_produto'] == 0) echo 'selected' ?>>Inativo</option>
                                </select>
                              </div>

                              <div class="col-md-2">
                                <label for="datacadastro" class="form-label">Data de cadastro</label>
                                <input type="date" name="datacadastro" id="datacadastro" class="form-control" required disabled value="<?php echo date('Y-m-d', strtotime($produto['data_cadastro'])) ?>">
                              </div>

                              <div class="col-md-4">
                                <label for="fornecedor" class="form-label"><strong class="text-danger">*</strong> Fornecedor</label>
                                <select name="fornecedor" id="fornecedor" class="form-select" required>
                                  <option value="">Selecionar</option>

                                  <?php

                                  $sql_fornecedor = "SELECT * FROM fornecedor WHERE status_fornecedor = 1;";

                                  $query_fornecedor = mysqli_query($conexao, $sql_fornecedor);

                                  foreach ($query_fornecedor as $fornecedor) {
                                  ?>
                                    <option value="<?php echo $fornecedor['id_fornecedor'] ?>"
                                      <?php if ($produto['id_fornecedor'] == $fornecedor['id_fornecedor']) echo 'selected' ?>>
                                      <?php echo $fornecedor['nome_fornecedor'] ?>
                                    </option>

                                  <?php
                                  }
                                  ?>

                                </select>
                              </div>

                              <div class="col-md-4">
                                <label for="categoria" class="form-label"><strong class="text-danger">*</strong> Categoria</label>
                                <select name="categoria" id="categoria" class="form-select" required>
                                  <option value="">Selecionar</option>

                                  <?php

                                  $sql_categoria = "SELECT * FROM categoria WHERE status_categoria = 1;";

                                  $query_categoria = mysqli_query($conexao, $sql_categoria);

                                  foreach ($query_categoria as $categoria) {
                                  ?>
                                    <option value="<?php echo $categoria['id_categoria'] ?>"
                                      <?php if ($produto['id_categoria'] == $categoria['id_categoria']) echo 'selected' ?>>
                                      <?php echo $categoria['nome_categoria'] ?>
                                    </option>

                                  <?php
                                  }
                                  ?>

                                </select>
                              </div>

                              <div class="col-md-4">
                                <label for="marca" class="form-label"><strong class="text-danger">*</strong> Marca</label>
                                <select name="marca" id="marca" class="form-select" required>
                                  <option value="">Selecionar</option>

                                  <?php

                                  $sql_marca = "SELECT * FROM marca WHERE status_marca = 1;";

                                  $query_marca = mysqli_query($conexao, $sql_marca);

                                  foreach ($query_marca as $marca) {
                                  ?>
                                    <option value="<?php echo $marca['id_marca'] ?>"
                                      <?php if ($produto['id_marca'] == $marca['id_marca']) echo 'selected' ?>>
                                      <?php echo $marca['nome_marca'] ?>
                                    </option>

                                  <?php
                                  }
                                  ?>

                                </select>
                              </div>

                              <div class="col-md-4">
                                <label for="cor" class="form-label"><strong class="text-danger">*</strong> Cor</label>
                                <select name="cor" id="cor" class="form-select" required>
                                  <option value="">Cor</option>
                                  <option value="Amarelo" <?php if ($produto['cor'] == 'Amarelo') echo 'selected' ?>>Amarelo</option>
                                  <option value="Azul" <?php if ($produto['cor'] == 'Azul') echo 'selected' ?>>Azul</option>
                                  <option value="Bege" <?php if ($produto['cor'] == 'Bege') echo 'selected' ?>>Bege</option>
                                  <option value="Branco" <?php if ($produto['cor'] == 'Branco') echo 'selected' ?>>Branco</option>
                                  <option value="Cinza" <?php if ($produto['cor'] == 'Cinza') echo 'selected' ?>>Cinza</option>
                                  <option value="Laranja" <?php if ($produto['cor'] == 'Laranja') echo 'selected' ?>>Laranja</option>
                                  <option value="Marrom" <?php if ($produto['cor'] == 'Marrom') echo 'selected' ?>>Marrom</option>
                                  <option value="Preto" <?php if ($produto['cor'] == 'Preto') echo 'selected' ?>>Preto</option>
                                  <option value="Rosa" <?php if ($produto['cor'] == 'Rosa') echo 'selected' ?>>Rosa</option>
                                  <option value="Roxo" <?php if ($produto['cor'] == 'Roxo') echo 'selected' ?>>Roxo</option>
                                  <option value="Verde" <?php if ($produto['cor'] == 'Verde') echo 'selected' ?>>Verde</option>
                                  <option value="Vermelho" <?php if ($produto['cor'] == 'Vermelho') echo 'selected' ?>>Vermelho</option>
                                </select>
                              </div>

                              <div class="col-md-4">
                                <label for="tamanho" class="form-label"><strong class="text-danger">*</strong> Tamanho</label>
                                <input type="text" name="tamanho" id="tamanho" class="form-control" placeholder="Ex: 38, 39, 40, 41 ou P, M, G" required value="<?php echo $produto['tamanho'] ?>">
                              </div>

                              <div class="col-md-4">
                              <label for="estoque" class="form-label"><strong class="text-danger">*</strong> Estoque</label>
                              <input type="number" name="estoque" id="estoque" class="form-control" required value="<?php  echo $produto['estoque']?>">
                            </div>

                              <div class="col-md-3">
                              <label for="destaque" class="form-label">Produto em Destaque</label>
                              <select name="destaque" id="destaque" class="form-select" required>
                                <option value="0" <?php if($produto['status_destaque'] == 0) echo 'selected' ?>>Inativo</option>
                                <option value="1" <?php if($produto['status_destaque'] == 1) echo 'selected' ?>>Ativo</option>
                              </select>
                            </div>


                              <div class="col-12">
                                <label for="descricao" class="form-label">Descrição</label>
                                <!-- CAMPO DE TEXTO MAIOR -->
                                <textarea name="descricao" id="descricao" class="form-control" maxlength="1000" rows="3"><?php echo $produto['descricao'] ?></textarea>
                              </div>

                            </div>
                          </div>
                        </div>

                        <!-- PREÇO E PROMOÇÃO -->
                        <div class="card text-bg-dark">
                          <div class="card-header fw-semibold">
                            Preço e Promoção
                          </div>
                          <div class="card-body">
                            <div class="row g-3">

                              <div class="col-md-4">
                                <!-- FOR TEM QUE SER IGUAL O ID -->
                                <label for="custo_produto" class="form-label"><strong class="text-danger">*</strong> Custo do produto</label>
                                <input type="text" name="custo_produto" id="custo_produto" class="form-control" required data-mask="00000,00" data-mask-reverse="true" value="<?php echo $produto['preco_custo'] ?>">
                              </div>

                              <div class="col-md-4">
                                <!-- FOR TEM QUE SER IGUAL O ID -->
                                <label for="lucro" class="form-label">Lucro %</label>
                                <input type="text" name="lucro" id="lucro" class="form-control" data-mask="000,00" data-mask-reverse="true" value="<?php echo $produto['lucro'] ?>">
                              </div>

                              <div class="col-md-4">
                                <!-- FOR TEM QUE SER IGUAL O ID -->
                                <label for="valor_produto" class="form-label"><strong class="text-danger">*</strong> Valor Produto</label>
                                <input type="text" name="valor_produto" id="valor_produto" class="form-control" value="<?php echo $produto['preco_venda'] ?>">
                              </div>

                              <div class="col-md-4">
                                <label for="promocao" class="form-label">Promoção</label>
                                <select name="promocao" id="promocao" class="form-select" required>
                                  <option value="0" <?php if ($produto['promocao'] == 0) echo 'selected' ?>>Inativo</option>
                                  <option value="1" <?php if ($produto['promocao'] == 1) echo 'selected' ?>>Ativo</option>
                                </select>
                              </div>

                              <div class="col-md-4">
                                <!-- FOR TEM QUE SER IGUAL O ID -->
                                <label for="desconto_produto" class="form-label">Desconto %</label>
                                <input type="text" name="desconto_produto" id="desconto_produto" class="form-control" disabled data-mask="000,00" data-mask-reverse="true" value="<?php echo $produto['desconto'] ?>">
                              </div>

                              <div class="col-md-4">
                                <!-- FOR TEM QUE SER IGUAL O ID -->
                                <label for="valor_promocao" class="form-label">Valor na promoção</label>
                                <input type="text" name="valor_promocao" id="valor_promocao" class="form-control" readonly>
                              </div>

                            </div>
                          </div>
                        </div>

                        <!-- TEM QUE ESTAR DENTRO DA TAG FORM -->
                        <input type="hidden" name="editar" value="editar_produto">
                        <input type="hidden" name="id_produto" value="<?php echo $id_produto ?>">

                        <div class="d-flex justify-content-end gap-2">
                          <button type="submit" class="btn btn-primary px-4">Editar</button>
                        </div>

                      </div>
                    </div>

                  </div>
                </form>

              </div>


            </div>

          <?php
          } else {
            echo '<div class="alert alert-warning d-flex align-items-center justify-content-center" role="alert">
          Nenhum registro encontrado
        </div>
      </div>';
          }

          ?>

        </main>

      </div>

    </div>

    <?php

    mysqli_close($conexao);

    ?>


    <!-- JQUERY CDN -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.7.1/jquery.min.js" integrity="sha512-v2CJ7UaYy4JwqLDIrZUI/4hqeoQieOmAZNXBeQyjo21dadnwR+8ZaIJVT8EE2iyI61OV8e6M8PP2/4hpQINQ/g==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <!-- BOOTSTRAP JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>
    <!-- JQUERY MASK, BIBLIOTECA PARA MASCARAS DE INPUTS SITE TEM TODAS AS DOCUMENTAÇÕES -->
    <script src="../../assets/js/jquery.mask.min.js"></script>
    <!-- MEU JS -->
    <script src="../../custom/js/script.js"></script>
    <!-- foto edit -->
    <script src="../../custom/js/product.js"></script>


  </body>

  </html>