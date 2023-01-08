using MarketOtomasyonu.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.Utils
{
    internal static class MenuUtil
    {
        public static UserControl GetPage(object sender)
        {
            UserControl userControl;

            Button senderButton = (Button)sender;

            switch (senderButton.Name)
            {
                case "anasayfaBtn":
                    userControl = new Anasayfa();
                    break;
                case "urunlerBtn":
                    userControl = new Urunler();
                    break;
                case "stoklarBtn":
                    userControl = new Stoklar();
                    break;
                case "satisBtn":
                    userControl = new Satis();
                    break;
                case "personelBtn":
                    userControl = new Personel();
                    break;
                case "tedarikciBtn":
                    userControl = new Tedarikci();
                    break;
                case "musteriBorcBtn":
                    userControl = new MusteriBorclar();
                    break;
                case "musteriBtn":
                    userControl = new Musteriler();
                    break;
                case "marketBorcBtn":
                    userControl = new MarketBorclar();
                    break;
                case "raporBtn":
                    userControl = new Raporlar();
                    break;
                default:
                    throw new Exception();
            }

            return userControl;
        }
    }
}
