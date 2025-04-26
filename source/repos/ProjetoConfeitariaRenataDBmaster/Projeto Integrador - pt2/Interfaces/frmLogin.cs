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
        }
        public void ShowSplash()
        {
            Application.Run(new frmSplash());
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            email_usuTextBox.Text = "";
            this.usuarioTableAdapter.Fill(this.renataDBDataSet.usuario);
            this.usuarioTableAdapter.Fill(this.renataDBDataSet.usuario);
            this.usuarioTableAdapter.Fill(this.renataDBDataSet.usuario);
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }
        private void btn_Sair_Click(object sender, EventArgs e)
        {
                Close();
        }

        
        private void btn_Entrar_Click(object sender, EventArgs e)
        {

          
                try
                {
                    if ((email_usuTextBox.Text != "") && (senha_usuTextBox.Text != ""))
                    {
                        SqlCommand connection = new SqlCommand("SELECT * FROM usuario WHERE email_usu = @email AND senha_usu = @senha", conn);
                        connection.Parameters.Add("@usuario", SqlDbType.VarChar).Value = email_usuTextBox.Text;
                        connection.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha_usuTextBox.Text;

                        conn.Open();
                        SqlDataReader reader = null;
                        reader = connection.ExecuteReader();
                        if (reader.Read())
                        {
                            usuarioLogado = email_usuTextBox.Text;

                            MenuPrincipal menu = new MenuPrincipal();

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

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btm_Cadastro_Click(object sender, EventArgs e)
        {
            frmUsuario usu = new frmUsuario();
            usu.Show();
        }

        private void btn_Sair_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void senha_usuTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btn_Sair_Click(sender, e);
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void email_usuTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_usuTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btn_Sair_Click(sender, e);
            }
        }

        private void btn_Entrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Sucesso ao entrar no sistema!","Bem-vindo",MessageBoxButtons.OK);
                btn_Entrar_Click(sender, e);
            }
        }

        private void senha_usuTextBox_TextChanged(object sender, EventArgs e)
        {
            senha_usuTextBox.UseSystemPasswordChar = true;
            senha_usuTextBox.Text = "";
        }

        private void senha_usuTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            senha_usuTextBox.UseSystemPasswordChar = true;
            senha_usuTextBox.Text = "";
        }
    }
}