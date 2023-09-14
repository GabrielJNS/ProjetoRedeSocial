
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
            this.components = new System.ComponentModel.Container();
            this.caixa_nome = new System.Windows.Forms.TextBox();
            this.caixa_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.caixa_email = new System.Windows.Forms.TextBox();
            this.caixa_confirmaSenha = new System.Windows.Forms.TextBox();
            this.caixa_data = new System.Windows.Forms.TextBox();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btEnviarFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // caixa_nome
            // 
            this.caixa_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_nome.Location = new System.Drawing.Point(731, 252);
            this.caixa_nome.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_nome.Name = "caixa_nome";
            this.caixa_nome.Size = new System.Drawing.Size(315, 22);
            this.caixa_nome.TabIndex = 0;
            this.caixa_nome.Text = "Nome";
            // 
            // caixa_senha
            // 
            this.caixa_senha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.caixa_senha.Location = new System.Drawing.Point(729, 426);
            this.caixa_senha.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_senha.Name = "caixa_senha";
            this.caixa_senha.Size = new System.Drawing.Size(313, 22);
            this.caixa_senha.TabIndex = 1;
            this.caixa_senha.Text = "Senha";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(639, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de Novo Usuário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_cadastrar.Location = new System.Drawing.Point(728, 537);
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
            this.caixa_email.Location = new System.Drawing.Point(731, 304);
            this.caixa_email.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_email.Name = "caixa_email";
            this.caixa_email.Size = new System.Drawing.Size(315, 22);
            this.caixa_email.TabIndex = 4;
            this.caixa_email.Text = "E-Mail";
            // 
            // caixa_confirmaSenha
            // 
            this.caixa_confirmaSenha.Location = new System.Drawing.Point(728, 480);
            this.caixa_confirmaSenha.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_confirmaSenha.Name = "caixa_confirmaSenha";
            this.caixa_confirmaSenha.Size = new System.Drawing.Size(315, 22);
            this.caixa_confirmaSenha.TabIndex = 5;
            this.caixa_confirmaSenha.Text = "Confirmar Senha";
            // 
            // caixa_data
            // 
            this.caixa_data.Location = new System.Drawing.Point(729, 359);
            this.caixa_data.Margin = new System.Windows.Forms.Padding(4);
            this.caixa_data.Name = "caixa_data";
            this.caixa_data.Size = new System.Drawing.Size(315, 22);
            this.caixa_data.TabIndex = 6;
            this.caixa_data.Text = "Data de Nascimento";
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.Location = new System.Drawing.Point(595, 426);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(101, 56);
            this.btnSelecionarImagem.TabIndex = 7;
            this.btnSelecionarImagem.Text = "Carregar foto de perfil";
            this.btnSelecionarImagem.UseVisualStyleBackColor = true;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.btnSelecionarImagem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(499, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 130);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btEnviarFoto
            // 
            this.btEnviarFoto.Location = new System.Drawing.Point(484, 426);
            this.btEnviarFoto.Name = "btEnviarFoto";
            this.btEnviarFoto.Size = new System.Drawing.Size(105, 56);
            this.btEnviarFoto.TabIndex = 9;
            this.btEnviarFoto.Text = "Enviar foto de perfil";
            this.btEnviarFoto.UseVisualStyleBackColor = true;
            this.btEnviarFoto.Click += new System.EventHandler(this.btEnviarFoto_Click);
            // 
            // Tela_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 1028);
            this.Controls.Add(this.btEnviarFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelecionarImagem);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnSelecionarImagem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btEnviarFoto;
    }
}