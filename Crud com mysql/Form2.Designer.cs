namespace Crud_com_mysql
{
    partial class Form2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.labUser = new System.Windows.Forms.Label();
			this.labSenha = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblnivel = new System.Windows.Forms.Label();
			this.txtnivel = new System.Windows.Forms.TextBox();
			this.btnform = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// labUser
			// 
			this.labUser.AutoSize = true;
			this.labUser.Location = new System.Drawing.Point(36, 40);
			this.labUser.Name = "labUser";
			this.labUser.Size = new System.Drawing.Size(54, 13);
			this.labUser.TabIndex = 0;
			this.labUser.Text = "Usuario:";
			// 
			// labSenha
			// 
			this.labSenha.AutoSize = true;
			this.labSenha.Location = new System.Drawing.Point(42, 110);
			this.labSenha.Name = "labSenha";
			this.labSenha.Size = new System.Drawing.Size(47, 13);
			this.labSenha.TabIndex = 1;
			this.labSenha.Text = "Senha:";
			// 
			// txtUser
			// 
			this.txtUser.BackColor = System.Drawing.SystemColors.Menu;
			this.txtUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.txtUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txtUser.Location = new System.Drawing.Point(97, 37);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(116, 20);
			this.txtUser.TabIndex = 2;
			// 
			// txtSenha
			// 
			this.txtSenha.BackColor = System.Drawing.SystemColors.Info;
			this.txtSenha.Location = new System.Drawing.Point(97, 110);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.PasswordChar = '*';
			this.txtSenha.Size = new System.Drawing.Size(116, 20);
			this.txtSenha.TabIndex = 3;
			this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnLogin.Location = new System.Drawing.Point(97, 232);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(87, 23);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(389, 1);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(494, 374);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(111, 258);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 13);
			this.label3.TabIndex = 6;
			// 
			// lblnivel
			// 
			this.lblnivel.AutoSize = true;
			this.lblnivel.Location = new System.Drawing.Point(50, 172);
			this.lblnivel.Name = "lblnivel";
			this.lblnivel.Size = new System.Drawing.Size(40, 13);
			this.lblnivel.TabIndex = 7;
			this.lblnivel.Text = "Nivel:";
			// 
			// txtnivel
			// 
			this.txtnivel.BackColor = System.Drawing.SystemColors.Menu;
			this.txtnivel.Location = new System.Drawing.Point(97, 169);
			this.txtnivel.Name = "txtnivel";
			this.txtnivel.Size = new System.Drawing.Size(67, 20);
			this.txtnivel.TabIndex = 11;
			// 
			// btnform
			// 
			this.btnform.Location = new System.Drawing.Point(271, 232);
			this.btnform.Name = "btnform";
			this.btnform.Size = new System.Drawing.Size(87, 23);
			this.btnform.TabIndex = 13;
			this.btnform.Text = "PUBLICO";
			this.btnform.UseVisualStyleBackColor = true;
			this.btnform.Click += new System.EventHandler(this.btnform_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(884, 376);
			this.Controls.Add(this.btnform);
			this.Controls.Add(this.txtnivel);
			this.Controls.Add(this.lblnivel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.labSenha);
			this.Controls.Add(this.labUser);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Form2";
			this.Text = "Boreal project";
			this.TransparencyKey = System.Drawing.Color.Transparent;
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.Label labSenha;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblnivel;
		private System.Windows.Forms.TextBox txtnivel;
		private System.Windows.Forms.Button btnform;
	}
}