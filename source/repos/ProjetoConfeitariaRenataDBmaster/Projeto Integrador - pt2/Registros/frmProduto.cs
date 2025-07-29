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
    public partial class frmProduto: Form
    {
        Conection cntn = new Conection();
        public frmProduto()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.LimparCampos();
        }
        public void LimparCampos()
        {
            id_produtoTextBox1.Text="";
            nome_produtoTextBox1.Text = "";
            preco_produtoTextBox1.Text = "";
            fKid_categoriaTextBox1.Text = "";
            promocaoTextBox1.Text = "";
        }
       
      
        private void produtoBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void frmProduto_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet1.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter1.Fill(this.renataDBDataSet1.produto);
            this.produtoBindingSource1.DataSource = this.renataDBDataSet1.produto;
            this.LimparCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.toolStripButton5.PerformClick();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Erro ao incluir produto: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try 
            {
                this.toolStripButton6.PerformClick();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Erro ao excluir produto: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.produtoBindingSource1.EndEdit();
                this.tableAdapterManager1.UpdateAll(this.renataDBDataSet1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar produto: " + ex.Message);
            }
        }
        public void exibirConsulta() 
        { 
            CSTproduto cSTproduto = new CSTproduto();
            cSTproduto.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.exibirConsulta();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }
    }
}
