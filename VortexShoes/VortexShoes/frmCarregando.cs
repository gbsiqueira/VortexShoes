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
    public partial class frmCarregando : Form
    {

        public int tipo_acesso;
        public frmCarregando()
        {
            InitializeComponent();
        }

        private void tmrCarregando_Tick(object sender, EventArgs e)
        {
            guna2CircleProgressBar1.Value += 7;

            lblValor.Text = (Convert.ToInt32(lblValor.Text) + 7).ToString();

            if (guna2CircleProgressBar1.Value >= 100)
            {
                tmrCarregando.Stop();
                this.Close();
                frmPrincipal fPrincipal = new frmPrincipal();
                fPrincipal.tipo_acesso = tipo_acesso;
                fPrincipal.Show();
            }

            
        }

        private void frmCarregando_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            tmrCarregando.Start();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
