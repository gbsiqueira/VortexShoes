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
    public partial class frmConsCargo : Form
    {
        public frmConsCargo()
        {
            InitializeComponent();
        }

        private void frmConsCategoria_Load(object sender, EventArgs e)
        {
            classCargo cCargo = new classCargo();

            cmbcargo.DataSource = cCargo.CarregarCombo();
            cmbcargo.DisplayMember = "nome";
            cmbcargo.ValueMember = "id_cargo";
            cmbcargo.SelectedIndex = -1;

            cmbstatus.Items.Add("Ativo");
            cmbstatus.Items.Add("Inativo");
            cmbstatus.SelectedIndex = 0;

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classCargo cCargo = new classCargo();

            int id = 0;

            if (cmbcargo.SelectedIndex != -1)
            {
                int.TryParse(cmbcargo.SelectedValue.ToString(), out id);
            }

            int status = 1;

            if(cmbstatus.SelectedIndex == 1)
            {
                status = 0;
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

            dgv.DataSource = cCargo.BuscarCargo(id, status, inicio, fim, ckdata.Checked);
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

        private void btnLimparFlitros_Click(object sender, EventArgs e)
        {
            LimparFiltros();
        }

        private void LimparFiltros()
        {
            cmbstatus.SelectedIndex = 0;
            cmbcargo.SelectedIndex = -1;
            ckdata.Checked = false;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja editar ou excluir o cargo selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes) return;

            classCargo cCargo = new classCargo();

            frmCadCargo fCargo = new frmCadCargo();

            cCargo.BuscarDadosCargo(Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value));

            fCargo.txtnome.Text = cCargo.nome;

            fCargo.txtobs.Text = cCargo.observacao;

            fCargo.txtid.Text = cCargo.id_cargo.ToString();

            fCargo.cargo = cCargo.id_cargo;

            fCargo.data_cadastro = cCargo.data_cadastro;

            fCargo.status = cCargo.status;

            fCargo.tipo_form = "atualização";

            fCargo.ShowDialog();
        }
    }
}
