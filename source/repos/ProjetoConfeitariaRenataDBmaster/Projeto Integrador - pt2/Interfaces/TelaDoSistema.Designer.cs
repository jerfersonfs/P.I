namespace Projeto_Integrador___pt2.Interfaces
{
    partial class TelaDoSistema
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avaliaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosECadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslUsu = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNomePC = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.receitasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.registrosECadastrosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.pedidoToolStripMenuItem,
            this.receitasToolStripMenuItem,
            this.ingredientesToolStripMenuItem,
            this.pagamentosToolStripMenuItem,
            this.avaliaçõesToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.produtoToolStripMenuItem.Text = "Produtos";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.pedidoToolStripMenuItem.Text = "Pedidos";
            this.pedidoToolStripMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click);
            // 
            // receitasToolStripMenuItem
            // 
            this.receitasToolStripMenuItem.Name = "receitasToolStripMenuItem";
            this.receitasToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.receitasToolStripMenuItem.Text = "Receitas";
            this.receitasToolStripMenuItem.Click += new System.EventHandler(this.receitasToolStripMenuItem_Click);
            // 
            // ingredientesToolStripMenuItem
            // 
            this.ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            this.ingredientesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ingredientesToolStripMenuItem.Text = "Ingredientes";
            this.ingredientesToolStripMenuItem.Click += new System.EventHandler(this.ingredientesToolStripMenuItem_Click);
            // 
            // pagamentosToolStripMenuItem
            // 
            this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            this.pagamentosToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.pagamentosToolStripMenuItem.Text = "Pagamentos";
            this.pagamentosToolStripMenuItem.Click += new System.EventHandler(this.pagamentosToolStripMenuItem_Click);
            // 
            // avaliaçõesToolStripMenuItem
            // 
            this.avaliaçõesToolStripMenuItem.Name = "avaliaçõesToolStripMenuItem";
            this.avaliaçõesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.avaliaçõesToolStripMenuItem.Text = "Avaliações";
            this.avaliaçõesToolStripMenuItem.Click += new System.EventHandler(this.avaliaçõesToolStripMenuItem_Click);
            // 
            // registrosECadastrosToolStripMenuItem
            // 
            this.registrosECadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem1,
            this.categoriaToolStripMenuItem,
            this.pedidoToolStripMenuItem1,
            this.ingredientesToolStripMenuItem1,
            this.receitasToolStripMenuItem1});
            this.registrosECadastrosToolStripMenuItem.Name = "registrosECadastrosToolStripMenuItem";
            this.registrosECadastrosToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.registrosECadastrosToolStripMenuItem.Text = "Registros e Cadastros";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUsu,
            this.tsslIP,
            this.tsslNomePC,
            this.tsslData,
            this.tsslHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslUsu
            // 
            this.tsslUsu.Name = "tsslUsu";
            this.tsslUsu.Size = new System.Drawing.Size(50, 17);
            this.tsslUsu.Text = "Usuário:";
            // 
            // tsslIP
            // 
            this.tsslIP.Name = "tsslIP";
            this.tsslIP.Size = new System.Drawing.Size(20, 17);
            this.tsslIP.Text = "IP:";
            // 
            // tsslNomePC
            // 
            this.tsslNomePC.Name = "tsslNomePC";
            this.tsslNomePC.Size = new System.Drawing.Size(78, 17);
            this.tsslNomePC.Text = "Computador:";
            // 
            // tsslData
            // 
            this.tsslData.Name = "tsslData";
            this.tsslData.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslHora
            // 
            this.tsslHora.Name = "tsslHora";
            this.tsslHora.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.produtoToolStripMenuItem1.Text = "Produto";
            this.produtoToolStripMenuItem1.Click += new System.EventHandler(this.produtoToolStripMenuItem1_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // pedidoToolStripMenuItem1
            // 
            this.pedidoToolStripMenuItem1.Name = "pedidoToolStripMenuItem1";
            this.pedidoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pedidoToolStripMenuItem1.Text = "Estoque";
            this.pedidoToolStripMenuItem1.Click += new System.EventHandler(this.pedidoToolStripMenuItem1_Click);
            // 
            // ingredientesToolStripMenuItem1
            // 
            this.ingredientesToolStripMenuItem1.Name = "ingredientesToolStripMenuItem1";
            this.ingredientesToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ingredientesToolStripMenuItem1.Text = "Ingredientes";
            this.ingredientesToolStripMenuItem1.Click += new System.EventHandler(this.ingredientesToolStripMenuItem1_Click);
            // 
            // receitasToolStripMenuItem1
            // 
            this.receitasToolStripMenuItem1.Name = "receitasToolStripMenuItem1";
            this.receitasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.receitasToolStripMenuItem1.Text = "Receitas";
            this.receitasToolStripMenuItem1.Click += new System.EventHandler(this.receitasToolStripMenuItem1_Click);
            // 
            // TelaDoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaDoSistema";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avaliaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosECadastrosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsu;
        private System.Windows.Forms.ToolStripStatusLabel tsslIP;
        private System.Windows.Forms.ToolStripStatusLabel tsslNomePC;
        private System.Windows.Forms.ToolStripStatusLabel tsslData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel tsslHora;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingredientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem receitasToolStripMenuItem1;
    }
}