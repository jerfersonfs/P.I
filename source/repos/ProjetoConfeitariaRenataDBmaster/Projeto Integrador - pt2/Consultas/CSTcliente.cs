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
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    string sql = "SELECT * FROM cliente WHERE id_cliente = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable cliente = new DataTable();
                    adapter.Fill(cliente);
                    clienteDataGridView.DataSource = cliente;
                }
                if (cbmFiltrar.Text == "Cliente")
                {
                    string sql = "SELECT * FROM cliente WHERE nome_cliente LIKE '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable cliente = new DataTable();
                    adapter.Fill(cliente);
                    clienteDataGridView.DataSource = cliente;
                }
                if (cbmFiltrar.Text == "CPF")
                {
                    string sql = "SELECT * FROM cliente WHERE cpf LIKE '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable cliente = new DataTable();
                    adapter.Fill(cliente);
                    clienteDataGridView.DataSource = cliente;
                }
                if (cbmFiltrar.Text == "CNPJ")
                {
                    string sql = "SELECT * FROM cliente WHERE cnpj LIKE '%" + txtPesquisar.Text + "%'";
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
    }
}
