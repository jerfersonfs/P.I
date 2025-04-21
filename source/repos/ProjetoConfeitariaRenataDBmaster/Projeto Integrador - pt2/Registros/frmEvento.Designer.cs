namespace Projeto_Integrador___pt2.Formulários
{
    partial class frmEvento
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
            System.Windows.Forms.Label id_eventoLabel;
            System.Windows.Forms.Label tipo_eventoLabel;
            System.Windows.Forms.Label data_eventoLabel;
            System.Windows.Forms.Label horário_eventoLabel;
            System.Windows.Forms.Label num_convidadosLabel;
            System.Windows.Forms.Label local_eventoLabel;
            System.Windows.Forms.Label valor_eventoLabel;
            System.Windows.Forms.Label id_clienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvento));
            this.renataDBDataSet = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventosTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.eventosTableAdapter();
            this.tableAdapterManager = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.eventosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eventosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eventosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_eventoTextBox = new System.Windows.Forms.TextBox();
            this.tipo_eventoTextBox = new System.Windows.Forms.TextBox();
            this.data_eventoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horário_eventoTextBox = new System.Windows.Forms.TextBox();
            this.num_convidadosTextBox = new System.Windows.Forms.TextBox();
            this.local_eventoTextBox = new System.Windows.Forms.TextBox();
            this.valor_eventoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.clienteTableAdapter();
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            id_eventoLabel = new System.Windows.Forms.Label();
            tipo_eventoLabel = new System.Windows.Forms.Label();
            data_eventoLabel = new System.Windows.Forms.Label();
            horário_eventoLabel = new System.Windows.Forms.Label();
            num_convidadosLabel = new System.Windows.Forms.Label();
            local_eventoLabel = new System.Windows.Forms.Label();
            valor_eventoLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingNavigator)).BeginInit();
            this.eventosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_eventoLabel
            // 
            id_eventoLabel.AutoSize = true;
            id_eventoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_eventoLabel.Location = new System.Drawing.Point(16, 221);
            id_eventoLabel.Name = "id_eventoLabel";
            id_eventoLabel.Size = new System.Drawing.Size(50, 13);
            id_eventoLabel.TabIndex = 2;
            id_eventoLabel.Text = "Código:";
            // 
            // tipo_eventoLabel
            // 
            tipo_eventoLabel.AutoSize = true;
            tipo_eventoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipo_eventoLabel.Location = new System.Drawing.Point(14, 273);
            tipo_eventoLabel.Name = "tipo_eventoLabel";
            tipo_eventoLabel.Size = new System.Drawing.Size(97, 13);
            tipo_eventoLabel.TabIndex = 6;
            tipo_eventoLabel.Text = "Tipo de evento:";
            // 
            // data_eventoLabel
            // 
            data_eventoLabel.AutoSize = true;
            data_eventoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_eventoLabel.Location = new System.Drawing.Point(16, 298);
            data_eventoLabel.Name = "data_eventoLabel";
            data_eventoLabel.Size = new System.Drawing.Size(99, 13);
            data_eventoLabel.TabIndex = 8;
            data_eventoLabel.Text = "Data do evento:";
            data_eventoLabel.Click += new System.EventHandler(this.data_eventoLabel_Click);
            // 
            // horário_eventoLabel
            // 
            horário_eventoLabel.AutoSize = true;
            horário_eventoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horário_eventoLabel.Location = new System.Drawing.Point(14, 325);
            horário_eventoLabel.Name = "horário_eventoLabel";
            horário_eventoLabel.Size = new System.Drawing.Size(113, 13);
            horário_eventoLabel.TabIndex = 10;
            horário_eventoLabel.Text = "Horário do evento:";
            // 
            // num_convidadosLabel
            // 
            num_convidadosLabel.AutoSize = true;
            num_convidadosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            num_convidadosLabel.Location = new System.Drawing.Point(14, 347);
            num_convidadosLabel.Name = "num_convidadosLabel";
            num_convidadosLabel.Size = new System.Drawing.Size(141, 13);
            num_convidadosLabel.TabIndex = 12;
            num_convidadosLabel.Text = "Número de convidados:";
            // 
            // local_eventoLabel
            // 
            local_eventoLabel.AutoSize = true;
            local_eventoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            local_eventoLabel.Location = new System.Drawing.Point(14, 373);
            local_eventoLabel.Name = "local_eventoLabel";
            local_eventoLabel.Size = new System.Drawing.Size(42, 13);
            local_eventoLabel.TabIndex = 14;
            local_eventoLabel.Text = "Local:";
            // 
            // valor_eventoLabel
            // 
            valor_eventoLabel.AutoSize = true;
            valor_eventoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_eventoLabel.Location = new System.Drawing.Point(16, 399);
            valor_eventoLabel.Name = "valor_eventoLabel";
            valor_eventoLabel.Size = new System.Drawing.Size(40, 13);
            valor_eventoLabel.TabIndex = 16;
            valor_eventoLabel.Text = "Valor:";
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_clienteLabel.Location = new System.Drawing.Point(16, 247);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(67, 13);
            id_clienteLabel.TabIndex = 22;
            id_clienteLabel.Text = "ID Cliente:";
            // 
            // renataDBDataSet
            // 
            this.renataDBDataSet.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.avaliacaoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.estoqueTableAdapter = null;
            this.tableAdapterManager.eventosTableAdapter = this.eventosTableAdapter;
            this.tableAdapterManager.ingredientesTableAdapter = null;
            this.tableAdapterManager.item_pedidoTableAdapter = null;
            this.tableAdapterManager.pagamentoTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.receitaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // eventosBindingNavigator
            // 
            this.eventosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventosBindingNavigator.BindingSource = this.eventosBindingSource;
            this.eventosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eventosBindingNavigatorSaveItem});
            this.eventosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eventosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventosBindingNavigator.Name = "eventosBindingNavigator";
            this.eventosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventosBindingNavigator.Size = new System.Drawing.Size(874, 25);
            this.eventosBindingNavigator.TabIndex = 0;
            this.eventosBindingNavigator.Text = "bindingNavigator1";
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
            // eventosBindingNavigatorSaveItem
            // 
            this.eventosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventosBindingNavigatorSaveItem.Image")));
            this.eventosBindingNavigatorSaveItem.Name = "eventosBindingNavigatorSaveItem";
            this.eventosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eventosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.eventosBindingNavigatorSaveItem.Click += new System.EventHandler(this.eventosBindingNavigatorSaveItem_Click);
            // 
            // eventosDataGridView
            // 
            this.eventosDataGridView.AutoGenerateColumns = false;
            this.eventosDataGridView.BackgroundColor = System.Drawing.Color.Plum;
            this.eventosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.eventosDataGridView.DataSource = this.eventosBindingSource;
            this.eventosDataGridView.Location = new System.Drawing.Point(12, 433);
            this.eventosDataGridView.Name = "eventosDataGridView";
            this.eventosDataGridView.Size = new System.Drawing.Size(842, 400);
            this.eventosDataGridView.TabIndex = 1;
            this.eventosDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventosDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_evento";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_evento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FKid_cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "FKid_cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipo_evento";
            this.dataGridViewTextBoxColumn3.HeaderText = "tipo_evento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "data_evento";
            this.dataGridViewTextBoxColumn4.HeaderText = "data_evento";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "horário_evento";
            this.dataGridViewTextBoxColumn5.HeaderText = "horário_evento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "num_convidados";
            this.dataGridViewTextBoxColumn6.HeaderText = "num_convidados";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "local_evento";
            this.dataGridViewTextBoxColumn7.HeaderText = "local_evento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "valor_evento";
            this.dataGridViewTextBoxColumn8.HeaderText = "valor_evento";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // id_eventoTextBox
            // 
            this.id_eventoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventosBindingSource, "id_evento", true));
            this.id_eventoTextBox.Location = new System.Drawing.Point(156, 214);
            this.id_eventoTextBox.Name = "id_eventoTextBox";
            this.id_eventoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_eventoTextBox.TabIndex = 3;
            // 
            // tipo_eventoTextBox
            // 
            this.tipo_eventoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventosBindingSource, "tipo_evento", true));
            this.tipo_eventoTextBox.Location = new System.Drawing.Point(156, 266);
            this.tipo_eventoTextBox.Name = "tipo_eventoTextBox";
            this.tipo_eventoTextBox.Size = new System.Drawing.Size(200, 20);
            this.tipo_eventoTextBox.TabIndex = 7;
            // 
            // data_eventoDateTimePicker
            // 
            this.data_eventoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventosBindingSource, "data_evento", true));
            this.data_eventoDateTimePicker.Location = new System.Drawing.Point(156, 292);
            this.data_eventoDateTimePicker.Name = "data_eventoDateTimePicker";
            this.data_eventoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_eventoDateTimePicker.TabIndex = 9;
            // 
            // horário_eventoTextBox
            // 
            this.horário_eventoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventosBindingSource, "horário_evento", true));
            this.horário_eventoTextBox.Location = new System.Drawing.Point(156, 318);
            this.horário_eventoTextBox.Name = "horário_eventoTextBox";
            this.horário_eventoTextBox.Size = new System.Drawing.Size(200, 20);
            this.horário_eventoTextBox.TabIndex = 11;
            // 
            // num_convidadosTextBox
            // 
            this.num_convidadosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventosBindingSource, "num_convidados", true));
            this.num_convidadosTextBox.Location = new System.Drawing.Point(156, 344);
            this.num_convidadosTextBox.Name = "num_convidadosTextBox";
            this.num_convidadosTextBox.Size = new System.Drawing.Size(200, 20);
            this.num_convidadosTextBox.TabIndex = 13;
            // 
            // local_eventoTextBox
            // 
            this.local_eventoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventosBindingSource, "local_evento", true));
            this.local_eventoTextBox.Location = new System.Drawing.Point(156, 370);
            this.local_eventoTextBox.Name = "local_eventoTextBox";
            this.local_eventoTextBox.Size = new System.Drawing.Size(200, 20);
            this.local_eventoTextBox.TabIndex = 15;
            // 
            // valor_eventoTextBox
            // 
            this.valor_eventoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventosBindingSource, "valor_evento", true));
            this.valor_eventoTextBox.Location = new System.Drawing.Point(156, 396);
            this.valor_eventoTextBox.Name = "valor_eventoTextBox";
            this.valor_eventoTextBox.Size = new System.Drawing.Size(200, 20);
            this.valor_eventoTextBox.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Plum;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.cbmFiltrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(459, 240);
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
            this.textBox1.Location = new System.Drawing.Point(266, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 62);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Evento";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.renataDBDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "id_cliente", true));
            this.id_clienteTextBox.Location = new System.Drawing.Point(156, 240);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.id_clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_clienteTextBox.TabIndex = 23;
            this.id_clienteTextBox.TextChanged += new System.EventHandler(this.id_clienteTextBox_TextChanged);
            // 
            // frmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(874, 853);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(id_eventoLabel);
            this.Controls.Add(this.id_eventoTextBox);
            this.Controls.Add(tipo_eventoLabel);
            this.Controls.Add(this.tipo_eventoTextBox);
            this.Controls.Add(data_eventoLabel);
            this.Controls.Add(this.data_eventoDateTimePicker);
            this.Controls.Add(horário_eventoLabel);
            this.Controls.Add(this.horário_eventoTextBox);
            this.Controls.Add(num_convidadosLabel);
            this.Controls.Add(this.num_convidadosTextBox);
            this.Controls.Add(local_eventoLabel);
            this.Controls.Add(this.local_eventoTextBox);
            this.Controls.Add(valor_eventoLabel);
            this.Controls.Add(this.valor_eventoTextBox);
            this.Controls.Add(this.eventosDataGridView);
            this.Controls.Add(this.eventosBindingNavigator);
            this.Name = "frmEvento";
            this.Text = "frmEvento";
            this.Load += new System.EventHandler(this.frmEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingNavigator)).EndInit();
            this.eventosBindingNavigator.ResumeLayout(false);
            this.eventosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenataDBDataSet renataDBDataSet;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private RenataDBDataSetTableAdapters.eventosTableAdapter eventosTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eventosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eventosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView eventosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox id_eventoTextBox;
        private System.Windows.Forms.TextBox tipo_eventoTextBox;
        private System.Windows.Forms.DateTimePicker data_eventoDateTimePicker;
        private System.Windows.Forms.TextBox horário_eventoTextBox;
        private System.Windows.Forms.TextBox num_convidadosTextBox;
        private System.Windows.Forms.TextBox local_eventoTextBox;
        private System.Windows.Forms.TextBox valor_eventoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private RenataDBDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.TextBox id_clienteTextBox;
    }
}