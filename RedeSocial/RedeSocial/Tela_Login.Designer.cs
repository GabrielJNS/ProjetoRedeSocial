
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
            this.bt_logar = new System.Windows.Forms.Button();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.label_Vetor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Senha = new System.Windows.Forms.Button();
            this.caixa_senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // caixa_nome
            // 
            this.caixa_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_nome.BackColor = System.Drawing.Color.White;
            this.caixa_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa_nome.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa_nome.Location = new System.Drawing.Point(787, 254);
            this.caixa_nome.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_nome.Name = "caixa_nome";
            this.caixa_nome.Size = new System.Drawing.Size(341, 28);
            this.caixa_nome.TabIndex = 0;
            this.caixa_nome.TextChanged += new System.EventHandler(this.caixa_nome_TextChanged);
            // 
            // bt_logar
            // 
            this.bt_logar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_logar.BackColor = System.Drawing.Color.Transparent;
            this.bt_logar.BackgroundImage = global::RedeSocial.Properties.Resources.Login__14__removebg_preview;
            this.bt_logar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_logar.FlatAppearance.BorderSize = 0;
            this.bt_logar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_logar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_logar.Location = new System.Drawing.Point(829, 453);
            this.bt_logar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_logar.Name = "bt_logar";
            this.bt_logar.Size = new System.Drawing.Size(189, 69);
            this.bt_logar.TabIndex = 2;
            this.bt_logar.UseVisualStyleBackColor = false;
            this.bt_logar.Click += new System.EventHandler(this.bt_logar_Click);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cadastrar.FlatAppearance.BorderSize = 0;
            this.bt_cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastrar.Location = new System.Drawing.Point(981, 542);
            this.bt_cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(87, 23);
            this.bt_cadastrar.TabIndex = 3;
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.Bt_cadastrar_Click);
            // 
            // label_Vetor
            // 
            this.label_Vetor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Vetor.AutoSize = true;
            this.label_Vetor.BackColor = System.Drawing.Color.Transparent;
            this.label_Vetor.ForeColor = System.Drawing.Color.Transparent;
            this.label_Vetor.Location = new System.Drawing.Point(843, 577);
            this.label_Vetor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Vetor.Name = "label_Vetor";
            this.label_Vetor.Size = new System.Drawing.Size(42, 17);
            this.label_Vetor.TabIndex = 5;
            this.label_Vetor.Text = "Vetor";
            this.label_Vetor.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(646, 577);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Posição do Usuário no Vetor";
            // 
            // bt_Senha
            // 
            this.bt_Senha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Senha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Senha.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_Senha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_Senha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_Senha.ForeColor = System.Drawing.Color.White;
            this.bt_Senha.Image = global::RedeSocial.Properties.Resources.olho_aberto;
            this.bt_Senha.Location = new System.Drawing.Point(1091, 368);
            this.bt_Senha.Name = "bt_Senha";
            this.bt_Senha.Size = new System.Drawing.Size(37, 27);
            this.bt_Senha.TabIndex = 7;
            this.bt_Senha.UseVisualStyleBackColor = false;
            this.bt_Senha.Click += new System.EventHandler(this.bt_Senha_Click);
            // 
            // caixa_senha
            // 
            this.caixa_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_senha.BackColor = System.Drawing.Color.White;
            this.caixa_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa_senha.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa_senha.Location = new System.Drawing.Point(787, 368);
            this.caixa_senha.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_senha.Name = "caixa_senha";
            this.caixa_senha.Size = new System.Drawing.Size(341, 28);
            this.caixa_senha.TabIndex = 8;
            this.caixa_senha.TextChanged += new System.EventHandler(this.caixa_senha_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::RedeSocial.Properties.Resources.Login__15_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.bt_Senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Vetor);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.bt_logar);
            this.Controls.Add(this.caixa_nome);
            this.Controls.Add(this.caixa_senha);
            this.DoubleBuffered = true;
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
        private System.Windows.Forms.Button bt_logar;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Label label_Vetor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_Senha;
        private System.Windows.Forms.TextBox caixa_senha;
    }
}

