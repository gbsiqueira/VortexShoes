 <!-- INCIO CABEÇALHO -->

  <header class="topo">

    <!-- MENU  -->
    <div class="MENU-NAVEGACAO">

      <div class="container">

       <a href="index.php" class="d-none d-xl-flex text-decoration-none text-black fw-bolder fs-5" id="logotipoweb">VortexShoes</a>

        <nav>
          <!-- menu mobile vem depois do menu principal -->
          <div class="menu" id="menu-principal">
            <ul>
              <li><a href="index.php">Home</a></li>
              <hr>
              <li><a href="produtos.php">Produtos</a></li>
              <hr>
              <li><a href="contato.php">Contato</a></li>
              <hr>
            </ul>

          </div>

          <div class="menu-mobile d-md-none">
            <span></span>
            <span></span>
            <span></span>
          </div>

        </nav>

         <div class="input-container">
          <i class="fa-solid fa-magnifying-glass"></i>
          <form action="busca.php" method="GET">
          <input type="text" id="search" name="busca" placeholder="Search">
          </form>
        </div>

        <div class="cart-user">

          <div class="cart">

            <a href="#">
              <i class="fa-solid fa-basket-shopping d-flex align-items-center justify-content-center"></i>
            </a>

          </div>

          <div class="user">
            <a href="admin/Index.php"><i class="fa-solid fa-user d-flex align-items-center justify-content-center"></i>
            </a>
          </div>

        </div>

      </div>

    </div>

  </header>
