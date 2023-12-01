
namespace RedeSocial
{
    partial class Tela_Senha
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
            this.label1 = new System.Windows.Forms.Label();
            this.EmailRec = new System.Windows.Forms.TextBox();
            this.EnviarEmail = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Email cadastrado:";
            // 
            // EmailRec
            // 
            this.EmailRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailRec.Location = new System.Drawing.Point(22, 53);
            this.EmailRec.Name = "EmailRec";
            this.EmailRec.Size = new System.Drawing.Size(161, 20);
            this.EmailRec.TabIndex = 1;
            // 
            // EnviarEmail
            // 
            this.EnviarEmail.BackColor = System.Drawing.Color.DarkBlue;
            this.EnviarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnviarEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.EnviarEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.EnviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnviarEmail.ForeColor = System.Drawing.Color.White;
            this.EnviarEmail.Location = new System.Drawing.Point(64, 93);
            this.EnviarEmail.Name = "EnviarEmail";
            this.EnviarEmail.Size = new System.Drawing.Size(75, 23);
            this.EnviarEmail.TabIndex = 2;
            this.EnviarEmail.Text = "Enviar";
            this.EnviarEmail.UseVisualStyleBackColor = false;
            this.EnviarEmail.Click += new System.EventHandler(this.EnviarEmail_Click);
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
            this.Sair.Location = new System.Drawing.Point(187, 3);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(26, 27);
            this.Sair.TabIndex = 56;
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Tela_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(218, 128);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.EnviarEmail);
            this.Controls.Add(this.EmailRec);
            this.Controls.Add(this.label1);
            this.Name = "Tela_Senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Tela_Senha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailRec;
        private System.Windows.Forms.Button EnviarEmail;
        private System.Windows.Forms.Button Sair;
    }
}