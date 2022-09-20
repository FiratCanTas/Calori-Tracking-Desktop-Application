namespace PresentationLayer.Forms
{
    partial class FH_Dinner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FH_Dinner));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAraDinner = new System.Windows.Forms.TextBox();
            this.btnAksamOgunuEkle = new System.Windows.Forms.Button();
            this.dgvMealList = new System.Windows.Forms.DataGridView();
            this.dgvDinnerList = new System.Windows.Forms.DataGridView();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.btnAksamOgunuKaldir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinnerList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 91);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(880, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Akşam Yemeği Seçimi";
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
            this.btnAra.TabIndex = 25;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAraDinner
            // 
            this.txtAraDinner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAraDinner.Location = new System.Drawing.Point(207, 128);
            this.txtAraDinner.Name = "txtAraDinner";
            this.txtAraDinner.Size = new System.Drawing.Size(204, 29);
            this.txtAraDinner.TabIndex = 24;
            // 
            // btnAksamOgunuEkle
            // 
            this.btnAksamOgunuEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAksamOgunuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAksamOgunuEkle.Image = global::PresentationLayer.Properties.Resources.icons8_sent;
            this.btnAksamOgunuEkle.Location = new System.Drawing.Point(774, 350);
            this.btnAksamOgunuEkle.Name = "btnAksamOgunuEkle";
            this.btnAksamOgunuEkle.Size = new System.Drawing.Size(115, 37);
            this.btnAksamOgunuEkle.TabIndex = 23;
            this.btnAksamOgunuEkle.UseVisualStyleBackColor = false;
            this.btnAksamOgunuEkle.Click += new System.EventHandler(this.btnAksamOgunuEkle_Click);
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
            this.dgvMealList.TabIndex = 22;
            this.dgvMealList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMealList_CellClick);
            // 
            // dgvDinnerList
            // 
            this.dgvDinnerList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDinnerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDinnerList.Location = new System.Drawing.Point(935, 166);
            this.dgvDinnerList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvDinnerList.Name = "dgvDinnerList";
            this.dgvDinnerList.RowHeadersWidth = 51;
            this.dgvDinnerList.Size = new System.Drawing.Size(426, 404);
            this.dgvDinnerList.TabIndex = 21;
            this.dgvDinnerList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDinnerList_CellClick);
            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTamamla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamamla.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamamla.Location = new System.Drawing.Point(774, 420);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(115, 37);
            this.btnTamamla.TabIndex = 36;
            this.btnTamamla.Text = "Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // btnAksamOgunuKaldir
            // 
            this.btnAksamOgunuKaldir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAksamOgunuKaldir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAksamOgunuKaldir.Image = ((System.Drawing.Image)(resources.GetObject("btnAksamOgunuKaldir.Image")));
            this.btnAksamOgunuKaldir.Location = new System.Drawing.Point(774, 307);
            this.btnAksamOgunuKaldir.Name = "btnAksamOgunuKaldir";
            this.btnAksamOgunuKaldir.Size = new System.Drawing.Size(115, 37);
            this.btnAksamOgunuKaldir.TabIndex = 35;
            this.btnAksamOgunuKaldir.UseVisualStyleBackColor = false;
            this.btnAksamOgunuKaldir.Click += new System.EventHandler(this.btnAksamOgunuKaldir_Click);
            // 
            // FH_Dinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1397, 581);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.btnAksamOgunuKaldir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAraDinner);
            this.Controls.Add(this.btnAksamOgunuEkle);
            this.Controls.Add(this.dgvMealList);
            this.Controls.Add(this.dgvDinnerList);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FH_Dinner";
            this.Text = "FH_Dinner";
            this.Load += new System.EventHandler(this.FH_Dinner_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDinnerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAraDinner;
        private System.Windows.Forms.Button btnAksamOgunuEkle;
        private System.Windows.Forms.DataGridView dgvMealList;
        private System.Windows.Forms.DataGridView dgvDinnerList;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Button btnAksamOgunuKaldir;
    }
}