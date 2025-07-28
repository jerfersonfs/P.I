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
    public partial class CSTcliente : Form
    {
        Conection cntn = new Conection();
        public CSTcliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void CSTcliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.renataDBDataSet.cliente);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            { 
                btnPesquisar_Click
                (sender, e);
            }
        }

        public void showFrmCliente()
        {
            Registros.frmCliente frm = new Registros.frmCliente();
            frm.ShowDialog();
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
           this.showFrmCliente();
        }

        private void clienteBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.renataDBDataSet1);

        }

        private void CSTcliente_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet1.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter1.Fill(this.renataDBDataSet1.cliente);
            this.clienteDataGridView1.DataSource = this.clienteBindingSource1;
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbm_Filtrar.Text == "Código")
                {
                    string sql = "SELECT * FROM cliente WHERE id_cliente = " + txt_Pesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable cliente = new DataTable();
                    adapter.Fill(cliente);
                    clienteDataGridView.DataSource = cliente;
                }
                if (cbm_Filtrar.Text == "Cliente")
                {
                    string sql = "SELECT * FROM cliente WHERE nome_cliente LIKE '%" + txt_Pesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable cliente = new DataTable();
                    adapter.Fill(cliente);
                    clienteDataGridView.DataSource = cliente;
                }
                if (cbm_Filtrar.Text == "CPF")
                {
                    string sql = "SELECT * FROM cliente WHERE cpf LIKE '%" + txt_Pesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable cliente = new DataTable();
                    adapter.Fill(cliente);
                    clienteDataGridView.DataSource = cliente;
                }
                if (cbm_Filtrar.Text == "CNPJ")
                {
                    string sql = "SELECT * FROM cliente WHERE cnpj LIKE '%" + txt_Pesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable cliente = new DataTable();
                    adapter.Fill(cliente);
                    clienteDataGridView.DataSource = cliente;
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
