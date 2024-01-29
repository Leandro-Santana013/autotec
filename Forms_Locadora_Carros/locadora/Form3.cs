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
    public partial class Form3 : Form
    {
        private MySqlConnection Conexao;

        private string data_source = "datasource=localhost;username=root;password=root;database=db_locadora";

        public Form3()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbfab.Text))
            {
                MessageBox.Show("Favor informar o nome do componente", "Aviso");
                txtbfab.Focus();
            }

            else
            {
                try
                {
                    Conexao = new MySqlConnection(data_source);

                    string sql = "INSERT INTO tb_fabricante (nm_fabricante) VALUES ('" + txtbfab.Text + "')";

                    MySqlCommand comando = new MySqlCommand(sql, Conexao);

                    Conexao.Open();

                    comando.ExecuteReader();

                    MessageBox.Show("Inserido com Sucesso !!!");
                    txtbfab.Text = "";
                    txtbfab.Focus();

                    Conexao.Close();

                    string sql3 = "SELECT nm_fabricante AS Fabricante FROM tb_fabricante AS fabri ORDER BY fabri.nm_fabricante; ";

                    MySqlCommand comando4 = new MySqlCommand(sql3, Conexao);

                    Conexao.Open();

                    comando4.CommandType = CommandType.Text;

                    MySqlDataAdapter da = new MySqlDataAdapter(comando4);


                    DataTable componentes = new DataTable();


                    da.Fill(componentes);

                    dgv.DataSource = componentes;


                    DataGridViewColumn coluna0 = dgv.Columns[0];
                    coluna0.Width = 400;
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
    }


        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost;username=root;password=root;database=db_locadora";

            Conexao = new MySqlConnection(data_source);

            string sql3 = "SELECT nm_fabricante AS Fabricante FROM tb_fabricante AS fabri ORDER BY fabri.nm_fabricante;";

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
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
