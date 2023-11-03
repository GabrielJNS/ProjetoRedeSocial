
namespace RedeSocial
{
    partial class Tela_Perfil_Amigos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_nome_amigo = new System.Windows.Forms.Label();
            this.Label_nome = new System.Windows.Forms.Label();
            this.Label_data = new System.Windows.Forms.Label();
            this.Label_comunidades = new System.Windows.Forms.Label();
            this.Label_id = new System.Windows.Forms.Label();
            this.Pic_amigo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_amigo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(63, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Solicitação de Amizade";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data de Nascimento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(331, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Comunidades";
            // 
            // label_nome_amigo
            // 
            this.label_nome_amigo.AutoSize = true;
            this.label_nome_amigo.Location = new System.Drawing.Point(111, 166);
            this.label_nome_amigo.Name = "label_nome_amigo";
            this.label_nome_amigo.Size = new System.Drawing.Size(41, 13);
            this.label_nome_amigo.TabIndex = 5;
            this.label_nome_amigo.Text = "Amigos";
            this.label_nome_amigo.Click += new System.EventHandler(this.label_nome_amigo_Click);
            // 
            // Label_nome
            // 
            this.Label_nome.AutoSize = true;
            this.Label_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_nome.Location = new System.Drawing.Point(571, 208);
            this.Label_nome.Name = "Label_nome";
            this.Label_nome.Size = new System.Drawing.Size(68, 25);
            this.Label_nome.TabIndex = 6;
            this.Label_nome.Text = "Nome";
            // 
            // Label_data
            // 
            this.Label_data.AutoSize = true;
            this.Label_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_data.Location = new System.Drawing.Point(571, 251);
            this.Label_data.Name = "Label_data";
            this.Label_data.Size = new System.Drawing.Size(57, 25);
            this.Label_data.TabIndex = 7;
            this.Label_data.Text = "Data";
            // 
            // Label_comunidades
            // 
            this.Label_comunidades.AutoSize = true;
            this.Label_comunidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_comunidades.Location = new System.Drawing.Point(571, 294);
            this.Label_comunidades.Name = "Label_comunidades";
            this.Label_comunidades.Size = new System.Drawing.Size(144, 25);
            this.Label_comunidades.TabIndex = 8;
            this.Label_comunidades.Text = "Comunidades";
            // 
            // Label_id
            // 
            this.Label_id.AutoSize = true;
            this.Label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_id.Location = new System.Drawing.Point(572, 166);
            this.Label_id.Name = "Label_id";
            this.Label_id.Size = new System.Drawing.Size(32, 25);
            this.Label_id.TabIndex = 9;
            this.Label_id.Text = "ID";
            // 
            // Pic_amigo
            // 
            this.Pic_amigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_amigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic_amigo.Location = new System.Drawing.Point(45, 190);
            this.Pic_amigo.Name = "Pic_amigo";
            this.Pic_amigo.Size = new System.Drawing.Size(167, 214);
            this.Pic_amigo.TabIndex = 10;
            this.Pic_amigo.TabStop = false;
            // 
            // Tela_Perfil_Amigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RedeSocial.Properties.Resources.Login__43_;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.Pic_amigo);
            this.Controls.Add(this.Label_id);
            this.Controls.Add(this.Label_comunidades);
            this.Controls.Add(this.Label_data);
            this.Controls.Add(this.Label_nome);
            this.Controls.Add(this.label_nome_amigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Tela_Perfil_Amigos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Amigos";
            this.Load += new System.EventHandler(this.Tela_Perfil_Amigos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_amigo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_nome_amigo;
        private System.Windows.Forms.Label Label_nome;
        private System.Windows.Forms.Label Label_data;
        private System.Windows.Forms.Label Label_comunidades;
        private System.Windows.Forms.Label Label_id;
        private System.Windows.Forms.PictureBox Pic_amigo;
    }
}