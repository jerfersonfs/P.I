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
        public void exibirConsulta() 
        {
            CSTusuario cst = new CSTusuario();
            cst.ShowDialog();
        }
        private void usuarioBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.renataDBDataSet1);

        }

        private void frmUsuario_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet1.usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter1.Fill(this.renataDBDataSet1.usuario);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorAddNewItem.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.bindingNavigatorDeleteItem.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.usuarioBindingNavigatorSaveItem.PerformClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            exibirConsulta();
        }
    }
}
