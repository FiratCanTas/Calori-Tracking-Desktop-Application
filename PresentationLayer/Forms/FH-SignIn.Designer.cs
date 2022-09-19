namespace PresentationLayer.Forms
{
    partial class FH_SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FH_SignIn));
            this.btnContactUs = new System.Windows.Forms.Button();
            this.btnSifremiUnuttum = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmailAdresiniz = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.btnSifreGizle = new System.Windows.Forms.Button();
            this.txtSifreniz = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContactUs
            // 
            this.btnContactUs.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContactUs.Location = new System.Drawing.Point(373, 402);
            this.btnContactUs.Margin = new System.Windows.Forms.Padding(4);
            this.btnContactUs.Name = "btnContactUs";
            this.btnContactUs.Size = new System.Drawing.Size(274, 28);
            this.btnContactUs.TabIndex = 37;
            this.btnContactUs.Text = "Bize Ulaşın";
            this.btnContactUs.UseVisualStyleBackColor = true;
            this.btnContactUs.Click += new System.EventHandler(this.btnContactUs_Click);
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifremiUnuttum.Location = new System.Drawing.Point(502, 343);
            this.btnSifremiUnuttum.Margin = new System.Windows.Forms.Padding(4);
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.Size = new System.Drawing.Size(146, 51);
            this.btnSifremiUnuttum.TabIndex = 36;
            this.btnSifremiUnuttum.Text = "Şifremi Unuttum";
            this.btnSifremiUnuttum.UseVisualStyleBackColor = true;
            this.btnSifremiUnuttum.Click += new System.EventHandler(this.btnSifremiUnuttum_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PresentationLayer.Properties.Resources.MicrosoftTeams_image__2_;
            this.pictureBox2.Location = new System.Drawing.Point(326, 137);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(361, 70);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PresentationLayer.Properties.Resources.MicrosoftTeams_image_3;
            this.pictureBox3.Location = new System.Drawing.Point(187, 119);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(262, 88);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Şifre : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mail Adresi :";
            // 
            // txtEmailAdresiniz
            // 
            this.txtEmailAdresiniz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailAdresiniz.Location = new System.Drawing.Point(373, 249);
            this.txtEmailAdresiniz.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailAdresiniz.Name = "txtEmailAdresiniz";
            this.txtEmailAdresiniz.Size = new System.Drawing.Size(274, 29);
            this.txtEmailAdresiniz.TabIndex = 30;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            this.btnGirisYap.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGirisYap.Location = new System.Drawing.Point(373, 343);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(121, 51);
            this.btnGirisYap.TabIndex = 29;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // btnSifreGizle
            // 
            this.btnSifreGizle.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSifreGizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSifreGizle.Image = ((System.Drawing.Image)(resources.GetObject("btnSifreGizle.Image")));
            this.btnSifreGizle.Location = new System.Drawing.Point(613, 286);
            this.btnSifreGizle.Name = "btnSifreGizle";
            this.btnSifreGizle.Size = new System.Drawing.Size(34, 25);
            this.btnSifreGizle.TabIndex = 77;
            this.btnSifreGizle.UseMnemonic = false;
            this.btnSifreGizle.UseVisualStyleBackColor = true;
            this.btnSifreGizle.Click += new System.EventHandler(this.btnSifreGizle_Click);
            // 
            // txtSifreniz
            // 
            this.txtSifreniz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifreniz.Location = new System.Drawing.Point(373, 286);
            this.txtSifreniz.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifreniz.Name = "txtSifreniz";
            this.txtSifreniz.Size = new System.Drawing.Size(240, 29);
            this.txtSifreniz.TabIndex = 76;
            this.txtSifreniz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FH_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(875, 549);
            this.Controls.Add(this.btnSifreGizle);
            this.Controls.Add(this.txtSifreniz);
            this.Controls.Add(this.btnContactUs);
            this.Controls.Add(this.btnSifremiUnuttum);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmailAdresiniz);
            this.Controls.Add(this.btnGirisYap);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FH_SignIn";
            this.Text = "FH_SignIn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FH_SignIn_FormClosed);
            this.Load += new System.EventHandler(this.FH_SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContactUs;
        private System.Windows.Forms.Button btnSifremiUnuttum;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmailAdresiniz;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Button btnSifreGizle;
        private System.Windows.Forms.TextBox txtSifreniz;
    }
}