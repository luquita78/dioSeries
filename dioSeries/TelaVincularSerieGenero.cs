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


namespace dioSeries
{
    public partial class TelaVincularSerieGenero : Form
    {
        public TelaVincularSerieGenero()
        {
            InitializeComponent();
        }

        private void TelaVincularSerieGenero_Load(object sender, EventArgs e)
        {
            Recarregar();

          
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Recarregar()
        {
            Serie serie = new Serie();
            dgvSerie.DataSource = serie.Listar();

            Genero genero = new Genero();
            dgvGenero.DataSource = genero.Listar();

            GeneroSerie generoSerie = new GeneroSerie();
            dgvGeneroSerie.DataSource = generoSerie.Listar();
        }

        private void btnVincular_Click(object sender, EventArgs e)
        {
            try
            {
                GeneroSerie generoSerie = new GeneroSerie(int.Parse(this.txtSerie.Text.ToString()),int.Parse(this.txtGenero.Text.ToString()));
               
                if (generoSerie.VincularGeneroSerie() == true)
                {
                    MessageBox.Show("Registro realizado com sucesso!");
                    Recarregar();
                }
                
                generoSerie = null;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);

            }
        }
    }
}
