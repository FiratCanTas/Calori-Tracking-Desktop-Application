namespace PresentationLayer.Forms
{
    partial class FH_Snacks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FH_Snacks));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtAraSnacks = new System.Windows.Forms.TextBox();
            this.dgvMealList = new System.Windows.Forms.DataGridView();
            this.dgvSnacksList = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnAraOgunEkle = new System.Windows.Forms.Button();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.btnAraOgunuKaldir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSnacksList)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(905, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ara Öğün Seçimi";
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
            // txtAraSnacks
            // 
            this.txtAraSnacks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAraSnacks.Location = new System.Drawing.Point(207, 128);
            this.txtAraSnacks.Name = "txtAraSnacks";
            this.txtAraSnacks.Size = new System.Drawing.Size(204, 29);
            this.txtAraSnacks.TabIndex = 30;
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
            this.dgvMealList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMealList_CellClick);
            // 
            // dgvSnacksList
            // 
            this.dgvSnacksList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSnacksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSnacksList.Location = new System.Drawing.Point(935, 166);
            this.dgvSnacksList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvSnacksList.Name = "dgvSnacksList";
            this.dgvSnacksList.RowHeadersWidth = 51;
            this.dgvSnacksList.Size = new System.Drawing.Size(426, 404);
            this.dgvSnacksList.TabIndex = 27;
            this.dgvSnacksList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSnacksList_CellClick);
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
            // btnAraOgunEkle
            // 
            this.btnAraOgunEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAraOgunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAraOgunEkle.Image = global::PresentationLayer.Properties.Resources.icons8_sent;
            this.btnAraOgunEkle.Location = new System.Drawing.Point(774, 350);
            this.btnAraOgunEkle.Name = "btnAraOgunEkle";
            this.btnAraOgunEkle.Size = new System.Drawing.Size(115, 37);
            this.btnAraOgunEkle.TabIndex = 29;
            this.btnAraOgunEkle.UseVisualStyleBackColor = false;
            this.btnAraOgunEkle.Click += new System.EventHandler(this.btnAraOgunEkle_Click);
            // 
            // btnTamamla
            // 
            this.btnTamamla.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTamamla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTamamla.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamamla.Location = new System.Drawing.Point(774, 420);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(115, 37);
            this.btnTamamla.TabIndex = 38;
            this.btnTamamla.Text = "Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // btnAraOgunuKaldir
            // 
            this.btnAraOgunuKaldir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAraOgunuKaldir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAraOgunuKaldir.Image = ((System.Drawing.Image)(resources.GetObject("btnAraOgunuKaldir.Image")));
            this.btnAraOgunuKaldir.Location = new System.Drawing.Point(774, 307);
            this.btnAraOgunuKaldir.Name = "btnAraOgunuKaldir";
            this.btnAraOgunuKaldir.Size = new System.Drawing.Size(115, 37);
            this.btnAraOgunuKaldir.TabIndex = 37;
            this.btnAraOgunuKaldir.UseVisualStyleBackColor = false;
            this.btnAraOgunuKaldir.Click += new System.EventHandler(this.btnAraOgunuKaldir_Click);
            // 
            // FH_Snacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1397, 581);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.btnAraOgunuKaldir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAraSnacks);
            this.Controls.Add(this.btnAraOgunEkle);
            this.Controls.Add(this.dgvMealList);
            this.Controls.Add(this.dgvSnacksList);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FH_Snacks";
            this.Text = "FH_Snacks";
            this.Load += new System.EventHandler(this.FH_Snacks_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSnacksList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAraSnacks;
        private System.Windows.Forms.Button btnAraOgunEkle;
        private System.Windows.Forms.DataGridView dgvMealList;
        private System.Windows.Forms.DataGridView dgvSnacksList;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Button btnAraOgunuKaldir;
    }
}