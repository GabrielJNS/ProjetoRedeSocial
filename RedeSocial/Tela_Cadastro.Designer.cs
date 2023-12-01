
namespace RedeSocial
{
    partial class Tela_Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Cadastro));
            this.caixa_nome = new System.Windows.Forms.TextBox();
            this.caixa_senha = new System.Windows.Forms.TextBox();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.caixa_email = new System.Windows.Forms.TextBox();
            this.caixa_confirmaSenha = new System.Windows.Forms.TextBox();
            this.caixa_data = new System.Windows.Forms.TextBox();
            this.caixa_confirmaEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sair = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // caixa_nome
            // 
            this.caixa_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caixa_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa_nome.Location = new System.Drawing.Point(61, 152);
            this.caixa_nome.Multiline = true;
            this.caixa_nome.Name = "caixa_nome";
            this.caixa_nome.Size = new System.Drawing.Size(229, 27);
            this.caixa_nome.TabIndex = 0;
            this.caixa_nome.Text = "Tom Anjos";
            this.caixa_nome.TextChanged += new System.EventHandler(this.caixa_nome_TextChanged);
            // 
            // caixa_senha
            // 
            this.caixa_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caixa_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa_senha.Location = new System.Drawing.Point(374, 272);
            this.caixa_senha.Multiline = true;
            this.caixa_senha.Name = "caixa_senha";
            this.caixa_senha.Size = new System.Drawing.Size(233, 27);
            this.caixa_senha.TabIndex = 1;
            this.caixa_senha.Text = "123";
            this.caixa_senha.TextChanged += new System.EventHandler(this.caixa_senha_TextChanged);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_cadastrar.FlatAppearance.BorderSize = 0;
            this.bt_cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastrar.Location = new System.Drawing.Point(197, 494);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(250, 50);
            this.bt_cadastrar.TabIndex = 3;
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // caixa_email
            // 
            this.caixa_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caixa_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa_email.Location = new System.Drawing.Point(61, 272);
            this.caixa_email.Multiline = true;
            this.caixa_email.Name = "caixa_email";
            this.caixa_email.Size = new System.Drawing.Size(229, 27);
            this.caixa_email.TabIndex = 4;
            this.caixa_email.Text = "tomanjos@gmail.com";
            this.caixa_email.TextChanged += new System.EventHandler(this.caixa_email_TextChanged);
            // 
            // caixa_confirmaSenha
            // 
            this.caixa_confirmaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_confirmaSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caixa_confirmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa_confirmaSenha.Location = new System.Drawing.Point(374, 411);
            this.caixa_confirmaSenha.Name = "caixa_confirmaSenha";
            this.caixa_confirmaSenha.Size = new System.Drawing.Size(233, 22);
            this.caixa_confirmaSenha.TabIndex = 5;
            this.caixa_confirmaSenha.Text = "123";
            this.caixa_confirmaSenha.TextChanged += new System.EventHandler(this.caixa_confirmaSenha_TextChanged);
            // 
            // caixa_data
            // 
            this.caixa_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caixa_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa_data.Location = new System.Drawing.Point(374, 152);
            this.caixa_data.Name = "caixa_data";
            this.caixa_data.Size = new System.Drawing.Size(229, 22);
            this.caixa_data.TabIndex = 6;
            this.caixa_data.Text = "09/04/2003";
            this.caixa_data.TextChanged += new System.EventHandler(this.caixa_data_TextChanged);
            // 
            // caixa_confirmaEmail
            // 
            this.caixa_confirmaEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caixa_confirmaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa_confirmaEmail.Location = new System.Drawing.Point(61, 405);
            this.caixa_confirmaEmail.Margin = new System.Windows.Forms.Padding(2);
            this.caixa_confirmaEmail.Multiline = true;
            this.caixa_confirmaEmail.Name = "caixa_confirmaEmail";
            this.caixa_confirmaEmail.Size = new System.Drawing.Size(229, 28);
            this.caixa_confirmaEmail.TabIndex = 7;
            this.caixa_confirmaEmail.Text = "tomanjos@gmail.com";
            this.caixa_confirmaEmail.TextChanged += new System.EventHandler(this.caixa_confirmaEmail_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RedeSocial.Properties.Resources.Group_162;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Sair);
            this.panel1.Controls.Add(this.toolStripContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.Sair.Location = new System.Drawing.Point(1184, 30);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(35, 40);
            this.Sair.TabIndex = 55;
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.caixa_senha);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.caixa_nome);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.caixa_data);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.caixa_email);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.caixa_confirmaEmail);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.bt_cadastrar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.caixa_confirmaSenha);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(631, 558);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(600, 76);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(631, 558);
            this.toolStripContainer1.TabIndex = 8;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            this.toolStripContainer1.Click += new System.EventHandler(this.toolStripContainer1_Click);
            // 
            // Tela_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::RedeSocial.Properties.Resources.Group_16;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Cadastro";
            this.Load += new System.EventHandler(this.Tela_Cadastro_Load);
            this.panel1.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox caixa_nome;
        private System.Windows.Forms.TextBox caixa_senha;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.TextBox caixa_email;
        private System.Windows.Forms.TextBox caixa_confirmaSenha;
        private System.Windows.Forms.TextBox caixa_data;
        private System.Windows.Forms.TextBox caixa_confirmaEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button Sair;
    }
}