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
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }
        SqlConnection sqlConn = null;
        private string strConn = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Oficina;Data Source=LAPTOP-FCIGCC9H";
        private string strSql = string.Empty;


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            strSql = "Insert into tb_produto (id_produto,ds_produto,valor,quant)values(@id_produto,@ds_produto,@valor,@quant)";

            sqlConn = new SqlConnection(strConn);
            SqlCommand comando = new SqlCommand(strSql, sqlConn);

            comando.Parameters.Add("@id_produto", SqlDbType.Int).Value = int.Parse(tb_ID.Text);
            comando.Parameters.Add("@ds_produto", SqlDbType.VarChar).Value = (txt_descricao.Text);
            comando.Parameters.Add("@valor", SqlDbType.Int).Value = float.Parse(txt_valor.Text);
            comando.Parameters.Add("@quant", SqlDbType.Int).Value = int.Parse(tb_ID.Text);

            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro concluído!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            

            txt_descricao.Clear();
            txt_valor.Clear();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            strSql = "update tb_produto set id_produto =@id_produto, ds_produto=@ds_produto,valor=@valor";
            sqlConn = new SqlConnection(strConn);
            SqlCommand comando = new SqlCommand(strSql, sqlConn);

            comando.Parameters.Add("@id_produto", SqlDbType.Int).Value = int.Parse(tb_ID.Text);
            comando.Parameters.Add("@ds_produto", SqlDbType.VarChar).Value = (txt_descricao.Text);
            comando.Parameters.Add("@valor", SqlDbType.Int).Value = decimal.Parse(txt_valor.Text);

            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro alterado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }
            tb_ID.Enabled = true;

            txt_descricao.Clear();
            txt_valor.Clear();
            tb_ID.Clear();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este produto?", "Cuidado", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!");
            }
            strSql = "delete from tb_produto where id_produto=@id_produto";
            sqlConn = new SqlConnection(strConn);
            SqlCommand comando = new SqlCommand(strSql, sqlConn);

            comando.Parameters.Add("@id_produto", SqlDbType.Int).Value = int.Parse(tb_ID.Text);

            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto excluído!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }

            txt_descricao.Clear();
            txt_valor.Clear();
            tb_ID.Clear();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tb_ID.Clear();
            txt_descricao.Clear();
            txt_valor.Clear();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja sair de Cadastro? ", "Mensage do sistema ",

               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {

                Close();
            }
        }

        private void tb_ID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            strSql = "select*from tb_produto where id_produto =@id_produto";
            sqlConn = new SqlConnection(strConn);
            SqlCommand comando = new SqlCommand(strSql, sqlConn);

            comando.Parameters.Add("@id_produto", SqlDbType.Int).Value = int.Parse(tb_ID.Text);

            try
            {
                sqlConn.Open();
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("Este produto não está cadastrado!");
                }
                dr.Read();
                tb_ID.Text = Convert.ToString(dr["id_produto"]);
                txt_descricao.Text = Convert.ToString(dr["ds_produto"]);
                txt_valor.Text = Convert.ToString(dr["valor"]);

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
    }
    }


