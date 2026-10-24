<?php

require_once __DIR__ . "/../conexao/conecta.php";

if (!isset($_SESSION)) {
  session_start();
}

if (empty($_SESSION['USER'])) {
  $_SESSION['naoAutorizado'] = "Apenas usuários logados podem acessar esta área";
  header('Location: Index.php');
  exit;
}

$res = mysqli_query($conexao, "SELECT COUNT(*) AS total FROM cliente");
$total_clientes = mysqli_fetch_assoc($res)['total'] ?? 0;

$res = mysqli_query($conexao, "SELECT COUNT(*) AS total FROM produto");
$total_produtos = mysqli_fetch_assoc($res)['total'] ?? 0;

$res = mysqli_query($conexao, "SELECT COUNT(*) AS total FROM categoria");
$total_categorias = mysqli_fetch_assoc($res)['total'] ?? 0;

$res = mysqli_query($conexao, "SELECT COUNT(*) AS total FROM produto WHERE status_produto = 1");
$total_ativos = mysqli_fetch_assoc($res)['total'] ?? 0;

$res = mysqli_query($conexao, "SELECT COUNT(*) AS total_pedidos, SUM(valor_total) AS faturamento_total FROM venda");
$dados_vendas = mysqli_fetch_assoc($res);
$total_pedidos = $dados_vendas['total_pedidos'] ?? 0;
$faturamento_total = $dados_vendas['faturamento_total'] ?? 0;

$barras_labels = [];
$barras_valores = [];
$res = mysqli_query($conexao, "SELECT c.nome_categoria AS categoria, COUNT(p.id_produto) AS qtd 
                               FROM categoria c 
                               LEFT JOIN produto p ON p.id_categoria = c.id_categoria 
                               GROUP BY c.id_categoria, c.nome_categoria");
while ($row = mysqli_fetch_assoc($res)) {
  $barras_labels[] = $row['categoria'];
  $barras_valores[] = (int) $row['qtd'];
}

$rosca_labels = ['Ativos', 'Inativos'];
$rosca_valores = [];
$res_a = mysqli_query($conexao, "SELECT COUNT(*) AS total FROM produto WHERE status_produto = 1");
$rosca_valores[] = (int) (mysqli_fetch_assoc($res_a)['total'] ?? 0);

$res_i = mysqli_query($conexao, "SELECT COUNT(*) AS total FROM produto WHERE status_produto = 0");
$rosca_valores[] = (int) (mysqli_fetch_assoc($res_i)['total'] ?? 0);

$ultimos_clientes = [];
$res = mysqli_query($conexao, "SELECT nome_cliente AS nome, email, DATE_FORMAT(data_cadastro, '%d/%m/%Y') AS data 
                               FROM cliente ORDER BY id_cliente DESC LIMIT 5");
while ($row = mysqli_fetch_assoc($res)) {
  $ultimos_clientes[] = $row;
}

$ultimas_vendas = [];
$res = mysqli_query($conexao, "SELECT id_pedido, DATE_FORMAT(data_pedido, '%d/%m/%Y') AS data, tipo_pagamento, valor_total 
                               FROM venda ORDER BY id_pedido DESC LIMIT 5");
while ($row = mysqli_fetch_assoc($res)) {
  $ultimas_vendas[] = $row;
}

?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>PAINEL ADMINISTRATIVO</title>

  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" crossorigin="anonymous">

  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.13.1/font/bootstrap-icons.min.css">

  <link rel="preconnect" href="https://fonts.googleapis.com">
  <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
  <link href="https://fonts.googleapis.com/css2?family=Anton&family=Inter:wght@300;400;500;600;700&display=swap" rel="stylesheet">

  <link rel="stylesheet" href="../assets/css/dashboard.min.css">
  <link rel="stylesheet" href="../assets/css/styles.min.css">
  <link rel="stylesheet" href="../custom/css/background.css">
  <link rel="stylesheet" href="/VortexShoes/SiteWeb/custom/css/dashboard-admin.css">
  <link rel="stylesheet" href="../custom/css/dash.css">

</head>

<body>

  <?php
  include('Topo.php');
  ?>

  <div class="container-fluid">
    <div class="row">
      <?php
      include('Navegacao.php');
      ?>

      <main class="ms-auto col-lg-10 px-md-4 py-4">
        <?php
        include('Log.php');
        ?>

        <div>
          <?php
          if (isset($_SESSION['naoAdm'])) {
            echo '<div class="alert alert-danger alert-dismissible fade show bg-dark text-white border-secondary" role="alert">';
            echo $_SESSION['naoAdm'];
            echo '<button type="button" class="btn-close btn-close-white" data-bs-dismiss="alert" aria-label="Close"></button>
            </div>';
            unset($_SESSION['naoAdm']);
          }
          ?>
        </div>

        <div class="dash">

          <div class="row g-3 mb-4">

            <div class="col-xl-3 col-md-6">
              <div class="vortex-card-stat destaque">
                <i class="bi bi-currency-dollar"></i>
                <div class="vortex-stat-value">R$ <?php echo number_format($faturamento_total, 2, ',', '.'); ?></div>
                <div class="vortex-stat-label">Faturamento Total</div>
              </div>
            </div>

            <div class="col-xl-3 col-md-6">
              <div class="vortex-card-stat">
                <i class="bi bi-cart-check-fill"></i>
                <div class="vortex-stat-value"><?php echo $total_pedidos; ?></div>
                <div class="vortex-stat-label">Total de Pedidos</div>
              </div>
            </div>

            <div class="col-xl-3 col-md-6">
              <div class="vortex-card-stat">
                <i class="bi bi-people-fill"></i>
                <div class="vortex-stat-value"><?php echo $total_clientes; ?></div>
                <div class="vortex-stat-label">Clientes Cadastrados</div>
              </div>
            </div>

            <div class="col-xl-3 col-md-6">
              <div class="vortex-card-stat">
                <i class="bi bi-bag-fill"></i>
                <div class="vortex-stat-value"><?php echo $total_produtos; ?></div>
                <div class="vortex-stat-label">Produtos Cadastrados</div>
              </div>
            </div>

          </div>

          <div class="row g-3 mb-4">

            <div class="col-xl-8">
              <div class="vortex-panel">
                <h2 class="vortex-panel-title">
                  <span><i class="bi bi-bar-chart-fill me-2"></i> Produtos por Categoria</span>
                </h2>
                <?php if (!empty($barras_valores)) { ?>
                  <div class="vortex-chart-container"><canvas id="graficoBarras"></canvas></div>
                <?php } else { ?>
                  <p class="vortex-empty">Sem dados para mostrar ainda.</p>
                <?php } ?>
              </div>
            </div>

            <div class="col-xl-4">
              <div class="vortex-panel">
                <h2 class="vortex-panel-title">
                  <span><i class="bi bi-pie-chart-fill me-2"></i> Status dos Produtos</span>
                </h2>
                <?php if (!empty($rosca_valores)) { ?>
                  <div class="vortex-chart-container"><canvas id="graficoRosca"></canvas></div>
                <?php } else { ?>
                  <p class="vortex-empty">Sem dados para mostrar ainda.</p>
                <?php } ?>
              </div>
            </div>

          </div>

          <div class="row g-3 mb-4">

            <div class="col-xl-6">
              <div class="vortex-panel">
                <h2 class="vortex-panel-title">
                  <span><i class="bi bi-receipt me-2"></i> Últimas Vendas / Pedidos</span>
                </h2>
                <?php if (!empty($ultimas_vendas)) { ?>
                  <table class="vortex-table">
                    <thead>
                      <tr>
                        <th>Pedido</th>
                        <th>Data</th>
                        <th>Pagamento</th>
                        <th class="text-end">Valor Total</th>
                      </tr>
                    </thead>
                    <tbody>
                      <?php foreach ($ultimas_vendas as $venda) { ?>
                        <tr>
                          <td class="fw-semibold text-white">#<?php echo $venda['id_pedido']; ?></td>
                          <td class="text-muted"><?php echo $venda['data']; ?></td>
                          <td><span class="badge bg-dark border border-secondary text-light"><?php echo htmlspecialchars($venda['tipo_pagamento'] ?? 'Não informado'); ?></span></td>
                          <td class="text-end fw-bold text-white">R$ <?php echo number_format($venda['valor_total'], 2, ',', '.'); ?></td>
                        </tr>
                      <?php } ?>
                    </tbody>
                  </table>
                <?php } else { ?>
                  <p class="vortex-empty">Nenhuma venda registrada ainda.</p>
                <?php } ?>
              </div>
            </div>

            <div class="col-xl-6">
              <div class="vortex-panel">
                <h2 class="vortex-panel-title">
                  <span><i class="bi bi-person-plus-fill me-2"></i> Últimos Clientes</span>
                </h2>
                <?php if (!empty($ultimos_clientes)) { ?>
                  <table class="vortex-table">
                    <thead>
                      <tr>
                        <th>Nome</th>
                        <th>E-mail</th>
                        <th class="text-end">Cadastro</th>
                      </tr>
                    </thead>
                    <tbody>
                      <?php foreach ($ultimos_clientes as $cliente) { ?>
                        <tr>
                          <td class="fw-semibold text-white"><?php echo htmlspecialchars($cliente['nome']); ?></td>
                          <td class="text-muted"><?php echo htmlspecialchars($cliente['email']); ?></td>
                          <td class="text-end text-muted"><?php echo htmlspecialchars($cliente['data']); ?></td>
                        </tr>
                      <?php } ?>
                    </tbody>
                  </table>
                <?php } else { ?>
                  <p class="vortex-empty">Nenhum cliente cadastrado ainda.</p>
                <?php } ?>
              </div>
            </div>

          </div>

        </div>

      </main>

    </div>

  </div>

  <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.7.1/jquery.min.js" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>

  <script src="https://cdn.jsdelivr.net/npm/chart.js@4.4.4/dist/chart.umd.min.js"></script>

  <script>
    Chart.defaults.color = '#9ca3af';
    Chart.defaults.borderColor = 'rgba(255, 255, 255, 0.08)';
    Chart.defaults.font.family = "'Inter', sans-serif";

    <?php if (!empty($barras_valores)) { ?>
      new Chart(document.getElementById('graficoBarras'), {
        type: 'bar',
        data: {
          labels: <?php echo json_encode($barras_labels); ?>,
          datasets: [{
            data: <?php echo json_encode($barras_valores); ?>,
            backgroundColor: '#ffffff',
            borderRadius: 4,
            maxBarThickness: 36
          }]
        },
        options: {
          responsive: true,
          maintainAspectRatio: false,
          plugins: {
            legend: {
              display: false
            }
          },
          scales: {
            x: {
              grid: {
                display: false
              }
            },
            y: {
              beginAtZero: true,
              ticks: {
                precision: 0
              }
            }
          }
        }
      });
    <?php } ?>

    <?php if (!empty($rosca_valores)) { ?>
      new Chart(document.getElementById('graficoRosca'), {
        type: 'doughnut',
        data: {
          labels: <?php echo json_encode($rosca_labels); ?>,
          datasets: [{
            data: <?php echo json_encode($rosca_valores); ?>,
            backgroundColor: ['#ffffff', '#4b5563', '#9ca3af', '#1f2937'],
            borderWidth: 0,
            spacing: 4
          }]
        },
        options: {
          responsive: true,
          maintainAspectRatio: false,
          cutout: '72%',
          plugins: {
            legend: {
              position: 'bottom',
              labels: {
                boxWidth: 12,
                padding: 20
              }
            }
          }
        }
      });
    <?php } ?>
  </script>

</body>

</html>