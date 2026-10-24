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


  <!-- css -->
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
            <h4 class="m-0">Novo Cliente</h4>

            <a href="Index.php" class="btn btn-primary btn-sm">
              <i class="bi bi-arrow-left-short"></i>

              Voltar
            </a>

          </div>


          <div class="card-body">

            <!-- ENCTYPE E PARA TRABALHAR COM ENVIO DE ARQUIVOS -->
            <form action="acoes.php" method="post" enctype="multipart/form-data" class="d-flex">
              <div class="geral col-12 ps-2">
                <div class="row">

                  <h4 class="pt-1 pb-2">Informações Pessoais</h4>

                  <div class="col-5">
                    <!-- FOR TEM QUE SER IGUAL O ID -->
                    <label for="nome"><strong class="text-danger">*</strong> Nome</label>
                    <!-- MAXLENGHT 60 CARACTERES, REQUIRED CAMPO ORIGATÓRIO -->
                    <input type="text" name="nome" id="nome" class="form-control" maxlength="60" required>

                  </div>

                  <div class="col-5">
                    <!-- FOR TEM QUE SER IGUAL O ID -->
                    <label for="nomesocial">Nome Social</label>
                    <input type="text" name="nomesocial" id="nomesocial" class="form-control" maxlength="60">

                  </div>



                  <div class="col-3">

                    <label for="sexo"><strong class="text-danger">* </strong>Sexo</label>

                    <select name="sexo" id="sexo" class="form-control" required>

                      <option value="m">Masculino</option>
                      <option value="f">Feminino</option>
                      <option value="n">Não Informado</option>


                    </select>

                  </div>

                  <div class="col-4 mt-2">
                    <label for="datanascimento"><strong class="text-danger">*</strong> Data de Nascimento</label>
                    <input type="date" name="datanascimento" id="datanascimento" class="form-control" min="1900-01-01" max="<?php echo date('Y-m-d') ?>" required>
                  </div>

                  <div class="col-3 mt-2">

                    <label for="cpf"><strong class="text-danger">*</strong> CPF </label>
                    <input type="text" name="cpf" id="cpf" class="form-control" maxlength="14" data-mask="000.000.000-00" required>

                  </div>


                  <div class="col-4 mt-2">
                    <label for="email"><strong class="text-danger">*</strong> Email </label>
                    <input type="email" name="email" id="email" class="form-control col-2" maxlength="50" required>

                  </div>


                  <div class="col-3 mt-2">

                    <label for="telefonecelular"><strong class="text-danger">*</strong> Telefone </label>
                    <input type="text" name="telefone" id="telefone1" class="form-control col-4" maxlength="14" data-mask="(00)99999-9999" required>

                  </div>

                  <div class="col-3 mt-2">

                    <label for="telefoneresidencial">Telefone</label>
                    <input type="text" name="telefone2" id="telefone2" class="form-control col-4" maxlength="14" data-mask="(00)99999-9999">

                  </div>

                  <div class="col-3 mt-2">

                    <label for="status">Status</label>

                    <select name="status" id="status" class="form-control" disabled>

                      <option value="1">Ativo</option>
                      <option value="0">Inativo</option>

                    </select>

                  </div>

                  <div class="col-4 mt-2">

                    <label for="datacadastro">Data de cadastro</label>
                    <input type="date" name="datacadastro" id="datacadastro" class="form-control" required disabled>

                  </div>






                  <h4 class="pt-3 pb-2">Endereço</h4>


                  <div class="col-3">
                    <!-- VIA CEP A FERRAMENTA PARA BUSCAR CEP DE GRAÇA -->
                    <label for="cep"><strong class="text-danger">*</strong> CEP </label>
                    <input type="text" name="cep" id="cep" class="form-control col-4" maxlength="9" data-mask="00000-000" required>

                  </div>

                  <div class="col-4">

                    <label for="rua"><strong class="text-danger">*</strong> Rua </label>
                    <input type="text" name="rua" id="rua" class="form-control col-4" maxlength="70" required>

                  </div>

                  <div class="col-2">

                    <label for="numero"><strong class="text-danger">*</strong> Número </label>
                    <input type="text" name="numero" id="numero" class="form-control col-4" maxlength="4" required>

                  </div>

                  <div class="col-4 mt-2">

                    <label for="bairro"><strong class="text-danger">*</strong> Bairro </label>
                    <input type="text" name="bairro" id="bairro" class="form-control col-4" maxlength="30" required>

                  </div>


                  <div class="col-3 mt-2">

                    <label for="estado"><strong class="text-danger">*</strong> Estado</label>

                    <select name="estado" id="estado" class="form-control" required>

                      <option value="">Selecione o estado</option>
                      <option value="AC">Acre</option>
                      <option value="AL">Alagoas</option>
                      <option value="AP">Amapá</option>
                      <option value="AM">Amazonas</option>
                      <option value="BA">Bahia</option>
                      <option value="CE">Ceará</option>
                      <option value="DF">Distrito Federal</option>
                      <option value="ES">Espírito Santo</option>
                      <option value="GO">Goiás</option>
                      <option value="MA">Maranhão</option>
                      <option value="MT">Mato Grosso</option>
                      <option value="MS">Mato Grosso do Sul</option>
                      <option value="MG">Minas Gerais</option>
                      <option value="PA">Pará</option>
                      <option value="PB">Paraíba</option>
                      <option value="PR">Paraná</option>
                      <option value="PE">Pernambuco</option>
                      <option value="PI">Piauí</option>
                      <option value="RJ">Rio de Janeiro</option>
                      <option value="RN">Rio Grande do Norte</option>
                      <option value="RS">Rio Grande do Sul</option>
                      <option value="RO">Rondônia</option>
                      <option value="RR">Roraima</option>
                      <option value="SC">Santa Catarina</option>
                      <option value="SP">São Paulo</option>
                      <option value="SE">Sergipe</option>
                      <option value="TO">Tocantins</option>

                    </select>

                  </div>

                  <div class="col-3 mt-2">

                    <label for="cidade"><strong class="text-danger">*</strong> Cidade </label>
                    <input type="text" name="cidade" id="cidade" class="form-control col-4" maxlength="40" required>

                  </div>

                  <span class="adicionarend btn btn-primary mt-4">
                    <i class="bi bi-plus"></i>
                  </span>


                  <div class="col-3 mt-2 mb-2">

                    <label for="complemento">Complemento </label>
                    <input type="text" name="complemento" id="complemento" class="form-control col-4" maxlength="40">

                  </div>

                  <div class="col-3 mt-2">



                    <label for="status3">Status</label>

                    <select name="status3" id="status3" class="form-control" disabled>

                      <option value="1">Ativo</option>
                      <option value="0">Inativo</option>

                    </select>

                  </div>

                  <h4 class="endereco2 d-none pt-3 pb-2">Endereço</h4>


                  <div class="col-3">
                    <!-- VIA CEP A FERRAMENTA PARA BUSCAR CEP DE GRAÇA -->
                    <label for="cep2" class="endereco2 d-none"><strong class="text-danger">*</strong> CEP </label>
                    <input type="text" name="cep2" id="cep2" class="endereco2 d-none form-control col-4" maxlength="9" data-mask="00000-000">

                  </div>

                  <div class="col-4">

                    <label for="rua2" class="endereco2 d-none"><strong class="text-danger">*</strong> Rua </label>
                    <input type="text" name="rua2" id="rua2" class="endereco2 d-none form-control col-4" maxlength="70">

                  </div>

                  <div class="col-2">

                    <label for="numero2" class="endereco2 d-none"><strong class="text-danger">*</strong> Número </label>
                    <input type="text" name="numero2" id="numero2" class="endereco2 d-none form-control col-4" maxlength="4">

                  </div>

                  <div class="col-4 mt-2">

                    <label for="bairro2" class="endereco2 d-none"><strong class="text-danger">*</strong> Bairro </label>
                    <input type="text" name="bairro2" id="bairro2" class="endereco2 d-none form-control col-4" maxlength="30">

                  </div>


                  <div class="col-3 mt-2">

                    <label for="estado2" class="endereco2 d-none"><strong class="text-danger">*</strong> Estado</label>

                    <select name="estado2" id="estado2" class="endereco2 d-none form-control">

                      <option value="">Selecione o estado</option>
                      <option value="AC">Acre</option>
                      <option value="AL">Alagoas</option>
                      <option value="AP">Amapá</option>
                      <option value="AM">Amazonas</option>
                      <option value="BA">Bahia</option>
                      <option value="CE">Ceará</option>
                      <option value="DF">Distrito Federal</option>
                      <option value="ES">Espírito Santo</option>
                      <option value="GO">Goiás</option>
                      <option value="MA">Maranhão</option>
                      <option value="MT">Mato Grosso</option>
                      <option value="MS">Mato Grosso do Sul</option>
                      <option value="MG">Minas Gerais</option>
                      <option value="PA">Pará</option>
                      <option value="PB">Paraíba</option>
                      <option value="PR">Paraná</option>
                      <option value="PE">Pernambuco</option>
                      <option value="PI">Piauí</option>
                      <option value="RJ">Rio de Janeiro</option>
                      <option value="RN">Rio Grande do Norte</option>
                      <option value="RS">Rio Grande do Sul</option>
                      <option value="RO">Rondônia</option>
                      <option value="RR">Roraima</option>
                      <option value="SC">Santa Catarina</option>
                      <option value="SP">São Paulo</option>
                      <option value="SE">Sergipe</option>
                      <option value="TO">Tocantins</option>

                    </select>

                  </div>

                  <div class="col-3 mt-2">

                    <label for="cidade2" class="endereco2 d-none"><strong class="text-danger">*</strong> Cidade </label>
                    <input type="text" name="cidade2" id="cidade2" class="endereco2 d-none form-control col-4" maxlength="40">

                  </div>

                  <span class="removerend endereco2 d-none btn btn-primary mt-4">
                    <i class="bi bi-trash"></i>
                  </span>


                  <div class="col-3 mt-2 mb-2">

                    <label for="complemento2" class="endereco2 d-none">Complemento </label>
                    <input type="text" name="complemento2" id="complemento2" class="endereco2 d-none form-control col-4" maxlength="40">

                  </div>

                  <div class="col-3 mt-2">

                    <label for="status2" class="endereco2 d-none">Status</label>

                    <select name="status2" id="status2" class="endereco2 d-none form-control" disabled>

                      <option value="1">Ativo</option>
                      <option value="0">Inativo</option>

                    </select>

                  </div>




                  <div class="col-10 mt-2">

                    <!-- TEM QUE ESTAR DENTRO DA TAG FORM -->
                    <input type="hidden" name="cadastrar" value="cadastrar_cliente">


                    <button type="submit" class="btn btn-primary mt-3">Cadastrar</button>

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
  <!-- VIA CEP -->
  <script src="../../assets/js/via.cep.js"></script>
  <!-- VIA CEP ENDERECO 2 -->
  <script src="../../assets/js/via.cepend2.js"></script>
  <!-- ENDERECO 2 -->
  <script src="../../custom/js/endereco2.js"></script>


</body>

</html>