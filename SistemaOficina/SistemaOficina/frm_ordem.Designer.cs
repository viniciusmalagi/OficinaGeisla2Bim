namespace SistemaOficina
{
    partial class frm_ordem
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
            this.dgv_prod = new System.Windows.Forms.DataGridView();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cance = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.txt_valorUni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_totalCompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_COD = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rb_Din = new System.Windows.Forms.RadioButton();
            this.rb_Cart = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_mao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_prod
            // 
            this.dgv_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prod.Location = new System.Drawing.Point(10, 133);
            this.dgv_prod.Name = "dgv_prod";
            this.dgv_prod.Size = new System.Drawing.Size(561, 166);
            this.dgv_prod.TabIndex = 21;
            this.dgv_prod.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_prod_CellEndEdit);
            this.dgv_prod.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_prod_CellEnter);
            this.dgv_prod.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_prod_CellLeave);
            this.dgv_prod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_prod_KeyDown);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(416, 104);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 20;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(313, 104);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 19;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_cance
            // 
            this.btn_cance.Location = new System.Drawing.Point(199, 104);
            this.btn_cance.Name = "btn_cance";
            this.btn_cance.Size = new System.Drawing.Size(75, 23);
            this.btn_cance.TabIndex = 18;
            this.btn_cance.Text = "Cancelar";
            this.btn_cance.UseVisualStyleBackColor = true;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(78, 104);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 17;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // txt_valorUni
            // 
            this.txt_valorUni.Location = new System.Drawing.Point(354, 65);
            this.txt_valorUni.Name = "txt_valorUni";
            this.txt_valorUni.Size = new System.Drawing.Size(53, 20);
            this.txt_valorUni.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Valor unitário";
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(229, 27);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(100, 20);
            this.txt_produto.TabIndex = 12;
            this.txt_produto.Validating += new System.ComponentModel.CancelEventHandler(this.txt_produto_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "TOTAL R$";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(229, 64);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(45, 20);
            this.txt_quantidade.TabIndex = 26;
            this.txt_quantidade.Validating += new System.ComponentModel.CancelEventHandler(this.txt_quantidade_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(384, 27);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(187, 20);
            this.txt_nome.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "VALOR TOTAL DA COMPRA R$";
            // 
            // txt_totalCompra
            // 
            this.txt_totalCompra.Location = new System.Drawing.Point(313, 305);
            this.txt_totalCompra.Name = "txt_totalCompra";
            this.txt_totalCompra.Size = new System.Drawing.Size(100, 20);
            this.txt_totalCompra.TabIndex = 30;
            this.txt_totalCompra.Validating += new System.ComponentModel.CancelEventHandler(this.txt_totalCompra_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Compra Nº";
            // 
            // lbl_COD
            // 
            this.lbl_COD.AutoSize = true;
            this.lbl_COD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_COD.Location = new System.Drawing.Point(23, 47);
            this.lbl_COD.Name = "lbl_COD";
            this.lbl_COD.Size = new System.Drawing.Size(21, 24);
            this.lbl_COD.TabIndex = 32;
            this.lbl_COD.Text = "0";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(486, 64);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(85, 20);
            this.txt_total.TabIndex = 33;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(486, 339);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(75, 23);
            this.btn_finalizar.TabIndex = 34;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Pagamento:";
            // 
            // rb_Din
            // 
            this.rb_Din.AutoSize = true;
            this.rb_Din.Location = new System.Drawing.Point(121, 330);
            this.rb_Din.Name = "rb_Din";
            this.rb_Din.Size = new System.Drawing.Size(106, 17);
            this.rb_Din.TabIndex = 36;
            this.rb_Din.TabStop = true;
            this.rb_Din.Text = "Dinheiro (À Vista)";
            this.rb_Din.UseVisualStyleBackColor = true;
            // 
            // rb_Cart
            // 
            this.rb_Cart.AutoSize = true;
            this.rb_Cart.Location = new System.Drawing.Point(121, 353);
            this.rb_Cart.Name = "rb_Cart";
            this.rb_Cart.Size = new System.Drawing.Size(95, 17);
            this.rb_Cart.TabIndex = 37;
            this.rb_Cart.TabStop = true;
            this.rb_Cart.Text = "Cartão (Até 6x)";
            this.rb_Cart.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(273, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Valor Mão de obra:";
            // 
            // lbl_mao
            // 
            this.lbl_mao.AutoSize = true;
            this.lbl_mao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mao.Location = new System.Drawing.Point(394, 344);
            this.lbl_mao.Name = "lbl_mao";
            this.lbl_mao.Size = new System.Drawing.Size(12, 13);
            this.lbl_mao.TabIndex = 39;
            this.lbl_mao.Text = "*";
            // 
            // frm_ordem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 377);
            this.Controls.Add(this.lbl_mao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rb_Cart);
            this.Controls.Add(this.rb_Din);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_COD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_totalCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_prod);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cance);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.txt_valorUni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.label1);
            this.Name = "frm_ordem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamento Ordem de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_prod;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cance;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox txt_valorUni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_totalCompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_COD;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rb_Din;
        private System.Windows.Forms.RadioButton rb_Cart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_mao;
    }
}