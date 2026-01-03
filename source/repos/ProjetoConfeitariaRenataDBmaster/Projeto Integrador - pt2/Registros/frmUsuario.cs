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
            id_usuTextBox1.Text = "";
            nome_usuTextBox1.Text = "";
            email_usuTextBox1.Text = "";
            celular_usuTextBox1.Text = "";
            telefone_usuTextBox1.Text = "";
            senha_usuTextBox1.Text = "";
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
                if (nome_usuTextBox1.Text == "")
                    MessageBox.Show("O Usuário deve ser preenchido");
                else
                if (email_usuTextBox1.Text == "")
                    MessageBox.Show("O email deve ser preenchido");
                else
                if (senha_usuTextBox1.Text == "")
                    MessageBox.Show("A senha deve ser preenchido");
                else
                if (celular_usuTextBox1.Text == "")
                    MessageBox.Show("O celular deve ser preenchido");
                else
                if (telefone_usuTextBox1.Text == "")
                    MessageBox.Show("O Telefone deve ser preenchido");
                else
                {
                    data_cadastroDateTimePicker1.Text = DateTime.Now.ToString();
                    this.Validate();
                    this.usuarioBindingSource1.EndEdit();
                    MessageBox.Show("Cadastro efetuado com sucesso! Seja bem-vindo");
                    this.usuarioTableAdapter1.Update(this.renataDBDataSet1.usuario);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Não foi possível salvar" + "pelo seguinte motivo: "+ ex.Message);
            }
            this.Validate();
            this.usuarioBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.renataDBDataSet1);
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
            this.usuarioBindingSource1.DataSource = this.renataDBDataSet1.usuario;
            this.LimparCampo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.toolStripButton5.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.toolStripButton6.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.usuarioBindingSource1BindingNavigatorSaveItem.PerformClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.exibirConsulta();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
