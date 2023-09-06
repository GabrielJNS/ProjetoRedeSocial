
namespace RedeSocial
{
    partial class Tela_Perfil
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.Label_Nome = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Seguir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label_Nome
            // 
            this.Label_Nome.AutoSize = true;
            this.Label_Nome.Location = new System.Drawing.Point(44, 57);
            this.Label_Nome.Name = "Label_Nome";
            this.Label_Nome.Size = new System.Drawing.Size(106, 13);
            this.Label_Nome.TabIndex = 1;
            this.Label_Nome.Text = "Nome Usuário Amigo";
            this.Label_Nome.Click += new System.EventHandler(this.Label_Nome_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Tela_Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 366);
            this.Controls.Add(this.Label_Nome);
            this.Controls.Add(this.button1);
            this.Name = "Tela_Perfil";
            this.Text = "Tela Perfil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Label_Nome;
        private System.Windows.Forms.ImageList imageList1;
    }
}