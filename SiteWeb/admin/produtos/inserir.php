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

          <div class="card bg-dark text-white">

            <div class="card-header d-flex justify-content-between">
              <h4 class="m-0">Novo Produto</h4>

              <a href="Index.php" class="btn btn-primary btn-sm">
                <i class="bi bi-arrow-left-short"></i>

                Voltar
              </a>

            </div>


            <div class="card-body">

              <!-- ENCTYPE E PARA TRABALHAR COM ENVIO DE ARQUIVOS -->
              <form action="acoes.php" method="post" enctype="multipart/form-data" id="formProduto">
                <div class="row g-4">



                  <div class="col-12 col-lg-4 order-lg-2">

                    <div class="upload-imagem card bg-dark text-white p-4">

                      <!-- IMAGEM PRINCIPAL -->
                      <h5 class="pb-1">
                        <strong class="text-danger fs-5">*</strong> Imagem Principal
                      </h5>

                      <label for="foto_produto" id="label_foto_produto">
                        <img id="preview_foto_produto"
                          src=""
                          alt="Imagem Principal"
                          class="img-preview"
                          style="display: none;">

                        <i class="bi bi-cloud-arrow-up"></i>
                        <strong>Clique para adicionar uma imagem</strong>
                        <span>PNG, JPG ou WEBP</span>
                      </label>

                      <input type="file"
                        id="foto_produto"
                        name="foto_produto"
                        accept="image/png, image/jpeg, image/webp">


                      <!-- IMAGENS ADICIONAIS -->
                      <h5 class="pt-4">Imagens Adicionais (máx.3)</h5>

                      <div class="imagens-extras d-flex justify-content-around">

                        <!-- FOTO EXTRA 2 -->
                        <div class="imagem-extra mt-3">
                          <label for="foto_produto2"
                            class="d-flex justify-content-center align-items-center">

                            <img id="preview_foto_produto2"
                              src=""
                              alt="Foto 2"
                              class="img-preview-extra"
                              style="display: none;">

                            <i class="bi bi-plus"></i>

                          </label>
                        </div>

                        <input type="file"
                          id="foto_produto2"
                          name="foto_produto2"
                          accept="image/png, image/jpeg, image/webp">


                        <!-- FOTO EXTRA 3 -->
                        <div class="imagem-extra mt-3">
                          <label for="foto_produto3"
                            class="d-flex justify-content-center align-items-center">

                            <img id="preview_foto_produto3"
                              src=""
                              alt="Foto 3"
                              class="img-preview-extra"
                              style="display: none;">

                            <i class="bi bi-plus"></i>

                          </label>
                        </div>

                        <input type="file"
                          id="foto_produto3"
                          name="foto_produto3"
                          accept="image/png, image/jpeg, image/webp">


                        <!-- FOTO EXTRA 4 -->
                        <div class="imagem-extra mt-3">
                          <label for="foto_produto4"
                            class="d-flex justify-content-center align-items-center">

                            <img id="preview_foto_produto4"
                              src=""
                              alt="Foto 4"
                              class="img-preview-extra"
                              style="display: none;">

                            <i class="bi bi-plus"></i>

                          </label>
                        </div>

                        <input type="file"
                          id="foto_produto4"
                          name="foto_produto4"
                          accept="image/png, image/jpeg, image/webp">

                      </div>


                      <!-- MENSAGEM INFORMATIVA -->
                      <div class="mensagem-imagens card d-flex flex-row pt-2 mt-5 justify-content-around text-dark">
                        <i class="bi bi-info-circle fs-5"></i>

                        <p class="col-10 mb-0">
                          Você pode enviar até <strong>4 imagens</strong> no total.
                          <br>
                          <strong>A primeira imagem será a principal do produto.</strong>
                        </p>
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
                              <input type="text" name="nome" id="nome" class="form-control" maxlength="50" required placeholder="Digite o nome do produto">
                            </div>

                            <div class="col-md-2">
                              <label for="status" class="form-label">Status</label>
                              <select name="status" id="status" class="form-select" disabled>
                                <option value="1">Ativo</option>
                                <option value="0">Inativo</option>
                              </select>
                            </div>

                            <div class="col-md-2">
                              <label for="datacadastro" class="form-label">Data de cadastro</label>
                              <input type="date" name="datacadastro" id="datacadastro" class="form-control" required disabled>
                            </div>

                            <div class="col-md-4">
                              <label for="fornecedor" class="form-label"><strong class="text-danger">*</strong> Fornecedor</label>
                              <select name="fornecedor" id="fornecedor" class="form-select" required>
                                <option value="">Selecionar</option>

                                <?php

                                $sql_fornecedor = "SELECT * FROM fornecedor WHERE status_fornecedor = 1;";

                                $query_fornecedor = mysqli_query($conexao, $sql_fornecedor);

                                foreach ($query_fornecedor as $fornecedor) {
                                  // CONCATENAR O ID E O NOME
                                  echo '<option value="' . $fornecedor['id_fornecedor'] . '">' . $fornecedor['nome_fornecedor'] . '</option>';
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
                                  // CONCATENAR O ID E O NOME
                                  echo '<option value="' . $categoria['id_categoria'] . '">' . $categoria['nome_categoria'] . '</option>';
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
                                  // CONCATENAR O ID E O NOME
                                  echo '<option value="' . $marca['id_marca'] . '">' . $marca['nome_marca'] . '</option>';
                                }

                                ?>

                              </select>
                            </div>

                            <div class="col-md-4">
                              <label for="cor" class="form-label"><strong class="text-danger">*</strong> Cor</label>
                              <select name="cor" id="cor" class="form-select" required>
                                <option value="">Cor</option>
                                <option value="Amarelo">Amarelo</option>
                                <option value="Azul">Azul</option>
                                <option value="Bege">Bege</option>
                                <option value="Branco">Branco</option>
                                <option value="Cinza">Cinza</option>
                                <option value="Laranja">Laranja</option>
                                <option value="Marrom">Marrom</option>
                                <option value="Preto">Preto</option>
                                <option value="Rosa">Rosa</option>
                                <option value="Roxo">Roxo</option>
                                <option value="Verde">Verde</option>
                                <option value="Vermelho">Vermelho</option>
                              </select>
                            </div>

                            <div class="col-md-4">
                              <label for="tamanho" class="form-label"><strong class="text-danger">*</strong> Tamanho</label>
                              <input type="text" name="tamanho" id="tamanho" class="form-control" placeholder="Ex: 38, 39, 40, 41 ou P, M, G" required>
                            </div>

                            <div class="col-md-4">
                              <label for="estoque" class="form-label"><strong class="text-danger">*</strong> Estoque</label>
                              <input type="number" name="estoque" id="estoque" class="form-control" required>
                            </div>

                            <div class="col-md-3">
                              <label for="destaque" class="form-label">Produto em Destaque</label>
                              <select name="destaque" id="destaque" class="form-select" required>
                                <option value="0">Inativo</option>
                                <option value="1">Ativo</option>
                              </select>
                            </div>


                            <div class="col-12">
                              <label for="descricao" class="form-label">Descrição</label>
                              <!-- CAMPO DE TEXTO MAIOR -->
                              <textarea name="descricao" id="descricao" class="form-control" maxlength="1000" rows="3"></textarea>
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
                              <input type="text" name="custo_produto" id="custo_produto" class="form-control" required data-mask="00000,00" data-mask-reverse="true">
                            </div>

                            <div class="col-md-4">
                              <!-- FOR TEM QUE SER IGUAL O ID -->
                              <label for="lucro" class="form-label">Lucro %</label>
                              <input type="text" name="lucro" id="lucro" class="form-control" data-mask="000,00" data-mask-reverse="true">
                            </div>

                            <div class="col-md-4">
                              <!-- FOR TEM QUE SER IGUAL O ID -->
                              <label for="valor_produto" class="form-label"><strong class="text-danger">*</strong> Valor Produto</label>
                              <input type="text" name="valor_produto" id="valor_produto" class="form-control">
                            </div>

                            <div class="col-md-4">
                              <label for="promocao" class="form-label">Promoção</label>
                              <select name="promocao" id="promocao" class="form-select" required>
                                <option value="0">Inativo</option>
                                <option value="1">Ativo</option>
                              </select>
                            </div>

                            <div class="col-md-4">
                              <!-- FOR TEM QUE SER IGUAL O ID -->
                              <label for="desconto_produto" class="form-label">Desconto %</label>
                              <input type="text" name="desconto_produto" id="desconto_produto" class="form-control" disabled data-mask="000,00" data-mask-reverse="true">
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
                      <input type="hidden" name="cadastrar" value="cadastrar_produto">

                      <div class="d-flex justify-content-end gap-2">
                        <button type="submit" class="btn btn-primary px-4">Cadastrar</button>
                      </div>

                    </div>
                  </div>

                </div>

              </form>

            </div>


          </div>

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
    <!-- foto produto -->
    <script src="../../custom/js/product.js"></script>

  </body>

  </html>