using Properties;
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
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDenklemCoz.Visible = true;
            if (comboBox1.SelectedIndex == 0)
            {
                temizle();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                show1();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                show2();
            }
            else if (comboBox1.SelectedIndex == 3)
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
    }
}
