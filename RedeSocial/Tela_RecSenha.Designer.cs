
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
            this.Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o código:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CodRec
            // 
            this.CodRec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CodRec.Location = new System.Drawing.Point(47, 45);
            this.CodRec.Name = "CodRec";
            this.CodRec.Size = new System.Drawing.Size(114, 20);
            this.CodRec.TabIndex = 1;
            // 
            // buttonVerificar
            // 
            this.buttonVerificar.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVerificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonVerificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerificar.ForeColor = System.Drawing.Color.White;
            this.buttonVerificar.Location = new System.Drawing.Point(66, 88);
            this.buttonVerificar.Name = "buttonVerificar";
            this.buttonVerificar.Size = new System.Drawing.Size(75, 23);
            this.buttonVerificar.TabIndex = 2;
            this.buttonVerificar.Text = "Enviar";
            this.buttonVerificar.UseVisualStyleBackColor = false;
            this.buttonVerificar.Click += new System.EventHandler(this.buttonVerificar_Click_1);
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
            this.Sair.Location = new System.Drawing.Point(183, 6);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(30, 27);
            this.Sair.TabIndex = 55;
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Tela_RecSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(218, 126);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.buttonVerificar);
            this.Controls.Add(this.CodRec);
            this.Controls.Add(this.label1);
            this.Name = "Tela_RecSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Tela_RecSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodRec;
        private System.Windows.Forms.Button buttonVerificar;
        private System.Windows.Forms.Button Sair;
    }
}