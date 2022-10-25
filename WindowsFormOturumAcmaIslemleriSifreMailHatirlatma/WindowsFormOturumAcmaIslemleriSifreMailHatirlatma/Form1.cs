using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormOturumAcmaIslemleriSifreMailHatirlatma.Models;


namespace WindowsFormOturumAcmaIslemleriSifreMailHatirlatma
{
    public partial class Form1 : Form
    {
        WindowsFormOturumAcmaIslemleriSifreMailHatirlatmaEntities db = new WindowsFormOturumAcmaIslemleriSifreMailHatirlatmaEntities();

        public Form1()
        {
            InitializeComponent();
        }

        public static int id;


        private void button1_Click(object sender, EventArgs e)
        {
            var Durum = db.PersonelGirisTablosu.FirstOrDefault(x => x.MailAdress == textBox1.Text && x.Password == textBox2.Text);
            if(Durum != null)
            {
                GirisBasarili gb = new GirisBasarili();
                gb.ShowDialog();


            }

            else
            {
                MessageBox.Show("girilen bilgiler gerçeği ile uyuşmamaktadır", "durum", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SifreTazele st = new SifreTazele();
            st.Show();

        }
    }
}
