
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Email cadastrado:";
            // 
            // EmailRec
            // 
            this.EmailRec.Location = new System.Drawing.Point(148, 17);
            this.EmailRec.Name = "EmailRec";
            this.EmailRec.Size = new System.Drawing.Size(161, 20);
            this.EmailRec.TabIndex = 1;
            // 
            // EnviarEmail
            // 
            this.EnviarEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnviarEmail.Location = new System.Drawing.Point(186, 43);
            this.EnviarEmail.Name = "EnviarEmail";
            this.EnviarEmail.Size = new System.Drawing.Size(75, 23);
            this.EnviarEmail.TabIndex = 2;
            this.EnviarEmail.Text = "Enviar";
            this.EnviarEmail.UseVisualStyleBackColor = true;
            this.EnviarEmail.Click += new System.EventHandler(this.EnviarEmail_Click);
            // 
            // Tela_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 128);
            this.Controls.Add(this.EnviarEmail);
            this.Controls.Add(this.EmailRec);
            this.Controls.Add(this.label1);
            this.Name = "Tela_Senha";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Tela_Senha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailRec;
        private System.Windows.Forms.Button EnviarEmail;
    }
}