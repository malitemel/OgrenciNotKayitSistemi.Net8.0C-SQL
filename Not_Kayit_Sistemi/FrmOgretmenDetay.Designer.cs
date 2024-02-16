namespace Not_Kayit_Sistemi
{
    partial class FrmOgretmenDetay
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label3 = new Label();
            TxtSoyad = new TextBox();
            label2 = new Label();
            TxtAd = new TextBox();
            MsksNumara = new MaskedTextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            TxtSinav3 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            TxtSinav2 = new TextBox();
            label5 = new Label();
            TxtSinav1 = new TextBox();
            groupBox3 = new GroupBox();
            lblKalanSayisi = new Label();
            lblGecenSayisi = new Label();
            lblOrtalama = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            sqlParameterCollectionBindingSource = new BindingSource(components);
            sqlConnectionBindingSource = new BindingSource(components);
            sqlCommandBindingSource = new BindingSource(components);
            sqlConnectionBindingSource1 = new BindingSource(components);
            sqlCommandBindingSource1 = new BindingSource(components);
            sqlConnectionBindingSource2 = new BindingSource(components);
            sqlCommandBindingSource2 = new BindingSource(components);
            databaseGeneratedAttributeBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sqlParameterCollectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sqlConnectionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sqlCommandBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sqlConnectionBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sqlCommandBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sqlConnectionBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sqlCommandBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseGeneratedAttributeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtSoyad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TxtAd);
            groupBox1.Controls.Add(MsksNumara);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(416, 283);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekle";
            // 
            // button1
            // 
            button1.Location = new Point(165, 216);
            button1.Name = "button1";
            button1.Size = new Size(237, 29);
            button1.TabIndex = 6;
            button1.Text = "Öğrenci Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 155);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 5;
            label3.Text = "Soyad :";
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(165, 148);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(237, 27);
            TxtSoyad.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 96);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 3;
            label2.Text = "Ad :";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(165, 89);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(237, 27);
            TxtAd.TabIndex = 2;
            // 
            // MsksNumara
            // 
            MsksNumara.Location = new Point(165, 31);
            MsksNumara.Mask = "0000";
            MsksNumara.Name = "MsksNumara";
            MsksNumara.Size = new Size(237, 27);
            MsksNumara.TabIndex = 1;
            MsksNumara.ValidatingType = typeof(int);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Numara :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(TxtSinav3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(TxtSinav2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(TxtSinav1);
            groupBox2.Location = new Point(434, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(418, 283);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sınav Notları";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 155);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 8;
            label6.Text = "Sınav 3 :";
            // 
            // TxtSinav3
            // 
            TxtSinav3.Location = new Point(169, 148);
            TxtSinav3.Name = "TxtSinav3";
            TxtSinav3.Size = new Size(237, 27);
            TxtSinav3.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(169, 216);
            button2.Name = "button2";
            button2.Size = new Size(237, 29);
            button2.TabIndex = 6;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 97);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 5;
            label4.Text = "Sınav 2 :";
            // 
            // TxtSinav2
            // 
            TxtSinav2.Location = new Point(169, 90);
            TxtSinav2.Name = "TxtSinav2";
            TxtSinav2.Size = new Size(237, 27);
            TxtSinav2.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 38);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 3;
            label5.Text = "Sınav 1 :";
            // 
            // TxtSinav1
            // 
            TxtSinav1.Location = new Point(169, 31);
            TxtSinav1.Name = "TxtSinav1";
            TxtSinav1.Size = new Size(237, 27);
            TxtSinav1.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblKalanSayisi);
            groupBox3.Controls.Add(lblGecenSayisi);
            groupBox3.Controls.Add(lblOrtalama);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(858, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(249, 283);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ortalama";
            // 
            // lblKalanSayisi
            // 
            lblKalanSayisi.AutoSize = true;
            lblKalanSayisi.Location = new Point(165, 155);
            lblKalanSayisi.Name = "lblKalanSayisi";
            lblKalanSayisi.Size = new Size(25, 20);
            lblKalanSayisi.TabIndex = 11;
            lblKalanSayisi.Text = "00";
            // 
            // lblGecenSayisi
            // 
            lblGecenSayisi.AutoSize = true;
            lblGecenSayisi.Location = new Point(165, 97);
            lblGecenSayisi.Name = "lblGecenSayisi";
            lblGecenSayisi.Size = new Size(25, 20);
            lblGecenSayisi.TabIndex = 10;
            lblGecenSayisi.Text = "00";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(169, 38);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(25, 20);
            lblOrtalama.TabIndex = 9;
            lblOrtalama.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 155);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 8;
            label7.Text = "Kalan Sayısı :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 97);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 5;
            label8.Text = "Geçen Sayısı :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 38);
            label9.Name = "label9";
            label9.Size = new Size(78, 20);
            label9.TabIndex = 3;
            label9.Text = "Ortalama :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(14, 305);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1093, 320);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sınıf Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1087, 294);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // sqlParameterCollectionBindingSource
            // 
            sqlParameterCollectionBindingSource.DataSource = typeof(Microsoft.Data.SqlClient.SqlParameterCollection);
            // 
            // sqlConnectionBindingSource
            // 
            sqlConnectionBindingSource.DataSource = typeof(Microsoft.Data.SqlClient.SqlConnection);
            // 
            // sqlCommandBindingSource
            // 
            sqlCommandBindingSource.DataSource = typeof(Microsoft.Data.SqlClient.SqlCommand);
            // 
            // sqlConnectionBindingSource1
            // 
            sqlConnectionBindingSource1.DataSource = typeof(System.Data.SqlClient.SqlConnection);
            // 
            // sqlCommandBindingSource1
            // 
            sqlCommandBindingSource1.DataSource = typeof(System.Data.SqlClient.SqlCommand);
            // 
            // sqlConnectionBindingSource2
            // 
            sqlConnectionBindingSource2.DataSource = typeof(System.Data.SqlClient.SqlConnection);
            // 
            // sqlCommandBindingSource2
            // 
            sqlCommandBindingSource2.DataSource = typeof(System.Data.SqlClient.SqlCommand);
            // 
            // databaseGeneratedAttributeBindingSource
            // 
            databaseGeneratedAttributeBindingSource.DataSource = typeof(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedAttribute);
            // 
            // FrmOgretmenDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1125, 637);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmOgretmenDetay";
            Text = "FrmOgretmenDetay";
            Load += FrmOgretmenDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlParameterCollectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlConnectionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlCommandBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlConnectionBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlCommandBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlConnectionBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlCommandBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseGeneratedAttributeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private TextBox TxtSoyad;
        private Label label2;
        private TextBox TxtAd;
        private MaskedTextBox MsksNumara;
        private Label label1;
        private Button button1;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox TxtSinav3;
        private Button button2;
        private Label label4;
        private TextBox TxtSinav2;
        private Label label5;
        private TextBox TxtSinav1;
        private GroupBox groupBox3;
        private Label lblKalanSayisi;
        private Label lblGecenSayisi;
        private Label lblOrtalama;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private BindingSource sqlParameterCollectionBindingSource;
        private BindingSource sqlCommandBindingSource1;
        private BindingSource sqlConnectionBindingSource;
        private BindingSource sqlCommandBindingSource;
        private BindingSource sqlConnectionBindingSource1;
        private BindingSource sqlConnectionBindingSource2;
        private BindingSource sqlCommandBindingSource2;
        private BindingSource databaseGeneratedAttributeBindingSource;
    }
}