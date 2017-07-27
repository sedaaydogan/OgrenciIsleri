namespace OgrenciIsleri
{
    partial class Form8
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
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
            this.txtara = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btndon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(24, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 249);
            this.dataGridView1.TabIndex = 13;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 44;
            // 
            // DERSADI
            // 
            this.DERSADI.DataPropertyName = "DERSADI";
            this.DERSADI.HeaderText = "DERS ADI";
            this.DERSADI.Name = "DERSADI";
            this.DERSADI.Width = 88;
            // 
            // VIZE
            // 
            this.VIZE.DataPropertyName = "VIZE";
            this.VIZE.HeaderText = "VIZE";
            this.VIZE.Name = "VIZE";
            this.VIZE.Width = 57;
            // 
            // FINAL
            // 
            this.FINAL.DataPropertyName = "FINAL";
            this.FINAL.HeaderText = "FINAL";
            this.FINAL.Name = "FINAL";
            this.FINAL.Width = 65;
            // 
            // ORTALAMA
            // 
            this.ORTALAMA.DataPropertyName = "ORTALAMA";
            this.ORTALAMA.HeaderText = "ORTALAMA";
            this.ORTALAMA.Name = "ORTALAMA";
            this.ORTALAMA.Width = 96;
            // 
            // HARF
            // 
            this.HARF.DataPropertyName = "HARF";
            this.HARF.HeaderText = "HARF";
            this.HARF.Name = "HARF";
            this.HARF.Width = 64;
            // 
            // OGRENCI_ID
            // 
            this.OGRENCI_ID.DataPropertyName = "OGRENCI_ID";
            this.OGRENCI_ID.HeaderText = "OGRENCI NO";
            this.OGRENCI_ID.Name = "OGRENCI_ID";
            this.OGRENCI_ID.Width = 108;
            // 
            // ADI
            // 
            this.ADI.DataPropertyName = "ADI";
            this.ADI.HeaderText = "ADI";
            this.ADI.Name = "ADI";
            this.ADI.Width = 51;
            // 
            // SOYADI
            // 
            this.SOYADI.DataPropertyName = "SOYADI";
            this.SOYADI.HeaderText = "SOYADI";
            this.SOYADI.Name = "SOYADI";
            this.SOYADI.Width = 75;
            // 
            // txtara
            // 
            this.txtara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtara.Location = new System.Drawing.Point(143, 78);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(160, 21);
            this.txtara.TabIndex = 16;
            this.txtara.TextChanged += new System.EventHandler(this.txtara_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(328, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 41);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndon
            // 
            this.btndon.FlatAppearance.BorderSize = 0;
            this.btndon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndon.Image = ((System.Drawing.Image)(resources.GetObject("btndon.Image")));
            this.btndon.Location = new System.Drawing.Point(12, 12);
            this.btndon.Name = "btndon";
            this.btndon.Size = new System.Drawing.Size(59, 45);
            this.btndon.TabIndex = 18;
            this.btndon.UseVisualStyleBackColor = true;
            this.btndon.Click += new System.EventHandler(this.btndon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(55, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ogrenci No:";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(790, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Excel Cikti Al";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btndon;
        private System.Windows.Forms.Label label1;
    }
}