using Projeto_Integrador___pt2.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador___pt2.Formulários
{
    public partial class frmPedido: Form
    {
        Conection cntn = new Conection();
        public frmPedido()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pedidoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pedidoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.item_pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.item_pedidoTableAdapter.Fill(this.renataDBDataSet.item_pedido);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.renataDBDataSet.produto);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.renataDBDataSet.cliente);
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.pedido'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidoTableAdapter.Fill(this.renataDBDataSet.pedido);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
          
        }
        private void id_clienteTextBox_TextChanged(object sender, EventArgs e)
        {
            SqlTransaction transaction = cntn.Connection.BeginTransaction();
            try
            {
                using (SqlConnection cntn = new SqlConnection())
                {
                    cntn.Open();
                    string query = "INSERT INTO Pedido(FKid_cliente) WHERE VALUES Cliente(id_cliente) ";
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

        public void exibeConsulta() 
        {
            try 
            {
                CSTpedido cst = new CSTpedido();
                foreach (Form frm in this.MdiChildren) 
                {
                    if (frm is CSTpedido) 
                    {
                        cst = (CSTpedido)frm;
                        break;
                    }
                }
                if (cst.IsDisposed)
                {
                    cst = new CSTpedido();
                    cst.MdiParent = this;
                    cst.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir consulta: " + ex.Message);
            }
        }
        private void btn_consultaP_Click(object sender, EventArgs e)
        {
            exibeConsulta();
        }
    }
}
