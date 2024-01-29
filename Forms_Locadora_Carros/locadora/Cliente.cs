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
    public partial class Cliente : Form
    {
        private int cdCidade;

        private MySqlConnection Conexao;

        private string data_source = "datasource=localhost;username=root;password=root;database=db_locadora";
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost;username=root;password=root;database=db_locadora";

            Conexao = new MySqlConnection(data_source);

            string sql3 = "SELECT tb_cliente.nm_cliente, tb_cliente.cd_cpfCliente, tb_cliente.sg_sexoCliente, tb_cliente.qt_idadeCliente, tb_cliente.nmr_telefoneCliente, tb_cliente.cd_emailCliente, tb_cliente.nmr_habilitacaoCliente, tb_cliente.ed_enderecoCliente, tb_cidade.nm_cidade FROM tb_cliente INNER JOIN tb_cidade ON (tb_cliente.cd_cidadeCliente = tb_cidade.cd_cidade) ORDER BY cd_cidadeCliente;";

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

            string sql1 = "select nm_cidade from tb_cidade order by nm_cidade";

            Conexao.Open();

            MySqlCommand comando2 = new MySqlCommand(sql1, Conexao);

            MySqlDataReader reader = comando2.ExecuteReader();

            cbCidade.Items.Clear();

            while (reader.Read())
            {
                cbCidade.Items.Add(reader.GetString("nm_cidade"));
            }
            Conexao.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHabilitacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(txtCpf.Text) && !String.IsNullOrEmpty(txtIdade.Text) && !String.IsNullOrEmpty(txtTelefone.Text) && !String.IsNullOrEmpty(cbxSexo.Text) && !String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtHabilitacao.Text) && !String.IsNullOrEmpty(txtEndereco.Text) && !String.IsNullOrEmpty(cbCidade.Text))
            {
                try
                {
                    Conexao = new MySqlConnection(data_source);

                    string sql4 = "select cd_cidade from tb_cidade where nm_cidade = '" + cbCidade.Text + "'";

                    MySqlCommand comandoCid = new MySqlCommand(sql4, Conexao);

                    Conexao.Open();

                    MySqlDataReader readerCid = comandoCid.ExecuteReader();

                    while (readerCid.Read())
                    {
                        cdCidade = (readerCid.GetInt32(0));
                    }

                    Conexao.Close();

                    string sql = "INSERT INTO tb_cliente (nm_cliente, cd_cpfCliente, sg_sexoCliente, qt_idadeCliente, nmr_telefoneCliente, cd_emailCliente, nmr_habilitacaoCliente, ed_enderecoCliente, cd_cidadeCliente) VALUES ('" + txtNome.Text + "', '" + txtCpf.Text + "', '" + cbxSexo.Text + "', '" + txtIdade.Text + "', '" + txtTelefone.Text + "', '" + txtEmail.Text + "', '" + txtHabilitacao.Text + "', '" + txtEndereco.Text + "', '" + cdCidade + "')";

                    MySqlCommand comando = new MySqlCommand(sql, Conexao);

                    Conexao.Open();

                    comando.ExecuteReader();

                    MessageBox.Show("Inserido com Sucesso !!!");
                    txtNome.Text = "";
                    txtCpf.Text = "";
                    cbxSexo.Text = null;
                    txtIdade.Text = "";
                    txtTelefone.Text = "";
                    txtEmail.Text = "";
                    txtHabilitacao.Text = "";
                    txtEndereco.Text = "";
                    cbCidade.Text = "";

                    Conexao.Close();

                    string sql3 = "SELECT tb_cliente.nm_cliente, tb_cliente.cd_cpfCliente, tb_cliente.sg_sexoCliente, tb_cliente.qt_idadeCliente, tb_cliente.nmr_telefoneCliente, tb_cliente.cd_emailCliente, tb_cliente.nmr_habilitacaoCliente, tb_cliente.ed_enderecoCliente, tb_cidade.nm_cidade FROM tb_cliente INNER JOIN tb_cidade ON (tb_cliente.cd_cidadeCliente = tb_cidade.cd_cidade) ORDER BY cd_cidadeCliente;";

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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Hide()                                                             ;
        }

        private void cbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCad_MouseMove(object sender, MouseEventArgs e)
        {
            btnCad.FillColor = Color.Orange;
        }


        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
