using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Imports do LiveCharts v0.9.7
using LiveCharts;
using LiveCharts.Wpf;
using WpfBrushes = System.Windows.Media.Brushes;


namespace VortexShoes
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

            classDashboard cDash = new classDashboard();

            CarregarGraficoBarras();

            lblcadprod.Text = cDash.ContarProdutos().ToString();

            lblcadcli.Text = cDash.ContarClientes().ToString();

            lblvendasem.Text = cDash.VendasSemana().ToString();

            lblprodvendidos.Text = cDash.ProdutosVendidos().ToString();

            lblfornecedoresativos.Text = cDash.FornecedoreAtivo().ToString();

            lblvendashj.Text = cDash.VendasHoje().ToString();

        }

        private DataTable DadosDash()
        {
            string sql = $"SELECT MONTH(data_pedido) AS MesNum, COUNT(*) AS TotalPedidos FROM venda WHERE YEAR(data_pedido) = YEAR(CURDATE()) GROUP BY MONTH(data_pedido) ORDER BY MesNum";

            classConexao cConexao = new classConexao();

            return cConexao.RetornaDados(sql);
        }

        private void CarregarGraficoBarras()
        {

            DataTable vendas = DadosDash();

            double[] meses = new double[12];


            foreach (DataRow linha in vendas.Rows)
            {
                int mes = Convert.ToInt32(linha["MesNum"]);
                double total = Convert.ToDouble(linha["TotalPedidos"]);

               meses[mes - 1] = total;
            }


            var cartesianChart = new LiveCharts.WinForms.CartesianChart
            {
                Dock = DockStyle.Fill,
                BackColor = System.Drawing.Color.Black
            };

            cartesianChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                     Title = "Vendas Vortex",
                    Values = new ChartValues<double>(meses),
                    Fill = WpfBrushes.DodgerBlue,
                    Stroke = WpfBrushes.DeepSkyBlue,
                    MaxColumnWidth = 28,
                    DataLabels = true,
                    Foreground = WpfBrushes.White
                }
            };

            cartesianChart.AxisX.Add(new Axis
            {
                Title = "Meses",
                Labels = new[] { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" },
                Foreground = WpfBrushes.White,                 
                Separator = new Separator
                {
                    Step = 1,                             
                    Stroke = WpfBrushes.Gray                
                }
            });

            cartesianChart.AxisY.Add(new Axis
            {
                Title = "Quantidade",
                MinValue = 0,
                Foreground = WpfBrushes.White,               
                Separator = new Separator
                {
                    Stroke = WpfBrushes.Gray                  
                }
            });

            pnlgrafico.BackColor = System.Drawing.Color.Black;
            pnlgrafico.Controls.Clear();
            pnlgrafico.Controls.Add(cartesianChart);
        }
    }
}