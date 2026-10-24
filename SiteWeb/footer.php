<footer id="rodape">

    <div class="container-site">

      <div class="logo-footer">

        <a href="index.php"><img src="assets/img/logotipo.png" alt="logotipo"></a>

        <a href="http://instagram.com" target="_blank" rel="noopener noreferrer"><i
            class="fa-brands fa-instagram"></i></a>
        <a href="http://linkedin.com" target="_blank" rel="noopener noreferrer"><i
            class="fa-brands fa-linkedin-in"></i></a>
        <a href="http://github.com/gbsiqueira" target="_blank" rel="noopener noreferrer"><i
            class="fa-brands fa-github"></i></a>
        <a href="http://x.com" target="_blank" rel="noopener noreferrer"><i class="fa-brands fa-x-twitter"></i></a>
      </div>


      <div class="colunas-footer">

        <div class="coluna-footer">

          <h3>Serviços</h3>

          <a href="index.php">Home</a>

          <a href="#">Entregas</a>

          <a href="#">Devoluções</a>

          <a href="#">Pagamentos</a>

          <a href="contato.php">Fale Conosco</a>

        </div>

        <div class="coluna-footer">

          <h3>Institucional</h3>

          <a href="#">Sobre nós</a>

          <a href="contato.php">Contato</a>

          <a href="#">Política de Privacidade</a>

          <a href="#">Termos de Uso</a>


        </div>

        <div class="coluna-footer">

          <?php

          $sql = "SELECT categoria.id_categoria, categoria.nome_categoria, COUNT(produto.id_categoria) FROM categoria INNER JOIN produto ON categoria.id_categoria = produto.id_categoria GROUP BY categoria.id_categoria, categoria.nome_categoria HAVING COUNT(produto.id_categoria) > 0  LIMIT 4";

          $query = mysqli_query($conexao, $sql);


          echo "<h3>Categorias</h3>";

          foreach ($query as $categorias) {

          ?>

            <a href="categorias.php?id_categoria=<?php echo $categorias['id_categoria'] ?>"><?php echo $categorias['nome_categoria'] ?></a>

          <?php

          }

          ?>



        </div>




      </div>

    </div>

    <hr>

    <div class="creditos-footer">

      <div class="copy">2026 &copy; Anchor - Todos os Direitos Reservados</div>

      <div class="desenvolvedor">
        Desenvolvido por <a href="http://github.com/gbsiqueira" target="_blank" rel="noopener noreferrer">Gabriel
          Siqueira</a>
      </div>

    </div>

  </footer>
