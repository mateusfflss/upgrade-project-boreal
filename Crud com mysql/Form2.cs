using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Crud_com_mysql
{
    public partial class Form2 : Form
    {
        MySqlConnection coo = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=cadastros;User Id=root;PWD=1234");
        int i;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            i = 0;
            coo.Open();
            MySqlCommand cmd = coo.CreateCommand();
            cmd.CommandType = CommandType.Text; 
            cmd.CommandText = "select * from registro where usuario='"+txtUser.Text+"' and senha='"+txtSenha.Text+ "'and nivel_acess='" + txtnivel.Text + "'";
            cmd.ExecuteNonQuery();

            DataTable dtt = new DataTable();
            MySqlDataAdapter daa = new MySqlDataAdapter(cmd);
            daa.Fill(dtt);
            i = Convert.ToInt32 (dtt.Rows.Count.ToString());

            if(i==0)
            {
                label3.Text = "voce colocou o usuario ou senha incorreto";
            }
            else
            {
                this.Hide();
                Form1 fm = new Form1();
                fm.Show();
            }
            coo.Close();
            
        }

		private void cadastreSe_Click(object sender, EventArgs e)
		{

			MySqlConnection coo = new MySqlConnection(@"Data Source=localhost;port=3306;Initial Catalog=cadastros;User Id=root;PWD=1234");
			MySqlCommand cmd = coo.CreateCommand();
			cmd.CommandText = "select * from registro where usuario = '" + txtUser.Text + "' and senha = '" + txtSenha.Text + "'and nivel_acess = '" + txtnivel.Text + "'";
			cmd.CommandText = "select * from registro insert into values (usuario,senha,nivel_acess);";
			cmd.Parameters.AddWithValue("usuario", txtUser);
			cmd.Parameters.AddWithValue("senha", txtSenha);
			cmd.Parameters.AddWithValue("nivel_acess", txtnivel);
		}

		private void btnform_Click(object sender, EventArgs e)
		{
			Form3 form3 = new Form3();
			form3.ShowDialog();
		}

		private void txtSenha_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}
	}
}
