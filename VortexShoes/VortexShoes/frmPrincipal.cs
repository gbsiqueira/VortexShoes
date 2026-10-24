using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VortexShoes
{
    public partial class frmPrincipal : Form
    {

        public int tipo_acesso;


        public frmPrincipal()
        {
            InitializeComponent();

            OrganizarMenu();
        }

        private void OrganizarMenu()
        {
            pnlMenu.Controls.SetChildIndex(pnlsubrela, 0);
            pnlMenu.Controls.SetChildIndex(btnmenurelatorio, 1);
            pnlMenu.Controls.SetChildIndex(pnlmenuconsulta, 2);
            pnlMenu.Controls.SetChildIndex(btnmenuconsulta, 3);
            pnlMenu.Controls.SetChildIndex(pnlsubcadastrar, 4);
            pnlMenu.Controls.SetChildIndex(btnmenucadastrar, 5);
            pnlMenu.Controls.SetChildIndex(btnmenudash, 6);
        }


        private void tmrPrincipal_Tick(object sender, EventArgs e)
        {
            stsData.Text = DateTime.Now.ToShortDateString();
            stsHora.Text = DateTime.Now.ToShortTimeString();
        }


       

       

       

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDashboard());

            if(tipo_acesso == 0)
            {
                btnfuncionario.Visible = false;
            }
        }

        private Form formularioAtivo = null;

        private void AbrirFormulario(Form formulario)
        {
            //SE FOR DIFERENTE DE NULL APAGA O FURMULÁRIO
            if(formularioAtivo != null)
            {
                formularioAtivo.Close();
            }

            //Atribui o formulario ativo como formulario
            formularioAtivo = formulario;

            //ALTERANDO AS PROPRIEDADES DO FORM
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            pnlAbrirformulario.Controls.Clear();
            pnlAbrirformulario.Controls.Add(formulario);

            //MOSTRANDO O FORMULARIO
            formulario.Show();
        }

        

       

        

        private void btnmenusair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja fazer LogOFF?", "Vorteshoes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Sessão encerrada com Sucesso!", "Vorteshoes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmLogin fLogin = new frmLogin();
                this.Close();
                fLogin.Show();
            }
        }

       

        private void btnmenucad_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCadCliente());
        }

        private void btnescondermenu_Click_1(object sender, EventArgs e)
        {
            slogan.Visible = false;
            nomelogotipo.Visible = false;
            guna2Panel1.Visible = true;
            btnvoltarmenu.Location = new Point(37, 15);
            btnescondermenu.Visible = false;
            btnvoltarmenu.Visible = true;
            guna2Panel1.Width = 68;
            guna2Transition1.ShowSync(guna2Panel1);
            btnmenusair.Text = "";
            btnmenurelatorio.Width = 40;
            btnmenurelatorio.Text = "";
            btncliente.Width = 40;
            btncliente.Text = "";
            btnmenudash.Width = 40;
            btnmenudash.Text = "";
            btncadvenda.Width = 40;
            btncadvenda.Text = "";
            btncargo.Width = 40;
            btncargo.Text = "";

        }

        private void btnvoltarmenu_Click_1(object sender, EventArgs e)
        {
            slogan.Visible = true;
            nomelogotipo.Visible = true;
            btnvoltarmenu.Visible = false;
            btnescondermenu.Visible = true;
            guna2Panel1.Visible = false;
            guna2Panel1.Width = 233;
            guna2Transition1.ShowSync(guna2Panel1);
            btnmenusair.Text = "Sair";
            btnmenudash.Width = 217;
            btnmenudash.Text = "DashBoard";
            btncliente.Width = 217;
            btncliente.Text = "Cadastrar";
            btnmenurelatorio.Width = 217;
            btnmenurelatorio.Text = "Relatório";
            btncargo.Width = 217;
            btncargo.Text = "Consulta";
            btncadvenda.Width = 217;
            btncadvenda.Text = "Venda";

        }

        private void btnmenudash_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDashboard());
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar a aplicação?", "Vorteshoes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnmenuconsulta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCadCargo());
        }

      
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCadFornecedor());

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCadFuncionario());
        }

        private void btnmenucadastrar_Click(object sender, EventArgs e)
        {
            if(pnlsubcadastrar.Visible == false)
            {
                pnlsubcadastrar.Visible = true;
            }
            else
            {
                pnlsubcadastrar.Visible = false;
            }
        }

        private void btncategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCadCategoria());
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCadProduto());
        }

        private void btnconscargo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmConsCargo());
        }

        private void btnmenuconsulta_Click_1(object sender, EventArgs e)
        {
            if(pnlmenuconsulta.Visible == false)
            {
                pnlmenuconsulta.Visible = true;
            }
            else
            {
                pnlmenuconsulta.Visible = false;
            }
        }

        private void btnconscliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmConsCliente());
        }

        private void btnconsfunc_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmConsFuncionario());
        }

        private void btnconsforne_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmConsFornecedor());
        }

        private void btnconsmarca_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmConsMarca());
        }

        private void btnconsprod_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmConsProduto());
        }

        private void btnconscat_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmConsCategoria());
        }

        private void btnmarca_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCadMarca());
        }

        private void btnrelclie_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRelCliente());
        }

        private void btnrelfunc_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRelFuncionario());
        }

        private void btnrelprod_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRelProduto());
        }

        private void btnmenurelatorio_Click(object sender, EventArgs e)
        {
            if (pnlsubrela.Visible == false)
            {
                pnlsubrela.Visible = true;
            }
            else
            {
                pnlsubrela.Visible = false;
            }
        }

        private void btncadvendaa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmVenda());
        }

        private void btnmenusair_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fazer LogOff?", "Vorteshoes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                frmLogin fLogin = new frmLogin();

                this.Close();

                fLogin.Show();

                fLogin.lblvalidacao.Text = "LogOff realizado com sucesso!";
                fLogin.lblvalidacao.ForeColor = Color.Green;
            }
        }
    }
}
