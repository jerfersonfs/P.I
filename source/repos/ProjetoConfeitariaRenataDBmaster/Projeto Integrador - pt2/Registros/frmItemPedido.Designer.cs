namespace Projeto_Integrador___pt2.Formulários
{
    partial class frmItemPedido
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
            System.Windows.Forms.Label id_item_pedidoLabel;
            System.Windows.Forms.Label quantidade_item_pedidoLabel;
            System.Windows.Forms.Label valor_total_pedidoLabel;
            System.Windows.Forms.Label id_produtoLabel;
            System.Windows.Forms.Label id_pedidoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemPedido));
            this.renataDBDataSet = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.item_pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.item_pedidoTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.item_pedidoTableAdapter();
            this.tableAdapterManager = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.item_pedidoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.item_pedidoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_item_pedidoTextBox = new System.Windows.Forms.TextBox();
            this.quantidade_item_pedidoTextBox = new System.Windows.Forms.TextBox();
            this.valor_total_pedidoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.produtoTableAdapter();
            this.id_produtoTextBox = new System.Windows.Forms.TextBox();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pedidoTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.pedidoTableAdapter();
            this.id_pedidoTextBox = new System.Windows.Forms.TextBox();
            id_item_pedidoLabel = new System.Windows.Forms.Label();
            quantidade_item_pedidoLabel = new System.Windows.Forms.Label();
            valor_total_pedidoLabel = new System.Windows.Forms.Label();
            id_produtoLabel = new System.Windows.Forms.Label();
            id_pedidoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_pedidoBindingNavigator)).BeginInit();
            this.item_pedidoBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_item_pedidoLabel
            // 
            id_item_pedidoLabel.AutoSize = true;
            id_item_pedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_item_pedidoLabel.Location = new System.Drawing.Point(23, 229);
            id_item_pedidoLabel.Name = "id_item_pedidoLabel";
            id_item_pedidoLabel.Size = new System.Drawing.Size(50, 13);
            id_item_pedidoLabel.TabIndex = 2;
            id_item_pedidoLabel.Text = "Código:";
            // 
            // quantidade_item_pedidoLabel
            // 
            quantidade_item_pedidoLabel.AutoSize = true;
            quantidade_item_pedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidade_item_pedidoLabel.Location = new System.Drawing.Point(23, 307);
            quantidade_item_pedidoLabel.Name = "quantidade_item_pedidoLabel";
            quantidade_item_pedidoLabel.Size = new System.Drawing.Size(76, 13);
            quantidade_item_pedidoLabel.TabIndex = 8;
            quantidade_item_pedidoLabel.Text = "Quantidade:";
            // 
            // valor_total_pedidoLabel
            // 
            valor_total_pedidoLabel.AutoSize = true;
            valor_total_pedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valor_total_pedidoLabel.Location = new System.Drawing.Point(23, 333);
            valor_total_pedidoLabel.Name = "valor_total_pedidoLabel";
            valor_total_pedidoLabel.Size = new System.Drawing.Size(69, 13);
            valor_total_pedidoLabel.TabIndex = 10;
            valor_total_pedidoLabel.Text = "Valor total:";
            // 
            // id_produtoLabel
            // 
            id_produtoLabel.AutoSize = true;
            id_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_produtoLabel.Location = new System.Drawing.Point(23, 281);
            id_produtoLabel.Name = "id_produtoLabel";
            id_produtoLabel.Size = new System.Drawing.Size(72, 13);
            id_produtoLabel.TabIndex = 22;
            id_produtoLabel.Text = "ID Produto:";
            // 
            // id_pedidoLabel
            // 
            id_pedidoLabel.AutoSize = true;
            id_pedidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_pedidoLabel.Location = new System.Drawing.Point(23, 255);
            id_pedidoLabel.Name = "id_pedidoLabel";
            id_pedidoLabel.Size = new System.Drawing.Size(67, 13);
            id_pedidoLabel.TabIndex = 23;
            id_pedidoLabel.Text = "ID Pedido:";
            id_pedidoLabel.Click += new System.EventHandler(this.id_pedidoLabel_Click);
            // 
            // renataDBDataSet
            // 
            this.renataDBDataSet.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // item_pedidoBindingSource
            // 
            this.item_pedidoBindingSource.DataMember = "item_pedido";
            this.item_pedidoBindingSource.DataSource = this.renataDBDataSet;
            // 
            // item_pedidoTableAdapter
            // 
            this.item_pedidoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.item_pedidoTableAdapter = this.item_pedidoTableAdapter;
            this.tableAdapterManager.pagamentoTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.receitaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // item_pedidoBindingNavigator
            // 
            this.item_pedidoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.item_pedidoBindingNavigator.BindingSource = this.item_pedidoBindingSource;
            this.item_pedidoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.item_pedidoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.item_pedidoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.item_pedidoBindingNavigatorSaveItem});
            this.item_pedidoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.item_pedidoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.item_pedidoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.item_pedidoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.item_pedidoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.item_pedidoBindingNavigator.Name = "item_pedidoBindingNavigator";
            this.item_pedidoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.item_pedidoBindingNavigator.Size = new System.Drawing.Size(755, 25);
            this.item_pedidoBindingNavigator.TabIndex = 0;
            this.item_pedidoBindingNavigator.Text = "bindingNavigator1";
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
            // item_pedidoBindingNavigatorSaveItem
            // 
            this.item_pedidoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.item_pedidoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("item_pedidoBindingNavigatorSaveItem.Image")));
            this.item_pedidoBindingNavigatorSaveItem.Name = "item_pedidoBindingNavigatorSaveItem";
            this.item_pedidoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.item_pedidoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.item_pedidoBindingNavigatorSaveItem.Click += new System.EventHandler(this.item_pedidoBindingNavigatorSaveItem_Click);
            // 
            // id_item_pedidoTextBox
            // 
            this.id_item_pedidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.item_pedidoBindingSource, "id_item_pedido", true));
            this.id_item_pedidoTextBox.Location = new System.Drawing.Point(149, 226);
            this.id_item_pedidoTextBox.Name = "id_item_pedidoTextBox";
            this.id_item_pedidoTextBox.Size = new System.Drawing.Size(159, 20);
            this.id_item_pedidoTextBox.TabIndex = 3;
            // 
            // quantidade_item_pedidoTextBox
            // 
            this.quantidade_item_pedidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.item_pedidoBindingSource, "quantidade_item_pedido", true));
            this.quantidade_item_pedidoTextBox.Location = new System.Drawing.Point(149, 304);
            this.quantidade_item_pedidoTextBox.Name = "quantidade_item_pedidoTextBox";
            this.quantidade_item_pedidoTextBox.Size = new System.Drawing.Size(159, 20);
            this.quantidade_item_pedidoTextBox.TabIndex = 9;
            // 
            // valor_total_pedidoTextBox
            // 
            this.valor_total_pedidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.item_pedidoBindingSource, "valor_total_pedido", true));
            this.valor_total_pedidoTextBox.Location = new System.Drawing.Point(149, 330);
            this.valor_total_pedidoTextBox.Name = "valor_total_pedidoTextBox";
            this.valor_total_pedidoTextBox.Size = new System.Drawing.Size(159, 20);
            this.valor_total_pedidoTextBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Plum;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.cbmFiltrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(339, 226);
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
            this.textBox1.Location = new System.Drawing.Point(198, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 62);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Item Pedido";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataMember = "produto";
            this.produtoBindingSource.DataSource = this.renataDBDataSet;
            // 
            // produtoTableAdapter
            // 
            this.produtoTableAdapter.ClearBeforeFill = true;
            // 
            // id_produtoTextBox
            // 
            this.id_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "id_produto", true));
            this.id_produtoTextBox.Location = new System.Drawing.Point(149, 278);
            this.id_produtoTextBox.Name = "id_produtoTextBox";
            this.id_produtoTextBox.Size = new System.Drawing.Size(159, 20);
            this.id_produtoTextBox.TabIndex = 23;
            this.id_produtoTextBox.TextChanged += new System.EventHandler(this.id_produtoTextBox_TextChanged);
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
            this.id_pedidoTextBox.Location = new System.Drawing.Point(149, 252);
            this.id_pedidoTextBox.Name = "id_pedidoTextBox";
            this.id_pedidoTextBox.Size = new System.Drawing.Size(159, 20);
            this.id_pedidoTextBox.TabIndex = 24;
            this.id_pedidoTextBox.TextChanged += new System.EventHandler(this.id_pedidoTextBox_TextChanged);
            // 
            // frmItemPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(755, 749);
            this.Controls.Add(id_pedidoLabel);
            this.Controls.Add(this.id_pedidoTextBox);
            this.Controls.Add(id_produtoLabel);
            this.Controls.Add(this.id_produtoTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(id_item_pedidoLabel);
            this.Controls.Add(this.id_item_pedidoTextBox);
            this.Controls.Add(quantidade_item_pedidoLabel);
            this.Controls.Add(this.quantidade_item_pedidoTextBox);
            this.Controls.Add(valor_total_pedidoLabel);
            this.Controls.Add(this.valor_total_pedidoTextBox);
            this.Controls.Add(this.item_pedidoBindingNavigator);
            this.Name = "frmItemPedido";
            this.Text = "frmItemPedido";
            this.Load += new System.EventHandler(this.frmItemPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_pedidoBindingNavigator)).EndInit();
            this.item_pedidoBindingNavigator.ResumeLayout(false);
            this.item_pedidoBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenataDBDataSet renataDBDataSet;
        private System.Windows.Forms.BindingSource item_pedidoBindingSource;
        private RenataDBDataSetTableAdapters.item_pedidoTableAdapter item_pedidoTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator item_pedidoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton item_pedidoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_item_pedidoTextBox;
        private System.Windows.Forms.TextBox quantidade_item_pedidoTextBox;
        private System.Windows.Forms.TextBox valor_total_pedidoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private RenataDBDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private System.Windows.Forms.TextBox id_produtoTextBox;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private RenataDBDataSetTableAdapters.pedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.TextBox id_pedidoTextBox;
    }
}