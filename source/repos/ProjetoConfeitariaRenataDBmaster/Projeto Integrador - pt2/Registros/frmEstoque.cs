using Projeto_Integrador___pt2.Consultas;
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
    public partial class frmEstoque: Form
    {
        Conection cntn = new Conection();
        public frmEstoque()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void estoqueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estoqueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.ingredientes'. Você pode movê-la ou removê-la conforme necessário.
            this.ingredientesTableAdapter.Fill(this.renataDBDataSet.ingredientes);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter.Fill(this.renataDBDataSet.estoque);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    string sql = "SELECT * FROM Estoque WHERE id_estoque = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable estoque = new DataTable();
                    adapter.Fill(estoque);
                    estoqueDataGridView.DataSource = estoque;
                }
                if (cbmFiltrar.Text == "Usuário")
                {
                    string sql = "SELECT * FROM Estoque WHERE nome_estoque LIKE '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable  estoque = new DataTable();
                    adapter.Fill(estoque);
                    estoqueDataGridView.DataSource = estoque;
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
        private void id_ingredienteTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT*FROM ingrediente WHERE id_ingrediente = @id_ingrediente";
                SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                cmd.Parameters.AddWithValue("@id_ingrediente", fKid_ingredienteTextBox.Text);
                cntn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar o nome do ingrediente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cntn.Close();
            }
        }
        private void frmEstoque_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet1.estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter1.Fill(this.renataDBDataSet1.estoque);

        }

        private void estoqueBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estoqueBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.renataDBDataSet1);

        }

        private void estoqueDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorAddNewItem.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorDeleteItem.PerformClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.estoqueBindingNavigatorSaveItem_Click(sender, e);
        }
        public void exibirConsulta()
        {
            CSTestoque cst = new CSTestoque();
            cst.ShowDialog();
        }   
        private void button6_Click(object sender, EventArgs e)
        {
           this.exibirConsulta();
        }
    }
}
