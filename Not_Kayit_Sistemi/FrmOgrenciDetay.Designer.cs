
namespace Not_Kayit_Sistemi
{
    partial class FrmOgrenciDetay
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblAdSoyad = new Label();
            lblNumara = new Label();
            label8 = new Label();
            label9 = new Label();
            lblSinav1 = new Label();
            lblSinav2 = new Label();
            lblSinav3 = new Label();
            lblOrtalama = new Label();
            lblDurum = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 89);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Numara :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 157);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 2;
            label3.Text = "Sınav 1 :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 203);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "Sınav 2 :";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 253);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 4;
            label5.Text = "Sınav 3 :";
            label5.Click += label5_Click;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(132, 36);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(44, 20);
            lblAdSoyad.TabIndex = 5;
            lblAdSoyad.Text = "NULL";
            lblAdSoyad.Click += label6_Click;
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(132, 89);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(41, 20);
            lblNumara.TabIndex = 6;
            lblNumara.Text = "0000";
            lblNumara.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 325);
            label8.Name = "label8";
            label8.Size = new Size(78, 20);
            label8.TabIndex = 7;
            label8.Text = "Ortalama :";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 367);
            label9.Name = "label9";
            label9.Size = new Size(61, 20);
            label9.TabIndex = 8;
            label9.Text = "Durum :";
            label9.Click += label9_Click;
            // 
            // lblSinav1
            // 
            lblSinav1.AutoSize = true;
            lblSinav1.Location = new Point(132, 157);
            lblSinav1.Name = "lblSinav1";
            lblSinav1.Size = new Size(25, 20);
            lblSinav1.TabIndex = 9;
            lblSinav1.Text = "00";
            // 
            // lblSinav2
            // 
            lblSinav2.AutoSize = true;
            lblSinav2.Location = new Point(132, 203);
            lblSinav2.Name = "lblSinav2";
            lblSinav2.Size = new Size(25, 20);
            lblSinav2.TabIndex = 10;
            lblSinav2.Text = "00";
            // 
            // lblSinav3
            // 
            lblSinav3.AutoSize = true;
            lblSinav3.Location = new Point(132, 253);
            lblSinav3.Name = "lblSinav3";
            lblSinav3.Size = new Size(25, 20);
            lblSinav3.TabIndex = 11;
            lblSinav3.Text = "00";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(132, 325);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(25, 20);
            lblOrtalama.TabIndex = 12;
            lblOrtalama.Text = "00";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(132, 367);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(44, 20);
            lblDurum.TabIndex = 13;
            lblDurum.Text = "NULL";
            // 
            // FrmOgrenciDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(625, 461);
            Controls.Add(lblDurum);
            Controls.Add(lblOrtalama);
            Controls.Add(lblSinav3);
            Controls.Add(lblSinav2);
            Controls.Add(lblSinav1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lblNumara);
            Controls.Add(lblAdSoyad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmOgrenciDetay";
            Text = "Öğrenci Not Kayıt Sistemi";
            Load += FrmOgrenciDetay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblAdSoyad;
        private Label lblNumara;
        private Label label8;
        private Label label9;
        private Label lblSinav1;
        private Label lblSinav2;
        private Label lblSinav3;
        private Label lblOrtalama;
        private Label lblDurum;
    }
}