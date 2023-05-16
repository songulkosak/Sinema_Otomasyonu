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
    public partial class SeansEkle : Form
    {
        Database database = new Database();
        string seans = "";
        public SeansEkle()
        {
            InitializeComponent();
        }
        private void ChechBoxButtonSelected()
        {
            if (checkBox1.Checked == true) seans = checkBox1.Text;
            if (checkBox2.Checked == true) seans = seans + checkBox2.Text + "/";
            if (checkBox3.Checked == true) seans = seans + checkBox3.Text + "/";
            if (checkBox4.Checked == true) seans = seans + checkBox4.Text + "/";
            if (checkBox5.Checked == true) seans = seans + checkBox5.Text + "/";
            if (checkBox6.Checked == true) seans = seans + checkBox6.Text + "/";
            if (checkBox7.Checked == true) seans = seans + checkBox7.Text + "/";
            if (checkBox8.Checked == true) seans = seans + checkBox8.Text + "/";
            if (checkBox9.Checked == true) seans = seans + checkBox9.Text + "/";
            if (checkBox10.Checked == true) seans = seans + checkBox10.Text + "/";
            if (checkBox11.Checked == true) seans = seans + checkBox11.Text + "/";
            if (checkBox12.Checked == true) seans = seans + checkBox12.Text + "/";
        }
        private void button_seansekle_Click(object sender, EventArgs e)
        {
            ChechBoxButtonSelected();
            string[] seanslar = seans.Split('/');

            Seans seansl = new Seans();

            if (seans != "")
            {
                foreach (var yeniSeans in seanslar)
                {
                    if (yeniSeans != "")
                    {
                        comboBox_film.Text = database.GetFilmler().ToString();
                        comboBox_salon.Text = database.Salon().ToString();
                    }
                }

                MessageBox.Show("Seans ekleme işlemi başarılı!");
                this.Close();
                SeansEkle yeniac = new SeansEkle();
                yeniac.Show();
            }
            else if (seans == "")
            {
                MessageBox.Show("Seans seçimini yapmadınız!");
            }
            comboBox_film.Text = "";
            comboBox_salon.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            frm.Show();
            this.Hide();
        }

        private void SeansEkle_Load(object sender, EventArgs e)
        {
            comboBox_film.DisplayMember = "FilmAdi";
            comboBox_film.ValueMember = "FilmId";
            comboBox_film.DataSource = database.GetFilmler();

            comboBox_salon.DisplayMember = "SalonAdi";
            comboBox_salon.ValueMember = "SalonId";
            comboBox_salon.DataSource = database.Salon();
        }
    }
}
