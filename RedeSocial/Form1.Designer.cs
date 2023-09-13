
namespace RedeSocial
{
    partial class Login
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
            this.caixa_nome = new System.Windows.Forms.TextBox();
            this.caixa_senha = new System.Windows.Forms.MaskedTextBox();
            this.bt_logar = new System.Windows.Forms.Button();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Vetor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // caixa_nome
            // 
            this.caixa_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_nome.Location = new System.Drawing.Point(229, 161);
            this.caixa_nome.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_nome.Name = "caixa_nome";
            this.caixa_nome.Size = new System.Drawing.Size(297, 22);
            this.caixa_nome.TabIndex = 0;
            // 
            // caixa_senha
            // 
            this.caixa_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_senha.Location = new System.Drawing.Point(229, 244);
            this.caixa_senha.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_senha.Name = "caixa_senha";
            this.caixa_senha.Size = new System.Drawing.Size(296, 22);
            this.caixa_senha.TabIndex = 1;
            this.caixa_senha.UseSystemPasswordChar = true;
            // 
            // bt_logar
            // 
            this.bt_logar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_logar.Location = new System.Drawing.Point(208, 309);
            this.bt_logar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_logar.Name = "bt_logar";
            this.bt_logar.Size = new System.Drawing.Size(343, 84);
            this.bt_logar.TabIndex = 2;
            this.bt_logar.Text = "Login";
            this.bt_logar.UseVisualStyleBackColor = true;
            this.bt_logar.Click += new System.EventHandler(this.bt_logar_Click);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_cadastrar.Location = new System.Drawing.Point(205, 427);
            this.bt_cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(344, 87);
            this.bt_cadastrar.TabIndex = 3;
            this.bt_cadastrar.Text = "Cadastrar";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.Bt_cadastrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // label_Vetor
            // 
            this.label_Vetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Vetor.AutoSize = true;
            this.label_Vetor.Location = new System.Drawing.Point(453, 396);
            this.label_Vetor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Vetor.Name = "label_Vetor";
            this.label_Vetor.Size = new System.Drawing.Size(40, 16);
            this.label_Vetor.TabIndex = 5;
            this.label_Vetor.Text = "Vetor";
            this.label_Vetor.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 396);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Posição do Usuário no Vetor";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 578);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Vetor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.bt_logar);
            this.Controls.Add(this.caixa_senha);
            this.Controls.Add(this.caixa_nome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caixa_nome;
        private System.Windows.Forms.MaskedTextBox caixa_senha;
        private System.Windows.Forms.Button bt_logar;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Vetor;
        private System.Windows.Forms.Label label3;
    }
}

