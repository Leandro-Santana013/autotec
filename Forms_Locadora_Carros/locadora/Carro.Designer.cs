namespace locadora
{
    partial class Carro
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtCor = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPlaca = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCad = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSair = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbFabricante = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbModelo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbSituacao = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPreco = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(25, 332);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(936, 270);
            this.dgv.TabIndex = 23;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // txtCor
            // 
            this.txtCor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtCor.BorderRadius = 13;
            this.txtCor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCor.DefaultText = "";
            this.txtCor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtCor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCor.Location = new System.Drawing.Point(513, 206);
            this.txtCor.Name = "txtCor";
            this.txtCor.PasswordChar = '\0';
            this.txtCor.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtCor.PlaceholderText = "Cor";
            this.txtCor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCor.SelectedText = "";
            this.txtCor.Size = new System.Drawing.Size(288, 36);
            this.txtCor.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.textBox2.BorderRadius = 13;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.DefaultText = "";
            this.textBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.textBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox2.Location = new System.Drawing.Point(513, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '\0';
            this.textBox2.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textBox2.PlaceholderText = "Ano";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.SelectedText = "";
            this.textBox2.Size = new System.Drawing.Size(288, 36);
            this.textBox2.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.textBox1.BorderRadius = 13;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.DefaultText = "";
            this.textBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.textBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox1.Location = new System.Drawing.Point(513, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textBox1.PlaceholderText = "Chassi";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.SelectedText = "";
            this.textBox1.Size = new System.Drawing.Size(288, 36);
            this.textBox1.TabIndex = 36;
            // 
            // txtPlaca
            // 
            this.txtPlaca.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtPlaca.BorderRadius = 13;
            this.txtPlaca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlaca.DefaultText = "";
            this.txtPlaca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlaca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlaca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlaca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlaca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlaca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPlaca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtPlaca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlaca.Location = new System.Drawing.Point(197, 206);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.PasswordChar = '\0';
            this.txtPlaca.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPlaca.PlaceholderText = "Placa";
            this.txtPlaca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPlaca.SelectedText = "";
            this.txtPlaca.Size = new System.Drawing.Size(288, 36);
            this.txtPlaca.TabIndex = 37;
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
            this.btnCad.Location = new System.Drawing.Point(551, 262);
            this.btnCad.Name = "btnCad";
            this.btnCad.PressedColor = System.Drawing.Color.Empty;
            this.btnCad.Size = new System.Drawing.Size(208, 60);
            this.btnCad.TabIndex = 40;
            this.btnCad.Text = "&Cadastrar";
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(378, 48);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(200, 31);
            this.guna2HtmlLabel1.TabIndex = 43;
            this.guna2HtmlLabel1.Text = "Cadastro de Carro";
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
            this.btnSair.Location = new System.Drawing.Point(799, 48);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 45);
            this.btnSair.TabIndex = 41;
            this.btnSair.Text = "&Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::locadora.Properties.Resources.autoetec;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-9, -9);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(250, 125);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 42;
            this.guna2PictureBox1.TabStop = false;
            // 
            // cbFabricante
            // 
            this.cbFabricante.AutoRoundedCorners = true;
            this.cbFabricante.BackColor = System.Drawing.Color.Transparent;
            this.cbFabricante.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.cbFabricante.BorderRadius = 17;
            this.cbFabricante.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFabricante.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFabricante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFabricante.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbFabricante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbFabricante.ItemHeight = 30;
            this.cbFabricante.Items.AddRange(new object[] {
            "M",
            "F",
            "-"});
            this.cbFabricante.Location = new System.Drawing.Point(197, 122);
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(288, 36);
            this.cbFabricante.TabIndex = 45;
            this.cbFabricante.Tag = "";
            this.cbFabricante.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cbFabricante.SelectedIndexChanged += new System.EventHandler(this.cbFabricante_SelectedIndexChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(95, 136);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(87, 22);
            this.guna2HtmlLabel3.TabIndex = 46;
            this.guna2HtmlLabel3.Text = "Fabricante:";
            // 
            // cbModelo
            // 
            this.cbModelo.AutoRoundedCorners = true;
            this.cbModelo.BackColor = System.Drawing.Color.Transparent;
            this.cbModelo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.cbModelo.BorderRadius = 17;
            this.cbModelo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbModelo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbModelo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbModelo.ItemHeight = 30;
            this.cbModelo.Items.AddRange(new object[] {
            "M",
            "F",
            "-"});
            this.cbModelo.Location = new System.Drawing.Point(197, 164);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(288, 36);
            this.cbModelo.TabIndex = 47;
            this.cbModelo.Tag = "";
            this.cbModelo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cbModelo.SelectedIndexChanged += new System.EventHandler(this.cbModelo_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(120, 178);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(62, 22);
            this.guna2HtmlLabel2.TabIndex = 48;
            this.guna2HtmlLabel2.Text = "Modelo:";
            this.guna2HtmlLabel2.Click += new System.EventHandler(this.guna2HtmlLabel2_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(109, 262);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(73, 22);
            this.guna2HtmlLabel4.TabIndex = 50;
            this.guna2HtmlLabel4.Text = "Situação:";
            this.guna2HtmlLabel4.Click += new System.EventHandler(this.guna2HtmlLabel4_Click);
            // 
            // cbSituacao
            // 
            this.cbSituacao.AutoRoundedCorners = true;
            this.cbSituacao.BackColor = System.Drawing.Color.Transparent;
            this.cbSituacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.cbSituacao.BorderRadius = 17;
            this.cbSituacao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSituacao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSituacao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSituacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSituacao.ItemHeight = 30;
            this.cbSituacao.Items.AddRange(new object[] {
            "A",
            "D"});
            this.cbSituacao.Location = new System.Drawing.Point(197, 248);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(70, 36);
            this.cbSituacao.TabIndex = 51;
            this.cbSituacao.Tag = "";
            this.cbSituacao.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cbSituacao.SelectedIndexChanged += new System.EventHandler(this.cbSituacao_SelectedIndexChanged);
            // 
            // txtPreco
            // 
            this.txtPreco.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtPreco.BorderRadius = 13;
            this.txtPreco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPreco.DefaultText = "";
            this.txtPreco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPreco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPreco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtPreco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreco.Location = new System.Drawing.Point(310, 248);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPreco.PlaceholderText = "Preço";
            this.txtPreco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPreco.SelectedText = "";
            this.txtPreco.Size = new System.Drawing.Size(175, 36);
            this.txtPreco.TabIndex = 52;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(986, 614);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.cbFabricante);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.dgv);
            this.Name = "Carro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carro";
            this.Load += new System.EventHandler(this.Carro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private Guna.UI2.WinForms.Guna2TextBox txtCor;
        private Guna.UI2.WinForms.Guna2TextBox textBox2;
        private Guna.UI2.WinForms.Guna2TextBox textBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtPlaca;
        private Guna.UI2.WinForms.Guna2Button btnCad;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnSair;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFabricante;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbModelo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cbSituacao;
        private Guna.UI2.WinForms.Guna2TextBox txtPreco;
    }
}