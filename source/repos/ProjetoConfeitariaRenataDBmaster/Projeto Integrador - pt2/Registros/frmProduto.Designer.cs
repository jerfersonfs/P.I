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
            System.Windows.Forms.Label fKid_categoriaLabel;
            System.Windows.Forms.Label promocaoLabel;
            System.Windows.Forms.Label data_inicio_promocaoLabel;
            System.Windows.Forms.Label data_fim_promocaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.renataDBDataSet1 = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.produtoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.produtoTableAdapter1 = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.produtoTableAdapter();
            this.tableAdapterManager1 = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.produtoBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.produtoBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_produtoTextBox1 = new System.Windows.Forms.TextBox();
            this.nome_produtoTextBox1 = new System.Windows.Forms.TextBox();
            this.preco_produtoTextBox1 = new System.Windows.Forms.TextBox();
            this.fKid_categoriaTextBox1 = new System.Windows.Forms.TextBox();
            this.promocaoTextBox1 = new System.Windows.Forms.TextBox();
            this.data_inicio_promocaoDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.data_fim_promocaoDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            id_produtoLabel = new System.Windows.Forms.Label();
            nome_produtoLabel = new System.Windows.Forms.Label();
            preco_produtoLabel = new System.Windows.Forms.Label();
            fKid_categoriaLabel = new System.Windows.Forms.Label();
            promocaoLabel = new System.Windows.Forms.Label();
            data_inicio_promocaoLabel = new System.Windows.Forms.Label();
            data_fim_promocaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1BindingNavigator)).BeginInit();
            this.produtoBindingSource1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_produtoLabel
            // 
            id_produtoLabel.AutoSize = true;
            id_produtoLabel.Location = new System.Drawing.Point(151, 150);
            id_produtoLabel.Name = "id_produtoLabel";
            id_produtoLabel.Size = new System.Drawing.Size(43, 13);
            id_produtoLabel.TabIndex = 1;
            id_produtoLabel.Text = "Código:";
            // 
            // nome_produtoLabel
            // 
            nome_produtoLabel.AutoSize = true;
            nome_produtoLabel.Location = new System.Drawing.Point(151, 176);
            nome_produtoLabel.Name = "nome_produtoLabel";
            nome_produtoLabel.Size = new System.Drawing.Size(47, 13);
            nome_produtoLabel.TabIndex = 3;
            nome_produtoLabel.Text = "Produto:";
            // 
            // preco_produtoLabel
            // 
            preco_produtoLabel.AutoSize = true;
            preco_produtoLabel.Location = new System.Drawing.Point(151, 202);
            preco_produtoLabel.Name = "preco_produtoLabel";
            preco_produtoLabel.Size = new System.Drawing.Size(38, 13);
            preco_produtoLabel.TabIndex = 5;
            preco_produtoLabel.Text = "Preço:";
            // 
            // fKid_categoriaLabel
            // 
            fKid_categoriaLabel.AutoSize = true;
            fKid_categoriaLabel.Location = new System.Drawing.Point(151, 228);
            fKid_categoriaLabel.Name = "fKid_categoriaLabel";
            fKid_categoriaLabel.Size = new System.Drawing.Size(78, 13);
            fKid_categoriaLabel.TabIndex = 7;
            fKid_categoriaLabel.Text = "FKid categoria:";
            // 
            // promocaoLabel
            // 
            promocaoLabel.AutoSize = true;
            promocaoLabel.Location = new System.Drawing.Point(151, 254);
            promocaoLabel.Name = "promocaoLabel";
            promocaoLabel.Size = new System.Drawing.Size(57, 13);
            promocaoLabel.TabIndex = 9;
            promocaoLabel.Text = "promocao:";
            // 
            // data_inicio_promocaoLabel
            // 
            data_inicio_promocaoLabel.AutoSize = true;
            data_inicio_promocaoLabel.Location = new System.Drawing.Point(151, 281);
            data_inicio_promocaoLabel.Name = "data_inicio_promocaoLabel";
            data_inicio_promocaoLabel.Size = new System.Drawing.Size(108, 13);
            data_inicio_promocaoLabel.TabIndex = 11;
            data_inicio_promocaoLabel.Text = "data inicio promocao:";
            // 
            // data_fim_promocaoLabel
            // 
            data_fim_promocaoLabel.AutoSize = true;
            data_fim_promocaoLabel.Location = new System.Drawing.Point(151, 307);
            data_fim_promocaoLabel.Name = "data_fim_promocaoLabel";
            data_fim_promocaoLabel.Size = new System.Drawing.Size(97, 13);
            data_fim_promocaoLabel.TabIndex = 13;
            data_fim_promocaoLabel.Text = "data fim promocao:";
            // 
            // renataDBDataSet1
            // 
            this.renataDBDataSet1.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtoBindingSource1
            // 
            this.produtoBindingSource1.DataMember = "produto";
            this.produtoBindingSource1.DataSource = this.renataDBDataSet1;
            // 
            // produtoTableAdapter1
            // 
            this.produtoTableAdapter1.ClearBeforeFill = true;
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
            this.tableAdapterManager1.pedidoTableAdapter = null;
            this.tableAdapterManager1.produtoTableAdapter = this.produtoTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usuarioTableAdapter = null;
            // 
            // produtoBindingSource1BindingNavigator
            // 
            this.produtoBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.produtoBindingSource1BindingNavigator.BindingSource = this.produtoBindingSource1;
            this.produtoBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.produtoBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.produtoBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.produtoBindingSource1BindingNavigatorSaveItem});
            this.produtoBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.produtoBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.produtoBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.produtoBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.produtoBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.produtoBindingSource1BindingNavigator.Name = "produtoBindingSource1BindingNavigator";
            this.produtoBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.produtoBindingSource1BindingNavigator.Size = new System.Drawing.Size(1194, 25);
            this.produtoBindingSource1BindingNavigator.TabIndex = 0;
            this.produtoBindingSource1BindingNavigator.Text = "bindingNavigator1";
            this.produtoBindingSource1BindingNavigator.Visible = false;
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
            // produtoBindingSource1BindingNavigatorSaveItem
            // 
            this.produtoBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.produtoBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("produtoBindingSource1BindingNavigatorSaveItem.Image")));
            this.produtoBindingSource1BindingNavigatorSaveItem.Name = "produtoBindingSource1BindingNavigatorSaveItem";
            this.produtoBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.produtoBindingSource1BindingNavigatorSaveItem.Text = "Salvar Dados";
            this.produtoBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.produtoBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // id_produtoTextBox1
            // 
            this.id_produtoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource1, "id_produto", true));
            this.id_produtoTextBox1.Location = new System.Drawing.Point(265, 147);
            this.id_produtoTextBox1.Name = "id_produtoTextBox1";
            this.id_produtoTextBox1.Size = new System.Drawing.Size(200, 20);
            this.id_produtoTextBox1.TabIndex = 2;
            // 
            // nome_produtoTextBox1
            // 
            this.nome_produtoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource1, "nome_produto", true));
            this.nome_produtoTextBox1.Location = new System.Drawing.Point(265, 173);
            this.nome_produtoTextBox1.Name = "nome_produtoTextBox1";
            this.nome_produtoTextBox1.Size = new System.Drawing.Size(200, 20);
            this.nome_produtoTextBox1.TabIndex = 4;
            // 
            // preco_produtoTextBox1
            // 
            this.preco_produtoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource1, "preco_produto", true));
            this.preco_produtoTextBox1.Location = new System.Drawing.Point(265, 199);
            this.preco_produtoTextBox1.Name = "preco_produtoTextBox1";
            this.preco_produtoTextBox1.Size = new System.Drawing.Size(200, 20);
            this.preco_produtoTextBox1.TabIndex = 6;
            // 
            // fKid_categoriaTextBox1
            // 
            this.fKid_categoriaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource1, "FKid_categoria", true));
            this.fKid_categoriaTextBox1.Location = new System.Drawing.Point(265, 225);
            this.fKid_categoriaTextBox1.Name = "fKid_categoriaTextBox1";
            this.fKid_categoriaTextBox1.Size = new System.Drawing.Size(200, 20);
            this.fKid_categoriaTextBox1.TabIndex = 8;
            // 
            // promocaoTextBox1
            // 
            this.promocaoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource1, "promocao", true));
            this.promocaoTextBox1.Location = new System.Drawing.Point(265, 251);
            this.promocaoTextBox1.Name = "promocaoTextBox1";
            this.promocaoTextBox1.Size = new System.Drawing.Size(200, 20);
            this.promocaoTextBox1.TabIndex = 10;
            // 
            // data_inicio_promocaoDateTimePicker1
            // 
            this.data_inicio_promocaoDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.produtoBindingSource1, "data_inicio_promocao", true));
            this.data_inicio_promocaoDateTimePicker1.Location = new System.Drawing.Point(265, 277);
            this.data_inicio_promocaoDateTimePicker1.Name = "data_inicio_promocaoDateTimePicker1";
            this.data_inicio_promocaoDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.data_inicio_promocaoDateTimePicker1.TabIndex = 12;
            // 
            // data_fim_promocaoDateTimePicker1
            // 
            this.data_fim_promocaoDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.produtoBindingSource1, "data_fim_promocao", true));
            this.data_fim_promocaoDateTimePicker1.Location = new System.Drawing.Point(265, 303);
            this.data_fim_promocaoDateTimePicker1.Name = "data_fim_promocaoDateTimePicker1";
            this.data_fim_promocaoDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.data_fim_promocaoDateTimePicker1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(434, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Visualizar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(611, 47);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "Cadastro de produtos";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmProduto
            // 
            this.ClientSize = new System.Drawing.Size(611, 370);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_produtoLabel);
            this.Controls.Add(this.id_produtoTextBox1);
            this.Controls.Add(nome_produtoLabel);
            this.Controls.Add(this.nome_produtoTextBox1);
            this.Controls.Add(preco_produtoLabel);
            this.Controls.Add(this.preco_produtoTextBox1);
            this.Controls.Add(fKid_categoriaLabel);
            this.Controls.Add(this.fKid_categoriaTextBox1);
            this.Controls.Add(promocaoLabel);
            this.Controls.Add(this.promocaoTextBox1);
            this.Controls.Add(data_inicio_promocaoLabel);
            this.Controls.Add(this.data_inicio_promocaoDateTimePicker1);
            this.Controls.Add(data_fim_promocaoLabel);
            this.Controls.Add(this.data_fim_promocaoDateTimePicker1);
            this.Controls.Add(this.produtoBindingSource1BindingNavigator);
            this.Name = "frmProduto";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmProduto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource1BindingNavigator)).EndInit();
            this.produtoBindingSource1BindingNavigator.ResumeLayout(false);
            this.produtoBindingSource1BindingNavigator.PerformLayout();
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
        private RenataDBDataSet renataDBDataSet1;
        private System.Windows.Forms.BindingSource produtoBindingSource1;
        private RenataDBDataSetTableAdapters.produtoTableAdapter produtoTableAdapter1;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator produtoBindingSource1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton produtoBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_produtoTextBox1;
        private System.Windows.Forms.TextBox nome_produtoTextBox1;
        private System.Windows.Forms.TextBox preco_produtoTextBox1;
        private System.Windows.Forms.TextBox fKid_categoriaTextBox1;
        private System.Windows.Forms.TextBox promocaoTextBox1;
        private System.Windows.Forms.DateTimePicker data_inicio_promocaoDateTimePicker1;
        private System.Windows.Forms.DateTimePicker data_fim_promocaoDateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
    }
}