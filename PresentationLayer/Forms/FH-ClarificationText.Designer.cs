namespace PresentationLayer.Forms
{
    partial class FH_ClarificationText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FH_ClarificationText));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnRedEdiyorum = new System.Windows.Forms.Button();
            this.btnKabul = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbAydinlatmaMetni = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PresentationLayer.Properties.Resources.MicrosoftTeams_image__2_;
            this.pictureBox2.Location = new System.Drawing.Point(123, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(289, 64);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PresentationLayer.Properties.Resources.MicrosoftTeams_image_3;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(210, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // btnRedEdiyorum
            // 
            this.btnRedEdiyorum.Location = new System.Drawing.Point(202, 659);
            this.btnRedEdiyorum.Name = "btnRedEdiyorum";
            this.btnRedEdiyorum.Size = new System.Drawing.Size(193, 47);
            this.btnRedEdiyorum.TabIndex = 29;
            this.btnRedEdiyorum.Text = "Kabul Etmiyorum";
            this.btnRedEdiyorum.UseVisualStyleBackColor = true;
            this.btnRedEdiyorum.Click += new System.EventHandler(this.btnRedEdiyorum_Click);
            // 
            // btnKabul
            // 
            this.btnKabul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            this.btnKabul.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKabul.ForeColor = System.Drawing.Color.White;
            this.btnKabul.Location = new System.Drawing.Point(849, 659);
            this.btnKabul.Name = "btnKabul";
            this.btnKabul.Size = new System.Drawing.Size(193, 47);
            this.btnKabul.TabIndex = 28;
            this.btnKabul.Text = "Kabul Ediyorum";
            this.btnKabul.UseVisualStyleBackColor = false;
            this.btnKabul.Click += new System.EventHandler(this.btnKabul_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.aydinlatma;
            this.pictureBox1.Location = new System.Drawing.Point(453, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(198, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Verilerinizi nasıl kullanıyoruz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(198, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kullanmaya başlamadan önce";
            // 
            // rtbAydinlatmaMetni
            // 
            this.rtbAydinlatmaMetni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbAydinlatmaMetni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAydinlatmaMetni.Location = new System.Drawing.Point(202, 219);
            this.rtbAydinlatmaMetni.Margin = new System.Windows.Forms.Padding(8);
            this.rtbAydinlatmaMetni.Name = "rtbAydinlatmaMetni";
            this.rtbAydinlatmaMetni.ReadOnly = true;
            this.rtbAydinlatmaMetni.Size = new System.Drawing.Size(840, 416);
            this.rtbAydinlatmaMetni.TabIndex = 24;
            this.rtbAydinlatmaMetni.Text = resources.GetString("rtbAydinlatmaMetni.Text");
            // 
            // FH_ClarificationText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1210, 757);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnRedEdiyorum);
            this.Controls.Add(this.btnKabul);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbAydinlatmaMetni);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FH_ClarificationText";
            this.Text = "FH_ClarificationText";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FH_ClarificationText_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnRedEdiyorum;
        private System.Windows.Forms.Button btnKabul;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbAydinlatmaMetni;
    }
}