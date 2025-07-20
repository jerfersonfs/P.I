namespace Projeto_Integrador___pt2.Consultas
{
    partial class CSTpedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSTpedido));
            this.renataDBDataSet1 = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.pedidoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter1 = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.pedidoTableAdapter();
            this.tableAdapterManager1 = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.pedidoBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pedidoBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pedidoDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbm_Filtrar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1BindingNavigator)).BeginInit();
            this.pedidoBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // renataDBDataSet1
            // 
            this.renataDBDataSet1.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidoBindingSource1
            // 
            this.pedidoBindingSource1.DataMember = "pedido";
            this.pedidoBindingSource1.DataSource = this.renataDBDataSet1;
            // 
            // pedidoTableAdapter1
            // 
            this.pedidoTableAdapter1.ClearBeforeFill = true;
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
            this.tableAdapterManager1.pedidoTableAdapter = this.pedidoTableAdapter1;
            this.tableAdapterManager1.produtoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usuarioTableAdapter = null;
            // 
            // pedidoBindingSource1BindingNavigator
            // 
            this.pedidoBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.pedidoBindingSource1BindingNavigator.BindingSource = this.pedidoBindingSource1;
            this.pedidoBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.pedidoBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.pedidoBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pedidoBindingSource1BindingNavigatorSaveItem});
            this.pedidoBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pedidoBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.pedidoBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.pedidoBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.pedidoBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.pedidoBindingSource1BindingNavigator.Name = "pedidoBindingSource1BindingNavigator";
            this.pedidoBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.pedidoBindingSource1BindingNavigator.Size = new System.Drawing.Size(842, 25);
            this.pedidoBindingSource1BindingNavigator.TabIndex = 0;
            this.pedidoBindingSource1BindingNavigator.Text = "bindingNavigator1";
            this.pedidoBindingSource1BindingNavigator.Visible = false;
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
            // pedidoBindingSource1BindingNavigatorSaveItem
            // 
            this.pedidoBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pedidoBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pedidoBindingSource1BindingNavigatorSaveItem.Image")));
            this.pedidoBindingSource1BindingNavigatorSaveItem.Name = "pedidoBindingSource1BindingNavigatorSaveItem";
            this.pedidoBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pedidoBindingSource1BindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pedidoBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.pedidoBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // pedidoDataGridView1
            // 
            this.pedidoDataGridView1.AutoGenerateColumns = false;
            this.pedidoDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pedidoDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.pedidoDataGridView1.DataSource = this.pedidoBindingSource1;
            this.pedidoDataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pedidoDataGridView1.Location = new System.Drawing.Point(0, 172);
            this.pedidoDataGridView1.Name = "pedidoDataGridView1";
            this.pedidoDataGridView1.Size = new System.Drawing.Size(842, 293);
            this.pedidoDataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_pedido";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_pedido";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 130;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FKid_cliente";
            this.dataGridViewTextBoxColumn7.HeaderText = "FKid_cliente";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 130;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "data_pedido";
            this.dataGridViewTextBoxColumn8.HeaderText = "data_pedido";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 130;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "data_entrega";
            this.dataGridViewTextBoxColumn9.HeaderText = "data_entrega";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 130;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "status_pedido";
            this.dataGridViewTextBoxColumn10.HeaderText = "status_pedido";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 130;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "item_ped";
            this.dataGridViewTextBoxColumn11.HeaderText = "item_ped";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 130;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "descricao_pedido";
            this.dataGridViewTextBoxColumn12.HeaderText = "descricao_pedido";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 130;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Pesquisar);
            this.groupBox2.Controls.Add(this.txt_Pesquisar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbm_Filtrar);
            this.groupBox2.Location = new System.Drawing.Point(103, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 48);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Location = new System.Drawing.Point(417, 18);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.btn_Pesquisar.TabIndex = 3;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.Location = new System.Drawing.Point(210, 19);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(193, 20);
            this.txt_Pesquisar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "=";
            // 
            // cbm_Filtrar
            // 
            this.cbm_Filtrar.FormattingEnabled = true;
            this.cbm_Filtrar.Items.AddRange(new object[] {
            "",
            "Código",
            "Categoria"});
            this.cbm_Filtrar.Location = new System.Drawing.Point(58, 18);
            this.cbm_Filtrar.Name = "cbm_Filtrar";
            this.cbm_Filtrar.Size = new System.Drawing.Size(121, 21);
            this.cbm_Filtrar.TabIndex = 0;
            // 
            // CSTpedido
            // 
            this.ClientSize = new System.Drawing.Size(842, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pedidoDataGridView1);
            this.Controls.Add(this.pedidoBindingSource1BindingNavigator);
            this.Name = "CSTpedido";
            this.Load += new System.EventHandler(this.CSTpedido_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1BindingNavigator)).EndInit();
            this.pedidoBindingSource1BindingNavigator.ResumeLayout(false);
            this.pedidoBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoDataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private RenataDBDataSet renataDBDataSet;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private RenataDBDataSetTableAdapters.pedidoTableAdapter pedidoTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pedidoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pedidoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pedidoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnIncluir;
        private RenataDBDataSet renataDBDataSet1;
        private System.Windows.Forms.BindingSource pedidoBindingSource1;
        private RenataDBDataSetTableAdapters.pedidoTableAdapter pedidoTableAdapter1;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator pedidoBindingSource1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pedidoBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pedidoDataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.TextBox txt_Pesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbm_Filtrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}