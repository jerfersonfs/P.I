using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador___pt2.Formulários
{
    public partial class frmAvaliacao: Form
    {
        Conection cntn = new Conection();
        public frmAvaliacao()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void avaliacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avaliacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void frmAvaliacao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.renataDBDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.renataDBDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.avaliacao'. Você pode movê-la ou removê-la conforme necessário.
            this.avaliacaoTableAdapter.Fill(this.renataDBDataSet.avaliacao);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    string sql = "SELECT * FROM Avaliacao WHERE id_avaliacao = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable avaliacao = new DataTable();
                    adapter.Fill(avaliacao);
                    avaliacaoDataGridView.DataSource = avaliacao;
                }
                if (cbmFiltrar.Text == "Usuário")
                {
                    string sql = "SELECT * FROM Avaliacao WHERE nota_avaliacao LIKE '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable avaliacao = new DataTable();
                    adapter.Fill(avaliacao);
                    avaliacaoDataGridView.DataSource = avaliacao;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cntn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_avaliacaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void fKid_produtoLabel_Click(object sender, EventArgs e)
        {

        }

        private void fKid_clienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void nota_avaliacaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void comentario_avaliacaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void data_avaliacaoLabel_Click(object sender, EventArgs e)
        {

        }

        private void fKid_clienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fKid_produtoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_clienteTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlTransaction transaction = cntn.Connection.BeginTransaction();
            try
            {
                using (SqlConnection cntn = new SqlConnection())
                {
                    cntn.Open();
                    string query = "INSERT INTO Avaliacao(FKid_cliente) WHERE nome_usu = nome_cli AND celular_usu = celular_cli AND ** VALUES Cliente(id_cliente) ";
                    using (SqlCommand cmd = new SqlCommand(query, cntn, transaction))
                    {
                        cmd.Parameters.AddWithValue("id_cliente", id_clienteTextBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
                MessageBox.Show("ID do cliente inserido com sucesso!");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao inserir ID do cliente: " + ex.Message);
            }
        }

        private void id_produtoTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlTransaction transaction = cntn.Connection.BeginTransaction();
            try
            {
                using (SqlConnection cntn = new SqlConnection())
                {
                    cntn.Open();
                    string query = "INSERT INTO Produto(FKid_produto) WHERE ** VALUES Cliente(id_produto) ";
                    using (SqlCommand cmd = new SqlCommand(query, cntn, transaction))
                    {
                        cmd.Parameters.AddWithValue("id_produto", id_produtoTextBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
                MessageBox.Show("ID do produto inserido com sucesso!");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao inserir ID do produto: " + ex.Message);
            }
        }
    }
}
