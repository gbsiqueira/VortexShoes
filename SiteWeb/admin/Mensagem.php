<?php 

  if(isset($_SESSION['mensagem']) && !isset($_SESSION['mensagem_verde']))
  {
    echo '<div class="alert alert-danger alert-dismissible fade show" role="alert">';

      echo $_SESSION['mensagem'];

      echo '<button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
      </div>';

      unset($_SESSION['mensagem']);
  }

  if(isset($_SESSION['mensagem_verde']))
  {
    echo '<div class="alert alert-success alert-dismissible fade show" role="alert">';

      echo $_SESSION['mensagem_verde'];

      echo '<button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
      </div>';

      unset($_SESSION['mensagem_verde']);
  }

  if(isset($_SESSION['mensagem_fk']))
  {
    echo '<div class="alert alert-warning alert-dismissible fade show" role="alert">';

      echo $_SESSION['mensagem_fk'];

      echo '<button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
      </div>';

      unset($_SESSION['mensagem_fk']);
  }
  
  

?>