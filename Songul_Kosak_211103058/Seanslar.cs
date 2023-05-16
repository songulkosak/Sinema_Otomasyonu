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
    
    public partial class Seanslar : Form
    {
        Database database = new Database();
        public Seanslar()
        {
            InitializeComponent();
        }

        private void button_geri_Click(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            frm.Show();
            this.Hide();
        }
        private void gridGüncelle()
        {
            try
            {
                dataGridView1.DataSource = database.GetSeanslar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button_yeniseans_Click(object sender, EventArgs e)
        {
            SeansEkle frm = new SeansEkle();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gridGüncelle();
        }

        private void button_tümseans_Click_1(object sender, EventArgs e)
        {
            gridGüncelle();
        }

        private void button_geri_Click_1(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            frm.Show();
            this.Hide();
        }

        private void button_yeniseans_Click_1(object sender, EventArgs e)
        {
            SeansEkle frm = new SeansEkle();
            frm.Show();
            this.Hide();
        }
    }
}
