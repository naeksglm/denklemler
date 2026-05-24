using System.Numerics;
using System.Resources;

namespace Denklemler
{
    public partial class Denklemler : Form
    {
        private static int basamakAdedi = 3;
        private static Yardim yardim = new Yardim();
        public Denklemler()
        {
            InitializeComponent();
            temizle();
            yardim.Visible = false;
        }

        private void temizle()
        {
            denklemPanel.Visible = false;
            imgDenklem.Image = null;
            katSayiA(false);
            katSayiB(false);
            katSayiC(false);
            katSayiD(false);
            cozum_Butonu.Visible = false;
            denklemListComboBox.SelectedIndex = 0;

            katsayi_Label.Visible = false;
            imgDenklem.Visible = false;

            cozumTemizle();
        }

        private void cozumTemizle()
        {
            cozum1_label.Visible = false;
            cozum2_label.Visible = false;
            cozum3_label.Visible = false;

            cozum1_label.Text = "";
            cozum2_label.Text = "";
            cozum3_label.Text = "";

            cozumX.Visible = false;
            cozumX1.Visible = false;
            cozumX2.Visible = false;
            cozumX3.Visible = false;

            denklemCozumBaslik_Label.Visible = false;
            denklem_Cozumu_Panel.Visible = false;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            katsayi_Label.Visible = true;
            imgDenklem.Visible = true;

            cozumTemizle();
            if (denklemListComboBox.SelectedIndex == 0)
            {
                temizle();
            }
            else if (denklemListComboBox.SelectedIndex == 1)
            {
                show1();
            }
            else if (denklemListComboBox.SelectedIndex == 2)
            {
                show2();
            }
            else if (denklemListComboBox.SelectedIndex == 3)
            {
                show3();
            }
        }

        private void show1()
        {
            imgDenklem.Image = Properties.Resources.birinci_derece;
            denklemPanel.Visible = true;
            katSayiA(true);
            katSayiB(true);
            katSayiC(false);
            katSayiD(false);
        }
        private void show2()
        {
            imgDenklem.Image = Properties.Resources.ikinci_derece;
            denklemPanel.Visible = true;
            katSayiA(true);
            katSayiB(true);
            katSayiC(true);
            katSayiD(false);
        }
        private void show3()
        {
            imgDenklem.Image = Properties.Resources.ucuncu_derece;
            denklemPanel.Visible = true;
            katSayiA(true);
            katSayiB(true);
            katSayiC(true);
            katSayiD(true);
        }

        private void katSayiA(Boolean flag)
        {
            resim_A_Harfi.Visible = flag;
            labelEsittirIsareti_A.Visible = flag;
            katsayi_Giris_A.Visible = flag;
            katsayi_Giris_A.Text = "";
        }
        private void katSayiB(Boolean flag)
        {
            resim_B_Harfi.Visible = flag;
            labelEsittirIsareti_B.Visible = flag;
            katsayi_Giris_B.Visible = flag;
            katsayi_Giris_B.Text = "";
        }
        private void katSayiC(Boolean flag)
        {
            resim_C_Harfi.Visible = flag;
            labelEsittirIsareti_C.Visible = flag;
            katsayi_Giris_C.Visible = flag;
            katsayi_Giris_C.Text = "";
        }
        private void katSayiD(Boolean flag)
        {
            resim_D_Harfi.Visible = flag;
            labelEsittirIsareti_D.Visible = flag;
            katsayi_Giris_D.Visible = flag;
            katsayi_Giris_D.Text = "";
        }

        private void btnDenklemCoz_Click(object sender, EventArgs e)
        {
            if (denklemListComboBox.SelectedIndex == 1)
            {
                coz1();
            }
            else if (denklemListComboBox.SelectedIndex == 2)
            {
                coz2();
            }
            else if (denklemListComboBox.SelectedIndex == 3)
            {
                coz3();
            }
        }

        private void metinKontrol(object sender, EventArgs e)
        {
            Boolean flagA = katsayi_Giris_A.Text.Length > 0;
            Boolean flagB = katsayi_Giris_B.Text.Length > 0;
            Boolean flagC = katsayi_Giris_C.Text.Length > 0;
            Boolean flagD = katsayi_Giris_D.Text.Length > 0;

            cozum_Butonu.Visible =
                   (denklemListComboBox.SelectedIndex == 1 && flagA && flagB)
                || (denklemListComboBox.SelectedIndex == 2 && flagA && flagB && flagC)
                || (denklemListComboBox.SelectedIndex == 3 && flagA && flagB && flagC && flagD)
                ;
        }

        private void sayiKontrol(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            // Backspace vb.
            if (char.IsControl(e.KeyChar))
                return;

            string text = tb.Text;
            int pos = tb.SelectionStart;

            // Eksi iþareti
            if (e.KeyChar == '-')
            {
                // Sadece baþta olabilir ve 1 tane olabilir
                if (pos != 0 || text.Contains("-"))
                    e.Handled = true;

                return;
            }

            // Virgül
            if (e.KeyChar == ',')
            {
                // Tek virgül
                if (text.Contains(","))
                {
                    e.Handled = true;
                    return;
                }

                // Virgül öncesinde en az 1 rakam olmalý
                string temp = text.Replace("-", "");

                if (temp.Length == 0)
                {
                    e.Handled = true;
                    return;
                }

                return;
            }

            // Rakam
            if (char.IsDigit(e.KeyChar))
            {
                if (text.StartsWith("-")&&pos==0)
                {
                    e.Handled = true;
                    return;
                }
                
                // Ýmlecin olduðu yere karakter eklenmiþ hali
                string newText =
                    text.Substring(0, pos) +
                    e.KeyChar +
                    text.Substring(pos);

                // Sayýsal kontrol için eksi kaldýr
                string kontrol = newText.Replace("-", "");

                // Virgül öncesi kýsmý al
                string integerPart = kontrol;

                if (integerPart.Contains(","))
                    integerPart = integerPart.Split(',')[0];

                // Baþtaki sýfýr kontrolü
                // 00
                // 015
                // -0002
                // vb. engellenir

                if (integerPart.Length > 1 && integerPart.StartsWith("0"))
                {
                    e.Handled = true;
                    return;
                }

                return;
            }

            // Diðer tüm karakterleri engelle
            e.Handled = true;
        }


        private void coz1()
        {
            cozumTemizle();
            double a = double.Parse(katsayi_Giris_A.Text);
            double b = double.Parse(katsayi_Giris_B.Text);

            double cozum = (b / a) * (-1d);
            cozum1_label.Text = cozum.ToString("F" + basamakAdedi);
            denklemCozumBaslik_Label.Visible = true;
            denklem_Cozumu_Panel.Visible = true;
            cozum1Goster();
        }

        private void coz2()
        {
            cozumTemizle();
            float a = float.Parse(katsayi_Giris_A.Text);
            float b = float.Parse(katsayi_Giris_B.Text);
            float c = float.Parse(katsayi_Giris_C.Text);

            // a 0 olamaz
            if (a == 0)
            {
                MessageBox.Show("Bu ikinci dereceden denklem deðildir.");
                return;
            }

            // Delta
            double delta = (b * b) - (4 * a * c);

            // Karmaþýk sqrt destekli
            Complex sqrtDelta = Complex.Sqrt(delta);

            Complex x1 =
                (-b + sqrtDelta) / (2 * a);

            Complex x2 =
                (-b - sqrtDelta) / (2 * a);

            cozum1_label.Text = complexToString(x1);
            cozum2_label.Text = complexToString(x2);
            denklemCozumBaslik_Label.Visible = true;
            denklem_Cozumu_Panel.Visible = true;
            cozum2Goster();
        }

        private void coz3()
        {
            cozumTemizle();
            float a = float.Parse(katsayi_Giris_A.Text);
            float b = float.Parse(katsayi_Giris_B.Text);
            float c = float.Parse(katsayi_Giris_C.Text);
            float d = float.Parse(katsayi_Giris_D.Text);

            if (a == 0)
            {
                MessageBox.Show("Bu üçüncü dereceden denklem deðildir.");
            }

            double delta0 = b * b - 3 * a * c;

            double delta1 =
                2 * b * b * b -
                9 * a * b * c +
                27 * a * a * d;

            double eps = 1e-12;

            Complex[]? roots = null;

            // Özel durum: üç katlý kök
            if (Math.Abs(delta0) < eps && Math.Abs(delta1) < eps)
            {
                Complex kok = new Complex(-b / (3 * a), 0);

                roots = new Complex[]
                {
                    kok,
                    kok,
                    kok
                };
            }
            else
            {

                Complex sqrtPart = Complex.Sqrt(
                    delta1 * delta1 - 4 * Math.Pow(delta0, 3)
                );

                Complex C = Complex.Pow(
                    (delta1 + sqrtPart) / 2.0,
                    1.0 / 3.0
                );

                // C sýfýr çýkarsa diðer iþareti dene
                if (Complex.Abs(C) < eps)
                {
                    C = Complex.Pow(
                        (delta1 - sqrtPart) / 2.0,
                        1.0 / 3.0
                    );
                }

                Complex w0 = new Complex(1, 0);
                Complex w1 = new Complex(-0.5, Math.Sqrt(3) / 2);
                Complex w2 = new Complex(-0.5, -Math.Sqrt(3) / 2);

                Complex[] w = { w0, w1, w2 };
                roots = new Complex[3];

                for (int k = 0; k < 3; k++)
                {
                    Complex wk = w[k];

                    roots[k] =
                        -(b + wk * C + delta0 / (wk * C)) / (3 * a);
                }
            }
            cozum1_label.Text = complexToString(roots[0]);
            cozum2_label.Text = complexToString(roots[1]);
            cozum3_label.Text = complexToString(roots[2]);

            denklemCozumBaslik_Label.Visible = true;
            denklem_Cozumu_Panel.Visible = true;
            cozum3Goster();
        }

        private void cozum1Goster()
        {
            cozum1_label.Visible = true;
            cozumX.Visible = true;
        }
        private void cozum2Goster()
        {
            cozum1_label.Visible = true;
            cozumX1.Visible = true;

            cozum2_label.Visible = true;
            cozumX2.Visible = true;
        }
        private void cozum3Goster()
        {
            cozum1_label.Visible = true;
            cozumX1.Visible = true;

            cozum2_label.Visible = true;
            cozumX2.Visible = true;

            cozum3_label.Visible = true;
            cozumX3.Visible = true;
        }

        public static string complexToString(Complex c)
        {
            double real = c.Real;
            double imag = c.Imaginary;

            string realStr = real.ToString("F" + basamakAdedi);
            string imagStr = imag.ToString("F" + basamakAdedi);
            // Sadece reel
            if (imag == 0)
                return realStr;

            // Sadece sanal
            if (real == 0)
                return imagStr + "i";

            // Pozitif sanal
            if (imag > 0)
                return realStr + "+" + imagStr + "i";

            // Negatif sanal
            return realStr + imagStr + "i";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void yardimImg_Click(object sender, EventArgs e)
        {
            yardim.Visible = true;
        }
    }
}
