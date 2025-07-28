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
    public partial class CSTestoque : Form
    {
        Conection cntn = new Conection();
        public CSTestoque()
        {
            InitializeComponent();
        }

        private void estoqueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estoqueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void CSTestoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter.Fill(this.renataDBDataSet.estoque);

        }
        public void showfrmEstoque() 
        { 
            frmEstoque frm = new frmEstoque();
            frm.ShowDialog();
            CSTestoque consulta = new CSTestoque();
            consulta.Close();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            this.showfrmEstoque();
        }

        private void estoqueBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estoqueBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.renataDBDataSet1);

        }

        private void CSTestoque_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet1.estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter1.Fill(this.renataDBDataSet1.estoque);
            this.estoqueDataGridView1.DataSource = this.estoqueBindingSource1;
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbm_Filtrar.Text == "Código")
                {
                    string sql = "SELECT * FROM estoque WHERE id_estoque = " + txt_Pesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable estoque = new DataTable();
                    adapter.Fill(estoque);
                    estoqueDataGridView.DataSource = estoque;
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
