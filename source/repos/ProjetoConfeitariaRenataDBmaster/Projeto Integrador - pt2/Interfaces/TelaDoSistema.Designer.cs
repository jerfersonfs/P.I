﻿namespace Projeto_Integrador___pt2.Interfaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDoSistema));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosECadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslUsu = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslIP = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslNomePC = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslData = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(191)))));
            this.menuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosECadastrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip2.Size = new System.Drawing.Size(138, 450);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.UseWaitCursor = true;
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtoToolStripMenuItem,
            this.pedidoToolStripMenuItem,
            this.ingredientesToolStripMenuItem});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(137, 32);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.produtoToolStripMenuItem.Text = "Produtos";
            this.produtoToolStripMenuItem.Click += new System.EventHandler(this.produtoToolStripMenuItem_Click);
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.pedidoToolStripMenuItem.Text = "Pedidos";
            this.pedidoToolStripMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click);
            // 
            // ingredientesToolStripMenuItem
            // 
            this.ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            this.ingredientesToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.ingredientesToolStripMenuItem.Text = "Ingredientes";
            this.ingredientesToolStripMenuItem.Click += new System.EventHandler(this.ingredientesToolStripMenuItem_Click);
            // 
            // registrosECadastrosToolStripMenuItem
            // 
            this.registrosECadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.produtoToolStripMenuItem1,
            this.categoriaToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.pedidoToolStripMenuItem1,
            this.ingredientesToolStripMenuItem1});
            this.registrosECadastrosToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrosECadastrosToolStripMenuItem.Name = "registrosECadastrosToolStripMenuItem";
            this.registrosECadastrosToolStripMenuItem.Size = new System.Drawing.Size(137, 32);
            this.registrosECadastrosToolStripMenuItem.Text = "Movimentações";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(181, 32);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // produtoToolStripMenuItem1
            // 
            this.produtoToolStripMenuItem1.Name = "produtoToolStripMenuItem1";
            this.produtoToolStripMenuItem1.Size = new System.Drawing.Size(181, 32);
            this.produtoToolStripMenuItem1.Text = "Produto";
            this.produtoToolStripMenuItem1.Click += new System.EventHandler(this.produtoToolStripMenuItem1_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(181, 32);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(181, 32);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // pedidoToolStripMenuItem1
            // 
            this.pedidoToolStripMenuItem1.Name = "pedidoToolStripMenuItem1";
            this.pedidoToolStripMenuItem1.Size = new System.Drawing.Size(181, 32);
            this.pedidoToolStripMenuItem1.Text = "Estoque";
            this.pedidoToolStripMenuItem1.Click += new System.EventHandler(this.pedidoToolStripMenuItem1_Click);
            // 
            // ingredientesToolStripMenuItem1
            // 
            this.ingredientesToolStripMenuItem1.Name = "ingredientesToolStripMenuItem1";
            this.ingredientesToolStripMenuItem1.Size = new System.Drawing.Size(181, 32);
            this.ingredientesToolStripMenuItem1.Text = "Ingredientes";
            this.ingredientesToolStripMenuItem1.Click += new System.EventHandler(this.ingredientesToolStripMenuItem1_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.senhaToolStripMenuItem,
            this.temasToolStripMenuItem,
            this.reiniciarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(137, 32);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // senhaToolStripMenuItem
            // 
            this.senhaToolStripMenuItem.Name = "senhaToolStripMenuItem";
            this.senhaToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.senhaToolStripMenuItem.Text = "Senha";
            // 
            // temasToolStripMenuItem
            // 
            this.temasToolStripMenuItem.Name = "temasToolStripMenuItem";
            this.temasToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.temasToolStripMenuItem.Text = "Temas";
            this.temasToolStripMenuItem.Click += new System.EventHandler(this.temasToolStripMenuItem_Click);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar ";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(191)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUsu,
            this.tsslIP,
            this.tsslNomePC,
            this.tsslData,
            this.tsslHora});
            this.statusStrip1.Location = new System.Drawing.Point(138, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(920, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // tsslUsu
            // 
            this.tsslUsu.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslUsu.Name = "tsslUsu";
            this.tsslUsu.Size = new System.Drawing.Size(54, 19);
            this.tsslUsu.Text = "Usuário:";
            this.tsslUsu.Click += new System.EventHandler(this.tsslUsu_Click);
            // 
            // tsslIP
            // 
            this.tsslIP.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslIP.Name = "tsslIP";
            this.tsslIP.Size = new System.Drawing.Size(24, 19);
            this.tsslIP.Text = "IP:";
            // 
            // tsslNomePC
            // 
            this.tsslNomePC.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslNomePC.Name = "tsslNomePC";
            this.tsslNomePC.Size = new System.Drawing.Size(82, 19);
            this.tsslNomePC.Text = "Computador:";
            // 
            // tsslData
            // 
            this.tsslData.Name = "tsslData";
            this.tsslData.Size = new System.Drawing.Size(0, 19);
            // 
            // tsslHora
            // 
            this.tsslHora.Name = "tsslHora";
            this.tsslHora.Size = new System.Drawing.Size(0, 19);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // TelaDoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1058, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TelaDoSistema";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TelaDoSistema_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosECadastrosToolStripMenuItem;
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsu;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem senhaToolStripMenuItem;
    }
}