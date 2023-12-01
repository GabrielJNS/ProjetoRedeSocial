
namespace RedeSocial
{
    partial class Tela_Senha_Excluir
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
            this.caixa_email = new System.Windows.Forms.TextBox();
            this.caixa_senha = new System.Windows.Forms.TextBox();
            this.caixa_text = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // caixa_email
            // 
            this.caixa_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa_email.Location = new System.Drawing.Point(29, 73);
            this.caixa_email.Name = "caixa_email";
            this.caixa_email.Size = new System.Drawing.Size(190, 20);
            this.caixa_email.TabIndex = 0;
            // 
            // caixa_senha
            // 
            this.caixa_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa_senha.Location = new System.Drawing.Point(29, 122);
            this.caixa_senha.Name = "caixa_senha";
            this.caixa_senha.Size = new System.Drawing.Size(190, 20);
            this.caixa_senha.TabIndex = 1;
            // 
            // caixa_text
            // 
            this.caixa_text.BackColor = System.Drawing.Color.DarkBlue;
            this.caixa_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.caixa_text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caixa_text.ForeColor = System.Drawing.Color.Transparent;
            this.caixa_text.Location = new System.Drawing.Point(45, 171);
            this.caixa_text.Name = "caixa_text";
            this.caixa_text.Size = new System.Drawing.Size(75, 23);
            this.caixa_text.TabIndex = 2;
            this.caixa_text.Text = "Confirmar";
            this.caixa_text.UseVisualStyleBackColor = false;
            this.caixa_text.Click += new System.EventHandler(this.caixa_text_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(126, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite sua Senha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.Sair.Location = new System.Drawing.Point(207, 22);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(26, 27);
            this.Sair.TabIndex = 57;
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Tela_Senha_Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(252, 256);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.caixa_text);
            this.Controls.Add(this.caixa_senha);
            this.Controls.Add(this.caixa_email);
            this.Name = "Tela_Senha_Excluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_Senha_Excluir";
            this.Load += new System.EventHandler(this.Tela_Senha_Excluir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caixa_email;
        private System.Windows.Forms.TextBox caixa_senha;
        private System.Windows.Forms.Button caixa_text;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sair;
    }
}