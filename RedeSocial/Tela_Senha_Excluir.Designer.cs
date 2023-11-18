
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
            this.SuspendLayout();
            // 
            // caixa_email
            // 
            this.caixa_email.Location = new System.Drawing.Point(56, 95);
            this.caixa_email.Name = "caixa_email";
            this.caixa_email.Size = new System.Drawing.Size(190, 20);
            this.caixa_email.TabIndex = 0;
            // 
            // caixa_senha
            // 
            this.caixa_senha.Location = new System.Drawing.Point(56, 152);
            this.caixa_senha.Name = "caixa_senha";
            this.caixa_senha.Size = new System.Drawing.Size(190, 20);
            this.caixa_senha.TabIndex = 1;
            // 
            // caixa_text
            // 
            this.caixa_text.Location = new System.Drawing.Point(56, 192);
            this.caixa_text.Name = "caixa_text";
            this.caixa_text.Size = new System.Drawing.Size(75, 23);
            this.caixa_text.TabIndex = 2;
            this.caixa_text.Text = "Confirmar";
            this.caixa_text.UseVisualStyleBackColor = true;
            this.caixa_text.Click += new System.EventHandler(this.caixa_text_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite sua Senha";
            // 
            // Tela_Senha_Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.caixa_text);
            this.Controls.Add(this.caixa_senha);
            this.Controls.Add(this.caixa_email);
            this.Name = "Tela_Senha_Excluir";
            this.Text = "Tela_Senha_Excluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox caixa_email;
        private System.Windows.Forms.TextBox caixa_senha;
        private System.Windows.Forms.Button caixa_text;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}