namespace OgrenciIsleri
{
    partial class Form12
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DERSADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VIZE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FINAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORTALAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HARF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OGRENCI_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOYADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DERSADI,
            this.VIZE,
            this.FINAL,
            this.ORTALAMA,
            this.HARF,
            this.OGRENCI_ID,
            this.ADI,
            this.SOYADI});
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 249);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // DERSADI
            // 
            this.DERSADI.DataPropertyName = "DERSADI";
            this.DERSADI.HeaderText = "DERS ADI";
            this.DERSADI.Name = "DERSADI";
            // 
            // VIZE
            // 
            this.VIZE.DataPropertyName = "VIZE";
            this.VIZE.HeaderText = "VIZE";
            this.VIZE.Name = "VIZE";
            // 
            // FINAL
            // 
            this.FINAL.DataPropertyName = "FINAL";
            this.FINAL.HeaderText = "FINAL";
            this.FINAL.Name = "FINAL";
            // 
            // ORTALAMA
            // 
            this.ORTALAMA.DataPropertyName = "ORTALAMA";
            this.ORTALAMA.HeaderText = "ORTALAMA";
            this.ORTALAMA.Name = "ORTALAMA";
            // 
            // HARF
            // 
            this.HARF.DataPropertyName = "HARF";
            this.HARF.HeaderText = "HARF";
            this.HARF.Name = "HARF";
            // 
            // OGRENCI_ID
            // 
            this.OGRENCI_ID.DataPropertyName = "OGRENCI_ID";
            this.OGRENCI_ID.HeaderText = "OGRENCI NO";
            this.OGRENCI_ID.Name = "OGRENCI_ID";
            // 
            // ADI
            // 
            this.ADI.DataPropertyName = "ADI";
            this.ADI.HeaderText = "ADI";
            this.ADI.Name = "ADI";
            // 
            // SOYADI
            // 
            this.SOYADI.DataPropertyName = "SOYADI";
            this.SOYADI.HeaderText = "SOYADI";
            this.SOYADI.Name = "SOYADI";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 366);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form12";
            this.Text = "Ogrencı not gorsun";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DERSADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIZE;
        private System.Windows.Forms.DataGridViewTextBoxColumn FINAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORTALAMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HARF;
        private System.Windows.Forms.DataGridViewTextBoxColumn OGRENCI_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOYADI;
    }
}