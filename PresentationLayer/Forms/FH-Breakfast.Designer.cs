namespace PresentationLayer.Forms
{
    partial class FH_Breakfast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FH_Breakfast));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAraBreakfast = new System.Windows.Forms.TextBox();
            this.btnKahvaltiEkle = new System.Windows.Forms.Button();
            this.dgvMealList = new System.Windows.Forms.DataGridView();
            this.dgvBreakfastList = new System.Windows.Forms.DataGridView();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.btnKahvaltiOgunuKaldir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreakfastList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 91);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(884, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kahvaltı Seçimi";
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
            this.btnAra.Location = new System.Drawing.Point(428, 122);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(48, 36);
            this.btnAra.TabIndex = 13;
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAraBreakfast
            // 
            this.txtAraBreakfast.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAraBreakfast.Location = new System.Drawing.Point(207, 126);
            this.txtAraBreakfast.Name = "txtAraBreakfast";
            this.txtAraBreakfast.Size = new System.Drawing.Size(204, 29);
            this.txtAraBreakfast.TabIndex = 12;
            // 
            // btnKahvaltiEkle
            // 
            this.btnKahvaltiEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKahvaltiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKahvaltiEkle.Image = global::PresentationLayer.Properties.Resources.icons8_sent;
            this.btnKahvaltiEkle.Location = new System.Drawing.Point(774, 348);
            this.btnKahvaltiEkle.Name = "btnKahvaltiEkle";
            this.btnKahvaltiEkle.Size = new System.Drawing.Size(115, 37);
            this.btnKahvaltiEkle.TabIndex = 11;
            this.btnKahvaltiEkle.UseVisualStyleBackColor = false;
            this.btnKahvaltiEkle.Click += new System.EventHandler(this.btnKahvaltiEkle_Click);
            // 
            // dgvMealList
            // 
            this.dgvMealList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMealList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealList.Location = new System.Drawing.Point(12, 164);
            this.dgvMealList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvMealList.Name = "dgvMealList";
            this.dgvMealList.RowHeadersWidth = 51;
            this.dgvMealList.Size = new System.Drawing.Size(717, 404);
            this.dgvMealList.TabIndex = 10;
            this.dgvMealList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMealList_CellClick);
            // 
            // dgvBreakfastList
            // 
            this.dgvBreakfastList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBreakfastList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBreakfastList.Location = new System.Drawing.Point(935, 164);
            this.dgvBreakfastList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvBreakfastList.Name = "dgvBreakfastList";
            this.dgvBreakfastList.RowHeadersWidth = 51;
            this.dgvBreakfastList.Size = new System.Drawing.Size(426, 404);
            this.dgvBreakfastList.TabIndex = 9;
            this.dgvBreakfastList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBreakfastList_CellClick);
            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTamamla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamamla.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamamla.Location = new System.Drawing.Point(774, 418);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(115, 37);
            this.btnTamamla.TabIndex = 38;
            this.btnTamamla.Text = "Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // btnKahvaltiOgunuKaldir
            // 
            this.btnKahvaltiOgunuKaldir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKahvaltiOgunuKaldir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKahvaltiOgunuKaldir.Image = ((System.Drawing.Image)(resources.GetObject("btnKahvaltiOgunuKaldir.Image")));
            this.btnKahvaltiOgunuKaldir.Location = new System.Drawing.Point(774, 305);
            this.btnKahvaltiOgunuKaldir.Name = "btnKahvaltiOgunuKaldir";
            this.btnKahvaltiOgunuKaldir.Size = new System.Drawing.Size(115, 37);
            this.btnKahvaltiOgunuKaldir.TabIndex = 37;
            this.btnKahvaltiOgunuKaldir.UseVisualStyleBackColor = false;
            this.btnKahvaltiOgunuKaldir.Click += new System.EventHandler(this.btnKahvaltiOgunuKaldir_Click);
            // 
            // FH_Breakfast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1397, 581);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.btnKahvaltiOgunuKaldir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAraBreakfast);
            this.Controls.Add(this.btnKahvaltiEkle);
            this.Controls.Add(this.dgvMealList);
            this.Controls.Add(this.dgvBreakfastList);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FH_Breakfast";
            this.Text = "FH_Breakfast";
            this.Load += new System.EventHandler(this.FH_Breakfast_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBreakfastList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAraBreakfast;
        private System.Windows.Forms.Button btnKahvaltiEkle;
        private System.Windows.Forms.DataGridView dgvMealList;
        private System.Windows.Forms.DataGridView dgvBreakfastList;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Button btnKahvaltiOgunuKaldir;
    }
}