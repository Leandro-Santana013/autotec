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
    public partial class Alugar : Form
    {
        private int cdName;
        private int cdCarro;

        private MySqlConnection Conexao;

        private string data_source = "datasource=localhost;username=root;password=root;database=db_locadora";

        public Alugar()
        {
            InitializeComponent();
        }

        private void Alugar_Load(object sender, EventArgs e)
        {
            Conexao = new MySqlConnection(data_source);

            string sql1 = "select nm_cliente from tb_cliente order by nm_cliente";

            Conexao.Open();

            MySqlCommand comando1 = new MySqlCommand(sql1, Conexao);

            MySqlDataReader reader1 = comando1.ExecuteReader();

            cbName.Items.Clear();

            while (reader1.Read())
            {
                cbName.Items.Add(reader1.GetString("nm_cliente"));
            }
            Conexao.Close();

            string sql2 = "select id_placaCarro from tb_carro where cd_situacao = 'D' order by id_placaCarro;";

            Conexao.Open();

            MySqlCommand comando2 = new MySqlCommand(sql2, Conexao);

            MySqlDataReader reader2 = comando2.ExecuteReader();

            cbCarro.Items.Clear();

            while (reader2.Read())
            {
                cbCarro.Items.Add(reader2.GetString("id_placaCarro"));
            }
            Conexao.Close();

            Conexao = new MySqlConnection(data_source);

            string sql3 = "SELECT tb_cliente.nm_cliente, tb_carro.id_placaCarro, tb_locacao.dt_inicioLocacao, tb_locacao.dt_fimLocacao, tb_locacao.prc_valorAluguel FROM tb_locacao INNER JOIN tb_cliente ON tb_locacao.cd_cliente = tb_cliente.cd_cliente INNER JOIN tb_carro ON tb_locacao.cd_carro = tb_carro.cd_carro;";

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

        private void btnCad_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbName.Text) && !String.IsNullOrEmpty(cbCarro.Text) && !String.IsNullOrEmpty(txtInicio.Text) && !String.IsNullOrEmpty(txtFim.Text) && !String.IsNullOrEmpty(txtLoc.Text))
            {
                try
                {
                    string sql4 = "select cd_cliente from tb_cliente where nm_cliente = '" + cbName.Text + "'";

                    MySqlCommand comandoName = new MySqlCommand(sql4, Conexao);

                    Conexao.Open();

                    MySqlDataReader readerName = comandoName.ExecuteReader();

                    while (readerName.Read())
                    {
                        cdName = (readerName.GetInt32(0));
                    }

                    Conexao.Close();

                    string sql5 = "select cd_carro from tb_carro where id_placaCarro = '" + cbCarro.Text + "'";

                    MySqlCommand comandoCarro = new MySqlCommand(sql5, Conexao);

                    Conexao.Open();

                    MySqlDataReader readerCarro = comandoCarro.ExecuteReader();

                    while (readerCarro.Read())
                    {
                        cdCarro = (readerCarro.GetInt32(0));
                    }

                    Conexao.Close();

                    bool dtInicio = DateTime.TryParse(txtInicio.Text, out DateTime data_inicio);
                    bool dtFim = DateTime.TryParse(txtFim.Text, out DateTime data_fim);

                    bool dtInicioB = DateTime.TryParse(txtInicio.Text, out DateTime data_inicioIn);
                    string dataInicio = data_inicioIn.ToString("yyyy/MM/dd");

                    bool dtFimB = DateTime.TryParse(txtFim.Text, out DateTime data_fimIn);
                    string dataFim = data_fimIn.ToString("yyyy/MM/dd");

                    string sql = "INSERT INTO tb_locacao (cd_cliente, cd_carro, dt_inicioLocacao, dt_fimLocacao, prc_valorAluguel) VALUES (" + cdName + ", " + cdCarro + ", '" + dataInicio + "', '" + dataFim + "', '" + txtLoc.Text + "')";

                    MySqlCommand comando = new MySqlCommand(sql, Conexao);

                    Conexao.Open();

                    comando.ExecuteReader();

                    Conexao.Close();

                    Conexao = new MySqlConnection(data_source);

                    string sql9 = "UPDATE tb_carro SET cd_situacao = 'A' WHERE cd_carro IN (SELECT " + cdCarro + " FROM tb_locacao);";

                    MySqlCommand comandoUpdate = new MySqlCommand(sql9, Conexao);

                    Conexao.Open();

                    comandoUpdate.ExecuteReader();

                    MessageBox.Show("Inserido com Sucesso !!!");
                    cbName.Text = "";
                    cbCarro.Text = "";
                    txtInicio.Text = "";
                    txtFim.Text = "";
                    txtLoc.Text = "";

                    Conexao.Close();

                    Conexao = new MySqlConnection(data_source);

                    string sql3 = "SELECT tb_cliente.nm_cliente, tb_carro.id_placaCarro, tb_locacao.dt_inicioLocacao, tb_locacao.dt_fimLocacao, tb_locacao.prc_valorAluguel FROM tb_locacao INNER JOIN tb_cliente ON tb_locacao.cd_cliente = tb_cliente.cd_cliente INNER JOIN tb_carro ON tb_locacao.cd_carro = tb_carro.cd_carro;";

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

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCarro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtLoc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
