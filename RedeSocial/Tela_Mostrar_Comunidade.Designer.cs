
namespace RedeSocial
{
    partial class Tela_Mostrar_Comunidade
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
            this.listBoxComunidades = new System.Windows.Forms.ListBox();
            this.btMinhaComunidade = new System.Windows.Forms.Button();
            this.btOutrasComunidades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxComunidades
            // 
            this.listBoxComunidades.FormattingEnabled = true;
            this.listBoxComunidades.ItemHeight = 16;
            this.listBoxComunidades.Location = new System.Drawing.Point(66, 37);
            this.listBoxComunidades.Name = "listBoxComunidades";
            this.listBoxComunidades.Size = new System.Drawing.Size(616, 244);
            this.listBoxComunidades.TabIndex = 0;
            // 
            // btMinhaComunidade
            // 
            this.btMinhaComunidade.Location = new System.Drawing.Point(412, 333);
            this.btMinhaComunidade.Name = "btMinhaComunidade";
            this.btMinhaComunidade.Size = new System.Drawing.Size(183, 37);
            this.btMinhaComunidade.TabIndex = 1;
            this.btMinhaComunidade.Text = "Minhas Comunidades ";
            this.btMinhaComunidade.UseVisualStyleBackColor = true;
            this.btMinhaComunidade.Click += new System.EventHandler(this.btMinhaComunidade_Click_1);
            // 
            // btOutrasComunidades
            // 
            this.btOutrasComunidades.Location = new System.Drawing.Point(179, 333);
            this.btOutrasComunidades.Name = "btOutrasComunidades";
            this.btOutrasComunidades.Size = new System.Drawing.Size(183, 37);
            this.btOutrasComunidades.TabIndex = 2;
            this.btOutrasComunidades.Text = "Outras Comunidades";
            this.btOutrasComunidades.UseVisualStyleBackColor = true;
            // 
            // Tela_Mostrar_Comunidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btOutrasComunidades);
            this.Controls.Add(this.btMinhaComunidade);
            this.Controls.Add(this.listBoxComunidades);
            this.Name = "Tela_Mostrar_Comunidade";
            this.Text = "Tela_Mostrar_Comunidade";
            this.Load += new System.EventHandler(this.Tela_Mostrar_Comunidade_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxComunidades;
        private System.Windows.Forms.Button btMinhaComunidade;
        private System.Windows.Forms.Button btOutrasComunidades;
    }
}