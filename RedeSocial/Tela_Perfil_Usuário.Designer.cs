
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
            Tela_BoasVindas novo = new Tela_BoasVindas();
            if (disposing && (components != null))
            {
                components.Dispose();
                novo.Show();

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
            this.Label_Nome = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label_Id = new System.Windows.Forms.Label();
            this.Label_Data = new System.Windows.Forms.Label();
            this.Label_email = new System.Windows.Forms.Label();
            this.Label_name = new System.Windows.Forms.Label();
            this.foto_perfil = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1_foto_perfil = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.foto_perfil)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "E-Mail:";
            // 
            // Label_Id
            // 
            this.Label_Id.AutoSize = true;
            this.Label_Id.Location = new System.Drawing.Point(207, 178);
            this.Label_Id.Name = "Label_Id";
            this.Label_Id.Size = new System.Drawing.Size(18, 13);
            this.Label_Id.TabIndex = 6;
            this.Label_Id.Text = "ID";
            this.Label_Id.Click += new System.EventHandler(this.Label_Id_Click);
            // 
            // Label_Data
            // 
            this.Label_Data.AutoSize = true;
            this.Label_Data.Location = new System.Drawing.Point(207, 282);
            this.Label_Data.Name = "Label_Data";
            this.Label_Data.Size = new System.Drawing.Size(30, 13);
            this.Label_Data.TabIndex = 7;
            this.Label_Data.Text = "Data";
            // 
            // Label_email
            // 
            this.Label_email.AutoSize = true;
            this.Label_email.Location = new System.Drawing.Point(207, 247);
            this.Label_email.Name = "Label_email";
            this.Label_email.Size = new System.Drawing.Size(43, 13);
            this.Label_email.TabIndex = 8;
            this.Label_email.Text = "Usuário";
            // 
            // Label_name
            // 
            this.Label_name.AutoSize = true;
            this.Label_name.Location = new System.Drawing.Point(207, 210);
            this.Label_name.Name = "Label_name";
            this.Label_name.Size = new System.Drawing.Size(43, 13);
            this.Label_name.TabIndex = 9;
            this.Label_name.Text = "Usuário";
            this.Label_name.Click += new System.EventHandler(this.Label_name_Click);
            // 
            // foto_perfil
            // 
            this.foto_perfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foto_perfil.Location = new System.Drawing.Point(409, 57);
            this.foto_perfil.Name = "foto_perfil";
            this.foto_perfil.Size = new System.Drawing.Size(336, 218);
            this.foto_perfil.TabIndex = 10;
            this.foto_perfil.TabStop = false;
            this.foto_perfil.Click += new System.EventHandler(this.foto_perfil_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Foto Perfil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1_foto_perfil
            // 
            this.openFileDialog1_foto_perfil.FileName = "openFileDialog1_foto_perfil";
            this.openFileDialog1_foto_perfil.Filter = "JPEG(*.jpeg)|*.jpeg|PNG(*.png)|*.png|JPG(*.jpg)|*.jpg";
            // 
            // Tela_Perfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 599);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.foto_perfil);
            this.Controls.Add(this.Label_name);
            this.Controls.Add(this.Label_email);
            this.Controls.Add(this.Label_Data);
            this.Controls.Add(this.Label_Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Nome);
            this.Name = "Tela_Perfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Perfil";
            this.Load += new System.EventHandler(this.Tela_Perfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto_perfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_Nome;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label_Id;
        private System.Windows.Forms.Label Label_Data;
        private System.Windows.Forms.Label Label_email;
        private System.Windows.Forms.Label Label_name;
        private System.Windows.Forms.PictureBox foto_perfil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1_foto_perfil;
    }
}