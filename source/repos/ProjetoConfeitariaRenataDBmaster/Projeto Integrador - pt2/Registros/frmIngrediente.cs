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
    public partial class frmIngrediente : Form
    {
        Conection cntn = new Conection();
        public frmIngrediente()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ingredientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingredientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void frmIngrediente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.ingredientes'. Você pode movê-la ou removê-la conforme necessário.
            this.ingredientesTableAdapter.Fill(this.renataDBDataSet.ingredientes);
            this.ingredientesBindingSource.DataSource = this.renataDBDataSet.ingredientes;
        }

        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            try 
            {
                this.bindingNavigatorAddNewItem.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao incluir ingrediente: " + ex.Message);
            }
            finally
            {
                this.LimparCampos();
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            this.ingredientesBindingSource.RemoveCurrent();
            this.ingredientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            try 
            {
                this.Validate();
                this.ingredientesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.renataDBDataSet);
            } 
            catch (Exception ex)
            { 
                MessageBox.Show("Erro ao salvar ingrediente: " + ex.Message);
            }
        }
        public void LimparCampos()
        {
            id_ingredienteTextBox.Text = "";
            nome_ingredienteTextBox.Text = "";
            preco_custo_ingredienteTextBox.Text = "";
            preco_custo_ingredienteTextBox.Text = "";
        }
        public void exibirConsulta()
        {
            CSTingrediente cst = new CSTingrediente();
            cst.ShowDialog();
        }

        private void btn_Visualizar_Click(object sender, EventArgs e)
        {
            this.exibirConsulta();
        }
    }
}
