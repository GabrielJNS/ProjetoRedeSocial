
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
            this.SuspendLayout();
            // 
            // caixa_nome
            // 
            this.caixa_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa_nome.Location = new System.Drawing.Point(136, 210);
            this.caixa_nome.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_nome.Name = "caixa_nome";
            this.caixa_nome.Size = new System.Drawing.Size(203, 22);
            this.caixa_nome.TabIndex = 0;
            this.caixa_nome.Text = "Tom Anjos";
            this.caixa_nome.TextChanged += new System.EventHandler(this.caixa_nome_TextChanged);
            // 
            // caixa_senha
            // 
            this.caixa_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa_senha.Location = new System.Drawing.Point(532, 358);
            this.caixa_senha.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_senha.Name = "caixa_senha";
            this.caixa_senha.Size = new System.Drawing.Size(212, 22);
            this.caixa_senha.TabIndex = 1;
            this.caixa_senha.Text = "123";
            this.caixa_senha.TextChanged += new System.EventHandler(this.caixa_senha_TextChanged);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.BackgroundImage = global::RedeSocial.Properties.Resources.Login__16__removebg_preview1;
            this.bt_cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_cadastrar.FlatAppearance.BorderSize = 0;
            this.bt_cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastrar.Location = new System.Drawing.Point(366, 478);
            this.bt_cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(153, 50);
            this.bt_cadastrar.TabIndex = 3;
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // caixa_email
            // 
            this.caixa_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa_email.Location = new System.Drawing.Point(132, 283);
            this.caixa_email.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_email.Name = "caixa_email";
            this.caixa_email.Size = new System.Drawing.Size(214, 22);
            this.caixa_email.TabIndex = 4;
            this.caixa_email.Text = "tomanjos@gmail.com";
            this.caixa_email.TextChanged += new System.EventHandler(this.caixa_email_TextChanged);
            // 
            // caixa_confirmaSenha
            // 
            this.caixa_confirmaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_confirmaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa_confirmaSenha.Location = new System.Drawing.Point(532, 434);
            this.caixa_confirmaSenha.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_confirmaSenha.Name = "caixa_confirmaSenha";
            this.caixa_confirmaSenha.Size = new System.Drawing.Size(212, 22);
            this.caixa_confirmaSenha.TabIndex = 5;
            this.caixa_confirmaSenha.Text = "123";
            // 
            // caixa_data
            // 
            this.caixa_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa_data.Location = new System.Drawing.Point(132, 434);
            this.caixa_data.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_data.Name = "caixa_data";
            this.caixa_data.Size = new System.Drawing.Size(214, 22);
            this.caixa_data.TabIndex = 6;
            this.caixa_data.Text = "09/04/2003";
            this.caixa_data.TextChanged += new System.EventHandler(this.caixa_data_TextChanged);
            // 
            // caixa_confirmaEmail
            // 
            this.caixa_confirmaEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa_confirmaEmail.Location = new System.Drawing.Point(132, 358);
            this.caixa_confirmaEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.caixa_confirmaEmail.Name = "caixa_confirmaEmail";
            this.caixa_confirmaEmail.Size = new System.Drawing.Size(214, 22);
            this.caixa_confirmaEmail.TabIndex = 7;
            this.caixa_confirmaEmail.Text = "tomanjos@gmail.com";
            this.caixa_confirmaEmail.TextChanged += new System.EventHandler(this.caixa_confirmaEmail_TextChanged);
            // 
            // Tela_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::RedeSocial.Properties.Resources.Login__31_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1181, 603);
            this.Controls.Add(this.caixa_data);
            this.Controls.Add(this.caixa_confirmaEmail);
            this.Controls.Add(this.caixa_confirmaSenha);
            this.Controls.Add(this.caixa_email);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.caixa_senha);
            this.Controls.Add(this.caixa_nome);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tela_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Cadastro";
            this.Load += new System.EventHandler(this.Tela_Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caixa_nome;
        private System.Windows.Forms.TextBox caixa_senha;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.TextBox caixa_email;
        private System.Windows.Forms.TextBox caixa_confirmaSenha;
        private System.Windows.Forms.TextBox caixa_data;
        private System.Windows.Forms.TextBox caixa_confirmaEmail;
    }
}