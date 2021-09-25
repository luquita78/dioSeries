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
    public partial class TelaCadastrarSerie : Form
    {
        private bool EhEdicao = false;
        public TelaCadastrarSerie(int id = 0)
        {
            InitializeComponent();
            if (id != 0)
            {
                try
                {
                    EhEdicao = true;
                    lblTitulo.Text = ("Alteração de cadastro de Série");
                    btnExcluir.Visible = false;
                    btnAlterar.Visible = false;
                    Serie serie = new Serie();
                    Serie dados_serie = serie.getSeriePeloID(id);

                    txtId.Text = dados_serie.Id.ToString();
                    txtTitulo.Text = dados_serie.Nome;
                    txtAno.Text = dados_serie.AnoLancamento.ToString();
                    txtDesc.Text = dados_serie.Descricao;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }
            }
            else
            {
                EhEdicao = false;
                lblTitulo.Text = "Cadastro de série";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadastrarSerie_Load(object sender, EventArgs e)
        {
            Recarregar();
        }

        public void Recarregar()
        {
            Serie serie = new Serie();
            dataGridView1.DataSource = serie.Listar();        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 )
            {
                int ID = int.Parse(dataGridView1.SelectedRows[0].Cells["CODIGO"].Value.ToString());
                TelaCadastrarSerie alterarSerie = new TelaCadastrarSerie(ID);
                if(alterarSerie.ShowDialog() == DialogResult.OK)
                {
                    Recarregar();
                }
            }
            else
            {
                MessageBox.Show("Selecione apenas um registro!");
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Serie serie = new Serie(txtTitulo.Text, txtDesc.Text, int.Parse(txtAno.Text.ToString()));
                if (EhEdicao == true)
                {
                    serie.Id = int.Parse(txtId.Text.ToString());
                    if(serie.Alterar() == true)
                    {
                        MessageBox.Show("Série alterada com sucesso!");
                        Recarregar();
                    }
                }
                else
                {
                    if(serie.Incluir() == true)
                    {
                        MessageBox.Show("Série cadastrada com sucesso!");
                        Recarregar();
                    }
                }
                serie = null;
                this.DialogResult = DialogResult.OK;
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Deseja remover o item(S) selecionados?","REMOVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i <= dataGridView1.SelectedRows.Count; i++)
                    {
                        int ID = int.Parse(dataGridView1.SelectedRows[i].Cells["CODIGO"].Value.ToString());
                        Serie serie = new Serie();

                        if (serie.Excluir(ID))
                        {
                            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
                            dataGridView1.DataSource = serie.Listar();
                        }
                    }
                    MessageBox.Show("Série(s) delatada(s) com sucesso!");

                }
                
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
