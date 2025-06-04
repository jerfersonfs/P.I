namespace Projeto_Integrador___pt2.Formulários
{
    partial class frmCliente
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
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label nome_clienteLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label celular_clienteLabel;
            System.Windows.Forms.Label email_clienteLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label rua_clienteLabel;
            System.Windows.Forms.Label numero_da_residencia_clienteLabel;
            System.Windows.Forms.Label bairro_clienteLabel;
            System.Windows.Forms.Label cidade_clienteLabel;
            System.Windows.Forms.Label estado_clienteLabel;
            System.Windows.Forms.Label cepLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.clienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.clienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            this.nome_clienteTextBox = new System.Windows.Forms.TextBox();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.cnpjTextBox = new System.Windows.Forms.TextBox();
            this.celular_clienteTextBox = new System.Windows.Forms.TextBox();
            this.email_clienteTextBox = new System.Windows.Forms.TextBox();
            this.data_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rua_clienteTextBox = new System.Windows.Forms.TextBox();
            this.numero_da_residencia_clienteTextBox = new System.Windows.Forms.TextBox();
            this.bairro_clienteTextBox = new System.Windows.Forms.TextBox();
            this.cidade_clienteTextBox = new System.Windows.Forms.TextBox();
            this.estado_clienteTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clienteTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.clienteTableAdapter();
            this.tableAdapterManager = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            id_clienteLabel = new System.Windows.Forms.Label();
            nome_clienteLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            celular_clienteLabel = new System.Windows.Forms.Label();
            email_clienteLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            rua_clienteLabel = new System.Windows.Forms.Label();
            numero_da_residencia_clienteLabel = new System.Windows.Forms.Label();
            bairro_clienteLabel = new System.Windows.Forms.Label();
            cidade_clienteLabel = new System.Windows.Forms.Label();
            estado_clienteLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).BeginInit();
            this.clienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_clienteLabel.Location = new System.Drawing.Point(120, 129);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(50, 13);
            id_clienteLabel.TabIndex = 2;
            id_clienteLabel.Text = "Código:";
            // 
            // nome_clienteLabel
            // 
            nome_clienteLabel.AutoSize = true;
            nome_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_clienteLabel.Location = new System.Drawing.Point(120, 155);
            nome_clienteLabel.Name = "nome_clienteLabel";
            nome_clienteLabel.Size = new System.Drawing.Size(43, 13);
            nome_clienteLabel.TabIndex = 4;
            nome_clienteLabel.Text = "Nome:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpfLabel.Location = new System.Drawing.Point(120, 181);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(34, 13);
            cpfLabel.TabIndex = 6;
            cpfLabel.Text = "CPF:";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cnpjLabel.Location = new System.Drawing.Point(120, 207);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(42, 13);
            cnpjLabel.TabIndex = 8;
            cnpjLabel.Text = "CPNJ:";
            // 
            // celular_clienteLabel
            // 
            celular_clienteLabel.AutoSize = true;
            celular_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            celular_clienteLabel.Location = new System.Drawing.Point(120, 233);
            celular_clienteLabel.Name = "celular_clienteLabel";
            celular_clienteLabel.Size = new System.Drawing.Size(50, 13);
            celular_clienteLabel.TabIndex = 10;
            celular_clienteLabel.Text = "Celular:";
            // 
            // email_clienteLabel
            // 
            email_clienteLabel.AutoSize = true;
            email_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            email_clienteLabel.Location = new System.Drawing.Point(120, 259);
            email_clienteLabel.Name = "email_clienteLabel";
            email_clienteLabel.Size = new System.Drawing.Size(41, 13);
            email_clienteLabel.TabIndex = 12;
            email_clienteLabel.Text = "Email:";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_nascimentoLabel.Location = new System.Drawing.Point(120, 286);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(108, 13);
            data_nascimentoLabel.TabIndex = 14;
            data_nascimentoLabel.Text = "Data Nascimento:";
            // 
            // rua_clienteLabel
            // 
            rua_clienteLabel.AutoSize = true;
            rua_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rua_clienteLabel.Location = new System.Drawing.Point(120, 337);
            rua_clienteLabel.Name = "rua_clienteLabel";
            rua_clienteLabel.Size = new System.Drawing.Size(34, 13);
            rua_clienteLabel.TabIndex = 16;
            rua_clienteLabel.Text = "Rua:";
            // 
            // numero_da_residencia_clienteLabel
            // 
            numero_da_residencia_clienteLabel.AutoSize = true;
            numero_da_residencia_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numero_da_residencia_clienteLabel.Location = new System.Drawing.Point(120, 363);
            numero_da_residencia_clienteLabel.Name = "numero_da_residencia_clienteLabel";
            numero_da_residencia_clienteLabel.Size = new System.Drawing.Size(134, 13);
            numero_da_residencia_clienteLabel.TabIndex = 18;
            numero_da_residencia_clienteLabel.Text = "Número de residência:";
            // 
            // bairro_clienteLabel
            // 
            bairro_clienteLabel.AutoSize = true;
            bairro_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bairro_clienteLabel.Location = new System.Drawing.Point(120, 389);
            bairro_clienteLabel.Name = "bairro_clienteLabel";
            bairro_clienteLabel.Size = new System.Drawing.Size(44, 13);
            bairro_clienteLabel.TabIndex = 20;
            bairro_clienteLabel.Text = "Bairro:";
            // 
            // cidade_clienteLabel
            // 
            cidade_clienteLabel.AutoSize = true;
            cidade_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidade_clienteLabel.Location = new System.Drawing.Point(120, 415);
            cidade_clienteLabel.Name = "cidade_clienteLabel";
            cidade_clienteLabel.Size = new System.Drawing.Size(50, 13);
            cidade_clienteLabel.TabIndex = 22;
            cidade_clienteLabel.Text = "Cidade:";
            // 
            // estado_clienteLabel
            // 
            estado_clienteLabel.AutoSize = true;
            estado_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estado_clienteLabel.Location = new System.Drawing.Point(120, 441);
            estado_clienteLabel.Name = "estado_clienteLabel";
            estado_clienteLabel.Size = new System.Drawing.Size(50, 13);
            estado_clienteLabel.TabIndex = 24;
            estado_clienteLabel.Text = "Estado:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cepLabel.Location = new System.Drawing.Point(120, 314);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(35, 13);
            cepLabel.TabIndex = 28;
            cepLabel.Text = "CEP:";
            // 
            // clienteBindingNavigator
            // 
            this.clienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clienteBindingNavigator.BindingSource = this.clienteBindingSource;
            this.clienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clienteBindingNavigatorSaveItem});
            this.clienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clienteBindingNavigator.Name = "clienteBindingNavigator";
            this.clienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clienteBindingNavigator.Size = new System.Drawing.Size(606, 25);
            this.clienteBindingNavigator.TabIndex = 0;
            this.clienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.renataDBDataSet;
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // clienteBindingNavigatorSaveItem
            // 
            this.clienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteBindingNavigatorSaveItem.Image")));
            this.clienteBindingNavigatorSaveItem.Name = "clienteBindingNavigatorSaveItem";
            this.clienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.clienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingNavigatorSaveItem_Click);
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "id_cliente", true));
            this.id_clienteTextBox.Location = new System.Drawing.Point(273, 129);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.id_clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_clienteTextBox.TabIndex = 3;
            // 
            // nome_clienteTextBox
            // 
            this.nome_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "nome_cliente", true));
            this.nome_clienteTextBox.Location = new System.Drawing.Point(273, 155);
            this.nome_clienteTextBox.Name = "nome_clienteTextBox";
            this.nome_clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.nome_clienteTextBox.TabIndex = 5;
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cpf", true));
            this.cpfTextBox.Location = new System.Drawing.Point(273, 181);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(200, 20);
            this.cpfTextBox.TabIndex = 7;
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cnpj", true));
            this.cnpjTextBox.Location = new System.Drawing.Point(273, 207);
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(200, 20);
            this.cnpjTextBox.TabIndex = 9;
            // 
            // celular_clienteTextBox
            // 
            this.celular_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "celular_cliente", true));
            this.celular_clienteTextBox.Location = new System.Drawing.Point(273, 233);
            this.celular_clienteTextBox.Name = "celular_clienteTextBox";
            this.celular_clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.celular_clienteTextBox.TabIndex = 11;
            // 
            // email_clienteTextBox
            // 
            this.email_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "email_cliente", true));
            this.email_clienteTextBox.Location = new System.Drawing.Point(273, 259);
            this.email_clienteTextBox.Name = "email_clienteTextBox";
            this.email_clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.email_clienteTextBox.TabIndex = 13;
            // 
            // data_nascimentoDateTimePicker
            // 
            this.data_nascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource, "data_nascimento", true));
            this.data_nascimentoDateTimePicker.Location = new System.Drawing.Point(273, 285);
            this.data_nascimentoDateTimePicker.Name = "data_nascimentoDateTimePicker";
            this.data_nascimentoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_nascimentoDateTimePicker.TabIndex = 15;
            // 
            // rua_clienteTextBox
            // 
            this.rua_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "rua_cliente", true));
            this.rua_clienteTextBox.Location = new System.Drawing.Point(273, 337);
            this.rua_clienteTextBox.Name = "rua_clienteTextBox";
            this.rua_clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.rua_clienteTextBox.TabIndex = 17;
            // 
            // numero_da_residencia_clienteTextBox
            // 
            this.numero_da_residencia_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "numero_da_residencia_cliente", true));
            this.numero_da_residencia_clienteTextBox.Location = new System.Drawing.Point(273, 363);
            this.numero_da_residencia_clienteTextBox.Name = "numero_da_residencia_clienteTextBox";
            this.numero_da_residencia_clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.numero_da_residencia_clienteTextBox.TabIndex = 19;
            // 
            // bairro_clienteTextBox
            // 
            this.bairro_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "bairro_cliente", true));
            this.bairro_clienteTextBox.Location = new System.Drawing.Point(273, 389);
            this.bairro_clienteTextBox.Name = "bairro_clienteTextBox";
            this.bairro_clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.bairro_clienteTextBox.TabIndex = 21;
            // 
            // cidade_clienteTextBox
            // 
            this.cidade_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cidade_cliente", true));
            this.cidade_clienteTextBox.Location = new System.Drawing.Point(273, 415);
            this.cidade_clienteTextBox.Name = "cidade_clienteTextBox";
            this.cidade_clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.cidade_clienteTextBox.TabIndex = 23;
            // 
            // estado_clienteTextBox
            // 
            this.estado_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "estado_cliente", true));
            this.estado_clienteTextBox.Location = new System.Drawing.Point(273, 441);
            this.estado_clienteTextBox.Name = "estado_clienteTextBox";
            this.estado_clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.estado_clienteTextBox.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Plum;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(140, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 62);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Cliente";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.avaliacaoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.estoqueTableAdapter = null;
            this.tableAdapterManager.eventosTableAdapter = null;
            this.tableAdapterManager.ingredientesTableAdapter = null;
            this.tableAdapterManager.item_pedidoTableAdapter = null;
            this.tableAdapterManager.pagamentoTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.receitaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // cepTextBox
            // 
            this.cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "cep", true));
            this.cepTextBox.Location = new System.Drawing.Point(273, 311);
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(200, 20);
            this.cepTextBox.TabIndex = 29;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(606, 481);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteTextBox);
            this.Controls.Add(nome_clienteLabel);
            this.Controls.Add(this.nome_clienteTextBox);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.cpfTextBox);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.cnpjTextBox);
            this.Controls.Add(celular_clienteLabel);
            this.Controls.Add(this.celular_clienteTextBox);
            this.Controls.Add(email_clienteLabel);
            this.Controls.Add(this.email_clienteTextBox);
            this.Controls.Add(data_nascimentoLabel);
            this.Controls.Add(this.data_nascimentoDateTimePicker);
            this.Controls.Add(rua_clienteLabel);
            this.Controls.Add(this.rua_clienteTextBox);
            this.Controls.Add(numero_da_residencia_clienteLabel);
            this.Controls.Add(this.numero_da_residencia_clienteTextBox);
            this.Controls.Add(bairro_clienteLabel);
            this.Controls.Add(this.bairro_clienteTextBox);
            this.Controls.Add(cidade_clienteLabel);
            this.Controls.Add(this.cidade_clienteTextBox);
            this.Controls.Add(estado_clienteLabel);
            this.Controls.Add(this.estado_clienteTextBox);
            this.Controls.Add(this.clienteBindingNavigator);
            this.Name = "frmCliente";
            this.Text = "Cadastro do Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingNavigator)).EndInit();
            this.clienteBindingNavigator.ResumeLayout(false);
            this.clienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenataDBDataSet renataDBDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private RenataDBDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clienteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_clienteTextBox;
        private System.Windows.Forms.TextBox nome_clienteTextBox;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.TextBox cnpjTextBox;
        private System.Windows.Forms.TextBox celular_clienteTextBox;
        private System.Windows.Forms.TextBox email_clienteTextBox;
        private System.Windows.Forms.DateTimePicker data_nascimentoDateTimePicker;
        private System.Windows.Forms.TextBox rua_clienteTextBox;
        private System.Windows.Forms.TextBox numero_da_residencia_clienteTextBox;
        private System.Windows.Forms.TextBox bairro_clienteTextBox;
        private System.Windows.Forms.TextBox cidade_clienteTextBox;
        private System.Windows.Forms.TextBox estado_clienteTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox cepTextBox;
    }
}