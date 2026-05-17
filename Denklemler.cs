using System.Resources;

namespace Denklemler
{
    public partial class Denklemler : Form
    {
        public Denklemler()
        {
            InitializeComponent();
            temizle();
        }

        private void temizle()
        {
            imgDenklem.Image = null;
            katSayiA(false);
            katSayiB(false);
            katSayiC(false);
            katSayiD(false);
            btnDenklemCoz.Visible = false;
            denklemListComboBox.SelectedIndex = 0;
           
            katsayiLabel.Visible = false;
            imgDenklem.Visible = false;

            cozumTemizle();
        }

        private void cozumTemizle()
        {
            cozum1.Visible = false;
            cozum2.Visible = false;
            cozum3.Visible = false;

            cozum1.Text = "";
            cozum2.Text = "";
            cozum3.Text = "";

            cozumX.Visible = false;
            cozumX1.Visible = false;
            cozumX2.Visible = false;
            cozumX3.Visible = false;

            denklemCozumLabel.Visible = false;
            denklemCozumu.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            katsayiLabel.Visible = true;
            imgDenklem.Visible = true;
            

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
            
            katSayiA(true);
            katSayiB(true);
            katSayiC(false);
            katSayiD(false);
        }
        private void show2()
        {
            imgDenklem.Image = Properties.Resources.ikinci_derece;
            katSayiA(true);
            katSayiB(true);
            katSayiC(true);
            katSayiD(false);
        }
        private void show3()
        {
            imgDenklem.Image = Properties.Resources.ucuncu_derece;
            katSayiA(true);
            katSayiB(true);
            katSayiC(true);
            katSayiD(true);
        }

        private void katSayiA(Boolean flag)
        {
            imgA.Visible = flag;
            eqA.Visible = flag;
            textA.Visible = flag;
            textA.Text = "";
        }
        private void katSayiB(Boolean flag)
        {
            imgB.Visible = flag;
            eqB.Visible = flag;
            textB.Visible = flag;
            textB.Text = "";
        }
        private void katSayiC(Boolean flag)
        {
            imgC.Visible = flag;
            eqC.Visible = flag;
            textC.Visible = flag;
            textC.Text = "";
        }
        private void katSayiD(Boolean flag)
        {
            imgD.Visible = flag;
            eqD.Visible = flag;
            textD.Visible = flag;
            textD.Text = "";
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
            Boolean flagA = textA.Text.Length > 0;
            Boolean flagB = textB.Text.Length > 0;
            Boolean flagC = textC.Text.Length > 0;
            Boolean flagD = textD.Text.Length > 0;

            btnDenklemCoz.Visible =
                   (denklemListComboBox.SelectedIndex == 1 && flagA && flagB)
                || (denklemListComboBox.SelectedIndex == 2 && flagA && flagB && flagC)
                || (denklemListComboBox.SelectedIndex == 3 && flagA && flagB && flagC && flagD)
                ;
        }

        private void sayiKontrol(object sender, KeyPressEventArgs e)
        {
            
            TextBox textBox = (TextBox)sender;
            
            //MessageBox.Show(textBox.Text);
            // Backspace vb.
            if (char.IsControl(e.KeyChar))
                return;

            // Rakam girilebilir
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            // Sadece 1 tane nokta olsun
            if (e.KeyChar == ',')
            {
                // Ýlk karakter nokta olamaz
                if (textBox.SelectionStart == 0)
                {
                    e.Handled = true;
                    return;
                }

                // Daha önce nokta varsa tekrar eklenemez
                if (textBox.Text.Contains(","))
                {
                    e.Handled = true;
                    return;
                }


                return;
            }

            if (e.KeyChar == '-')
            {
                
                e.Handled = textBox.Text.Contains("-") || textBox.SelectionStart != 0;
                return;
            }
            

            // Diðer her þeyi engelle
            e.Handled = true;
        }

        private void coz1()
        {
            cozumTemizle();
            double a = double.Parse(textA.Text);
            double b = double.Parse(textB.Text);
            
            double cozum = (b / a) * (-1d);
            cozum1.Text = cozum.ToString();
            denklemCozumLabel.Visible = true;
            denklemCozumu.Visible = true;
            cozumGoster();
        }

        private void coz2()
        {
            cozumTemizle();
            float a = float.Parse(textA.Text);
            float b = float.Parse(textB.Text);
            float c = float.Parse(textC.Text);
            float cozum = (b / a) * (-1f);
            cozum1.Text = cozum.ToString();
            cozum2.Text = cozum.ToString();
            denklemCozumLabel.Visible = true;
            denklemCozumu.Visible = true;
            cozum2Goster();
        }

        private void coz3()
        {
            cozumTemizle();
            float a = float.Parse(textA.Text);
            float b = float.Parse(textB.Text);
            float c = float.Parse(textC.Text);
            float d = float.Parse(textD.Text);
            float cozum = (b / a) * (-1f);
            cozum1.Text = cozum.ToString();
            cozum2.Text = cozum.ToString();
            cozum3.Text = cozum.ToString();
            denklemCozumLabel.Visible = true;
            denklemCozumu.Visible = true;
            cozumGoster();
        }

        private void cozumGoster()
        {
            cozum1.Visible = true;
            cozumX.Visible = true;
        }
        private void cozum2Goster()
        {
            cozum1.Visible = true;
            cozumX1.Visible = true; 
            
            cozum2.Visible = true;
            cozumX2.Visible = true;
        }
        private void cozum3Goster()
        {
            cozum1.Visible = true;
            cozumX1.Visible = true;
            
            cozum2.Visible = true;
            cozumX2.Visible = true; 
            
            cozum3.Visible = true;
            cozumX3.Visible = true;
        }

    }
}
