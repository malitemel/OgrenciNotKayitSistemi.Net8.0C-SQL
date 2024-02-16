﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Not_Kayit_Sistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-R2437GRG\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True;Encrypt=False");
        void ogrenciGetir()
        {
            baglanti.Open();
            da = new SqlDataAdapter("select * from TBLDERS", baglanti);
            DataTable tabl = new DataTable();
            da.Fill(tabl);
            dataGridView1.DataSource = tabl;
            baglanti.Close();

        }
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            ogrenciGetir();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA,OGRAD,OGSOYAD) values (@P1,@P2,@P3)", baglanti);
            komut.Parameters.AddWithValue("@P1", MsksNumara.Text);
            komut.Parameters.AddWithValue("@P2", TxtAd.Text);
            komut.Parameters.AddWithValue("@P3", TxtSoyad.Text);
            komut.ExecuteNonQuery();
            da = new SqlDataAdapter("select * from TBLDERS", baglanti);
            DataTable tabl = new DataTable();
            da.Fill(tabl);
            dataGridView1.DataSource = tabl;
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtSinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            TxtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MsksNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(TxtSinav1.Text);
            s2 = Convert.ToDouble(TxtSinav2.Text);
            s3 = Convert.ToDouble(TxtSinav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblOrtalama.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLDERS set OGRS1=@P1,OGRS2=@P2,OGRS3=@P3,ORTALAMA=@P4,DURUM=@P5 WHERE OGRNUMARA=@P6",baglanti);
            komut.Parameters.AddWithValue("@P1", TxtSinav1.Text);
            komut.Parameters.AddWithValue("@P2", TxtSinav2.Text);
            komut.Parameters.AddWithValue("@P3", TxtSinav3.Text);
            komut.Parameters.AddWithValue("@P4", decimal.Parse(lblOrtalama.Text));
            komut.Parameters.AddWithValue("@P5", durum);
            komut.Parameters.AddWithValue("@P6", MsksNumara.Text);
            komut.ExecuteNonQuery();

            da = new SqlDataAdapter("select * from TBLDERS", baglanti);
            DataTable tabl = new DataTable();
            da.Fill(tabl);
            dataGridView1.DataSource = tabl;

            baglanti.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi");

        }
    }
}
