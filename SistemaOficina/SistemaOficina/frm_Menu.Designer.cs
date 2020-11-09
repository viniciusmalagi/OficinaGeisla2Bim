namespace SistemaOficina
{
    partial class frm_Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lançarOrdemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadClientes = new System.Windows.Forms.Button();
            this.btnCadProdutos = new System.Windows.Forms.Button();
            this.btnOrdem = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.vendasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.veiculosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.marcasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // veiculosToolStripMenuItem
            // 
            this.veiculosToolStripMenuItem.Name = "veiculosToolStripMenuItem";
            this.veiculosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veiculosToolStripMenuItem.Text = "Veiculos";
            this.veiculosToolStripMenuItem.Click += new System.EventHandler(this.veiculosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lançarOrdemToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // lançarOrdemToolStripMenuItem
            // 
            this.lançarOrdemToolStripMenuItem.Name = "lançarOrdemToolStripMenuItem";
            this.lançarOrdemToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.lançarOrdemToolStripMenuItem.Text = "Lançar Ordem de Venda";
            this.lançarOrdemToolStripMenuItem.Click += new System.EventHandler(this.lançarOrdemToolStripMenuItem_Click);
            // 
            // btnCadClientes
            // 
            this.btnCadClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnCadClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadClientes.Image = global::SistemaOficina.Properties.Resources.Cadas2;
            this.btnCadClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadClientes.Location = new System.Drawing.Point(12, 40);
            this.btnCadClientes.Name = "btnCadClientes";
            this.btnCadClientes.Size = new System.Drawing.Size(77, 85);
            this.btnCadClientes.TabIndex = 2;
            this.btnCadClientes.Text = "Cadastro de Clientes";
            this.btnCadClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadClientes.UseVisualStyleBackColor = false;
            this.btnCadClientes.Click += new System.EventHandler(this.btnCadClientes_Click);
            // 
            // btnCadProdutos
            // 
            this.btnCadProdutos.BackColor = System.Drawing.Color.Transparent;
            this.btnCadProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadProdutos.Image = global::SistemaOficina.Properties.Resources.CadProd12;
            this.btnCadProdutos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadProdutos.Location = new System.Drawing.Point(12, 146);
            this.btnCadProdutos.Name = "btnCadProdutos";
            this.btnCadProdutos.Size = new System.Drawing.Size(77, 96);
            this.btnCadProdutos.TabIndex = 3;
            this.btnCadProdutos.Text = "Cadastro de Produtos";
            this.btnCadProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadProdutos.UseVisualStyleBackColor = false;
            this.btnCadProdutos.Click += new System.EventHandler(this.btnCadProdutos_Click);
            // 
            // btnOrdem
            // 
            this.btnOrdem.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrdem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrdem.Image = global::SistemaOficina.Properties.Resources.Ordem_de_compraaa;
            this.btnOrdem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOrdem.Location = new System.Drawing.Point(12, 248);
            this.btnOrdem.Name = "btnOrdem";
            this.btnOrdem.Size = new System.Drawing.Size(77, 130);
            this.btnOrdem.TabIndex = 4;
            this.btnOrdem.Text = "Lançar Ordem de Compra";
            this.btnOrdem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOrdem.UseVisualStyleBackColor = false;
            this.btnOrdem.Click += new System.EventHandler(this.btnOrdem_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalizar.Image = global::SistemaOficina.Properties.Resources.fechar;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFinalizar.Location = new System.Drawing.Point(12, 384);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(77, 96);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar sistema";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaOficina.Properties.Resources.repar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(744, 483);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnOrdem);
            this.Controls.Add(this.btnCadProdutos);
            this.Controls.Add(this.btnCadClientes);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.Button btnCadClientes;
        private System.Windows.Forms.Button btnCadProdutos;
        private System.Windows.Forms.Button btnOrdem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lançarOrdemToolStripMenuItem;
        private System.Windows.Forms.Button btnFinalizar;
    }
}

