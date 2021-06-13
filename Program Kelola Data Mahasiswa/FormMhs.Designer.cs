namespace Program_Kelola_Data_Mahasiswa
{
    partial class FormMhs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMhs));
            this.alamatMhs = new System.Windows.Forms.TextBox();
            this.namaMhs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nimMhs = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Option = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.print = new System.Windows.Forms.Button();
            this.correct = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.mhs_nim = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.axCrystalReport1 = new AxCrystal.AxCrystalReport();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCrystalReport1)).BeginInit();
            this.SuspendLayout();
            // 
            // alamatMhs
            // 
            this.alamatMhs.Location = new System.Drawing.Point(140, 84);
            this.alamatMhs.Margin = new System.Windows.Forms.Padding(2);
            this.alamatMhs.MaximumSize = new System.Drawing.Size(158, 22);
            this.alamatMhs.MaxLength = 100;
            this.alamatMhs.MinimumSize = new System.Drawing.Size(132, 22);
            this.alamatMhs.Name = "alamatMhs";
            this.alamatMhs.Size = new System.Drawing.Size(158, 20);
            this.alamatMhs.TabIndex = 33;
            // 
            // namaMhs
            // 
            this.namaMhs.Location = new System.Drawing.Point(140, 51);
            this.namaMhs.Margin = new System.Windows.Forms.Padding(2);
            this.namaMhs.MaximumSize = new System.Drawing.Size(4, 22);
            this.namaMhs.MaxLength = 20;
            this.namaMhs.MinimumSize = new System.Drawing.Size(132, 22);
            this.namaMhs.Name = "namaMhs";
            this.namaMhs.Size = new System.Drawing.Size(132, 22);
            this.namaMhs.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nama";
            // 
            // nimMhs
            // 
            this.nimMhs.Location = new System.Drawing.Point(140, 22);
            this.nimMhs.Margin = new System.Windows.Forms.Padding(2);
            this.nimMhs.MaximumSize = new System.Drawing.Size(132, 22);
            this.nimMhs.MaxLength = 8;
            this.nimMhs.MinimumSize = new System.Drawing.Size(88, 22);
            this.nimMhs.Name = "nimMhs";
            this.nimMhs.Size = new System.Drawing.Size(107, 20);
            this.nimMhs.TabIndex = 29;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(633, 435);
            this.Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(96, 58);
            this.Exit.TabIndex = 28;
            this.Exit.Text = "Tutup";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(521, 435);
            this.cancel.Margin = new System.Windows.Forms.Padding(2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(96, 58);
            this.cancel.TabIndex = 27;
            this.cancel.Text = "Batal";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(275, 28);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.MaximumSize = new System.Drawing.Size(132, 22);
            this.search.MinimumSize = new System.Drawing.Size(88, 26);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(132, 21);
            this.search.TabIndex = 20;
            this.search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Cari";
            // 
            // Option
            // 
            this.Option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Option.FormattingEnabled = true;
            this.Option.Items.AddRange(new object[] {
            "NIM",
            "Nama",
            "Alamat"});
            this.Option.Location = new System.Drawing.Point(79, 28);
            this.Option.Margin = new System.Windows.Forms.Padding(2);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(125, 23);
            this.Option.TabIndex = 21;
            this.Option.SelectedIndexChanged += new System.EventHandler(this.Option_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Pilihan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Alamat";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Option);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(73, 429);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(435, 63);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cari Data";
            // 
            // print
            // 
            this.print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(608, 127);
            this.print.Margin = new System.Windows.Forms.Padding(2);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(120, 44);
            this.print.TabIndex = 25;
            this.print.Text = "Cetak";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.Print_Click);
            // 
            // correct
            // 
            this.correct.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.correct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correct.Location = new System.Drawing.Point(344, 127);
            this.correct.Margin = new System.Windows.Forms.Padding(2);
            this.correct.Name = "correct";
            this.correct.Size = new System.Drawing.Size(120, 44);
            this.correct.TabIndex = 24;
            this.correct.Text = "Koreksi";
            this.correct.UseVisualStyleBackColor = true;
            this.correct.Click += new System.EventHandler(this.Correct_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(209, 127);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(120, 44);
            this.clear.TabIndex = 23;
            this.clear.Text = "Hapus";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(73, 127);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(120, 44);
            this.save.TabIndex = 22;
            this.save.Text = "Simpan";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // mhs_nim
            // 
            this.mhs_nim.AutoSize = true;
            this.mhs_nim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mhs_nim.Location = new System.Drawing.Point(69, 24);
            this.mhs_nim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mhs_nim.Name = "mhs_nim";
            this.mhs_nim.Size = new System.Drawing.Size(35, 17);
            this.mhs_nim.TabIndex = 21;
            this.mhs_nim.Text = "NIM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 192);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 218);
            this.dataGridView1.TabIndex = 20;
            // 
            // axCrystalReport1
            // 
            this.axCrystalReport1.Enabled = true;
            this.axCrystalReport1.Location = new System.Drawing.Point(521, 127);
            this.axCrystalReport1.Name = "axCrystalReport1";
            this.axCrystalReport1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCrystalReport1.OcxState")));
            this.axCrystalReport1.Size = new System.Drawing.Size(28, 28);
            this.axCrystalReport1.TabIndex = 34;
            // 
            // FormMhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Program_Kelola_Data_Mahasiswa.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 515);
            this.Controls.Add(this.axCrystalReport1);
            this.Controls.Add(this.alamatMhs);
            this.Controls.Add(this.namaMhs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nimMhs);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.print);
            this.Controls.Add(this.correct);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.mhs_nim);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMhs";
            this.Text = "Program Kelola Data Mahasiswa";
            this.Load += new System.EventHandler(this.FormMhs_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMhs_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axCrystalReport1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox alamatMhs;
        private System.Windows.Forms.TextBox namaMhs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nimMhs;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Option;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button correct;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label mhs_nim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AxCrystal.AxCrystalReport axCrystalReport1;
    }
}

