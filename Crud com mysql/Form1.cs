using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crud_com_mysql.model;
using Crud_com_mysql.bll;
using MySql.Data.MySqlClient;

namespace Crud_com_mysql
{
    public partial class Form1 : Form
    {
		public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        //limpador de tabelas
        private void limparcampo()
        {
            txtID.Clear();
            txtmodelo.Clear();
            txtdata.Clear();
            txtcategoria.Clear();
            txtaltura.Clear();
            txtNacionalidade.Clear();
            txtpreco.Clear();
            //para voltar a cor normal caso erro
            txtmodelo.BackColor = Color.White;
            txtpreco.BackColor = Color.White;
            txtcategoria.BackColor = Color.White;
            txtNacionalidade.BackColor = Color.White;
        }


        private void salvar(empregados empregados)
        { //dados a serem salvos no banco de dados
            empregadosBll empregadosBll = new empregadosBll();
            if (txtmodelo.Text.Trim() == string.Empty || txtNacionalidade.Text.Trim() == string.Empty || txtpreco.Text.Trim() == string.Empty)
            {  //notificação de erro
                MessageBox.Show("Campos obrigatorios vazios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmodelo.BackColor = Color.Red;
                txtpreco.BackColor = Color.Red;
                txtcategoria.BackColor = Color.Red;
                txtNacionalidade.BackColor = Color.Red;
            }
            else
            {
             empregados.modelo = txtmodelo.Text;
             empregados.data = txtdata.Text;
             empregados.categoria = txtcategoria.Text;
             empregados.altura = txtaltura.Text;
             empregados.nacionalidade = txtNacionalidade.Text;
             empregados.preco = txtpreco.Text;

             empregadosBll.salvar(empregados);

             MessageBox.Show("Veiculo adicionado com sucesso");
             limparcampo();

            }

            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExibir_Click(object sender, EventArgs e) //funcao do botao exibir 
        {
            ClasseBLL bll = new ClasseBLL();

            try
            {
                dataGridView1.DataSource = bll.exibirdadosdal();
            }
            catch(Exception erro)
            {
                MessageBox.Show("erro ao exibir os dados" + erro); //mensagem de erro caso o problema seja nesse setor
            }
        
        }
        // conexao das funcoes de salvar editar e etc..
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            empregados empregados = new empregados();
            salvar(empregados);


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            empregados empregados = new empregados();
            editar(empregados);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            empregados empregados = new empregados();
            excluir(empregados);
        }
        // Editor de dados metodo 

            private void editar(empregados empregados)
        {
            if (txtmodelo.Text.Trim() == string.Empty || txtNacionalidade.Text.Trim() == string.Empty || txtpreco.Text.Trim() == string.Empty)
            {  //notificação de erro
                MessageBox.Show("Campos obrigatorios vazios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmodelo.BackColor = Color.Red;
                txtpreco.BackColor = Color.Red;
                txtcategoria.BackColor = Color.Red;
                txtNacionalidade.BackColor = Color.Red;
            }
            else
            {



                empregadosBll empregadosBll = new empregadosBll();
                empregados.id = txtID.Text;
                empregados.modelo = txtmodelo.Text;
                empregados.data = txtdata.Text;
                empregados.categoria = txtcategoria.Text;
                empregados.altura = txtaltura.Text;
                empregados.nacionalidade = txtNacionalidade.Text;
                empregados.preco = txtpreco.Text;


                empregadosBll.editar(empregados);

                MessageBox.Show("Veiculo editado com sucesso!");
                limparcampo();
            }
            

        }

        // metodo exluir ou apagar 
        private void excluir(empregados empregados)
        {
            empregadosBll empregadosBll = new empregadosBll();

            if (txtID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("selecione um veiculo para ser apagado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Tem certeza?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
            }else
            { empregados.id = txtID.Text;

                empregadosBll.excluir(empregados);

                MessageBox.Show("Veiculo excluido com sucesso");
                limparcampo();
            }
        }





        //evento de puxar os dados para o esqueleto
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmodelo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdata.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            
            txtcategoria.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtaltura.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtNacionalidade.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
            txtpreco.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
           
            
            
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparcampo();
        }

        private void crud_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
			
		}

        private void button1_Click(object sender, EventArgs e)
        {

			Close();
        }
	
	}
}
