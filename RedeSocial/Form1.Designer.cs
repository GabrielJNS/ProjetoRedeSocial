
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // caixa_nome
            // 
            this.caixa_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_nome.Location = new System.Drawing.Point(172, 131);
            this.caixa_nome.Name = "caixa_nome";
            this.caixa_nome.Size = new System.Drawing.Size(224, 20);
            this.caixa_nome.TabIndex = 0;
            // 
            // caixa_senha
            // 
            this.caixa_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_senha.Location = new System.Drawing.Point(172, 198);
            this.caixa_senha.Name = "caixa_senha";
            this.caixa_senha.Size = new System.Drawing.Size(223, 20);
            this.caixa_senha.TabIndex = 1;
            // 
            // bt_logar
            // 
            this.bt_logar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_logar.Location = new System.Drawing.Point(156, 251);
            this.bt_logar.Name = "bt_logar";
            this.bt_logar.Size = new System.Drawing.Size(257, 68);
            this.bt_logar.TabIndex = 2;
            this.bt_logar.Text = "Login";
            this.bt_logar.UseVisualStyleBackColor = true;
            this.bt_logar.Click += new System.EventHandler(this.bt_logar_Click);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_cadastrar.Location = new System.Drawing.Point(154, 347);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(258, 71);
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
            this.label1.Location = new System.Drawing.Point(180, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vetor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Posição do Usuário no Vetor";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.bt_logar);
            this.Controls.Add(this.caixa_senha);
            this.Controls.Add(this.caixa_nome);
            this.Name = "Login";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

