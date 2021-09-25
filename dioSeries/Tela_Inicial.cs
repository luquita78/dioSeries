using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dioSeries
{
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrarSeries_Click(object sender, EventArgs e)
        {
            TelaCadastrarSerie telaCadastrarSerie = new TelaCadastrarSerie(0);
            telaCadastrarSerie.Show();
        }

        private void btnGenero_Click(object sender, EventArgs e)
        {
            TelaCadastrarGenero telagenero = new TelaCadastrarGenero(0);
            telagenero.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaVincularSerieGenero vincularSerieGenero = new TelaVincularSerieGenero();
            vincularSerieGenero.Show();
        }
    }
}
