using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İdealKiloHesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "İDEAL KİLO HESAPLAMA PROGRAMI";
            label2.Text = "Ad:";
            label3.Text = "Soyad:";
            label4.Text = "Yaş:";
            label5.Text = "Boy:";
            label6.Text = "Cinsiyet:";
            label7.Text = "Kilo:";
            label8.Text = "İdeal Kilo:";
            comboBox1.Items.Add("Erkek"); //combobox a eleman ekliyoruz.
            comboBox1.Items.Add("Kadın");
            label9.Visible = false; //sonucun verileceği labeli butona basmadan önce gizliyoruz.
            label9.ForeColor = Color.Red; //sonucun verileceği labelin rengini kırmızı yapıyoruz.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double yas; //yaş değerini tutacağımız değişken.
            double boy; //boy değerini tutacağımız değişken.
            double kilo; //kilo değerini tutacağımız değişken.
            double k=0; //k katsayısını ilk başta 0 yapıyoruz.
            double ideal=0; //ideal kiloyu tutacağımız değişken.
            double sonuc = 0;

            yas = Convert.ToDouble(textBox3.Text); //yaş değerini double a çevirip değişkene atıyoruz.
            boy = Convert.ToDouble(textBox4.Text); //boy değerini double a çevirip değişkene atıyoruz.
            kilo = Convert.ToDouble(textBox5.Text); //kilo değerini double a çevirip değişkene atıyoruz.

            if (comboBox1.Text == "Erkek") //kişinin erkek mi kadın mı olduğunu öğreneceğimiz koşulu yazıyoruz.
            {
                k = 0.9; //erkek için k katsayısı.
                ideal = ((boy - 100) + (yas / 10)) * k; //ideal kilo hesaplama işlemi.
            }
            else if(comboBox1.Text == "Kadın")
            {
                k = 0.8; //kadın için k katsayısı.
                ideal = (boy - 100 + yas / 10) * k; //ideal kilo hesaplama işlemi.

            }

            if(ideal > kilo) //sonuç değerimizin negatif çıkmaması için gerekli koşulu oluşturuyoruz.
            {
                sonuc = ideal - kilo; //ideal kilo büyük oldğu için kişinin kilosundan çıkarıyoruz.
                label9.Text="Zayıfsın. " + sonuc + " kilo almalısın!"; //labele sonucu yazdırıyoruz.
            }
            else if(ideal<kilo)
            {
                sonuc = kilo - ideal; //kişinin kilosu büyük oldğu için ideal kilodan çıkarıyoruz.
                label9.Text = "Şişmansın. " + sonuc + " kilo zayıflamalısın!"; //labele sonucu yazdırıyoruz.
            }
            else if(ideal==kilo)
            {
                label9.Text = "Bravo ideal kilodasınız"; //labele sonucu yazdırıyoruz.
            }

            textBox6.Text = Convert.ToString(ideal); //ideal kiloyu yazdırıyoruz.

            label9.Visible = true; //sonuç değerinin yazıldığı labeli görünür hale getiriyoruz.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            label9.Text = "";
            //sil butonuna basıldığı için bütün değerleri boş hale getiriyoruz.
        }
    }
}
