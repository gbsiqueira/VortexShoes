
namespace VortexShoes
{
    partial class frmPrincipal
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tmrPrincipal = new System.Windows.Forms.Timer(this.components);
            this.sts = new System.Windows.Forms.StatusStrip();
            this.stsHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsData = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnmenusair = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlsubrela = new Guna.UI2.WinForms.Guna2Panel();
            this.btncadvenda = new Guna.UI2.WinForms.Guna2Button();
            this.btnrelprod = new Guna.UI2.WinForms.Guna2Button();
            this.btnrelfunc = new Guna.UI2.WinForms.Guna2Button();
            this.btnrelclie = new Guna.UI2.WinForms.Guna2Button();
            this.pnlsubcadastrar = new Guna.UI2.WinForms.Guna2Panel();
            this.btncadvendaa = new Guna.UI2.WinForms.Guna2Button();
            this.btncategoria = new Guna.UI2.WinForms.Guna2Button();
            this.btnproduto = new Guna.UI2.WinForms.Guna2Button();
            this.btnmarca = new Guna.UI2.WinForms.Guna2Button();
            this.btnfuncionario = new Guna.UI2.WinForms.Guna2Button();
            this.btnFornecedor = new Guna.UI2.WinForms.Guna2Button();
            this.btncliente = new Guna.UI2.WinForms.Guna2Button();
            this.btncargo = new Guna.UI2.WinForms.Guna2Button();
            this.pnlmenuconsulta = new Guna.UI2.WinForms.Guna2Panel();
            this.btnconsvenda = new Guna.UI2.WinForms.Guna2Button();
            this.btnconscat = new Guna.UI2.WinForms.Guna2Button();
            this.btnconsprod = new Guna.UI2.WinForms.Guna2Button();
            this.btnconsmarca = new Guna.UI2.WinForms.Guna2Button();
            this.btnconsfunc = new Guna.UI2.WinForms.Guna2Button();
            this.btnconsforne = new Guna.UI2.WinForms.Guna2Button();
            this.btnconscliente = new Guna.UI2.WinForms.Guna2Button();
            this.btnconscargo = new Guna.UI2.WinForms.Guna2Button();
            this.btnmenuconsulta = new Guna.UI2.WinForms.Guna2Button();
            this.btnmenurelatorio = new Guna.UI2.WinForms.Guna2Button();
            this.btnmenucadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnmenudash = new Guna.UI2.WinForms.Guna2Button();
            this.slogan = new System.Windows.Forms.Label();
            this.nomelogotipo = new System.Windows.Forms.Label();
            this.logotipo = new System.Windows.Forms.PictureBox();
            this.btnfechar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnmaximizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnminimizar = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlAbrirformulario = new System.Windows.Forms.Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnvoltarmenu = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnescondermenu = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.sts.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlsubrela.SuspendLayout();
            this.pnlsubcadastrar.SuspendLayout();
            this.pnlmenuconsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logotipo)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnvoltarmenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnescondermenu)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrPrincipal
            // 
            this.tmrPrincipal.Enabled = true;
            this.tmrPrincipal.Tick += new System.EventHandler(this.tmrPrincipal_Tick);
            // 
            // sts
            // 
            this.sts.BackColor = System.Drawing.Color.Black;
            this.guna2Transition1.SetDecoration(this.sts, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsHora,
            this.stsData,
            this.stsMensagem});
            this.sts.Location = new System.Drawing.Point(0, 1078);
            this.sts.Name = "sts";
            this.sts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sts.Size = new System.Drawing.Size(1386, 22);
            this.sts.TabIndex = 1;
            // 
            // stsHora
            // 
            this.stsHora.ForeColor = System.Drawing.Color.White;
            this.stsHora.Name = "stsHora";
            this.stsHora.Size = new System.Drawing.Size(135, 17);
            this.stsHora.Text = "toolStripStatusLabel1";
            // 
            // stsData
            // 
            this.stsData.ForeColor = System.Drawing.Color.White;
            this.stsData.Name = "stsData";
            this.stsData.Size = new System.Drawing.Size(135, 17);
            this.stsData.Text = "toolStripStatusLabel2";
            // 
            // stsMensagem
            // 
            this.stsMensagem.ForeColor = System.Drawing.Color.White;
            this.stsMensagem.Name = "stsMensagem";
            this.stsMensagem.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.stsMensagem.Size = new System.Drawing.Size(339, 17);
            this.stsMensagem.Text = "Bem-vindo ao Painel Administrativo da VortexShoes";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind;
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.btnmenusair);
            this.guna2Panel1.Controls.Add(this.pnlMenu);
            this.guna2Panel1.Controls.Add(this.slogan);
            this.guna2Panel1.Controls.Add(this.nomelogotipo);
            this.guna2Panel1.Controls.Add(this.logotipo);
            this.guna2Transition1.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(233, 1078);
            this.guna2Panel1.TabIndex = 5;
            // 
            // btnmenusair
            // 
            this.btnmenusair.Animated = true;
            this.btnmenusair.AutoRoundedCorners = true;
            this.btnmenusair.BorderColor = System.Drawing.Color.White;
            this.btnmenusair.BorderRadius = 20;
            this.btnmenusair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnmenusair, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnmenusair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmenusair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmenusair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmenusair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmenusair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnmenusair.FillColor = System.Drawing.Color.Black;
            this.btnmenusair.FocusedColor = System.Drawing.Color.Transparent;
            this.btnmenusair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnmenusair.ForeColor = System.Drawing.Color.White;
            this.btnmenusair.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnmenusair.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnmenusair.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnmenusair.Image = ((System.Drawing.Image)(resources.GetObject("btnmenusair.Image")));
            this.btnmenusair.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnmenusair.Location = new System.Drawing.Point(0, 1036);
            this.btnmenusair.Name = "btnmenusair";
            this.btnmenusair.PressedColor = System.Drawing.Color.White;
            this.btnmenusair.Size = new System.Drawing.Size(233, 42);
            this.btnmenusair.TabIndex = 80;
            this.btnmenusair.Text = "Sair";
            this.btnmenusair.Click += new System.EventHandler(this.btnmenusair_Click_1);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.pnlsubrela);
            this.pnlMenu.Controls.Add(this.pnlsubcadastrar);
            this.pnlMenu.Controls.Add(this.pnlmenuconsulta);
            this.pnlMenu.Controls.Add(this.btnmenuconsulta);
            this.pnlMenu.Controls.Add(this.btnmenurelatorio);
            this.pnlMenu.Controls.Add(this.btnmenucadastrar);
            this.pnlMenu.Controls.Add(this.btnmenudash);
            this.guna2Transition1.SetDecoration(this.pnlMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlMenu.Location = new System.Drawing.Point(3, 94);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(224, 903);
            this.pnlMenu.TabIndex = 7;
            // 
            // pnlsubrela
            // 
            this.pnlsubrela.Controls.Add(this.btncadvenda);
            this.pnlsubrela.Controls.Add(this.btnrelprod);
            this.pnlsubrela.Controls.Add(this.btnrelfunc);
            this.pnlsubrela.Controls.Add(this.btnrelclie);
            this.guna2Transition1.SetDecoration(this.pnlsubrela, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlsubrela.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlsubrela.Location = new System.Drawing.Point(0, 914);
            this.pnlsubrela.Name = "pnlsubrela";
            this.pnlsubrela.Size = new System.Drawing.Size(224, 184);
            this.pnlsubrela.TabIndex = 77;
            this.pnlsubrela.Visible = false;
            // 
            // btncadvenda
            // 
            this.btncadvenda.Animated = true;
            this.btncadvenda.AutoRoundedCorners = true;
            this.btncadvenda.BorderColor = System.Drawing.Color.White;
            this.btncadvenda.BorderRadius = 21;
            this.btncadvenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btncadvenda, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btncadvenda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncadvenda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncadvenda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncadvenda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncadvenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncadvenda.FillColor = System.Drawing.Color.Black;
            this.btncadvenda.FocusedColor = System.Drawing.Color.Transparent;
            this.btncadvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btncadvenda.ForeColor = System.Drawing.Color.White;
            this.btncadvenda.HoverState.BorderColor = System.Drawing.Color.White;
            this.btncadvenda.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btncadvenda.HoverState.ForeColor = System.Drawing.Color.White;
            this.btncadvenda.Image = ((System.Drawing.Image)(resources.GetObject("btncadvenda.Image")));
            this.btncadvenda.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncadvenda.Location = new System.Drawing.Point(0, 136);
            this.btncadvenda.Name = "btncadvenda";
            this.btncadvenda.PressedColor = System.Drawing.Color.White;
            this.btncadvenda.Size = new System.Drawing.Size(224, 45);
            this.btncadvenda.TabIndex = 68;
            this.btncadvenda.Text = "Venda";
            // 
            // btnrelprod
            // 
            this.btnrelprod.Animated = true;
            this.btnrelprod.AutoRoundedCorners = true;
            this.btnrelprod.BorderColor = System.Drawing.Color.White;
            this.btnrelprod.BorderRadius = 22;
            this.btnrelprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnrelprod, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnrelprod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnrelprod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnrelprod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnrelprod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnrelprod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnrelprod.FillColor = System.Drawing.Color.Black;
            this.btnrelprod.FocusedColor = System.Drawing.Color.Transparent;
            this.btnrelprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnrelprod.ForeColor = System.Drawing.Color.White;
            this.btnrelprod.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnrelprod.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnrelprod.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnrelprod.Image = ((System.Drawing.Image)(resources.GetObject("btnrelprod.Image")));
            this.btnrelprod.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnrelprod.Location = new System.Drawing.Point(0, 90);
            this.btnrelprod.Name = "btnrelprod";
            this.btnrelprod.PressedColor = System.Drawing.Color.White;
            this.btnrelprod.Size = new System.Drawing.Size(224, 46);
            this.btnrelprod.TabIndex = 75;
            this.btnrelprod.Text = "Produto";
            this.btnrelprod.Click += new System.EventHandler(this.btnrelprod_Click);
            // 
            // btnrelfunc
            // 
            this.btnrelfunc.Animated = true;
            this.btnrelfunc.AutoRoundedCorners = true;
            this.btnrelfunc.BorderColor = System.Drawing.Color.White;
            this.btnrelfunc.BorderRadius = 21;
            this.btnrelfunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnrelfunc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnrelfunc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnrelfunc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnrelfunc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnrelfunc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnrelfunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnrelfunc.FillColor = System.Drawing.Color.Black;
            this.btnrelfunc.FocusedColor = System.Drawing.Color.Transparent;
            this.btnrelfunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnrelfunc.ForeColor = System.Drawing.Color.White;
            this.btnrelfunc.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnrelfunc.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnrelfunc.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnrelfunc.Image = ((System.Drawing.Image)(resources.GetObject("btnrelfunc.Image")));
            this.btnrelfunc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnrelfunc.Location = new System.Drawing.Point(0, 45);
            this.btnrelfunc.Name = "btnrelfunc";
            this.btnrelfunc.PressedColor = System.Drawing.Color.White;
            this.btnrelfunc.Size = new System.Drawing.Size(224, 45);
            this.btnrelfunc.TabIndex = 73;
            this.btnrelfunc.Text = "Funcionário";
            this.btnrelfunc.Click += new System.EventHandler(this.btnrelfunc_Click);
            // 
            // btnrelclie
            // 
            this.btnrelclie.Animated = true;
            this.btnrelclie.AutoRoundedCorners = true;
            this.btnrelclie.BorderColor = System.Drawing.Color.White;
            this.btnrelclie.BorderRadius = 21;
            this.btnrelclie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnrelclie, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnrelclie.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnrelclie.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnrelclie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnrelclie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnrelclie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnrelclie.FillColor = System.Drawing.Color.Black;
            this.btnrelclie.FocusedColor = System.Drawing.Color.Transparent;
            this.btnrelclie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnrelclie.ForeColor = System.Drawing.Color.White;
            this.btnrelclie.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnrelclie.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnrelclie.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnrelclie.Image = ((System.Drawing.Image)(resources.GetObject("btnrelclie.Image")));
            this.btnrelclie.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnrelclie.Location = new System.Drawing.Point(0, 0);
            this.btnrelclie.Name = "btnrelclie";
            this.btnrelclie.PressedColor = System.Drawing.Color.White;
            this.btnrelclie.Size = new System.Drawing.Size(224, 45);
            this.btnrelclie.TabIndex = 64;
            this.btnrelclie.Text = "Cliente";
            this.btnrelclie.Click += new System.EventHandler(this.btnrelclie_Click);
            // 
            // pnlsubcadastrar
            // 
            this.pnlsubcadastrar.Controls.Add(this.btncadvendaa);
            this.pnlsubcadastrar.Controls.Add(this.btncategoria);
            this.pnlsubcadastrar.Controls.Add(this.btnproduto);
            this.pnlsubcadastrar.Controls.Add(this.btnmarca);
            this.pnlsubcadastrar.Controls.Add(this.btnfuncionario);
            this.pnlsubcadastrar.Controls.Add(this.btnFornecedor);
            this.pnlsubcadastrar.Controls.Add(this.btncliente);
            this.pnlsubcadastrar.Controls.Add(this.btncargo);
            this.guna2Transition1.SetDecoration(this.pnlsubcadastrar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlsubcadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlsubcadastrar.Location = new System.Drawing.Point(0, 548);
            this.pnlsubcadastrar.Name = "pnlsubcadastrar";
            this.pnlsubcadastrar.Size = new System.Drawing.Size(224, 366);
            this.pnlsubcadastrar.TabIndex = 71;
            this.pnlsubcadastrar.Visible = false;
            // 
            // btncadvendaa
            // 
            this.btncadvendaa.Animated = true;
            this.btncadvendaa.AutoRoundedCorners = true;
            this.btncadvendaa.BorderColor = System.Drawing.Color.White;
            this.btncadvendaa.BorderRadius = 22;
            this.btncadvendaa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btncadvendaa, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btncadvendaa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncadvendaa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncadvendaa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncadvendaa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncadvendaa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncadvendaa.FillColor = System.Drawing.Color.Black;
            this.btncadvendaa.FocusedColor = System.Drawing.Color.Transparent;
            this.btncadvendaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btncadvendaa.ForeColor = System.Drawing.Color.White;
            this.btncadvendaa.HoverState.BorderColor = System.Drawing.Color.White;
            this.btncadvendaa.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btncadvendaa.HoverState.ForeColor = System.Drawing.Color.White;
            this.btncadvendaa.Image = ((System.Drawing.Image)(resources.GetObject("btncadvendaa.Image")));
            this.btncadvendaa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncadvendaa.Location = new System.Drawing.Point(0, 320);
            this.btncadvendaa.Name = "btncadvendaa";
            this.btncadvendaa.PressedColor = System.Drawing.Color.White;
            this.btncadvendaa.Size = new System.Drawing.Size(224, 46);
            this.btncadvendaa.TabIndex = 77;
            this.btncadvendaa.Text = "Venda";
            this.btncadvendaa.Click += new System.EventHandler(this.btncadvendaa_Click);
            // 
            // btncategoria
            // 
            this.btncategoria.Animated = true;
            this.btncategoria.AutoRoundedCorners = true;
            this.btncategoria.BorderColor = System.Drawing.Color.White;
            this.btncategoria.BorderRadius = 22;
            this.btncategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btncategoria, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btncategoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncategoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncategoria.FillColor = System.Drawing.Color.Black;
            this.btncategoria.FocusedColor = System.Drawing.Color.Transparent;
            this.btncategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btncategoria.ForeColor = System.Drawing.Color.White;
            this.btncategoria.HoverState.BorderColor = System.Drawing.Color.White;
            this.btncategoria.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btncategoria.HoverState.ForeColor = System.Drawing.Color.White;
            this.btncategoria.Image = ((System.Drawing.Image)(resources.GetObject("btncategoria.Image")));
            this.btncategoria.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncategoria.Location = new System.Drawing.Point(0, 274);
            this.btncategoria.Name = "btncategoria";
            this.btncategoria.PressedColor = System.Drawing.Color.White;
            this.btncategoria.Size = new System.Drawing.Size(224, 46);
            this.btncategoria.TabIndex = 76;
            this.btncategoria.Text = "Categoria";
            this.btncategoria.Click += new System.EventHandler(this.btncategoria_Click);
            // 
            // btnproduto
            // 
            this.btnproduto.Animated = true;
            this.btnproduto.AutoRoundedCorners = true;
            this.btnproduto.BorderColor = System.Drawing.Color.White;
            this.btnproduto.BorderRadius = 22;
            this.btnproduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnproduto, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnproduto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnproduto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnproduto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnproduto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnproduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnproduto.FillColor = System.Drawing.Color.Black;
            this.btnproduto.FocusedColor = System.Drawing.Color.Transparent;
            this.btnproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnproduto.ForeColor = System.Drawing.Color.White;
            this.btnproduto.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnproduto.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnproduto.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnproduto.Image = ((System.Drawing.Image)(resources.GetObject("btnproduto.Image")));
            this.btnproduto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnproduto.Location = new System.Drawing.Point(0, 228);
            this.btnproduto.Name = "btnproduto";
            this.btnproduto.PressedColor = System.Drawing.Color.White;
            this.btnproduto.Size = new System.Drawing.Size(224, 46);
            this.btnproduto.TabIndex = 75;
            this.btnproduto.Text = "Produto";
            this.btnproduto.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // btnmarca
            // 
            this.btnmarca.Animated = true;
            this.btnmarca.AutoRoundedCorners = true;
            this.btnmarca.BorderColor = System.Drawing.Color.White;
            this.btnmarca.BorderRadius = 22;
            this.btnmarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnmarca, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnmarca.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmarca.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmarca.FillColor = System.Drawing.Color.Black;
            this.btnmarca.FocusedColor = System.Drawing.Color.Transparent;
            this.btnmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnmarca.ForeColor = System.Drawing.Color.White;
            this.btnmarca.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnmarca.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnmarca.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnmarca.Image = ((System.Drawing.Image)(resources.GetObject("btnmarca.Image")));
            this.btnmarca.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnmarca.Location = new System.Drawing.Point(0, 182);
            this.btnmarca.Name = "btnmarca";
            this.btnmarca.PressedColor = System.Drawing.Color.White;
            this.btnmarca.Size = new System.Drawing.Size(224, 46);
            this.btnmarca.TabIndex = 74;
            this.btnmarca.Text = "Marca";
            this.btnmarca.Click += new System.EventHandler(this.btnmarca_Click);
            // 
            // btnfuncionario
            // 
            this.btnfuncionario.Animated = true;
            this.btnfuncionario.AutoRoundedCorners = true;
            this.btnfuncionario.BorderColor = System.Drawing.Color.White;
            this.btnfuncionario.BorderRadius = 21;
            this.btnfuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnfuncionario, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnfuncionario.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfuncionario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfuncionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfuncionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnfuncionario.FillColor = System.Drawing.Color.Black;
            this.btnfuncionario.FocusedColor = System.Drawing.Color.Transparent;
            this.btnfuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnfuncionario.ForeColor = System.Drawing.Color.White;
            this.btnfuncionario.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnfuncionario.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnfuncionario.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnfuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnfuncionario.Image")));
            this.btnfuncionario.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnfuncionario.Location = new System.Drawing.Point(0, 137);
            this.btnfuncionario.Name = "btnfuncionario";
            this.btnfuncionario.PressedColor = System.Drawing.Color.White;
            this.btnfuncionario.Size = new System.Drawing.Size(224, 45);
            this.btnfuncionario.TabIndex = 73;
            this.btnfuncionario.Text = "Funcionário";
            this.btnfuncionario.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Animated = true;
            this.btnFornecedor.AutoRoundedCorners = true;
            this.btnFornecedor.BorderColor = System.Drawing.Color.White;
            this.btnFornecedor.BorderRadius = 22;
            this.btnFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnFornecedor, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnFornecedor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFornecedor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFornecedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFornecedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFornecedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFornecedor.FillColor = System.Drawing.Color.Black;
            this.btnFornecedor.FocusedColor = System.Drawing.Color.Transparent;
            this.btnFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnFornecedor.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnFornecedor.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnFornecedor.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedor.Image")));
            this.btnFornecedor.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFornecedor.Location = new System.Drawing.Point(0, 91);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.PressedColor = System.Drawing.Color.White;
            this.btnFornecedor.Size = new System.Drawing.Size(224, 46);
            this.btnFornecedor.TabIndex = 72;
            this.btnFornecedor.Text = "Fornecedor";
            this.btnFornecedor.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btncliente
            // 
            this.btncliente.Animated = true;
            this.btncliente.AutoRoundedCorners = true;
            this.btncliente.BorderColor = System.Drawing.Color.White;
            this.btncliente.BorderRadius = 21;
            this.btncliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btncliente, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btncliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncliente.FillColor = System.Drawing.Color.Black;
            this.btncliente.FocusedColor = System.Drawing.Color.Transparent;
            this.btncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btncliente.ForeColor = System.Drawing.Color.White;
            this.btncliente.HoverState.BorderColor = System.Drawing.Color.White;
            this.btncliente.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btncliente.HoverState.ForeColor = System.Drawing.Color.White;
            this.btncliente.Image = ((System.Drawing.Image)(resources.GetObject("btncliente.Image")));
            this.btncliente.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncliente.Location = new System.Drawing.Point(0, 46);
            this.btncliente.Name = "btncliente";
            this.btncliente.PressedColor = System.Drawing.Color.White;
            this.btncliente.Size = new System.Drawing.Size(224, 45);
            this.btncliente.TabIndex = 64;
            this.btncliente.Text = "Cliente";
            this.btncliente.Click += new System.EventHandler(this.btnmenucad_Click);
            // 
            // btncargo
            // 
            this.btncargo.Animated = true;
            this.btncargo.AutoRoundedCorners = true;
            this.btncargo.BorderColor = System.Drawing.Color.White;
            this.btncargo.BorderRadius = 22;
            this.btncargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btncargo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btncargo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncargo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncargo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncargo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncargo.FillColor = System.Drawing.Color.Black;
            this.btncargo.FocusedColor = System.Drawing.Color.Transparent;
            this.btncargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btncargo.ForeColor = System.Drawing.Color.White;
            this.btncargo.HoverState.BorderColor = System.Drawing.Color.White;
            this.btncargo.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btncargo.HoverState.ForeColor = System.Drawing.Color.White;
            this.btncargo.Image = ((System.Drawing.Image)(resources.GetObject("btncargo.Image")));
            this.btncargo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncargo.Location = new System.Drawing.Point(0, 0);
            this.btncargo.Name = "btncargo";
            this.btncargo.PressedColor = System.Drawing.Color.White;
            this.btncargo.Size = new System.Drawing.Size(224, 46);
            this.btncargo.TabIndex = 65;
            this.btncargo.Text = "Cargo";
            this.btncargo.Click += new System.EventHandler(this.btnmenuconsulta_Click);
            // 
            // pnlmenuconsulta
            // 
            this.pnlmenuconsulta.Controls.Add(this.btnconsvenda);
            this.pnlmenuconsulta.Controls.Add(this.btnconscat);
            this.pnlmenuconsulta.Controls.Add(this.btnconsprod);
            this.pnlmenuconsulta.Controls.Add(this.btnconsmarca);
            this.pnlmenuconsulta.Controls.Add(this.btnconsfunc);
            this.pnlmenuconsulta.Controls.Add(this.btnconsforne);
            this.pnlmenuconsulta.Controls.Add(this.btnconscliente);
            this.pnlmenuconsulta.Controls.Add(this.btnconscargo);
            this.guna2Transition1.SetDecoration(this.pnlmenuconsulta, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlmenuconsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlmenuconsulta.Location = new System.Drawing.Point(0, 181);
            this.pnlmenuconsulta.Name = "pnlmenuconsulta";
            this.pnlmenuconsulta.Size = new System.Drawing.Size(224, 367);
            this.pnlmenuconsulta.TabIndex = 77;
            this.pnlmenuconsulta.Visible = false;
            // 
            // btnconsvenda
            // 
            this.btnconsvenda.Animated = true;
            this.btnconsvenda.AutoRoundedCorners = true;
            this.btnconsvenda.BorderColor = System.Drawing.Color.White;
            this.btnconsvenda.BorderRadius = 22;
            this.btnconsvenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnconsvenda, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnconsvenda.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnconsvenda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnconsvenda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnconsvenda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnconsvenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnconsvenda.FillColor = System.Drawing.Color.Black;
            this.btnconsvenda.FocusedColor = System.Drawing.Color.Transparent;
            this.btnconsvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnconsvenda.ForeColor = System.Drawing.Color.White;
            this.btnconsvenda.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnconsvenda.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnconsvenda.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnconsvenda.Image = ((System.Drawing.Image)(resources.GetObject("btnconsvenda.Image")));
            this.btnconsvenda.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnconsvenda.Location = new System.Drawing.Point(0, 320);
            this.btnconsvenda.Name = "btnconsvenda";
            this.btnconsvenda.PressedColor = System.Drawing.Color.White;
            this.btnconsvenda.Size = new System.Drawing.Size(224, 46);
            this.btnconsvenda.TabIndex = 78;
            this.btnconsvenda.Text = "Venda";
            // 
            // btnconscat
            // 
            this.btnconscat.Animated = true;
            this.btnconscat.AutoRoundedCorners = true;
            this.btnconscat.BorderColor = System.Drawing.Color.White;
            this.btnconscat.BorderRadius = 22;
            this.btnconscat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnconscat, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnconscat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnconscat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnconscat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnconscat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnconscat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnconscat.FillColor = System.Drawing.Color.Black;
            this.btnconscat.FocusedColor = System.Drawing.Color.Transparent;
            this.btnconscat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnconscat.ForeColor = System.Drawing.Color.White;
            this.btnconscat.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnconscat.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnconscat.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnconscat.Image = ((System.Drawing.Image)(resources.GetObject("btnconscat.Image")));
            this.btnconscat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnconscat.Location = new System.Drawing.Point(0, 274);
            this.btnconscat.Name = "btnconscat";
            this.btnconscat.PressedColor = System.Drawing.Color.White;
            this.btnconscat.Size = new System.Drawing.Size(224, 46);
            this.btnconscat.TabIndex = 76;
            this.btnconscat.Text = "Categoria";
            this.btnconscat.Click += new System.EventHandler(this.btnconscat_Click);
            // 
            // btnconsprod
            // 
            this.btnconsprod.Animated = true;
            this.btnconsprod.AutoRoundedCorners = true;
            this.btnconsprod.BorderColor = System.Drawing.Color.White;
            this.btnconsprod.BorderRadius = 22;
            this.btnconsprod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnconsprod, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnconsprod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnconsprod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnconsprod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnconsprod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnconsprod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnconsprod.FillColor = System.Drawing.Color.Black;
            this.btnconsprod.FocusedColor = System.Drawing.Color.Transparent;
            this.btnconsprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnconsprod.ForeColor = System.Drawing.Color.White;
            this.btnconsprod.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnconsprod.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnconsprod.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnconsprod.Image = ((System.Drawing.Image)(resources.GetObject("btnconsprod.Image")));
            this.btnconsprod.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnconsprod.Location = new System.Drawing.Point(0, 228);
            this.btnconsprod.Name = "btnconsprod";
            this.btnconsprod.PressedColor = System.Drawing.Color.White;
            this.btnconsprod.Size = new System.Drawing.Size(224, 46);
            this.btnconsprod.TabIndex = 75;
            this.btnconsprod.Text = "Produto";
            this.btnconsprod.Click += new System.EventHandler(this.btnconsprod_Click);
            // 
            // btnconsmarca
            // 
            this.btnconsmarca.Animated = true;
            this.btnconsmarca.AutoRoundedCorners = true;
            this.btnconsmarca.BorderColor = System.Drawing.Color.White;
            this.btnconsmarca.BorderRadius = 22;
            this.btnconsmarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnconsmarca, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnconsmarca.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnconsmarca.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnconsmarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnconsmarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnconsmarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnconsmarca.FillColor = System.Drawing.Color.Black;
            this.btnconsmarca.FocusedColor = System.Drawing.Color.Transparent;
            this.btnconsmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnconsmarca.ForeColor = System.Drawing.Color.White;
            this.btnconsmarca.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnconsmarca.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnconsmarca.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnconsmarca.Image = ((System.Drawing.Image)(resources.GetObject("btnconsmarca.Image")));
            this.btnconsmarca.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnconsmarca.Location = new System.Drawing.Point(0, 182);
            this.btnconsmarca.Name = "btnconsmarca";
            this.btnconsmarca.PressedColor = System.Drawing.Color.White;
            this.btnconsmarca.Size = new System.Drawing.Size(224, 46);
            this.btnconsmarca.TabIndex = 74;
            this.btnconsmarca.Text = "Marca";
            this.btnconsmarca.Click += new System.EventHandler(this.btnconsmarca_Click);
            // 
            // btnconsfunc
            // 
            this.btnconsfunc.Animated = true;
            this.btnconsfunc.AutoRoundedCorners = true;
            this.btnconsfunc.BorderColor = System.Drawing.Color.White;
            this.btnconsfunc.BorderRadius = 21;
            this.btnconsfunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnconsfunc, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnconsfunc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnconsfunc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnconsfunc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnconsfunc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnconsfunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnconsfunc.FillColor = System.Drawing.Color.Black;
            this.btnconsfunc.FocusedColor = System.Drawing.Color.Transparent;
            this.btnconsfunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnconsfunc.ForeColor = System.Drawing.Color.White;
            this.btnconsfunc.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnconsfunc.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnconsfunc.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnconsfunc.Image = ((System.Drawing.Image)(resources.GetObject("btnconsfunc.Image")));
            this.btnconsfunc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnconsfunc.Location = new System.Drawing.Point(0, 137);
            this.btnconsfunc.Name = "btnconsfunc";
            this.btnconsfunc.PressedColor = System.Drawing.Color.White;
            this.btnconsfunc.Size = new System.Drawing.Size(224, 45);
            this.btnconsfunc.TabIndex = 73;
            this.btnconsfunc.Text = "Funcionário";
            this.btnconsfunc.Click += new System.EventHandler(this.btnconsfunc_Click);
            // 
            // btnconsforne
            // 
            this.btnconsforne.Animated = true;
            this.btnconsforne.AutoRoundedCorners = true;
            this.btnconsforne.BorderColor = System.Drawing.Color.White;
            this.btnconsforne.BorderRadius = 22;
            this.btnconsforne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnconsforne, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnconsforne.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnconsforne.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnconsforne.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnconsforne.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnconsforne.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnconsforne.FillColor = System.Drawing.Color.Black;
            this.btnconsforne.FocusedColor = System.Drawing.Color.Transparent;
            this.btnconsforne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnconsforne.ForeColor = System.Drawing.Color.White;
            this.btnconsforne.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnconsforne.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnconsforne.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnconsforne.Image = ((System.Drawing.Image)(resources.GetObject("btnconsforne.Image")));
            this.btnconsforne.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnconsforne.Location = new System.Drawing.Point(0, 91);
            this.btnconsforne.Name = "btnconsforne";
            this.btnconsforne.PressedColor = System.Drawing.Color.White;
            this.btnconsforne.Size = new System.Drawing.Size(224, 46);
            this.btnconsforne.TabIndex = 72;
            this.btnconsforne.Text = "Fornecedor";
            this.btnconsforne.Click += new System.EventHandler(this.btnconsforne_Click);
            // 
            // btnconscliente
            // 
            this.btnconscliente.Animated = true;
            this.btnconscliente.AutoRoundedCorners = true;
            this.btnconscliente.BorderColor = System.Drawing.Color.White;
            this.btnconscliente.BorderRadius = 21;
            this.btnconscliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnconscliente, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnconscliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnconscliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnconscliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnconscliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnconscliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnconscliente.FillColor = System.Drawing.Color.Black;
            this.btnconscliente.FocusedColor = System.Drawing.Color.Transparent;
            this.btnconscliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnconscliente.ForeColor = System.Drawing.Color.White;
            this.btnconscliente.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnconscliente.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnconscliente.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnconscliente.Image = ((System.Drawing.Image)(resources.GetObject("btnconscliente.Image")));
            this.btnconscliente.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnconscliente.Location = new System.Drawing.Point(0, 46);
            this.btnconscliente.Name = "btnconscliente";
            this.btnconscliente.PressedColor = System.Drawing.Color.White;
            this.btnconscliente.Size = new System.Drawing.Size(224, 45);
            this.btnconscliente.TabIndex = 64;
            this.btnconscliente.Text = "Cliente";
            this.btnconscliente.Click += new System.EventHandler(this.btnconscliente_Click);
            // 
            // btnconscargo
            // 
            this.btnconscargo.Animated = true;
            this.btnconscargo.AutoRoundedCorners = true;
            this.btnconscargo.BorderColor = System.Drawing.Color.White;
            this.btnconscargo.BorderRadius = 22;
            this.btnconscargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnconscargo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnconscargo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnconscargo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnconscargo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnconscargo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnconscargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnconscargo.FillColor = System.Drawing.Color.Black;
            this.btnconscargo.FocusedColor = System.Drawing.Color.Transparent;
            this.btnconscargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnconscargo.ForeColor = System.Drawing.Color.White;
            this.btnconscargo.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnconscargo.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnconscargo.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnconscargo.Image = ((System.Drawing.Image)(resources.GetObject("btnconscargo.Image")));
            this.btnconscargo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnconscargo.Location = new System.Drawing.Point(0, 0);
            this.btnconscargo.Name = "btnconscargo";
            this.btnconscargo.PressedColor = System.Drawing.Color.White;
            this.btnconscargo.Size = new System.Drawing.Size(224, 46);
            this.btnconscargo.TabIndex = 65;
            this.btnconscargo.Text = "Cargo";
            this.btnconscargo.Click += new System.EventHandler(this.btnconscargo_Click);
            // 
            // btnmenuconsulta
            // 
            this.btnmenuconsulta.Animated = true;
            this.btnmenuconsulta.AutoRoundedCorners = true;
            this.btnmenuconsulta.BorderColor = System.Drawing.Color.White;
            this.btnmenuconsulta.BorderRadius = 22;
            this.btnmenuconsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnmenuconsulta, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnmenuconsulta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmenuconsulta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmenuconsulta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmenuconsulta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmenuconsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmenuconsulta.FillColor = System.Drawing.Color.Black;
            this.btnmenuconsulta.FocusedColor = System.Drawing.Color.Transparent;
            this.btnmenuconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnmenuconsulta.ForeColor = System.Drawing.Color.White;
            this.btnmenuconsulta.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnmenuconsulta.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnmenuconsulta.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnmenuconsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnmenuconsulta.Image")));
            this.btnmenuconsulta.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnmenuconsulta.Location = new System.Drawing.Point(0, 135);
            this.btnmenuconsulta.Name = "btnmenuconsulta";
            this.btnmenuconsulta.PressedColor = System.Drawing.Color.White;
            this.btnmenuconsulta.Size = new System.Drawing.Size(224, 46);
            this.btnmenuconsulta.TabIndex = 77;
            this.btnmenuconsulta.Text = "Consulta";
            this.btnmenuconsulta.Click += new System.EventHandler(this.btnmenuconsulta_Click_1);
            // 
            // btnmenurelatorio
            // 
            this.btnmenurelatorio.Animated = true;
            this.btnmenurelatorio.AutoRoundedCorners = true;
            this.btnmenurelatorio.BorderColor = System.Drawing.Color.White;
            this.btnmenurelatorio.BorderRadius = 21;
            this.btnmenurelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnmenurelatorio, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnmenurelatorio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmenurelatorio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmenurelatorio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmenurelatorio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmenurelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmenurelatorio.FillColor = System.Drawing.Color.Black;
            this.btnmenurelatorio.FocusedColor = System.Drawing.Color.Transparent;
            this.btnmenurelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnmenurelatorio.ForeColor = System.Drawing.Color.White;
            this.btnmenurelatorio.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnmenurelatorio.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnmenurelatorio.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnmenurelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btnmenurelatorio.Image")));
            this.btnmenurelatorio.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnmenurelatorio.Location = new System.Drawing.Point(0, 90);
            this.btnmenurelatorio.Name = "btnmenurelatorio";
            this.btnmenurelatorio.PressedColor = System.Drawing.Color.White;
            this.btnmenurelatorio.Size = new System.Drawing.Size(224, 45);
            this.btnmenurelatorio.TabIndex = 66;
            this.btnmenurelatorio.Text = "Relatório";
            this.btnmenurelatorio.Click += new System.EventHandler(this.btnmenurelatorio_Click);
            // 
            // btnmenucadastrar
            // 
            this.btnmenucadastrar.Animated = true;
            this.btnmenucadastrar.AutoRoundedCorners = true;
            this.btnmenucadastrar.BorderColor = System.Drawing.Color.White;
            this.btnmenucadastrar.BorderRadius = 21;
            this.btnmenucadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnmenucadastrar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnmenucadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmenucadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmenucadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmenucadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmenucadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmenucadastrar.FillColor = System.Drawing.Color.Black;
            this.btnmenucadastrar.FocusedColor = System.Drawing.Color.Transparent;
            this.btnmenucadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnmenucadastrar.ForeColor = System.Drawing.Color.White;
            this.btnmenucadastrar.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnmenucadastrar.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnmenucadastrar.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnmenucadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnmenucadastrar.Image")));
            this.btnmenucadastrar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnmenucadastrar.Location = new System.Drawing.Point(0, 45);
            this.btnmenucadastrar.Name = "btnmenucadastrar";
            this.btnmenucadastrar.PressedColor = System.Drawing.Color.White;
            this.btnmenucadastrar.Size = new System.Drawing.Size(224, 45);
            this.btnmenucadastrar.TabIndex = 70;
            this.btnmenucadastrar.Text = "Cadastrar";
            this.btnmenucadastrar.Click += new System.EventHandler(this.btnmenucadastrar_Click);
            // 
            // btnmenudash
            // 
            this.btnmenudash.Animated = true;
            this.btnmenudash.AutoRoundedCorners = true;
            this.btnmenudash.BorderColor = System.Drawing.Color.White;
            this.btnmenudash.BorderRadius = 21;
            this.btnmenudash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnmenudash, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnmenudash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmenudash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmenudash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmenudash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmenudash.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmenudash.FillColor = System.Drawing.Color.Black;
            this.btnmenudash.FocusedColor = System.Drawing.Color.Transparent;
            this.btnmenudash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnmenudash.ForeColor = System.Drawing.Color.White;
            this.btnmenudash.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnmenudash.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnmenudash.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnmenudash.Image = ((System.Drawing.Image)(resources.GetObject("btnmenudash.Image")));
            this.btnmenudash.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnmenudash.Location = new System.Drawing.Point(0, 0);
            this.btnmenudash.Name = "btnmenudash";
            this.btnmenudash.PressedColor = System.Drawing.Color.White;
            this.btnmenudash.Size = new System.Drawing.Size(224, 45);
            this.btnmenudash.TabIndex = 69;
            this.btnmenudash.Text = "DashBoard";
            this.btnmenudash.Click += new System.EventHandler(this.btnmenudash_Click);
            // 
            // slogan
            // 
            this.slogan.AutoSize = true;
            this.slogan.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.slogan, Guna.UI2.AnimatorNS.DecorationType.None);
            this.slogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slogan.ForeColor = System.Drawing.Color.White;
            this.slogan.Location = new System.Drawing.Point(71, 58);
            this.slogan.Name = "slogan";
            this.slogan.Size = new System.Drawing.Size(148, 16);
            this.slogan.TabIndex = 6;
            this.slogan.Text = "Cada passo importa";
            this.slogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nomelogotipo
            // 
            this.nomelogotipo.AutoSize = true;
            this.nomelogotipo.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.nomelogotipo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nomelogotipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomelogotipo.ForeColor = System.Drawing.Color.White;
            this.nomelogotipo.Location = new System.Drawing.Point(69, 24);
            this.nomelogotipo.Name = "nomelogotipo";
            this.nomelogotipo.Size = new System.Drawing.Size(161, 29);
            this.nomelogotipo.TabIndex = 5;
            this.nomelogotipo.Text = "VortexShoes";
            // 
            // logotipo
            // 
            this.guna2Transition1.SetDecoration(this.logotipo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.logotipo.ErrorImage = null;
            this.logotipo.Image = ((System.Drawing.Image)(resources.GetObject("logotipo.Image")));
            this.logotipo.Location = new System.Drawing.Point(13, 24);
            this.logotipo.Name = "logotipo";
            this.logotipo.Size = new System.Drawing.Size(50, 50);
            this.logotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logotipo.TabIndex = 4;
            this.logotipo.TabStop = false;
            // 
            // btnfechar
            // 
            this.btnfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnfechar.Animated = true;
            this.btnfechar.CustomClick = true;
            this.guna2Transition1.SetDecoration(this.btnfechar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnfechar.FillColor = System.Drawing.Color.Black;
            this.btnfechar.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnfechar.HoverState.IconColor = System.Drawing.Color.Red;
            this.btnfechar.IconColor = System.Drawing.Color.White;
            this.btnfechar.Location = new System.Drawing.Point(1108, 3);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(45, 29);
            this.btnfechar.TabIndex = 85;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnmaximizar
            // 
            this.btnmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximizar.Animated = true;
            this.btnmaximizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2Transition1.SetDecoration(this.btnmaximizar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnmaximizar.FillColor = System.Drawing.Color.Black;
            this.btnmaximizar.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnmaximizar.HoverState.IconColor = System.Drawing.Color.White;
            this.btnmaximizar.IconColor = System.Drawing.Color.White;
            this.btnmaximizar.Location = new System.Drawing.Point(1067, 3);
            this.btnmaximizar.Name = "btnmaximizar";
            this.btnmaximizar.Size = new System.Drawing.Size(45, 29);
            this.btnmaximizar.TabIndex = 86;
            // 
            // btnminimizar
            // 
            this.btnminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimizar.Animated = true;
            this.btnminimizar.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2Transition1.SetDecoration(this.btnminimizar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnminimizar.FillColor = System.Drawing.Color.Black;
            this.btnminimizar.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.btnminimizar.HoverState.IconColor = System.Drawing.Color.White;
            this.btnminimizar.IconColor = System.Drawing.Color.White;
            this.btnminimizar.Location = new System.Drawing.Point(1031, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(45, 29);
            this.btnminimizar.TabIndex = 87;
            // 
            // pnlAbrirformulario
            // 
            this.guna2Transition1.SetDecoration(this.pnlAbrirformulario, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlAbrirformulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAbrirformulario.Location = new System.Drawing.Point(0, 0);
            this.pnlAbrirformulario.Name = "pnlAbrirformulario";
            this.pnlAbrirformulario.Size = new System.Drawing.Size(1153, 1018);
            this.pnlAbrirformulario.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnvoltarmenu);
            this.guna2Panel2.Controls.Add(this.btnescondermenu);
            this.guna2Panel2.Controls.Add(this.btnminimizar);
            this.guna2Panel2.Controls.Add(this.btnmaximizar);
            this.guna2Panel2.Controls.Add(this.btnfechar);
            this.guna2Transition1.SetDecoration(this.guna2Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(233, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1153, 60);
            this.guna2Panel2.TabIndex = 90;
            // 
            // btnvoltarmenu
            // 
            this.btnvoltarmenu.BackColor = System.Drawing.Color.Black;
            this.btnvoltarmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnvoltarmenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnvoltarmenu.FillColor = System.Drawing.Color.Black;
            this.btnvoltarmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnvoltarmenu.Image")));
            this.btnvoltarmenu.ImageRotate = 0F;
            this.btnvoltarmenu.Location = new System.Drawing.Point(73, 12);
            this.btnvoltarmenu.Name = "btnvoltarmenu";
            this.btnvoltarmenu.Size = new System.Drawing.Size(47, 37);
            this.btnvoltarmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnvoltarmenu.TabIndex = 89;
            this.btnvoltarmenu.TabStop = false;
            this.btnvoltarmenu.Visible = false;
            this.btnvoltarmenu.Click += new System.EventHandler(this.btnvoltarmenu_Click_1);
            // 
            // btnescondermenu
            // 
            this.btnescondermenu.BackColor = System.Drawing.Color.Black;
            this.btnescondermenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Transition1.SetDecoration(this.btnescondermenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnescondermenu.FillColor = System.Drawing.Color.Black;
            this.btnescondermenu.Image = ((System.Drawing.Image)(resources.GetObject("btnescondermenu.Image")));
            this.btnescondermenu.ImageRotate = 0F;
            this.btnescondermenu.Location = new System.Drawing.Point(6, 12);
            this.btnescondermenu.Name = "btnescondermenu";
            this.btnescondermenu.Size = new System.Drawing.Size(47, 37);
            this.btnescondermenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnescondermenu.TabIndex = 88;
            this.btnescondermenu.TabStop = false;
            this.btnescondermenu.Click += new System.EventHandler(this.btnescondermenu_Click_1);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.pnlAbrirformulario);
            this.guna2Transition1.SetDecoration(this.guna2Panel3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(233, 60);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1153, 1018);
            this.guna2Panel3.TabIndex = 91;
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 1100);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.sts);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPrincipal";
            this.Text = "VortexShoes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.sts.ResumeLayout(false);
            this.sts.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.pnlsubrela.ResumeLayout(false);
            this.pnlsubcadastrar.ResumeLayout(false);
            this.pnlmenuconsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logotipo)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnvoltarmenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnescondermenu)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmrPrincipal;
        private System.Windows.Forms.StatusStrip sts;
        private System.Windows.Forms.ToolStripStatusLabel stsMensagem;
        private System.Windows.Forms.ToolStripStatusLabel stsHora;
        private System.Windows.Forms.ToolStripStatusLabel stsData;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label slogan;
        private System.Windows.Forms.Label nomelogotipo;
        private System.Windows.Forms.PictureBox logotipo;
        private Guna.UI2.WinForms.Guna2Button btncliente;
        private Guna.UI2.WinForms.Guna2Button btnmenudash;
        private System.Windows.Forms.Panel pnlAbrirformulario;
        private Guna.UI2.WinForms.Guna2ControlBox btnminimizar;
        private Guna.UI2.WinForms.Guna2ControlBox btnmaximizar;
        private Guna.UI2.WinForms.Guna2ControlBox btnfechar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox btnescondermenu;
        private Guna.UI2.WinForms.Guna2PictureBox btnvoltarmenu;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private Guna.UI2.WinForms.Guna2Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Panel pnlsubcadastrar;
        private Guna.UI2.WinForms.Guna2Button btnmenucadastrar;
        private Guna.UI2.WinForms.Guna2Button btnmenurelatorio;
        private Guna.UI2.WinForms.Guna2Button btncargo;
        private Guna.UI2.WinForms.Guna2Button btnfuncionario;
        private Guna.UI2.WinForms.Guna2Button btnFornecedor;
        private Guna.UI2.WinForms.Guna2Button btncategoria;
        private Guna.UI2.WinForms.Guna2Button btnproduto;
        private Guna.UI2.WinForms.Guna2Button btnmarca;
        private Guna.UI2.WinForms.Guna2Panel pnlmenuconsulta;
        private Guna.UI2.WinForms.Guna2Button btnconscat;
        private Guna.UI2.WinForms.Guna2Button btnconsprod;
        private Guna.UI2.WinForms.Guna2Button btnconsmarca;
        private Guna.UI2.WinForms.Guna2Button btnconsfunc;
        private Guna.UI2.WinForms.Guna2Button btnconsforne;
        private Guna.UI2.WinForms.Guna2Button btnconscliente;
        private Guna.UI2.WinForms.Guna2Button btnconscargo;
        private Guna.UI2.WinForms.Guna2Button btnmenuconsulta;
        private Guna.UI2.WinForms.Guna2Panel pnlsubrela;
        private Guna.UI2.WinForms.Guna2Button btnrelprod;
        private Guna.UI2.WinForms.Guna2Button btnrelfunc;
        private Guna.UI2.WinForms.Guna2Button btnrelclie;
        private Guna.UI2.WinForms.Guna2Button btncadvenda;
        private Guna.UI2.WinForms.Guna2Button btnmenusair;
        private Guna.UI2.WinForms.Guna2Button btncadvendaa;
        private Guna.UI2.WinForms.Guna2Button btnconsvenda;
    }
}

