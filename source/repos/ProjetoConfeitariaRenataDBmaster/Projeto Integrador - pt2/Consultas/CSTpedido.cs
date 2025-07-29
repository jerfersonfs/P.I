using Projeto_Integrador___pt2.Registros;
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
    public partial class CSTpedido : Form
    {
        Conection cntn = new Conection();
        public CSTpedido()
        {
            InitializeComponent();
        }

        private void pedidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.renataDBDataSet1);

        }

        private void CSTpedido_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidoTableAdapter1.Fill(this.renataDBDataSet1.pedido);

        }

        public void showfrmPedido()
        {
            frmPedido frm = new frmPedido();
            frm.ShowDialog();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            showfrmPedido();
        }

        private void pedidoBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.renataDBDataSet1);

        }

        private void CSTpedido_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet1.pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidoTableAdapter1.Fill(this.renataDBDataSet1.pedido);
            this.pedidoDataGridView1.DataSource = this.pedidoBindingSource1;
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbm_Filtrar.Text == "Código")
                {
                    string sql = "SELECT * FROM pedido WHERE id_pedido = " + txt_Pesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable pedido = new DataTable();
                    adapter.Fill(pedido);
                    pedidoDataGridView1.DataSource = pedido;
                }
                if (cbm_Filtrar.Text == "Pedido")
                {
                    string sql = "SELECT * FROM pedido WHERE FKid_produto LIKE '%" + txt_Pesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable pedido = new DataTable();
                    adapter.Fill(pedido);
                    pedidoDataGridView1.DataSource = pedido;
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
