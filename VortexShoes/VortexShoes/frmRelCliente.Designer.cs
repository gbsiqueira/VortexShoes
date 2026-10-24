
namespace VortexShoes
{
    partial class frmRelCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelCliente));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnfechar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblsubtitulo = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtidade2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtidade1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblateidade = new System.Windows.Forms.Label();
            this.lbldeidade = new System.Windows.Forms.Label();
            this.ckdata = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimparFlitros = new Guna.UI2.WinForms.Guna2Button();
            this.cmbsexo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel9 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbstatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbcidade = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblate = new System.Windows.Forms.Label();
            this.dtpDataFinal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpDataInicial = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblde = new System.Windows.Forms.Label();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rptcliente = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.classClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // classClienteBindingSource
            // 
            this.classClienteBindingSource.DataSource = typeof(VortexShoes.classCliente);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnfechar
            // 
            this.btnfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfechar.Animated = true;
            this.btnfechar.FillColor = System.Drawing.Color.Black;
            this.btnfechar.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnfechar.HoverState.IconColor = System.Drawing.Color.Red;
            this.btnfechar.IconColor = System.Drawing.Color.White;
            this.btnfechar.Location = new System.Drawing.Point(926, 6);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(45, 29);
            this.btnfechar.TabIndex = 148;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 147;
            this.pictureBox2.TabStop = false;
            // 
            // lblsubtitulo
            // 
            this.lblsubtitulo.AutoSize = true;
            this.lblsubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblsubtitulo.Location = new System.Drawing.Point(85, 63);
            this.lblsubtitulo.Name = "lblsubtitulo";
            this.lblsubtitulo.Size = new System.Drawing.Size(426, 16);
            this.lblsubtitulo.TabIndex = 146;
            this.lblsubtitulo.Text = "Faça um relatório de cliente com as opções de filtros abaixo";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(83, 29);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(210, 29);
            this.lbltitulo.TabIndex = 145;
            this.lbltitulo.Text = "Relatório Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.groupBox1.Controls.Add(this.txtidade2);
            this.groupBox1.Controls.Add(this.txtidade1);
            this.groupBox1.Controls.Add(this.lblateidade);
            this.groupBox1.Controls.Add(this.lbldeidade);
            this.groupBox1.Controls.Add(this.ckdata);
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Controls.Add(this.btnLimparFlitros);
            this.groupBox1.Controls.Add(this.cmbsexo);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel9);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel10);
            this.groupBox1.Controls.Add(this.cmbstatus);
            this.groupBox1.Controls.Add(this.cmbcidade);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel12);
            this.groupBox1.Controls.Add(this.lblate);
            this.groupBox1.Controls.Add(this.dtpDataFinal);
            this.groupBox1.Controls.Add(this.dtpDataInicial);
            this.groupBox1.Controls.Add(this.lblde);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel13);
            this.groupBox1.Location = new System.Drawing.Point(2, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(966, 229);
            this.groupBox1.TabIndex = 144;
            this.groupBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(299, 40);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(43, 20);
            this.guna2HtmlLabel1.TabIndex = 148;
            this.guna2HtmlLabel1.Text = "Idade";
            // 
            // txtidade2
            // 
            this.txtidade2.AutoRoundedCorners = true;
            this.txtidade2.BorderRadius = 12;
            this.txtidade2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidade2.DefaultText = "";
            this.txtidade2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtidade2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtidade2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidade2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidade2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidade2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidade2.ForeColor = System.Drawing.Color.Black;
            this.txtidade2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidade2.Location = new System.Drawing.Point(423, 69);
            this.txtidade2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtidade2.Name = "txtidade2";
            this.txtidade2.PlaceholderText = "";
            this.txtidade2.SelectedText = "";
            this.txtidade2.Size = new System.Drawing.Size(43, 26);
            this.txtidade2.TabIndex = 147;
            this.txtidade2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2TextBox1_KeyPress);
            // 
            // txtidade1
            // 
            this.txtidade1.AutoRoundedCorners = true;
            this.txtidade1.BorderRadius = 12;
            this.txtidade1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidade1.DefaultText = "";
            this.txtidade1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtidade1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtidade1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidade1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidade1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidade1.ForeColor = System.Drawing.Color.Black;
            this.txtidade1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidade1.Location = new System.Drawing.Point(310, 69);
            this.txtidade1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtidade1.Name = "txtidade1";
            this.txtidade1.PlaceholderText = "";
            this.txtidade1.SelectedText = "";
            this.txtidade1.Size = new System.Drawing.Size(43, 26);
            this.txtidade1.TabIndex = 146;
            this.txtidade1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblateidade
            // 
            this.lblateidade.AutoSize = true;
            this.lblateidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblateidade.Location = new System.Drawing.Point(377, 72);
            this.lblateidade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblateidade.Name = "lblateidade";
            this.lblateidade.Size = new System.Drawing.Size(42, 20);
            this.lblateidade.TabIndex = 144;
            this.lblateidade.Text = "Até:";
            // 
            // lbldeidade
            // 
            this.lbldeidade.AutoSize = true;
            this.lbldeidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeidade.Location = new System.Drawing.Point(267, 72);
            this.lbldeidade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbldeidade.Name = "lbldeidade";
            this.lbldeidade.Size = new System.Drawing.Size(37, 20);
            this.lbldeidade.TabIndex = 145;
            this.lbldeidade.Text = "De:";
            // 
            // ckdata
            // 
            this.ckdata.AutoSize = true;
            this.ckdata.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckdata.CheckedState.BorderRadius = 0;
            this.ckdata.CheckedState.BorderThickness = 0;
            this.ckdata.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckdata.ForeColor = System.Drawing.Color.White;
            this.ckdata.Location = new System.Drawing.Point(693, 49);
            this.ckdata.Name = "ckdata";
            this.ckdata.Size = new System.Drawing.Size(15, 14);
            this.ckdata.TabIndex = 143;
            this.ckdata.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckdata.UncheckedState.BorderRadius = 0;
            this.ckdata.UncheckedState.BorderThickness = 0;
            this.ckdata.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckdata.CheckedChanged += new System.EventHandler(this.ckdata_CheckedChanged);
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
            this.btPesquisar.Location = new System.Drawing.Point(554, 163);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.PressedColor = System.Drawing.Color.White;
            this.btPesquisar.Size = new System.Drawing.Size(145, 44);
            this.btPesquisar.TabIndex = 116;
            this.btPesquisar.Text = "Relatório";
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
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
            this.btnLimparFlitros.Location = new System.Drawing.Point(721, 163);
            this.btnLimparFlitros.Name = "btnLimparFlitros";
            this.btnLimparFlitros.PressedColor = System.Drawing.Color.White;
            this.btnLimparFlitros.Size = new System.Drawing.Size(176, 44);
            this.btnLimparFlitros.TabIndex = 133;
            this.btnLimparFlitros.Text = "Limpar Filtros";
            this.btnLimparFlitros.Click += new System.EventHandler(this.btnLimparFlitros_Click);
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
            this.cmbsexo.Location = new System.Drawing.Point(43, 160);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(161, 36);
            this.cmbsexo.TabIndex = 119;
            // 
            // guna2HtmlLabel9
            // 
            this.guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel9.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel9.Location = new System.Drawing.Point(315, 137);
            this.guna2HtmlLabel9.Name = "guna2HtmlLabel9";
            this.guna2HtmlLabel9.Size = new System.Drawing.Size(51, 20);
            this.guna2HtmlLabel9.TabIndex = 132;
            this.guna2HtmlLabel9.Text = "Status";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(43, 134);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(41, 20);
            this.guna2HtmlLabel10.TabIndex = 120;
            this.guna2HtmlLabel10.Text = "Sexo";
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
            this.cmbstatus.Location = new System.Drawing.Point(310, 163);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(161, 36);
            this.cmbstatus.TabIndex = 131;
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
            this.cmbcidade.Location = new System.Drawing.Point(43, 66);
            this.cmbcidade.Name = "cmbcidade";
            this.cmbcidade.Size = new System.Drawing.Size(161, 36);
            this.cmbcidade.TabIndex = 121;
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(43, 40);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(55, 20);
            this.guna2HtmlLabel12.TabIndex = 122;
            this.guna2HtmlLabel12.Text = "Cidade";
            // 
            // lblate
            // 
            this.lblate.AutoSize = true;
            this.lblate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblate.Location = new System.Drawing.Point(732, 85);
            this.lblate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblate.Name = "lblate";
            this.lblate.Size = new System.Drawing.Size(42, 20);
            this.lblate.TabIndex = 46;
            this.lblate.Text = "Até:";
            this.lblate.Visible = false;
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
            this.dtpDataFinal.Location = new System.Drawing.Point(779, 75);
            this.dtpDataFinal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDataFinal.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(130, 43);
            this.dtpDataFinal.TabIndex = 128;
            this.dtpDataFinal.Value = new System.DateTime(2026, 8, 7, 10, 25, 33, 524);
            this.dtpDataFinal.Visible = false;
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
            this.dtpDataInicial.Location = new System.Drawing.Point(587, 75);
            this.dtpDataInicial.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDataInicial.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(128, 43);
            this.dtpDataInicial.TabIndex = 126;
            this.dtpDataInicial.Value = new System.DateTime(2026, 8, 7, 10, 25, 33, 524);
            this.dtpDataInicial.Visible = false;
            // 
            // lblde
            // 
            this.lblde.AutoSize = true;
            this.lblde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblde.Location = new System.Drawing.Point(550, 85);
            this.lblde.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblde.Name = "lblde";
            this.lblde.Size = new System.Drawing.Size(37, 20);
            this.lblde.TabIndex = 46;
            this.lblde.Text = "De:";
            this.lblde.Visible = false;
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(554, 45);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(133, 20);
            this.guna2HtmlLabel13.TabIndex = 127;
            this.guna2HtmlLabel13.Text = "Data Nascimento";
            // 
            // rptcliente
            // 
            this.rptcliente.BackColor = System.Drawing.Color.Black;
            this.rptcliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rptcliente.ForeColor = System.Drawing.Color.White;
            reportDataSource1.Name = "dscliente";
            reportDataSource1.Value = this.classClienteBindingSource;
            this.rptcliente.LocalReport.DataSources.Add(reportDataSource1);
            this.rptcliente.LocalReport.ReportEmbeddedResource = "VortexShoes.RptCliente.rdlc";
            this.rptcliente.Location = new System.Drawing.Point(173, 338);
            this.rptcliente.Name = "rptcliente";
            this.rptcliente.ServerReport.BearerToken = null;
            this.rptcliente.Size = new System.Drawing.Size(638, 457);
            this.rptcliente.TabIndex = 151;
            // 
            // frmRelCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(975, 799);
            this.Controls.Add(this.rptcliente);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblsubtitulo);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRelCliente";
            this.Text = "frmRelCliente";
            this.Load += new System.EventHandler(this.frmRelCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox btnfechar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblsubtitulo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2CheckBox ckdata;
        private Guna.UI2.WinForms.Guna2Button btPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnLimparFlitros;
        public Guna.UI2.WinForms.Guna2ComboBox cmbsexo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel9;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        public Guna.UI2.WinForms.Guna2ComboBox cmbstatus;
        public Guna.UI2.WinForms.Guna2ComboBox cmbcidade;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private System.Windows.Forms.Label lblate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataFinal;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataInicial;
        private System.Windows.Forms.Label lblde;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Microsoft.Reporting.WinForms.ReportViewer rptcliente;
        private System.Windows.Forms.BindingSource classClienteBindingSource;
        private System.Windows.Forms.Label lblateidade;
        private System.Windows.Forms.Label lbldeidade;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2TextBox txtidade2;
        public Guna.UI2.WinForms.Guna2TextBox txtidade1;
    }
}