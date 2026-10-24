<?php 

  require __DIR__ . "/Navdinacima.php"

?>

<nav id="sidebarMenu" class="col-md-3 col-lg-2 d-md-block bg-dark sidebar collapse">
  <div class="position-sticky pt-3">
    
    
    <ul class="nav flex-column">
      <li class="nav-item">
        <a class="nav-link text-white d-flex gap-2" href="<?php echo $url?>/admin.php">
          <i class="bi bi-house-door-fill"></i>
          Início
        </a>
      </li>

      <li class="nav-item">
        <a class="nav-link text-white d-flex gap-2" href="<?php echo $url?>/cargos/">
          <i class="bi bi-person-fill-gear"></i>
          Cargos
        </a>
      </li>

      <li class="nav-item">
        <a class="nav-link text-white d-flex gap-2" href="<?php echo $url ?>/funcionarios/">
          <i class="bi bi-person-vcard-fill"></i>
          Funcionários
        </a>
      </li>
      
      <li class="nav-item">
        <a class="nav-link text-white d-flex gap-2" href="<?php echo $url ?>/categorias/">
          <i class="bi bi-stack"></i>
          Categorias
        </a>
      </li>

      <li class="nav-item">
        <a class="nav-link text-white d-flex gap-2" href="<?php echo $url ?>/marcas/">
          <i class="bi bi-bag-fill"></i>
          Marcas
        </a>
      </li>
      
      <li class="nav-item">
        <a class="nav-link text-white d-flex gap-2" href="<?php echo $url ?>/produtos/">
          <i class="bi bi-archive-fill"></i>
          Produtos
        </a>
      </li>

      <li class="nav-item">
        <a class="nav-link text-white d-flex gap-2" href="<?php echo $url ?>/clientes/">
          <i class="bi bi-people-fill"></i>
          Clientes
        </a>
      </li>

      <li class="nav-item">
        <a class="nav-link text-white d-flex gap-2" href="<?php echo $url ?>/fornecedores/">
         <i class="bi-box-seam-fill"></i>
          Fornecedores
        </a>
      </li>
    </ul>
  </div>
</nav>