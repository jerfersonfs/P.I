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
    public partial class CSTfornecedor : Form
    {
        Conection cntn = new Conection();
        public CSTfornecedor()
        {
            InitializeComponent();
        }

        private void CSTfornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.renataDBDataSet.fornecedores);

        }

        private void fornecedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbm_Filtrar.Text == "Código")
                {
                    string sql = "SELECT * FROM fornecedores WHERE id_forn = " + txt_Pesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable forn = new DataTable();
                    adapter.Fill(forn);
                    fornecedoresDataGridView.DataSource = forn;
                }
                if (cbm_Filtrar.Text == "Fornecedor")
                {
                    string sql = "SELECT * FROM fornecedores WHERE nome_forn LIKE '%" + txt_Pesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable forn = new DataTable();
                    adapter.Fill(forn);
                    fornecedoresDataGridView.DataSource = forn;
                }
                if (cbm_Filtrar.Text == "CNPJ")
                {
                    string sql = "SELECT * FROM fornecedores WHERE cnpj LIKE '%" + txt_Pesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable forn = new DataTable();
                    adapter.Fill(forn);
                    fornecedoresDataGridView.DataSource = forn;
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
