using NDPOdev2._4.Sekiller;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NDPOdev2._4
{
    public static class CarpismaKontrol
    {
        public static void dikdortgenDikdortgen(Dikdortgen a, Dikdortgen b)
        {
            /* Eğer bir dikdörtgenin sol alt köşesi diğer dikdörtgenin sağ üst köşesinden daha sola,
             sağ alt köşesi diğer dikdörtgenin sol üst köşesinden daha sağa ve dikdörtgenler birbirine değiyorsa,
             çarpışma gerçekleşiyor.*/
            if (a.M.x < b.M.x + b.En &&
                a.M.x + a.En > b.M.x &&
                a.M.y < b.M.y + b.Boy &&
                a.M.y + a.Boy > b.M.y)
            {
                MessageBox.Show("Dikdörtgenler çarpıştı!");
            }
        }
        public static void KureKure(Kure k1, Kure k2)
        {
            float d = (float)Math.Sqrt(Math.Pow(k1.M.X - k2.M.X, 2) + Math.Pow(k1.M.Y - k2.M.Y, 2) + Math.Pow(k1.M.Z - k2.M.Z, 2));
            /*İki kürenin merkezleri arasındaki mesafe, kürelerin yarıçaplarının toplamından küçükse,
            küreler birbirine değer ve çarpışma gerçekleşiyor.*/
            if (k1.R + k2.R > (int)d)
            {
                MessageBox.Show("Küreler Çarpıştı");
            }
        }
        public static void DaireDikdortgen(Cember c, Dikdortgen d)
        {
            Rectangle rect = new Rectangle(d.M.X, d.M.Y, d.En, d.Boy);
            /*Daireyi bir dikdörtgenin içine oturtarak, dikdörtgenin içinde ya da kenarlarına temas ederse, çarpışma gerçekleşiyor.*/
            if (rect.IntersectsWith(new Rectangle(c.M.X + 40 - c.R, c.M.Y + 40 - c.R, c.R * 2, c.R * 2)))
            {
                MessageBox.Show("Daire İle Dikdörtgen Çarpıştı");
            }
        }
        public static void SilindirSilindir(Silindir k1, Silindir k2)
        {
            float k1MinX = k1.M.x - k1.R;
            float k1MaxX = k1.M.x + k1.R;
            float k1MinY = k1.M.y;
            float k1MaxY = k1.M.y + k1.H;
            float k1MinZ = k1.M.z - k1.R;
            float k1MaxZ = k1.M.z + k1.R;

            float k2MinX = k2.M.x - k2.R;
            float k2MaxX = k2.M.x + k2.R;
            float k2MinY = k2.M.y;
            float k2MaxY = k2.M.y + k2.H;
            float k2MinZ = k2.M.z - k2.R;
            float k2MaxZ = k2.M.z + k2.R;

            /*Her iki silindirin sınırlayıcı kutuları (bounding boxes) arasındaki çakışmayı kontrol eder. 
              Eğer sınırlayıcı kutular birbirine temas eder veya iç içe geçerse, çarpışma gerçekleşiyor.*/
            if (k1MinX <= k2MaxX && k1MaxX >= k2MinX &&
                k1MinY <= k2MaxY && k1MaxY >= k2MinY &&
                k1MinZ <= k2MaxZ && k1MaxZ >= k2MinZ)
            {
                MessageBox.Show("Silindirler Çarpıştı");
            }
        }
        public static void DikdörtgenNokta(Cember c, Dikdortgen d)
        {
            Rectangle rect = new Rectangle(d.M.X, d.M.Y, d.En, d.Boy);
            /*Dikdörtgenin içinde veya kenarlarına temas eden bir nokta varsa, çarpışma gerçekleşir.*/
            if (rect.IntersectsWith(new Rectangle(c.M.X + 40 - c.R, c.M.Y + 40 - c.R, c.R * 2, c.R * 2)))
            {
                MessageBox.Show("Dikdörtgen İle Nokta Çarpıştı");
            }
        }
        public static void KureNokta(Kure k1, Kure k2)
        {
            float d = (float)Math.Sqrt(Math.Pow(k1.M.X - k2.M.X, 2) +
            Math.Pow(k1.M.Y - k2.M.Y, 2) + Math.Pow(k1.M.Z - k2.M.Z, 2));
            //Eğer küreler bir noktada birleşiyorsa, if şartı true döner.
            if (k1.R + k2.R > (int)d)
            {
                MessageBox.Show("Küre İle Nokta Çarpıştı");
            }
        }
        public static void CemberNokta(Cember cember, Point nokta)
        {
            // Noktanın dairenin merkezine olan uzaklığını hesaplar.
            double uzaklik = Math.Sqrt(Math.Pow(nokta.X - cember.M.x, 2) + Math.Pow(nokta.Y - cember.M.y, 2));

            // Eğer noktanın dairenin çevresine olan uzaklığı dairenin yarıçapından küçük veya eşitse,if şartı true olur.
            if (uzaklik <= cember.R)
            {
                MessageBox.Show("Çember İle Nokta Çarpıştı");
            }
        }
        public static void SilindirNokta(Silindir silindir, Point nokta)
        {
            // Üst çemberin sınırlarını belirler.
            float ustKenarXMin = silindir.M.x - silindir.R;
            float ustKenarXMax = silindir.M.x + silindir.R;
            float ustKenarYMin = silindir.M.y;
            float ustKenarYMax = silindir.M.y + silindir.H;

            // Alt çemberin sınırlarını belirler.
            float altKenarXMin = silindir.M.x - silindir.R;
            float altKenarXMax = silindir.M.x + silindir.R;
            float altKenarYMin = silindir.M.y - silindir.H;
            float altKenarYMax = silindir.M.y;

            // Noktanın üst veya alt çemberin kenarına olan uzaklığını hesaplar.
            float uzaklikUst = (float)Math.Sqrt(Math.Pow(nokta.X - silindir.M.x, 2) + Math.Pow(nokta.Y - silindir.M.y, 2));
            float uzaklikAlt = (float)Math.Sqrt(Math.Pow(nokta.X - silindir.M.x, 2) + Math.Pow(nokta.Y - (silindir.M.y - silindir.H), 2));

            // Eğer nokta silindirin üst veya alt çemberlerine değiyorsa, İf şartı true olur.
            if (uzaklikUst <= silindir.R && nokta.Y >= ustKenarYMin && nokta.Y <= ustKenarYMax ||
                uzaklikAlt <= silindir.R && nokta.Y >= altKenarYMin && nokta.Y <= altKenarYMax)
            {
                MessageBox.Show("Silindir İle Nokta Çarpıştı");
            }

        }

    }
}