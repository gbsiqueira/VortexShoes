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

  <!-- POPPINS + ANTON -->
  <link rel="preconnect" href="https://fonts.googleapis.com">
  <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
  <link href="https://fonts.googleapis.com/css2?family=Anton&family=Poppins:wght@300;400;500;600;700&display=swap" rel="stylesheet">

  <!-- bootstrap -->
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet"
    integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">

  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.13.1/font/bootstrap-icons.min.css">

  <!-- CSS DA PÁGINA DE CONTATO (carrega por último) -->
  <link rel="stylesheet" href="custom/css/contato.css">

</head>

<body id="contatopage">

  <!-- INCIO CABEÇALHO -->

<?php require_once __DIR__ . "/header.php"?>


  <section id="contato">

    <div class="container">

      <div class="contato-cabecalho mt-4">
        <h1>Fale com a gente</h1>
        <p>Dúvidas sobre pedidos, trocas ou produtos? Escreva pra nós e respondemos em até 1 dia útil.</p>
      </div>

      <div class="row g-5">

        <!-- INFORMAÇÕES DE CONTATO -->
        <div class="col-lg-5">

          <ul class="contato-lista">

            <li>
              <i class="fa-solid fa-envelope"></i>
              <div>
                <strong>E-mail</strong>
                <span>contato@vortexshoes.com.br</span>
              </div>
            </li>

            <li>
              <i class="fa-brands fa-whatsapp"></i>
              <div>
                <strong>WhatsApp</strong>
                <span>(11) 99999-0000</span>
              </div>
            </li>

            <li>
              <i class="fa-solid fa-location-dot"></i>
              <div>
                <strong>Endereço</strong>
                <span>Rua Santa Cruz, 1148 — Piracicaba, SP</span>
              </div>
            </li>

            <li>
              <i class="fa-solid fa-clock"></i>
              <div>
                <strong>Atendimento</strong>
                <span>Segunda a Sábado, das 6h às 18h</span>
              </div>
            </li>

          </ul>

          <div class="contato-redes">
            <a href="http://instagram.com" target="_blank" rel="noopener noreferrer" aria-label="Instagram"><i class="fa-brands fa-instagram"></i></a>
            <a href="http://linkedin.com" target="_blank" rel="noopener noreferrer" aria-label="LinkedIn"><i class="fa-brands fa-linkedin-in"></i></a>
            <a href="http://github.com/gbsiqueira" target="_blank" rel="noopener noreferrer" aria-label="GitHub"><i class="fa-brands fa-github"></i></a>
            <a href="http://x.com" target="_blank" rel="noopener noreferrer" aria-label="X"><i class="fa-brands fa-x-twitter"></i></a>
          </div>

        </div>

        <!-- FORMULÁRIO (ILUSTRATIVO — NÃO ENVIA NADA) -->
        <div class="col-lg-7">

          <form class="contato-form" action="#" method="post" onsubmit="event.preventDefault();">

            <div class="row g-3">

              <div class="col-md-6">
                <label for="nome">Nome</label>
                <input type="text" id="nome" name="nome" class="form-control" placeholder="Seu nome completo">
              </div>

              <div class="col-md-6">
                <label for="email">E-mail</label>
                <input type="email" id="email" name="email" class="form-control" placeholder="voce@email.com">
              </div>

              <div class="col-md-6">
                <label for="telefone">Telefone</label>
                <input type="text" id="telefone" name="telefone" class="form-control" placeholder="(00) 00000-0000">
              </div>

              <div class="col-md-6">
                <label for="assunto">Assunto</label>
                <select id="assunto" name="assunto" class="form-select">
                  <option value="duvida">Dúvida sobre produto</option>
                  <option value="pedido">Meu pedido</option>
                  <option value="troca">Troca ou devolução</option>
                  <option value="outro">Outro assunto</option>
                </select>
              </div>

              <div class="col-12">
                <label for="mensagem">Mensagem</label>
                <textarea id="mensagem" name="mensagem" rows="5" class="form-control" placeholder="Como podemos ajudar?"></textarea>
              </div>

              <div class="col-12">
                <button type="submit" class="botao-contato">Enviar mensagem</button>
              </div>

            </div>

          </form>

        </div>

      </div>

    </div>

  </section>

<?php require_once __DIR__ . "/footer.php"?>

  <!-- LINKANDO JS -->
  <script src="custom/js/javascript.js"></script>

</body>

</html>