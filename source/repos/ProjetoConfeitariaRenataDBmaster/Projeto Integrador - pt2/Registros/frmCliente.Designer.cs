namespace Projeto_Integrador___pt2.Registros
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
            this.renataDBDataSet1 = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter1 = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.clienteTableAdapter();
            this.tableAdapterManager1 = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.clienteBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.clienteBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_clienteTextBox1 = new System.Windows.Forms.TextBox();
            this.nome_clienteTextBox1 = new System.Windows.Forms.TextBox();
            this.cpfTextBox1 = new System.Windows.Forms.TextBox();
            this.cnpjTextBox1 = new System.Windows.Forms.TextBox();
            this.celular_clienteTextBox1 = new System.Windows.Forms.TextBox();
            this.email_clienteTextBox1 = new System.Windows.Forms.TextBox();
            this.data_nascimentoDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rua_clienteTextBox1 = new System.Windows.Forms.TextBox();
            this.numero_da_residencia_clienteTextBox1 = new System.Windows.Forms.TextBox();
            this.bairro_clienteTextBox1 = new System.Windows.Forms.TextBox();
            this.cidade_clienteTextBox1 = new System.Windows.Forms.TextBox();
            this.estado_clienteTextBox1 = new System.Windows.Forms.TextBox();
            this.cepTextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1BindingNavigator)).BeginInit();
            this.clienteBindingSource1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(133, 104);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(43, 13);
            id_clienteLabel.TabIndex = 1;
            id_clienteLabel.Text = "Código:";
            // 
            // nome_clienteLabel
            // 
            nome_clienteLabel.AutoSize = true;
            nome_clienteLabel.Location = new System.Drawing.Point(133, 130);
            nome_clienteLabel.Name = "nome_clienteLabel";
            nome_clienteLabel.Size = new System.Drawing.Size(42, 13);
            nome_clienteLabel.TabIndex = 3;
            nome_clienteLabel.Text = "Cliente:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(133, 156);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(30, 13);
            cpfLabel.TabIndex = 5;
            cpfLabel.Text = "CPF:";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(133, 182);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(37, 13);
            cnpjLabel.TabIndex = 7;
            cnpjLabel.Text = "CNPJ:";
            // 
            // celular_clienteLabel
            // 
            celular_clienteLabel.AutoSize = true;
            celular_clienteLabel.Location = new System.Drawing.Point(133, 208);
            celular_clienteLabel.Name = "celular_clienteLabel";
            celular_clienteLabel.Size = new System.Drawing.Size(42, 13);
            celular_clienteLabel.TabIndex = 9;
            celular_clienteLabel.Text = "Celular:";
            // 
            // email_clienteLabel
            // 
            email_clienteLabel.AutoSize = true;
            email_clienteLabel.Location = new System.Drawing.Point(133, 234);
            email_clienteLabel.Name = "email_clienteLabel";
            email_clienteLabel.Size = new System.Drawing.Size(35, 13);
            email_clienteLabel.TabIndex = 11;
            email_clienteLabel.Text = "Email:";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Location = new System.Drawing.Point(133, 261);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(105, 13);
            data_nascimentoLabel.TabIndex = 13;
            data_nascimentoLabel.Text = "Data de nascimento:";
            // 
            // rua_clienteLabel
            // 
            rua_clienteLabel.AutoSize = true;
            rua_clienteLabel.Location = new System.Drawing.Point(133, 286);
            rua_clienteLabel.Name = "rua_clienteLabel";
            rua_clienteLabel.Size = new System.Drawing.Size(30, 13);
            rua_clienteLabel.TabIndex = 15;
            rua_clienteLabel.Text = "Rua:";
            // 
            // numero_da_residencia_clienteLabel
            // 
            numero_da_residencia_clienteLabel.AutoSize = true;
            numero_da_residencia_clienteLabel.Location = new System.Drawing.Point(133, 312);
            numero_da_residencia_clienteLabel.Name = "numero_da_residencia_clienteLabel";
            numero_da_residencia_clienteLabel.Size = new System.Drawing.Size(113, 13);
            numero_da_residencia_clienteLabel.TabIndex = 17;
            numero_da_residencia_clienteLabel.Text = "Número da residencia:";
            // 
            // bairro_clienteLabel
            // 
            bairro_clienteLabel.AutoSize = true;
            bairro_clienteLabel.Location = new System.Drawing.Point(133, 338);
            bairro_clienteLabel.Name = "bairro_clienteLabel";
            bairro_clienteLabel.Size = new System.Drawing.Size(37, 13);
            bairro_clienteLabel.TabIndex = 19;
            bairro_clienteLabel.Text = "Bairro:";
            // 
            // cidade_clienteLabel
            // 
            cidade_clienteLabel.AutoSize = true;
            cidade_clienteLabel.Location = new System.Drawing.Point(133, 364);
            cidade_clienteLabel.Name = "cidade_clienteLabel";
            cidade_clienteLabel.Size = new System.Drawing.Size(43, 13);
            cidade_clienteLabel.TabIndex = 21;
            cidade_clienteLabel.Text = "Cidade:";
            // 
            // estado_clienteLabel
            // 
            estado_clienteLabel.AutoSize = true;
            estado_clienteLabel.Location = new System.Drawing.Point(133, 390);
            estado_clienteLabel.Name = "estado_clienteLabel";
            estado_clienteLabel.Size = new System.Drawing.Size(43, 13);
            estado_clienteLabel.TabIndex = 23;
            estado_clienteLabel.Text = "Estado:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(133, 416);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(31, 13);
            cepLabel.TabIndex = 25;
            cepLabel.Text = "CEP:";
            // 
            // renataDBDataSet1
            // 
            this.renataDBDataSet1.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "cliente";
            this.clienteBindingSource1.DataSource = this.renataDBDataSet1;
            // 
            // clienteTableAdapter1
            // 
            this.clienteTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.avaliacaoTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.categoriaTableAdapter = null;
            this.tableAdapterManager1.clienteTableAdapter = this.clienteTableAdapter1;
            this.tableAdapterManager1.estoqueTableAdapter = null;
            this.tableAdapterManager1.eventosTableAdapter = null;
            this.tableAdapterManager1.fornecedoresTableAdapter = null;
            this.tableAdapterManager1.ingredientesTableAdapter = null;
            this.tableAdapterManager1.item_pedidoTableAdapter = null;
            this.tableAdapterManager1.pagamentoTableAdapter = null;
            this.tableAdapterManager1.pedidoTableAdapter = null;
            this.tableAdapterManager1.produtoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usuarioTableAdapter = null;
            // 
            // clienteBindingSource1BindingNavigator
            // 
            this.clienteBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.clienteBindingSource1BindingNavigator.BindingSource = this.clienteBindingSource1;
            this.clienteBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.clienteBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.clienteBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clienteBindingSource1BindingNavigatorSaveItem});
            this.clienteBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clienteBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.clienteBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.clienteBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.clienteBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.clienteBindingSource1BindingNavigator.Name = "clienteBindingSource1BindingNavigator";
            this.clienteBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.clienteBindingSource1BindingNavigator.Size = new System.Drawing.Size(671, 25);
            this.clienteBindingSource1BindingNavigator.TabIndex = 0;
            this.clienteBindingSource1BindingNavigator.Text = "bindingNavigator2";
            this.clienteBindingSource1BindingNavigator.Visible = false;
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
            // clienteBindingSource1BindingNavigatorSaveItem
            // 
            this.clienteBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clienteBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteBindingSource1BindingNavigatorSaveItem.Image")));
            this.clienteBindingSource1BindingNavigatorSaveItem.Name = "clienteBindingSource1BindingNavigatorSaveItem";
            this.clienteBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clienteBindingSource1BindingNavigatorSaveItem.Text = "Salvar Dados";
            this.clienteBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.clienteBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // id_clienteTextBox1
            // 
            this.id_clienteTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "id_cliente", true));
            this.id_clienteTextBox1.Location = new System.Drawing.Point(284, 101);
            this.id_clienteTextBox1.Name = "id_clienteTextBox1";
            this.id_clienteTextBox1.Size = new System.Drawing.Size(200, 20);
            this.id_clienteTextBox1.TabIndex = 2;
            // 
            // nome_clienteTextBox1
            // 
            this.nome_clienteTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "nome_cliente", true));
            this.nome_clienteTextBox1.Location = new System.Drawing.Point(284, 127);
            this.nome_clienteTextBox1.Name = "nome_clienteTextBox1";
            this.nome_clienteTextBox1.Size = new System.Drawing.Size(200, 20);
            this.nome_clienteTextBox1.TabIndex = 4;
            // 
            // cpfTextBox1
            // 
            this.cpfTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "cpf", true));
            this.cpfTextBox1.Location = new System.Drawing.Point(284, 153);
            this.cpfTextBox1.Name = "cpfTextBox1";
            this.cpfTextBox1.Size = new System.Drawing.Size(200, 20);
            this.cpfTextBox1.TabIndex = 6;
            // 
            // cnpjTextBox1
            // 
            this.cnpjTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "cnpj", true));
            this.cnpjTextBox1.Location = new System.Drawing.Point(284, 179);
            this.cnpjTextBox1.Name = "cnpjTextBox1";
            this.cnpjTextBox1.Size = new System.Drawing.Size(200, 20);
            this.cnpjTextBox1.TabIndex = 8;
            // 
            // celular_clienteTextBox1
            // 
            this.celular_clienteTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "celular_cliente", true));
            this.celular_clienteTextBox1.Location = new System.Drawing.Point(284, 205);
            this.celular_clienteTextBox1.Name = "celular_clienteTextBox1";
            this.celular_clienteTextBox1.Size = new System.Drawing.Size(200, 20);
            this.celular_clienteTextBox1.TabIndex = 10;
            // 
            // email_clienteTextBox1
            // 
            this.email_clienteTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "email_cliente", true));
            this.email_clienteTextBox1.Location = new System.Drawing.Point(284, 231);
            this.email_clienteTextBox1.Name = "email_clienteTextBox1";
            this.email_clienteTextBox1.Size = new System.Drawing.Size(200, 20);
            this.email_clienteTextBox1.TabIndex = 12;
            // 
            // data_nascimentoDateTimePicker1
            // 
            this.data_nascimentoDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clienteBindingSource1, "data_nascimento", true));
            this.data_nascimentoDateTimePicker1.Location = new System.Drawing.Point(284, 257);
            this.data_nascimentoDateTimePicker1.Name = "data_nascimentoDateTimePicker1";
            this.data_nascimentoDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.data_nascimentoDateTimePicker1.TabIndex = 14;
            // 
            // rua_clienteTextBox1
            // 
            this.rua_clienteTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "rua_cliente", true));
            this.rua_clienteTextBox1.Location = new System.Drawing.Point(284, 283);
            this.rua_clienteTextBox1.Name = "rua_clienteTextBox1";
            this.rua_clienteTextBox1.Size = new System.Drawing.Size(200, 20);
            this.rua_clienteTextBox1.TabIndex = 16;
            // 
            // numero_da_residencia_clienteTextBox1
            // 
            this.numero_da_residencia_clienteTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "numero_da_residencia_cliente", true));
            this.numero_da_residencia_clienteTextBox1.Location = new System.Drawing.Point(284, 309);
            this.numero_da_residencia_clienteTextBox1.Name = "numero_da_residencia_clienteTextBox1";
            this.numero_da_residencia_clienteTextBox1.Size = new System.Drawing.Size(200, 20);
            this.numero_da_residencia_clienteTextBox1.TabIndex = 18;
            // 
            // bairro_clienteTextBox1
            // 
            this.bairro_clienteTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "bairro_cliente", true));
            this.bairro_clienteTextBox1.Location = new System.Drawing.Point(284, 335);
            this.bairro_clienteTextBox1.Name = "bairro_clienteTextBox1";
            this.bairro_clienteTextBox1.Size = new System.Drawing.Size(200, 20);
            this.bairro_clienteTextBox1.TabIndex = 20;
            // 
            // cidade_clienteTextBox1
            // 
            this.cidade_clienteTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "cidade_cliente", true));
            this.cidade_clienteTextBox1.Location = new System.Drawing.Point(284, 361);
            this.cidade_clienteTextBox1.Name = "cidade_clienteTextBox1";
            this.cidade_clienteTextBox1.Size = new System.Drawing.Size(200, 20);
            this.cidade_clienteTextBox1.TabIndex = 22;
            // 
            // estado_clienteTextBox1
            // 
            this.estado_clienteTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "estado_cliente", true));
            this.estado_clienteTextBox1.Location = new System.Drawing.Point(284, 387);
            this.estado_clienteTextBox1.Name = "estado_clienteTextBox1";
            this.estado_clienteTextBox1.Size = new System.Drawing.Size(200, 20);
            this.estado_clienteTextBox1.TabIndex = 24;
            // 
            // cepTextBox1
            // 
            this.cepTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource1, "cep", true));
            this.cepTextBox1.Location = new System.Drawing.Point(284, 413);
            this.cepTextBox1.Name = "cepTextBox1";
            this.cepTextBox1.Size = new System.Drawing.Size(200, 20);
            this.cepTextBox1.TabIndex = 26;
            this.cepTextBox1.TextChanged += new System.EventHandler(this.cepTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(321, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(418, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Visualizar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Plum;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(671, 47);
            this.textBox2.TabIndex = 31;
            this.textBox2.Text = "Cadastro de clientes";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCliente
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(671, 460);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteTextBox1);
            this.Controls.Add(nome_clienteLabel);
            this.Controls.Add(this.nome_clienteTextBox1);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.cpfTextBox1);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.cnpjTextBox1);
            this.Controls.Add(celular_clienteLabel);
            this.Controls.Add(this.celular_clienteTextBox1);
            this.Controls.Add(email_clienteLabel);
            this.Controls.Add(this.email_clienteTextBox1);
            this.Controls.Add(data_nascimentoLabel);
            this.Controls.Add(this.data_nascimentoDateTimePicker1);
            this.Controls.Add(rua_clienteLabel);
            this.Controls.Add(this.rua_clienteTextBox1);
            this.Controls.Add(numero_da_residencia_clienteLabel);
            this.Controls.Add(this.numero_da_residencia_clienteTextBox1);
            this.Controls.Add(bairro_clienteLabel);
            this.Controls.Add(this.bairro_clienteTextBox1);
            this.Controls.Add(cidade_clienteLabel);
            this.Controls.Add(this.cidade_clienteTextBox1);
            this.Controls.Add(estado_clienteLabel);
            this.Controls.Add(this.estado_clienteTextBox1);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepTextBox1);
            this.Controls.Add(this.clienteBindingSource1BindingNavigator);
            this.Name = "frmCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCliente_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1BindingNavigator)).EndInit();
            this.clienteBindingSource1BindingNavigator.ResumeLayout(false);
            this.clienteBindingSource1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        
        private RenataDBDataSet renataDBDataSet1;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private RenataDBDataSetTableAdapters.clienteTableAdapter clienteTableAdapter1;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator clienteBindingSource1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clienteBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_clienteTextBox1;
        private System.Windows.Forms.TextBox nome_clienteTextBox1;
        private System.Windows.Forms.TextBox cpfTextBox1;
        private System.Windows.Forms.TextBox cnpjTextBox1;
        private System.Windows.Forms.TextBox celular_clienteTextBox1;
        private System.Windows.Forms.TextBox email_clienteTextBox1;
        private System.Windows.Forms.DateTimePicker data_nascimentoDateTimePicker1;
        private System.Windows.Forms.TextBox rua_clienteTextBox1;
        private System.Windows.Forms.TextBox numero_da_residencia_clienteTextBox1;
        private System.Windows.Forms.TextBox bairro_clienteTextBox1;
        private System.Windows.Forms.TextBox cidade_clienteTextBox1;
        private System.Windows.Forms.TextBox estado_clienteTextBox1;
        private System.Windows.Forms.TextBox cepTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
    }
}