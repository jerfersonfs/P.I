using Projeto_Integrador___pt2.Formulários;
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
    public partial class CSTproduto : Form
    {
        Conection cntn = new Conection();
        public CSTproduto()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void CSTproduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.renataDBDataSet.produto);

        }

        public void showfrmProduto() 
        {
            frmProduto frm = new frmProduto();
            frm.ShowDialog();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            this.showfrmProduto();
        }

        private void produtoBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.renataDBDataSet1);

        }

        private void CSTproduto_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet1.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter1.Fill(this.renataDBDataSet1.produto);
            this.produtoDataGridView.DataSource = this.produtoBindingSource1;
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbm_Filtrar.Text == "Código")
                {
                    string sql = "SELECT * FROM produto WHERE id_produto = " + txt_Pesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable produto = new DataTable();
                    adapter.Fill(produto);
                    produtoDataGridView.DataSource = produto;
                }
                if (cbm_Filtrar.Text == "Produto")
                {
                    string sql = "SELECT * FROM produto WHERE nome_produto LIKE '%" + txt_Pesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable produto = new DataTable();
                    adapter.Fill(produto);
                    produtoDataGridView.DataSource = produto;
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
