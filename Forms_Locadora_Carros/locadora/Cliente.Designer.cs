namespace locadora
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbxSexo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHabilitacao = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEndereco = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelefone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtIdade = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCpf = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cbCidade = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSair = new Guna.UI2.WinForms.Guna2Button();
            this.btnCad = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(508, 269);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(60, 22);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Cidade:";
            // 
            // txtNome
            // 
            this.txtNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtNome.BorderRadius = 13;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.DefaultText = "";
            this.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.Location = new System.Drawing.Point(137, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(288, 36);
            this.txtNome.TabIndex = 9;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // cbxSexo
            // 
            this.cbxSexo.AutoRoundedCorners = true;
            this.cbxSexo.BackColor = System.Drawing.Color.Transparent;
            this.cbxSexo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.cbxSexo.BorderRadius = 17;
            this.cbxSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxSexo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxSexo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxSexo.ItemHeight = 30;
            this.cbxSexo.Items.AddRange(new object[] {
            "M",
            "F",
            "-"});
            this.cbxSexo.Location = new System.Drawing.Point(188, 260);
            this.cbxSexo.Name = "cbxSexo";
            this.cbxSexo.Size = new System.Drawing.Size(237, 36);
            this.cbxSexo.TabIndex = 10;
            this.cbxSexo.Tag = "";
            this.cbxSexo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cbxSexo.SelectedIndexChanged += new System.EventHandler(this.cbxSexo_SelectedIndexChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(137, 269);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(45, 22);
            this.guna2HtmlLabel3.TabIndex = 11;
            this.guna2HtmlLabel3.Text = "Sexo:";
            this.guna2HtmlLabel3.Click += new System.EventHandler(this.guna2HtmlLabel3_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtEmail.BorderRadius = 13;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(499, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(294, 36);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtHabilitacao
            // 
            this.txtHabilitacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtHabilitacao.BorderRadius = 13;
            this.txtHabilitacao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHabilitacao.DefaultText = "";
            this.txtHabilitacao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHabilitacao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHabilitacao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHabilitacao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHabilitacao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHabilitacao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHabilitacao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHabilitacao.Location = new System.Drawing.Point(499, 205);
            this.txtHabilitacao.Name = "txtHabilitacao";
            this.txtHabilitacao.PasswordChar = '\0';
            this.txtHabilitacao.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtHabilitacao.PlaceholderText = "Habilitação";
            this.txtHabilitacao.SelectedText = "";
            this.txtHabilitacao.Size = new System.Drawing.Size(294, 36);
            this.txtHabilitacao.TabIndex = 13;
            this.txtHabilitacao.TextChanged += new System.EventHandler(this.txtHabilitacao_TextChanged);
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtEndereco.BorderRadius = 13;
            this.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndereco.DefaultText = "";
            this.txtEndereco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEndereco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEndereco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndereco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEndereco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndereco.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEndereco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEndereco.Location = new System.Drawing.Point(499, 152);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtEndereco.PlaceholderText = "Endereco";
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.Size = new System.Drawing.Size(294, 36);
            this.txtEndereco.TabIndex = 14;
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtTelefone.BorderRadius = 13;
            this.txtTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefone.DefaultText = "";
            this.txtTelefone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefone.Location = new System.Drawing.Point(219, 205);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTelefone.PlaceholderText = "Telefone";
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.Size = new System.Drawing.Size(206, 36);
            this.txtTelefone.TabIndex = 16;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // txtIdade
            // 
            this.txtIdade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtIdade.BorderRadius = 13;
            this.txtIdade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdade.DefaultText = "";
            this.txtIdade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdade.Location = new System.Drawing.Point(137, 205);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.PasswordChar = '\0';
            this.txtIdade.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtIdade.PlaceholderText = "Idade";
            this.txtIdade.SelectedText = "";
            this.txtIdade.Size = new System.Drawing.Size(76, 36);
            this.txtIdade.TabIndex = 17;
            this.txtIdade.TextChanged += new System.EventHandler(this.txtIdade_TextChanged);
            // 
            // txtCpf
            // 
            this.txtCpf.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtCpf.BorderRadius = 13;
            this.txtCpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpf.DefaultText = "";
            this.txtCpf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCpf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCpf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCpf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCpf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCpf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCpf.Location = new System.Drawing.Point(137, 152);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PasswordChar = '\0';
            this.txtCpf.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCpf.PlaceholderText = "CPF";
            this.txtCpf.SelectedText = "";
            this.txtCpf.Size = new System.Drawing.Size(288, 36);
            this.txtCpf.TabIndex = 18;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(-3, 430);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(966, 255);
            this.dgv.TabIndex = 20;
            // 
            // cbCidade
            // 
            this.cbCidade.BackColor = System.Drawing.Color.Transparent;
            this.cbCidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.cbCidade.BorderRadius = 13;
            this.cbCidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCidade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCidade.ItemHeight = 30;
            this.cbCidade.Location = new System.Drawing.Point(574, 260);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(219, 36);
            this.cbCidade.TabIndex = 22;
            this.cbCidade.SelectedIndexChanged += new System.EventHandler(this.cbCidade_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(346, 41);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(216, 31);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = "Cadastro de Cliente";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::locadora.Properties.Resources.autoetec;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-37, -20);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(250, 125);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 23;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BorderRadius = 20;
            this.btnSair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSair.FillColor = System.Drawing.Color.Transparent;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = global::locadora.Properties.Resources.logout;
            this.btnSair.Location = new System.Drawing.Point(839, 41);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 45);
            this.btnSair.TabIndex = 21;
            this.btnSair.Text = "&Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.Color.Transparent;
            this.btnCad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.btnCad.BorderRadius = 20;
            this.btnCad.BorderThickness = 1;
            this.btnCad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCad.FillColor = System.Drawing.Color.Transparent;
            this.btnCad.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.btnCad.Image = global::locadora.Properties.Resources.register;
            this.btnCad.ImageSize = new System.Drawing.Size(38, 38);
            this.btnCad.Location = new System.Drawing.Point(360, 351);
            this.btnCad.Name = "btnCad";
            this.btnCad.PressedColor = System.Drawing.Color.Empty;
            this.btnCad.Size = new System.Drawing.Size(208, 60);
            this.btnCad.TabIndex = 19;
            this.btnCad.Text = "&Cadastrar";
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            this.btnCad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCad_MouseMove);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(961, 691);
            this.ControlBox = false;
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cbCidade);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtHabilitacao);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.cbxSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2ComboBox cbxSexo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtHabilitacao;
        private Guna.UI2.WinForms.Guna2TextBox txtEndereco;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefone;
        private Guna.UI2.WinForms.Guna2TextBox txtIdade;
        private Guna.UI2.WinForms.Guna2TextBox txtCpf;
        private Guna.UI2.WinForms.Guna2Button btnCad;
        private System.Windows.Forms.DataGridView dgv;
        private Guna.UI2.WinForms.Guna2Button btnSair;
        private Guna.UI2.WinForms.Guna2ComboBox cbCidade;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}