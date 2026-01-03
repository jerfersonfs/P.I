namespace Projeto_Integrador___pt2.Registros
{
    partial class frmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.renataDBDataSet1 = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.pedidoTableAdapter();
            this.tableAdapterManager1 = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.pedidoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pedidoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.item_pedidoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.item_pedidoTableAdapter1 = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.item_pedidoTableAdapter();
            this.item_pedidoDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingNavigator)).BeginInit();
            this.pedidoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_pedidoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_pedidoDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // renataDBDataSet1
            // 
            this.renataDBDataSet1.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "pedido";
            this.pedidoBindingSource.DataSource = this.renataDBDataSet1;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.avaliacaoTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.categoriaTableAdapter = null;
            this.tableAdapterManager1.clienteTableAdapter = null;
            this.tableAdapterManager1.estoqueTableAdapter = null;
            this.tableAdapterManager1.eventosTableAdapter = null;
            this.tableAdapterManager1.fornecedoresTableAdapter = null;
            this.tableAdapterManager1.ingredientesTableAdapter = null;
            this.tableAdapterManager1.item_pedidoTableAdapter = null;
            this.tableAdapterManager1.pagamentoTableAdapter = null;
            this.tableAdapterManager1.pedidoTableAdapter = this.pedidoTableAdapter;
            this.tableAdapterManager1.produtoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usuarioTableAdapter = null;
            // 
            // pedidoBindingNavigator
            // 
            this.pedidoBindingNavigator.AddNewItem = this.toolStripButton5;
            this.pedidoBindingNavigator.BindingSource = this.pedidoBindingSource;
            this.pedidoBindingNavigator.CountItem = this.toolStripLabel1;
            this.pedidoBindingNavigator.DeleteItem = this.toolStripButton6;
            this.pedidoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.pedidoBindingNavigatorSaveItem});
            this.pedidoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pedidoBindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.pedidoBindingNavigator.MoveLastItem = this.toolStripButton4;
            this.pedidoBindingNavigator.MoveNextItem = this.toolStripButton3;
            this.pedidoBindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.pedidoBindingNavigator.Name = "pedidoBindingNavigator";
            this.pedidoBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.pedidoBindingNavigator.Size = new System.Drawing.Size(803, 25);
            this.pedidoBindingNavigator.TabIndex = 0;
            this.pedidoBindingNavigator.Text = "bindingNavigator1";
            this.pedidoBindingNavigator.Visible = false;
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Adicionar novo";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "de {0}";
            this.toolStripLabel1.ToolTipText = "Número total de itens";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Excluir";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Mover primeiro";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Mover anterior";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Posição";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Posição atual";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Mover próximo";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Mover último";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // pedidoBindingNavigatorSaveItem
            // 
            this.pedidoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pedidoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pedidoBindingNavigatorSaveItem.Image")));
            this.pedidoBindingNavigatorSaveItem.Name = "pedidoBindingNavigatorSaveItem";
            this.pedidoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pedidoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pedidoBindingNavigatorSaveItem.Click += new System.EventHandler(this.pedidoBindingNavigatorSaveItem_Click_1);
            // 
            // item_pedidoBindingSource1
            // 
            this.item_pedidoBindingSource1.DataMember = "item_pedido";
            this.item_pedidoBindingSource1.DataSource = this.renataDBDataSet1;
            // 
            // item_pedidoTableAdapter1
            // 
            this.item_pedidoTableAdapter1.ClearBeforeFill = true;
            // 
            // item_pedidoDataGridView1
            // 
            this.item_pedidoDataGridView1.AutoGenerateColumns = false;
            this.item_pedidoDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.item_pedidoDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.item_pedidoDataGridView1.DataSource = this.item_pedidoBindingSource1;
            this.item_pedidoDataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.item_pedidoDataGridView1.Location = new System.Drawing.Point(0, 154);
            this.item_pedidoDataGridView1.Name = "item_pedidoDataGridView1";
            this.item_pedidoDataGridView1.Size = new System.Drawing.Size(788, 297);
            this.item_pedidoDataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_item_pedido";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_item_pedido";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FKid_pedido";
            this.dataGridViewTextBoxColumn7.HeaderText = "FKid_pedido";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FKid_produto";
            this.dataGridViewTextBoxColumn8.HeaderText = "FKid_produto";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "quantidade_item_pedido";
            this.dataGridViewTextBoxColumn9.HeaderText = "quantidade_item_pedido";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "valor_total_pedido";
            this.dataGridViewTextBoxColumn10.HeaderText = "valor_total_pedido";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(537, 103);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_Pesquisar.TabIndex = 7;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.Location = new System.Drawing.Point(330, 104);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(193, 20);
            this.txt_Pesquisar.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "=";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Código",
            "Item"});
            this.comboBox1.Location = new System.Drawing.Point(178, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Visualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Plum;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(788, 47);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "Consultar itens pedidos";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmPedido
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(788, 451);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.txt_Pesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.item_pedidoDataGridView1);
            this.Controls.Add(this.pedidoBindingNavigator);
            this.Name = "frmPedido";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPedido_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingNavigator)).EndInit();
            this.pedidoBindingNavigator.ResumeLayout(false);
            this.pedidoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_pedidoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_pedidoDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RenataDBDataSet renataDBDataSet1;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private RenataDBDataSetTableAdapters.pedidoTableAdapter pedidoTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator pedidoBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton pedidoBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource item_pedidoBindingSource1;
        private RenataDBDataSetTableAdapters.item_pedidoTableAdapter item_pedidoTableAdapter1;
        private System.Windows.Forms.DataGridView item_pedidoDataGridView1;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.TextBox txt_Pesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}