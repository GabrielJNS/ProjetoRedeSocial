
namespace RedeSocial
{
    partial class Tela_Postagem
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
            this.button1 = new System.Windows.Forms.Button();
            this.text_descricao = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.foto_postar = new System.Windows.Forms.PictureBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.Sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foto_postar)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(483, 548);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 41);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_descricao
            // 
            this.text_descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_descricao.Location = new System.Drawing.Point(204, 459);
            this.text_descricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_descricao.Name = "text_descricao";
            this.text_descricao.Size = new System.Drawing.Size(676, 77);
            this.text_descricao.TabIndex = 2;
            this.text_descricao.Text = "";
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(700, 98);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 31);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // foto_postar
            // 
            this.foto_postar.BackColor = System.Drawing.Color.Transparent;
            this.foto_postar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foto_postar.Location = new System.Drawing.Point(204, 133);
            this.foto_postar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foto_postar.Name = "foto_postar";
            this.foto_postar.Size = new System.Drawing.Size(677, 286);
            this.foto_postar.TabIndex = 0;
            this.foto_postar.TabStop = false;
            this.foto_postar.Click += new System.EventHandler(this.foto_postar_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.foto_postar);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.text_descricao);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.button2);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1181, 684);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(304, 139);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1181, 684);
            this.toolStripContainer1.TabIndex = 6;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
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
            this.Sair.Location = new System.Drawing.Point(1599, 15);
            this.Sair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(47, 49);
            this.Sair.TabIndex = 55;
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Tela_Postagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RedeSocial.Properties.Resources.Group_40;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.toolStripContainer1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Tela_Postagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postar";
            this.Load += new System.EventHandler(this.Tela_Postagem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto_postar)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox text_descricao;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.PictureBox foto_postar;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button Sair;
    }
}