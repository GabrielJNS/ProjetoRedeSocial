
namespace RedeSocial
{
    partial class Tela_Postagem
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
            this.button1 = new System.Windows.Forms.Button();
            this.text_descricao = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.foto_postar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.foto_postar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Postar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_descricao
            // 
            this.text_descricao.Location = new System.Drawing.Point(233, 309);
            this.text_descricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_descricao.Name = "text_descricao";
            this.text_descricao.Size = new System.Drawing.Size(411, 84);
            this.text_descricao.TabIndex = 2;
            this.text_descricao.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 111);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Fotos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // foto_postar
            // 
            this.foto_postar.Location = new System.Drawing.Point(233, 26);
            this.foto_postar.Margin = new System.Windows.Forms.Padding(4);
            this.foto_postar.Name = "foto_postar";
            this.foto_postar.Size = new System.Drawing.Size(412, 276);
            this.foto_postar.TabIndex = 0;
            this.foto_postar.TabStop = false;
            this.foto_postar.Click += new System.EventHandler(this.foto_postar_Click);
            // 
            // Tela_Postagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 529);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.text_descricao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.foto_postar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tela_Postagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postar";
            ((System.ComponentModel.ISupportInitialize)(this.foto_postar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox text_descricao;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.PictureBox foto_postar;
    }
}