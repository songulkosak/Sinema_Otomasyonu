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
    public partial class Anasayfa : Form
    {
        public Button btn;
        public int koltuksayisi;
        int sayac = 0;
        Database database = new Database();
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void renklendirme()
        {
            foreach (Control item in panel_salon.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.BackColor == Color.White)
            {
                textBox_koltukno.Text = b.Text;

            }
        }
        private void button_satisyap_Click(object sender, EventArgs e)
        {
            if (textBox_koltukno.Text != "")
            {
                try
                {
                    Satis2 yenisatis = new Satis2();
                    yenisatis.AdSoyad = textBox_adsoyad.Text;
                    yenisatis.Saat = comboBox_filmseans.Text;
                    yenisatis.TelNo = textBox_telno.Text;
                    yenisatis.Ucret = textBox_ucret.Text;
                    yenisatis.KoltukNo = Convert.ToInt16(textBox_koltukno.Text);
                    new Database().SatisEkle(yenisatis);


                    MessageBox.Show("Satış yapıldı!", "Satış");
                    renklendirme();
                }
                catch (Exception hata)
                {

                    MessageBox.Show("Hata oluştu! " + hata, "Uyarı");
                }
            }
            else
            {
                MessageBox.Show("Hata oluştu!\n  Koltuk seçimi yapmadınız.", "Uyarı");
            }
        }
        private void BosKoltuklar()
        {
            sayac = 1;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    Button btn = new Button();
                    btn.Size = new Size(35, 35);
                    btn.BackColor = Color.White;
                    btn.Font = new Font(btn.Font.FontFamily, 8);
                    btn.Location = new Point(j * 40 + 30, i * 40 + 30);
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 5 || i == 4)
                    {
                        Label lbl3 = new Label();
                        lbl3.BackColor = Color.Green;
                        lbl3.ForeColor = Color.White;
                        lbl3.TextAlign = ContentAlignment.TopCenter;
                        lbl3.Size = new Size(26, 25);
                        lbl3.Font = new Font(btn.Font.FontFamily, 11);
                        lbl3.Location = new Point(6 * 39, 22);
                        lbl3.Name = "";
                        lbl3.Text = "";
                        this.panel_salon.Controls.Add(lbl3);
                        Label lbl2 = new Label();
                        lbl2.BackColor = Color.White;
                        lbl2.ForeColor = Color.Black;
                        lbl2.TextAlign = ContentAlignment.BottomCenter;
                        lbl2.AutoSize = false;
                        lbl2.Size = new Size(26, 319);
                        lbl2.Font = new Font(btn.Font.FontFamily, 14);
                        lbl2.Location = new Point(6 * 39, 30);
                        lbl2.Name = "";
                        lbl2.Text = "";
                        this.panel_salon.Controls.Add(lbl2);
                        Label lbl = new Label();
                        lbl.BackColor = Color.White;
                        lbl.ForeColor = Color.Black;
                        lbl.TextAlign = ContentAlignment.MiddleLeft;
                        lbl.Size = new Size(360, 27);
                        lbl.Font = new Font(btn.Font.FontFamily, 11);
                        lbl.Location = new Point(30, 5 * 39);
                        lbl.Name = "";
                        lbl.Text = "";
                        this.panel_salon.Controls.Add(lbl);

                        continue;
                    }
                    sayac = sayac + 1;
                    this.panel_salon.Controls.Add(btn);
                    btn.Click += Btn_Click1;
                    btn.MouseDown += Btn_MouseDown;

                }
            }

        }
        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            btn = sender as Button;
            koltuksayisi = int.Parse(btn.Text);
        }
        Satis2 satis = new Satis2();
        private void Btn_Click1(object sender, EventArgs e)
        {

            btn = sender as Button;
            koltuksayisi = int.Parse(btn.Text);
            satis.KoltukNo = koltuksayisi;
            var result = database.GetSatislar();
            foreach (var item in result)
            {
                MessageBox.Show("Müşteri Bilgileri");
                textBox_adsoyad.Text = item.AdSoyad;
                textBox_telno.Text = item.TelNo;
            }

        }
        private void DoluKoltuklar()
        {

            foreach (Control item in panel_salon.Controls)
            {
                if (item is Button)
                {
                    if ("KoltukNo".ToString() == item.Text)
                    {
                        item.BackColor = Color.Green;

                    }
                }
            }


        }

        private void button_satislar_Click(object sender, EventArgs e)
        {
            Satislar frm4 = new Satislar();
            frm4.Show();
            this.Hide();
        }

        private void button_seanlar_Click(object sender, EventArgs e)
        {
            Seanslar frm2 = new Seanslar();
            frm2.Show();
            this.Hide();
        }

        private void button_seansekle_Click(object sender, EventArgs e)
        {
            SeansEkle frm3 = new SeansEkle();
            frm3.Show();
            this.Hide();
        }

        private void button_salonekle_Click(object sender, EventArgs e)
        {
            SalonEkle frm1 = new SalonEkle();
            frm1.Show();
            this.Hide();
        }

        private void button_filmekle_Click(object sender, EventArgs e)
        {
            FilmEkle frm = new FilmEkle();
            frm.Show();
            this.Hide();
        }

        private void button_iptalet_Click(object sender, EventArgs e)
        {
            try
            {
                database.Koltukİptal(comboBox5.SelectedIndex);

            }
            catch (Exception)
            {

                throw;
            }

            MessageBox.Show("Bilet iptal edildi!", "İptal");
            renklendirme();
            DoluKoltuklar();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            comboBox_filmadi.DisplayMember = "FilmAdi";
            comboBox_filmadi.ValueMember = "FilmId";
            comboBox_filmadi.DataSource = database.GetFilmler();

            comboBox_salon.DisplayMember = "SalonAdi";
            comboBox_salon.ValueMember = "SalonId";
            comboBox_salon.DataSource = database.Salon();

            comboBox_filmseans.DisplayMember = "Seansi";
            comboBox_filmseans.ValueMember = "SeansId";
            comboBox_filmseans.DataSource = database.GetSeanslar();

            comboBox_filmtar.DisplayMember = "SatisTarihi";
            comboBox_filmtar.ValueMember = "SatisId";
            comboBox_filmtar.DataSource = database.GetSatislar();

            BosKoltuklar();
        }
    }
}
