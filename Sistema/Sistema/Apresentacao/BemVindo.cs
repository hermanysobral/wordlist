using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Apresentacao
{
    public partial class BemVindo : Form
    {
        public BemVindo()
        {
            InitializeComponent();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BemVindo_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'sistemaDataSet.logins'. Você pode movê-la ou removê-la conforme necessário.
            this.loginsTableAdapter.Fill(this.sistemaDataSet.logins);
            // TODO: esta linha de código carrega dados na tabela 'sistemaDataSet.palavras'. Você pode movê-la ou removê-la conforme necessário.
            this.palavrasTableAdapter.Fill(this.sistemaDataSet.palavras);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarPalavra cdp = new CadastrarPalavra();
            cdp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Hide();
        }
    }
}
