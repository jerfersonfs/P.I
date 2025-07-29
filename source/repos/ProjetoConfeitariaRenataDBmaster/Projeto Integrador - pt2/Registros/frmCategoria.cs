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
    public partial class frmCategoria: Form
    {
        Conection cntn = new Conection();
        public frmCategoria()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void categoriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource2.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.renataDBDataSet2);

        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter2.Fill(this.renataDBDataSet2.categoria);

        }
        private void categoriaBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource2.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.renataDBDataSet2);

        }

        private void frmCategoria_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet1.categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter2.Fill(this.renataDBDataSet2.categoria);

        }

        private void categoriaBindingSource2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaBindingSource2.EndEdit();
            this.tableAdapterManager2.UpdateAll(this.renataDBDataSet2);

        }

        private void frmCategoria_Load_2(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet2.categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaTableAdapter2.Fill(this.renataDBDataSet2.categoria);
            this.categoriaDataGridView2.DataSource = this.categoriaBindingSource2;
            this.categoriaBindingSource2.DataSource = this.renataDBDataSet2.categoria;
            this.LimparCampos();
        }

        public void LimparCampos()
        {
            id_categoriaTextBox2.Text = "";
            nome_categoriaTextBox2.Text = "";
            personalizacaoTextBox2.Text = "";
            status_catTextBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.toolStripButton11.PerformClick();
            this.LimparCampos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.toolStripButton12.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource2BindingNavigatorSaveItem.PerformClick();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Código")
                {
                    string sql = "SELECT * FROM categoria WHERE id_categoria = " + textBox3.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable cat = new DataTable();
                    adapter.Fill(cat);
                    categoriaDataGridView2.DataSource = cat;
                }
                if (comboBox1.Text == "Categoria")
                {
                    string sql = "SELECT * FROM categoria WHERE nome_categoria LIKE '%" + textBox3.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable cat = new DataTable();
                    adapter.Fill(cat);
                    categoriaDataGridView2.DataSource = cat;
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

        private void toolStripButton11_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
