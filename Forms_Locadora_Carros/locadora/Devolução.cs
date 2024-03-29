﻿using System;
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
    public partial class Devolução : Form
    {
        private int cdName;
        private int cdCarro;
        private int cdLoc;

        private MySqlConnection Conexao;

        private string data_source = "datasource=localhost;username=root;password=root;database=db_locadora";

        public Devolução()
        {
            InitializeComponent();
        }

        private void Devolução_Load(object sender, EventArgs e)
        {
            Conexao = new MySqlConnection(data_source);

            string sql1 = "SELECT c.nm_cliente FROM tb_locacao l INNER JOIN tb_cliente c ON l.cd_cliente = c.cd_cliente INNER JOIN tb_carro car ON l.cd_carro = car.cd_carro WHERE l.dt_devolucaoFinal IS NULL;";

            Conexao.Open();

            MySqlCommand comando1 = new MySqlCommand(sql1, Conexao);

            MySqlDataReader reader1 = comando1.ExecuteReader();

            cbName.Items.Clear();

            while (reader1.Read())
            {
                cbName.Items.Add(reader1.GetString("nm_cliente"));
            }
            Conexao.Close();

            string sql2 = "SELECT car.id_placaCarro FROM tb_locacao l INNER JOIN tb_cliente c ON l.cd_cliente = c.cd_cliente INNER JOIN tb_carro car ON l.cd_carro = car.cd_carro WHERE l.dt_devolucaoFinal IS NULL;";

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

            string sql3 = "SELECT c.nm_cliente, car.id_placaCarro, l.prc_valorFinal, l.dt_devolucaoFinal, l.qt_diasExcedidos, l.prc_valorMulta FROM tb_locacao l INNER JOIN tb_cliente c ON l.cd_cliente = c.cd_cliente INNER JOIN tb_carro car ON l.cd_carro = car.cd_carro;";

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
            if (!String.IsNullOrEmpty(cbName.Text) && !String.IsNullOrEmpty(cbCarro.Text) && !String.IsNullOrEmpty(dtFinal.Text) && !String.IsNullOrEmpty(txtValorFinal.Text))
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

                    bool dtFim = DateTime.TryParse(dtFinal.Text, out DateTime data_fim);

                    bool dtFimB = DateTime.TryParse(dtFinal.Text, out DateTime data_fimIn);
                    string dataFim = data_fimIn.ToString("yyyy/MM/dd");

                    string sql = "UPDATE tb_locacao SET prc_valorFinal = '" + txtValorFinal.Text + "', dt_devolucaoFinal = '" + dataFim + "', qt_diasExcedidos = '" + dtAtraso.Text + "', prc_valorMulta = '" + txtMulta.Text + "' WHERE cd_cliente = " + cdName + ";";

                    MySqlCommand comando = new MySqlCommand(sql, Conexao);

                    Conexao.Open();

                    comando.ExecuteReader();

                    Conexao.Close();

                    Conexao = new MySqlConnection(data_source);

                    string sql9 = "UPDATE tb_carro SET cd_situacao = 'D' WHERE cd_carro IN (SELECT " + cdCarro + " FROM tb_locacao);";

                    MySqlCommand comandoUpdate = new MySqlCommand(sql9, Conexao);

                    Conexao.Open();

                    comandoUpdate.ExecuteReader();

                    MessageBox.Show("Inserido com Sucesso !!!");
                    cbName.Text = "";
                    cbCarro.Text = "";
                    txtMulta.Text = "";
                    txtValorFinal.Text = "";
                    dtFinal.Text = "";

                    Conexao.Close();

                    Conexao = new MySqlConnection(data_source);

                    string sql3 = "SELECT c.nm_cliente, car.id_placaCarro, l.prc_valorFinal, l.dt_devolucaoFinal, l.qt_diasExcedidos, l.prc_valorMulta FROM tb_locacao l INNER JOIN tb_cliente c ON l.cd_cliente = c.cd_cliente INNER JOIN tb_carro car ON l.cd_carro = car.cd_carro;";

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
            this.Hide();
        }

        private void txtMulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCarro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtAtraso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
