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
    public partial class frmEstoque : Form
    {
        Conection cntn = new Conection();
        public frmEstoque()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.limparCampos();
        }
        public void limparCampos()
        {
            fKid_ingredienteTextBox1.Text = "";
            tipo_movimentacaoTextBox1.Text = "";
            id_estoqueTextBox1.Text = "";
            data_movimentacaoDateTimePicker1.Text = "";
            quantidade_movimentadaTextBox1.Text = "";
        }
        private void frmEstoque_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet1.estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter1.Fill(this.renataDBDataSet1.estoque);
            this.estoqueBindingSource1.DataSource = this.renataDBDataSet1.estoque;
           
        }

        private void estoqueBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estoqueBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.renataDBDataSet1);
            this.limparCampos();
        }

        private void estoqueDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.toolStripButton5.PerformClick();
                this.limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir novo registro: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try 
            { 
                this.toolStripButton6.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir registro: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.estoqueBindingSource1BindingNavigatorSaveItem_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar registro: " + ex.Message);
            }
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void fKid_ingredienteTextBox1_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
