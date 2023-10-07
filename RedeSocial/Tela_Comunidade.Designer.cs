
namespace RedeSocial
{
    partial class Tela_Comunidade
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
            this.Label_Nome_Comunidade = new System.Windows.Forms.Label();
            this.Label_Descricao = new System.Windows.Forms.Label();
            this.Foto_Comunidade = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Foto_Comunidade)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Nome_Comunidade
            // 
            this.Label_Nome_Comunidade.AutoSize = true;
            this.Label_Nome_Comunidade.Location = new System.Drawing.Point(52, 42);
            this.Label_Nome_Comunidade.Name = "Label_Nome_Comunidade";
            this.Label_Nome_Comunidade.Size = new System.Drawing.Size(97, 13);
            this.Label_Nome_Comunidade.TabIndex = 0;
            this.Label_Nome_Comunidade.Text = "Nome Comunidade";
            this.Label_Nome_Comunidade.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label_Descricao
            // 
            this.Label_Descricao.AutoSize = true;
            this.Label_Descricao.Location = new System.Drawing.Point(52, 282);
            this.Label_Descricao.Name = "Label_Descricao";
            this.Label_Descricao.Size = new System.Drawing.Size(117, 13);
            this.Label_Descricao.TabIndex = 1;
            this.Label_Descricao.Text = "Descrição Comunidade";
            // 
            // Foto_Comunidade
            // 
            this.Foto_Comunidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Foto_Comunidade.Location = new System.Drawing.Point(43, 58);
            this.Foto_Comunidade.Name = "Foto_Comunidade";
            this.Foto_Comunidade.Size = new System.Drawing.Size(217, 206);
            this.Foto_Comunidade.TabIndex = 2;
            this.Foto_Comunidade.TabStop = false;
            this.Foto_Comunidade.Click += new System.EventHandler(this.Foto_Comunidade_Click);
            // 
            // Tela_Comunidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Foto_Comunidade);
            this.Controls.Add(this.Label_Descricao);
            this.Controls.Add(this.Label_Nome_Comunidade);
            this.Name = "Tela_Comunidade";
            this.Text = "Tela Comunidade";
            this.Load += new System.EventHandler(this.Tela_Comunidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Foto_Comunidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Nome_Comunidade;
        private System.Windows.Forms.Label Label_Descricao;
        private System.Windows.Forms.PictureBox Foto_Comunidade;
    }
}