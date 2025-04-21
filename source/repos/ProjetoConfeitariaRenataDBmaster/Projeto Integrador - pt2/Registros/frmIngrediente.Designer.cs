namespace Projeto_Integrador___pt2.Formulários
{
    partial class frmIngrediente
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
            System.Windows.Forms.Label id_ingredienteLabel;
            System.Windows.Forms.Label nome_ingredienteLabel;
            System.Windows.Forms.Label unidade_medida_ingredienteLabel;
            System.Windows.Forms.Label preco_custo_ingredienteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngrediente));
            this.renataDBDataSet = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.ingredientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ingredientesTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.ingredientesTableAdapter();
            this.tableAdapterManager = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.ingredientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ingredientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ingredientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ingredienteTextBox = new System.Windows.Forms.TextBox();
            this.nome_ingredienteTextBox = new System.Windows.Forms.TextBox();
            this.unidade_medida_ingredienteTextBox = new System.Windows.Forms.TextBox();
            this.preco_custo_ingredienteTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            id_ingredienteLabel = new System.Windows.Forms.Label();
            nome_ingredienteLabel = new System.Windows.Forms.Label();
            unidade_medida_ingredienteLabel = new System.Windows.Forms.Label();
            preco_custo_ingredienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientesBindingNavigator)).BeginInit();
            this.ingredientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_ingredienteLabel
            // 
            id_ingredienteLabel.AutoSize = true;
            id_ingredienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_ingredienteLabel.Location = new System.Drawing.Point(29, 139);
            id_ingredienteLabel.Name = "id_ingredienteLabel";
            id_ingredienteLabel.Size = new System.Drawing.Size(50, 13);
            id_ingredienteLabel.TabIndex = 2;
            id_ingredienteLabel.Text = "Código:";
            // 
            // nome_ingredienteLabel
            // 
            nome_ingredienteLabel.AutoSize = true;
            nome_ingredienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_ingredienteLabel.Location = new System.Drawing.Point(29, 161);
            nome_ingredienteLabel.Name = "nome_ingredienteLabel";
            nome_ingredienteLabel.Size = new System.Drawing.Size(75, 13);
            nome_ingredienteLabel.TabIndex = 4;
            nome_ingredienteLabel.Text = "Ingrediente:";
            // 
            // unidade_medida_ingredienteLabel
            // 
            unidade_medida_ingredienteLabel.AutoSize = true;
            unidade_medida_ingredienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unidade_medida_ingredienteLabel.Location = new System.Drawing.Point(29, 187);
            unidade_medida_ingredienteLabel.Name = "unidade_medida_ingredienteLabel";
            unidade_medida_ingredienteLabel.Size = new System.Drawing.Size(120, 13);
            unidade_medida_ingredienteLabel.TabIndex = 6;
            unidade_medida_ingredienteLabel.Text = "Unidade de medida:";
            // 
            // preco_custo_ingredienteLabel
            // 
            preco_custo_ingredienteLabel.AutoSize = true;
            preco_custo_ingredienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            preco_custo_ingredienteLabel.Location = new System.Drawing.Point(29, 217);
            preco_custo_ingredienteLabel.Name = "preco_custo_ingredienteLabel";
            preco_custo_ingredienteLabel.Size = new System.Drawing.Size(128, 13);
            preco_custo_ingredienteLabel.TabIndex = 8;
            preco_custo_ingredienteLabel.Text = "Custo do ingrediente:";
            // 
            // renataDBDataSet
            // 
            this.renataDBDataSet.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ingredientesBindingSource
            // 
            this.ingredientesBindingSource.DataMember = "ingredientes";
            this.ingredientesBindingSource.DataSource = this.renataDBDataSet;
            // 
            // ingredientesTableAdapter
            // 
            this.ingredientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.avaliacaoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.estoqueTableAdapter = null;
            this.tableAdapterManager.eventosTableAdapter = null;
            this.tableAdapterManager.ingredientesTableAdapter = this.ingredientesTableAdapter;
            this.tableAdapterManager.item_pedidoTableAdapter = null;
            this.tableAdapterManager.pagamentoTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.receitaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // ingredientesBindingNavigator
            // 
            this.ingredientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ingredientesBindingNavigator.BindingSource = this.ingredientesBindingSource;
            this.ingredientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ingredientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ingredientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ingredientesBindingNavigatorSaveItem});
            this.ingredientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ingredientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ingredientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ingredientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ingredientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ingredientesBindingNavigator.Name = "ingredientesBindingNavigator";
            this.ingredientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ingredientesBindingNavigator.Size = new System.Drawing.Size(473, 25);
            this.ingredientesBindingNavigator.TabIndex = 0;
            this.ingredientesBindingNavigator.Text = "bindingNavigator1";
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
            // ingredientesBindingNavigatorSaveItem
            // 
            this.ingredientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ingredientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ingredientesBindingNavigatorSaveItem.Image")));
            this.ingredientesBindingNavigatorSaveItem.Name = "ingredientesBindingNavigatorSaveItem";
            this.ingredientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ingredientesBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.ingredientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.ingredientesBindingNavigatorSaveItem_Click);
            // 
            // ingredientesDataGridView
            // 
            this.ingredientesDataGridView.AutoGenerateColumns = false;
            this.ingredientesDataGridView.BackgroundColor = System.Drawing.Color.Plum;
            this.ingredientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.ingredientesDataGridView.DataSource = this.ingredientesBindingSource;
            this.ingredientesDataGridView.Location = new System.Drawing.Point(12, 402);
            this.ingredientesDataGridView.Name = "ingredientesDataGridView";
            this.ingredientesDataGridView.Size = new System.Drawing.Size(439, 395);
            this.ingredientesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_ingrediente";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_ingrediente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nome_ingrediente";
            this.dataGridViewTextBoxColumn2.HeaderText = "nome_ingrediente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "unidade_medida_ingrediente";
            this.dataGridViewTextBoxColumn3.HeaderText = "unidade_medida_ingrediente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "preco_custo_ingrediente";
            this.dataGridViewTextBoxColumn4.HeaderText = "preco_custo_ingrediente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // id_ingredienteTextBox
            // 
            this.id_ingredienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientesBindingSource, "id_ingrediente", true));
            this.id_ingredienteTextBox.Location = new System.Drawing.Point(161, 136);
            this.id_ingredienteTextBox.Name = "id_ingredienteTextBox";
            this.id_ingredienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_ingredienteTextBox.TabIndex = 3;
            // 
            // nome_ingredienteTextBox
            // 
            this.nome_ingredienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientesBindingSource, "nome_ingrediente", true));
            this.nome_ingredienteTextBox.Location = new System.Drawing.Point(161, 162);
            this.nome_ingredienteTextBox.Name = "nome_ingredienteTextBox";
            this.nome_ingredienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.nome_ingredienteTextBox.TabIndex = 5;
            // 
            // unidade_medida_ingredienteTextBox
            // 
            this.unidade_medida_ingredienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientesBindingSource, "unidade_medida_ingrediente", true));
            this.unidade_medida_ingredienteTextBox.Location = new System.Drawing.Point(161, 188);
            this.unidade_medida_ingredienteTextBox.Name = "unidade_medida_ingredienteTextBox";
            this.unidade_medida_ingredienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.unidade_medida_ingredienteTextBox.TabIndex = 7;
            // 
            // preco_custo_ingredienteTextBox
            // 
            this.preco_custo_ingredienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientesBindingSource, "preco_custo_ingrediente", true));
            this.preco_custo_ingredienteTextBox.Location = new System.Drawing.Point(161, 214);
            this.preco_custo_ingredienteTextBox.Name = "preco_custo_ingredienteTextBox";
            this.preco_custo_ingredienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.preco_custo_ingredienteTextBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.cbmFiltrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 129);
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
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(144, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 49);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Ingredientes";
            // 
            // frmIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(473, 817);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(id_ingredienteLabel);
            this.Controls.Add(this.id_ingredienteTextBox);
            this.Controls.Add(nome_ingredienteLabel);
            this.Controls.Add(this.nome_ingredienteTextBox);
            this.Controls.Add(unidade_medida_ingredienteLabel);
            this.Controls.Add(this.unidade_medida_ingredienteTextBox);
            this.Controls.Add(preco_custo_ingredienteLabel);
            this.Controls.Add(this.preco_custo_ingredienteTextBox);
            this.Controls.Add(this.ingredientesDataGridView);
            this.Controls.Add(this.ingredientesBindingNavigator);
            this.Name = "frmIngrediente";
            this.Text = "Ingredientes";
            this.Load += new System.EventHandler(this.frmIngrediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientesBindingNavigator)).EndInit();
            this.ingredientesBindingNavigator.ResumeLayout(false);
            this.ingredientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenataDBDataSet renataDBDataSet;
        private System.Windows.Forms.BindingSource ingredientesBindingSource;
        private RenataDBDataSetTableAdapters.ingredientesTableAdapter ingredientesTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ingredientesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ingredientesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ingredientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox id_ingredienteTextBox;
        private System.Windows.Forms.TextBox nome_ingredienteTextBox;
        private System.Windows.Forms.TextBox unidade_medida_ingredienteTextBox;
        private System.Windows.Forms.TextBox preco_custo_ingredienteTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private System.Windows.Forms.TextBox textBox1;
    }
}