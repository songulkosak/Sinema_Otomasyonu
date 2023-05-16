using Songul_Kosak_211103058.DAL;
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
    public partial class SalonEkle : Form
    {
        Database database = new Database();
        public SalonEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            frm.Show();
            this.Hide();
        }

        private void button_salonekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_salonadi.Text == "" || textBox_salon.Text == "")
                {
                    MessageBox.Show("Lütfen Geçerli Alanları Doldurunuz!", "Sistem Bildirimi Penceresi");
                }
                else
                {
                    int sayi = 0;
                    panel1.Controls.Clear();
                    for (int i = 0; i < textBox_salon.Lines.Count(); i++)
                    {
                        for (int j = 0; j < textBox_salon.Lines[i].Count(); j++)
                        {
                            string satir = textBox_salon.Lines[i];

                            if (satir[j] == '*')
                            {
                                Button nesne = new Button();
                                nesne.Name = "buton" + i;
                                nesne.Text = (++sayi).ToString();
                                nesne.BackColor = Color.Red;
                                nesne.Width = nesne.Height = 30;
                                nesne.Left = 35 * j;
                                nesne.Top = 35 * i;
                                nesne.Click += koltukSecildi;
                                panel1.Controls.Add(nesne);

                            }
                        }
                    }
                    MessageBox.Show("Salon Başarılı Bir Şekilde Eklendi!", "Sistem Bildirimi Penceresi");
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
            Salon yenisalon = new Salon();
            yenisalon.SalonTasarimi = textBox_salon.Text;
            yenisalon.SalonAdi = textBox_salonadi.Text;
            new Database().SalonEkle(yenisalon);
        }
        void koltukSecildi(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.BackColor == Color.White)
                btn.BackColor = Color.Aqua;
            else
                btn.BackColor = Color.Red;

        }
    }
}
