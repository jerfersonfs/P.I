namespace Projeto_Integrador___pt2.Interfaces
{
    partial class frmLogin
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
            System.Windows.Forms.Label email_usuLabel;
            System.Windows.Forms.Label senha_usuLabel;
            this.email_usuTextBox = new System.Windows.Forms.TextBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.renataDBDataSet = new Projeto_Integrador___pt2.RenataDBDataSet();
            this.senha_usuTextBox = new System.Windows.Forms.TextBox();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btm_Cadastro = new System.Windows.Forms.Button();
            this.usuarioTableAdapter = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.usuarioTableAdapter();
            this.tableAdapterManager = new Projeto_Integrador___pt2.RenataDBDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            email_usuLabel = new System.Windows.Forms.Label();
            senha_usuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // email_usuLabel
            // 
            email_usuLabel.AutoSize = true;
            email_usuLabel.Location = new System.Drawing.Point(159, 162);
            email_usuLabel.Name = "email_usuLabel";
            email_usuLabel.Size = new System.Drawing.Size(35, 13);
            email_usuLabel.TabIndex = 1;
            email_usuLabel.Text = "Email:";
            // 
            // senha_usuLabel
            // 
            senha_usuLabel.AutoSize = true;
            senha_usuLabel.Location = new System.Drawing.Point(159, 204);
            senha_usuLabel.Name = "senha_usuLabel";
            senha_usuLabel.Size = new System.Drawing.Size(41, 13);
            senha_usuLabel.TabIndex = 3;
            senha_usuLabel.Text = "Senha:";
            // 
            // email_usuTextBox
            // 
            this.email_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "email_usu", true));
            this.email_usuTextBox.Location = new System.Drawing.Point(206, 159);
            this.email_usuTextBox.Name = "email_usuTextBox";
            this.email_usuTextBox.Size = new System.Drawing.Size(130, 20);
            this.email_usuTextBox.TabIndex = 2;
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
            // senha_usuTextBox
            // 
            this.senha_usuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "senha_usu", true));
            this.senha_usuTextBox.Location = new System.Drawing.Point(206, 201);
            this.senha_usuTextBox.Name = "senha_usuTextBox";
            this.senha_usuTextBox.Size = new System.Drawing.Size(130, 20);
            this.senha_usuTextBox.TabIndex = 4;
            this.senha_usuTextBox.UseSystemPasswordChar = true;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Location = new System.Drawing.Point(206, 245);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(130, 40);
            this.btn_Entrar.TabIndex = 5;
            this.btn_Entrar.Text = "Entrar";
            this.btn_Entrar.UseVisualStyleBackColor = true;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(12, 395);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(86, 28);
            this.btn_Sair.TabIndex = 6;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btm_Cadastro
            // 
            this.btm_Cadastro.Location = new System.Drawing.Point(231, 300);
            this.btm_Cadastro.Name = "btm_Cadastro";
            this.btm_Cadastro.Size = new System.Drawing.Size(80, 25);
            this.btm_Cadastro.TabIndex = 7;
            this.btm_Cadastro.Text = "Cadastrar";
            this.btm_Cadastro.UseVisualStyleBackColor = true;
            this.btm_Cadastro.Click += new System.EventHandler(this.btm_Cadastro_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 33.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 54);
            this.label1.TabIndex = 8;
            this.label1.Text = "Renata - Confeitaria Artesanal";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Integrador___pt2.Properties.Resources.Gemini_Generated_Image_h8pjszh8pjszh8pj;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btm_Cadastro);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Entrar);
            this.Controls.Add(senha_usuLabel);
            this.Controls.Add(this.senha_usuTextBox);
            this.Controls.Add(email_usuLabel);
            this.Controls.Add(this.email_usuTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renataDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RenataDBDataSet renataDBDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private RenataDBDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private RenataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox email_usuTextBox;
        private System.Windows.Forms.TextBox senha_usuTextBox;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btm_Cadastro;
        private System.Windows.Forms.Label label1;
    }
}