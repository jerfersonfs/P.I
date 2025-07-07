using Projeto_Integrador___pt2.Consultas;
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

       

        private void usuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       

        private void telefone_usuTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_clienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_clienteLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorAddNewItem.PerformClick();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorDeleteItem.PerformClick();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.usuarioBindingNavigatorSaveItem.PerformClick();
            frmUsuario usu = new frmUsuario();
            usu.Close();
        }
        public void exibirConsulta() 
        {
            CSTusuario cst = new CSTusuario();
            cst.ShowDialog();
        }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            exibirConsulta();
        }
    }
}
