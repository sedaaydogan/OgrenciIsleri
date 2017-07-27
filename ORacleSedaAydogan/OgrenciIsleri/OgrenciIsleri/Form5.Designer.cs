namespace OgrenciIsleri
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txtders = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnduzenle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbBolum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DERSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DERSADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOLUMADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdersid = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(66, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ders Adı:";
            // 
            // txtders
            // 
            this.txtders.Location = new System.Drawing.Point(166, 92);
            this.txtders.Name = "txtders";
            this.txtders.Size = new System.Drawing.Size(155, 20);
            this.txtders.TabIndex = 1;
            // 
            // btnkaydet
            // 
            this.btnkaydet.FlatAppearance.BorderSize = 0;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnkaydet.Image")));
            this.btnkaydet.Location = new System.Drawing.Point(445, 160);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(72, 48);
            this.btnkaydet.TabIndex = 2;
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnduzenle
            // 
            this.btnduzenle.FlatAppearance.BorderSize = 0;
            this.btnduzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnduzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnduzenle.Image")));
            this.btnduzenle.Location = new System.Drawing.Point(450, 240);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(63, 46);
            this.btnduzenle.TabIndex = 2;
            this.btnduzenle.UseVisualStyleBackColor = true;
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 45);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmbBolum
            // 
            this.cmbBolum.FormattingEnabled = true;
            this.cmbBolum.Location = new System.Drawing.Point(166, 53);
            this.cmbBolum.Name = "cmbBolum";
            this.cmbBolum.Size = new System.Drawing.Size(155, 21);
            this.cmbBolum.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bölüm Adı:";
            // 
            // btnsil
            // 
            this.btnsil.FlatAppearance.BorderSize = 0;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.Image")));
            this.btnsil.Location = new System.Drawing.Point(445, 313);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(72, 38);
            this.btnsil.TabIndex = 2;
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DERSID,
            this.DERSADI,
            this.BOLUMADI});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 160);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(384, 220);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DERSID
            // 
            this.DERSID.DataPropertyName = "DERSID";
            this.DERSID.HeaderText = "DERS ID";
            this.DERSID.Name = "DERSID";
            this.DERSID.Width = 81;
            // 
            // DERSADI
            // 
            this.DERSADI.DataPropertyName = "DERSADI";
            this.DERSADI.HeaderText = "DERS ADI";
            this.DERSADI.Name = "DERSADI";
            this.DERSADI.Width = 88;
            // 
            // BOLUMADI
            // 
            this.BOLUMADI.DataPropertyName = "BOLUMADI";
            this.BOLUMADI.HeaderText = "BOLUM ADI";
            this.BOLUMADI.Name = "BOLUMADI";
            this.BOLUMADI.Width = 98;
            // 
            // txtdersid
            // 
            this.txtdersid.Location = new System.Drawing.Point(173, 12);
            this.txtdersid.Name = "txtdersid";
            this.txtdersid.Size = new System.Drawing.Size(132, 20);
            this.txtdersid.TabIndex = 1;
            this.txtdersid.Visible = false;
            this.txtdersid.TextChanged += new System.EventHandler(this.txtdersid_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(66, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ders Ara:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Silinmis Dersler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(567, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBolum);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnduzenle);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtdersid);
            this.Controls.Add(this.txtders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form5";
            this.Text = "Ders İslemleri";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtders;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnduzenle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbBolum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DERSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DERSADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOLUMADI;
        private System.Windows.Forms.TextBox txtdersid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}