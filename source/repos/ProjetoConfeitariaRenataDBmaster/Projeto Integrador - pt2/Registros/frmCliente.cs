using Newtonsoft.Json;
using Projeto_Integrador___pt2.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador___pt2.Registros
{
    public partial class frmCliente : Form
    {
        Conection cntn = new Conection();
        public void ClearFields() 
        {
            id_clienteTextBox1.Text = "";
            nome_clienteTextBox1.Text = "";
            celular_clienteTextBox1.Text = "";
            email_clienteTextBox1.Text = "";
            cpfTextBox1.Text = "";
            cnpjTextBox1.Text = "";
            data_nascimentoDateTimePicker1.Text = "";
            rua_clienteTextBox1.Text = "";
            numero_da_residencia_clienteTextBox1.Text = "";
            cidade_clienteTextBox1.Text = "";
            estado_clienteTextBox1.Text = "";
            bairro_clienteTextBox1.Text = "";
        }
        public frmCliente()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClearFields();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.renataDBDataSet1);
            ClearFields();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter1.Fill(this.renataDBDataSet1.cliente);

        }
       /* public async Task BuscarCep()
        {
            if (cepTextBox1.MaxLength == 9)
            {
                try
                {
                    using (HttpClient cliente = new HttpClient())
                    {
                        string url = $"https://viacep.com.br/ws/{cepTextBox1.Text}/json/";
                        HttpResponseMessage response = await cliente.GetAsync(url);

                        if (response.IsSuccessStatusCode)
                        {
                            string json = await response.Content.ReadAsStringAsync();
                            dynamic dados = JsonConvert.DeserializeObject(json);

                            if (dados.erro == null) // Verifica se o CEP existe
                            {
                                rua_clienteTextBox1.Text = dados.rua;
                                bairro_clienteTextBox1.Text = dados.bairro;
                                cidade_clienteTextBox1.Text = dados.cidade;
                                estado_clienteTextBox1.Text = dados.estado;
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
       */
        private void clienteBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.renataDBDataSet1);
            this.ClearFields();
        }

        private void frmCliente_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet1.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter1.Fill(this.renataDBDataSet1.cliente);
            this.clienteBindingSource1.DataSource = this.renataDBDataSet1.cliente;
            this.ClearFields();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                this.toolStripButton5.PerformClick();
                this.ClearFields();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao incluir cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            {
                this.toolStripButton6.PerformClick();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao excluir cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try 
            {
                this.clienteBindingNavigatorSaveItem_Click(sender, e);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao atualizar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void exibirConsulta() 
        {
            CSTcliente cst = new CSTcliente();
            cst.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.exibirConsulta();
        }

        private void cepTextBox1_TextChanged(object sender, EventArgs e)
        {
           /* if (cepTextBox1.Text.Length == 9)
            {
                BuscarCep();
            }
            else
            {
                MessageBox.Show("CEP inválido! Digite um CEP com 8 dígitos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }
    }
}
