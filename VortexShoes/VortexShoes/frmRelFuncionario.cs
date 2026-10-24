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
    public partial class frmRelFuncionario : Form
    {
        public frmRelFuncionario()
        {
            InitializeComponent();
        }

        private void formRelFuncionario_Load(object sender, EventArgs e)
        {
            cmbsexo.Items.Add("Masculino");
            cmbsexo.Items.Add("Feminino");
            cmbsexo.Items.Add("Não Informado");
            cmbsexo.SelectedIndex = -1;

            cmbstatus.Items.Add("Ativo");
            cmbstatus.Items.Add("Inativo");
            cmbstatus.SelectedIndex = 0;

            classCargo cCargo = new classCargo();

            //TRAZER ITENS EXTERNOS É O DATASOURCE, E COLOCA O METODO PARA CARREGAR A COMBO
            cmbcargo.DataSource = cCargo.CarregarCombo();
            //O QUE SERA EXIBIDO NA COMBO, COLOQUE O NOME DA COLUNA DO BANCO, TEM QUE SER IGUAL!
            cmbcargo.DisplayMember = "nome";
            //O QUE SERA ARMAZENADO NO BANCO DE DADOS
            cmbcargo.ValueMember = "id_cargo";
            //NAO VIR NENHUMA PRE SELECIONADA
            cmbcargo.SelectedIndex = -1;


            //CARREGAR COMBO CIDADE
            classFuncionario cFuncionario = new classFuncionario();
            cmbcidade.DataSource = cFuncionario.CarregarComboCidadeConsulta();
            cmbcidade.DisplayMember = "cidade";
            cmbcidade.ValueMember = "cidade";
            cmbcidade.SelectedIndex = -1;

            this.rptfunc.RefreshReport();
        }


        private void LimparFiltros()
        {
            cmbsexo.SelectedIndex = -1;
            cmbstatus.SelectedIndex = 0;
            cmbcidade.SelectedIndex = -1;
            cmbcargo.SelectedIndex = -1;
            ckdata.Checked = false;
        }



        

        private void ckdata_CheckedChanged_1(object sender, EventArgs e)
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

        private void btnLimparFlitros_Click(object sender, EventArgs e)
        {
            LimparFiltros();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();

            int status = 1;

            if (cmbstatus.SelectedIndex == 1)
            {
                status = 0;
            }

            string cidade = null;

            if (cmbcidade.SelectedIndex != -1)
            {
                cidade = cmbcidade.Text;
            }

            int cargo = 0;

            if (cmbcargo.SelectedIndex != -1)
            {
                cargo = Convert.ToInt32(cmbcargo.SelectedValue);
            }

            string sexo = null;

            if (cmbsexo.SelectedIndex != -1)
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

            DateTime inicio = new DateTime(1700, 1, 1);
            DateTime fim = new DateTime(1700, 1, 1);


            if (ckdata.Checked == true)
            {
                inicio = dtpDataInicial.Value;
                fim = dtpDataFinal.Value;

                if (inicio > fim)
                {
                    MessageBox.Show("A data inicial não pode ser maior que a data final!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }




            classFuncionarioBindingSource.DataSource = cFuncionario.BuscarFuncionarioRelatorio(status, cidade, cargo, sexo, inicio, fim, ckdata.Checked);
            this.rptfunc.RefreshReport();

        }

       
    }
}
