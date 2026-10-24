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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

       

        private void btnsingin_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrWhiteSpace(txtuser.Text) && string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                lblvalidacao.Text = "Favor insira usuário e senha";
                lblvalidacao.ForeColor = Color.Red;
                return;
            }

            string user = txtuser.Text;
            string pass = txtpassword.Text;

            classFuncionario cFuncionario = new classFuncionario();

            if(cFuncionario.LoginFuncionario(user, pass) == -1)
            {
                lblvalidacao.Text = "Usuário ou senha incorretos!";
                lblvalidacao.ForeColor = Color.Red;
                return;
            }


            this.Hide();
            frmCarregando fCarregando = new frmCarregando();
            frmPrincipal fPrincipal = new frmPrincipal();

            fCarregando.tipo_acesso = cFuncionario.tipo_acesso;

            fCarregando.Show();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
