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
    public partial class Carro : Form
    {
        private int cdFabricante;
        private int cdModelo;

        private MySqlConnection Conexao;

        private string data_source = "datasource=localhost;username=root;password=root;database=db_locadora";
        public Carro()
        {
            InitializeComponent();
        }

        private void Carro_Load(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost;username=root;password=root;database=db_locadora";

            Conexao = new MySqlConnection(data_source);

            string sql3 = "SELECT tb_carro.id_placaCarro, tb_carro.id_chassiCarro, tb_carro.ano_fabricacaoCarro, tb_carro.nm_corCarro, tb_modelo.nm_modelo, tb_fabricante.nm_fabricante, tb_carro.qt_precoDiaria FROM tb_carro INNER JOIN tb_modelo ON tb_carro.cd_modeloCarro = tb_modelo.cd_modelo INNER JOIN tb_fabricante ON tb_carro.cd_fabricanteCarro = tb_fabricante.cd_fabricante;";

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

            string sql1 = "select nm_fabricante from tb_fabricante order by nm_fabricante";

            Conexao.Open();

            MySqlCommand comando2 = new MySqlCommand(sql1, Conexao);

            MySqlDataReader readerFab = comando2.ExecuteReader();

            cbFabricante.Items.Clear();

            while (readerFab.Read())
            {
                cbFabricante.Items.Add(readerFab.GetString("nm_fabricante"));
            }
            Conexao.Close();

            Conexao = new MySqlConnection(data_source);

            string sql2 = "select nm_modelo from tb_modelo order by nm_modelo";

            Conexao.Open();

            MySqlCommand comando3 = new MySqlCommand(sql2, Conexao);

            MySqlDataReader readerMod = comando3.ExecuteReader();

            cbModelo.Items.Clear();

            while (readerMod.Read())
            {
                cbModelo.Items.Add(readerMod.GetString("nm_modelo"));
            }
            Conexao.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(cbFabricante.Text) && !String.IsNullOrEmpty(cbModelo.Text) && !String.IsNullOrEmpty(txtPlaca.Text) && !String.IsNullOrEmpty(cbSituacao.Text))
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

                    string sql6 = "select cd_modelo from tb_modelo where nm_modelo = '" + cbModelo.Text + "'";

                    MySqlCommand comandoMod = new MySqlCommand(sql4, Conexao);

                    Conexao.Open();

                    MySqlDataReader readerMod = comandoMod.ExecuteReader();

                    while (readerMod.Read())
                    {
                        cdModelo = (readerMod.GetInt32(0));
                    }

                    Conexao.Close();

                    string sql = "INSERT INTO tb_carro (id_placaCarro, id_chassiCarro, ano_fabricacaoCarro, nm_corCarro, cd_modeloCarro, cd_fabricanteCarro, cd_situacao, qt_precoDiaria) VALUES ('" + txtPlaca.Text + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + txtCor.Text + "', '" + cdModelo + "', '" + cdFabricante + "', '"+ cbSituacao.Text + "', '" + txtPreco.Text + "')";

                    MySqlCommand comando = new MySqlCommand(sql, Conexao);

                    Conexao.Open();

                    comando.ExecuteReader();

                    MessageBox.Show("Inserido com Sucesso !!!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    cbFabricante.Text = "";
                    cbModelo.Text = "";
                    txtPlaca.Text = "";
                    txtCor.Text = "";
                    cbSituacao.Text = "";

                    Conexao.Close();

                    string sql3 = "SELECT tb_carro.id_placaCarro, tb_carro.id_chassiCarro, tb_carro.ano_fabricacaoCarro, tb_carro.nm_corCarro, tb_modelo.nm_modelo, tb_fabricante.nm_fabricante, tb_carro.qt_precoDiaria FROM tb_carro INNER JOIN tb_modelo ON tb_carro.cd_modeloCarro = tb_modelo.cd_modelo INNER JOIN tb_fabricante ON tb_carro.cd_fabricanteCarro = tb_fabricante.cd_fabricante;";

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

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void cbFabricante_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void cbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
