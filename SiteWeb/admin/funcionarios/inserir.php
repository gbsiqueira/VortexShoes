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

  <!-- CSS -->
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

        <div class="card bg-dark">

          <div class="card-header bg-dark d-flex justify-content-between">
            <h4 class="m-0 text-white">Novo Funcionário</h4>

            <a href="Index.php" class="btn btn-primary btn-sm">
              <i class="bi bi-arrow-left-short"></i>

              Voltar
            </a>

          </div>


          <div class="card-body bg-dark">



            <form action="acoes.php" method="post" enctype="multipart/form-data" id="formFuncionario">
              <div class="row g-4">

                <!-- COLUNA DA FOTO -->
                <div class="col-12 col-lg-3 order-lg-2">
                  <div class="card text-bg-dark h-100">
                    <div class="card-header fw-semibold">
                      Foto do Funcionário
                    </div>
                    <div class="card-body d-flex flex-column align-items-center gap-3">

                      <img src="../../assets/img/placeholder-funcionario.png" alt="Selecione a imagem do funcionário" id="previewFoto" class="img-funcionario-inserir rounded-circle img-thumbnail" width="150" height="150">

                      <!-- accept e aceite imagens, a extensao tanto faz mas e apenas imagens -->
                      <input type="file" name="fotoinput" id="fotoinput" class="form-control" accept="image/*">

                      <button type="button" id="btnRemoverFoto" class="btn btn-outline-danger btn-sm w-100">
                        Remover foto
                      </button>

                    </div>
                  </div>
                </div>

                <!-- COLUNA DOS DADOS -->
                <div class="col-12 col-lg-9 order-lg-1">
                  <div class="d-flex flex-column gap-4">

                    <!-- INFORMAÇÕES PESSOAIS -->
                    <div class="card text-bg-dark">
                      <div class="card-header fw-semibold">
                        Informações Pessoais
                      </div>
                      <div class="card-body">
                        <div class="row g-3">

                          <div class="col-md-6">
                            <!-- FOR TEM QUE SER IGUAL O ID -->
                            <label for="nome" class="form-label"><strong class="text-danger">*</strong> Nome</label>
                            <!-- MAXLENGHT 60 CARACTERES, REQUIRED CAMPO ORIGATÓRIO -->
                            <input type="text" name="nome" id="nome" class="form-control" maxlength="60" required>
                          </div>

                          <div class="col-md-6">
                            <label for="nomesocial" class="form-label">Nome Social</label>
                            <input type="text" name="nomesocial" id="nomesocial" class="form-control" maxlength="40">
                          </div>

                          <div class="col-md-3">
                            <label for="sexo" class="form-label"><strong class="text-danger">*</strong> Sexo</label>
                            <select name="sexo" id="sexo" class="form-select" required>
                              <option value="m">Masculino</option>
                              <option value="f">Feminino</option>
                              <option value="n">Não Informado</option>
                            </select>
                          </div>

                          <div class="col-md-4">
                            <label for="datanascimento" class="form-label"><strong class="text-danger">*</strong> Data de Nascimento</label>
                            <input type="date" name="datanascimento" id="datanascimento" class="form-control" min="1900-01-01" max="<?php echo date('Y-m-d') ?>" required>
                          </div>

                          <div class="col-md-5">
                            <label for="estadocivil" class="form-label">Estado Civil</label>
                            <select name="estadocivil" id="estadocivil" class="form-select">
                              <option value="">Estado Civil</option>
                              <option value="Solteiro(a)">Solteiro(a)</option>
                              <option value="Casado(a)">Casado(a)</option>
                              <option value="Divorciado(a)">Divorciado(a)</option>
                              <option value="Viúvo(a)">Viúvo(a)</option>
                              <option value="Separado(a) Judicialmente">Separado(a) Judicialmente</option>
                              <option value="União Estáve">União Estável</option>
                            </select>
                          </div>

                          <div class="col-md-5">
                            <label for="cpf" class="form-label"><strong class="text-danger">*</strong> CPF</label>
                            <input type="text" name="cpf" id="cpf" class="form-control" maxlength="14" data-mask="000.000.000-00" required>
                          </div>

                          <div class="col-md-4">
                            <label for="rg" class="form-label">RG</label>
                            <input type="text" name="rg" id="rg" class="form-control" maxlength="14" data-mask="00.000.000-A">
                          </div>

                          <div class="col-md-3">
                            <label for="email" class="form-label"><strong class="text-danger">*</strong> Email</label>
                            <input type="email" name="email" id="email" class="form-control" maxlength="50" required>
                          </div>

                          <div class="col-md-4">
                            <label for="telefonecelular" class="form-label">Telefone Celular</label>
                            <input type="text" name="telefonecelular" id="telefonecelular" class="form-control" maxlength="14" data-mask="(00)99999-9999">
                          </div>

                          <div class="col-md-4">
                            <label for="telefoneresidencial" class="form-label">Telefone Residencial</label>
                            <input type="text" name="telefoneresidencial" id="telefoneresidencial" class="form-control" maxlength="13" data-mask="(00)0000-0000">
                          </div>

                          <div class="col-md-2">
                            <label for="status" class="form-label">Status</label>
                            <select name="status" id="status" class="form-select" disabled>
                              <option value="1">Ativo</option>
                              <option value="0">Inativo</option>
                            </select>
                          </div>

                          <div class="col-md-2">
                            <label for="datacadastro" class="form-label">Cadastro</label>
                            <input type="date" name="datacadastro" id="datacadastro" class="form-control" required disabled>
                          </div>

                        </div>
                      </div>
                    </div>

                    <!-- ENDEREÇO -->
                    <div class="card text-bg-dark">
                      <div class="card-header fw-semibold">
                        Endereço
                      </div>
                      <div class="card-body">
                        <div class="row g-3">

                          <div class="col-md-3">
                            <!-- VIA CEP A FERRAMENTA PARA BUSCAR CEP DE GRAÇA -->
                            <label for="cep" class="form-label"><strong class="text-danger">*</strong> CEP</label>
                            <input type="text" name="cep" id="cep" class="form-control" maxlength="9" data-mask="00000-000" required>
                          </div>

                          <div class="col-md-5">
                            <label for="rua" class="form-label"><strong class="text-danger">*</strong> Rua</label>
                            <input type="text" name="rua" id="rua" class="form-control" maxlength="70" required>
                          </div>

                          <div class="col-md-2">
                            <label for="numero" class="form-label"><strong class="text-danger">*</strong> Número</label>
                            <input type="text" name="numero" id="numero" class="form-control" maxlength="4" required>
                          </div>

                          <div class="col-md-2">
                            <label for="complemento" class="form-label">Complemento</label>
                            <input type="text" name="complemento" id="complemento" class="form-control" maxlength="40">
                          </div>

                          <div class="col-md-4">
                            <label for="bairro" class="form-label"><strong class="text-danger">*</strong> Bairro</label>
                            <input type="text" name="bairro" id="bairro" class="form-control" maxlength="30" required>
                          </div>

                          <div class="col-md-4">
                            <label for="cidade" class="form-label"><strong class="text-danger">*</strong> Cidade</label>
                            <input type="text" name="cidade" id="cidade" class="form-control" maxlength="40" required>
                          </div>

                          <div class="col-md-4">
                            <label for="estado" class="form-label"><strong class="text-danger">*</strong> Estado</label>
                            <select name="estado" id="estado" class="form-select" required>
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

                        </div>
                      </div>
                    </div>

                    <!-- CREDENCIAIS E SALÁRIO -->
                    <div class="card text-bg-dark">
                      <div class="card-header fw-semibold">
                        Credenciais e Salário
                      <div class="card-body">
                        <div class="row g-3">

                          <div class="col-md-4">
                            <label for="usuario" class="form-label"><strong class="text-danger">*</strong> Usuário</label>
                            <input type="text" name="usuario" id="usuario" class="form-control" maxlength="15" required>
                          </div>

                          <div class="col-md-4">
                            <label for="senha" class="form-label"><strong class="text-danger">*</strong> Senha</label>
                            <input type="password" name="senha" id="senha" class="form-control" maxlength="10" required>
                          </div>

                          <div class="col-md-4">
                            <label for="acesso" class="form-label"><strong class="text-danger">*</strong> Tipo de acesso</label>
                            <select name="acesso" id="acesso" class="form-select" required>
                              <option value="0">Comum</option>
                              <option value="1">Administrador</option>
                            </select>
                          </div>

                          <div class="col-md-6">
                            <label for="cargo" class="form-label"><strong class="text-danger">*</strong> Cargo</label>
                            <select name="cargo" id="cargo" class="form-select" required>
                              <option value="">Selecionar</option>

                              <?php

                              $sql_cargo = "SELECT id_cargo, nome FROM cargo WHERE status = 1";

                              $query_cargo = mysqli_query($conexao, $sql_cargo);

                              foreach ($query_cargo as $cargo) {
                                // CONCATENAR O ID E O NOME
                                echo '<option value="' . $cargo['id_cargo'] . '">' . $cargo['nome'] . '</option>';
                              }

                              ?>

                            </select>
                          </div>

                          <div class="col-md-6">
                            <label for="salario" class="form-label"><strong class="text-danger">*</strong> Salário</label>
                            <div class="input-group">
                              <span class="input-group-text">R$</span>
                              <!-- DATA-MASK REVERSE SERVE PRA COLOCAR A VIRUGULA DEPOIS DOS 3 PRIMEIROS NUMEROS -->
                              <input type="decimal" name="salario" id="salario" class="form-control" data-mask="00000,00" data-mask-reverse="true" required>
                            </div>
                          </div>

                        </div>
                    </div>

                    <!-- TEM QUE ESTAR DENTRO DA TAG FORM -->
                    <input type="hidden" name="cadastrar" value="cadastrar_funcionario">

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
  <!-- VIA CEP -->
  <script src="../../assets/js/via.cep.js"></script>
  <script src="../../custom/js/inputimg.js"></script>


</body>

</html>