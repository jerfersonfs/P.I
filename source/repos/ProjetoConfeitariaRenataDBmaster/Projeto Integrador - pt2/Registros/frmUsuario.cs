using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador___pt2.Formulários
{
    public partial class frmUsuario: Form
    {
        Conection cntn = new Conection();
        RenataDBDataSet banco = new RenataDBDataSet();

        public void LimparCampo()
        {
            id_usuTextBox.Text = "";
            nome_usuTextBox.Text = "";
            email_usuTextBox.Text = "";
            celular_usuTextBox.Text = "";
            telefone_usuTextBox.Text = "";
            senha_usuTextBox.Text = "";
            repitasenhatxtBox.Text = "";
            id_clienteTextBox.Text = "";
        }
        public frmUsuario()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try 
            {
                if (nome_usuTextBox.Text == "")
                    MessageBox.Show("O Usuário deve ser preenchido");
                else
                if (senha_usuTextBox.Text != repitasenhatxtBox.Text)
                    MessageBox.Show("As senhas são diferentes! Por favor digite a senha correta");
                else
                if (email_usuTextBox.Text == "")
                    MessageBox.Show("O email deve ser preenchido");
                else
                if (senha_usuTextBox.Text == "")
                    MessageBox.Show("A senha deve ser preenchido");
                else
                if (celular_usuTextBox.Text == "")
                    MessageBox.Show("O celular deve ser preenchido");
                else
                if (telefone_usuTextBox.Text == "")
                    MessageBox.Show("O Telefone deve ser preenchido");
                else
                {
                    data_cadastroDateTimePicker.Text = DateTime.Now.ToString();
                    this.Validate();
                    this.usuarioBindingSource.EndEdit();
                    MessageBox.Show("Cadastro efetuado com sucesso! Seja bem-vindo");
                    this.usuarioTableAdapter.Update(this.renataDBDataSet.usuario);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Não foi possível salvar" + "pelo seguinte motivo: "+ ex.Message);
            }
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.renataDBDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.renataDBDataSet.usuario);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void id_usuLabel_Click(object sender, EventArgs e)
        {

        }

        private void fKid_clienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbmFiltrar.Text == "Código") 
                {
                    string sql = "SELECT * FROM Usuario WHERE id_usu = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable usu = new DataTable();
                    adapter.Fill(usu);
                    usuarioDataGridView.DataSource = usu;
                }
                if(cbmFiltrar.Text == "Usuário") 
                {
                    string sql = "SELECT * FROM Usuario WHERE nome_usu LIKE '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable usu = new DataTable();
                    adapter.Fill(usu);
                    usuarioDataGridView.DataSource = usu;
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

        private void usuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       /* public int GetCustomerId( string cellUsu, string nomeUsu, string nomeCli , string cellCli)
        {
            int id = -1;
            using (SqlConnection connection = new SqlConnection())
            {
                connection.Open();
                string query = "SELECT id_cliente FROM Cliente WHERE nome_usu = nome_cliente AND celular_usu = celular_cliente";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("nome_usu", nomeUsu);
                    cmd.Parameters.AddWithValue("nome_cliente", nomeCli);
                    cmd.Parameters.AddWithValue("celular_usu", cellUsu);
                    cmd.Parameters.AddWithValue("celular_cliente", cellCli);
                    var result = cmd.ExecuteScalar();
                    if (result != null) 
                    { 
                        id = Convert.ToInt32(result);
                    }
                }
            }
            return id;
        }*/
        private void fKid_clienteTextBox_TextChanged(object sender, EventArgs e/*, string cellUsu, string nomeUsu, string nomeCli, string cellCli*/)
        {
            /*int id = GetCustomerId(nomeUsu, nomeCli, cellCli,cellUsu);
            if (id != -1)*/
            SqlTransaction transaction = cntn.Connection.BeginTransaction();
            try
            {
                using (SqlConnection cntn = new SqlConnection())
                {
                    cntn.Open();
                    string query = "INSERT INTO Usuario(FKid_cliente) WHERE nome_usu = nome_cliente AND celular_usu = celular_cliente VALUES Cliente(id_cliente) ";
                    using (SqlCommand cmd = new SqlCommand(query, cntn, transaction))
                    {
                        cmd.Parameters.AddWithValue("id_cliente", id_clienteTextBox.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
                MessageBox.Show("ID do cliente inserido com sucesso!");
            }
            catch (Exception ex) 
            { 
                transaction.Rollback();
                MessageBox.Show("Erro ao inserir ID do cliente: " + ex.Message);
            }
        }

        private void telefone_usuTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_clienteTextBox_TextChanged(object sender, EventArgs e)
        {
           /* try
            {
                using (var context = new RenataDBDataSet())
                {
                    var query = from id_cliente in context.cliente
                                select new
                                { };
                }
            }
            catch (Exception ex)
            { 
            
            
            }*/
        }

        private void id_clienteLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
