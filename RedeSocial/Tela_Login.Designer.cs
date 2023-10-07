
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
            this.caixa_senha = new System.Windows.Forms.MaskedTextBox();
            this.bt_logar = new System.Windows.Forms.Button();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.Caixa_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // caixa_senha
            // 
            this.caixa_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_senha.BackColor = System.Drawing.Color.White;
            this.caixa_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caixa_senha.Location = new System.Drawing.Point(783, 370);
            this.caixa_senha.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_senha.Name = "caixa_senha";
            this.caixa_senha.Size = new System.Drawing.Size(338, 28);
            this.caixa_senha.TabIndex = 1;
            this.caixa_senha.UseSystemPasswordChar = true;
            // 
            // bt_logar
            // 
            this.bt_logar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_logar.BackColor = System.Drawing.Color.Transparent;
            this.bt_logar.BackgroundImage = global::RedeSocial.Properties.Resources.Login__14__removebg_preview;
            this.bt_logar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_logar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_logar.FlatAppearance.BorderSize = 0;
            this.bt_logar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_logar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_logar.Location = new System.Drawing.Point(893, 452);
            this.bt_logar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_logar.Name = "bt_logar";
            this.bt_logar.Size = new System.Drawing.Size(117, 59);
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
            this.bt_cadastrar.Location = new System.Drawing.Point(979, 543);
            this.bt_cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(88, 24);
            this.bt_cadastrar.TabIndex = 3;
            this.bt_cadastrar.UseVisualStyleBackColor = false;
            this.bt_cadastrar.Click += new System.EventHandler(this.Bt_cadastrar_Click);
            // 
            // Caixa_email
            // 
            this.Caixa_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Caixa_email.BackColor = System.Drawing.Color.White;
            this.Caixa_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Caixa_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caixa_email.Location = new System.Drawing.Point(783, 251);
            this.Caixa_email.Margin = new System.Windows.Forms.Padding(4);
            this.Caixa_email.Name = "Caixa_email";
            this.Caixa_email.Size = new System.Drawing.Size(338, 28);
            this.Caixa_email.TabIndex = 5;
            this.Caixa_email.TextChanged += new System.EventHandler(this.Caixa_email_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::RedeSocial.Properties.Resources.Login__15_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.Caixa_email);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.bt_logar);
            this.Controls.Add(this.caixa_senha);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox caixa_senha;
        private System.Windows.Forms.Button bt_logar;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.TextBox Caixa_email;
    }
}

