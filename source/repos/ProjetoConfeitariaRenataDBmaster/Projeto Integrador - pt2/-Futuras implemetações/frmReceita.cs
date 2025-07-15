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
    public partial class frmReceita: Form
    {
        Conection cntn = new Conection();
        public frmReceita()
        {
            InitializeComponent();
            this.Size = base.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void receitaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.receitaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void frmReceita_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.receita'. Você pode movê-la ou removê-la conforme necessário.
            this.receitaTableAdapter.Fill(this.renataDBDataSet.receita);
        }
    }
}
