
namespace RedeSocial
{
    partial class Tela_Criar_Comunidades
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
            Tela_Principal nova = new Tela_Principal();
            nova.Show();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bt_Criar_Comunidade = new System.Windows.Forms.Button();
            this.bt_Voltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nome_Comunidade = new System.Windows.Forms.TextBox();
            this.Bt_Carrega_Imagem = new System.Windows.Forms.Button();
            this.Picture_Imagem_Comunidade = new System.Windows.Forms.PictureBox();
            this.Text_Box_Descricao = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Imagem_Comunidade)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt_Criar_Comunidade
            // 
            this.Bt_Criar_Comunidade.BackColor = System.Drawing.Color.LimeGreen;
            this.Bt_Criar_Comunidade.Location = new System.Drawing.Point(514, 399);
            this.Bt_Criar_Comunidade.Name = "Bt_Criar_Comunidade";
            this.Bt_Criar_Comunidade.Size = new System.Drawing.Size(140, 39);
            this.Bt_Criar_Comunidade.TabIndex = 0;
            this.Bt_Criar_Comunidade.Text = "Criar Comunidade";
            this.Bt_Criar_Comunidade.UseVisualStyleBackColor = false;
            this.Bt_Criar_Comunidade.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Voltar
            // 
            this.bt_Voltar.BackColor = System.Drawing.Color.Red;
            this.bt_Voltar.Location = new System.Drawing.Point(674, 399);
            this.bt_Voltar.Name = "bt_Voltar";
            this.bt_Voltar.Size = new System.Drawing.Size(140, 39);
            this.bt_Voltar.TabIndex = 1;
            this.bt_Voltar.Text = "Voltar";
            this.bt_Voltar.UseVisualStyleBackColor = false;
            this.bt_Voltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Comunidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição Comunidade";
            // 
            // Nome_Comunidade
            // 
            this.Nome_Comunidade.Location = new System.Drawing.Point(84, 120);
            this.Nome_Comunidade.Name = "Nome_Comunidade";
            this.Nome_Comunidade.Size = new System.Drawing.Size(277, 20);
            this.Nome_Comunidade.TabIndex = 5;
            // 
            // Bt_Carrega_Imagem
            // 
            this.Bt_Carrega_Imagem.BackColor = System.Drawing.Color.LimeGreen;
            this.Bt_Carrega_Imagem.Location = new System.Drawing.Point(559, 268);
            this.Bt_Carrega_Imagem.Name = "Bt_Carrega_Imagem";
            this.Bt_Carrega_Imagem.Size = new System.Drawing.Size(189, 23);
            this.Bt_Carrega_Imagem.TabIndex = 7;
            this.Bt_Carrega_Imagem.Text = "Imagem Comunidade";
            this.Bt_Carrega_Imagem.UseVisualStyleBackColor = false;
            this.Bt_Carrega_Imagem.Click += new System.EventHandler(this.Bt_Carrega_Imagem_Click);
            // 
            // Picture_Imagem_Comunidade
            // 
            this.Picture_Imagem_Comunidade.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Imagem_Comunidade.Location = new System.Drawing.Point(529, 93);
            this.Picture_Imagem_Comunidade.Name = "Picture_Imagem_Comunidade";
            this.Picture_Imagem_Comunidade.Size = new System.Drawing.Size(233, 169);
            this.Picture_Imagem_Comunidade.TabIndex = 8;
            this.Picture_Imagem_Comunidade.TabStop = false;
            this.Picture_Imagem_Comunidade.Click += new System.EventHandler(this.Picture_Imagem_Comunidade_Click);
            // 
            // Text_Box_Descricao
            // 
            this.Text_Box_Descricao.Location = new System.Drawing.Point(70, 332);
            this.Text_Box_Descricao.Name = "Text_Box_Descricao";
            this.Text_Box_Descricao.Size = new System.Drawing.Size(744, 61);
            this.Text_Box_Descricao.TabIndex = 9;
            this.Text_Box_Descricao.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Tela_Criar_Comunidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RedeSocial.Properties.Resources.Login__42_;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Text_Box_Descricao);
            this.Controls.Add(this.Picture_Imagem_Comunidade);
            this.Controls.Add(this.Bt_Carrega_Imagem);
            this.Controls.Add(this.Nome_Comunidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Voltar);
            this.Controls.Add(this.Bt_Criar_Comunidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Tela_Criar_Comunidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Comunidades";
            this.Load += new System.EventHandler(this.Tela_Criar_Comunidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Imagem_Comunidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_Criar_Comunidade;
        private System.Windows.Forms.Button bt_Voltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nome_Comunidade;
        private System.Windows.Forms.Button Bt_Carrega_Imagem;
        private System.Windows.Forms.PictureBox Picture_Imagem_Comunidade;
        private System.Windows.Forms.RichTextBox Text_Box_Descricao;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}