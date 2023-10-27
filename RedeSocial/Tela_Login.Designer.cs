
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bt_logar = new System.Windows.Forms.Button();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.Caixa_email = new System.Windows.Forms.TextBox();
            this.btnMostrarSenha = new System.Windows.Forms.Button();
            this.caixaSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_logar
            // 
            this.bt_logar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_logar.BackColor = System.Drawing.Color.Transparent;
            this.bt_logar.BackgroundImage = global::RedeSocial.Properties.Resources.Login__37__removebg_preview;
            this.bt_logar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_logar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_logar.FlatAppearance.BorderSize = 0;
            this.bt_logar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_logar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_logar.Location = new System.Drawing.Point(1409, 764);
            this.bt_logar.Name = "bt_logar";
            this.bt_logar.Size = new System.Drawing.Size(221, 96);
            this.bt_logar.TabIndex = 2;
            this.bt_logar.UseVisualStyleBackColor = false;
            this.bt_logar.Click += new System.EventHandler(this.bt_logar_Click);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_cadastrar.FlatAppearance.BorderSize = 0;
            this.bt_cadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cadastrar.Location = new System.Drawing.Point(1574, 951);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(139, 20);
            this.bt_cadastrar.TabIndex = 3;
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.Bt_cadastrar_Click);
            // 
            // Caixa_email
            // 
            this.Caixa_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Caixa_email.BackColor = System.Drawing.Color.White;
            this.Caixa_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Caixa_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caixa_email.Location = new System.Drawing.Point(1300, 438);
            this.Caixa_email.Multiline = true;
            this.Caixa_email.Name = "Caixa_email";
            this.Caixa_email.Size = new System.Drawing.Size(450, 30);
            this.Caixa_email.TabIndex = 5;
            this.Caixa_email.Text = "mane@gmail.com";
            this.Caixa_email.TextChanged += new System.EventHandler(this.Caixa_email_TextChanged);
            // 
            // btnMostrarSenha
            // 
            this.btnMostrarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMostrarSenha.BackColor = System.Drawing.Color.FloralWhite;
            this.btnMostrarSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMostrarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarSenha.FlatAppearance.BorderSize = 0;
            this.btnMostrarSenha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMostrarSenha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMostrarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarSenha.Location = new System.Drawing.Point(1727, 636);
            this.btnMostrarSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarSenha.Name = "btnMostrarSenha";
            this.btnMostrarSenha.Size = new System.Drawing.Size(48, 42);
            this.btnMostrarSenha.TabIndex = 6;
            this.btnMostrarSenha.UseVisualStyleBackColor = false;
            this.btnMostrarSenha.Click += new System.EventHandler(this.btnMostrarSenha_Click);
            // 
            // caixaSenha
            // 
            this.caixaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixaSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caixaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixaSenha.Location = new System.Drawing.Point(1300, 647);
            this.caixaSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.caixaSenha.Multiline = true;
            this.caixaSenha.Name = "caixaSenha";
            this.caixaSenha.Size = new System.Drawing.Size(423, 31);
            this.caixaSenha.TabIndex = 7;
            this.caixaSenha.Text = "123";
            this.caixaSenha.TextChanged += new System.EventHandler(this.caixaSenha_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::RedeSocial.Properties.Resources.Login__40_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnMostrarSenha);
            this.Controls.Add(this.caixaSenha);
            this.Controls.Add(this.Caixa_email);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.bt_logar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_logar;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.TextBox Caixa_email;
        private System.Windows.Forms.Button btnMostrarSenha;
        private System.Windows.Forms.TextBox caixaSenha;
    }
}

