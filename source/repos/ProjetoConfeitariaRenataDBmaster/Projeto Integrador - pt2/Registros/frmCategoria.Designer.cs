namespace Projeto_Integrador___pt2.Formulários
{
    partial class frmCategoria
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
            System.Windows.Forms.Label id_categoriaLabel;
            System.Windows.Forms.Label nome_categoriaLabel;
            System.Windows.Forms.Label personalizacaoLabel;
            System.Windows.Forms.Label status_catLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.renataDBDataSet2 = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.categoriaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaTableAdapter2 = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.categoriaTableAdapter();
            this.tableAdapterManager2 = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.categoriaBindingSource2BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.categoriaBindingSource2BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.categoriaDataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_categoriaTextBox2 = new System.Windows.Forms.TextBox();
            this.nome_categoriaTextBox2 = new System.Windows.Forms.TextBox();
            this.personalizacaoTextBox2 = new System.Windows.Forms.TextBox();
            this.status_catTextBox2 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            id_categoriaLabel = new System.Windows.Forms.Label();
            nome_categoriaLabel = new System.Windows.Forms.Label();
            personalizacaoLabel = new System.Windows.Forms.Label();
            status_catLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource2BindingNavigator)).BeginInit();
            this.categoriaBindingSource2BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_categoriaLabel
            // 
            id_categoriaLabel.AutoSize = true;
            id_categoriaLabel.Location = new System.Drawing.Point(158, 96);
            id_categoriaLabel.Name = "id_categoriaLabel";
            id_categoriaLabel.Size = new System.Drawing.Size(43, 13);
            id_categoriaLabel.TabIndex = 2;
            id_categoriaLabel.Text = "Código:";
            // 
            // nome_categoriaLabel
            // 
            nome_categoriaLabel.AutoSize = true;
            nome_categoriaLabel.Location = new System.Drawing.Point(158, 122);
            nome_categoriaLabel.Name = "nome_categoriaLabel";
            nome_categoriaLabel.Size = new System.Drawing.Size(55, 13);
            nome_categoriaLabel.TabIndex = 4;
            nome_categoriaLabel.Text = "Categoria:";
            // 
            // personalizacaoLabel
            // 
            personalizacaoLabel.AutoSize = true;
            personalizacaoLabel.Location = new System.Drawing.Point(158, 148);
            personalizacaoLabel.Name = "personalizacaoLabel";
            personalizacaoLabel.Size = new System.Drawing.Size(82, 13);
            personalizacaoLabel.TabIndex = 6;
            personalizacaoLabel.Text = "Personalizacao:";
            // 
            // status_catLabel
            // 
            status_catLabel.AutoSize = true;
            status_catLabel.Location = new System.Drawing.Point(158, 174);
            status_catLabel.Name = "status_catLabel";
            status_catLabel.Size = new System.Drawing.Size(40, 13);
            status_catLabel.TabIndex = 8;
            status_catLabel.Text = "Status:";
            // 
            // renataDBDataSet2
            // 
            this.renataDBDataSet2.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaBindingSource2
            // 
            this.categoriaBindingSource2.DataMember = "categoria";
            this.categoriaBindingSource2.DataSource = this.renataDBDataSet2;
            // 
            // categoriaTableAdapter2
            // 
            this.categoriaTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.avaliacaoTableAdapter = null;
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.categoriaTableAdapter = this.categoriaTableAdapter2;
            this.tableAdapterManager2.clienteTableAdapter = null;
            this.tableAdapterManager2.estoqueTableAdapter = null;
            this.tableAdapterManager2.eventosTableAdapter = null;
            this.tableAdapterManager2.fornecedoresTableAdapter = null;
            this.tableAdapterManager2.ingredientesTableAdapter = null;
            this.tableAdapterManager2.item_pedidoTableAdapter = null;
            this.tableAdapterManager2.pagamentoTableAdapter = null;
            this.tableAdapterManager2.pedidoTableAdapter = null;
            this.tableAdapterManager2.produtoTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager2.usuarioTableAdapter = null;
            // 
            // categoriaBindingSource2BindingNavigator
            // 
            this.categoriaBindingSource2BindingNavigator.AddNewItem = this.toolStripButton11;
            this.categoriaBindingSource2BindingNavigator.BindingSource = this.categoriaBindingSource2;
            this.categoriaBindingSource2BindingNavigator.CountItem = this.toolStripLabel2;
            this.categoriaBindingSource2BindingNavigator.DeleteItem = this.toolStripButton12;
            this.categoriaBindingSource2BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator6,
            this.toolStripButton11,
            this.toolStripButton12,
            this.categoriaBindingSource2BindingNavigatorSaveItem});
            this.categoriaBindingSource2BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoriaBindingSource2BindingNavigator.MoveFirstItem = this.toolStripButton7;
            this.categoriaBindingSource2BindingNavigator.MoveLastItem = this.toolStripButton10;
            this.categoriaBindingSource2BindingNavigator.MoveNextItem = this.toolStripButton9;
            this.categoriaBindingSource2BindingNavigator.MovePreviousItem = this.toolStripButton8;
            this.categoriaBindingSource2BindingNavigator.Name = "categoriaBindingSource2BindingNavigator";
            this.categoriaBindingSource2BindingNavigator.PositionItem = this.toolStripTextBox2;
            this.categoriaBindingSource2BindingNavigator.Size = new System.Drawing.Size(622, 25);
            this.categoriaBindingSource2BindingNavigator.TabIndex = 0;
            this.categoriaBindingSource2BindingNavigator.Text = "bindingNavigator1";
            this.categoriaBindingSource2BindingNavigator.Visible = false;
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Adicionar novo";
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel2.Text = "de {0}";
            this.toolStripLabel2.ToolTipText = "Número total de itens";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Excluir";
            this.toolStripButton12.Click += new System.EventHandler(this.toolStripButton12_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Mover primeiro";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Mover anterior";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Posição";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Posição atual";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Mover próximo";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Mover último";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // categoriaBindingSource2BindingNavigatorSaveItem
            // 
            this.categoriaBindingSource2BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoriaBindingSource2BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriaBindingSource2BindingNavigatorSaveItem.Image")));
            this.categoriaBindingSource2BindingNavigatorSaveItem.Name = "categoriaBindingSource2BindingNavigatorSaveItem";
            this.categoriaBindingSource2BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.categoriaBindingSource2BindingNavigatorSaveItem.Text = "Salvar Dados";
            this.categoriaBindingSource2BindingNavigatorSaveItem.Click += new System.EventHandler(this.categoriaBindingSource2BindingNavigatorSaveItem_Click);
            // 
            // categoriaDataGridView2
            // 
            this.categoriaDataGridView2.AutoGenerateColumns = false;
            this.categoriaDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriaDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.categoriaDataGridView2.DataSource = this.categoriaBindingSource2;
            this.categoriaDataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.categoriaDataGridView2.Location = new System.Drawing.Point(0, 258);
            this.categoriaDataGridView2.Name = "categoriaDataGridView2";
            this.categoriaDataGridView2.Size = new System.Drawing.Size(622, 293);
            this.categoriaDataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_categoria";
            this.dataGridViewTextBoxColumn9.HeaderText = "id_categoria";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 130;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "nome_categoria";
            this.dataGridViewTextBoxColumn10.HeaderText = "nome_categoria";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 130;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "personalizacao";
            this.dataGridViewTextBoxColumn11.HeaderText = "personalizacao";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 170;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "status_cat";
            this.dataGridViewTextBoxColumn12.HeaderText = "status_cat";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // id_categoriaTextBox2
            // 
            this.id_categoriaTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource2, "id_categoria", true));
            this.id_categoriaTextBox2.Location = new System.Drawing.Point(247, 93);
            this.id_categoriaTextBox2.Name = "id_categoriaTextBox2";
            this.id_categoriaTextBox2.Size = new System.Drawing.Size(173, 20);
            this.id_categoriaTextBox2.TabIndex = 3;
            // 
            // nome_categoriaTextBox2
            // 
            this.nome_categoriaTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource2, "nome_categoria", true));
            this.nome_categoriaTextBox2.Location = new System.Drawing.Point(247, 119);
            this.nome_categoriaTextBox2.Name = "nome_categoriaTextBox2";
            this.nome_categoriaTextBox2.Size = new System.Drawing.Size(173, 20);
            this.nome_categoriaTextBox2.TabIndex = 5;
            // 
            // personalizacaoTextBox2
            // 
            this.personalizacaoTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource2, "personalizacao", true));
            this.personalizacaoTextBox2.Location = new System.Drawing.Point(247, 145);
            this.personalizacaoTextBox2.Name = "personalizacaoTextBox2";
            this.personalizacaoTextBox2.Size = new System.Drawing.Size(173, 20);
            this.personalizacaoTextBox2.TabIndex = 7;
            // 
            // status_catTextBox2
            // 
            this.status_catTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource2, "status_cat", true));
            this.status_catTextBox2.Location = new System.Drawing.Point(247, 171);
            this.status_catTextBox2.Name = "status_catTextBox2";
            this.status_catTextBox2.Size = new System.Drawing.Size(173, 20);
            this.status_catTextBox2.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(622, 47);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "Gerenciamento de categorias";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Incluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 28;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(351, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 29;
            this.button4.Text = "Salvar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Pesquisar);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Location = new System.Drawing.Point(0, 204);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 48);
            this.groupBox2.TabIndex = 31;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(210, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(193, 20);
            this.textBox3.TabIndex = 2;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Código",
            "Categoria"});
            this.comboBox1.Location = new System.Drawing.Point(58, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // frmCategoria
            // 
            this.ClientSize = new System.Drawing.Size(622, 551);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(id_categoriaLabel);
            this.Controls.Add(this.id_categoriaTextBox2);
            this.Controls.Add(nome_categoriaLabel);
            this.Controls.Add(this.nome_categoriaTextBox2);
            this.Controls.Add(personalizacaoLabel);
            this.Controls.Add(this.personalizacaoTextBox2);
            this.Controls.Add(status_catLabel);
            this.Controls.Add(this.status_catTextBox2);
            this.Controls.Add(this.categoriaDataGridView2);
            this.Controls.Add(this.categoriaBindingSource2BindingNavigator);
            this.Name = "frmCategoria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCategoria_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource2BindingNavigator)).EndInit();
            this.categoriaBindingSource2BindingNavigator.ResumeLayout(false);
            this.categoriaBindingSource2BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
       
       
        private RenataDBDataSet renataDBDataSet2;
        private System.Windows.Forms.BindingSource categoriaBindingSource2;
        private RenataDBDataSetTableAdapters.categoriaTableAdapter categoriaTableAdapter2;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.BindingNavigator categoriaBindingSource2BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton categoriaBindingSource2BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView categoriaDataGridView2;
        private System.Windows.Forms.TextBox id_categoriaTextBox2;
        private System.Windows.Forms.TextBox nome_categoriaTextBox2;
        private System.Windows.Forms.TextBox personalizacaoTextBox2;
        private System.Windows.Forms.TextBox status_catTextBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
    }
}