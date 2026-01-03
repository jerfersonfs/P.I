using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using Projeto_Integrador___pt2.Consultas;
using Projeto_Integrador___pt2.Formulários;
using Projeto_Integrador___pt2.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador___pt2.Interfaces
{
    public partial class TelaDoSistema : Form
    {
        public TelaDoSistema()
        {
            InitializeComponent();
        }

        public void showcsltcliente()
        {
            try
            {
                CSTcliente cliente = new CSTcliente();
                cliente.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir formulário: " + ex.Message);
            }
        }

        public void showcsltusu()
        {
            try
            {
                CSTusuario usu = new CSTusuario();
                usu.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir formulário: " + ex.Message);
            }
        }

        public void showcslproduto()
        {
            try
            {
                CSTproduto prod = new CSTproduto();
                prod.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir formulário: " + ex.Message);
            }
        }

        public void showcsltpedido()
        {
            try
            {
                CSTpedido pedido = new CSTpedido();
                pedido.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir formulário: " + ex.Message);
            }
        }

        public void showcsltingredi()
        {
            try
            {
                CSTingrediente ing = new CSTingrediente();
                ing.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir formulário: " + ex.Message);
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showcsltcliente();
        }
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showcslproduto();
        }
        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showcsltpedido();
        }
        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showcsltingredi();
        }
       
        public void exibeFrmProd()
        {
            try
            {
                frmProduto produto = new frmProduto();
                produto.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao formulário: " + ex.Message);
            }
        }
        public void exibeFrmCli()
        {
            try
            {
                frmCliente cliente = new frmCliente();
                cliente.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao formulário: " + ex.Message);
            }
        }
        public void exibeFrmPedido()
        {
            try
            {
                frmPedido pedido = new frmPedido();
                pedido.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao formulário: " + ex.Message);
            }
        }
        public void exibeFrmEventos()
        {
            try
            {
                frmEvento eventos = new frmEvento();
                eventos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao formulário: " + ex.Message);
            }
        }
        public void exibeFrmIngredi()
        {
            try
            {
                frmIngrediente ingrediente = new frmIngrediente();
                ingrediente.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao formulário: " + ex.Message);
            }
        }
        public void exibeFrmEstoque()
        {
            try
            {
                frmEstoque estq = new frmEstoque();
                estq.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao formulário: " + ex.ToString());
            }
        }
        public void exibeFrmCategoria()
        {
            try
            {
                frmCategoria cat = new frmCategoria();
                cat.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao formulário: " + ex.Message);
            }
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }//Data

        private void timer2_Tick(object sender, EventArgs e)
        {
            tsslHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }//Hora

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibeFrmCli();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exibeFrmProd();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibeFrmCategoria();
        }

        private void pedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exibeFrmEstoque();//Esqueci de trocar o nome
        }

        private void ingredientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exibeFrmIngredi();
        }

        private void receitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsslUsu_Click(object sender, EventArgs e)
        {

        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // ---> Parte em que o usuário reloga no sistema <---
        public void exibeLogin()
        {
            try
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao formulário: " + ex.Message);
            }
        }


        private void TelaDoSistema_Load(object sender, EventArgs e)
        {
            tsslUsu.Text = "Usuário: " + frmLogin.usuarioLogado;
            string myHostname = System.Net.Dns.GetHostName();
            tsslNomePC.Text = "Nome do PC: " + myHostname;
            System.Net.IPHostEntry myIPs = System.Net.Dns.GetHostEntry(myHostname);
            foreach (System.Net.IPAddress myIP in myIPs.AddressList)
            {
                tsslIP.Text = "IP: " + myIP;
            }
        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*notificação*/
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void exibeFrmFornecedores()
        {
            try
            {
                frmFornecedor fornecedor = new frmFornecedor();
                fornecedor.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao formulário: " + ex.Message);
            }
        }
        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exibeFrmFornecedores();
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao reiniciar o aplicativo: " + ex.Message);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TelaDoSistema.ActiveForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao sair do aplicativo: " + ex.Message);
            }
        }

        public void exibeImagens()
        {
            try 
            { 
                frmImagens imagens = new frmImagens();
                imagens.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir formulário de imagens: " + ex.Message);
            }
        }


        private void temasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.exibeImagens();
        }

        public void exibefrmUsuario()
        {
            try
            {
                frmUsuario usuario = new frmUsuario();
                usuario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir formulário de usuário: " + ex.Message);
            }
        }
        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exibefrmUsuario();
        }
        public void exibefrmPerfilUsu()
        {
            try 
            {
            
                frmPerfilUsu perfilUsuario = new frmPerfilUsu();
                perfilUsuario.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir formulário de perfil de usuário: " + ex.Message);
            }
        }

        private void novaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
