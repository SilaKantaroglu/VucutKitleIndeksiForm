using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VucutKitleIndeksiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /*Kullanıcının girdiği boy ve ağırlık değerlerine göre vücut kitle indeksini 
         * (VKİ=ağırlık/(boy*boy), boy metre cinsinden verilmeli) hesaplayınız.
        VKİ 18 ile < 25 aralığındaysa normal,
        VKİ 25 ile <30 aralığındaysa kilolu,
        VKİ 30 ve daha yüksekse obez,
        VKİ 35 ve daha fazlaysa ciddi obez olarak kabul edilir.
        VKİ’ni hesaplayarak kişinin durumunu yazdırınız.*/

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double boy, kilo, sonuc;
            
            boy = Convert.ToDouble(txtBoy.Text);
            kilo = Convert.ToDouble(txtKilo.Text);
            sonuc = kilo / (boy * boy);
            txtSonuc.Text = sonuc.ToString();
            if (sonuc>18 && sonuc<25)
            {
                MessageBox.Show("VÜCUT KİTLE İNDEKSİ ANALİZİ: NORMAL");
            }
            else if (sonuc > 25 && sonuc < 30)
            {
                MessageBox.Show("VÜCUT KİTLE İNDEKSİ ANALİZİ: KİLOLU");
            }
            else if (sonuc > 30 && sonuc < 35)
            {
                MessageBox.Show("VÜCUT KİTLE İNDEKSİ ANALİZİ: OBEZ");
            }
            else if (sonuc > 35)
            {
                MessageBox.Show("VÜCUT KİTLE İNDEKSİ ANALİZİ: CİDDİ OBEZ");
            }
            else
            {
                MessageBox.Show("Lütfen boyunuzu 1,80 şeklinde ve kilonuzu 70 şeklinde giriniz! ");
            }
            listBox1.Items.Add(sonuc);      

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

            foreach (Control item in this.Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox") item.Text = "";
            }
        }
    }
}
