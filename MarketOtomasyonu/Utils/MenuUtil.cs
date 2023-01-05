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
                case "anasayfabutton":
                    userControl = new Anasayfa();
                    break;
                case "urunlerbutton":
                    userControl = new Urunler();
                    break;
                case "stoklarbutton":
                    userControl = new Stoklar();
                    break;
                case "satisbutton":
                    userControl = new Satis();
                    break;
                case "personelbutton":
                    userControl = new Personel();
                    break;
                case "tedarikcibutton":
                    userControl = new Tedarikci();
                    break;
                case "musteribbutton":
                    userControl = new MusteriBorclar();
                    break;
                case "musteributton":
                    userControl = new Musteriler();
                    break;
                case "marketbbutton":
                    userControl = new MarketBorclar();
                    break;
                case "raporbutton":
                    userControl = new Raporlar();
                    break;
                default:
                    throw new Exception();
            }

            return userControl;
        }
    }
}
