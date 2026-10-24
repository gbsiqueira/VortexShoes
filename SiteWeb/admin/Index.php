<?php

// INICIANDO UMA SESSÃO
if (!isset($_SESSION)) {
  session_start();
}

?>


<!DOCTYPE html>
<html lang="pt-br">

<head>

  <meta charset="UTF-8">

  <meta name="viewport" content="width=device-width, initial-scale=1.0">

  <title>PAINEL ADMINISTRATIVO — LOGIN</title>

  <!-- BOOTSTRAP CSS -->
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">

  <!-- BOOTSTRAP ICONS -->
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.13.1/font/bootstrap-icons.min.css">

  <!-- CUSTOMIZAÇÃO DO TEMPLATE -->
  <link rel="stylesheet" href="../assets/css/signin.min.css">
  <link rel="stylesheet" href="../assets/css/styles.min.css">

  <!-- FAVICON -->
  <link rel="shortcut icon" href="../assets/img/favicon.ico" type="image/x-icon">

  <!-- CSS -->
  <link rel="stylesheet" href="../custom/css/login.css">

  <link rel="preconnect" href="https://fonts.googleapis.com">
  <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
  <link href="https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,100..900;1,100..900&display=swap" rel="stylesheet">


</head>

<body>

  <div class="login-page">

    <div class="login-box">

      <!-- LADO ESQUERDO — MARCA -->
      <div class="lado-marca">

        <div class="marca-conteudo">

          

          <h1 class="logo-marca">VortexShoes</h1>

          <p class="texto-marca">
            Gerencie produtos, categorias e clientes da sua loja em um só lugar.
          </p>

        </div>

      </div>

      <!-- LADO DIREITO — FORMULÁRIO -->
      <div class="lado-form">

        <main class="form-signin text-center">

          <h2 class="titulo-login">Painel Administrativo</h2>
          <h3 class="sub-titulo">Faça login para continuar</h3>

          <form action="login.php" method="POST">

            <div class="campo-login mb-3 mt-4">
              <i class="bi bi-person-fill"></i>
              <input type="text" class="form-control" name="usuario" placeholder="Usuário" required>
            </div>

            <div class="campo-login mb-3">
              <i class="bi bi-lock-fill"></i>
              <input type="password" class="form-control" name="senha" placeholder="Senha" required>
            </div>

            <button class="w-100 btn btn-login mt-3" type="submit">
              Entrar
              <i class="bi bi-arrow-right ms-1"></i>
            </button>

          </form>

          <div class="pt-3">

            <?php

            //LOGIN VAZIO
            if (isset($_SESSION['LoginVazio'])) {
              echo '<div class="alert alert-danger alert-dismissible fade show" role="alert">';

              echo $_SESSION['LoginVazio'];

              echo '<button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
      </div>';

              unset($_SESSION['LoginVazio']);
            }

            if (isset($_SESSION['loginErro'])) {
              echo '<div class="alert alert-danger alert-dismissible fade show" role="alert">';

              echo $_SESSION['loginErro'];

              echo '<button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
      </div>';

              unset($_SESSION['loginErro']);
            }


            if (isset($_SESSION['naoAutorizado'])) {
              echo '<div class="alert alert-danger alert-dismissible fade show" role="alert">';

              echo $_SESSION['naoAutorizado'];

              echo '<button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
      </div>';

              unset($_SESSION['naoAutorizado']);
            }


            if (isset($_SESSION['logOFF'])) {
              echo '<div class="alert alert-success alert-dismissible fade show" role="alert">';

              echo $_SESSION['logOFF'];

              echo '<button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
      </div>';

              unset($_SESSION['logOFF']);
            }

            ?>

          </div>

        </main>

      </div>

    </div>

  </div>

  <!-- JQUERY CDN -->
  <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.7.1/jquery.min.js" integrity="sha512-v2CJ7UaYy4JwqLDIrZUI/4hqeoQieOmAZNXBeQyjo21dadnwR+8ZaIJVT8EE2iyI61OV8e6M8PP2/4hpQINQ/g==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
  <!-- BOOTSTRAP JS -->
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>
</body>

</html>