namespace PresentationLayer.Forms
{
    partial class FH_Lunch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FH_Lunch));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAraLunch = new System.Windows.Forms.TextBox();
            this.btnOgleOgunuEkle = new System.Windows.Forms.Button();
            this.dgvMealList = new System.Windows.Forms.DataGridView();
            this.dgvLunchList = new System.Windows.Forms.DataGridView();
            this.btnOgleOgunuKaldir = new System.Windows.Forms.Button();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLunchList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 91);
            this.panel1.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(913, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Öğle Yemeği Seçimi";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PresentationLayer.Properties.Resources.MicrosoftTeams_image__2_;
            this.pictureBox2.Location = new System.Drawing.Point(95, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(373, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PresentationLayer.Properties.Resources.MicrosoftTeams_image_3;
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAra.Image = global::PresentationLayer.Properties.Resources.icons8_search_1;
            this.btnAra.Location = new System.Drawing.Point(428, 124);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(48, 36);
            this.btnAra.TabIndex = 31;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAraLunch
            // 
            this.txtAraLunch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAraLunch.Location = new System.Drawing.Point(207, 128);
            this.txtAraLunch.Name = "txtAraLunch";
            this.txtAraLunch.Size = new System.Drawing.Size(204, 29);
            this.txtAraLunch.TabIndex = 30;
            // 
            // btnOgleOgunuEkle
            // 
            this.btnOgleOgunuEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOgleOgunuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgleOgunuEkle.Image = global::PresentationLayer.Properties.Resources.icons8_sent;
            this.btnOgleOgunuEkle.Location = new System.Drawing.Point(774, 350);
            this.btnOgleOgunuEkle.Name = "btnOgleOgunuEkle";
            this.btnOgleOgunuEkle.Size = new System.Drawing.Size(115, 37);
            this.btnOgleOgunuEkle.TabIndex = 29;
            this.btnOgleOgunuEkle.UseVisualStyleBackColor = false;
            this.btnOgleOgunuEkle.Click += new System.EventHandler(this.btnOgleOgunuEkle_Click);
            // 
            // dgvMealList
            // 
            this.dgvMealList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMealList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealList.Location = new System.Drawing.Point(12, 166);
            this.dgvMealList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvMealList.Name = "dgvMealList";
            this.dgvMealList.RowHeadersWidth = 51;
            this.dgvMealList.Size = new System.Drawing.Size(717, 404);
            this.dgvMealList.TabIndex = 28;
            this.dgvMealList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuchList_CellClick);
            // 
            // dgvLunchList
            // 
            this.dgvLunchList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLunchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLunchList.Location = new System.Drawing.Point(935, 166);
            this.dgvLunchList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvLunchList.Name = "dgvLunchList";
            this.dgvLunchList.RowHeadersWidth = 51;
            this.dgvLunchList.Size = new System.Drawing.Size(426, 404);
            this.dgvLunchList.TabIndex = 27;
            this.dgvLunchList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSecilenYemekler_CellClick);
            // 
            // btnOgleOgunuKaldir
            // 
            this.btnOgleOgunuKaldir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOgleOgunuKaldir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgleOgunuKaldir.Image = ((System.Drawing.Image)(resources.GetObject("btnOgleOgunuKaldir.Image")));
            this.btnOgleOgunuKaldir.Location = new System.Drawing.Point(774, 307);
            this.btnOgleOgunuKaldir.Name = "btnOgleOgunuKaldir";
            this.btnOgleOgunuKaldir.Size = new System.Drawing.Size(115, 37);
            this.btnOgleOgunuKaldir.TabIndex = 33;
            this.btnOgleOgunuKaldir.UseVisualStyleBackColor = false;
            this.btnOgleOgunuKaldir.Click += new System.EventHandler(this.btnOgleOgunuKaldir_Click);
            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTamamla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamamla.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamamla.Location = new System.Drawing.Point(774, 420);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(115, 37);
            this.btnTamamla.TabIndex = 34;
            this.btnTamamla.Text = "Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // FH_Lunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1397, 581);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.btnOgleOgunuKaldir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAraLunch);
            this.Controls.Add(this.btnOgleOgunuEkle);
            this.Controls.Add(this.dgvMealList);
            this.Controls.Add(this.dgvLunchList);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FH_Lunch";
            this.Text = "FH_Lunch";
            this.Load += new System.EventHandler(this.FH_Lunch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLunchList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAraLunch;
        private System.Windows.Forms.Button btnOgleOgunuEkle;
        private System.Windows.Forms.DataGridView dgvMealList;
        private System.Windows.Forms.DataGridView dgvLunchList;
        private System.Windows.Forms.Button btnOgleOgunuKaldir;
        private System.Windows.Forms.Button btnTamamla;
    }
}