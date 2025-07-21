namespace Projeto_Integrador___pt2.Formulários
{
    partial class frmEstoque
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
            System.Windows.Forms.Label id_estoqueLabel;
            System.Windows.Forms.Label fKid_ingredienteLabel;
            System.Windows.Forms.Label data_movimentacaoLabel;
            System.Windows.Forms.Label quantidade_movimentadaLabel;
            System.Windows.Forms.Label tipo_movimentacaoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.renataDBDataSet1 = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.estoqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estoqueTableAdapter1 = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.estoqueTableAdapter();
            this.tableAdapterManager1 = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.estoqueBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.estoqueBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_estoqueTextBox1 = new System.Windows.Forms.TextBox();
            this.fKid_ingredienteTextBox1 = new System.Windows.Forms.TextBox();
            this.data_movimentacaoDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.quantidade_movimentadaTextBox1 = new System.Windows.Forms.TextBox();
            this.tipo_movimentacaoTextBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            id_estoqueLabel = new System.Windows.Forms.Label();
            fKid_ingredienteLabel = new System.Windows.Forms.Label();
            data_movimentacaoLabel = new System.Windows.Forms.Label();
            quantidade_movimentadaLabel = new System.Windows.Forms.Label();
            tipo_movimentacaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource1BindingNavigator)).BeginInit();
            this.estoqueBindingSource1BindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_estoqueLabel
            // 
            id_estoqueLabel.AutoSize = true;
            id_estoqueLabel.Location = new System.Drawing.Point(125, 147);
            id_estoqueLabel.Name = "id_estoqueLabel";
            id_estoqueLabel.Size = new System.Drawing.Size(43, 13);
            id_estoqueLabel.TabIndex = 2;
            id_estoqueLabel.Text = "Código:";
            // 
            // fKid_ingredienteLabel
            // 
            fKid_ingredienteLabel.AutoSize = true;
            fKid_ingredienteLabel.Location = new System.Drawing.Point(125, 173);
            fKid_ingredienteLabel.Name = "fKid_ingredienteLabel";
            fKid_ingredienteLabel.Size = new System.Drawing.Size(86, 13);
            fKid_ingredienteLabel.TabIndex = 4;
            fKid_ingredienteLabel.Text = "FKid ingrediente:";
            // 
            // data_movimentacaoLabel
            // 
            data_movimentacaoLabel.AutoSize = true;
            data_movimentacaoLabel.Location = new System.Drawing.Point(125, 200);
            data_movimentacaoLabel.Name = "data_movimentacaoLabel";
            data_movimentacaoLabel.Size = new System.Drawing.Size(120, 13);
            data_movimentacaoLabel.TabIndex = 6;
            data_movimentacaoLabel.Text = "Data de movimentacao:";
            // 
            // quantidade_movimentadaLabel
            // 
            quantidade_movimentadaLabel.AutoSize = true;
            quantidade_movimentadaLabel.Location = new System.Drawing.Point(125, 225);
            quantidade_movimentadaLabel.Name = "quantidade_movimentadaLabel";
            quantidade_movimentadaLabel.Size = new System.Drawing.Size(131, 13);
            quantidade_movimentadaLabel.TabIndex = 8;
            quantidade_movimentadaLabel.Text = "Quantidade movimentada:";
            // 
            // tipo_movimentacaoLabel
            // 
            tipo_movimentacaoLabel.AutoSize = true;
            tipo_movimentacaoLabel.Location = new System.Drawing.Point(125, 251);
            tipo_movimentacaoLabel.Name = "tipo_movimentacaoLabel";
            tipo_movimentacaoLabel.Size = new System.Drawing.Size(118, 13);
            tipo_movimentacaoLabel.TabIndex = 10;
            tipo_movimentacaoLabel.Text = "Tipo de movimentacao:";
            // 
            // renataDBDataSet1
            // 
            this.renataDBDataSet1.DataSetName = "RenataDBDataSet";
            this.renataDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estoqueBindingSource1
            // 
            this.estoqueBindingSource1.DataMember = "estoque";
            this.estoqueBindingSource1.DataSource = this.renataDBDataSet1;
            // 
            // estoqueTableAdapter1
            // 
            this.estoqueTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.avaliacaoTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.categoriaTableAdapter = null;
            this.tableAdapterManager1.clienteTableAdapter = null;
            this.tableAdapterManager1.estoqueTableAdapter = this.estoqueTableAdapter1;
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
            // estoqueBindingSource1BindingNavigator
            // 
            this.estoqueBindingSource1BindingNavigator.AddNewItem = this.toolStripButton5;
            this.estoqueBindingSource1BindingNavigator.BindingSource = this.estoqueBindingSource1;
            this.estoqueBindingSource1BindingNavigator.CountItem = this.toolStripLabel1;
            this.estoqueBindingSource1BindingNavigator.DeleteItem = this.toolStripButton6;
            this.estoqueBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.estoqueBindingSource1BindingNavigatorSaveItem});
            this.estoqueBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.estoqueBindingSource1BindingNavigator.MoveFirstItem = this.toolStripButton1;
            this.estoqueBindingSource1BindingNavigator.MoveLastItem = this.toolStripButton4;
            this.estoqueBindingSource1BindingNavigator.MoveNextItem = this.toolStripButton3;
            this.estoqueBindingSource1BindingNavigator.MovePreviousItem = this.toolStripButton2;
            this.estoqueBindingSource1BindingNavigator.Name = "estoqueBindingSource1BindingNavigator";
            this.estoqueBindingSource1BindingNavigator.PositionItem = this.toolStripTextBox1;
            this.estoqueBindingSource1BindingNavigator.Size = new System.Drawing.Size(848, 25);
            this.estoqueBindingSource1BindingNavigator.TabIndex = 0;
            this.estoqueBindingSource1BindingNavigator.Text = "bindingNavigator1";
            this.estoqueBindingSource1BindingNavigator.Visible = false;
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
            // estoqueBindingSource1BindingNavigatorSaveItem
            // 
            this.estoqueBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.estoqueBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("estoqueBindingSource1BindingNavigatorSaveItem.Image")));
            this.estoqueBindingSource1BindingNavigatorSaveItem.Name = "estoqueBindingSource1BindingNavigatorSaveItem";
            this.estoqueBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.estoqueBindingSource1BindingNavigatorSaveItem.Text = "Salvar Dados";
            this.estoqueBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.estoqueBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // id_estoqueTextBox1
            // 
            this.id_estoqueTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource1, "id_estoque", true));
            this.id_estoqueTextBox1.Location = new System.Drawing.Point(260, 144);
            this.id_estoqueTextBox1.Name = "id_estoqueTextBox1";
            this.id_estoqueTextBox1.Size = new System.Drawing.Size(200, 20);
            this.id_estoqueTextBox1.TabIndex = 3;
            // 
            // fKid_ingredienteTextBox1
            // 
            this.fKid_ingredienteTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource1, "FKid_ingrediente", true));
            this.fKid_ingredienteTextBox1.Location = new System.Drawing.Point(260, 170);
            this.fKid_ingredienteTextBox1.Name = "fKid_ingredienteTextBox1";
            this.fKid_ingredienteTextBox1.Size = new System.Drawing.Size(200, 20);
            this.fKid_ingredienteTextBox1.TabIndex = 5;
            // 
            // data_movimentacaoDateTimePicker1
            // 
            this.data_movimentacaoDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.estoqueBindingSource1, "data_movimentacao", true));
            this.data_movimentacaoDateTimePicker1.Location = new System.Drawing.Point(260, 196);
            this.data_movimentacaoDateTimePicker1.Name = "data_movimentacaoDateTimePicker1";
            this.data_movimentacaoDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.data_movimentacaoDateTimePicker1.TabIndex = 7;
            // 
            // quantidade_movimentadaTextBox1
            // 
            this.quantidade_movimentadaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource1, "quantidade_movimentada", true));
            this.quantidade_movimentadaTextBox1.Location = new System.Drawing.Point(260, 222);
            this.quantidade_movimentadaTextBox1.Name = "quantidade_movimentadaTextBox1";
            this.quantidade_movimentadaTextBox1.Size = new System.Drawing.Size(200, 20);
            this.quantidade_movimentadaTextBox1.TabIndex = 9;
            // 
            // tipo_movimentacaoTextBox1
            // 
            this.tipo_movimentacaoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.estoqueBindingSource1, "tipo_movimentacao", true));
            this.tipo_movimentacaoTextBox1.Location = new System.Drawing.Point(260, 248);
            this.tipo_movimentacaoTextBox1.Name = "tipo_movimentacaoTextBox1";
            this.tipo_movimentacaoTextBox1.Size = new System.Drawing.Size(200, 20);
            this.tipo_movimentacaoTextBox1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Incluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(216, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(317, 84);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Salvar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(414, 84);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Visualizar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(623, 47);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "Movimentações de estoque";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmEstoque
            // 
            this.ClientSize = new System.Drawing.Size(623, 356);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(id_estoqueLabel);
            this.Controls.Add(this.id_estoqueTextBox1);
            this.Controls.Add(fKid_ingredienteLabel);
            this.Controls.Add(this.fKid_ingredienteTextBox1);
            this.Controls.Add(data_movimentacaoLabel);
            this.Controls.Add(this.data_movimentacaoDateTimePicker1);
            this.Controls.Add(quantidade_movimentadaLabel);
            this.Controls.Add(this.quantidade_movimentadaTextBox1);
            this.Controls.Add(tipo_movimentacaoLabel);
            this.Controls.Add(this.tipo_movimentacaoTextBox1);
            this.Controls.Add(this.estoqueBindingSource1BindingNavigator);
            this.Name = "frmEstoque";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmEstoque_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoqueBindingSource1BindingNavigator)).EndInit();
            this.estoqueBindingSource1BindingNavigator.ResumeLayout(false);
            this.estoqueBindingSource1BindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenataDBDataSet renataDBDataSet;
        private System.Windows.Forms.BindingSource estoqueBindingSource;
        private RenataDBDataSetTableAdapters.estoqueTableAdapter estoqueTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator estoqueBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton estoqueBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_estoqueTextBox;
        private System.Windows.Forms.TextBox cat_estoqueTextBox;
        private System.Windows.Forms.TextBox nome_estoqueTextBox;
        private System.Windows.Forms.DateTimePicker data_movimentacaoDateTimePicker;
        private System.Windows.Forms.TextBox quantidade_movimentadaTextBox;
        private System.Windows.Forms.TextBox tipo_movimentacaoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource ingredientesBindingSource;
        private RenataDBDataSetTableAdapters.ingredientesTableAdapter ingredientesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView estoqueDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox fKid_ingredienteTextBox;
        private RenataDBDataSet renataDBDataSet1;
        private System.Windows.Forms.BindingSource estoqueBindingSource1;
        private RenataDBDataSetTableAdapters.estoqueTableAdapter estoqueTableAdapter1;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator estoqueBindingSource1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton estoqueBindingSource1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_estoqueTextBox1;
        private System.Windows.Forms.TextBox fKid_ingredienteTextBox1;
        private System.Windows.Forms.DateTimePicker data_movimentacaoDateTimePicker1;
        private System.Windows.Forms.TextBox quantidade_movimentadaTextBox1;
        private System.Windows.Forms.TextBox tipo_movimentacaoTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
    }
}