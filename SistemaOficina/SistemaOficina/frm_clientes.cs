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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        SqlConnection sqlConn = null;
        private string strConn ="Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Oficina;Data Source=LAPTOP-FCIGCC9H";
        private string strSql = string.Empty;
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            strSql = "Insert into TabOfc(id_produto,nome,fone,cpf,email)values(@id_produto,@nome,@fone,@cpf,@email)";

            sqlConn = new SqlConnection(strConn);
            SqlCommand comando = new SqlCommand(strSql, sqlConn);

            comando.Parameters.Add("@id_produto", SqlDbType.Int).Value = int.Parse(txt_id.Text);
            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = (txt_nome.Text);
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = (txt_email.Text);
            comando.Parameters.Add("@fone", SqlDbType.VarChar).Value = (msk_fone.Text);
            comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = (msk_cpf.Text);

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
            txt_id.Enabled = true;

            txt_nome.Clear();
            msk_cpf.Clear();
            msk_fone.Clear();
            txt_email.Clear();
            txt_id.Clear();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            btn_cadastrar.Enabled = false;
            strSql = "select*from TabOfc where id_produto =@id_produto";
            sqlConn = new SqlConnection(strConn);
            SqlCommand comando = new SqlCommand(strSql, sqlConn);

            comando.Parameters.Add("@id_produto", SqlDbType.Int).Value = int.Parse(txt_id.Text);

            try
            {
                sqlConn.Open();
                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("Este cliente não está cadastrado!");
                }
                dr.Read();
                txt_id.Text = Convert.ToString(dr["id_produto"]);
                txt_nome.Text = Convert.ToString(dr["nome"]);
                txt_email.Text = Convert.ToString(dr["email"]);
                msk_fone.Text = Convert.ToString(dr["fone"]);
                msk_cpf.Text = Convert.ToString(dr["cpf"]);

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

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            strSql = "update TabOfc set id_produto =@id_produto, nome=@nome, fone=@fone, cpf=@cpf, email=@email";
            sqlConn = new SqlConnection(strConn);
            SqlCommand comando = new SqlCommand(strSql, sqlConn);

            comando.Parameters.Add("@id_produto", SqlDbType.Int).Value = int.Parse(txt_id.Text);
            comando.Parameters.Add("@nome", SqlDbType.VarChar).Value = (txt_nome.Text);
            comando.Parameters.Add("@fone", SqlDbType.VarChar).Value = (msk_fone.Text);
            comando.Parameters.Add("@cpf", SqlDbType.VarChar).Value = (msk_cpf.Text);
            comando.Parameters.Add("@email", SqlDbType.VarChar).Value = (txt_email.Text);


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
            txt_id.Enabled = true;

            txt_nome.Clear();
            msk_cpf.Clear();
            msk_fone.Clear();
            txt_id.Clear();
            txt_email.Clear();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este cadastro?", "Cuidado", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação cancelada!");
            }
            strSql = "delete from TabOfc where id_produto=@id_produto";
            sqlConn = new SqlConnection(strConn);
            SqlCommand comando = new SqlCommand(strSql, sqlConn);

            comando.Parameters.Add("@id_produto", SqlDbType.Int).Value = int.Parse(txt_id.Text);



            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro excluído!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConn.Close();
            }

            txt_nome.Clear();
            msk_cpf.Clear();
            msk_fone.Clear();
            txt_id.Clear();
            txt_email.Clear();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_nome.Clear();
            msk_cpf.Clear();
            msk_fone.Clear();
            txt_email.Clear();
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            btn_cadastrar.Enabled = true;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

