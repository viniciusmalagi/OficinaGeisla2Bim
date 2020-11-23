using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOficina
{
    public partial class frm_ordem : Form
    {
        public frm_ordem()
       
        {
            InitializeComponent();
            NomerDataGrid();
            rb_Cart.Enabled = false;


        }
        
        
        SqlConnection sqlConn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Oficina;Data Source=LAPTOP-FCIGCC9H");
        float totalvenda = 0;
        float totalant = 0;

       
        public void gerarCod()
        {
            
           SqlCommand cmd = new SqlCommand("select MAX (id_venda) from tb_caixa");

            
            try
            {
                sqlConn.Open();
                if (cmd.ExecuteScalar() == DBNull.Value)
                {
                    lbl_COD.Text = "i";
                }
                else
                {
                    Int32 ra = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                    lbl_COD.Text = ra.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
                sqlConn.Dispose();
                
            }
        }
        

        public void NomerDataGrid()
        {
            dgv_prod.ColumnCount = 5;
            dgv_prod.Columns[0].HeaderText = "Código";
            dgv_prod.Columns[1].HeaderText = "Descrição";
            dgv_prod.Columns[1].Width = 120;
            dgv_prod.Columns[2].HeaderText = "Valor unitario";
            dgv_prod.Columns[3].HeaderText = "Quantidade";
            dgv_prod.Columns[4].HeaderText = "Total";
        }

        public void consultaProd()
        {
            SqlCommand cmd = new SqlCommand("select * from tb_produto where id_produto=@id_produto", sqlConn);
            cmd.Parameters.Add("@id_produto", SqlDbType.Int).Value = int.Parse(txt_produto.Text);

            try
            {
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open();
                }
                SqlDataReader drProd = cmd.ExecuteReader(); 
                drProd.Read();
                if (!drProd.HasRows)
                {
                    MessageBox.Show("Produto não encontrado!");
                    txt_produto.Clear();
                    txt_produto.Focus();
                }
                else
                {
                    txt_nome.Text = drProd["ds_produto"].ToString();
                    txt_valorUni.Text = drProd["valor"].ToString();
                    int quantidade = int.Parse(drProd["quant"].ToString());
                    txt_quantidade.Focus();

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            totalvenda += float.Parse(txt_total.Text);
            txt_totalCompra.Text = totalvenda.ToString();
           dgv_prod.Rows.Add(txt_produto.Text,txt_nome.Text, txt_valorUni.Text, txt_quantidade.Text, txt_total.Text);
            limparTudo();
        }
        public void limparTudo()



        {
            txt_produto.Clear();
            txt_nome.Clear();
            txt_quantidade.Clear();
            txt_valorUni.Clear();
            txt_total.Clear();
        }
        public void GravarVenda()
        {
            SqlCommand cmd = new SqlCommand("insert into tb_caixa (id_venda, valortotal)values (@id_venda,@valortotal)", sqlConn);
            cmd.Parameters.AddWithValue("@id_venda", Convert.ToInt32(lbl_COD.Text));
            cmd.Parameters.AddWithValue("@valortotal", Convert.ToDecimal(txt_totalCompra.Text));

            try
            {
                sqlConn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
                
            }

        }
        public void Inserir()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into tb_itensvenda(id_venda, id_produto, quant, valor_uni)values(@codvenda, @codprod,@tquant,@valor");
                for (int i = 0; i < dgv_prod.Rows.Count - 1; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@codvenda", lbl_COD.Text);
                    cmd.Parameters.AddWithValue("@codprod", dgv_prod.Rows[i].Cells[0].Value);
                    cmd.Parameters.AddWithValue("@tquant", dgv_prod.Rows[i].Cells[3].Value);
                    cmd.Parameters.AddWithValue("@valor", dgv_prod.Rows[i].Cells[2].Value);
                    
                    cmd.ExecuteNonQuery();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
                GravarVenda();
                gerarCod();
            }
            
            {

            }
        }
        public void FecharFormulario(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void confirmarSair(FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }


        }

        private void VendaFromClosing(object sender, FormClosingEventArgs e)
        {
            confirmarSair(e);
        }
        private void VendaKeyDown(object sender, KeyEventArgs e)
        {
            FecharFormulario(e);
        }

        private void txt_produto_Validating(object sender, CancelEventArgs e)
        {
            if (txt_produto.Text != string.Empty)
            {
                consultaProd();

            }
            else
            {
                MessageBox.Show("Digite o ID!");
                txt_produto.Focus();
            }
        }

        private void txt_quantidade_Validating(object sender, CancelEventArgs e)
        {
            {
                if (txt_quantidade.Text != string.Empty)
                {
                    
                    txt_total.Text = (float.Parse(txt_valorUni.Text) * float.Parse(txt_quantidade.Text)).ToString();
                    btn_adicionar.Focus();
                }
                else
                {
                    MessageBox.Show("Digite a quantidade!");
                    txt_quantidade.Focus();
                }
            }
        }

        private void dgv_prod_CellEnter(object sender, DataGridViewCellEventArgs e)

        {
            if (dgv_prod.CurrentCell.ColumnIndex == 3)
            {
                int rows = dgv_prod.CurrentCell.RowIndex;
                //totalant = float.Parse(dgv_prod.Rows[rows].Cells["valor"].Value.ToString());
                dgv_prod.BeginEdit(true);
            }
        }

        private void dgv_prod_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_prod.CurrentCell.ColumnIndex == 3)
            {
                int rows = dgv_prod.CurrentCell.RowIndex;
                dgv_prod.EndEdit();
            }
        }

        private void dgv_prod_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rows = dgv_prod.CurrentCell.RowIndex;
            int quantidade = int.Parse(dgv_prod.Rows[rows].Cells["quant"].Value.ToString());
            float valorunitario = float.Parse(dgv_prod.Rows[rows].Cells["valor_uni"].Value.ToString());

            dgv_prod.Rows[rows].Cells["total"].Value = quantidade * valorunitario;
            totalvenda -= totalant;
            totalvenda += float.Parse(dgv_prod.Rows[rows].Cells["valor"].Value.ToString());
            txt_totalCompra.Text = totalvenda.ToString();
        }
        public void DeletarCelula(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int rows = dgv_prod.CurrentCell.RowIndex;
                //totalant = float.Parse(dgv_prod.Rows[rows].Cells["valor"].Value.ToString());

                dgv_prod.Rows.RemoveAt(dgv_prod.Rows[rows].Index);

                totalvenda += totalant;
                txt_totalCompra.Text = totalvenda.ToString();
            }
        }

        private void dgv_prod_KeyDown(object sender, KeyEventArgs e)
        {
            DeletarCelula(e);
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txt_totalCompra.Text) >= 250)
                MessageBox.Show("Pedido Concluído!");
            else
            {
                MessageBox.Show("O valor mínimo do pedido é de R$250,00");
            }
            //GravarVenda();
            //gerarCod();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja sair de Vendas? ", "Mensage do sistema ",

               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                Close();
            }
        }
        public void Pag()

        {
            
            //if(int.Parse(txt_totalCompra.Text) >=800)
            //{
            //    rb_Cart.Visible = true;
            //}
            //else
            //{
            //    rb_Cart.Visible = false;
            //    MessageBox.Show("Para Parcelamento o valor é acima de R$800,00");

            //}
            
        }

        private void txt_totalCompra_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(txt_totalCompra.Text) >= 800)
            {
                rb_Cart.Enabled = true;
            }
            
        }
        
        
    }
}
