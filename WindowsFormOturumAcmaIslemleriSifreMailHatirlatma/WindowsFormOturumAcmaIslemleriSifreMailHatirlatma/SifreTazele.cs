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
    public partial class SifreTazele : Form
    {

        public SifreTazele()
        {

            InitializeComponent();
        }
        MailGonderici mg = new MailGonderici();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            mg.Microsoft(textBox1.Text, textBox2.Text, textBox1.Text);
            MessageBox.Show("girilen bilgiler eşleşir ise şifreniz yenilenecek ve mail olarak gönderilecek", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
