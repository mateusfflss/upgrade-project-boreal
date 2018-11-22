namespace Crud_com_mysql
{
    partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtmodelo = new System.Windows.Forms.TextBox();
			this.txtdata = new System.Windows.Forms.TextBox();
			this.txtaltura = new System.Windows.Forms.MaskedTextBox();
			this.txtNacionalidade = new System.Windows.Forms.TextBox();
			this.txtpreco = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtcategoria = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.btnLimpar = new System.Windows.Forms.Button();
			this.btnExibir = new System.Windows.Forms.Button();
			this.btnApagar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.labMod = new System.Windows.Forms.Label();
			this.labLanca = new System.Windows.Forms.Label();
			this.labCategoria = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtmodelo
			// 
			this.txtmodelo.Location = new System.Drawing.Point(94, 98);
			this.txtmodelo.Name = "txtmodelo";
			this.txtmodelo.Size = new System.Drawing.Size(186, 20);
			this.txtmodelo.TabIndex = 2;
			this.toolTip.SetToolTip(this.txtmodelo, "Nome do funcionario");
			this.txtmodelo.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
			// 
			// txtdata
			// 
			this.txtdata.Location = new System.Drawing.Point(114, 124);
			this.txtdata.Name = "txtdata";
			this.txtdata.Size = new System.Drawing.Size(100, 20);
			this.txtdata.TabIndex = 3;
			this.toolTip.SetToolTip(this.txtdata, "idade do funcionario");
			// 
			// txtaltura
			// 
			this.txtaltura.Location = new System.Drawing.Point(94, 191);
			this.txtaltura.Mask = "0.00";
			this.txtaltura.Name = "txtaltura";
			this.txtaltura.Size = new System.Drawing.Size(100, 20);
			this.txtaltura.TabIndex = 5;
			this.toolTip.SetToolTip(this.txtaltura, "Altura do funcionario");
			// 
			// txtNacionalidade
			// 
			this.txtNacionalidade.Location = new System.Drawing.Point(106, 228);
			this.txtNacionalidade.Name = "txtNacionalidade";
			this.txtNacionalidade.Size = new System.Drawing.Size(121, 20);
			this.txtNacionalidade.TabIndex = 6;
			this.toolTip.SetToolTip(this.txtNacionalidade, "Lugar onde o funcionario nasceu");
			// 
			// txtpreco
			// 
			this.txtpreco.Location = new System.Drawing.Point(103, 265);
			this.txtpreco.Name = "txtpreco";
			this.txtpreco.Size = new System.Drawing.Size(100, 20);
			this.txtpreco.TabIndex = 7;
			this.toolTip.SetToolTip(this.txtpreco, "Quantia de salario recebido pelo funcionario");
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(16, 293);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(772, 145);
			this.dataGridView1.TabIndex = 13;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
			// 
			// txtcategoria
			// 
			this.txtcategoria.Location = new System.Drawing.Point(94, 158);
			this.txtcategoria.Name = "txtcategoria";
			this.txtcategoria.Size = new System.Drawing.Size(100, 20);
			this.txtcategoria.TabIndex = 4;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(72, 33);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(36, 20);
			this.txtID.TabIndex = 1;
			this.toolTip.SetToolTip(this.txtID, "Não Mecha");
			this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
			this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnLimpar.Location = new System.Drawing.Point(674, 191);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(114, 45);
			this.btnLimpar.TabIndex = 11;
			this.toolTip.SetToolTip(this.btnLimpar, "Limpar");
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// btnExibir
			// 
			this.btnExibir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExibir.BackgroundImage")));
			this.btnExibir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnExibir.Location = new System.Drawing.Point(674, 242);
			this.btnExibir.Name = "btnExibir";
			this.btnExibir.Size = new System.Drawing.Size(114, 45);
			this.btnExibir.TabIndex = 12;
			this.toolTip.SetToolTip(this.btnExibir, "Exibir/Atualizar");
			this.btnExibir.UseVisualStyleBackColor = true;
			this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
			// 
			// btnApagar
			// 
			this.btnApagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApagar.BackgroundImage")));
			this.btnApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnApagar.Location = new System.Drawing.Point(674, 140);
			this.btnApagar.Name = "btnApagar";
			this.btnApagar.Size = new System.Drawing.Size(114, 45);
			this.btnApagar.TabIndex = 10;
			this.toolTip.SetToolTip(this.btnApagar, "Apagar");
			this.btnApagar.UseVisualStyleBackColor = true;
			this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
			// 
			// btnEditar
			// 
			this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
			this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnEditar.Location = new System.Drawing.Point(674, 89);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(114, 45);
			this.btnEditar.TabIndex = 9;
			this.toolTip.SetToolTip(this.btnEditar, "Editar");
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
			this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
			this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSalvar.ForeColor = System.Drawing.Color.Black;
			this.btnSalvar.Location = new System.Drawing.Point(674, 38);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(114, 45);
			this.btnSalvar.TabIndex = 8;
			this.toolTip.SetToolTip(this.btnSalvar, "Salvar");
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// labMod
			// 
			this.labMod.AutoSize = true;
			this.labMod.Location = new System.Drawing.Point(16, 101);
			this.labMod.Name = "labMod";
			this.labMod.Size = new System.Drawing.Size(42, 13);
			this.labMod.TabIndex = 14;
			this.labMod.Text = "Modelo";
			// 
			// labLanca
			// 
			this.labLanca.AutoSize = true;
			this.labLanca.Location = new System.Drawing.Point(7, 127);
			this.labLanca.Name = "labLanca";
			this.labLanca.Size = new System.Drawing.Size(101, 13);
			this.labLanca.TabIndex = 15;
			this.labLanca.Text = "data de lançamento";
			// 
			// labCategoria
			// 
			this.labCategoria.AutoSize = true;
			this.labCategoria.Location = new System.Drawing.Point(21, 158);
			this.labCategoria.Name = "labCategoria";
			this.labCategoria.Size = new System.Drawing.Size(52, 13);
			this.labCategoria.TabIndex = 16;
			this.labCategoria.Text = "Categoria";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 194);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "Altura ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 235);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 13);
			this.label4.TabIndex = 18;
			this.label4.Text = "Nacionalidade";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 265);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 19;
			this.label5.Text = "Preço";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "ID";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(286, 6);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(382, 281);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.labCategoria);
			this.Controls.Add(this.labLanca);
			this.Controls.Add(this.labMod);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.txtcategoria);
			this.Controls.Add(this.btnExibir);
			this.Controls.Add(this.btnApagar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtpreco);
			this.Controls.Add(this.txtNacionalidade);
			this.Controls.Add(this.txtaltura);
			this.Controls.Add(this.txtdata);
			this.Controls.Add(this.txtmodelo);
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro - V1.6.0";
			this.Load += new System.EventHandler(this.crud_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.TextBox txtdata;
        private System.Windows.Forms.MaskedTextBox txtaltura;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labMod;
        private System.Windows.Forms.Label labLanca;
        private System.Windows.Forms.Label labCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

