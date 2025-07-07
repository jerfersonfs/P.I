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

namespace Projeto_Integrador___pt2.Consultas
{
    public partial class CSTestoque : Form
    {
        public CSTestoque()
        {
            InitializeComponent();
        }

        private void estoqueBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estoqueBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void CSTestoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.estoqueTableAdapter.Fill(this.renataDBDataSet.estoque);

        }
        public void showfrmEstoque() 
        { 
            frmEstoque frm = new frmEstoque();
            frm.ShowDialog();
            CSTestoque consulta = new CSTestoque();
            consulta.Close();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            this.showfrmEstoque();
        }
    }
}
