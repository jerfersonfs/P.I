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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.renataDBDataSet1 = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter1 = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.usuarioTableAdapter();
            this.tableAdapterManager1 = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.usuarioBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.usuarioBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_usuTextBox1 = new System.Windows.Forms.TextBox();
            this.nome_usuTextBox1 = new System.Windows.Forms.TextBox();
            this.senha_usuTextBox1 = new System.Windows.Forms.TextBox();
            this.celular_usuTextBox1 = new System.Windows.Forms.TextBox();
            this.telefone_usuTextBox1 = new System.Windows.Forms.TextBox();
            this.email_usuTextBox1 = new System.Windows.Forms.TextBox();
            this.data_cadastroDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            id_usuLabel = new System.Windows.Forms.Label();
            nome_usuLabel = new System.Windows.Forms.Label();
            senha_usuLabel = new System.Windows.Forms.Label();
            celular_usuLabel = new System.Windows.Forms.Label();
            telefone_usuLabel = new System.Windows.Forms.Label();
            email_usuLabel = new System.Windows.Forms.Label();
            data_cadastroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1BindingNavigator)).BeginInit();
            this.usuarioBindingSource1BindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_usuLabel
            // 
            id_usuLabel.AutoSize = true;
            id_usuLabel.Location = new System.Drawing.Point(156, 169);
            id_usuLabel.Name = "id_usuLabel";
            id_usuLabel.Size = new System.Drawing.Size(43, 13);
            id_usuLabel.TabIndex = 1;
            id_usuLabel.Text = "Código:";
            // 
            // nome_usuLabel
            // 
            nome_usuLabel.AutoSize = true;
            nome_usuLabel.Location = new System.Drawing.Point(156, 195);
            nome_usuLabel.Name = "nome_usuLabel";
            nome_usuLabel.Size = new System.Drawing.Size(46, 13);
            nome_usuLabel.TabIndex = 3;
            nome_usuLabel.Text = "Usuário:";
            // 
            // senha_usuLabel
            // 
            senha_usuLabel.AutoSize = true;
            senha_usuLabel.Location = new System.Drawing.Point(156, 221);
            senha_usuLabel.Name = "senha_usuLabel";
            senha_usuLabel.Size = new System.Drawing.Size(41, 13);
            senha_usuLabel.TabIndex = 5;
            senha_usuLabel.Text = "Senha:";
            // 
            // celular_usuLabel
            // 
            celular_usuLabel.AutoSize = true;
            celular_usuLabel.Location = new System.Drawing.Point(156, 247);
            celular_usuLabel.Name = "celular_usuLabel";
            celular_usuLabel.Size = new System.Drawing.Size(42, 13);
            celular_usuLabel.TabIndex = 7;
            celular_usuLabel.Text = "Celular:";
            // 
            // telefone_usuLabel
            // 
            telefone_usuLabel.AutoSize = true;
            telefone_usuLabel.Location = new System.Drawing.Point(156, 273);
            telefone_usuLabel.Name = "telefone_usuLabel";
            telefone_usuLabel.Size = new System.Drawing.Size(52, 13);
            telefone_usuLabel.TabIndex = 9;
            telefone_usuLabel.Text = "Telefone:";
            // 
            // email_usuLabel
            // 
            email_usuLabel.AutoSize = true;
            email_usuLabel.Location = new System.Drawing.Point(156, 299);
            email_usuLabel.Name = "email_usuLabel";
            email_usuLabel.Size = new System.Drawing.Size(35, 13);
            email_usuLabel.TabIndex = 11;
            email_usuLabel.Text = "Email:";
            // 
            // data_cadastroLabel
            // 
            data_cadastroLabel.AutoSize = true;
            data_cadastroLabel.Location = new System.Drawing.Point(406, 16);
            data_cadastroLabel.Name = "data_cadastroLabel";
            data_cadastroLabel.Size = new System.Drawing.Size(92, 13);
            data_cadastroLabel.TabIndex = 13;
            data_cadastroLabel.Text = "Data de cadastro:";
            // 
            // renataDBDataSet1
            // 
            this.renataDBDataSet1.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "usuario";
            this.usuarioBindingSource1.DataSource = this.renataDBDataSet1;
            // 
            // usuarioTableAdapter1
            // 
            this.usuarioTableAdapter1.ClearBeforeFill = true;
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
            this.tableAdapterManager1.produtoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usuarioTableAdapter = this.usuarioTableAdapter1;
            // 
            // usuarioBindingSource1BindingNavigator
            // 
            this.usuarioBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.usuarioBindingSource1BindingNavigator.BindingSource = this.usuarioBindingSource1;
            this.usuarioBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.usuarioBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.usuarioBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.usuarioBindingSource1BindingNavigatorSaveItem});
            this.usuarioBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuarioBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.usuarioBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.usuarioBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.usuarioBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.usuarioBindingSource1BindingNavigator.Name = "usuarioBindingSource1BindingNavigator";
            this.usuarioBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.usuarioBindingSource1BindingNavigator.Size = new System.Drawing.Size(763, 25);
            this.usuarioBindingSource1BindingNavigator.TabIndex = 0;
            this.usuarioBindingSource1BindingNavigator.Text = "bindingNavigator1";
            this.usuarioBindingSource1BindingNavigator.Visible = false;
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
            // usuarioBindingSource1BindingNavigatorSaveItem
            // 
            this.usuarioBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usuarioBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioBindingSource1BindingNavigatorSaveItem.Image")));
            this.usuarioBindingSource1BindingNavigatorSaveItem.Name = "usuarioBindingSource1BindingNavigatorSaveItem";
            this.usuarioBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usuarioBindingSource1BindingNavigatorSaveItem.Text = "Salvar Dados";
            this.usuarioBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.usuarioBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // id_usuTextBox1
            // 
            this.id_usuTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource1, "id_usu", true));
            this.id_usuTextBox1.Location = new System.Drawing.Point(237, 166);
            this.id_usuTextBox1.Name = "id_usuTextBox1";
            this.id_usuTextBox1.Size = new System.Drawing.Size(200, 20);
            this.id_usuTextBox1.TabIndex = 2;
            // 
            // nome_usuTextBox1
            // 
            this.nome_usuTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource1, "nome_usu", true));
            this.nome_usuTextBox1.Location = new System.Drawing.Point(237, 192);
            this.nome_usuTextBox1.Name = "nome_usuTextBox1";
            this.nome_usuTextBox1.Size = new System.Drawing.Size(200, 20);
            this.nome_usuTextBox1.TabIndex = 4;
            // 
            // senha_usuTextBox1
            // 
            this.senha_usuTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource1, "senha_usu", true));
            this.senha_usuTextBox1.Location = new System.Drawing.Point(237, 218);
            this.senha_usuTextBox1.Name = "senha_usuTextBox1";
            this.senha_usuTextBox1.Size = new System.Drawing.Size(200, 20);
            this.senha_usuTextBox1.TabIndex = 6;
            // 
            // celular_usuTextBox1
            // 
            this.celular_usuTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource1, "celular_usu", true));
            this.celular_usuTextBox1.Location = new System.Drawing.Point(237, 244);
            this.celular_usuTextBox1.Name = "celular_usuTextBox1";
            this.celular_usuTextBox1.Size = new System.Drawing.Size(200, 20);
            this.celular_usuTextBox1.TabIndex = 8;
            // 
            // telefone_usuTextBox1
            // 
            this.telefone_usuTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource1, "telefone_usu", true));
            this.telefone_usuTextBox1.Location = new System.Drawing.Point(237, 270);
            this.telefone_usuTextBox1.Name = "telefone_usuTextBox1";
            this.telefone_usuTextBox1.Size = new System.Drawing.Size(200, 20);
            this.telefone_usuTextBox1.TabIndex = 10;
            // 
            // email_usuTextBox1
            // 
            this.email_usuTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource1, "email_usu", true));
            this.email_usuTextBox1.Location = new System.Drawing.Point(237, 296);
            this.email_usuTextBox1.Name = "email_usuTextBox1";
            this.email_usuTextBox1.Size = new System.Drawing.Size(200, 20);
            this.email_usuTextBox1.TabIndex = 12;
            // 
            // data_cadastroDateTimePicker1
            // 
            this.data_cadastroDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuarioBindingSource1, "data_cadastro", true));
            this.data_cadastroDateTimePicker1.Location = new System.Drawing.Point(205, 78);
            this.data_cadastroDateTimePicker1.Name = "data_cadastroDateTimePicker1";
            this.data_cadastroDateTimePicker1.Size = new System.Drawing.Size(232, 20);
            this.data_cadastroDateTimePicker1.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Incluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(309, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Salvar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(404, 127);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Visualizar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(id_usuLabel);
            this.groupBox2.Controls.Add(data_cadastroLabel);
            this.groupBox2.Controls.Add(this.data_cadastroDateTimePicker1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.id_usuTextBox1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(nome_usuLabel);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.nome_usuTextBox1);
            this.groupBox2.Controls.Add(this.celular_usuTextBox1);
            this.groupBox2.Controls.Add(senha_usuLabel);
            this.groupBox2.Controls.Add(this.email_usuTextBox1);
            this.groupBox2.Controls.Add(this.senha_usuTextBox1);
            this.groupBox2.Controls.Add(email_usuLabel);
            this.groupBox2.Controls.Add(celular_usuLabel);
            this.groupBox2.Controls.Add(this.telefone_usuTextBox1);
            this.groupBox2.Controls.Add(telefone_usuLabel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 372);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Plum;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(647, 47);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "Cadastro de usuário";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmUsuario
            // 
            this.ClientSize = new System.Drawing.Size(647, 372);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.usuarioBindingSource1BindingNavigator);
            this.Name = "frmUsuario";
            this.ShowIcon = false;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmUsuario_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1BindingNavigator)).EndInit();
            this.usuarioBindingSource1BindingNavigator.ResumeLayout(false);
            this.usuarioBindingSource1BindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenataDBDataSet renataDBDataSet1;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
        private RenataDBDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter1;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator usuarioBindingSource1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton usuarioBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_usuTextBox1;
        private System.Windows.Forms.TextBox nome_usuTextBox1;
        private System.Windows.Forms.TextBox senha_usuTextBox1;
        private System.Windows.Forms.TextBox celular_usuTextBox1;
        private System.Windows.Forms.TextBox telefone_usuTextBox1;
        private System.Windows.Forms.TextBox email_usuTextBox1;
        private System.Windows.Forms.DateTimePicker data_cadastroDateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
    }
}