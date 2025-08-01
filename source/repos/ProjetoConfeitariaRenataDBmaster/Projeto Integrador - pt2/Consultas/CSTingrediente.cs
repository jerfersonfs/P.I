﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Integrador___pt2.Consultas
{
    public partial class CSTingrediente : Form
    {
        Conection cntn = new Conection();
        public CSTingrediente()
        {
            InitializeComponent();
        }

        private void ingredientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingredientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.renataDBDataSet);

        }

        private void CSTingrediente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'renataDBDataSet.ingredientes'. Você pode movê-la ou removê-la conforme necessário.
            this.ingredientesTableAdapter.Fill(this.renataDBDataSet.ingredientes);
            this.ingredientesDataGridView.DataSource = this.ingredientesBindingSource;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    string sql = "SELECT * FROM ingredientes WHERE id_ingrediente = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql);
                    cntn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable ingrediente = new DataTable();
                    adapter.Fill(ingrediente);
                    ingredientesDataGridView.DataSource = ingrediente;
                }
                if (cbmFiltrar.Text == "Ingrediente")
                {
                    string sql = "SELECT * FROM ingredientes WHERE nome_ingrediente LIKE '%" + txtPesquisar.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cntn.Connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable ingrediente = new DataTable();
                    adapter.Fill(ingrediente);
                    ingredientesDataGridView.DataSource = ingrediente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cntn.Close();
            }

        }
    }
}