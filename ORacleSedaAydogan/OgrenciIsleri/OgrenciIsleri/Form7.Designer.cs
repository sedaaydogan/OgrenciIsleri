namespace OgrenciIsleri
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Adi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(343, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(451, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 38);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(10, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 40);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(917, 249);
            this.dataGridView1.TabIndex = 14;
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
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(974, 397);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form7";
            this.Text = "Traskript Al";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
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