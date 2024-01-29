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
    public partial class Modelo : Form
    {
        private int cdFabricante;

        private MySqlConnection Conexao;

        private string data_source = "datasource=localhost;username=root;password=root;database=db_locadora";
        public Modelo()
        {
            InitializeComponent();
        }

        private void Modelo_Load(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost;username=root;password=root;database=db_locadora";

            Conexao = new MySqlConnection(data_source);

            string sql3 = "SELECT tb_modelo.nm_modelo, tb_fabricante.nm_fabricante FROM tb_modelo INNER JOIN tb_fabricante ON (tb_modelo.cd_fabricanteModelo = tb_fabricante.cd_fabricante);";

            MySqlCommand comando4 = new MySqlCommand(sql3, Conexao);

            Conexao.Open();

            comando4.CommandType = CommandType.Text;

            MySqlDataAdapter da = new MySqlDataAdapter(comando4);

            DataTable componentes = new DataTable();

            da.Fill(componentes);

            dataGridView1.DataSource = componentes;

            DataGridViewColumn coluna0 = dataGridView1.Columns[0];
            coluna0.Width = 470;
            Conexao.Close();

            Conexao = new MySqlConnection(data_source);

            string sql1 = "select nm_fabricante from tb_fabricante order by nm_fabricante";

            Conexao.Open();

            MySqlCommand comando2 = new MySqlCommand(sql1, Conexao);

            MySqlDataReader reader = comando2.ExecuteReader();

            cbFabricante.Items.Clear();

            while (reader.Read())
            {
                cbFabricante.Items.Add(reader.GetString("nm_fabricante"));
            }
            Conexao.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbFabricante.Text) && !String.IsNullOrEmpty(txtmod.Text))
            {
                try
                {
                    Conexao = new MySqlConnection(data_source);

                    string sql4 = "select cd_fabricante from tb_fabricante where nm_fabricante = '" + cbFabricante.Text + "'";

                    MySqlCommand comandoCid = new MySqlCommand(sql4, Conexao);

                    Conexao.Open();

                    MySqlDataReader readerCid = comandoCid.ExecuteReader();

                    while (readerCid.Read())
                    {
                        cdFabricante = (readerCid.GetInt32(0));
                    }

                    Conexao.Close();

                    string sql = "INSERT INTO tb_modelo (cd_fabricanteModelo, nm_modelo) VALUES ('" + cdFabricante + "', '" + txtmod.Text + "')";

                    MySqlCommand comando = new MySqlCommand(sql, Conexao);

                    Conexao.Open();

                    comando.ExecuteReader();

                    MessageBox.Show("Inserido com Sucesso !!!");
                    cbFabricante.Text = "";
                    txtmod.Text = "";

                    Conexao.Close();

                    string sql3 = "SELECT tb_modelo.nm_modelo, tb_fabricante.nm_fabricante FROM tb_modelo INNER JOIN tb_fabricante ON (tb_modelo.cd_fabricanteModelo = tb_fabricante.cd_fabricante);";

                    MySqlCommand comando4 = new MySqlCommand(sql3, Conexao);

                    Conexao.Open();

                    comando4.CommandType = CommandType.Text;

                    MySqlDataAdapter da = new MySqlDataAdapter(comando4);

                    DataTable componentes = new DataTable();

                    da.Fill(componentes);

                    dataGridView1.DataSource = componentes;

                    DataGridViewColumn coluna0 = dataGridView1.Columns[0];
                    coluna0.Width = 470;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cbFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
