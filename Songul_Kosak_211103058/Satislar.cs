using Songul_Kosak_211103058.DAL;
using Songul_Kosak_211103058.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Songul_Kosak_211103058
{
    public partial class Satislar : Form
    {
        private int Id = 0;
        Database database = new Database();
        public Satislar()
        {
            InitializeComponent();
        }
        private void ToplamUcretHesaplama()
        {
            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells["ucret"].Value);
            }
            label2.Text = toplam.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView1[0, e.RowIndex].Value;
            comboBox_filmadi.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            comboBox_filmseans.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            comboBox_salon.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox_adsoyad.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox_koltukno.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox_telno.Text = dataGridView1[6, e.RowIndex].Value.ToString();
            textBox_ucret.Text = dataGridView1[7, e.RowIndex].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1[8, e.RowIndex].Value;
        }

        private void button_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_filmadi.Text == "" || textBox_adsoyad.Text == "" || comboBox_filmseans.Text == "" || textBox_telno.Text == "" || textBox_ucret.Text == "" || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Lütfen Geçerli Alanları Doldurunuz!", "Sistem Bildirimi Penceresi");
                }
                else
                {
                    Satis2 kaydet = new Satis2();
                    kaydet.FilmAdi = comboBox_filmadi.Text;
                    kaydet.AdSoyad = textBox_adsoyad.Text;
                    kaydet.Seansi = comboBox_filmseans.Text;
                    kaydet.SalonAdi = comboBox_salon.Text;
                    kaydet.KoltukNo = Convert.ToInt32(textBox_koltukno.Text);
                    kaydet.TelNo = textBox_telno.Text;
                    kaydet.Ucret = textBox_ucret.Text;
                    kaydet.SatisTarihi = dateTimePicker1.Value;
                    kaydet.SatisId = Id;
                    new Database().SatisGuncelle(kaydet);
                    GridGuncelleme();
                }
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void GridGuncelleme()
        {
            try
            {
                dataGridView1.DataSource = new Database().SatisListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Satislar_Load(object sender, EventArgs e)
        {
            GridGuncelleme();
            ToplamUcretHesaplama();
        }
    }
}
