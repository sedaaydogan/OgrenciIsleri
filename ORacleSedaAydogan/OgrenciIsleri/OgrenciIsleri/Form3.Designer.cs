namespace OgrenciIsleri
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttc = new System.Windows.Forms.TextBox();
            this.cmbbolum = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbsinif = new System.Windows.Forms.ComboBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtogrencino = new System.Windows.Forms.TextBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TCNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOYADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KAYITTARIHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOLUMADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SINIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEPTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOGUMTARIHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDOGRENCI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.txtogrenciid = new System.Windows.Forms.TextBox();
            this.txtresimyolu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıt Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "TC Kimlik No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(79, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(60, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Soyadı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(54, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bölümü";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(36, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Öğrenci No";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(74, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sınıf";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(67, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adres";
            // 
            // txttc
            // 
            this.txttc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttc.Location = new System.Drawing.Point(141, 137);
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(197, 21);
            this.txttc.TabIndex = 1;
            // 
            // cmbbolum
            // 
            this.cmbbolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbolum.FormattingEnabled = true;
            this.cmbbolum.Location = new System.Drawing.Point(141, 279);
            this.cmbbolum.Name = "cmbbolum";
            this.cmbbolum.Size = new System.Drawing.Size(197, 23);
            this.cmbbolum.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(56, 470);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cep No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(22, 524);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Doğum Tarihi";
            // 
            // cmbsinif
            // 
            this.cmbsinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbsinif.FormattingEnabled = true;
            this.cmbsinif.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbsinif.Location = new System.Drawing.Point(141, 374);
            this.cmbsinif.Name = "cmbsinif";
            this.cmbsinif.Size = new System.Drawing.Size(197, 23);
            this.cmbsinif.TabIndex = 2;
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(141, 182);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(197, 21);
            this.txtad.TabIndex = 1;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Location = new System.Drawing.Point(141, 229);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(197, 21);
            this.txtsoyad.TabIndex = 1;
            // 
            // txtogrencino
            // 
            this.txtogrencino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrencino.Location = new System.Drawing.Point(142, 325);
            this.txtogrencino.Name = "txtogrencino";
            this.txtogrencino.Size = new System.Drawing.Size(197, 21);
            this.txtogrencino.TabIndex = 1;
            this.txtogrencino.Visible = false;
            // 
            // txtadres
            // 
            this.txtadres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadres.Location = new System.Drawing.Point(142, 423);
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(197, 21);
            this.txtadres.TabIndex = 1;
            // 
            // btnkaydet
            // 
            this.btnkaydet.FlatAppearance.BorderSize = 0;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Font = new System.Drawing.Font("Algerian", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(547, 63);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(77, 43);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(12, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 48);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 21);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(143, 524);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(197, 21);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(143, 470);
            this.maskedTextBox1.Mask = "0(999) 000 00 00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(197, 21);
            this.maskedTextBox1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TCNO,
            this.ADI,
            this.SOYADI,
            this.KAYITTARIHI,
            this.BOLUMADI,
            this.SINIF,
            this.ADRES,
            this.CEPTEL,
            this.DOGUMTARIHI,
            this.IDOGRENCI});
            this.dataGridView1.Location = new System.Drawing.Point(409, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 493);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TCNO
            // 
            this.TCNO.DataPropertyName = "TCNO";
            this.TCNO.HeaderText = "TC NO";
            this.TCNO.Name = "TCNO";
            this.TCNO.Width = 63;
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
            // KAYITTARIHI
            // 
            this.KAYITTARIHI.DataPropertyName = "KAYITTARIHI";
            this.KAYITTARIHI.HeaderText = "KAYIT TARIHI";
            this.KAYITTARIHI.Name = "KAYITTARIHI";
            this.KAYITTARIHI.Width = 96;
            // 
            // BOLUMADI
            // 
            this.BOLUMADI.DataPropertyName = "BOLUMADI";
            this.BOLUMADI.HeaderText = "BOLUM ADI";
            this.BOLUMADI.Name = "BOLUMADI";
            this.BOLUMADI.Width = 90;
            // 
            // SINIF
            // 
            this.SINIF.DataPropertyName = "SINIF";
            this.SINIF.HeaderText = "SINIF";
            this.SINIF.Name = "SINIF";
            this.SINIF.Width = 62;
            // 
            // ADRES
            // 
            this.ADRES.DataPropertyName = "ADRES";
            this.ADRES.HeaderText = "ADRES";
            this.ADRES.Name = "ADRES";
            this.ADRES.Width = 73;
            // 
            // CEPTEL
            // 
            this.CEPTEL.DataPropertyName = "CEPTEL";
            this.CEPTEL.HeaderText = "CEPTEL";
            this.CEPTEL.Name = "CEPTEL";
            this.CEPTEL.Width = 78;
            // 
            // DOGUMTARIHI
            // 
            this.DOGUMTARIHI.DataPropertyName = "DOGUMTARIHI";
            this.DOGUMTARIHI.HeaderText = "DOGUM TARIHI";
            this.DOGUMTARIHI.Name = "DOGUMTARIHI";
            this.DOGUMTARIHI.Width = 110;
            // 
            // IDOGRENCI
            // 
            this.IDOGRENCI.DataPropertyName = "IDOGRENCI";
            this.IDOGRENCI.HeaderText = "OGRENCI NO";
            this.IDOGRENCI.Name = "IDOGRENCI";
            this.IDOGRENCI.Width = 99;
            // 
            // btnsil
            // 
            this.btnsil.FlatAppearance.BorderSize = 0;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Algerian", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.Image")));
            this.btnsil.Location = new System.Drawing.Point(646, 63);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(71, 40);
            this.btnsil.TabIndex = 14;
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.FlatAppearance.BorderSize = 0;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Font = new System.Drawing.Font("Algerian", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(750, 64);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(70, 40);
            this.btnDuzenle.TabIndex = 15;
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // txtogrenciid
            // 
            this.txtogrenciid.Location = new System.Drawing.Point(1129, 39);
            this.txtogrenciid.Name = "txtogrenciid";
            this.txtogrenciid.Size = new System.Drawing.Size(116, 21);
            this.txtogrenciid.TabIndex = 16;
            // 
            // txtresimyolu
            // 
            this.txtresimyolu.Location = new System.Drawing.Point(1129, 12);
            this.txtresimyolu.Name = "txtresimyolu";
            this.txtresimyolu.Size = new System.Drawing.Size(116, 21);
            this.txtresimyolu.TabIndex = 17;
            this.txtresimyolu.Visible = false;
            this.txtresimyolu.TextChanged += new System.EventHandler(this.txtresimyolu_TextChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1224, 666);
            this.Controls.Add(this.txtresimyolu);
            this.Controls.Add(this.txtogrenciid);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbsinif);
            this.Controls.Add(this.cmbbolum);
            this.Controls.Add(this.txtadres);
            this.Controls.Add(this.txtogrencino);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txttc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form3";
            this.Text = "Ogrenci KAyit";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.ComboBox cmbbolum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbsinif;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtogrencino;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.TextBox txtogrenciid;
        private System.Windows.Forms.TextBox txtresimyolu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOYADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn KAYITTARIHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOLUMADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SINIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEPTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOGUMTARIHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOGRENCI;
    }
}