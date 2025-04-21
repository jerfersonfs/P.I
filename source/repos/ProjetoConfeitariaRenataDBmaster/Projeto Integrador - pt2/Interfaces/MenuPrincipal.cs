using Projeto_Integrador___pt2.Formulários;
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
    public partial class MenuPrincipal: Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibeFrmProd();
        }
        public void exibeFrmUsu()
        {
            try 
            {
                frmUsuario usuario = null;
                foreach (Form frm in this.MdiChildren) 
                {
                    if (frm is frmUsuario)
                    {
                        usuario = (frmUsuario)frm;
                        break;
                    }
                }
                if (usuario == null) 
                {
                    usuario = new frmUsuario();
                    usuario.MdiParent = this;
                    usuario.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao formulário: " + ex.Message);
            }
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
        public void exibeFrmItemPedido()
        {
            try
            {
                frmItemPedido itp = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmItemPedido)
                    {
                        itp = (frmItemPedido)frm;
                        break;
                    }
                }
                if (itp == null)
                {
                    itp = new frmItemPedido();
                    itp.MdiParent = this;
                    itp.Show();
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
        public void exibeFrmReceita()
        {
            try
            {
                frmReceita rec = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmReceita)
                    {
                        rec = (frmReceita)frm;
                        break;
                    }
                }
                if (rec == null)
                {
                    rec = new frmReceita();
                    rec.MdiParent = this;
                    rec.Show();
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
        public void exibeFrmPagamento()
        {
            try
            {
                frmPagamento pag = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmPagamento)
                    {
                        pag = (frmPagamento)frm;
                        break;
                    }
                }
                if (pag == null)
                {
                    pag = new frmPagamento();
                    pag.MdiParent = this;
                    pag.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao formulário: " + ex.Message);
            }
        }
        public void exibeFrmAvaliacao()
        {
            try
            {
                frmAvaliacao avl = null;
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is frmAvaliacao)
                    {
                        avl = (frmAvaliacao)frm;
                        break;
                    }
                }
                if (avl == null)
                {
                    avl = new frmAvaliacao();
                    avl.MdiParent = this;
                    avl.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao formulário: " + ex.Message);
            }
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibeFrmUsu();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibeFrmCli();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibeFrmPedido();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibeFrmEventos();
        }

        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibeFrmPagamento();
        }

        private void itemPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibeFrmItemPedido();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibeFrmCategoria();
        }

        private void ingredientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibeFrmIngredi();
        }

        private void receitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibeFrmReceita();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibeFrmEstoque();
        }

        private void avaliaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exibeFrmAvaliacao();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            tsslUsu.Text = "Usuário: " + frmLogin.usuarioLogado;
            string myHostname = System.Net.Dns.GetHostName();
            tsslNomePC.Text = "Nome do PC: " + myHostname;
            System.Net.IPHostEntry myIPs = System.Net.Dns.GetHostEntry(myHostname);
            foreach(System.Net.IPAddress myIP in myIPs.AddressList) 
            { 
                tsslIP.Text = "IP: " + myIP; 
            }
        }

        private void datattssl_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            datattssl.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void tsb_Logoff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}
