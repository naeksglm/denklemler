using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Denklemler
{
    public partial class Yardim : Form
    {
        public Yardim()
        {
            InitializeComponent();
        }

        private void Yardim_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Yardim Penceresine ait objenin tekrar kullanılması için
            // pencere sadece görünmez yapılır.
            this.Visible = false;
            e.Cancel = true;
        }

    }
}
