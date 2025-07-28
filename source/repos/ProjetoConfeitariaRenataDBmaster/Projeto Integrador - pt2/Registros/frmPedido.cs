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

namespace Projeto_Integrador___pt2.Registros
{
    public partial class frmPedido : Form
    {
        Conection cntn = new Conection();
        public frmPedido()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pedidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.pedidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.item_pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.item_pedidoTableAdapter.Fill(this.renataDBDataSet.item_pedido);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtoTableAdapter.Fill(this.renataDBDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            //this.clienteTableAdapter.Fill(this.renataDBDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.pedido'. Você pode movê-la ou removê-la conforme necessário.
            //this.pedidoTableAdapter.Fill(this.renataDBDataSet.pedido);

        }

        public void exibeConsulta()
        {
            try
            {
                CSTpedido cst = new CSTpedido();
                cst.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir consulta: " + ex.Message);
            }
        }

        private void item_pedidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.item_pedidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void frmPedido_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.item_pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.item_pedidoTableAdapter.Fill(this.renataDBDataSet.item_pedido);

        }

        private void item_pedidoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void item_pedidoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
      

        private void pedidoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.renataDBDataSet1);

        }

        private void frmPedido_Load_2(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet1.item_pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.item_pedidoTableAdapter1.Fill(this.renataDBDataSet1.item_pedido);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet1.pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidoTableAdapter.Fill(this.renataDBDataSet1.pedido);
            this.item_pedidoBindingSource1.DataSource = this.renataDBDataSet1.pedido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.exibeConsulta();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Código")
                {
                    string sql = "SELECT * FROM item_pedido WHERE id_item_pedido = " + txt_Pesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable ip = new DataTable();
                    adapter.Fill(ip);
                    item_pedidoDataGridView.DataSource = ip;
                }
                if (cbmFiltrar.Text == "Item")
                {
                    string sql = "SELECT * FROM item_pedido WHERE FKid_produto LIKE '%" + txt_Pesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable ip = new DataTable();
                    adapter.Fill(ip);
                    item_pedidoDataGridView.DataSource = ip;
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
