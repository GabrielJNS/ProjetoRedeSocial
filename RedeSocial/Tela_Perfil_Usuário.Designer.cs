
namespace RedeSocial
{
    partial class Tela_Perfil
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
            Tela_Principal novo = new Tela_Principal();
            if (disposing && (components != null))
            {
                components.Dispose();
                novo.Show();

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
            this.components = new System.ComponentModel.Container();
            this.Label_Nome = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_Id = new System.Windows.Forms.Label();
            this.Label_Data = new System.Windows.Forms.Label();
            this.Label_email = new System.Windows.Forms.Label();
            this.Label_name = new System.Windows.Forms.Label();
            this.foto_perfil = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1_foto_perfil = new System.Windows.Forms.OpenFileDialog();
            this.bt_alterar_dados = new System.Windows.Forms.Button();
            this.bt_Foto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDescricao_user = new System.Windows.Forms.TextBox();
            this.btnSalvarDescricao = new System.Windows.Forms.Button();
            this.Label_Descricao = new System.Windows.Forms.Label();
            this.bt_Excluir_Conta = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            ((System.ComponentModel.ISupportInitialize)(this.foto_perfil)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Nome
            // 
            this.Label_Nome.AutoSize = true;
            this.Label_Nome.BackColor = System.Drawing.Color.Transparent;
            this.Label_Nome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nome.Location = new System.Drawing.Point(40, 419);
            this.Label_Nome.Name = "Label_Nome";
            this.Label_Nome.Size = new System.Drawing.Size(159, 19);
            this.Label_Nome.TabIndex = 1;
            this.Label_Nome.Text = "Nome Usuário Amigo";
            this.Label_Nome.Click += new System.EventHandler(this.Label_Nome_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Nascimento:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "E-Mail:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Label_Id
            // 
            this.Label_Id.AutoSize = true;
            this.Label_Id.BackColor = System.Drawing.Color.Transparent;
            this.Label_Id.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Id.Location = new System.Drawing.Point(239, 294);
            this.Label_Id.Name = "Label_Id";
            this.Label_Id.Size = new System.Drawing.Size(17, 13);
            this.Label_Id.TabIndex = 6;
            this.Label_Id.Text = "ID";
            this.Label_Id.Click += new System.EventHandler(this.Label_Id_Click);
            // 
            // Label_Data
            // 
            this.Label_Data.AutoSize = true;
            this.Label_Data.BackColor = System.Drawing.Color.Transparent;
            this.Label_Data.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Data.Location = new System.Drawing.Point(236, 379);
            this.Label_Data.Name = "Label_Data";
            this.Label_Data.Size = new System.Drawing.Size(30, 13);
            this.Label_Data.TabIndex = 7;
            this.Label_Data.Text = "Data";
            this.Label_Data.Click += new System.EventHandler(this.Label_Data_Click);
            // 
            // Label_email
            // 
            this.Label_email.AutoSize = true;
            this.Label_email.BackColor = System.Drawing.Color.Transparent;
            this.Label_email.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_email.Location = new System.Drawing.Point(223, 339);
            this.Label_email.Name = "Label_email";
            this.Label_email.Size = new System.Drawing.Size(45, 13);
            this.Label_email.TabIndex = 8;
            this.Label_email.Text = "Usuário";
            this.Label_email.Click += new System.EventHandler(this.Label_email_Click);
            // 
            // Label_name
            // 
            this.Label_name.AutoSize = true;
            this.Label_name.BackColor = System.Drawing.Color.Transparent;
            this.Label_name.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_name.Location = new System.Drawing.Point(286, 52);
            this.Label_name.Name = "Label_name";
            this.Label_name.Size = new System.Drawing.Size(138, 42);
            this.Label_name.TabIndex = 9;
            this.Label_name.Text = "Usuário";
            this.Label_name.Click += new System.EventHandler(this.Label_name_Click);
            // 
            // foto_perfil
            // 
            this.foto_perfil.BackColor = System.Drawing.Color.Transparent;
            this.foto_perfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foto_perfil.Location = new System.Drawing.Point(44, 52);
            this.foto_perfil.Name = "foto_perfil";
            this.foto_perfil.Size = new System.Drawing.Size(200, 177);
            this.foto_perfil.TabIndex = 10;
            this.foto_perfil.TabStop = false;
            this.foto_perfil.Click += new System.EventHandler(this.foto_perfil_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(44, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Alterar Foto Perfil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1_foto_perfil
            // 
            this.openFileDialog1_foto_perfil.FileName = "openFileDialog1_foto_perfil";
            this.openFileDialog1_foto_perfil.Filter = "JPEG(*.jpeg)|*.jpeg|PNG(*.png)|*.png|JPG(*.jpg)|*.jpg";
            // 
            // bt_alterar_dados
            // 
            this.bt_alterar_dados.BackColor = System.Drawing.Color.Transparent;
            this.bt_alterar_dados.BackgroundImage = global::RedeSocial.Properties.Resources._5525275;
            this.bt_alterar_dados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_alterar_dados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_alterar_dados.FlatAppearance.BorderSize = 0;
            this.bt_alterar_dados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_alterar_dados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_alterar_dados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_alterar_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_alterar_dados.Location = new System.Drawing.Point(142, 451);
            this.bt_alterar_dados.Name = "bt_alterar_dados";
            this.bt_alterar_dados.Size = new System.Drawing.Size(57, 47);
            this.bt_alterar_dados.TabIndex = 12;
            this.bt_alterar_dados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_alterar_dados.UseVisualStyleBackColor = false;
            this.bt_alterar_dados.Click += new System.EventHandler(this.bt_alterar_dados_Click);
            // 
            // bt_Foto
            // 
            this.bt_Foto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bt_Foto.BackColor = System.Drawing.Color.Transparent;
            this.bt_Foto.BackgroundImage = global::RedeSocial.Properties.Resources.icons8_câmera_100__4_;
            this.bt_Foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Foto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Foto.FlatAppearance.BorderSize = 0;
            this.bt_Foto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_Foto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_Foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Foto.Location = new System.Drawing.Point(59, 452);
            this.bt_Foto.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Foto.Name = "bt_Foto";
            this.bt_Foto.Size = new System.Drawing.Size(49, 46);
            this.bt_Foto.TabIndex = 37;
            this.bt_Foto.UseVisualStyleBackColor = false;
            this.bt_Foto.Click += new System.EventHandler(this.bt_Foto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Minhas fotos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Alterar Dados";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxDescricao_user
            // 
            this.textBoxDescricao_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescricao_user.Location = new System.Drawing.Point(293, 119);
            this.textBoxDescricao_user.Multiline = true;
            this.textBoxDescricao_user.Name = "textBoxDescricao_user";
            this.textBoxDescricao_user.Size = new System.Drawing.Size(469, 110);
            this.textBoxDescricao_user.TabIndex = 40;
            this.textBoxDescricao_user.TextChanged += new System.EventHandler(this.textBoxDescricao_TextChanged);
            // 
            // btnSalvarDescricao
            // 
            this.btnSalvarDescricao.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarDescricao.Location = new System.Drawing.Point(707, 205);
            this.btnSalvarDescricao.Name = "btnSalvarDescricao";
            this.btnSalvarDescricao.Size = new System.Drawing.Size(53, 23);
            this.btnSalvarDescricao.TabIndex = 41;
            this.btnSalvarDescricao.Text = "Salvar";
            this.btnSalvarDescricao.UseVisualStyleBackColor = true;
            this.btnSalvarDescricao.Click += new System.EventHandler(this.btnSalvarDescricao_Click);
            // 
            // Label_Descricao
            // 
            this.Label_Descricao.AutoSize = true;
            this.Label_Descricao.BackColor = System.Drawing.Color.Transparent;
            this.Label_Descricao.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Descricao.Location = new System.Drawing.Point(290, 101);
            this.Label_Descricao.Name = "Label_Descricao";
            this.Label_Descricao.Size = new System.Drawing.Size(60, 14);
            this.Label_Descricao.TabIndex = 42;
            this.Label_Descricao.Text = "Descrição";
            this.Label_Descricao.Click += new System.EventHandler(this.Label_Descricao_Click);
            // 
            // bt_Excluir_Conta
            // 
            this.bt_Excluir_Conta.BackColor = System.Drawing.Color.Transparent;
            this.bt_Excluir_Conta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Excluir_Conta.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Excluir_Conta.Location = new System.Drawing.Point(44, 541);
            this.bt_Excluir_Conta.Name = "bt_Excluir_Conta";
            this.bt_Excluir_Conta.Size = new System.Drawing.Size(200, 32);
            this.bt_Excluir_Conta.TabIndex = 43;
            this.bt_Excluir_Conta.Text = "Excluir Conta";
            this.bt_Excluir_Conta.UseVisualStyleBackColor = false;
            this.bt_Excluir_Conta.Click += new System.EventHandler(this.bt_Excluir_Conta_Click);
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.Transparent;
            this.Sair.BackgroundImage = global::RedeSocial.Properties.Resources.icons8_fechar_64__2_;
            this.Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sair.FlatAppearance.BorderSize = 0;
            this.Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Location = new System.Drawing.Point(1200, 12);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(35, 40);
            this.Sair.TabIndex = 44;
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.foto_perfil);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Label_Nome);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnSalvarDescricao);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.bt_Excluir_Conta);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label3);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Label_Descricao);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label4);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Label_Id);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.textBoxDescricao_user);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Label_Data);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label6);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Label_email);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label5);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Label_name);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.bt_Foto);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.bt_alterar_dados);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(948, 602);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(241, 81);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(948, 602);
            this.toolStripContainer1.TabIndex = 45;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // Tela_Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RedeSocial.Properties.Resources.generica2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Tela_Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Perfil";
            this.Load += new System.EventHandler(this.Tela_Perfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto_perfil)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_Nome;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label_Id;
        private System.Windows.Forms.Label Label_Data;
        private System.Windows.Forms.Label Label_email;
        private System.Windows.Forms.Label Label_name;
        private System.Windows.Forms.PictureBox foto_perfil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1_foto_perfil;
        private System.Windows.Forms.Button bt_alterar_dados;
        private System.Windows.Forms.Button bt_Foto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDescricao_user;
        private System.Windows.Forms.Button btnSalvarDescricao;
        private System.Windows.Forms.Label Label_Descricao;
        private System.Windows.Forms.Button bt_Excluir_Conta;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}