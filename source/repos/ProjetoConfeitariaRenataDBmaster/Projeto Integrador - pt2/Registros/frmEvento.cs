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

        private void eventosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void frmEvento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.renataDBDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.eventos'. Você pode movê-la ou removê-la conforme necessário.
            this.eventosTableAdapter.Fill(this.renataDBDataSet.eventos);

        }

        private void eventosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_eventoLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    string sql = "SELECT * FROM Eventos WHERE id_evento = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable evento = new DataTable();
                    adapter.Fill(evento);
                    eventosDataGridView.DataSource = evento;
                }
                if (cbmFiltrar.Text == "Eventos")
                {
                    string sql = "SELECT * FROM Eventos WHERE tipo_evento LIKE '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable evento = new DataTable();
                    adapter.Fill(evento);
                    eventosDataGridView.DataSource = evento;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public async Task BuscarCep()
        {
            if (cep_evento.MaxInputLength == 9)
            {
                try
                {
                    using (HttpClient cliente = new HttpClient())
                    {
                        string url = $"https://viacep.com.br/ws/{cep_evento}/json/";
                        HttpResponseMessage response = await cliente.GetAsync(url);

                        if (response.IsSuccessStatusCode)
                        {
                            string json = await response.Content.ReadAsStringAsync();
                            dynamic dados = JsonConvert.DeserializeObject(json);

                            if (dados.erro == null) // Verifica se o CEP existe
                            {
                                rua_eventoTextBox.Text = dados.rua;
                                bairr_eventoTextBox.Text = dados.bairro;
                                cidade_eventoTextBox.Text = dados.cidade;
                                estado_eventoTextBox.Text = dados.estado;
                            }
                            else
                            {
                                MessageBox.Show("CEP não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro ao buscar o CEP. Tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("CEP inválido! Digite um CEP com 8 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorAddNewItem.PerformClick();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorDeleteItem.PerformClick();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.eventosBindingNavigatorSaveItem.PerformClick();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
