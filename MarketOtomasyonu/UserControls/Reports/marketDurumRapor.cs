using MarketOtomasyonu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketOtomasyonu.UserControls.Reports
{
    public partial class marketDurumRapor : UserControl
    {
        public marketDurumRapor()
        {
            InitializeComponent();
            DataGridGoster();
        }

        private void DataGridGoster()
        {
            
        }
    }

    internal class MarketDurum
    {
        public float Gelir;
        public float Borc;
        public float Kar;

        public int Yil;
        public int Ay;
    }
}
