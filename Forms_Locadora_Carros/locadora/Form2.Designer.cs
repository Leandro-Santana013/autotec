namespace locadora
{
    partial class Form2
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
            this.txtbcit = new Guna.UI2.WinForms.Guna2TextBox();
            this.uf = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnsair = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cbxuf = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(2, 265);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(616, 226);
            this.dgv.TabIndex = 4;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // txtbcit
            // 
            this.txtbcit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtbcit.BorderRadius = 13;
            this.txtbcit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbcit.DefaultText = "";
            this.txtbcit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbcit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbcit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbcit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbcit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbcit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtbcit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbcit.Location = new System.Drawing.Point(262, 138);
            this.txtbcit.Name = "txtbcit";
            this.txtbcit.PasswordChar = '\0';
            this.txtbcit.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtbcit.PlaceholderText = "Cidade";
            this.txtbcit.SelectedText = "";
            this.txtbcit.Size = new System.Drawing.Size(294, 36);
            this.txtbcit.TabIndex = 13;
            this.txtbcit.TextChanged += new System.EventHandler(this.txtbcit_TextChanged);
            // 
            // uf
            // 
            this.uf.AccessibleDescription = "";
            this.uf.BackColor = System.Drawing.Color.Transparent;
            this.uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.uf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.uf.Location = new System.Drawing.Point(95, 152);
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(25, 22);
            this.uf.TabIndex = 15;
            this.uf.Text = "UF";
            // 
            // btnsair
            // 
            this.btnsair.BorderRadius = 20;
            this.btnsair.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsair.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsair.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsair.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsair.FillColor = System.Drawing.Color.Transparent;
            this.btnsair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsair.ForeColor = System.Drawing.Color.White;
            this.btnsair.Image = global::locadora.Properties.Resources.logout;
            this.btnsair.Location = new System.Drawing.Point(499, 27);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(110, 45);
            this.btnsair.TabIndex = 22;
            this.btnsair.Text = "&Sair";
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderThickness = 1;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.btnSave.Image = global::locadora.Properties.Resources.register;
            this.btnSave.ImageSize = new System.Drawing.Size(38, 38);
            this.btnSave.Location = new System.Drawing.Point(214, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(197, 49);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "&Cadastrar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(203, 41);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(218, 31);
            this.guna2HtmlLabel1.TabIndex = 25;
            this.guna2HtmlLabel1.Text = "Cadastro de Cidade";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::locadora.Properties.Resources.autoetec;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-53, -28);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(250, 125);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 26;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // cbxuf
            // 
            this.cbxuf.AutoCompleteCustomSource.AddRange(new string[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxuf.AutoRoundedCorners = true;
            this.cbxuf.BackColor = System.Drawing.Color.Transparent;
            this.cbxuf.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.cbxuf.BorderRadius = 17;
            this.cbxuf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxuf.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxuf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxuf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxuf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxuf.FormattingEnabled = true;
            this.cbxuf.ItemHeight = 30;
            this.cbxuf.Location = new System.Drawing.Point(137, 138);
            this.cbxuf.Name = "cbxuf";
            this.cbxuf.Size = new System.Drawing.Size(102, 36);
            this.cbxuf.TabIndex = 28;
            this.cbxuf.Tag = "";
            this.cbxuf.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cbxuf.SelectedIndexChanged += new System.EventHandler(this.cbxuf_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(621, 493);
            this.ControlBox = false;
            this.Controls.Add(this.cbxuf);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.uf);
            this.Controls.Add(this.txtbcit);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cidade";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private Guna.UI2.WinForms.Guna2TextBox txtbcit;
        private Guna.UI2.WinForms.Guna2HtmlLabel uf;
        private Guna.UI2.WinForms.Guna2Button btnsair;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxuf;
    }
}