namespace OgrenciIsleri
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.SILBOLUMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SILBOLUMADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SILTELNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SILEMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SILBOLUMID,
            this.SILBOLUMADI,
            this.SILTELNO,
            this.SILEMAIL});
            this.dataGridView1.Location = new System.Drawing.Point(43, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 282);
            this.dataGridView1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(3, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 58);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SILBOLUMID
            // 
            this.SILBOLUMID.DataPropertyName = "SILBOLUMID";
            this.SILBOLUMID.HeaderText = "Id";
            this.SILBOLUMID.Name = "SILBOLUMID";
            this.SILBOLUMID.Width = 42;
            // 
            // SILBOLUMADI
            // 
            this.SILBOLUMADI.DataPropertyName = "SILBOLUMADI";
            this.SILBOLUMADI.HeaderText = "BÖLÜM ADI";
            this.SILBOLUMADI.Name = "SILBOLUMADI";
            this.SILBOLUMADI.Width = 98;
            // 
            // SILTELNO
            // 
            this.SILTELNO.DataPropertyName = "SILTELNO";
            this.SILTELNO.HeaderText = "TELEFON";
            this.SILTELNO.Name = "SILTELNO";
            this.SILTELNO.Width = 87;
            // 
            // SILEMAIL
            // 
            this.SILEMAIL.DataPropertyName = "SILEMAIL";
            this.SILEMAIL.HeaderText = "E-MAİL";
            this.SILEMAIL.Name = "SILEMAIL";
            this.SILEMAIL.Width = 72;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(521, 412);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form10";
            this.Text = "Silinmis Bolumler";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SILBOLUMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SILBOLUMADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SILTELNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SILEMAIL;
    }
}