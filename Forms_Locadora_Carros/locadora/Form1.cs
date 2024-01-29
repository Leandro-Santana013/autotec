using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace locadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void fabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fabricante = new locadora.Form3();
            fabricante.ShowDialog();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 city = new locadora.Form2();
            city.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente cliente = new locadora.Cliente();
            cliente.ShowDialog();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modelo modelo = new locadora.Modelo();
            modelo.ShowDialog();
        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carro carro = new locadora.Carro();
            carro.ShowDialog();
        }

        private void alugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alugar alugar = new locadora.Alugar();
            alugar.ShowDialog();
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolução devolucao = new locadora.Devolução();
            devolucao.ShowDialog();
        }
    }
}
