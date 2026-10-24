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
    public partial class frmRelCliente : Form
    {
        public frmRelCliente()
        {
            InitializeComponent();
        }

        private void frmRelCliente_Load(object sender, EventArgs e)
        {
            classCliente cCliente = new classCliente();

            cmbcidade.DataSource = cCliente.CarregarComboCons();
            cmbcidade.DisplayMember = "cidade";
            cmbcidade.ValueMember = "cidade";
            cmbcidade.SelectedIndex = -1;

            cmbsexo.Items.Add("Masculino");
            cmbsexo.Items.Add("Feminino");
            cmbsexo.Items.Add("Não Informado");
            cmbsexo.SelectedIndex = -1;

            cmbstatus.Items.Add("Ativo");
            cmbstatus.Items.Add("Inativo");
            cmbstatus.SelectedIndex = 0;

            dtpDataFinal.MaxDate = DateTime.Now;
            dtpDataInicial.MaxDate = DateTime.Now;

            this.rptcliente.RefreshReport();
        }

         private void LimparFiltros()
         {        
            cmbsexo.SelectedIndex = -1;
            cmbstatus.SelectedIndex = 0;
            cmbcidade.SelectedIndex = -1;
            ckdata.Checked = false;
            txtidade1.Clear();
            txtidade2.Clear();
         }

        private void btnLimparFlitros_Click(object sender, EventArgs e)
        {
            LimparFiltros();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                //NAO DEIXA DIGITAR
                e.Handled = true;
            }
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                //NAO DEIXA DIGITAR
                e.Handled = true;
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            lbldeidade.ForeColor = Color.White;
            lblateidade.ForeColor = Color.White;
            lblate.ForeColor = Color.White;
            lblde.ForeColor = Color.White;

            classCliente cCliente = new classCliente();

            int status = 1;

            if(cmbstatus.SelectedIndex == 1)
            {
                status = 0;
            }

            string cidade = null;

            if(cmbcidade.SelectedIndex != -1)
            {
                cidade = cmbcidade.Text;
            }

            string sexo = null;

            if(cmbsexo.SelectedIndex != -1)
            {
                if (cmbsexo.SelectedIndex == 0)
                {
                    sexo = "m";
                }
                else if (cmbsexo.SelectedIndex == 1)
                {
                    sexo = "f";
                }
                else
                {
                    sexo = "n";
                }
            }


            int idade1 = 0;
            int idade2 = 0;

            if(!string.IsNullOrWhiteSpace(txtidade1.Text) && !string.IsNullOrWhiteSpace(txtidade2.Text))
            {
                if(!int.TryParse(txtidade1.Text, out idade1) || !int.TryParse(txtidade2.Text, out idade2))
                {
                    MessageBox.Show("Favor verifique o valor no filtro de idade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblateidade.ForeColor = Color.Red;
                    lbldeidade.ForeColor = Color.Red;
                    lbldeidade.Focus();
                    return;
                }

                if(idade1 > idade2)
                {
                    MessageBox.Show("A idade 1 não deve ser maior que a idade 2!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbldeidade.ForeColor = Color.Red;
                    lblateidade.ForeColor = Color.Red;
                    lbldeidade.Focus();
                    return;
                }
            }


            DateTime inicio = new DateTime(1700, 1, 1);
            DateTime fim = new DateTime(1700, 1, 1);


            if (ckdata.Checked == true)
            {
                inicio = dtpDataInicial.Value;
                fim = dtpDataFinal.Value;

                if (inicio > fim)
                {
                    MessageBox.Show("A data inicial não pode ser maior que a data final!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblate.ForeColor = Color.Red;
                    lblde.ForeColor = Color.Red;
                    return;
                }
            }

            classClienteBindingSource.DataSource = cCliente.BuscarClienteRelatorio(status, cidade, sexo, idade1, idade2, inicio, fim, ckdata.Checked);
            this.rptcliente.RefreshReport();
        }

        private void ckdata_CheckedChanged(object sender, EventArgs e)
        {
            if (ckdata.Checked == true)
            {
                dtpDataFinal.Visible = true;
                dtpDataInicial.Visible = true;
                lblate.Visible = true;
                lblde.Visible = true;
            }
            else
            {
                dtpDataInicial.Visible = false;
                dtpDataFinal.Visible = false;
                lblate.Visible = false;
                lblde.Visible = false;
            }
        }
    }
}
