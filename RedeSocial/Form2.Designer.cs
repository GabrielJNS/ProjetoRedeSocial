
namespace RedeSocial
{
    partial class Tela_BoasVindas
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
            this.Amigos = new System.Windows.Forms.Button();
            this.bt_UsuarioLogado = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Amigos
            // 
            this.Amigos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Amigos.Location = new System.Drawing.Point(41, 105);
            this.Amigos.Name = "Amigos";
            this.Amigos.Size = new System.Drawing.Size(82, 32);
            this.Amigos.TabIndex = 2;
            this.Amigos.Text = "Amigos";
            this.Amigos.UseVisualStyleBackColor = true;
            this.Amigos.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_UsuarioLogado
            // 
            this.bt_UsuarioLogado.Location = new System.Drawing.Point(41, 47);
            this.bt_UsuarioLogado.Name = "bt_UsuarioLogado";
            this.bt_UsuarioLogado.Size = new System.Drawing.Size(82, 28);
            this.bt_UsuarioLogado.TabIndex = 3;
            this.bt_UsuarioLogado.Text = "Usuário";
            this.bt_UsuarioLogado.UseVisualStyleBackColor = true;
            this.bt_UsuarioLogado.Click += new System.EventHandler(this.bt_UsuarioLogado_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Minhas Redes";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(142, 105);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "Criar Comunidade";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Tela_BoasVindas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 358);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_UsuarioLogado);
            this.Controls.Add(this.Amigos);
            this.Name = "Tela_BoasVindas";
            this.Text = "Bem Vindo";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Amigos;
        private System.Windows.Forms.Button bt_UsuarioLogado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}