using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace paspaparola
{
    public partial class Form1 : Form
    {
        SoundPlayer trueplayer = new SoundPlayer("D:\\indirilenler\\success-fanfare-trumpets-6185.wav");
        SoundPlayer wrongplayer = new SoundPlayer("D:\\indirilenler\\wrong-answer-126515.wav");

        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0, harfno = 0;
        int bironcekidogrusayisi = 0;
        int bironcekiyanlis = 0;

        private void komutlar_Enter(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            //harflero degiostort
            harfno++;
            switch (harfno)
            {
                case 1:
                    button21.Text = "A";
                    break;
                case 2:
                    button21.Text = "B"; break;
                case 3:
                    button21.Text = "C"; break;
                case 4:
                    button21.Text = "D"; break;
                case 5:
                    button21.Text = "E"; break;
                case 6:
                    button21.Text = "F"; break;
                case 7:
                    button21.Text = "G"; break;
                case 8:
                    button21.Text = "H"; break;
                case 9:
                    button21.Text = "I"; break;
                case 10:
                    button21.Text = "J"; break;
                case 11:
                    button21.Text = "K"; break;
                case 12:
                    button21.Text = "L"; break;
                case 13:
                    button21.Text = "M"; break;
                case 14:
                    button21.Text = "N"; break;
                case 15:
                    button21.Text = "O"; break;
                case 16:
                    button21.Text = "p"; break;
                case 17:
                    button21.Text = "R"; break;
                case 18:
                    button21.Text = "S"; break;
                case 19:
                    button21.Text = "T"; break;
                case 20:
                    button21.Text = "U"; break;
            }

            // Sorunun cevabını kontrol et
            switch (soruno)
            {
                case 1:
                    if (textBox1.Text == "abend")
                    {
                        button1.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play();
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button1.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                 
                    }
                    break;
                case 2:
                    if (textBox1.Text == "blau" || textBox1.Text == "braun")
                    {
                        button2.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play();
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button2.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play() ;
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 3:
                    if (textBox1.Text == "chemie")
                    {
                        button3.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button3.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 4:
                    if (textBox1.Text == "datum" || textBox1.Text == "deutsch")
                    {
                        button4.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button4.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 5:
                    if (textBox1.Text == "eins" || textBox1.Text == "elf")
                    {
                        button5.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button5.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 6:
                    if (textBox1.Text == "fragen")
                    {
                        button6.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button6.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 7:
                    if (textBox1.Text == "guten tag")
                    {
                        button7.BackColor = Color.Green;
                        dogru++;
                            trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button7.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 8:
                    if (textBox1.Text == "hallo")
                    {
                        button8.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button8.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 9:
                    if (textBox1.Text == "ınsult")
                    {
                        button9.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button9.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 10:
                    if (textBox1.Text == "juni")
                    {
                        button10.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button10.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 11:
                    if (textBox1.Text == "kaffee")
                    {
                        button11.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button11.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 12:
                    if (textBox1.Text == "letter")
                    {
                        button12.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button12.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 13:
                    if (textBox1.Text == "morgen")
                    {
                        button13.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button13.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 14:
                    if (textBox1.Text == "nicht")
                    {
                        button14.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button14.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 15:
                    if (textBox1.Text == "oliven")
                    {
                        button15.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button15.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 16:
                    if (textBox1.Text == "poulet")
                    {
                        button16.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button16.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 17:
                    if (textBox1.Text == "red")
                    {
                        button17.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button17.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 18:
                    if (textBox1.Text == "schwarz")
                    {
                        button18.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button18.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 19:
                    if (textBox1.Text == "tag")
                    {
                        button19.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button19.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
                case 20:
                    if (textBox1.Text == "unfair")
                    {
                        button20.BackColor = Color.Green;
                        dogru++;
                        trueplayer.Play() ;
                        label3.Text = dogru.ToString();
                    }
                    else
                    {
                        button20.BackColor = Color.Red;
                        yanlis++;
                        wrongplayer.Play();
                        label4.Text = yanlis.ToString();
                    }
                    break;
            }

            // Ses çalma
          

            // Bir sonraki soruya geç
            soruno++;
            this.Text = soruno + ". soru";

            // Soruları göster
            switch (soruno)
            {
                case 1:
                    richTextBox1.Text = "akşam anlamına gelen kelime?";
                    button1.BackColor = Color.Black;
                    break;
                case 2:
                    richTextBox1.Text = "almanca bir renk?";
                    button2.BackColor = Color.Black; break;
                case 3:
                    richTextBox1.Text = "almanca bir ders?";
                    button3.BackColor = Color.Black; break;
                case 4:
                    richTextBox1.Text = "almanca bir ders?";
                    button4.BackColor = Color.Black;
                    break;
                case 5:
                    richTextBox1.Text = "almanca bir sayı?";
                    button5.BackColor = Color.Black;
                    break;
                case 6:
                    richTextBox1.Text = "soru sormak icin kullanılan kelime?";
                    button6.BackColor = Color.Black;
                    break;
                case 7:
                    richTextBox1.Text = "iyi günler demek için kullanırız?";
                    button7.BackColor = Color.Black;
                    break;
                case 8:
                    richTextBox1.Text = "selamlaşmak için kullanırız?";
                    button8.BackColor = Color.Black;
                    break;
                case 9:
                    richTextBox1.Text = "hakaret anlamına gelen kelime?";
                    button9.BackColor = Color.Black;
                    break;
                case 10:
                    richTextBox1.Text = "bir ay?";
                    button10.BackColor = Color.Black;
                    break;
                case 11:
                    richTextBox1.Text = "uyanmak için içtiğimiz şey?";
                    button11.BackColor = Color.Black;
                    break;
                case 12:
                    richTextBox1.Text = "uzakta yaşayan sevdiğimiz yakınlarımıza yazdığımız şey?";
                    button12.BackColor = Color.Black;
                    break;
                case 13:
                    richTextBox1.Text = "günün erken  bir bölümü";
                    button13.BackColor = Color.Black;
                    break;
                case 14:
                    richTextBox1.Text = "olumsuzluk belirten kelime?";
                    button14.BackColor = Color.Black;
                    break;
                case 15:
                    richTextBox1.Text = "sabah kahvaltıda yediğimiz cekirdekli meyve?";
                    button15.BackColor = Color.Black;
                    break;
                case 16:
                    richTextBox1.Text = "kanatları olan uçamamayan afiyetle yediğimiz hayvan?";
                    button16.BackColor = Color.Black;
                    break;
                case 17:
                    richTextBox1.Text = "bir renk?";
                    button17.BackColor = Color.Black;
                    break;
                case 18:
                    richTextBox1.Text = "bir renk?";
                    button18.BackColor = Color.Black;
                    break;
                case 19:
                    richTextBox1.Text = "gün anlamına gelen kelime?";
                    button19.BackColor = Color.Black;
                    break;
                case 20:
                    richTextBox1.Text = "adaletsizlik haksızlık anlamına gelen kelıme (aynı ülkemizin adaleti gibi)";
                    button20.BackColor = Color.Black;
                    break;
                default:
                    MessageBox.Show("Tüm sorular çözüldü.");
                    button21.Text = "BÜTÜN TESTİ BİTİRDİN!";
                    listBox1.Items.Add("1-abend");
                    listBox1.Items.Add("2-blau or braun");
                    listBox1.Items.Add("3-chemie");
                    listBox1.Items.Add("4-datum or deutsch");
                    listBox1.Items.Add("5-eins or elf");
                    listBox1.Items.Add("6-fragen");
                    listBox1.Items.Add("7-guten tag");
                    listBox1.Items.Add("8-hallo");
                    listBox1.Items.Add("9-insult");
                    listBox1.Items.Add("10-juni");
                    listBox1.Items.Add("11-kaffee");
                    listBox1.Items.Add("12-letter");
                    listBox1.Items.Add("13-morgan");
                    listBox1.Items.Add("14-nicht");
                    listBox1.Items.Add("15-oliven");
                    listBox1.Items.Add("16-poulet");
                    listBox1.Items.Add("17-red");
                    listBox1.Items.Add("18-schwarz");
                    listBox1.Items.Add("19-tag");
                    listBox1.Items.Add("20-unfair");
                    break;
            }

            //textboxu temizle
            textBox1.Text = "";
        }
    }
}
