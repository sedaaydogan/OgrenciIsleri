namespace OgrenciIsleri
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvize = new System.Windows.Forms.TextBox();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtortalama = new System.Windows.Forms.TextBox();
            this.txtharfnotu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbogrencino = new System.Windows.Forms.ComboBox();
            this.cmbdersadi = new System.Windows.Forms.ComboBox();
            this.btnhesapla = new System.Windows.Forms.Button();
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
            this.txtnotid = new System.Windows.Forms.TextBox();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtogrenciid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(66, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ders Adı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(60, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vize Notu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(56, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Final Notu";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtvize
            // 
            this.txtvize.Location = new System.Drawing.Point(168, 170);
            this.txtvize.Name = "txtvize";
            this.txtvize.Size = new System.Drawing.Size(140, 21);
            this.txtvize.TabIndex = 6;
            // 
            // txtfinal
            // 
            this.txtfinal.Location = new System.Drawing.Point(168, 222);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.Size = new System.Drawing.Size(140, 21);
            this.txtfinal.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(347, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ortalama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(346, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Harf Notu";
            // 
            // txtortalama
            // 
            this.txtortalama.Location = new System.Drawing.Point(422, 170);
            this.txtortalama.Name = "txtortalama";
            this.txtortalama.Size = new System.Drawing.Size(94, 21);
            this.txtortalama.TabIndex = 6;
            this.txtortalama.TextChanged += new System.EventHandler(this.txtortalama_TextChanged);
            // 
            // txtharfnotu
            // 
            this.txtharfnotu.Location = new System.Drawing.Point(422, 225);
            this.txtharfnotu.Name = "txtharfnotu";
            this.txtharfnotu.Size = new System.Drawing.Size(94, 21);
            this.txtharfnotu.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(717, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 36);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(645, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 36);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(12, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 37);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbogrencino
            // 
            this.cmbogrencino.FormattingEnabled = true;
            this.cmbogrencino.Location = new System.Drawing.Point(168, 48);
            this.cmbogrencino.Name = "cmbogrencino";
            this.cmbogrencino.Size = new System.Drawing.Size(140, 23);
            this.cmbogrencino.TabIndex = 9;
            this.cmbogrencino.SelectedIndexChanged += new System.EventHandler(this.cmbogrencino_SelectedIndexChanged);
            // 
            // cmbdersadi
            // 
            this.cmbdersadi.FormattingEnabled = true;
            this.cmbdersadi.Location = new System.Drawing.Point(168, 98);
            this.cmbdersadi.Name = "cmbdersadi";
            this.cmbdersadi.Size = new System.Drawing.Size(140, 23);
            this.cmbdersadi.TabIndex = 10;
            this.cmbdersadi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnhesapla
            // 
            this.btnhesapla.FlatAppearance.BorderSize = 0;
            this.btnhesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhesapla.Image = ((System.Drawing.Image)(resources.GetObject("btnhesapla.Image")));
            this.btnhesapla.Location = new System.Drawing.Point(552, 225);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(72, 40);
            this.btnhesapla.TabIndex = 11;
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.dataGridView1.Location = new System.Drawing.Point(56, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 287);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.DERSADI.Width = 81;
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
            this.OGRENCI_ID.Width = 99;
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
            // txtnotid
            // 
            this.txtnotid.Location = new System.Drawing.Point(422, 39);
            this.txtnotid.Name = "txtnotid";
            this.txtnotid.Size = new System.Drawing.Size(35, 21);
            this.txtnotid.TabIndex = 13;
            this.txtnotid.Visible = false;
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(481, 39);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(35, 21);
            this.txtadi.TabIndex = 13;
            this.txtadi.Visible = false;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(573, 39);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(35, 21);
            this.txtsoyad.TabIndex = 13;
            this.txtsoyad.Visible = false;
            // 
            // txtogrenciid
            // 
            this.txtogrenciid.Location = new System.Drawing.Point(640, 39);
            this.txtogrenciid.Name = "txtogrenciid";
            this.txtogrenciid.Size = new System.Drawing.Size(24, 21);
            this.txtogrenciid.TabIndex = 14;
            this.txtogrenciid.Visible = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(846, 577);
            this.Controls.Add(this.txtogrenciid);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtadi);
            this.Controls.Add(this.txtnotid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.cmbdersadi);
            this.Controls.Add(this.cmbogrencino);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtharfnotu);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.txtortalama);
            this.Controls.Add(this.txtvize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form6";
            this.Text = "Ogrenci Not Girisi";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtvize;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtortalama;
        private System.Windows.Forms.TextBox txtharfnotu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbogrencino;
        private System.Windows.Forms.ComboBox cmbdersadi;
        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtnotid;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtogrenciid;
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