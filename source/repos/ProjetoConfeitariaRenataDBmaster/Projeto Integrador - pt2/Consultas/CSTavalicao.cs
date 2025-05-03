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

namespace Projeto_Integrador___pt2.Consultas
{
    public partial class CSTavalicao : Form
    {
        Conection cntn = new Conection();
        public CSTavalicao()
        {
            InitializeComponent();
        }

        private void avaliacaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.avaliacaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void CSTavalicao_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.avaliacao'. Você pode movê-la ou removê-la conforme necessário.
            this.avaliacaoTableAdapter.Fill(this.renataDBDataSet.avaliacao);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    string sql = "SELECT * FROM avaliacao WHERE id_avaliacao = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable avaliacao = new DataTable();
                    adapter.Fill(avaliacao);
                    avaliacaoDataGridView.DataSource = avaliacao;
                }
                if (cbmFiltrar.Text == "Cliente")
                {
                    string sql = "SELECT * FROM avaliacao WHERE nota_avaliacao LIKE '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable avaliacao = new DataTable();
                    adapter.Fill(avaliacao);
                    avaliacaoDataGridView.DataSource = avaliacao;
                }
                if (cbmFiltrar.Text == "Cliente")
                {
                    string sql = "SELECT * FROM avaliacao WHERE FKid_cliente LIKE '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable avaliacao = new DataTable();
                    adapter.Fill(avaliacao);
                    avaliacaoDataGridView.DataSource = avaliacao;
                }
                if (cbmFiltrar.Text == "Produto")
                {
                    string sql = "SELECT * FROM avaliacao WHERE FKid_produto LIKE '%" + txtPesquisar.Text + "%'";
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
    }
}
/* */