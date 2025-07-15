namespace Projeto_Integrador___pt2.Formulários
{
    partial class frmReceita
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
            System.Windows.Forms.Label id_receitaLabel;
            System.Windows.Forms.Label nome_receitaLabel;
            System.Windows.Forms.Label instrucoes_receitasLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceita));
            this.renataDBDataSet = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.receitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receitaTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.receitaTableAdapter();
            this.tableAdapterManager = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.receitaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.receitaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_receitaTextBox = new System.Windows.Forms.TextBox();
            this.nome_receitaTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.instrucoes_receitasTextBox = new System.Windows.Forms.TextBox();
            id_receitaLabel = new System.Windows.Forms.Label();
            nome_receitaLabel = new System.Windows.Forms.Label();
            instrucoes_receitasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitaBindingNavigator)).BeginInit();
            this.receitaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_receitaLabel
            // 
            id_receitaLabel.AutoSize = true;
            id_receitaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_receitaLabel.Location = new System.Drawing.Point(25, 171);
            id_receitaLabel.Name = "id_receitaLabel";
            id_receitaLabel.Size = new System.Drawing.Size(50, 13);
            id_receitaLabel.TabIndex = 2;
            id_receitaLabel.Text = "Código:";
            // 
            // nome_receitaLabel
            // 
            nome_receitaLabel.AutoSize = true;
            nome_receitaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_receitaLabel.Location = new System.Drawing.Point(25, 197);
            nome_receitaLabel.Name = "nome_receitaLabel";
            nome_receitaLabel.Size = new System.Drawing.Size(55, 13);
            nome_receitaLabel.TabIndex = 4;
            nome_receitaLabel.Text = "Receita:";
            // 
            // instrucoes_receitasLabel
            // 
            instrucoes_receitasLabel.AutoSize = true;
            instrucoes_receitasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            instrucoes_receitasLabel.Location = new System.Drawing.Point(25, 223);
            instrucoes_receitasLabel.Name = "instrucoes_receitasLabel";
            instrucoes_receitasLabel.Size = new System.Drawing.Size(70, 13);
            instrucoes_receitasLabel.TabIndex = 6;
            instrucoes_receitasLabel.Text = "Instruções:";
            // 
            // renataDBDataSet
            // 
            this.renataDBDataSet.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receitaBindingSource
            // 
            this.receitaBindingSource.DataMember = "receita";
            this.receitaBindingSource.DataSource = this.renataDBDataSet;
            // 
            // receitaTableAdapter
            // 
            this.receitaTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.receitaTableAdapter = this.receitaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // receitaBindingNavigator
            // 
            this.receitaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.receitaBindingNavigator.BindingSource = this.receitaBindingSource;
            this.receitaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.receitaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.receitaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.receitaBindingNavigatorSaveItem});
            this.receitaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.receitaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.receitaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.receitaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.receitaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.receitaBindingNavigator.Name = "receitaBindingNavigator";
            this.receitaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.receitaBindingNavigator.Size = new System.Drawing.Size(440, 25);
            this.receitaBindingNavigator.TabIndex = 0;
            this.receitaBindingNavigator.Text = "bindingNavigator1";
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
            // receitaBindingNavigatorSaveItem
            // 
            this.receitaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.receitaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("receitaBindingNavigatorSaveItem.Image")));
            this.receitaBindingNavigatorSaveItem.Name = "receitaBindingNavigatorSaveItem";
            this.receitaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.receitaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.receitaBindingNavigatorSaveItem.Click += new System.EventHandler(this.receitaBindingNavigatorSaveItem_Click);
            // 
            // id_receitaTextBox
            // 
            this.id_receitaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receitaBindingSource, "id_receita", true));
            this.id_receitaTextBox.Location = new System.Drawing.Point(98, 168);
            this.id_receitaTextBox.Name = "id_receitaTextBox";
            this.id_receitaTextBox.Size = new System.Drawing.Size(278, 20);
            this.id_receitaTextBox.TabIndex = 3;
            // 
            // nome_receitaTextBox
            // 
            this.nome_receitaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receitaBindingSource, "nome_receita", true));
            this.nome_receitaTextBox.Location = new System.Drawing.Point(98, 194);
            this.nome_receitaTextBox.Name = "nome_receitaTextBox";
            this.nome_receitaTextBox.Size = new System.Drawing.Size(278, 20);
            this.nome_receitaTextBox.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Plum;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(129, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 49);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "Receitas";
            // 
            // instrucoes_receitasTextBox
            // 
            this.instrucoes_receitasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receitaBindingSource, "instrucoes_receitas", true));
            this.instrucoes_receitasTextBox.Location = new System.Drawing.Point(98, 223);
            this.instrucoes_receitasTextBox.Multiline = true;
            this.instrucoes_receitasTextBox.Name = "instrucoes_receitasTextBox";
            this.instrucoes_receitasTextBox.Size = new System.Drawing.Size(278, 291);
            this.instrucoes_receitasTextBox.TabIndex = 7;
            this.instrucoes_receitasTextBox.Text = " ";
            // 
            // frmReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(440, 541);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(id_receitaLabel);
            this.Controls.Add(this.id_receitaTextBox);
            this.Controls.Add(nome_receitaLabel);
            this.Controls.Add(this.nome_receitaTextBox);
            this.Controls.Add(instrucoes_receitasLabel);
            this.Controls.Add(this.instrucoes_receitasTextBox);
            this.Controls.Add(this.receitaBindingNavigator);
            this.Name = "frmReceita";
            this.ShowIcon = false;
            this.Text = "Cadastro de receitas";
            this.Load += new System.EventHandler(this.frmReceita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receitaBindingNavigator)).EndInit();
            this.receitaBindingNavigator.ResumeLayout(false);
            this.receitaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenataDBDataSet renataDBDataSet;
        private System.Windows.Forms.BindingSource receitaBindingSource;
        private RenataDBDataSetTableAdapters.receitaTableAdapter receitaTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator receitaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton receitaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_receitaTextBox;
        private System.Windows.Forms.TextBox nome_receitaTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox instrucoes_receitasTextBox;
    }
}