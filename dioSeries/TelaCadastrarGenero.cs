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
    public partial class TelaCadastrarGenero : Form
    {
        private bool EhEdicao = false;
        public TelaCadastrarGenero(int id = 0)
        {
            InitializeComponent();
            if (id != 0)
            {
                try
                {
                    EhEdicao = true;
                    lblTitulo.Text = "Alterar cadastro";
                    btnAlterar.Visible = false;
                    btnDeletar.Visible = false;

                    Genero genero = new Genero();
                    Genero dados_genero = genero.getGeneroPeloID(id);
                    txtId.Text = dados_genero.Id.ToString();
                    txtNome.Text = dados_genero.Nome;

                }
                catch(Exception er)
                {
                    MessageBox.Show(er.Message);
                }
                
            }
            else
            {
                EhEdicao = false;
                lblTitulo.Text = "Cadastro";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TelaCadastrarGenero_Load(object sender, EventArgs e)
        {
            Recarregar();
        }

        public void Recarregar()
        {
            Genero genero = new Genero();
            dataGridView1.DataSource = genero.Listar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
               Genero genero = new Genero(txtNome.Text );
                if (EhEdicao == true)
                {
                    genero.Id = int.Parse(txtId.Text.ToString());
                    if (genero.Alterar() == true)
                    {
                        MessageBox.Show("Registro alterado com sucesso!");
                        Recarregar();
                    }
                }
                else
                {
                    if (genero.Incluir() == true)
                    {
                        MessageBox.Show("Registro cadastrado com sucesso!");
                        Recarregar();
                    }
                }
                genero = null;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int ID = int.Parse(dataGridView1.SelectedRows[0].Cells["CODIGO"].Value.ToString());
                TelaCadastrarGenero alterargenero = new TelaCadastrarGenero(ID);
                if (alterargenero.ShowDialog() == DialogResult.OK)
                {
                    Recarregar();
                }
            }
            else
            {
                MessageBox.Show("Selecione apenas um registro!");
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja remover o item(S) selecionados?", "REMOVER", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        int ID = int.Parse(dataGridView1.SelectedRows[i].Cells["CODIGO"].Value.ToString());
                        Genero genero = new Genero();

                        if (genero.Excluir(ID))
                        {
                            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
                            dataGridView1.DataSource = genero.Listar();
                        }
                    }
                    MessageBox.Show("Dado(s) delatado(s) com sucesso!");

                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
