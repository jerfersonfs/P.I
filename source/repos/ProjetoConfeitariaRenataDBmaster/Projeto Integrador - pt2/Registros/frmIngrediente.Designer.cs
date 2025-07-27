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
            this.id_ingredienteTextBox = new System.Windows.Forms.TextBox();
            this.nome_ingredienteTextBox = new System.Windows.Forms.TextBox();
            this.unidade_medida_ingredienteTextBox = new System.Windows.Forms.TextBox();
            this.preco_custo_ingredienteTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Visualizar = new System.Windows.Forms.Button();
            id_ingredienteLabel = new System.Windows.Forms.Label();
            nome_ingredienteLabel = new System.Windows.Forms.Label();
            unidade_medida_ingredienteLabel = new System.Windows.Forms.Label();
            preco_custo_ingredienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientesBindingNavigator)).BeginInit();
            this.ingredientesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_ingredienteLabel
            // 
            id_ingredienteLabel.AutoSize = true;
            id_ingredienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_ingredienteLabel.Location = new System.Drawing.Point(96, 121);
            id_ingredienteLabel.Name = "id_ingredienteLabel";
            id_ingredienteLabel.Size = new System.Drawing.Size(50, 13);
            id_ingredienteLabel.TabIndex = 2;
            id_ingredienteLabel.Text = "Código:";
            // 
            // nome_ingredienteLabel
            // 
            nome_ingredienteLabel.AutoSize = true;
            nome_ingredienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_ingredienteLabel.Location = new System.Drawing.Point(96, 143);
            nome_ingredienteLabel.Name = "nome_ingredienteLabel";
            nome_ingredienteLabel.Size = new System.Drawing.Size(75, 13);
            nome_ingredienteLabel.TabIndex = 4;
            nome_ingredienteLabel.Text = "Ingrediente:";
            // 
            // unidade_medida_ingredienteLabel
            // 
            unidade_medida_ingredienteLabel.AutoSize = true;
            unidade_medida_ingredienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            unidade_medida_ingredienteLabel.Location = new System.Drawing.Point(96, 169);
            unidade_medida_ingredienteLabel.Name = "unidade_medida_ingredienteLabel";
            unidade_medida_ingredienteLabel.Size = new System.Drawing.Size(120, 13);
            unidade_medida_ingredienteLabel.TabIndex = 6;
            unidade_medida_ingredienteLabel.Text = "Unidade de medida:";
            // 
            // preco_custo_ingredienteLabel
            // 
            preco_custo_ingredienteLabel.AutoSize = true;
            preco_custo_ingredienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            preco_custo_ingredienteLabel.Location = new System.Drawing.Point(96, 199);
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
            this.tableAdapterManager.fornecedoresTableAdapter = null;
            this.tableAdapterManager.ingredientesTableAdapter = this.ingredientesTableAdapter;
            this.tableAdapterManager.item_pedidoTableAdapter = null;
            this.tableAdapterManager.pagamentoTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
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
            this.ingredientesBindingNavigator.Size = new System.Drawing.Size(450, 25);
            this.ingredientesBindingNavigator.TabIndex = 0;
            this.ingredientesBindingNavigator.Text = "bindingNavigator1";
            this.ingredientesBindingNavigator.Visible = false;
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
            // id_ingredienteTextBox
            // 
            this.id_ingredienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientesBindingSource, "id_ingrediente", true));
            this.id_ingredienteTextBox.Location = new System.Drawing.Point(228, 118);
            this.id_ingredienteTextBox.Name = "id_ingredienteTextBox";
            this.id_ingredienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_ingredienteTextBox.TabIndex = 3;
            // 
            // nome_ingredienteTextBox
            // 
            this.nome_ingredienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientesBindingSource, "nome_ingrediente", true));
            this.nome_ingredienteTextBox.Location = new System.Drawing.Point(228, 144);
            this.nome_ingredienteTextBox.Name = "nome_ingredienteTextBox";
            this.nome_ingredienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.nome_ingredienteTextBox.TabIndex = 5;
            // 
            // unidade_medida_ingredienteTextBox
            // 
            this.unidade_medida_ingredienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientesBindingSource, "unidade_medida_ingrediente", true));
            this.unidade_medida_ingredienteTextBox.Location = new System.Drawing.Point(228, 170);
            this.unidade_medida_ingredienteTextBox.Name = "unidade_medida_ingredienteTextBox";
            this.unidade_medida_ingredienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.unidade_medida_ingredienteTextBox.TabIndex = 7;
            // 
            // preco_custo_ingredienteTextBox
            // 
            this.preco_custo_ingredienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ingredientesBindingSource, "preco_custo_ingrediente", true));
            this.preco_custo_ingredienteTextBox.Location = new System.Drawing.Point(228, 196);
            this.preco_custo_ingredienteTextBox.Name = "preco_custo_ingredienteTextBox";
            this.preco_custo_ingredienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.preco_custo_ingredienteTextBox.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Plum;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 49);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Ingredientes";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Location = new System.Drawing.Point(44, 66);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Incluir.TabIndex = 21;
            this.btn_Incluir.Text = "Incluir";
            this.btn_Incluir.UseVisualStyleBackColor = true;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(125, 66);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 22;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(218, 66);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 23;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Visualizar
            // 
            this.btn_Visualizar.Location = new System.Drawing.Point(309, 66);
            this.btn_Visualizar.Name = "btn_Visualizar";
            this.btn_Visualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Visualizar.TabIndex = 24;
            this.btn_Visualizar.Text = "Visualizar";
            this.btn_Visualizar.UseVisualStyleBackColor = true;
            this.btn_Visualizar.Click += new System.EventHandler(this.btn_Visualizar_Click);
            // 
            // frmIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(450, 262);
            this.Controls.Add(this.btn_Visualizar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Incluir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(id_ingredienteLabel);
            this.Controls.Add(this.id_ingredienteTextBox);
            this.Controls.Add(nome_ingredienteLabel);
            this.Controls.Add(this.nome_ingredienteTextBox);
            this.Controls.Add(unidade_medida_ingredienteLabel);
            this.Controls.Add(this.unidade_medida_ingredienteTextBox);
            this.Controls.Add(preco_custo_ingredienteLabel);
            this.Controls.Add(this.preco_custo_ingredienteTextBox);
            this.Controls.Add(this.ingredientesBindingNavigator);
            this.Name = "frmIngrediente";
            this.ShowIcon = false;
            this.Text = "Cadastro de ingredientes";
            this.Load += new System.EventHandler(this.frmIngrediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientesBindingNavigator)).EndInit();
            this.ingredientesBindingNavigator.ResumeLayout(false);
            this.ingredientesBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox id_ingredienteTextBox;
        private System.Windows.Forms.TextBox nome_ingredienteTextBox;
        private System.Windows.Forms.TextBox unidade_medida_ingredienteTextBox;
        private System.Windows.Forms.TextBox preco_custo_ingredienteTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Incluir;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Visualizar;
    }
}