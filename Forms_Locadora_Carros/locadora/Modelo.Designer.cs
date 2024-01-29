namespace locadora
{
    partial class Modelo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnsair = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtmod = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.cbFabricante = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(837, 235);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(320, 57);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(222, 31);
            this.guna2HtmlLabel1.TabIndex = 27;
            this.guna2HtmlLabel1.Text = "Cadastro de Modelo";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
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
            this.btnsair.Location = new System.Drawing.Point(645, 43);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(110, 45);
            this.btnsair.TabIndex = 25;
            this.btnsair.Text = "&Sair";
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::locadora.Properties.Resources.autoetec;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-10, -18);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(250, 125);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 26;
            this.guna2PictureBox1.TabStop = false;
            // 
            // txtmod
            // 
            this.txtmod.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(10)))));
            this.txtmod.BorderRadius = 13;
            this.txtmod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmod.DefaultText = "";
            this.txtmod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmod.Location = new System.Drawing.Point(449, 141);
            this.txtmod.Name = "txtmod";
            this.txtmod.PasswordChar = '\0';
            this.txtmod.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtmod.PlaceholderText = "Modelo";
            this.txtmod.SelectedText = "";
            this.txtmod.Size = new System.Drawing.Size(306, 36);
            this.txtmod.TabIndex = 29;
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
            this.btnSave.Location = new System.Drawing.Point(346, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.PressedColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(208, 60);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "&Cadastrar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.cbFabricante.Location = new System.Drawing.Point(182, 141);
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(237, 36);
            this.cbFabricante.TabIndex = 31;
            this.cbFabricante.Tag = "";
            this.cbFabricante.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cbFabricante.SelectedIndexChanged += new System.EventHandler(this.cbFabricante_SelectedIndexChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(89, 155);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(87, 22);
            this.guna2HtmlLabel3.TabIndex = 32;
            this.guna2HtmlLabel3.Text = "Fabricante:";
            // 
            // Modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(861, 556);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.cbFabricante);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtmod);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Modelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelo";
            this.Load += new System.EventHandler(this.Modelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnsair;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtmod;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox cbFabricante;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}