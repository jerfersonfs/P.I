using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador___pt2.Formulários
{
    public partial class frmEvento: Form
    {
        Conection cntn =  new Conection();
        public frmEvento()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void eventosBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventosBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.renataDBDataSet1);

        }

        private void frmEvento_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet1.eventos'. Você pode movê-la ou removê-la conforme necessário.
            this.eventosTableAdapter1.Fill(this.renataDBDataSet1.eventos);
            this.eventosDataGridView1.DataSource = this.eventosBindingSource1;
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbm_Filtrar.Text == "Código")
                {
                    string sql = "SELECT * FROM eventos WHERE id_evento = " + txt_Pesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable evento = new DataTable();
                    adapter.Fill(evento);
                    eventosDataGridView1.DataSource = evento;
                }
                if (cbm_Filtrar.Text == "Eventos")
                {
                    string sql = "SELECT * FROM eventos WHERE tipo_evento LIKE '%" + txt_Pesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable evento = new DataTable();
                    adapter.Fill(evento);
                    eventosDataGridView1.DataSource = evento;
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
