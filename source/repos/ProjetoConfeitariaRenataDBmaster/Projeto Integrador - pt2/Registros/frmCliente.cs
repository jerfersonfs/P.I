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
    public partial class frmCliente: Form
    {
        Conection cntn = new Conection();

        public void LimparCampo()
        {
            id_clienteTextBox.Text = "";
            nome_clienteTextBox.Text= "";
            celular_clienteTextBox.Text= "";
            email_clienteTextBox.Text= "";
            cpfTextBox.Text= "";
            cnpjTextBox.Text= "";
            data_nascimentoDateTimePicker.Text= "";
            rua_clienteTextBox.Text= "";
            numero_da_residencia_clienteTextBox.Text= "";
            cidade_clienteTextBox.Text= "";
            estado_clienteTextBox.Text= "";
        }
        public frmCliente()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.renataDBDataSet.cliente);

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    string sql = "SELECT * FROM Cliente WHERE id_cliente = " + txtPesquisar.Text + "";
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
                    string sql = "SELECT * FROM Cliente WHERE nome_cliente LIKE '%" + txtPesquisar.Text + "%'";
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

        private void clienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
