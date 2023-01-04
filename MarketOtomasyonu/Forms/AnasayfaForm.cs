using MarketOtomasyonu.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.Forms
{
    public partial class AnasayfaForm : Form
    {
        public AnasayfaForm()
        {
            InitializeComponent();
        }

        private void kapatbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anasayfabutton_Click(object sender, EventArgs e)
        {
            icerikpanel.Controls.Clear();
            icerikpanel.Controls.Add(new Anasayfa());
        }
    }
}
