namespace Projeto_Integrador___pt2.Registros
{
    partial class frmFornecedor
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
            System.Windows.Forms.Label id_fornLabel;
            System.Windows.Forms.Label nome_fornLabel;
            System.Windows.Forms.Label cnpjLabel;
            System.Windows.Forms.Label celular_fornLabel;
            System.Windows.Forms.Label email_fornLabel;
            System.Windows.Forms.Label rua_fornLabel;
            System.Windows.Forms.Label num_resi_fornLabel;
            System.Windows.Forms.Label bairro_fornLabel;
            System.Windows.Forms.Label cidade_fornLabel;
            System.Windows.Forms.Label estado_fornLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedor));
            this.renataDBDataSet = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.fornecedoresTableAdapter();
            this.tableAdapterManager = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.fornecedoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fornecedoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_fornTextBox = new System.Windows.Forms.TextBox();
            this.nome_fornTextBox = new System.Windows.Forms.TextBox();
            this.cnpjTextBox = new System.Windows.Forms.TextBox();
            this.celular_fornTextBox = new System.Windows.Forms.TextBox();
            this.email_fornTextBox = new System.Windows.Forms.TextBox();
            this.rua_fornTextBox = new System.Windows.Forms.TextBox();
            this.num_resi_fornTextBox = new System.Windows.Forms.TextBox();
            this.bairro_fornTextBox = new System.Windows.Forms.TextBox();
            this.cidade_fornTextBox = new System.Windows.Forms.TextBox();
            this.estado_fornTextBox = new System.Windows.Forms.TextBox();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Visualizr = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            id_fornLabel = new System.Windows.Forms.Label();
            nome_fornLabel = new System.Windows.Forms.Label();
            cnpjLabel = new System.Windows.Forms.Label();
            celular_fornLabel = new System.Windows.Forms.Label();
            email_fornLabel = new System.Windows.Forms.Label();
            rua_fornLabel = new System.Windows.Forms.Label();
            num_resi_fornLabel = new System.Windows.Forms.Label();
            bairro_fornLabel = new System.Windows.Forms.Label();
            cidade_fornLabel = new System.Windows.Forms.Label();
            estado_fornLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingNavigator)).BeginInit();
            this.fornecedoresBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_fornLabel
            // 
            id_fornLabel.AutoSize = true;
            id_fornLabel.Location = new System.Drawing.Point(221, 143);
            id_fornLabel.Name = "id_fornLabel";
            id_fornLabel.Size = new System.Drawing.Size(43, 13);
            id_fornLabel.TabIndex = 1;
            id_fornLabel.Text = "Código:";
            // 
            // nome_fornLabel
            // 
            nome_fornLabel.AutoSize = true;
            nome_fornLabel.Location = new System.Drawing.Point(221, 169);
            nome_fornLabel.Name = "nome_fornLabel";
            nome_fornLabel.Size = new System.Drawing.Size(64, 13);
            nome_fornLabel.TabIndex = 3;
            nome_fornLabel.Text = "Fornecedor:";
            // 
            // cnpjLabel
            // 
            cnpjLabel.AutoSize = true;
            cnpjLabel.Location = new System.Drawing.Point(221, 195);
            cnpjLabel.Name = "cnpjLabel";
            cnpjLabel.Size = new System.Drawing.Size(37, 13);
            cnpjLabel.TabIndex = 5;
            cnpjLabel.Text = "CNPJ:";
            // 
            // celular_fornLabel
            // 
            celular_fornLabel.AutoSize = true;
            celular_fornLabel.Location = new System.Drawing.Point(221, 221);
            celular_fornLabel.Name = "celular_fornLabel";
            celular_fornLabel.Size = new System.Drawing.Size(42, 13);
            celular_fornLabel.TabIndex = 7;
            celular_fornLabel.Text = "Celular:";
            // 
            // email_fornLabel
            // 
            email_fornLabel.AutoSize = true;
            email_fornLabel.Location = new System.Drawing.Point(221, 247);
            email_fornLabel.Name = "email_fornLabel";
            email_fornLabel.Size = new System.Drawing.Size(35, 13);
            email_fornLabel.TabIndex = 9;
            email_fornLabel.Text = "Email:";
            // 
            // rua_fornLabel
            // 
            rua_fornLabel.AutoSize = true;
            rua_fornLabel.Location = new System.Drawing.Point(221, 273);
            rua_fornLabel.Name = "rua_fornLabel";
            rua_fornLabel.Size = new System.Drawing.Size(30, 13);
            rua_fornLabel.TabIndex = 11;
            rua_fornLabel.Text = "Rua:";
            // 
            // num_resi_fornLabel
            // 
            num_resi_fornLabel.AutoSize = true;
            num_resi_fornLabel.Location = new System.Drawing.Point(221, 299);
            num_resi_fornLabel.Name = "num_resi_fornLabel";
            num_resi_fornLabel.Size = new System.Drawing.Size(113, 13);
            num_resi_fornLabel.TabIndex = 13;
            num_resi_fornLabel.Text = "Número de residência:";
            // 
            // bairro_fornLabel
            // 
            bairro_fornLabel.AutoSize = true;
            bairro_fornLabel.Location = new System.Drawing.Point(221, 325);
            bairro_fornLabel.Name = "bairro_fornLabel";
            bairro_fornLabel.Size = new System.Drawing.Size(37, 13);
            bairro_fornLabel.TabIndex = 15;
            bairro_fornLabel.Text = "Bairro:";
            // 
            // cidade_fornLabel
            // 
            cidade_fornLabel.AutoSize = true;
            cidade_fornLabel.Location = new System.Drawing.Point(221, 351);
            cidade_fornLabel.Name = "cidade_fornLabel";
            cidade_fornLabel.Size = new System.Drawing.Size(43, 13);
            cidade_fornLabel.TabIndex = 17;
            cidade_fornLabel.Text = "Cidade:";
            // 
            // estado_fornLabel
            // 
            estado_fornLabel.AutoSize = true;
            estado_fornLabel.Location = new System.Drawing.Point(221, 377);
            estado_fornLabel.Name = "estado_fornLabel";
            estado_fornLabel.Size = new System.Drawing.Size(43, 13);
            estado_fornLabel.TabIndex = 19;
            estado_fornLabel.Text = "Estado:";
            // 
            // renataDBDataSet
            // 
            this.renataDBDataSet.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "fornecedores";
            this.fornecedoresBindingSource.DataSource = this.renataDBDataSet;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.avaliacaoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.categoriaTableAdapter = null;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.estoqueTableAdapter = null;
            this.tableAdapterManager.eventosTableAdapter = null;
            this.tableAdapterManager.fornecedoresTableAdapter = this.fornecedoresTableAdapter;
            this.tableAdapterManager.ingredientesTableAdapter = null;
            this.tableAdapterManager.item_pedidoTableAdapter = null;
            this.tableAdapterManager.pagamentoTableAdapter = null;
            this.tableAdapterManager.pedidoTableAdapter = null;
            this.tableAdapterManager.produtoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // fornecedoresBindingNavigator
            // 
            this.fornecedoresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fornecedoresBindingNavigator.BindingSource = this.fornecedoresBindingSource;
            this.fornecedoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fornecedoresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fornecedoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fornecedoresBindingNavigatorSaveItem});
            this.fornecedoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fornecedoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fornecedoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fornecedoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fornecedoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fornecedoresBindingNavigator.Name = "fornecedoresBindingNavigator";
            this.fornecedoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fornecedoresBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.fornecedoresBindingNavigator.TabIndex = 0;
            this.fornecedoresBindingNavigator.Text = "bindingNavigator1";
            this.fornecedoresBindingNavigator.Visible = false;
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
            // fornecedoresBindingNavigatorSaveItem
            // 
            this.fornecedoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fornecedoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fornecedoresBindingNavigatorSaveItem.Image")));
            this.fornecedoresBindingNavigatorSaveItem.Name = "fornecedoresBindingNavigatorSaveItem";
            this.fornecedoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fornecedoresBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.fornecedoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.fornecedoresBindingNavigatorSaveItem_Click);
            // 
            // id_fornTextBox
            // 
            this.id_fornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "id_forn", true));
            this.id_fornTextBox.Location = new System.Drawing.Point(334, 140);
            this.id_fornTextBox.Name = "id_fornTextBox";
            this.id_fornTextBox.Size = new System.Drawing.Size(192, 20);
            this.id_fornTextBox.TabIndex = 2;
            // 
            // nome_fornTextBox
            // 
            this.nome_fornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "nome_forn", true));
            this.nome_fornTextBox.Location = new System.Drawing.Point(334, 166);
            this.nome_fornTextBox.Name = "nome_fornTextBox";
            this.nome_fornTextBox.Size = new System.Drawing.Size(192, 20);
            this.nome_fornTextBox.TabIndex = 4;
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "cnpj", true));
            this.cnpjTextBox.Location = new System.Drawing.Point(334, 192);
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(192, 20);
            this.cnpjTextBox.TabIndex = 6;
            // 
            // celular_fornTextBox
            // 
            this.celular_fornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "celular_forn", true));
            this.celular_fornTextBox.Location = new System.Drawing.Point(334, 218);
            this.celular_fornTextBox.Name = "celular_fornTextBox";
            this.celular_fornTextBox.Size = new System.Drawing.Size(192, 20);
            this.celular_fornTextBox.TabIndex = 8;
            // 
            // email_fornTextBox
            // 
            this.email_fornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "email_forn", true));
            this.email_fornTextBox.Location = new System.Drawing.Point(334, 244);
            this.email_fornTextBox.Name = "email_fornTextBox";
            this.email_fornTextBox.Size = new System.Drawing.Size(192, 20);
            this.email_fornTextBox.TabIndex = 10;
            // 
            // rua_fornTextBox
            // 
            this.rua_fornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "rua_forn", true));
            this.rua_fornTextBox.Location = new System.Drawing.Point(334, 270);
            this.rua_fornTextBox.Name = "rua_fornTextBox";
            this.rua_fornTextBox.Size = new System.Drawing.Size(192, 20);
            this.rua_fornTextBox.TabIndex = 12;
            // 
            // num_resi_fornTextBox
            // 
            this.num_resi_fornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "num_resi_forn", true));
            this.num_resi_fornTextBox.Location = new System.Drawing.Point(334, 296);
            this.num_resi_fornTextBox.Name = "num_resi_fornTextBox";
            this.num_resi_fornTextBox.Size = new System.Drawing.Size(192, 20);
            this.num_resi_fornTextBox.TabIndex = 14;
            // 
            // bairro_fornTextBox
            // 
            this.bairro_fornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "bairro_forn", true));
            this.bairro_fornTextBox.Location = new System.Drawing.Point(334, 322);
            this.bairro_fornTextBox.Name = "bairro_fornTextBox";
            this.bairro_fornTextBox.Size = new System.Drawing.Size(192, 20);
            this.bairro_fornTextBox.TabIndex = 16;
            // 
            // cidade_fornTextBox
            // 
            this.cidade_fornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "cidade_forn", true));
            this.cidade_fornTextBox.Location = new System.Drawing.Point(334, 348);
            this.cidade_fornTextBox.Name = "cidade_fornTextBox";
            this.cidade_fornTextBox.Size = new System.Drawing.Size(192, 20);
            this.cidade_fornTextBox.TabIndex = 18;
            // 
            // estado_fornTextBox
            // 
            this.estado_fornTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "estado_forn", true));
            this.estado_fornTextBox.Location = new System.Drawing.Point(334, 374);
            this.estado_fornTextBox.Name = "estado_fornTextBox";
            this.estado_fornTextBox.Size = new System.Drawing.Size(192, 20);
            this.estado_fornTextBox.TabIndex = 20;
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.Location = new System.Drawing.Point(195, 95);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Incluir.TabIndex = 21;
            this.btn_Incluir.Text = "Incluir";
            this.btn_Incluir.UseVisualStyleBackColor = true;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(288, 95);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 22;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(380, 95);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 23;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Visualizr
            // 
            this.btn_Visualizr.Location = new System.Drawing.Point(474, 95);
            this.btn_Visualizr.Name = "btn_Visualizr";
            this.btn_Visualizr.Size = new System.Drawing.Size(75, 23);
            this.btn_Visualizr.TabIndex = 24;
            this.btn_Visualizr.Text = "Visualizar";
            this.btn_Visualizr.UseVisualStyleBackColor = true;
            this.btn_Visualizr.Click += new System.EventHandler(this.btn_Visualizr_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Plum;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(800, 47);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "Cadastro de fornecedor";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_Visualizr);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Incluir);
            this.Controls.Add(id_fornLabel);
            this.Controls.Add(this.id_fornTextBox);
            this.Controls.Add(nome_fornLabel);
            this.Controls.Add(this.nome_fornTextBox);
            this.Controls.Add(cnpjLabel);
            this.Controls.Add(this.cnpjTextBox);
            this.Controls.Add(celular_fornLabel);
            this.Controls.Add(this.celular_fornTextBox);
            this.Controls.Add(email_fornLabel);
            this.Controls.Add(this.email_fornTextBox);
            this.Controls.Add(rua_fornLabel);
            this.Controls.Add(this.rua_fornTextBox);
            this.Controls.Add(num_resi_fornLabel);
            this.Controls.Add(this.num_resi_fornTextBox);
            this.Controls.Add(bairro_fornLabel);
            this.Controls.Add(this.bairro_fornTextBox);
            this.Controls.Add(cidade_fornLabel);
            this.Controls.Add(this.cidade_fornTextBox);
            this.Controls.Add(estado_fornLabel);
            this.Controls.Add(this.estado_fornTextBox);
            this.Controls.Add(this.fornecedoresBindingNavigator);
            this.Name = "frmFornecedor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingNavigator)).EndInit();
            this.fornecedoresBindingNavigator.ResumeLayout(false);
            this.fornecedoresBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenataDBDataSet renataDBDataSet;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private RenataDBDataSetTableAdapters.fornecedoresTableAdapter fornecedoresTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fornecedoresBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fornecedoresBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_fornTextBox;
        private System.Windows.Forms.TextBox nome_fornTextBox;
        private System.Windows.Forms.TextBox cnpjTextBox;
        private System.Windows.Forms.TextBox celular_fornTextBox;
        private System.Windows.Forms.TextBox email_fornTextBox;
        private System.Windows.Forms.TextBox rua_fornTextBox;
        private System.Windows.Forms.TextBox num_resi_fornTextBox;
        private System.Windows.Forms.TextBox bairro_fornTextBox;
        private System.Windows.Forms.TextBox cidade_fornTextBox;
        private System.Windows.Forms.TextBox estado_fornTextBox;
        private System.Windows.Forms.Button btn_Incluir;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Visualizr;
        private System.Windows.Forms.TextBox textBox2;
    }
}