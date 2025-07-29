using Projeto_Integrador___pt2.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador___pt2.Registros
{
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void fornecedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.renataDBDataSet.fornecedores);
            this.fornecedoresBindingSource.DataSource = this.renataDBDataSet.fornecedores;
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {

            try 
            {
                this.bindingNavigatorAddNewItem.PerformClick();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Erro ao incluir fornecedor: " + ex.Message);
            }

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try 
            {
                this.bindingNavigatorDeleteItem.PerformClick();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Erro ao excluir fornecedor: " + ex.Message);
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {

            try 
            {
                this.fornecedoresBindingNavigatorSaveItem_Click(sender, e);
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Erro ao salvar fornecedor: " + ex.Message);
            }
        }

        public void exibirConsuta() 
        { 
            CSTfornecedor cst= new CSTfornecedor();
            cst.ShowDialog();
        }
        private void btn_Visualizr_Click(object sender, EventArgs e)
        {
            this.exibirConsuta();
        }

    }
}
