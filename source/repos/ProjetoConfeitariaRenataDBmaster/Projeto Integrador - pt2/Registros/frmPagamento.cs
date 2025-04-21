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
    public partial class frmPagamento: Form
    {
        Conection cntn = new Conection();
        public frmPagamento()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pagamentoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pagamentoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.eventos'. Você pode movê-la ou removê-la conforme necessário.
            this.eventosTableAdapter.Fill(this.renataDBDataSet.eventos);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidoTableAdapter.Fill(this.renataDBDataSet.pedido);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.pagamento'. Você pode movê-la ou removê-la conforme necessário.
            this.pagamentoTableAdapter.Fill(this.renataDBDataSet.pagamento);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    string sql = "SELECT * FROM Pagamento WHERE id_pagamento = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable pag = new DataTable();
                    adapter.Fill(pag);
                    pagamentoDataGridView.DataSource = pag;
                }
                if (cbmFiltrar.Text == "Usuário")
                {
                    string sql = "SELECT * FROM Pagamento WHERE FKid_pedido LIKE '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable pag = new DataTable();
                    adapter.Fill(pag);
                    pagamentoDataGridView.DataSource = pag;
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

        private void id_pedidoTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlTransaction transaction = cntn.Connection.BeginTransaction();
            try
            {
                using (SqlConnection cntn = new SqlConnection())
                {
                    cntn.Open();
                    string query = "INSERT INTO Pagamento(FKid_pedido) WHERE  VALUES Pedido(id_pedido) ";
                    using (SqlCommand cmd = new SqlCommand(query, cntn, transaction))
                    {
                        cmd.Parameters.AddWithValue("id_pedido", id_pedidoTextBox);
                        cmd.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
                MessageBox.Show("ID do pedido inserido com sucesso!");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao inserir ID do pedido: " + ex.Message);
            }
        }

        private void id_eventoTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlTransaction transaction = cntn.Connection.BeginTransaction();
            try
            {
                using (SqlConnection cntn = new SqlConnection())
                {
                    cntn.Open();
                    string query = "INSERT INTO Pagamento(FKid_evento) WHERE VALUES Eventos(id_evento) ";
                    using (SqlCommand cmd = new SqlCommand(query, cntn, transaction))
                    {
                        cmd.Parameters.AddWithValue("id_evento", id_eventoTextBox);
                        cmd.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
                MessageBox.Show("ID do evento inserido com sucesso!");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Erro ao inserir ID do evento: " + ex.Message);
            }
        }
    }
}
