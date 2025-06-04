using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_Integrador___pt2.Formulários
{
    public partial class frmCliente : Form
    {
        Conection cntn = new Conection();

        public void LimparCampo()
        {
            id_clienteTextBox.Text = "";
            nome_clienteTextBox.Text = "";
            celular_clienteTextBox.Text = "";
            email_clienteTextBox.Text = "";
            cpfTextBox.Text = "";
            cnpjTextBox.Text = "";
            data_nascimentoDateTimePicker.Text = "";
            rua_clienteTextBox.Text = "";
            numero_da_residencia_clienteTextBox.Text = "";
            cidade_clienteTextBox.Text = "";
            estado_clienteTextBox.Text = "";
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


        private void clienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public async Task BuscarCep()
        {
            if (cep.MaxInputLenght == 9)
            {
                try
                {
                    using (HttpClient cliente = new HttpClient())
                    {
                        string url = $"https://viacep.com.br/ws/{cep}/json/";
                        HttpResponseMessage response = await cliente.GetAsync(url);

                        if (response.IsSuccessStatusCode)
                        {
                            string json = await response.Content.ReadAsStringAsync();
                            dynamic dados = JsonConvert.DeserializeObject(json);

                            if (dados.erro == null) // Verifica se o CEP existe
                            {
                                rua_clienteTextBox.Text = dados.rua;
                                bairro_clienteTextBox.Text = dados.bairro; 
                                cidade_clienteTextBox.Text = dados.cidade;
                                estado_clienteTextBox.Text = dados.estado;
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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
