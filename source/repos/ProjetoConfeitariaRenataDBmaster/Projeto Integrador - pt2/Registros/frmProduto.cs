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
    public partial class frmProduto: Form
    {
        Conection cntn = new Conection();
        public frmProduto()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void LimparCampos()
        {
            id_produtoTextBox.Text="";
            nome_produtoTextBox.Text = "";
            preco_produtoTextBox.Text = "";
            fKid_categoriaTextBox.Text = "";
            promocaoTextBox.Text = "";
        }
        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);
            this.LimparCampos();
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter.Fill(this.renataDBDataSet.categoria);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.renataDBDataSet.produto);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           
        }
        
 
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorAddNewItem.PerformClick();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorDeleteItem.PerformClick();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.produtoBindingNavigatorSaveItem.PerformClick();
            frmProduto produto = new frmProduto();
            produto.Close();
        }

        private void fKid_categoriaTextBox_TextChanged(object sender, EventArgs e)
        {
            try 
            { 
                using (SqlConnection conn = new SqlConnection(cntn.connectionString))
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO Produto (nome_produto, preco_produto, FKid_categoria, promocao)
                        SELECT @nome_produto, @preco_produto, c.id_categoria, @promocao
                        FROM Categoria c
                        WHERE c.id_categoria = @id_categoria";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome_produto", nome_produtoTextBox.Text);
                        cmd.Parameters.AddWithValue("@preco_produto", preco_produtoTextBox.Text);
                        cmd.Parameters.AddWithValue("@id_categoria", fKid_categoriaTextBox.Text);
                        cmd.Parameters.AddWithValue("@promocao", promocaoTextBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível inserir valor da categoria" + ex);
            }
        }
    }
}
