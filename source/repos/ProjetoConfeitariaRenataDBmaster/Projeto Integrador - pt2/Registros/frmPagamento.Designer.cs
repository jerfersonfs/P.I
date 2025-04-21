namespace Projeto_Integrador___pt2.Formulários
{
    partial class frmPagamento
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
            System.Windows.Forms.Label id_pagamentoLabel;
            System.Windows.Forms.Label data_pagamentoLabel;
            System.Windows.Forms.Label valor_pagamentoLabel;
            System.Windows.Forms.Label forma_pagamentoLabel;
            System.Windows.Forms.Label taxa_entregaLabel;
            System.Windows.Forms.Label id_pedidoLabel;
            System.Windows.Forms.Label id_eventoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagamento));
            this.renataDBDataSet = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagamentoTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.pagamentoTableAdapter();
            this.tableAdapterManager = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.pagamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pagamentoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pagamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_pagamentoTextBox = new System.Windows.Forms.TextBox();
            this.data_pagamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valor_pagamentoTextBox = new System.Windows.Forms.TextBox();
            this.forma_pagamentoTextBox = new System.Windows.Forms.TextBox();
            this.taxa_entregaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.pedidoTableAdapter();
            this.id_pedidoTextBox = new System.Windows.Forms.TextBox();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventosTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.eventosTableAdapter();
            this.id_eventoTextBox = new System.Windows.Forms.TextBox();
            id_pagamentoLabel = new System.Windows.Forms.Label();
            data_pagamentoLabel = new System.Windows.Forms.Label();
            valor_pagamentoLabel = new System.Windows.Forms.Label();
            forma_pagamentoLabel = new System.Windows.Forms.Label();
            taxa_entregaLabel = new System.Windows.Forms.Label();
            id_pedidoLabel = new System.Windows.Forms.Label();
            id_eventoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingNavigator)).BeginInit();
            this.pagamentoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_pagamentoLabel
            // 
            id_pagamentoLabel.AutoSize = true;
            id_pagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_pagamentoLabel.Location = new System.Drawing.Point(23, 243);
            id_pagamentoLabel.Name = "id_pagamentoLabel";
            id_pagamentoLabel.Size = new System.Drawing.Size(50, 13);
            id_pagamentoLabel.TabIndex = 2;
            id_pagamentoLabel.Text = "Código:";
            // 
            // data_pagamentoLabel
            // 
            data_pagamentoLabel.AutoSize = true;
            data_pagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_pagamentoLabel.Location = new System.Drawing.Point(22, 296);
            data_pagamentoLabel.Name = "data_pagamentoLabel";
            data_pagamentoLabel.Size = new System.Drawing.Size(122, 13);
            data_pagamentoLabel.TabIndex = 6;
            data_pagamentoLabel.Text = "Data de pagamento:";
            // 
            // valor_pagamentoLabel
            // 
            valor_pagamentoLabel.AutoSize = true;
            valor_pagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_pagamentoLabel.Location = new System.Drawing.Point(24, 321);
            valor_pagamentoLabel.Name = "valor_pagamentoLabel";
            valor_pagamentoLabel.Size = new System.Drawing.Size(40, 13);
            valor_pagamentoLabel.TabIndex = 8;
            valor_pagamentoLabel.Text = "Valor:";
            // 
            // forma_pagamentoLabel
            // 
            forma_pagamentoLabel.AutoSize = true;
            forma_pagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            forma_pagamentoLabel.Location = new System.Drawing.Point(23, 347);
            forma_pagamentoLabel.Name = "forma_pagamentoLabel";
            forma_pagamentoLabel.Size = new System.Drawing.Size(129, 13);
            forma_pagamentoLabel.TabIndex = 10;
            forma_pagamentoLabel.Text = "Forma de pagamento:";
            // 
            // taxa_entregaLabel
            // 
            taxa_entregaLabel.AutoSize = true;
            taxa_entregaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            taxa_entregaLabel.Location = new System.Drawing.Point(22, 373);
            taxa_entregaLabel.Name = "taxa_entregaLabel";
            taxa_entregaLabel.Size = new System.Drawing.Size(104, 13);
            taxa_entregaLabel.TabIndex = 12;
            taxa_entregaLabel.Text = "Taxa de entrega:";
            // 
            // id_pedidoLabel
            // 
            id_pedidoLabel.AutoSize = true;
            id_pedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_pedidoLabel.Location = new System.Drawing.Point(24, 269);
            id_pedidoLabel.Name = "id_pedidoLabel";
            id_pedidoLabel.Size = new System.Drawing.Size(67, 13);
            id_pedidoLabel.TabIndex = 22;
            id_pedidoLabel.Text = "ID Pedido:";
            // 
            // id_eventoLabel
            // 
            id_eventoLabel.AutoSize = true;
            id_eventoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_eventoLabel.Location = new System.Drawing.Point(24, 399);
            id_eventoLabel.Name = "id_eventoLabel";
            id_eventoLabel.Size = new System.Drawing.Size(74, 13);
            id_eventoLabel.TabIndex = 23;
            id_eventoLabel.Text = "ID Eventos:";
            // 
            // renataDBDataSet
            // 
            this.renataDBDataSet.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pagamentoBindingSource
            // 
            this.pagamentoBindingSource.DataMember = "pagamento";
            this.pagamentoBindingSource.DataSource = this.renataDBDataSet;
            // 
            // pagamentoTableAdapter
            // 
            this.pagamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.avaliacaoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.estoqueTableAdapter = null;
            this.tableAdapterManager.eventosTableAdapter = null;
            this.tableAdapterManager.ingredientesTableAdapter = null;
            this.tableAdapterManager.item_pedidoTableAdapter = null;
            this.tableAdapterManager.pagamentoTableAdapter = this.pagamentoTableAdapter;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.receitaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // pagamentoBindingNavigator
            // 
            this.pagamentoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pagamentoBindingNavigator.BindingSource = this.pagamentoBindingSource;
            this.pagamentoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pagamentoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pagamentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pagamentoBindingNavigatorSaveItem});
            this.pagamentoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pagamentoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pagamentoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pagamentoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pagamentoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pagamentoBindingNavigator.Name = "pagamentoBindingNavigator";
            this.pagamentoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pagamentoBindingNavigator.Size = new System.Drawing.Size(813, 25);
            this.pagamentoBindingNavigator.TabIndex = 0;
            this.pagamentoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pagamentoBindingNavigatorSaveItem
            // 
            this.pagamentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pagamentoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pagamentoBindingNavigatorSaveItem.Image")));
            this.pagamentoBindingNavigatorSaveItem.Name = "pagamentoBindingNavigatorSaveItem";
            this.pagamentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pagamentoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pagamentoBindingNavigatorSaveItem.Click += new System.EventHandler(this.pagamentoBindingNavigatorSaveItem_Click);
            // 
            // pagamentoDataGridView
            // 
            this.pagamentoDataGridView.AutoGenerateColumns = false;
            this.pagamentoDataGridView.BackgroundColor = System.Drawing.Color.Plum;
            this.pagamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.pagamentoDataGridView.DataSource = this.pagamentoBindingSource;
            this.pagamentoDataGridView.Location = new System.Drawing.Point(39, 470);
            this.pagamentoDataGridView.Name = "pagamentoDataGridView";
            this.pagamentoDataGridView.Size = new System.Drawing.Size(745, 519);
            this.pagamentoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_pagamento";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_pagamento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FKid_item_pedido";
            this.dataGridViewTextBoxColumn2.HeaderText = "FKid_item_pedido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "data_pagamento";
            this.dataGridViewTextBoxColumn3.HeaderText = "data_pagamento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valor_pagamento";
            this.dataGridViewTextBoxColumn4.HeaderText = "valor_pagamento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "forma_pagamento";
            this.dataGridViewTextBoxColumn5.HeaderText = "forma_pagamento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "taxa_entrega";
            this.dataGridViewTextBoxColumn6.HeaderText = "taxa_entrega";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FKid_eventos";
            this.dataGridViewTextBoxColumn7.HeaderText = "FKid_eventos";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // id_pagamentoTextBox
            // 
            this.id_pagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoBindingSource, "id_pagamento", true));
            this.id_pagamentoTextBox.Location = new System.Drawing.Point(158, 240);
            this.id_pagamentoTextBox.Name = "id_pagamentoTextBox";
            this.id_pagamentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_pagamentoTextBox.TabIndex = 3;
            // 
            // data_pagamentoDateTimePicker
            // 
            this.data_pagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pagamentoBindingSource, "data_pagamento", true));
            this.data_pagamentoDateTimePicker.Location = new System.Drawing.Point(158, 292);
            this.data_pagamentoDateTimePicker.Name = "data_pagamentoDateTimePicker";
            this.data_pagamentoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_pagamentoDateTimePicker.TabIndex = 7;
            // 
            // valor_pagamentoTextBox
            // 
            this.valor_pagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoBindingSource, "valor_pagamento", true));
            this.valor_pagamentoTextBox.Location = new System.Drawing.Point(158, 318);
            this.valor_pagamentoTextBox.Name = "valor_pagamentoTextBox";
            this.valor_pagamentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.valor_pagamentoTextBox.TabIndex = 9;
            // 
            // forma_pagamentoTextBox
            // 
            this.forma_pagamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoBindingSource, "forma_pagamento", true));
            this.forma_pagamentoTextBox.Location = new System.Drawing.Point(158, 344);
            this.forma_pagamentoTextBox.Name = "forma_pagamentoTextBox";
            this.forma_pagamentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.forma_pagamentoTextBox.TabIndex = 11;
            // 
            // taxa_entregaTextBox
            // 
            this.taxa_entregaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pagamentoBindingSource, "taxa_entrega", true));
            this.taxa_entregaTextBox.Location = new System.Drawing.Point(158, 370);
            this.taxa_entregaTextBox.Name = "taxa_entregaTextBox";
            this.taxa_entregaTextBox.Size = new System.Drawing.Size(200, 20);
            this.taxa_entregaTextBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Plum;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.cbmFiltrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(398, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 129);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(42, 75);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(312, 29);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(197, 35);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(152, 20);
            this.txtPesquisar.TabIndex = 1;
            // 
            // cbmFiltrar
            // 
            this.cbmFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmFiltrar.FormattingEnabled = true;
            this.cbmFiltrar.Location = new System.Drawing.Point(42, 32);
            this.cbmFiltrar.Name = "cbmFiltrar";
            this.cbmFiltrar.Size = new System.Drawing.Size(130, 21);
            this.cbmFiltrar.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Plum;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(133, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(495, 62);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Forma de Pagamento";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "pedido";
            this.pedidoBindingSource.DataSource = this.renataDBDataSet;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // id_pedidoTextBox
            // 
            this.id_pedidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pedidoBindingSource, "id_pedido", true));
            this.id_pedidoTextBox.Location = new System.Drawing.Point(158, 266);
            this.id_pedidoTextBox.Name = "id_pedidoTextBox";
            this.id_pedidoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_pedidoTextBox.TabIndex = 23;
            this.id_pedidoTextBox.TextChanged += new System.EventHandler(this.id_pedidoTextBox_TextChanged);
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataMember = "eventos";
            this.eventosBindingSource.DataSource = this.renataDBDataSet;
            // 
            // eventosTableAdapter
            // 
            this.eventosTableAdapter.ClearBeforeFill = true;
            // 
            // id_eventoTextBox
            // 
            this.id_eventoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventosBindingSource, "id_evento", true));
            this.id_eventoTextBox.Location = new System.Drawing.Point(158, 396);
            this.id_eventoTextBox.Name = "id_eventoTextBox";
            this.id_eventoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_eventoTextBox.TabIndex = 24;
            this.id_eventoTextBox.TextChanged += new System.EventHandler(this.id_eventoTextBox_TextChanged);
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(813, 1009);
            this.Controls.Add(id_eventoLabel);
            this.Controls.Add(this.id_eventoTextBox);
            this.Controls.Add(id_pedidoLabel);
            this.Controls.Add(this.id_pedidoTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(id_pagamentoLabel);
            this.Controls.Add(this.id_pagamentoTextBox);
            this.Controls.Add(data_pagamentoLabel);
            this.Controls.Add(this.data_pagamentoDateTimePicker);
            this.Controls.Add(valor_pagamentoLabel);
            this.Controls.Add(this.valor_pagamentoTextBox);
            this.Controls.Add(forma_pagamentoLabel);
            this.Controls.Add(this.forma_pagamentoTextBox);
            this.Controls.Add(taxa_entregaLabel);
            this.Controls.Add(this.taxa_entregaTextBox);
            this.Controls.Add(this.pagamentoDataGridView);
            this.Controls.Add(this.pagamentoBindingNavigator);
            this.Name = "frmPagamento";
            this.Text = "frmPagamento";
            this.Load += new System.EventHandler(this.frmPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingNavigator)).EndInit();
            this.pagamentoBindingNavigator.ResumeLayout(false);
            this.pagamentoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenataDBDataSet renataDBDataSet;
        private System.Windows.Forms.BindingSource pagamentoBindingSource;
        private RenataDBDataSetTableAdapters.pagamentoTableAdapter pagamentoTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pagamentoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pagamentoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView pagamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox id_pagamentoTextBox;
        private System.Windows.Forms.DateTimePicker data_pagamentoDateTimePicker;
        private System.Windows.Forms.TextBox valor_pagamentoTextBox;
        private System.Windows.Forms.TextBox forma_pagamentoTextBox;
        private System.Windows.Forms.TextBox taxa_entregaTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private RenataDBDataSetTableAdapters.pedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.TextBox id_pedidoTextBox;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private RenataDBDataSetTableAdapters.eventosTableAdapter eventosTableAdapter;
        private System.Windows.Forms.TextBox id_eventoTextBox;
    }
}