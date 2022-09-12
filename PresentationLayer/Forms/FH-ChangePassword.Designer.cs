namespace PresentationLayer.Forms
{
    partial class FH_ChangePassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSifreGüncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyadiniz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdiniz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 64);
            this.panel1.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PresentationLayer.Properties.Resources.MicrosoftTeams_image__2_;
            this.pictureBox2.Location = new System.Drawing.Point(104, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(345, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(665, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Şifre Kurtarma";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.MicrosoftTeams_image_3;
            this.pictureBox1.Location = new System.Drawing.Point(3, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnSifreGüncelle
            // 
            this.btnSifreGüncelle.Location = new System.Drawing.Point(541, 339);
            this.btnSifreGüncelle.Name = "btnSifreGüncelle";
            this.btnSifreGüncelle.Size = new System.Drawing.Size(189, 46);
            this.btnSifreGüncelle.TabIndex = 35;
            this.btnSifreGüncelle.Text = "Şifre Güncelle";
            this.btnSifreGüncelle.UseVisualStyleBackColor = true;
            this.btnSifreGüncelle.Click += new System.EventHandler(this.btnSifreGüncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 22);
            this.label5.TabIndex = 34;
            this.label5.Text = "Yeni Şifre : ";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYeniSifre.Location = new System.Drawing.Point(367, 290);
            this.txtYeniSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(363, 29);
            this.txtYeniSifre.TabIndex = 33;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(367, 252);
            this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(363, 29);
            this.dtpDogumTarihi.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 259);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "Doğum Tarihiniz : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "Soyadınız : ";
            // 
            // txtSoyadiniz
            // 
            this.txtSoyadiniz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyadiniz.Location = new System.Drawing.Point(367, 213);
            this.txtSoyadiniz.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyadiniz.Name = "txtSoyadiniz";
            this.txtSoyadiniz.Size = new System.Drawing.Size(363, 29);
            this.txtSoyadiniz.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 28;
            this.label2.Text = "Adınız : ";
            // 
            // txtAdiniz
            // 
            this.txtAdiniz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdiniz.Location = new System.Drawing.Point(367, 175);
            this.txtAdiniz.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdiniz.Name = "txtAdiniz";
            this.txtAdiniz.Size = new System.Drawing.Size(363, 29);
            this.txtAdiniz.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "E-Posta :";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(367, 136);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(363, 29);
            this.txtEmail.TabIndex = 25;
            // 
            // FH_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(925, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSifreGüncelle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyadiniz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdiniz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FH_ChangePassword";
            this.Text = "FH_ChangePassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FH_ChangePassword_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSifreGüncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyadiniz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdiniz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}