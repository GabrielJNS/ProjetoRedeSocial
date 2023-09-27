
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
            this.caixa_nome = new System.Windows.Forms.TextBox();
            this.caixa_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.caixa_email = new System.Windows.Forms.TextBox();
            this.caixa_confirmaSenha = new System.Windows.Forms.TextBox();
            this.caixa_data = new System.Windows.Forms.TextBox();
            this.caixa_confirmaEmail = new System.Windows.Forms.TextBox();
            this.Email_mask = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // caixa_nome
            // 
            this.caixa_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_nome.Location = new System.Drawing.Point(284, 158);
            this.caixa_nome.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_nome.Name = "caixa_nome";
            this.caixa_nome.Size = new System.Drawing.Size(315, 22);
            this.caixa_nome.TabIndex = 0;
            this.caixa_nome.Text = "Tom Anjos";
            // 
            // caixa_senha
            // 
            this.caixa_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_senha.Location = new System.Drawing.Point(285, 278);
            this.caixa_senha.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_senha.Name = "caixa_senha";
            this.caixa_senha.Size = new System.Drawing.Size(313, 22);
            this.caixa_senha.TabIndex = 1;
            this.caixa_senha.Text = "1234";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de Novo Usuário";
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_cadastrar.Location = new System.Drawing.Point(273, 386);
            this.bt_cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(328, 30);
            this.bt_cadastrar.TabIndex = 3;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // caixa_email
            // 
            this.caixa_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_email.Location = new System.Drawing.Point(284, 188);
            this.caixa_email.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_email.Name = "caixa_email";
            this.caixa_email.Size = new System.Drawing.Size(315, 22);
            this.caixa_email.TabIndex = 4;
            this.caixa_email.Text = "tomanjos@gmail.com";
            this.caixa_email.TextChanged += new System.EventHandler(this.caixa_email_TextChanged);
            // 
            // caixa_confirmaSenha
            // 
            this.caixa_confirmaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_confirmaSenha.Location = new System.Drawing.Point(284, 310);
            this.caixa_confirmaSenha.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_confirmaSenha.Name = "caixa_confirmaSenha";
            this.caixa_confirmaSenha.Size = new System.Drawing.Size(315, 22);
            this.caixa_confirmaSenha.TabIndex = 5;
            this.caixa_confirmaSenha.Text = "1234";
            // 
            // caixa_data
            // 
            this.caixa_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_data.Location = new System.Drawing.Point(285, 246);
            this.caixa_data.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_data.Name = "caixa_data";
            this.caixa_data.Size = new System.Drawing.Size(315, 22);
            this.caixa_data.TabIndex = 6;
            this.caixa_data.Text = "01/02/2000";
            // 
            // caixa_confirmaEmail
            // 
            this.caixa_confirmaEmail.Location = new System.Drawing.Point(284, 217);
            this.caixa_confirmaEmail.Name = "caixa_confirmaEmail";
            this.caixa_confirmaEmail.Size = new System.Drawing.Size(314, 22);
            this.caixa_confirmaEmail.TabIndex = 7;
            this.caixa_confirmaEmail.Text = "tomanjos@gmail.com";
            this.caixa_confirmaEmail.TextChanged += new System.EventHandler(this.caixa_confirmaEmail_TextChanged);
            // 
            // Email_mask
            // 
            this.Email_mask.Location = new System.Drawing.Point(725, 158);
            this.Email_mask.Name = "Email_mask";
            this.Email_mask.Size = new System.Drawing.Size(264, 22);
            this.Email_mask.TabIndex = 8;
            this.Email_mask.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Tela_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 741);
            this.Controls.Add(this.Email_mask);
            this.Controls.Add(this.caixa_confirmaEmail);
            this.Controls.Add(this.caixa_data);
            this.Controls.Add(this.caixa_confirmaSenha);
            this.Controls.Add(this.caixa_email);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caixa_senha);
            this.Controls.Add(this.caixa_nome);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.TextBox caixa_email;
        private System.Windows.Forms.TextBox caixa_confirmaSenha;
        private System.Windows.Forms.TextBox caixa_data;
        private System.Windows.Forms.TextBox caixa_confirmaEmail;
        private System.Windows.Forms.MaskedTextBox Email_mask;
    }
}