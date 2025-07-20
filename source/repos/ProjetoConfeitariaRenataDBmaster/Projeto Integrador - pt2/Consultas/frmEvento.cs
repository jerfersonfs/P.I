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

        private void fKid_clienteTextBox_TextChanged(object sender, EventArgs e)
        {
            try 
            { 
                string sql = "SELECT nome FROM cliente WHERE id_cliente = @id_cliente";
                SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                cmd.Parameters.AddWithValue("@id_cliente", fKid_clienteTextBox.Text);
                cntn.Open();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Erro ao buscar o nome do cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cntn.Close();
            }
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

        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
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
    }
}
