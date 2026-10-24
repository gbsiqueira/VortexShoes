
namespace VortexShoes
{
    partial class frmConsFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsFuncionario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.lblate = new System.Windows.Forms.Label();
            this.lblde = new System.Windows.Forms.Label();
            this.dgvFuncionario = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbsexo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbcidade = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.dtpDataInicial = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpDataFinal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbcargo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbstatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnLimparFlitros = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pctfun = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckdata = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnfechar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblsubtitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctfun)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btPesquisar
            // 
            this.btPesquisar.Animated = true;
            this.btPesquisar.BackColor = System.Drawing.Color.White;
            this.btPesquisar.BorderColor = System.Drawing.Color.White;
            this.btPesquisar.BorderRadius = 8;
            this.btPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPesquisar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btPesquisar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btPesquisar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btPesquisar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btPesquisar.FillColor = System.Drawing.Color.White;
            this.btPesquisar.FocusedColor = System.Drawing.Color.Transparent;
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btPesquisar.HoverState.BorderColor = System.Drawing.Color.White;
            this.btPesquisar.HoverState.FillColor = System.Drawing.Color.White;
            this.btPesquisar.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btPesquisar.Location = new System.Drawing.Point(1022, 213);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.PressedColor = System.Drawing.Color.White;
            this.btPesquisar.Size = new System.Drawing.Size(145, 44);
            this.btPesquisar.TabIndex = 116;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click_1);
            // 
            // lblate
            // 
            this.lblate.AutoSize = true;
            this.lblate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblate.Location = new System.Drawing.Point(765, 223);
            this.lblate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblate.Name = "lblate";
            this.lblate.Size = new System.Drawing.Size(42, 20);
            this.lblate.TabIndex = 46;
            this.lblate.Text = "Até:";
            this.lblate.Visible = false;
            // 
            // lblde
            // 
            this.lblde.AutoSize = true;
            this.lblde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblde.Location = new System.Drawing.Point(583, 223);
            this.lblde.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblde.Name = "lblde";
            this.lblde.Size = new System.Drawing.Size(37, 20);
            this.lblde.TabIndex = 46;
            this.lblde.Text = "De:";
            this.lblde.Visible = false;
            // 
            // dgvFuncionario
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFuncionario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncionario.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFuncionario.ColumnHeadersHeight = 50;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFuncionario.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFuncionario.GridColor = System.Drawing.Color.Black;
            this.dgvFuncionario.Location = new System.Drawing.Point(12, 406);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionario.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFuncionario.RowHeadersVisible = false;
            this.dgvFuncionario.Size = new System.Drawing.Size(1392, 496);
            this.dgvFuncionario.TabIndex = 101;
            this.dgvFuncionario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Black;
            this.dgvFuncionario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFuncionario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dgvFuncionario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFuncionario.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.dgvFuncionario.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvFuncionario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.dgvFuncionario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFuncionario.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvFuncionario.ThemeStyle.ReadOnly = true;
            this.dgvFuncionario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Black;
            this.dgvFuncionario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFuncionario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvFuncionario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dgvFuncionario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellClick);
            // 
            // txtNome
            // 
            this.txtNome.AutoRoundedCorners = true;
            this.txtNome.BorderRadius = 12;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.DefaultText = "";
            this.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.Location = new System.Drawing.Point(45, 116);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "";
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(204, 26);
            this.txtNome.TabIndex = 117;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(45, 90);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 20);
            this.label.TabIndex = 118;
            this.label.Text = "Nome";
            // 
            // cmbsexo
            // 
            this.cmbsexo.AutoRoundedCorners = true;
            this.cmbsexo.BackColor = System.Drawing.Color.Transparent;
            this.cmbsexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbsexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsexo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbsexo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbsexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsexo.ForeColor = System.Drawing.Color.Black;
            this.cmbsexo.ItemHeight = 30;
            this.cmbsexo.Location = new System.Drawing.Point(45, 210);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(161, 36);
            this.cmbsexo.TabIndex = 119;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(45, 184);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(41, 20);
            this.guna2HtmlLabel1.TabIndex = 120;
            this.guna2HtmlLabel1.Text = "Sexo";
            // 
            // cmbcidade
            // 
            this.cmbcidade.AutoRoundedCorners = true;
            this.cmbcidade.BackColor = System.Drawing.Color.Transparent;
            this.cmbcidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbcidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbcidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcidade.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbcidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcidade.ForeColor = System.Drawing.Color.Black;
            this.cmbcidade.ItemHeight = 30;
            this.cmbcidade.Location = new System.Drawing.Point(320, 116);
            this.cmbcidade.Name = "cmbcidade";
            this.cmbcidade.Size = new System.Drawing.Size(161, 36);
            this.cmbcidade.TabIndex = 121;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(320, 90);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(55, 20);
            this.guna2HtmlLabel2.TabIndex = 122;
            this.guna2HtmlLabel2.Text = "Cidade";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 12;
            this.guna2Panel1.Controls.Add(this.mskCpf);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(320, 210);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(120, 31);
            this.guna2Panel1.TabIndex = 125;
            // 
            // mskCpf
            // 
            this.mskCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mskCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCpf.ForeColor = System.Drawing.Color.Black;
            this.mskCpf.Location = new System.Drawing.Point(5, 7);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(112, 17);
            this.mskCpf.TabIndex = 85;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(322, 189);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(41, 18);
            this.lblcpf.TabIndex = 123;
            this.lblcpf.Text = "CPF";
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.BorderRadius = 18;
            this.dtpDataInicial.Checked = true;
            this.dtpDataInicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDataInicial.FillColor = System.Drawing.Color.Black;
            this.dtpDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataInicial.ForeColor = System.Drawing.Color.White;
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(620, 213);
            this.dtpDataInicial.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDataInicial.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(128, 43);
            this.dtpDataInicial.TabIndex = 126;
            this.dtpDataInicial.Value = new System.DateTime(2026, 8, 7, 10, 25, 33, 524);
            this.dtpDataInicial.Visible = false;
            this.dtpDataInicial.ValueChanged += new System.EventHandler(this.dtpDataInicial_ValueChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(587, 183);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(117, 20);
            this.guna2HtmlLabel3.TabIndex = 127;
            this.guna2HtmlLabel3.Text = "Data Admissão";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.BorderRadius = 18;
            this.dtpDataFinal.Checked = true;
            this.dtpDataFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDataFinal.FillColor = System.Drawing.Color.Black;
            this.dtpDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFinal.ForeColor = System.Drawing.Color.White;
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(812, 213);
            this.dtpDataFinal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDataFinal.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(130, 43);
            this.dtpDataFinal.TabIndex = 128;
            this.dtpDataFinal.Value = new System.DateTime(2026, 8, 7, 10, 25, 33, 524);
            this.dtpDataFinal.Visible = false;
            this.dtpDataFinal.ValueChanged += new System.EventHandler(this.dtpDataFinal_ValueChanged);
            // 
            // cmbcargo
            // 
            this.cmbcargo.AutoRoundedCorners = true;
            this.cmbcargo.BackColor = System.Drawing.Color.Transparent;
            this.cmbcargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbcargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbcargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcargo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbcargo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcargo.ForeColor = System.Drawing.Color.Black;
            this.cmbcargo.ItemHeight = 30;
            this.cmbcargo.Location = new System.Drawing.Point(587, 116);
            this.cmbcargo.Name = "cmbcargo";
            this.cmbcargo.Size = new System.Drawing.Size(161, 36);
            this.cmbcargo.TabIndex = 129;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(587, 90);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(49, 20);
            this.guna2HtmlLabel4.TabIndex = 130;
            this.guna2HtmlLabel4.Text = "Cargo";
            // 
            // cmbstatus
            // 
            this.cmbstatus.AutoRoundedCorners = true;
            this.cmbstatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbstatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbstatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstatus.ForeColor = System.Drawing.Color.Black;
            this.cmbstatus.ItemHeight = 30;
            this.cmbstatus.Location = new System.Drawing.Point(859, 116);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(161, 36);
            this.cmbstatus.TabIndex = 131;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(864, 90);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(51, 20);
            this.guna2HtmlLabel5.TabIndex = 132;
            this.guna2HtmlLabel5.Text = "Status";
            // 
            // btnLimparFlitros
            // 
            this.btnLimparFlitros.Animated = true;
            this.btnLimparFlitros.BackColor = System.Drawing.Color.White;
            this.btnLimparFlitros.BorderColor = System.Drawing.Color.White;
            this.btnLimparFlitros.BorderRadius = 8;
            this.btnLimparFlitros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparFlitros.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLimparFlitros.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLimparFlitros.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLimparFlitros.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLimparFlitros.FillColor = System.Drawing.Color.Black;
            this.btnLimparFlitros.FocusedColor = System.Drawing.Color.Transparent;
            this.btnLimparFlitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFlitros.ForeColor = System.Drawing.Color.White;
            this.btnLimparFlitros.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnLimparFlitros.HoverState.FillColor = System.Drawing.Color.Black;
            this.btnLimparFlitros.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLimparFlitros.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparFlitros.Image")));
            this.btnLimparFlitros.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLimparFlitros.Location = new System.Drawing.Point(1189, 213);
            this.btnLimparFlitros.Name = "btnLimparFlitros";
            this.btnLimparFlitros.PressedColor = System.Drawing.Color.White;
            this.btnLimparFlitros.Size = new System.Drawing.Size(176, 44);
            this.btnLimparFlitros.TabIndex = 133;
            this.btnLimparFlitros.Text = "Limpar Filtros";
            this.btnLimparFlitros.Click += new System.EventHandler(this.btnLimparFlitros_Click);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(89, 23);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(287, 31);
            this.guna2HtmlLabel6.TabIndex = 134;
            this.guna2HtmlLabel6.Text = "Consulta de Funcionário";
            // 
            // pctfun
            // 
            this.pctfun.FillColor = System.Drawing.Color.Transparent;
            this.pctfun.Image = ((System.Drawing.Image)(resources.GetObject("pctfun.Image")));
            this.pctfun.ImageRotate = 0F;
            this.pctfun.Location = new System.Drawing.Point(31, 23);
            this.pctfun.Name = "pctfun";
            this.pctfun.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pctfun.Size = new System.Drawing.Size(52, 50);
            this.pctfun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctfun.TabIndex = 135;
            this.pctfun.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckdata);
            this.groupBox1.Controls.Add(this.guna2CirclePictureBox1);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel7);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.btnLimparFlitros);
            this.groupBox1.Controls.Add(this.cmbsexo);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel5);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.groupBox1.Controls.Add(this.cmbstatus);
            this.groupBox1.Controls.Add(this.cmbcidade);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.groupBox1.Controls.Add(this.cmbcargo);
            this.groupBox1.Controls.Add(this.lblcpf);
            this.groupBox1.Controls.Add(this.lblate);
            this.groupBox1.Controls.Add(this.guna2Panel1);
            this.groupBox1.Controls.Add(this.dtpDataFinal);
            this.groupBox1.Controls.Add(this.dtpDataInicial);
            this.groupBox1.Controls.Add(this.lblde);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1382, 288);
            this.groupBox1.TabIndex = 136;
            this.groupBox1.TabStop = false;
            // 
            // ckdata
            // 
            this.ckdata.AutoSize = true;
            this.ckdata.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckdata.CheckedState.BorderRadius = 0;
            this.ckdata.CheckedState.BorderThickness = 0;
            this.ckdata.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckdata.ForeColor = System.Drawing.Color.White;
            this.ckdata.Location = new System.Drawing.Point(708, 187);
            this.ckdata.Name = "ckdata";
            this.ckdata.Size = new System.Drawing.Size(15, 14);
            this.ckdata.TabIndex = 143;
            this.ckdata.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckdata.UncheckedState.BorderRadius = 0;
            this.ckdata.UncheckedState.BorderThickness = 0;
            this.ckdata.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckdata.CheckedChanged += new System.EventHandler(this.ckdata_CheckedChanged);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(45, 29);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(35, 39);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 142;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(84, 34);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(69, 27);
            this.guna2HtmlLabel7.TabIndex = 141;
            this.guna2HtmlLabel7.Text = "Filtros";
            // 
            // btnfechar
            // 
            this.btnfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfechar.Animated = true;
            this.btnfechar.FillColor = System.Drawing.Color.Black;
            this.btnfechar.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnfechar.HoverState.IconColor = System.Drawing.Color.Red;
            this.btnfechar.IconColor = System.Drawing.Color.White;
            this.btnfechar.Location = new System.Drawing.Point(1388, 2);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(45, 29);
            this.btnfechar.TabIndex = 137;
            // 
            // lblsubtitulo
            // 
            this.lblsubtitulo.AutoSize = true;
            this.lblsubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblsubtitulo.Location = new System.Drawing.Point(90, 56);
            this.lblsubtitulo.Name = "lblsubtitulo";
            this.lblsubtitulo.Size = new System.Drawing.Size(421, 16);
            this.lblsubtitulo.TabIndex = 140;
            this.lblsubtitulo.Text = "Utilize os filtros abaixo para fazer uma consulta acumulativa";
            // 
            // frmConsFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1431, 749);
            this.Controls.Add(this.lblsubtitulo);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pctfun);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.dgvFuncionario);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formConsFuncionario52";
            this.Load += new System.EventHandler(this.formConsFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctfun)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblate;
        private System.Windows.Forms.Label lblde;
        private Guna.UI2.WinForms.Guna2DataGridView dgvFuncionario;
        private Guna.UI2.WinForms.Guna2Button btPesquisar;
        public Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2HtmlLabel label;
        public Guna.UI2.WinForms.Guna2ComboBox cmbsexo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2ComboBox cmbcidade;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblcpf;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataInicial;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataFinal;
        public Guna.UI2.WinForms.Guna2ComboBox cmbcargo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        public Guna.UI2.WinForms.Guna2ComboBox cmbstatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button btnLimparFlitros;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pctfun;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ControlBox btnfechar;
        private System.Windows.Forms.Label lblsubtitulo;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2CheckBox ckdata;
    }
}