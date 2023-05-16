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
    public partial class GirisSayfasi : Form
    {
        Database database = new Database();
        public GirisSayfasi()
        {
            InitializeComponent();
        }

        private void btnkullanicigiris_Click(object sender, EventArgs e)
        {

            if (txtkullaniciadi.Text != string.Empty && txtparola.Text != string.Empty)
            {
                KullaniciGiris g = new KullaniciGiris();
                g.KullaniciAdi = txtkullaniciadi.Text.Trim();
                g.Sifre = txtparola.Text.Trim();
                if (database.Giris(g).Count > 0)
                {
                    MessageBox.Show("Giriş Başarılı HoşGeldiniz Songül Hanım!", "Sistem Bildirimi Penceresi");
                    Anasayfa gir = new Anasayfa();
                    gir.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı!", "Sistem Bildirimi Penceresi");
                    txtkullaniciadi.Clear();
                    txtparola.Clear();
                    txtkullaniciadi.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!", "Sistem Bildirimi Penceresi");
            }
        }
    }
}
