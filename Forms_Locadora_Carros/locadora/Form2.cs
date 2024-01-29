using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace locadora
{
    public partial class Form2 : Form
    {
        private int cdEstado;

        private MySqlConnection Conexao;

        private string data_source = "datasource=localhost;username=root;password=root;database=db_locadora";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost;username=root;password=root;database=db_locadora";

            Conexao = new MySqlConnection(data_source);

            string sql3 = "SELECT tb_cidade.nm_cidade, tb_estado.sg_estado FROM tb_cidade INNER JOIN tb_estado on (tb_estado.cd_estado = tb_cidade.cd_estadoCidade);";
          
            MySqlCommand comando4 = new MySqlCommand(sql3, Conexao);

            Conexao.Open();

            comando4.CommandType = CommandType.Text;
        
            MySqlDataAdapter da = new MySqlDataAdapter(comando4);
            
            DataTable componentes = new DataTable();

            da.Fill(componentes);

            dgv.DataSource = componentes;

            DataGridViewColumn coluna0 = dgv.Columns[0];
            coluna0.Width = 470;
            Conexao.Close();

            Conexao = new MySqlConnection(data_source);

            string sql2 = "select sg_estado from tb_estado order by nm_estado";

            Conexao.Open();

            MySqlCommand comando2 = new MySqlCommand(sql2, Conexao);

            MySqlDataReader reader = comando2.ExecuteReader();

            cbxuf.Items.Clear();

            while (reader.Read())
            {
                cbxuf.Items.Add(reader.GetString("sg_estado"));
            }
            Conexao.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbxuf.Text) && !String.IsNullOrEmpty(txtbcit.Text))
            {
                try
                {
                    Conexao = new MySqlConnection(data_source);

                    string sql4 = "select cd_estado from tb_estado where sg_estado = '" + cbxuf.Text + "'";

                    MySqlCommand comandoUF = new MySqlCommand(sql4, Conexao);

                    Conexao.Open();

                    MySqlDataReader readerUF = comandoUF.ExecuteReader();

                    while (readerUF.Read())
                    {
                        cdEstado = (readerUF.GetInt32(0));
                    }

                    Conexao.Close();

                    string sql = "INSERT INTO tb_cidade (nm_cidade, cd_estadoCidade) VALUES ('" + txtbcit.Text + "' , '" + cdEstado + "')";

                    MySqlCommand comando = new MySqlCommand(sql, Conexao);

                    Conexao.Open();

                    comando.ExecuteReader();

                    MessageBox.Show("Inserido com Sucesso !!!");
                    cbxuf.Text = "";
                    txtbcit.Focus();

                    Conexao.Close();

                    string sql3 = "SELECT tb_cidade.nm_cidade, tb_estado.sg_estado FROM tb_cidade INNER JOIN tb_estado on (tb_estado.cd_estado = tb_cidade.cd_estadoCidade);";

                    MySqlCommand comando4 = new MySqlCommand(sql3, Conexao);

                    Conexao.Open();

                    comando4.CommandType = CommandType.Text;

                    MySqlDataAdapter da = new MySqlDataAdapter(comando4);

                    DataTable componentes = new DataTable();

                    da.Fill(componentes);

                    dgv.DataSource = componentes;

                    DataGridViewColumn coluna0 = dgv.Columns[0];
                    coluna0.Width = 400;
                    Conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Conexao.Close();
                }
            }
            else
            {
                MessageBox.Show("É obrigatório preencher todos os campos!");
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtbcit_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbxuf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}