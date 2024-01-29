namespace locadora
{
    partial class Alugar
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
            this.cbName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbCarro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtFim = new System.Windows.Forms.MaskedTextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSair = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCad = new Guna.UI2.WinForms.Guna2Button();
            this.txtLoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbName
            // 
            this.cbName.BackColor = System.Drawing.Color.Transparent;
            this.cbName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.cbName.BorderRadius = 13;
            this.cbName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbName.ItemHeight = 30;
            this.cbName.Location = new System.Drawing.Point(176, 112);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(412, 36);
            this.cbName.TabIndex = 26;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // cbCarro
            // 
            this.cbCarro.AutoRoundedCorners = true;
            this.cbCarro.BackColor = System.Drawing.Color.Transparent;
            this.cbCarro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.cbCarro.BorderRadius = 17;
            this.cbCarro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCarro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCarro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCarro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCarro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCarro.ItemHeight = 30;
            this.cbCarro.Items.AddRange(new object[] {
            "M",
            "F",
            "-"});
            this.cbCarro.Location = new System.Drawing.Point(176, 164);
            this.cbCarro.Name = "cbCarro";
            this.cbCarro.Size = new System.Drawing.Size(237, 36);
            this.cbCarro.TabIndex = 24;
            this.cbCarro.Tag = "";
            this.cbCarro.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cbCarro.SelectedIndexChanged += new System.EventHandler(this.cbCarro_SelectedIndexChanged);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(68, 303);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(659, 226);
            this.dgv.TabIndex = 29;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(273, 28);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(231, 31);
            this.guna2HtmlLabel1.TabIndex = 50;
            this.guna2HtmlLabel1.Text = "Cadastro de Locação";
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(176, 219);
            this.txtInicio.Mask = "00/00/0000";
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(71, 20);
            this.txtInicio.TabIndex = 54;
            this.txtInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtFim
            // 
            this.txtFim.Location = new System.Drawing.Point(176, 257);
            this.txtFim.Mask = "00/00/0000";
            this.txtFim.Name = "txtFim";
            this.txtFim.Size = new System.Drawing.Size(71, 20);
            this.txtFim.TabIndex = 55;
            this.txtFim.ValidatingType = typeof(System.DateTime);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(42, 217);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(111, 22);
            this.guna2HtmlLabel4.TabIndex = 56;
            this.guna2HtmlLabel4.Text = "Data de início:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(58, 257);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(95, 22);
            this.guna2HtmlLabel5.TabIndex = 57;
            this.guna2HtmlLabel5.Text = "Data de fim:";
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
            this.btnSair.Location = new System.Drawing.Point(666, 28);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 45);
            this.btnSair.TabIndex = 52;
            this.btnSair.Text = "&Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::locadora.Properties.Resources.autoetec;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-47, -34);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(250, 125);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 51;
            this.guna2PictureBox1.TabStop = false;
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
            this.btnCad.Location = new System.Drawing.Point(519, 219);
            this.btnCad.Name = "btnCad";
            this.btnCad.PressedColor = System.Drawing.Color.Empty;
            this.btnCad.Size = new System.Drawing.Size(208, 60);
            this.btnCad.TabIndex = 27;
            this.btnCad.Text = "&Cadastrar";
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // txtLoc
            // 
            this.txtLoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtLoc.BorderRadius = 13;
            this.txtLoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoc.DefaultText = "";
            this.txtLoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtLoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoc.Location = new System.Drawing.Point(264, 229);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.PasswordChar = '\0';
            this.txtLoc.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtLoc.PlaceholderText = "Valor da Locação";
            this.txtLoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLoc.SelectedText = "";
            this.txtLoc.Size = new System.Drawing.Size(240, 36);
            this.txtLoc.TabIndex = 64;
            this.txtLoc.TextChanged += new System.EventHandler(this.txtLoc_TextChanged);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(36, 164);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(117, 22);
            this.guna2HtmlLabel7.TabIndex = 72;
            this.guna2HtmlLabel7.Text = "Placa do carro:";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(24, 126);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(129, 22);
            this.guna2HtmlLabel8.TabIndex = 71;
            this.guna2HtmlLabel8.Text = "Nome do cliente:";
            // 
            // Alugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.txtFim);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.cbCarro);
            this.Name = "Alugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alugar";
            this.Load += new System.EventHandler(this.Alugar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cbName;
        private Guna.UI2.WinForms.Guna2ComboBox cbCarro;
        private Guna.UI2.WinForms.Guna2Button btnCad;
        private System.Windows.Forms.DataGridView dgv;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnSair;
        private System.Windows.Forms.MaskedTextBox txtInicio;
        private System.Windows.Forms.MaskedTextBox txtFim;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtLoc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
    }
}