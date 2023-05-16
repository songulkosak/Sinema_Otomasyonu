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
    public partial class FilmEkle : Form
    {
        Database database = new Database();
        private int Id = 0;
        public FilmEkle()
        {
            InitializeComponent();
        }

        private void button_afis_Click(object sender, EventArgs e)
        {
            GridGuncelleme();
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
        private void GridGuncelleme()
        {
            try
            {
                dataGridView1.DataSource = new Database().FilmListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button_filmekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_filmad.Text == "" || textBox_filmtür.Text == "" || textBox_yonetmen.Text == "" || comboBox_filmsure.Text == "" || richTextBox_oyuncular.Text == "")
                {
                    MessageBox.Show("Lütfen Geçerli Alanları Doldurunuz!", "Sistem Bildirimi Penceresi");
                }
                else
                {
                    Film yenifilm = new Film();
                    yenifilm.FilmAdi = textBox_filmad.Text;
                    yenifilm.FilmTuru = textBox_filmtür.Text;
                    yenifilm.Yonetmen = textBox_yonetmen.Text;
                    yenifilm.FilmVizyonTarihi = dateTimePicker1.Value;
                    yenifilm.FilmSuresi = comboBox_filmsure.Text;
                    yenifilm.Oyuncular = richTextBox_oyuncular.Text;
                    GridGuncelleme();
                    new Database().FilmEkle(yenifilm);
                    MessageBox.Show("Film Başarılı Bir Şekilde Eklendi!", "Sistem Bildirimi Penceresi");
                }
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
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

        private void button_geridon_Click(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            frm.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = (int)dataGridView1[0, e.RowIndex].Value;
            textBox_filmad.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox_yonetmen.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox_filmtür.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            comboBox_filmsure.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            dateTimePicker1.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            richTextBox_oyuncular.Text = dataGridView1[6, e.RowIndex].Value.ToString();
            //pictureBox1.Text = dataGridView1[7, e.RowIndex].Value.ToString();
        }

        private void FilmEkle_Load(object sender, EventArgs e)
        {
            GridGuncelleme();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            try
            {
                Film film = new Film();
                film.FilmId = Id;
                new Database().FilmSil(film);
                GridGuncelleme();
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
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

        private void button_geridon_Click_1(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
