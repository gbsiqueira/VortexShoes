
namespace VortexShoes
{
    partial class frmRelProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelProduto));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lblsubtitulo = new System.Windows.Forms.Label();
            this.btnfechar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbcor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtvalormax = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtvalmin = new Guna.UI2.WinForms.Guna2TextBox();
            this.btPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.btnLimparFlitros = new Guna.UI2.WinForms.Guna2Button();
            this.cmbcategoria = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbstatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbmarca = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbfornecedor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pctfun = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rtpproduto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.classProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctfun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classProdutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 18;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // lblsubtitulo
            // 
            this.lblsubtitulo.AutoSize = true;
            this.lblsubtitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblsubtitulo.Location = new System.Drawing.Point(71, 45);
            this.lblsubtitulo.Name = "lblsubtitulo";
            this.lblsubtitulo.Size = new System.Drawing.Size(441, 16);
            this.lblsubtitulo.TabIndex = 154;
            this.lblsubtitulo.Text = "Faça um relatório de produtos com as opções de filtros abaixo";
            // 
            // btnfechar
            // 
            this.btnfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfechar.Animated = true;
            this.btnfechar.FillColor = System.Drawing.Color.Black;
            this.btnfechar.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnfechar.HoverState.IconColor = System.Drawing.Color.Red;
            this.btnfechar.IconColor = System.Drawing.Color.White;
            this.btnfechar.Location = new System.Drawing.Point(1057, -1);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(45, 29);
            this.btnfechar.TabIndex = 153;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guna2HtmlLabel13);
            this.groupBox1.Controls.Add(this.cmbcor);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel12);
            this.groupBox1.Controls.Add(this.txtvalormax);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel11);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel10);
            this.groupBox1.Controls.Add(this.txtvalmin);
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Controls.Add(this.btnLimparFlitros);
            this.groupBox1.Controls.Add(this.cmbcategoria);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel5);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.groupBox1.Controls.Add(this.cmbstatus);
            this.groupBox1.Controls.Add(this.cmbmarca);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.groupBox1.Controls.Add(this.cmbfornecedor);
            this.groupBox1.Location = new System.Drawing.Point(7, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1078, 245);
            this.groupBox1.TabIndex = 152;
            this.groupBox1.TabStop = false;
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(30, 139);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(31, 20);
            this.guna2HtmlLabel13.TabIndex = 156;
            this.guna2HtmlLabel13.Text = "Cor";
            // 
            // cmbcor
            // 
            this.cmbcor.AutoRoundedCorners = true;
            this.cmbcor.BackColor = System.Drawing.Color.Transparent;
            this.cmbcor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbcor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbcor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbcor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbcor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcor.ForeColor = System.Drawing.Color.Black;
            this.cmbcor.ItemHeight = 30;
            this.cmbcor.Location = new System.Drawing.Point(30, 165);
            this.cmbcor.Name = "cmbcor";
            this.cmbcor.Size = new System.Drawing.Size(161, 36);
            this.cmbcor.TabIndex = 155;
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(427, 167);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(31, 20);
            this.guna2HtmlLabel12.TabIndex = 153;
            this.guna2HtmlLabel12.Text = "até:";
            // 
            // txtvalormax
            // 
            this.txtvalormax.AutoRoundedCorners = true;
            this.txtvalormax.BorderRadius = 12;
            this.txtvalormax.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtvalormax.DefaultText = "";
            this.txtvalormax.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtvalormax.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtvalormax.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtvalormax.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtvalormax.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtvalormax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalormax.ForeColor = System.Drawing.Color.Black;
            this.txtvalormax.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtvalormax.Location = new System.Drawing.Point(464, 165);
            this.txtvalormax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtvalormax.Name = "txtvalormax";
            this.txtvalormax.PlaceholderText = "";
            this.txtvalormax.SelectedText = "";
            this.txtvalormax.Size = new System.Drawing.Size(134, 26);
            this.txtvalormax.TabIndex = 152;
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(238, 169);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(26, 20);
            this.guna2HtmlLabel11.TabIndex = 151;
            this.guna2HtmlLabel11.Text = "de:";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(271, 139);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(42, 20);
            this.guna2HtmlLabel10.TabIndex = 150;
            this.guna2HtmlLabel10.Text = "Valor";
            // 
            // txtvalmin
            // 
            this.txtvalmin.AutoRoundedCorners = true;
            this.txtvalmin.BorderRadius = 12;
            this.txtvalmin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtvalmin.DefaultText = "";
            this.txtvalmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtvalmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtvalmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtvalmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtvalmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtvalmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalmin.ForeColor = System.Drawing.Color.Black;
            this.txtvalmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtvalmin.Location = new System.Drawing.Point(271, 165);
            this.txtvalmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtvalmin.Name = "txtvalmin";
            this.txtvalmin.PlaceholderText = "";
            this.txtvalmin.SelectedText = "";
            this.txtvalmin.Size = new System.Drawing.Size(134, 26);
            this.txtvalmin.TabIndex = 149;
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
            this.btPesquisar.Location = new System.Drawing.Point(705, 165);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.PressedColor = System.Drawing.Color.White;
            this.btPesquisar.Size = new System.Drawing.Size(145, 44);
            this.btPesquisar.TabIndex = 116;
            this.btPesquisar.Text = "Pesquisar";
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
            this.btnLimparFlitros.Location = new System.Drawing.Point(872, 165);
            this.btnLimparFlitros.Name = "btnLimparFlitros";
            this.btnLimparFlitros.PressedColor = System.Drawing.Color.White;
            this.btnLimparFlitros.Size = new System.Drawing.Size(176, 44);
            this.btnLimparFlitros.TabIndex = 133;
            this.btnLimparFlitros.Text = "Limpar Filtros";
            this.btnLimparFlitros.Click += new System.EventHandler(this.btnLimparFlitros_Click);
            // 
            // cmbcategoria
            // 
            this.cmbcategoria.AutoRoundedCorners = true;
            this.cmbcategoria.BackColor = System.Drawing.Color.Transparent;
            this.cmbcategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbcategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcategoria.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbcategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcategoria.ForeColor = System.Drawing.Color.Black;
            this.cmbcategoria.ItemHeight = 30;
            this.cmbcategoria.Location = new System.Drawing.Point(543, 68);
            this.cmbcategoria.Name = "cmbcategoria";
            this.cmbcategoria.Size = new System.Drawing.Size(161, 36);
            this.cmbcategoria.TabIndex = 119;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(825, 42);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(51, 20);
            this.guna2HtmlLabel5.TabIndex = 132;
            this.guna2HtmlLabel5.Text = "Status";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(543, 42);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(76, 20);
            this.guna2HtmlLabel1.TabIndex = 120;
            this.guna2HtmlLabel1.Text = "Categoria";
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
            this.cmbstatus.Location = new System.Drawing.Point(820, 68);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(161, 36);
            this.cmbstatus.TabIndex = 131;
            // 
            // cmbmarca
            // 
            this.cmbmarca.AutoRoundedCorners = true;
            this.cmbmarca.BackColor = System.Drawing.Color.Transparent;
            this.cmbmarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbmarca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmarca.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbmarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmarca.ForeColor = System.Drawing.Color.Black;
            this.cmbmarca.ItemHeight = 30;
            this.cmbmarca.Location = new System.Drawing.Point(30, 68);
            this.cmbmarca.Name = "cmbmarca";
            this.cmbmarca.Size = new System.Drawing.Size(161, 36);
            this.cmbmarca.TabIndex = 121;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(259, 42);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(90, 20);
            this.guna2HtmlLabel4.TabIndex = 130;
            this.guna2HtmlLabel4.Text = "Fornecedor";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(30, 42);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(50, 20);
            this.guna2HtmlLabel2.TabIndex = 122;
            this.guna2HtmlLabel2.Text = "Marca";
            // 
            // cmbfornecedor
            // 
            this.cmbfornecedor.AutoRoundedCorners = true;
            this.cmbfornecedor.BackColor = System.Drawing.Color.Transparent;
            this.cmbfornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbfornecedor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbfornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfornecedor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbfornecedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbfornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfornecedor.ForeColor = System.Drawing.Color.Black;
            this.cmbfornecedor.ItemHeight = 30;
            this.cmbfornecedor.Location = new System.Drawing.Point(259, 68);
            this.cmbfornecedor.Name = "cmbfornecedor";
            this.cmbfornecedor.Size = new System.Drawing.Size(161, 36);
            this.cmbfornecedor.TabIndex = 129;
            // 
            // pctfun
            // 
            this.pctfun.FillColor = System.Drawing.Color.Transparent;
            this.pctfun.Image = ((System.Drawing.Image)(resources.GetObject("pctfun.Image")));
            this.pctfun.ImageRotate = 0F;
            this.pctfun.Location = new System.Drawing.Point(12, 12);
            this.pctfun.Name = "pctfun";
            this.pctfun.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pctfun.Size = new System.Drawing.Size(52, 50);
            this.pctfun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctfun.TabIndex = 151;
            this.pctfun.TabStop = false;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(70, 12);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(209, 31);
            this.guna2HtmlLabel6.TabIndex = 150;
            this.guna2HtmlLabel6.Text = "Relatório Produto";
            // 
            // rtpproduto
            // 
            this.rtpproduto.BackColor = System.Drawing.Color.Black;
            reportDataSource1.Name = "dsproduto";
            reportDataSource1.Value = this.classProdutoBindingSource;
            this.rtpproduto.LocalReport.DataSources.Add(reportDataSource1);
            this.rtpproduto.LocalReport.ReportEmbeddedResource = "VortexShoes.RptProduto.rdlc";
            this.rtpproduto.Location = new System.Drawing.Point(225, 355);
            this.rtpproduto.Name = "rtpproduto";
            this.rtpproduto.ServerReport.BearerToken = null;
            this.rtpproduto.Size = new System.Drawing.Size(632, 404);
            this.rtpproduto.TabIndex = 155;
            // 
            // classProdutoBindingSource
            // 
            this.classProdutoBindingSource.DataSource = typeof(VortexShoes.classProduto);
            // 
            // frmRelProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1100, 762);
            this.Controls.Add(this.rtpproduto);
            this.Controls.Add(this.lblsubtitulo);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pctfun);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRelProduto";
            this.Load += new System.EventHandler(this.frmRelProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctfun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classProdutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label lblsubtitulo;
        private Guna.UI2.WinForms.Guna2ControlBox btnfechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        public Guna.UI2.WinForms.Guna2ComboBox cmbcor;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        public Guna.UI2.WinForms.Guna2TextBox txtvalormax;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        public Guna.UI2.WinForms.Guna2TextBox txtvalmin;
        private Guna.UI2.WinForms.Guna2Button btPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnLimparFlitros;
        public Guna.UI2.WinForms.Guna2ComboBox cmbcategoria;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2ComboBox cmbstatus;
        public Guna.UI2.WinForms.Guna2ComboBox cmbmarca;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        public Guna.UI2.WinForms.Guna2ComboBox cmbfornecedor;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pctfun;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Microsoft.Reporting.WinForms.ReportViewer rtpproduto;
        private System.Windows.Forms.BindingSource classProdutoBindingSource;
    }
}