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

        <?php 
        if(isset($_GET['id_cliente']) && $_GET['id_cliente'] != '')
          {
              $id_cliente = $_GET['id_cliente'];

              $sql = "SELECT * FROM cliente WHERE id_cliente = $id_cliente";

              $query = mysqli_query($conexao, $sql);

              $cliente = mysqli_fetch_assoc($query);


              //ENDERECO
              $sql_end = "SELECT * FROM endereco WHERE id_cliente = $id_cliente";

              $query_end = mysqli_query($conexao, $sql_end);

              $enderecos = [];
              while($linha = mysqli_fetch_assoc($query_end))
                {
                    $enderecos[] = $linha;
                }


                $end1 = $enderecos[0];
                $end2 = isset($enderecos[1]) ? $enderecos[1] : null;

                $id_end1 = $end1['id_endereco'];
                $id_end2= $end2['id_endereco'];

        ?>

        <div class="card bg-dark text-white">

          <div class="card-header d-flex justify-content-between">
            <h4 class="m-0">Editar Cliente</h4>

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
                    <input type="text" name="nome" id="nome" class="form-control" maxlength="60" required value="<?php echo $cliente['nome_cliente'] ?>">

                  </div>

                  <div class="col-5">
                    <!-- FOR TEM QUE SER IGUAL O ID -->
                    <label for="nomesocial">Nome Social</label>
                    <input type="text" name="nomesocial" id="nomesocial" class="form-control" maxlength="60" value="<?php echo $cliente['nome_social'] ?>">

                  </div>


                  <div class="col-3 mt-2">

                    <label for="sexo"><strong class="text-danger">* </strong>Sexo</label>

                    <select name="sexo" id="sexo" class="form-control" required>

                      <option value="m" <?php if($cliente['sexo_cliente'] == 'm') echo 'selected'?>>Masculino</option>
                      <option value="f" <?php if($cliente['sexo_cliente'] == 'f') echo 'selected'?>>Feminino</option>
                      <option value="n" <?php if($cliente['sexo_cliente'] == 'n') echo 'selected'?>>Não Informado</option>


                    </select>

                  </div>

                  <div class="col-4 mt-2">
                    <label for="datanascimento"><strong class="text-danger">*</strong> Data de Nascimento</label>
                    <input type="date" name="datanascimento" id="datanascimento" class="form-control"  min="1900-01-01" max="<?php echo date('Y-m-d') ?>" required value="<?php echo $cliente['data_nascimento_cliente'] ?>">
                  </div>

                  <div class="col-3 mt-2">

                    <label for="cpf"><strong class="text-danger">*</strong> CPF </label>
                    <input type="text" name="cpf" id="cpf" class="form-control" maxlength="14" data-mask="000.000.000-00" required value="<?php echo $cliente['cpf_cliente'] ?>">

                  </div>


                  <div class="col-4 mt-2">
                    <label for="email"><strong class="text-danger">*</strong> Email </label>
                    <input type="email" name="email" id="email" class="form-control col-2" maxlength="50" required value="<?php echo $cliente['email'] ?>">

                  </div>


                  <div class="col-3 mt-2">

                    <label for="telefonecelular"><strong class="text-danger">*</strong> Telefone </label>
                    <input type="text" name="telefone" id="telefone1" class="form-control col-4" maxlength="14" data-mask="(00)99999-9999" required value="<?php echo $cliente['telefone_cliente'] ?>">

                  </div>

                  <div class="col-3 mt-2">

                    <label for="telefoneresidencial">Telefone</label>
                    <input type="text" name="telefone2" id="telefone2" class="form-control col-4" maxlength="14" data-mask="(00)99999-9999" value="<?php echo $cliente['telefone_cliente2'] ?>">

                  </div>

                  <div class="col-3 mt-2">

                    <label for="status">Status</label>

                    <select name="status" id="status" class="form-control">

                      <option value="1" <?php if($cliente['status_cliente'] == 1) echo 'selected'?>>Ativo</option>
                      <option value="0" <?php if($cliente['status_cliente'] == 0) echo 'selected'?>>Inativo</option>

                    </select>

                  </div>

                  <div class="col-4 mt-2">

                    <label for="datacadastro">Data de cadastro</label>
                    <input type="date" name="datacadastro" id="datacadastro" class="form-control" required disabled value="<?php echo date('Y-m-d', strtotime($cliente['data_cadastro']))?>">

                  </div>






                  <h4 class="pt-3 pb-2">Endereço</h4>


                  <div class="col-3">
                    <!-- VIA CEP A FERRAMENTA PARA BUSCAR CEP DE GRAÇA -->
                    <label for="cep"><strong class="text-danger">*</strong> CEP </label>
                    <input type="text" name="cep" id="cep" class="form-control col-4" maxlength="9" data-mask="00000-000" required value="<?php echo $end1['cep'] ?>">

                  </div>

                  <div class="col-4">

                    <label for="rua"><strong class="text-danger">*</strong> Rua </label>
                    <input type="text" name="rua" id="rua" class="form-control col-4" maxlength="70" required value="<?php echo $end1['rua'] ?>">

                  </div>

                  <div class="col-2">

                    <label for="numero"><strong class="text-danger">*</strong> Número </label>
                    <input type="text" name="numero" id="numero" class="form-control col-4" maxlength="4" required value="<?php echo $end1['numero'] ?>">

                  </div>

                  <div class="col-4 mt-2">

                    <label for="bairro"><strong class="text-danger">*</strong> Bairro </label>
                    <input type="text" name="bairro" id="bairro" class="form-control col-4" maxlength="30" required value="<?php echo $end1['bairro'] ?>">

                  </div>


                  <div class="col-3 mt-2">

                    <label for="estado"><strong class="text-danger">*</strong> Estado</label>

                    <select name="estado" id="estado" class="form-control" required>

                     <option value="AC" <?php if($end1['estado'] == 'AC') echo 'selected'?>>Acre</option>
                      <option value="AL" <?php if($end1['estado'] == 'AL') echo 'selected'?>>Alagoas</option>
                      <option value="AP" <?php if($end1['estado'] == 'AP') echo 'selected'?>>Amapá</option>
                      <option value="AM" <?php if($end1['estado'] == 'AM') echo 'selected'?>>Amazonas</option>
                      <option value="BA" <?php if($end1['estado'] == 'BA') echo 'selected'?>>Bahia</option>
                      <option value="CE" <?php if($end1['estado'] == 'CE') echo 'selected'?>>Ceará</option>
                      <option value="DF" <?php if($end1['estado'] == 'DF') echo 'selected'?>>Distrito Federal</option>
                      <option value="ES" <?php if($end1['estado'] == 'ES') echo 'selected'?>>Espírito Santo</option>
                      <option value="GO" <?php if($end1['estado'] == 'GO') echo 'selected'?>>Goiás</option>
                      <option value="MA" <?php if($end1['estado'] == 'MA') echo 'selected'?>>Maranhão</option>
                      <option value="MT" <?php if($end1['estado'] == 'MT') echo 'selected'?>>Mato Grosso</option> 
                      <option value="MS" <?php if($end1['estado'] == 'MS') echo 'selected'?>>Mato Grosso do Sul</option>
                      <option value="MG" <?php if($end1['estado'] == 'MG') echo 'selected'?>>Minas Gerais</option>
                      <option value="PA" <?php if($end1['estado'] == 'PA') echo 'selected'?>>Pará</option>
                      <option value="PB" <?php if($end1['estado'] == 'PB') echo 'selected'?>>Paraíba</option>
                      <option value="PR" <?php if($end1['estado'] == 'PR') echo 'selected'?>>Paraná</option>
                      <option value="PE" <?php if($end1['estado'] == 'PE') echo 'selected'?>>Pernambuco</option>
                      <option value="PI" <?php if($end1['estado'] == 'PI') echo 'selected'?>>Piauí</option>
                      <option value="RJ" <?php if($end1['estado'] == 'RJ') echo 'selected'?>>Rio de Janeiro</option>
                      <option value="RN" <?php if($end1['estado'] == 'RN') echo 'selected'?>>Rio Grande do Norte</option>
                      <option value="RS" <?php if($end1['estado'] == 'RS') echo 'selected'?>>Rio Grande do Sul</option>
                      <option value="RO" <?php if($end1['estado'] == 'RO') echo 'selected'?>>Rondônia</option>
                      <option value="RR" <?php if($end1['estado'] == 'RR') echo 'selected'?>>Roraima</option>
                      <option value="SC" <?php if($end1['estado'] == 'SC') echo 'selected'?>>Santa Catarina</option>
                      <option value="SP" <?php if($end1['estado'] == 'SP') echo 'selected'?>>São Paulo</option>
                      <option value="SE" <?php if($end1['estado'] == 'SE') echo 'selected'?>>Sergipe</option>
                      <option value="TO" <?php if($end1['estado'] == 'TO') echo 'selected'?>>Tocantins</option>

                    </select>

                  </div>

                  <div class="col-3 mt-2">

                    <label for="cidade"><strong class="text-danger">*</strong> Cidade </label>
                    <input type="text" name="cidade" id="cidade" class="form-control col-4" maxlength="40" required value="<?php echo $end1['cidade'] ?>">

                  </div>

                  <span class="adicionarend btn btn-primary mt-4">
                    <i class="bi bi-plus"></i>
                  </span>


                  <div class="col-3 mt-2 mb-2">

                    <label for="complemento">Complemento </label>
                    <input type="text" name="complemento" id="complemento" class="form-control col-4" maxlength="40" value="<?php echo $end1['complemento'] ?>">

                  </div>

                  <div class="col-3 mt-2">
                  
                    <label for="status2">Status</label>

                    <select name="status2" id="status2" class="form-control">

                      <option value="1" <?php if($end1['status'] == 1) echo 'selected'?>>Ativo</option>
                      <option value="0" <?php if($end1['status'] == 0) echo 'selected'?>>Inativo</option>

                    </select>

                  </div>

                  <h4 class="endereco2 d-none pt-3 pb-2">Endereço</h4>


                  <div class="col-3">
                    <!-- VIA CEP A FERRAMENTA PARA BUSCAR CEP DE GRAÇA -->
                    <label for="cep2" class="endereco2 d-none"><strong class="text-danger">*</strong> CEP </label>
                    <input type="text" name="cep2" id="cep2" class="endereco2 d-none form-control col-4" maxlength="9" data-mask="00000-000" value="<?php echo $end2['cep'] ?>">

                  </div>

                  <div class="col-4">

                    <label for="rua2" class="endereco2 d-none"><strong class="text-danger">*</strong> Rua </label>
                    <input type="text" name="rua2" id="rua2" class="endereco2 d-none form-control col-4" maxlength="70" value="<?php echo $end2['rua'] ?>">

                  </div>

                  <div class="col-2">

                    <label for="numero2" class="endereco2 d-none"><strong class="text-danger">*</strong> Número </label>
                    <input type="text" name="numero2" id="numero2" class="endereco2 d-none form-control col-4" maxlength="4" value="<?php echo $end2['numero'] ?>">

                  </div>

                  <div class="col-4 mt-2">

                    <label for="bairro2" class="endereco2 d-none"><strong class="text-danger">*</strong> Bairro </label>
                    <input type="text" name="bairro2" id="bairro2" class="endereco2 d-none form-control col-4" maxlength="30" value="<?php echo $end2['bairro'] ?>">

                  </div>


                  <div class="col-3 mt-2">

                    <label for="estado2" class="endereco2 d-none"><strong class="text-danger">*</strong> Estado</label>

                    <select name="estado2" id="estado2" class="endereco2 d-none form-control">

                      <option value="AC" <?php if($end2['estado'] == 'AC') echo 'selected'?>>Acre</option>
                      <option value="AL" <?php if($end2['estado'] == 'AL') echo 'selected'?>>Alagoas</option>
                      <option value="AP" <?php if($end2['estado'] == 'AP') echo 'selected'?>>Amapá</option>
                      <option value="AM" <?php if($end2['estado'] == 'AM') echo 'selected'?>>Amazonas</option>
                      <option value="BA" <?php if($end2['estado'] == 'BA') echo 'selected'?>>Bahia</option>
                      <option value="CE" <?php if($end2['estado'] == 'CE') echo 'selected'?>>Ceará</option>
                      <option value="DF" <?php if($end2['estado'] == 'DF') echo 'selected'?>>Distrito Federal</option>
                      <option value="ES" <?php if($end2['estado'] == 'ES') echo 'selected'?>>Espírito Santo</option>
                      <option value="GO" <?php if($end2['estado'] == 'GO') echo 'selected'?>>Goiás</option>
                      <option value="MA" <?php if($end2['estado'] == 'MA') echo 'selected'?>>Maranhão</option>
                      <option value="MT" <?php if($end2['estado'] == 'MT') echo 'selected'?>>Mato Grosso</option> 
                      <option value="MS" <?php if($end2['estado'] == 'MS') echo 'selected'?>>Mato Grosso do Sul</option>
                      <option value="MG" <?php if($end2['estado'] == 'MG') echo 'selected'?>>Minas Gerais</option>
                      <option value="PA" <?php if($end2['estado'] == 'PA') echo 'selected'?>>Pará</option>
                      <option value="PB" <?php if($end2['estado'] == 'PB') echo 'selected'?>>Paraíba</option>
                      <option value="PR" <?php if($end2['estado'] == 'PR') echo 'selected'?>>Paraná</option>
                      <option value="PE" <?php if($end2['estado'] == 'PE') echo 'selected'?>>Pernambuco</option>
                      <option value="PI" <?php if($end2['estado'] == 'PI') echo 'selected'?>>Piauí</option>
                      <option value="RJ" <?php if($end2['estado'] == 'RJ') echo 'selected'?>>Rio de Janeiro</option>
                      <option value="RN" <?php if($end2['estado'] == 'RN') echo 'selected'?>>Rio Grande do Norte</option>
                      <option value="RS" <?php if($end2['estado'] == 'RS') echo 'selected'?>>Rio Grande do Sul</option>
                      <option value="RO" <?php if($end2['estado'] == 'RO') echo 'selected'?>>Rondônia</option>
                      <option value="RR" <?php if($end2['estado'] == 'RR') echo 'selected'?>>Roraima</option>
                      <option value="SC" <?php if($end2['estado'] == 'SC') echo 'selected'?>>Santa Catarina</option>
                      <option value="SP" <?php if($end2['estado'] == 'SP') echo 'selected'?>>São Paulo</option>
                      <option value="SE" <?php if($end2['estado'] == 'SE') echo 'selected'?>>Sergipe</option>
                      <option value="TO" <?php if($end2['estado'] == 'TO') echo 'selected'?>>Tocantins</option>


                    </select>

                  </div>

                  <div class="col-3 mt-2">

                    <label for="cidade2" class="endereco2 d-none"><strong class="text-danger">*</strong> Cidade </label>
                    <input type="text" name="cidade2" id="cidade2" class="endereco2 d-none form-control col-4" maxlength="40" value="<?php echo $end2['cidade'] ?>">

                  </div>

                  <span class="removerend endereco2 d-none btn btn-primary mt-4">
                    <i class="bi bi-trash"></i>
                  </span>


                  <div class="col-3 mt-2 mb-2">

                    <label for="complemento2" class="endereco2 d-none">Complemento </label>
                    <input type="text" name="complemento2" id="complemento2" class="endereco2 d-none form-control col-4" maxlength="40" value="<?php echo $end2['complemento'] ?>">

                  </div>

                   <div class="col-3 mt-2">
                  
                    <label for="status3" class="endereco2 d-none">Status</label>

                    <select name="status3" id="status3" class="d-none endereco2 form-control">

                      <option value="1" <?php if($end2['status'] == 1) echo 'selected'?>>Ativo</option>
                      <option value="0" <?php if($end2['status'] == 0) echo 'selected'?>>Inativo</option>

                    </select>

                  </div>




                  <div class="col-10 mt-2">

                    <!-- TEM QUE ESTAR DENTRO DA TAG FORM -->
                    <input type="hidden" name="editar" value="editar_cliente">
                    <input type="hidden" name="id_cliente" value="<?php echo $id_cliente?>">
                    <input type="hidden" name="id_end1" value="<?php echo $id_end1?>">
                    <input type="hidden" name="id_end2" value="<?php echo $id_end2?>">



                    <button type="submit" class="btn btn-primary mt-3">Editar</button>

                  </div>



                </div>

              </div>










            </form>

          </div>

        </div>

        <?php 
        }
        else
          {
              echo '<div class="alert alert-warning d-flex align-items-center justify-content-center" role="alert">
                  Cliente não encontrado
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
  <!-- VIA CEP -->
  <script src="../../assets/js/via.cep.js"></script>
  <!-- VIA CEP ENDERECO 2 -->
  <script src="../../assets/js/via.cepend2.js"></script>
  <!-- ENDERECO SL -->
  <script src="../../custom/js/enderecosl.js"></script>


</body>

</html>