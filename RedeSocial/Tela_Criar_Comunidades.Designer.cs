
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
            this.Nome_Comunidade = new System.Windows.Forms.TextBox();
            this.Bt_Carrega_Imagem = new System.Windows.Forms.Button();
            this.Picture_Imagem_Comunidade = new System.Windows.Forms.PictureBox();
            this.Text_Box_Descricao = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.Sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Imagem_Comunidade)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bt_Criar_Comunidade
            // 
            this.Bt_Criar_Comunidade.BackColor = System.Drawing.Color.Transparent;
            this.Bt_Criar_Comunidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Criar_Comunidade.FlatAppearance.BorderSize = 0;
            this.Bt_Criar_Comunidade.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Bt_Criar_Comunidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Bt_Criar_Comunidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Criar_Comunidade.Location = new System.Drawing.Point(337, 481);
            this.Bt_Criar_Comunidade.Name = "Bt_Criar_Comunidade";
            this.Bt_Criar_Comunidade.Size = new System.Drawing.Size(182, 39);
            this.Bt_Criar_Comunidade.TabIndex = 0;
            this.Bt_Criar_Comunidade.UseVisualStyleBackColor = false;
            this.Bt_Criar_Comunidade.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Voltar
            // 
            this.bt_Voltar.BackColor = System.Drawing.Color.Transparent;
            this.bt_Voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_Voltar.FlatAppearance.BorderSize = 0;
            this.bt_Voltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_Voltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Voltar.Location = new System.Drawing.Point(544, 480);
            this.bt_Voltar.Name = "bt_Voltar";
            this.bt_Voltar.Size = new System.Drawing.Size(184, 40);
            this.bt_Voltar.TabIndex = 1;
            this.bt_Voltar.UseVisualStyleBackColor = false;
            this.bt_Voltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Nome_Comunidade
            // 
            this.Nome_Comunidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nome_Comunidade.Location = new System.Drawing.Point(128, 183);
            this.Nome_Comunidade.Name = "Nome_Comunidade";
            this.Nome_Comunidade.Size = new System.Drawing.Size(391, 20);
            this.Nome_Comunidade.TabIndex = 5;
            // 
            // Bt_Carrega_Imagem
            // 
            this.Bt_Carrega_Imagem.BackColor = System.Drawing.Color.Transparent;
            this.Bt_Carrega_Imagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_Carrega_Imagem.FlatAppearance.BorderSize = 0;
            this.Bt_Carrega_Imagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Bt_Carrega_Imagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Bt_Carrega_Imagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_Carrega_Imagem.Location = new System.Drawing.Point(579, 269);
            this.Bt_Carrega_Imagem.Name = "Bt_Carrega_Imagem";
            this.Bt_Carrega_Imagem.Size = new System.Drawing.Size(149, 41);
            this.Bt_Carrega_Imagem.TabIndex = 7;
            this.Bt_Carrega_Imagem.UseVisualStyleBackColor = false;
            this.Bt_Carrega_Imagem.Click += new System.EventHandler(this.Bt_Carrega_Imagem_Click);
            // 
            // Picture_Imagem_Comunidade
            // 
            this.Picture_Imagem_Comunidade.BackColor = System.Drawing.Color.Transparent;
            this.Picture_Imagem_Comunidade.Location = new System.Drawing.Point(580, 145);
            this.Picture_Imagem_Comunidade.Name = "Picture_Imagem_Comunidade";
            this.Picture_Imagem_Comunidade.Size = new System.Drawing.Size(147, 126);
            this.Picture_Imagem_Comunidade.TabIndex = 8;
            this.Picture_Imagem_Comunidade.TabStop = false;
            this.Picture_Imagem_Comunidade.Click += new System.EventHandler(this.Picture_Imagem_Comunidade_Click);
            // 
            // Text_Box_Descricao
            // 
            this.Text_Box_Descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Text_Box_Descricao.Location = new System.Drawing.Point(128, 386);
            this.Text_Box_Descricao.Name = "Text_Box_Descricao";
            this.Text_Box_Descricao.Size = new System.Drawing.Size(600, 76);
            this.Text_Box_Descricao.TabIndex = 9;
            this.Text_Box_Descricao.Text = "";
            this.Text_Box_Descricao.TextChanged += new System.EventHandler(this.Text_Box_Descricao_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Text_Box_Descricao);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Bt_Criar_Comunidade);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Picture_Imagem_Comunidade);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.bt_Voltar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Bt_Carrega_Imagem);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.Nome_Comunidade);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(948, 582);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(203, 78);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(948, 582);
            this.toolStripContainer1.TabIndex = 10;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
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
            this.Sair.Location = new System.Drawing.Point(1199, 12);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(35, 40);
            this.Sair.TabIndex = 57;
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Tela_Criar_Comunidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RedeSocial.Properties.Resources.Group_361;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.toolStripContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Tela_Criar_Comunidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Comunidades";
            this.Load += new System.EventHandler(this.Tela_Criar_Comunidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Imagem_Comunidade)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bt_Criar_Comunidade;
        private System.Windows.Forms.Button bt_Voltar;
        private System.Windows.Forms.TextBox Nome_Comunidade;
        private System.Windows.Forms.Button Bt_Carrega_Imagem;
        private System.Windows.Forms.PictureBox Picture_Imagem_Comunidade;
        private System.Windows.Forms.RichTextBox Text_Box_Descricao;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button Sair;
    }
}