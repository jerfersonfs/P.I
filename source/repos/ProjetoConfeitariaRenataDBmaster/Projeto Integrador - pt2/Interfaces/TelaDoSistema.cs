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
                CSTcliente cliente = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is CSTcliente)
                    {
                        cliente = (CSTcliente)frm;
                        break;
                    }
                }
                if (cliente == null)
                {
                    cliente = new CSTcliente();
                    cliente.MdiParent = this;
                    cliente.Show();
                }

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
                CSTusuario usu = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is CSTusuario)
                    {
                        usu = (CSTusuario)frm;
                        break;
                    }
                }
                if (usu == null)
                {
                    usu = new CSTusuario();
                    usu.MdiParent = this;
                    usu.Show();
                }

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
                CSTproduto prod = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is CSTproduto)
                    {
                        prod = (CSTproduto)frm;
                        break;
                    }
                }
                if (prod == null)
                {
                    prod = new CSTproduto();
                    prod.MdiParent = this;
                    prod.Show();
                }

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
                CSTpedido pedido = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is CSTpedido)
                    {
                        pedido = (CSTpedido)frm;
                        break;
                    }
                }
                if (pedido == null)
                {
                    pedido = new CSTpedido();
                    pedido.MdiParent = this;
                    pedido.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir formulário: " + ex.Message);
            }
        }
        public void showcsltavaliacao()
        {
            try
            {
                CSTavalicao ava = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is CSTavalicao)
                    {
                        ava = (CSTavalicao)frm;
                        break;
                    }
                }
                if (ava == null)
                {
                    ava = new CSTavalicao();
                    ava.MdiParent = this;
                    ava.Show();
                }

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
                CSTingrediente ing = null;

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is CSTingrediente)
                    {
                        ing = (CSTingrediente)frm;
                        break;
                    }
                }
                if (ing == null)
                {
                    ing = new CSTingrediente();
                    ing.MdiParent = this;
                    ing.Show();
                }

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
        private void receitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showcsltingredi();
        }
        private void pagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void avaliaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showcsltavaliacao();
        }

        public void exibeFrmProd()
        {
            try
            {
                frmProduto produto = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmProduto)
                    {
                        produto = (frmProduto)frm;
                        break;
                    }
                }
                if (produto == null)
                {
                    produto = new frmProduto();
                    produto.MdiParent = this;
                    produto.Show();
                }
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
                frmCliente cliente = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmCliente)
                    {
                        cliente = (frmCliente)frm;
                        break;
                    }
                }
                if (cliente == null)
                {
                    cliente = new frmCliente();
                    cliente.MdiParent = this;
                    cliente.Show();
                }
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
                frmPedido pedido = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmPedido)
                    {
                        pedido = (frmPedido)frm;
                        break;
                    }
                }
                if (pedido == null)
                {
                    pedido = new frmPedido();
                    pedido.MdiParent = this;
                    pedido.Show();
                }
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
                frmEvento eventos = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (eventos is frmEvento)
                    {
                        eventos = (frmEvento)frm;
                        break;
                    }
                }
                if (eventos == null)
                {
                    eventos = new frmEvento();
                    eventos.MdiParent = this;
                    eventos.Show();
                }
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
                frmIngrediente ingrediente = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmIngrediente)
                    {
                        ingrediente = (frmIngrediente)frm;
                        break;
                    }
                }
                if (ingrediente == null)
                {
                    ingrediente = new frmIngrediente();
                    ingrediente.MdiParent = this;
                    ingrediente.Show();
                }
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
                frmEstoque estq = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmEstoque)
                    {
                        estq = (frmEstoque)frm;
                        break;
                    }
                }
                if (estq == null)
                {
                    estq = new frmEstoque();
                    estq.MdiParent = this;
                    estq.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao formulário: " + ex.Message);
            }
        }
        public void exibeFrmCategoria()
        {
            try
            {
                frmCategoria cat = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmCategoria)
                    {
                        cat = (frmCategoria)frm;
                        break;
                    }
                }
                if (cat == null)
                {
                    cat = new frmCategoria();
                    cat.MdiParent = this;
                    cat.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao formulário: " + ex.Message);
             }
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
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
                frmLogin login = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmLogin)
                    {
                        login = (frmLogin)frm;
                        break;
                    }
                }
                if (login == null)
                {
                    login = new frmLogin();
                    login.MdiParent = this;
                    login.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao formulário: " + ex.Message);
            }
        }


        private void TelaDoSistema_Load(object sender, EventArgs e)
        {

        }

        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
