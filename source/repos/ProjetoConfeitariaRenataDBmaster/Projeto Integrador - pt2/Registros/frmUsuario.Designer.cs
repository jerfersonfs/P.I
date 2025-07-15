namespace Projeto_Integrador___pt2.Formulários
{
    partial class frmUsuario
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
            System.Windows.Forms.Label id_usuLabel;
            System.Windows.Forms.Label nome_usuLabel;
            System.Windows.Forms.Label senha_usuLabel;
            System.Windows.Forms.Label celular_usuLabel;
            System.Windows.Forms.Label telefone_usuLabel;
            System.Windows.Forms.Label email_usuLabel;
            System.Windows.Forms.Label data_cadastroLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.usuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.renataDBDataSet = new Projeto_Integrador___pt2.RenataDBDataSet();
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
            this.usuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_usuTextBox = new System.Windows.Forms.TextBox();
            this.nome_usuTextBox = new System.Windows.Forms.TextBox();
            this.senha_usuTextBox = new System.Windows.Forms.TextBox();
            this.celular_usuTextBox = new System.Windows.Forms.TextBox();
            this.telefone_usuTextBox = new System.Windows.Forms.TextBox();
            this.email_usuTextBox = new System.Windows.Forms.TextBox();
            this.data_cadastroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.repitasenhatxtBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.usuarioTableAdapter();
            this.tableAdapterManager = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.clienteTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            id_usuLabel = new System.Windows.Forms.Label();
            nome_usuLabel = new System.Windows.Forms.Label();
            senha_usuLabel = new System.Windows.Forms.Label();
            celular_usuLabel = new System.Windows.Forms.Label();
            telefone_usuLabel = new System.Windows.Forms.Label();
            email_usuLabel = new System.Windows.Forms.Label();
            data_cadastroLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).BeginInit();
            this.usuarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_usuLabel
            // 
            id_usuLabel.AutoSize = true;
            id_usuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_usuLabel.Location = new System.Drawing.Point(37, 81);
            id_usuLabel.Name = "id_usuLabel";
            id_usuLabel.Size = new System.Drawing.Size(50, 13);
            id_usuLabel.TabIndex = 1;
            id_usuLabel.Text = "Código:";
            id_usuLabel.Click += new System.EventHandler(this.id_usuLabel_Click);
            // 
            // nome_usuLabel
            // 
            nome_usuLabel.AutoSize = true;
            nome_usuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_usuLabel.Location = new System.Drawing.Point(37, 107);
            nome_usuLabel.Name = "nome_usuLabel";
            nome_usuLabel.Size = new System.Drawing.Size(43, 13);
            nome_usuLabel.TabIndex = 3;
            nome_usuLabel.Text = "Nome:";
            // 
            // senha_usuLabel
            // 
            senha_usuLabel.AutoSize = true;
            senha_usuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            senha_usuLabel.Location = new System.Drawing.Point(347, 80);
            senha_usuLabel.Name = "senha_usuLabel";
            senha_usuLabel.Size = new System.Drawing.Size(47, 13);
            senha_usuLabel.TabIndex = 5;
            senha_usuLabel.Text = "Senha:";
            // 
            // celular_usuLabel
            // 
            celular_usuLabel.AutoSize = true;
            celular_usuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            celular_usuLabel.Location = new System.Drawing.Point(171, 147);
            celular_usuLabel.Name = "celular_usuLabel";
            celular_usuLabel.Size = new System.Drawing.Size(50, 13);
            celular_usuLabel.TabIndex = 7;
            celular_usuLabel.Text = "Celular:";
            // 
            // telefone_usuLabel
            // 
            telefone_usuLabel.AutoSize = true;
            telefone_usuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefone_usuLabel.Location = new System.Drawing.Point(171, 173);
            telefone_usuLabel.Name = "telefone_usuLabel";
            telefone_usuLabel.Size = new System.Drawing.Size(61, 13);
            telefone_usuLabel.TabIndex = 9;
            telefone_usuLabel.Text = "Telefone:";
            // 
            // email_usuLabel
            // 
            email_usuLabel.AutoSize = true;
            email_usuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            email_usuLabel.Location = new System.Drawing.Point(171, 199);
            email_usuLabel.Name = "email_usuLabel";
            email_usuLabel.Size = new System.Drawing.Size(41, 13);
            email_usuLabel.TabIndex = 11;
            email_usuLabel.Text = "Email:";
            // 
            // data_cadastroLabel
            // 
            data_cadastroLabel.AutoSize = true;
            data_cadastroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_cadastroLabel.Location = new System.Drawing.Point(245, 23);
            data_cadastroLabel.Name = "data_cadastroLabel";
            data_cadastroLabel.Size = new System.Drawing.Size(110, 13);
            data_cadastroLabel.TabIndex = 13;
            data_cadastroLabel.Text = "Data de Cadastro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(347, 106);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 13);
            label2.TabIndex = 19;
            label2.Text = "Repita senha:";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // usuarioBindingNavigator
            // 
            this.usuarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usuarioBindingNavigator.BindingSource = this.usuarioBindingSource;
            this.usuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usuarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.usuarioBindingNavigatorSaveItem});
            this.usuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usuarioBindingNavigator.Name = "usuarioBindingNavigator";
            this.usuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usuarioBindingNavigator.Size = new System.Drawing.Size(833, 25);
            this.usuarioBindingNavigator.TabIndex = 0;
            this.usuarioBindingNavigator.Text = "bindingNavigator1";
            this.usuarioBindingNavigator.Visible = false;
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
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.renataDBDataSet;
            // 
            // renataDBDataSet
            // 
            this.renataDBDataSet.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // usuarioBindingNavigatorSaveItem
            // 
            this.usuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioBindingNavigatorSaveItem.Image")));
            this.usuarioBindingNavigatorSaveItem.Name = "usuarioBindingNavigatorSaveItem";
            this.usuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usuarioBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.usuarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.usuarioBindingNavigatorSaveItem_Click);
            // 
            // id_usuTextBox
            // 
            this.id_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "id_usu", true));
            this.id_usuTextBox.Location = new System.Drawing.Point(104, 78);
            this.id_usuTextBox.Name = "id_usuTextBox";
            this.id_usuTextBox.Size = new System.Drawing.Size(56, 20);
            this.id_usuTextBox.TabIndex = 2;
            // 
            // nome_usuTextBox
            // 
            this.nome_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "nome_usu", true));
            this.nome_usuTextBox.Location = new System.Drawing.Point(104, 104);
            this.nome_usuTextBox.Name = "nome_usuTextBox";
            this.nome_usuTextBox.Size = new System.Drawing.Size(183, 20);
            this.nome_usuTextBox.TabIndex = 4;
            // 
            // senha_usuTextBox
            // 
            this.senha_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "senha_usu", true));
            this.senha_usuTextBox.Location = new System.Drawing.Point(439, 77);
            this.senha_usuTextBox.Name = "senha_usuTextBox";
            this.senha_usuTextBox.Size = new System.Drawing.Size(123, 20);
            this.senha_usuTextBox.TabIndex = 6;
            this.senha_usuTextBox.UseSystemPasswordChar = true;
            // 
            // celular_usuTextBox
            // 
            this.celular_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "celular_usu", true));
            this.celular_usuTextBox.Location = new System.Drawing.Point(238, 144);
            this.celular_usuTextBox.Name = "celular_usuTextBox";
            this.celular_usuTextBox.Size = new System.Drawing.Size(183, 20);
            this.celular_usuTextBox.TabIndex = 8;
            // 
            // telefone_usuTextBox
            // 
            this.telefone_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "telefone_usu", true));
            this.telefone_usuTextBox.Location = new System.Drawing.Point(238, 170);
            this.telefone_usuTextBox.Name = "telefone_usuTextBox";
            this.telefone_usuTextBox.Size = new System.Drawing.Size(183, 20);
            this.telefone_usuTextBox.TabIndex = 10;
            this.telefone_usuTextBox.TextChanged += new System.EventHandler(this.telefone_usuTextBox_TextChanged);
            // 
            // email_usuTextBox
            // 
            this.email_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "email_usu", true));
            this.email_usuTextBox.Location = new System.Drawing.Point(238, 196);
            this.email_usuTextBox.Name = "email_usuTextBox";
            this.email_usuTextBox.Size = new System.Drawing.Size(183, 20);
            this.email_usuTextBox.TabIndex = 12;
            // 
            // data_cadastroDateTimePicker
            // 
            this.data_cadastroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuarioBindingSource, "data_cadastro", true));
            this.data_cadastroDateTimePicker.Location = new System.Drawing.Point(205, 41);
            this.data_cadastroDateTimePicker.Name = "data_cadastroDateTimePicker";
            this.data_cadastroDateTimePicker.Size = new System.Drawing.Size(216, 20);
            this.data_cadastroDateTimePicker.TabIndex = 14;
            // 
            // repitasenhatxtBox
            // 
            this.repitasenhatxtBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "senha_usu", true));
            this.repitasenhatxtBox.Location = new System.Drawing.Point(439, 103);
            this.repitasenhatxtBox.Name = "repitasenhatxtBox";
            this.repitasenhatxtBox.Size = new System.Drawing.Size(123, 20);
            this.repitasenhatxtBox.TabIndex = 20;
            this.repitasenhatxtBox.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Plum;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.MaxLength = 456754;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(833, 49);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "Cadastro de Usuário";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.renataDBDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.receitaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_usuTextBox);
            this.groupBox1.Controls.Add(this.email_usuTextBox);
            this.groupBox1.Controls.Add(data_cadastroLabel);
            this.groupBox1.Controls.Add(this.data_cadastroDateTimePicker);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(email_usuLabel);
            this.groupBox1.Controls.Add(this.repitasenhatxtBox);
            this.groupBox1.Controls.Add(this.telefone_usuTextBox);
            this.groupBox1.Controls.Add(id_usuLabel);
            this.groupBox1.Controls.Add(telefone_usuLabel);
            this.groupBox1.Controls.Add(this.celular_usuTextBox);
            this.groupBox1.Controls.Add(nome_usuLabel);
            this.groupBox1.Controls.Add(celular_usuLabel);
            this.groupBox1.Controls.Add(this.nome_usuTextBox);
            this.groupBox1.Controls.Add(this.senha_usuTextBox);
            this.groupBox1.Controls.Add(senha_usuLabel);
            this.groupBox1.Location = new System.Drawing.Point(69, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 244);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 23;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(567, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 25);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Deletar";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(659, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 25);
            this.btnSalvar.TabIndex = 25;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(746, 12);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 25);
            this.btnVisualizar.TabIndex = 26;
            this.btnVisualizar.Text = "Vizualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(833, 375);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.usuarioBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).EndInit();
            this.usuarioBindingNavigator.ResumeLayout(false);
            this.usuarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenataDBDataSet renataDBDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private RenataDBDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usuarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton usuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_usuTextBox;
        private System.Windows.Forms.TextBox nome_usuTextBox;
        private System.Windows.Forms.TextBox senha_usuTextBox;
        private System.Windows.Forms.TextBox celular_usuTextBox;
        private System.Windows.Forms.TextBox telefone_usuTextBox;
        private System.Windows.Forms.TextBox email_usuTextBox;
        private System.Windows.Forms.DateTimePicker data_cadastroDateTimePicker;
        private System.Windows.Forms.TextBox repitasenhatxtBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private RenataDBDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVisualizar;
    }
}