using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Projeto_Integrador___pt2.Formulários;

namespace Projeto_Integrador___pt2.Interfaces
{
    public partial class frmLogin : Form
    {
        public static String usuarioLogado;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.RenataDBConnectionString);
        public frmLogin()
        {
            Thread thread = new Thread(new ThreadStart(ShowSplash));
            thread.Start();
            Thread.Sleep(5000);
            thread.Abort();
            InitializeComponent();

            // Sincronize placeholder logo após inicialização
            SetPlaceholder(nome_usuTextBox1, "Usuário");
            SetPlaceholder(senha_usuTextBox1, "Senha");
            senha_usuTextBox1.UseSystemPasswordChar = false;

            nome_usuTextBox1.Enter += (s, e) => RemovePlaceholder(nome_usuTextBox1);
            nome_usuTextBox1.Leave += (s, e) => RestorePlaceholder(nome_usuTextBox1);

            senha_usuTextBox1.Enter += (s, e) => RemovePlaceholder(senha_usuTextBox1);
            senha_usuTextBox1.Leave += (s, e) => RestorePlaceholder(senha_usuTextBox1);
        }
        public void ShowSplash()
        {
            Application.Run(new frmSplash());
        }
        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }
        private void btn_Entrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Sucesso ao entrar no sistema!","Bem-vindo",MessageBoxButtons.OK);
                btn_Entrarr_Click(sender, e);
            }
        }
        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.ForeColor = Color.Gray;
            textBox.Text = placeholder;
            textBox.Tag = placeholder;
        }

        private void RemovePlaceholder(TextBox textBox)
        {
            if (textBox.Text == (string)textBox.Tag)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                if (textBox == senha_usuTextBox1)
                    senha_usuTextBox1.UseSystemPasswordChar = true;
            }
        }

        private void RestorePlaceholder(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.ForeColor = Color.Gray;
                textBox.Text = (string)textBox.Tag;
                if (textBox == senha_usuTextBox1)
                    senha_usuTextBox1.UseSystemPasswordChar = false;
            }
        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet1.usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter1.Fill(this.renataDBDataSet1.usuario);

        }

        private void usuarioBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.renataDBDataSet1);

        }

        private void btn_Entrarr_Click(object sender, EventArgs e)
        {
            try
            {
                if ((nome_usuTextBox1.Text != "") && (senha_usuTextBox1.Text != ""))
                {
                    SqlCommand connection = new SqlCommand("SELECT * FROM usuario WHERE nome_usu = @usuario AND senha_usu = @senha", conn);
                    connection.Parameters.Add("@usuario", SqlDbType.VarChar).Value = nome_usuTextBox1.Text;
                    connection.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha_usuTextBox1.Text;

                    conn.Open();
                    SqlDataReader reader = null;
                    reader = connection.ExecuteReader();
                    if (reader.Read())
                    {
                        usuarioLogado = nome_usuTextBox1.Text;

                        TelaDoSistema menu = new TelaDoSistema();

                        this.Hide();

                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos!", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}