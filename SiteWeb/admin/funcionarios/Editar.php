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

        if (isset($_GET['id_funcionario']) && $_GET['id_funcionario'] != '') {

          $id = $_GET['id_funcionario'];

          $sql = "SELECT * FROM funcionario WHERE id_funcionario = $id";

          $query = mysqli_query($conexao, $sql);

          $funcionario = mysqli_fetch_assoc($query);



        ?>

          <div class="card bg-dark">

            <div class="card-header bg-dark d-flex justify-content-between">
              <h4 class="m-0 text-white">Editar Funcionário</h4>

              <a href="Index.php" class="btn btn-primary btn-sm">
                <i class="bi bi-arrow-left-short"></i>

                Voltar
              </a>

            </div>


            <div class="card-body bg-dark">

              <!-- ENCTYPE E PARA TRABALHAR COM ENVIO DE ARQUIVOS -->
              <form action="acoes.php" method="post" enctype="multipart/form-data" id="formFuncionario">
                <div class="row g-4">

                  <!-- COLUNA DA FOTO -->
                  <div class="col-12 col-lg-3 order-lg-2">
                    <div class="card text-bg-dark h-100">
                      <div class="card-header fw-semibold">
                        Foto do Funcionário
                      </div>
                      <div class="card-body d-flex flex-column align-items-center gap-3">

                        <?php

                        if ($funcionario['foto'] != '') {
                          echo '<img src="../../../images-funcionarios/' . $funcionario['foto'] . '" alt="Selecione a imagem do funcionário" id="previewFoto" class="img-funcionario-inserir rounded-circle img-thumbnail" width="150" height="150">';
                        } else {
                          echo '<img src="./../../assets/img/placeholder-funcionario.png" alt="Selecione a imagem do funcionário" id="previewFoto" class="img-funcionario-inserir rounded-circle img-thumbnail" width="150" height="150">';
                        }

                        ?>

                        <!-- accept e aceite imagens, a extensao tanto faz mas e apenas imagens -->
                        <input type="file" name="fotoinput" id="fotoinput" class="form-control" accept="image/*">

                        <input type="hidden" name="fotoatual" value="<?php echo $funcionario['foto'] ?>">

                        <input type="hidden" name="remover_foto" id="remover_foto" value="0">

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
                              <input type="text" name="nome" id="nome" class="form-control" maxlength="60" value="<?php echo $funcionario['nome'] ?>" required>
                            </div>

                            <div class="col-md-6">
                              <label for="nomesocial" class="form-label">Nome Social</label>
                              <input type="text" name="nomesocial" id="nomesocial" class="form-control" maxlength="40" value="<?php echo $funcionario['nome_social'] ?>">
                            </div>

                            <div class="col-md-3">
                              <label for="sexo" class="form-label"><strong class="text-danger">*</strong> Sexo</label>
                              <select name="sexo" id="sexo" class="form-select" required>
                                <option value="m" <?php if ($funcionario['sexo'] == 'm') echo 'selected' ?>>Masculino</option>
                                <option value="f" <?php if ($funcionario['sexo'] == 'f') echo 'selected' ?>>Feminino</option>
                                <option value="n" <?php if ($funcionario['sexo'] == 'n') echo 'selected' ?>>Não Informado</option>
                              </select>
                            </div>

                            <div class="col-md-4">
                              <label for="datanascimento" class="form-label"><strong class="text-danger">*</strong> Data de Nascimento</label>
                              <input type="date" name="datanascimento" id="datanascimento" class="form-control" min="1900-01-01" max="<?php echo date('Y-m-d') ?>" value="<?php echo $funcionario['data_nascimento'] ?>" required>
                            </div>

                            <div class="col-md-5">
                              <label for="estadocivil" class="form-label">Estado Civil</label>
                              <select name="estadocivil" id="estadocivil" class="form-select">
                                <option value="">Estado Civil</option>
                                <option value="Solteiro(a)" <?php if ($funcionario['estado_civil'] == 'Solteiro(a)') echo 'selected' ?>>Solteiro(a)</option>
                                <option value="Casado(a)" <?php if ($funcionario['estado_civil'] == 'Casado(a)') echo 'selected' ?>>Casado(a)</option>
                                <option value="Divorciado(a)" <?php if ($funcionario['estado_civil'] == 'Divorciado(a)') echo 'selected' ?>>Divorciado(a)</option>
                                <option value="Viúvo(a)" <?php if ($funcionario['estado_civil'] == 'Viúvo(a)') echo 'selected' ?>>Viúvo(a)</option>
                                <option value="Separado(a) Judicialmente" <?php if ($funcionario['estado_civil'] == 'Separado(a) Judicialmente') echo 'selected' ?>>Separado(a) Judicialmente</option>
                                <option value="União Estável" <?php if ($funcionario['estado_civil'] == 'União Estável') echo 'selected' ?>>União Estável</option>
                              </select>
                            </div>

                            <div class="col-md-5">
                              <label for="cpf" class="form-label"><strong class="text-danger">*</strong> CPF</label>
                              <input type="text" name="cpf" id="cpf" class="form-control" maxlength="14" data-mask="000.000.000-00" value="<?php echo $funcionario['cpf'] ?>" required>
                            </div>

                            <div class="col-md-4">
                              <label for="rg" class="form-label">RG</label>
                              <input type="text" name="rg" id="rg" class="form-control" maxlength="14" data-mask="00.000.000-A" value="<?php echo $funcionario['rg'] ?>">
                            </div>

                            <div class="col-md-3">
                              <label for="email" class="form-label"><strong class="text-danger">*</strong> Email</label>
                              <input type="email" name="email" id="email" class="form-control" maxlength="50" value="<?php echo $funcionario['email'] ?>" required>
                            </div>

                            <div class="col-md-4">
                              <label for="telefonecelular" class="form-label">Telefone Celular</label>
                              <input type="text" name="telefonecelular" id="telefonecelular" class="form-control" maxlength="14" data-mask="(00)99999-9999" value="<?php echo $funcionario['telefone_celular'] ?>">
                            </div>

                            <div class="col-md-4">
                              <label for="telefoneresidencial" class="form-label">Telefone Residencial</label>
                              <input type="text" name="telefoneresidencial" id="telefoneresidencial" class="form-control" maxlength="13" data-mask="(00)0000-0000" value="<?php echo $funcionario['telefone_residencial'] ?>">
                            </div>

                            <div class="col-md-2">
                              <label for="status" class="form-label">Status</label>
                              <select name="status" id="status" class="form-select">
                                <option value="1" <?php if ($funcionario['status'] == '1') echo 'selected' ?>>Ativo</option>
                                <option value="0" <?php if ($funcionario['status'] == '0') echo 'selected' ?>>Inativo</option>
                              </select>
                            </div>

                            <div class="col-md-2">
                              <label for="datacadastro" class="form-label">Cadastro</label>
                              <input type="date" name="datacadastro" id="datacadastro" class="form-control" disabled value="<?php echo date('Y-m-d', strtotime($funcionario['data_cadastro'])) ?>">
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
                              <input type="text" name="cep" id="cep" class="form-control" maxlength="9" data-mask="00000-000" value="<?php echo $funcionario['cep'] ?>" required>
                            </div>

                            <div class="col-md-5">
                              <label for="rua" class="form-label"><strong class="text-danger">*</strong> Rua</label>
                              <input type="text" name="rua" id="rua" class="form-control" maxlength="70" value="<?php echo $funcionario['endereco'] ?>" required>
                            </div>

                            <div class="col-md-2">
                              <label for="numero" class="form-label"><strong class="text-danger">*</strong> Número</label>
                              <input type="text" name="numero" id="numero" class="form-control" maxlength="4" value="<?php echo $funcionario['numero'] ?>" required>
                            </div>

                            <div class="col-md-2">
                              <label for="complemento" class="form-label">Complemento</label>
                              <input type="text" name="complemento" id="complemento" class="form-control" maxlength="40" value="<?php echo $funcionario['complemento'] ?>">
                            </div>

                            <div class="col-md-4">
                              <label for="bairro" class="form-label"><strong class="text-danger">*</strong> Bairro</label>
                              <input type="text" name="bairro" id="bairro" class="form-control" maxlength="30" value="<?php echo $funcionario['bairro'] ?>" required>
                            </div>

                            <div class="col-md-4">
                              <label for="cidade" class="form-label"><strong class="text-danger">*</strong> Cidade</label>
                              <input type="text" name="cidade" id="cidade" class="form-control" maxlength="40" value="<?php echo $funcionario['cidade'] ?>" required>
                            </div>

                            <div class="col-md-4">
                              <label for="estado" class="form-label"><strong class="text-danger">*</strong> Estado</label>
                              <select name="estado" id="estado" class="form-select" required>
                                <option value="AC" <?php echo ($funcionario['estado'] == 'AC') ? 'selected' : ''; ?>>Acre</option>
                                <option value="AL" <?php echo ($funcionario['estado'] == 'AL') ? 'selected' : ''; ?>>Alagoas</option>
                                <option value="AP" <?php echo ($funcionario['estado'] == 'AP') ? 'selected' : ''; ?>>Amapá</option>
                                <option value="AM" <?php echo ($funcionario['estado'] == 'AM') ? 'selected' : ''; ?>>Amazonas</option>
                                <option value="BA" <?php echo ($funcionario['estado'] == 'BA') ? 'selected' : ''; ?>>Bahia</option>
                                <option value="CE" <?php echo ($funcionario['estado'] == 'CE') ? 'selected' : ''; ?>>Ceará</option>
                                <option value="DF" <?php echo ($funcionario['estado'] == 'DF') ? 'selected' : ''; ?>>Distrito Federal</option>
                                <option value="ES" <?php echo ($funcionario['estado'] == 'ES') ? 'selected' : ''; ?>>Espírito Santo</option>
                                <option value="GO" <?php echo ($funcionario['estado'] == 'GO') ? 'selected' : ''; ?>>Goiás</option>
                                <option value="MA" <?php echo ($funcionario['estado'] == 'MA') ? 'selected' : ''; ?>>Maranhão</option>
                                <option value="MT" <?php echo ($funcionario['estado'] == 'MT') ? 'selected' : ''; ?>>Mato Grosso</option>
                                <option value="MS" <?php echo ($funcionario['estado'] == 'MS') ? 'selected' : ''; ?>>Mato Grosso do Sul</option>
                                <option value="MG" <?php echo ($funcionario['estado'] == 'MG') ? 'selected' : ''; ?>>Minas Gerais</option>
                                <option value="PA" <?php echo ($funcionario['estado'] == 'PA') ? 'selected' : ''; ?>>Pará</option>
                                <option value="PB" <?php echo ($funcionario['estado'] == 'PB') ? 'selected' : ''; ?>>Paraíba</option>
                                <option value="PR" <?php echo ($funcionario['estado'] == 'PR') ? 'selected' : ''; ?>>Paraná</option>
                                <option value="PE" <?php echo ($funcionario['estado'] == 'PE') ? 'selected' : ''; ?>>Pernambuco</option>
                                <option value="PI" <?php echo ($funcionario['estado'] == 'PI') ? 'selected' : ''; ?>>Piauí</option>
                                <option value="RJ" <?php echo ($funcionario['estado'] == 'RJ') ? 'selected' : ''; ?>>Rio de Janeiro</option>
                                <option value="RN" <?php echo ($funcionario['estado'] == 'RN') ? 'selected' : ''; ?>>Rio Grande do Norte</option>
                                <option value="RS" <?php echo ($funcionario['estado'] == 'RS') ? 'selected' : ''; ?>>Rio Grande do Sul</option>
                                <option value="RO" <?php echo ($funcionario['estado'] == 'RO') ? 'selected' : ''; ?>>Rondônia</option>
                                <option value="RR" <?php echo ($funcionario['estado'] == 'RR') ? 'selected' : ''; ?>>Roraima</option>
                                <option value="SC" <?php echo ($funcionario['estado'] == 'SC') ? 'selected' : ''; ?>>Santa Catarina</option>
                                <option value="SP" <?php echo ($funcionario['estado'] == 'SP') ? 'selected' : ''; ?>>São Paulo</option>
                                <option value="SE" <?php echo ($funcionario['estado'] == 'SE') ? 'selected' : ''; ?>>Sergipe</option>
                                <option value="TO" <?php echo ($funcionario['estado'] == 'TO') ? 'selected' : ''; ?>>Tocantins</option>
                              </select>
                            </div>

                          </div>
                        </div>
                      </div>

                      <!-- CREDENCIAIS E SALÁRIO -->
                      <div class="card text-bg-dark">
                        <div class="card-header fw-semibold">
                          Credenciais e Salário
                        </div>
                        <div class="card-body">
                          <div class="row g-3">

                            <div class="col-md-4">
                              <label for="usuario" class="form-label"><strong class="text-danger">*</strong> Usuário</label>
                              <input type="text" name="usuario" id="usuario" class="form-control" maxlength="15" value="<?php echo $funcionario['usuario'] ?>" required>
                            </div>

                            <div class="col-md-4">
                              <label for="senha" class="form-label"><strong class="text-danger">*</strong> Senha</label>
                              <input type="password" name="senha" id="senha" class="form-control" maxlength="10" value="<?php echo $funcionario['senha'] ?>" required>
                            </div>

                            <div class="col-md-4">
                              <label for="acesso" class="form-label"><strong class="text-danger">*</strong> Tipo de acesso</label>
                              <select name="acesso" id="acesso" class="form-select" required>
                                <option value="0" <?php if ($funcionario['tipo_acesso'] == 0) echo 'selected' ?>>Comum</option>
                                <option value="1" <?php if ($funcionario['tipo_acesso'] == 1) echo 'selected' ?>>Administrador</option>
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

                                ?>

                                  <option value="<?php echo $cargo['id_cargo'] ?>" <?php if ($funcionario['id_cargo'] == $cargo['id_cargo']) echo 'selected' ?>>
                                    <?php echo $cargo['nome'] ?>
                                  </option>

                                <?php
                                }
                                ?>

                              </select>
                            </div>

                            <div class="col-md-6">
                              <label for="salario" class="form-label"><strong class="text-danger">*</strong> Salário</label>
                              <div class="input-group">
                                <span class="input-group-text">R$</span>
                                <!-- DATA-MASK REVERSE SERVE PRA COLOCAR A VIRUGULA DEPOIS DOS 3 PRIMEIROS NUMEROS -->
                                <input type="decimal" name="salario" id="salario" class="form-control" data-mask="00000,00" data-mask-reverse="true" value="<?php echo $funcionario['salario'] ?>" required>
                              </div>
                            </div>

                          </div>
                        </div>
                      </div>

                      <!-- Mudar para editar -->
                      <input type="hidden" name="editar" value="editar_funcionario">
                      <!-- ESCONDER O ID -->
                      <input type="hidden" name="id_funcionario" value="<?php echo $id ?>">

                      <div class="d-flex justify-content-end">
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
                  Funcionário não encontrado
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
  <script src="../../custom/js/inputimg.js"></script>
  


</body>

</html>