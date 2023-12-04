
namespace RedeSocial
{
    partial class Aviso_Cadastro
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
            this.bt_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, -21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "\'";
            // 
            // bt_sair
            // 
            this.bt_sair.BackColor = System.Drawing.Color.Transparent;
            this.bt_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_sair.FlatAppearance.BorderSize = 0;
            this.bt_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bt_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sair.Location = new System.Drawing.Point(62, 129);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(66, 29);
            this.bt_sair.TabIndex = 1;
            this.bt_sair.Text = "\'";
            this.bt_sair.UseVisualStyleBackColor = false;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // Aviso_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RedeSocial.Properties.Resources.Group_292;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Aviso_Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Confirmado";
            this.Load += new System.EventHandler(this.Aviso_Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_sair;
    }
}