
namespace RedeSocial
{
    partial class Tela_RecSenha
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
            this.CodRec = new System.Windows.Forms.TextBox();
            this.buttonVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o código:";
            // 
            // CodRec
            // 
            this.CodRec.Location = new System.Drawing.Point(99, 30);
            this.CodRec.Name = "CodRec";
            this.CodRec.Size = new System.Drawing.Size(105, 20);
            this.CodRec.TabIndex = 1;
            // 
            // buttonVerificar
            // 
            this.buttonVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVerificar.Location = new System.Drawing.Point(114, 56);
            this.buttonVerificar.Name = "buttonVerificar";
            this.buttonVerificar.Size = new System.Drawing.Size(75, 23);
            this.buttonVerificar.TabIndex = 2;
            this.buttonVerificar.Text = "Enviar";
            this.buttonVerificar.UseVisualStyleBackColor = true;
            this.buttonVerificar.Click += new System.EventHandler(this.buttonVerificar_Click_1);
            // 
            // Tela_RecSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 126);
            this.Controls.Add(this.buttonVerificar);
            this.Controls.Add(this.CodRec);
            this.Controls.Add(this.label1);
            this.Name = "Tela_RecSenha";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Tela_RecSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodRec;
        private System.Windows.Forms.Button buttonVerificar;
    }
}