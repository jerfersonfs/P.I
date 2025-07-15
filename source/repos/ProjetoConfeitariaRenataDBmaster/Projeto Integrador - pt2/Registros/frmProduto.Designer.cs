namespace Projeto_Integrador___pt2.Formulários
{
    partial class frmProduto
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
            System.Windows.Forms.Label id_produtoLabel;
            System.Windows.Forms.Label nome_produtoLabel;
            System.Windows.Forms.Label preco_produtoLabel;
            System.Windows.Forms.Label promocaoLabel;
            System.Windows.Forms.Label data_inicio_promocaoLabel;
            System.Windows.Forms.Label data_fim_promocaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            System.Windows.Forms.Label fKid_categoriaLabel;
            this.renataDBDataSet = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.produtoTableAdapter();
            this.tableAdapterManager = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.produtoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.produtoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_produtoTextBox = new System.Windows.Forms.TextBox();
            this.nome_produtoTextBox = new System.Windows.Forms.TextBox();
            this.preco_produtoTextBox = new System.Windows.Forms.TextBox();
            this.promocaoTextBox = new System.Windows.Forms.TextBox();
            this.data_inicio_promocaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_fim_promocaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.categoriaTableAdapter();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.fKid_categoriaTextBox = new System.Windows.Forms.TextBox();
            id_produtoLabel = new System.Windows.Forms.Label();
            nome_produtoLabel = new System.Windows.Forms.Label();
            preco_produtoLabel = new System.Windows.Forms.Label();
            promocaoLabel = new System.Windows.Forms.Label();
            data_inicio_promocaoLabel = new System.Windows.Forms.Label();
            data_fim_promocaoLabel = new System.Windows.Forms.Label();
            fKid_categoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).BeginInit();
            this.produtoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_produtoLabel
            // 
            id_produtoLabel.AutoSize = true;
            id_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_produtoLabel.Location = new System.Drawing.Point(109, 150);
            id_produtoLabel.Name = "id_produtoLabel";
            id_produtoLabel.Size = new System.Drawing.Size(50, 13);
            id_produtoLabel.TabIndex = 2;
            id_produtoLabel.Text = "Código:";
            // 
            // nome_produtoLabel
            // 
            nome_produtoLabel.AutoSize = true;
            nome_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_produtoLabel.Location = new System.Drawing.Point(109, 176);
            nome_produtoLabel.Name = "nome_produtoLabel";
            nome_produtoLabel.Size = new System.Drawing.Size(55, 13);
            nome_produtoLabel.TabIndex = 4;
            nome_produtoLabel.Text = "Produto:";
            // 
            // preco_produtoLabel
            // 
            preco_produtoLabel.AutoSize = true;
            preco_produtoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            preco_produtoLabel.Location = new System.Drawing.Point(109, 202);
            preco_produtoLabel.Name = "preco_produtoLabel";
            preco_produtoLabel.Size = new System.Drawing.Size(44, 13);
            preco_produtoLabel.TabIndex = 6;
            preco_produtoLabel.Text = "Preço:";
            // 
            // promocaoLabel
            // 
            promocaoLabel.AutoSize = true;
            promocaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            promocaoLabel.Location = new System.Drawing.Point(109, 254);
            promocaoLabel.Name = "promocaoLabel";
            promocaoLabel.Size = new System.Drawing.Size(67, 13);
            promocaoLabel.TabIndex = 10;
            promocaoLabel.Text = "Promoção:";
            // 
            // data_inicio_promocaoLabel
            // 
            data_inicio_promocaoLabel.AutoSize = true;
            data_inicio_promocaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_inicio_promocaoLabel.Location = new System.Drawing.Point(109, 280);
            data_inicio_promocaoLabel.Name = "data_inicio_promocaoLabel";
            data_inicio_promocaoLabel.Size = new System.Drawing.Size(169, 13);
            data_inicio_promocaoLabel.TabIndex = 12;
            data_inicio_promocaoLabel.Text = "Data de início da promoção:";
            // 
            // data_fim_promocaoLabel
            // 
            data_fim_promocaoLabel.AutoSize = true;
            data_fim_promocaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_fim_promocaoLabel.Location = new System.Drawing.Point(109, 307);
            data_fim_promocaoLabel.Name = "data_fim_promocaoLabel";
            data_fim_promocaoLabel.Size = new System.Drawing.Size(153, 13);
            data_fim_promocaoLabel.TabIndex = 14;
            data_fim_promocaoLabel.Text = "Data do fim da promoção:";
            // 
            // renataDBDataSet
            // 
            this.renataDBDataSet.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.pagamentoTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = this.produtoTableAdapter;
            this.tableAdapterManager.receitaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // produtoBindingNavigator
            // 
            this.produtoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.produtoBindingNavigator.BindingSource = this.produtoBindingSource;
            this.produtoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.produtoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.produtoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produtoBindingNavigatorSaveItem});
            this.produtoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.produtoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.produtoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.produtoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.produtoBindingNavigator.Name = "produtoBindingNavigator";
            this.produtoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.produtoBindingNavigator.Size = new System.Drawing.Size(594, 25);
            this.produtoBindingNavigator.TabIndex = 0;
            this.produtoBindingNavigator.Text = "bindingNavigator1";
            this.produtoBindingNavigator.Visible = false;
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
            // produtoBindingNavigatorSaveItem
            // 
            this.produtoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produtoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produtoBindingNavigatorSaveItem.Image")));
            this.produtoBindingNavigatorSaveItem.Name = "produtoBindingNavigatorSaveItem";
            this.produtoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produtoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.produtoBindingNavigatorSaveItem.Click += new System.EventHandler(this.produtoBindingNavigatorSaveItem_Click);
            // 
            // id_produtoTextBox
            // 
            this.id_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "id_produto", true));
            this.id_produtoTextBox.Location = new System.Drawing.Point(284, 150);
            this.id_produtoTextBox.Name = "id_produtoTextBox";
            this.id_produtoTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_produtoTextBox.TabIndex = 3;
            // 
            // nome_produtoTextBox
            // 
            this.nome_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "nome_produto", true));
            this.nome_produtoTextBox.Location = new System.Drawing.Point(284, 176);
            this.nome_produtoTextBox.Name = "nome_produtoTextBox";
            this.nome_produtoTextBox.Size = new System.Drawing.Size(200, 20);
            this.nome_produtoTextBox.TabIndex = 5;
            // 
            // preco_produtoTextBox
            // 
            this.preco_produtoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "preco_produto", true));
            this.preco_produtoTextBox.Location = new System.Drawing.Point(284, 202);
            this.preco_produtoTextBox.Name = "preco_produtoTextBox";
            this.preco_produtoTextBox.Size = new System.Drawing.Size(200, 20);
            this.preco_produtoTextBox.TabIndex = 7;
            // 
            // promocaoTextBox
            // 
            this.promocaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "promocao", true));
            this.promocaoTextBox.Location = new System.Drawing.Point(284, 254);
            this.promocaoTextBox.Name = "promocaoTextBox";
            this.promocaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.promocaoTextBox.TabIndex = 11;
            // 
            // data_inicio_promocaoDateTimePicker
            // 
            this.data_inicio_promocaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.produtoBindingSource, "data_inicio_promocao", true));
            this.data_inicio_promocaoDateTimePicker.Location = new System.Drawing.Point(284, 280);
            this.data_inicio_promocaoDateTimePicker.Name = "data_inicio_promocaoDateTimePicker";
            this.data_inicio_promocaoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_inicio_promocaoDateTimePicker.TabIndex = 13;
            // 
            // data_fim_promocaoDateTimePicker
            // 
            this.data_fim_promocaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.produtoBindingSource, "data_fim_promocao", true));
            this.data_fim_promocaoDateTimePicker.Location = new System.Drawing.Point(284, 306);
            this.data_fim_promocaoDateTimePicker.Name = "data_fim_promocaoDateTimePicker";
            this.data_fim_promocaoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_fim_promocaoDateTimePicker.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Plum;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(594, 49);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Produtos ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataMember = "categoria";
            this.categoriaBindingSource.DataSource = this.renataDBDataSet;
            // 
            // categoriaTableAdapter
            // 
            this.categoriaTableAdapter.ClearBeforeFill = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(172, 97);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(90, 27);
            this.btnIncluir.TabIndex = 24;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(272, 97);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(90, 27);
            this.btnDeletar.TabIndex = 25;
            this.btnDeletar.Text = "Excluir";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(368, 97);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 27);
            this.btnSalvar.TabIndex = 26;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // fKid_categoriaLabel
            // 
            fKid_categoriaLabel.AutoSize = true;
            fKid_categoriaLabel.Location = new System.Drawing.Point(109, 231);
            fKid_categoriaLabel.Name = "fKid_categoriaLabel";
            fKid_categoriaLabel.Size = new System.Drawing.Size(78, 13);
            fKid_categoriaLabel.TabIndex = 26;
            fKid_categoriaLabel.Text = "FKid categoria:";
            // 
            // fKid_categoriaTextBox
            // 
            this.fKid_categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "FKid_categoria", true));
            this.fKid_categoriaTextBox.Location = new System.Drawing.Point(284, 228);
            this.fKid_categoriaTextBox.Name = "fKid_categoriaTextBox";
            this.fKid_categoriaTextBox.Size = new System.Drawing.Size(200, 20);
            this.fKid_categoriaTextBox.TabIndex = 27;
            this.fKid_categoriaTextBox.TextChanged += new System.EventHandler(this.fKid_categoriaTextBox_TextChanged);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(594, 419);
            this.Controls.Add(fKid_categoriaLabel);
            this.Controls.Add(this.fKid_categoriaTextBox);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(id_produtoLabel);
            this.Controls.Add(this.id_produtoTextBox);
            this.Controls.Add(nome_produtoLabel);
            this.Controls.Add(this.nome_produtoTextBox);
            this.Controls.Add(preco_produtoLabel);
            this.Controls.Add(this.preco_produtoTextBox);
            this.Controls.Add(promocaoLabel);
            this.Controls.Add(this.promocaoTextBox);
            this.Controls.Add(data_inicio_promocaoLabel);
            this.Controls.Add(this.data_inicio_promocaoDateTimePicker);
            this.Controls.Add(data_fim_promocaoLabel);
            this.Controls.Add(this.data_fim_promocaoDateTimePicker);
            this.Controls.Add(this.produtoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProduto";
            this.Text = "Registrar produtos";
            this.Load += new System.EventHandler(this.frmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingNavigator)).EndInit();
            this.produtoBindingNavigator.ResumeLayout(false);
            this.produtoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenataDBDataSet renataDBDataSet;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private RenataDBDataSetTableAdapters.produtoTableAdapter produtoTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator produtoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton produtoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_produtoTextBox;
        private System.Windows.Forms.TextBox nome_produtoTextBox;
        private System.Windows.Forms.TextBox preco_produtoTextBox;
        private System.Windows.Forms.TextBox promocaoTextBox;
        private System.Windows.Forms.DateTimePicker data_inicio_promocaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_fim_promocaoDateTimePicker;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private RenataDBDataSetTableAdapters.categoriaTableAdapter categoriaTableAdapter;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox fKid_categoriaTextBox;
    }
}