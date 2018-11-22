using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_com_mysql
{
	public partial class Form3 : Form
	{
		private object txtmodelo;
		private object txtdata;
		private object txtcategoria;
		private object txtaltura;
		private object txtNacionalidade;
		private object txtpreco;
		private object txtID;

		public Form3()
		{
			InitializeComponent();
		}
		private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			txtmodelo = dataGridView1.CurrentRow.Cells[1].Value.ToString();
			txtdata = dataGridView1.CurrentRow.Cells[2].Value.ToString();

			txtcategoria = dataGridView1.CurrentRow.Cells[3].Value.ToString();
			txtaltura = dataGridView1.CurrentRow.Cells[4].Value.ToString();
			txtNacionalidade = dataGridView1.CurrentRow.Cells[5].Value.ToString();

			txtpreco = dataGridView1.CurrentRow.Cells[6].Value.ToString();



			txtID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnexibir_Click(object sender, EventArgs e)
		{
			ClasseBLL bll = new ClasseBLL();

			try
			{
				dataGridView1.DataSource = bll.exibirdadosdal();
			}
			catch (Exception erro)
			{
				MessageBox.Show("erro ao exibir os dados" + erro); //mensagem de erro caso o problema seja nesse setor
			}
		}
	}
}
