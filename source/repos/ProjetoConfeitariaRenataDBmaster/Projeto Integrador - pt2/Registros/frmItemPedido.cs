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
    public partial class frmItemPedido: Form
    {
        Conection cntn = new Conection();
        public frmItemPedido()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void item_pedidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.item_pedidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void frmItemPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidoTableAdapter.Fill(this.renataDBDataSet.pedido);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.renataDBDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.item_pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.item_pedidoTableAdapter.Fill(this.renataDBDataSet.item_pedido);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    string sql = "SELECT * FROM Item_pedido WHERE id_item_pedido = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable itp = new DataTable();
                    adapter.Fill(itp);
                    item_pedidoDataGridView.DataSource = itp;
                }
                if (cbmFiltrar.Text == "Item Pedido")
                {
                    string sql = "SELECT * FROM Item_pedido WHERE FKid_produto LIKE '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable itp = new DataTable();
                    adapter.Fill(itp);
                    item_pedidoDataGridView.DataSource = itp;
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

        private void id_pedidoLabel_Click(object sender, EventArgs e)
        {

        }

        private void id_pedidoTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlTransaction transaction = cntn.Connection.BeginTransaction();
            try
            {
                using (SqlConnection cntn = new SqlConnection())
                {
                    cntn.Open();
                    string query = "INSERT INTO ItemPedido(FKid_pedido) WHERE VALUES Pedido(id_pedido) ";
                    using (SqlCommand cmd = new SqlCommand(query, cntn, transaction))
                    {
                        cmd.Parameters.AddWithValue("id_pedido", id_pedidoTextBox.Text);
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

        private void id_produtoTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlTransaction transaction = cntn.Connection.BeginTransaction();
            try
            {
                using (SqlConnection cntn = new SqlConnection())
                {
                    cntn.Open();
                    string query = "INSERT INTO ItemPedido(FKid_produto) WHERE VALUES Produto(id_produto) ";
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
