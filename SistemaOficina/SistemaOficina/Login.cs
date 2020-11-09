using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOficina
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if(txt_lg.Text=="user01" && txt_pass.Text =="1234")
            {
                MessageBox.Show("Bem Vindo!");

                frm_Menu frm = new frm_Menu();
                
                frm.Show();
                this.Visible = false;
                
            }
            else
            {
                MessageBox.Show("Login ou Senha inválidos!");
            }
        }
    }
}
