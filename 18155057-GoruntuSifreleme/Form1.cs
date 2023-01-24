using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18155057_GoruntuSifreleme
{
    public partial class Form1 : Form
    {

        Bitmap originalImage;
        Bitmap destinationImage;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void orijinal_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaSecici = new OpenFileDialog();
            dosyaSecici.Filter = "Image Files(*.JPG)|*.JPG;*.JPEG;*.jpeg;*.jpg";
            DialogResult cevap = dosyaSecici.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                orijinal.Image = new Bitmap(dosyaSecici.FileName);
                originalImage = (Bitmap)orijinal.Image;
                resminBoyutunuAyarla();
            }
        }

        private void resminBoyutunuAyarla()
        {
            Bitmap orijinalGoruntu = (Bitmap)orijinal.Image;
            int genislik = orijinalGoruntu.Width;
            int yukseklik = orijinalGoruntu.Height;
            Bitmap hedefGoruntu;


            if (((genislik % 2 == 0) && (yukseklik % 2 == 0)) || (((genislik % 2 == 1) && (yukseklik % 2 == 1))))
            {
                hedefGoruntu = new Bitmap(orijinalGoruntu, new Size(genislik + 1, yukseklik + 2));
                orijinal.Image = hedefGoruntu;
                destinationImage = hedefGoruntu;
                Console.WriteLine("Hedefgoruntu genislik: " + hedefGoruntu.Width + ", yukseklik: " + hedefGoruntu.Height);
                Console.WriteLine(destinationImage.Width + ", " + destinationImage.Height);
            }
            else
            {
                destinationImage = (Bitmap)orijinal.Image;
            }
        }

        private void marshalRenkSifrele(Boolean isAesthetic)
        {
            if (orijinal.Image == null) return;

            Bitmap orijinalGoruntu = destinationImage;
            int genislik = orijinalGoruntu.Width;
            int yukseklik = orijinalGoruntu.Height;

            BitmapData orijinalGoruntuData = orijinalGoruntu.LockBits(new Rectangle(0, 0, genislik, yukseklik), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            int byteSayisi = orijinalGoruntuData.Stride * yukseklik;
            byte[] orijinalPikseller = new byte[byteSayisi + 2];

            Marshal.Copy(orijinalGoruntuData.Scan0, orijinalPikseller, 0, byteSayisi);

            byte red, green, blue, newBluePiksel, newGreenPiksel, newRedPiksel;
            for (int i = 0; i <= byteSayisi - 1; i = i + 3)
            {
                blue = orijinalPikseller[i];
                green = orijinalPikseller[i + 1];
                red = orijinalPikseller[i + 2];

                if (isAesthetic == true)
                {
                    newBluePiksel = (byte)(blue - 536);
                    newGreenPiksel = (byte)(green - 124);
                    newRedPiksel = (byte)(red + 151);
                }
                else
                {
                    newBluePiksel = (byte)(blue - i);
                    newGreenPiksel = (byte)(green - i);
                    newRedPiksel = (byte)(red + i);
                }

                orijinalPikseller[i] = newBluePiksel;
                orijinalPikseller[i + 1] = newGreenPiksel;
                orijinalPikseller[i + 2] = newRedPiksel;

            }
            Bitmap hedefGoruntu = new Bitmap(genislik, yukseklik, PixelFormat.Format24bppRgb);

            BitmapData hedefGoruntuData = hedefGoruntu.LockBits(new Rectangle(0, 0, genislik, yukseklik), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            Marshal.Copy(orijinalPikseller, 0, hedefGoruntuData.Scan0, byteSayisi);
            orijinalGoruntu.UnlockBits(orijinalGoruntuData);
            hedefGoruntu.UnlockBits(hedefGoruntuData);
            hedef.Image = hedefGoruntu;
            destinationImage = hedefGoruntu;
        }

        private void marshalRenkCoz(Boolean isAesthetic)
        {
            if (orijinal.Image == null) return;

            Bitmap orijinalGoruntu = destinationImage;
            int genislik = orijinalGoruntu.Width;
            int yukseklik = orijinalGoruntu.Height;

            BitmapData orijinalGoruntuData = orijinalGoruntu.LockBits(new Rectangle(0, 0, genislik, yukseklik), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            int byteSayisi = orijinalGoruntuData.Stride * yukseklik;
            byte[] orijinalPikseller = new byte[byteSayisi + 2];

            Marshal.Copy(orijinalGoruntuData.Scan0, orijinalPikseller, 0, byteSayisi);

            byte red, green, blue, newBluePiksel, newGreenPiksel, newRedPiksel;
            for (int i = 0; i < byteSayisi - 1; i = i + 3)
            {
                blue = orijinalPikseller[i];
                green = orijinalPikseller[i + 1];
                red = orijinalPikseller[i + 2];

                if (isAesthetic == true)
                {
                    newBluePiksel = (byte)(blue + 536);
                    newGreenPiksel = (byte)(green + 124);
                    newRedPiksel = (byte)(red - 151);
                }
                else
                {
                    newBluePiksel = (byte)(blue + i);
                    newGreenPiksel = (byte)(green + i);
                    newRedPiksel = (byte)(red - i);
                }
                

                orijinalPikseller[i] = newBluePiksel;
                orijinalPikseller[i + 1] = newGreenPiksel;
                orijinalPikseller[i + 2] = newRedPiksel;

            }
            Bitmap hedefGoruntu = new Bitmap(genislik, yukseklik, PixelFormat.Format24bppRgb);

            BitmapData hedefGoruntuData = hedefGoruntu.LockBits(new Rectangle(0, 0, genislik, yukseklik), ImageLockMode.WriteOnly, PixelFormat.Format24bppRgb);

            Marshal.Copy(orijinalPikseller, 0, hedefGoruntuData.Scan0, byteSayisi);
            orijinalGoruntu.UnlockBits(orijinalGoruntuData);
            hedefGoruntu.UnlockBits(hedefGoruntuData);
            hedef.Image = hedefGoruntu;
            destinationImage = hedefGoruntu;
        }

        //---------------------------SATIR VE SUTUNLARIN AYARLANDIĞI KISIM
        private void sutunlariSagaSolaDagit()
        {
            if (orijinal.Image == null) return;

            Bitmap orijinalGoruntu = destinationImage;
            int genislik = orijinalGoruntu.Width;
            int yukseklik = orijinalGoruntu.Height;
            Bitmap hedefGoruntu = new Bitmap(genislik, yukseklik);

            int evilI; Boolean flag = true;
            for (int satir = 0; satir < genislik - 1; satir++)
            {
                for (int sutun = 0; sutun < yukseklik - 1; sutun++)
                {
                    Color currentPixel = orijinalGoruntu.GetPixel(satir, sutun);
                    evilI = genislik - satir - 1;
                    if (flag == true)
                    {
                        hedefGoruntu.SetPixel(evilI, sutun, currentPixel);
                        flag = false;
                    }
                    else
                    {
                        hedefGoruntu.SetPixel(satir, sutun, currentPixel);
                        flag = true;
                    }
                }
            }
            hedef.Image = hedefGoruntu;
            destinationImage = hedefGoruntu;
        }

        private void satirlariAsagiYukariDagit()
        {
            if (orijinal.Image == null) return;

            Bitmap orijinalGoruntu = destinationImage;
            int genislik = orijinalGoruntu.Width;
            int yukseklik = orijinalGoruntu.Height;
            Bitmap hedefGoruntu = new Bitmap(genislik, yukseklik);

            int evilI; Boolean flag = true;
            for (int y = 0; y < yukseklik - 1; y++)
            {
                for (int x = 0; x < genislik - 1; x++)
                {
                    Color currentPixel = orijinalGoruntu.GetPixel(x, y);
                    evilI = yukseklik - y - 1;
                    if (flag == true)
                    {
                        hedefGoruntu.SetPixel(x, evilI, currentPixel);
                        flag = false;
                    }
                    else
                    {
                        hedefGoruntu.SetPixel(x, y, currentPixel);
                        flag = true;
                    }
                }
            }
            hedef.Image = hedefGoruntu;
            destinationImage = hedefGoruntu;
        }

        private void sutunlariCoz()
        {
            if (orijinal.Image == null) return;

            Bitmap orijinalGoruntu = destinationImage;
            int genislik = orijinalGoruntu.Width;
            int yukseklik = orijinalGoruntu.Height;
            Bitmap hedefGoruntu = new Bitmap(genislik, yukseklik);
            int evilI; Boolean flag = true;


            for (int satir = 0; satir < genislik - 1; satir++)
            {
                for (int sutun = 0; sutun < yukseklik - 1; sutun++)
                {
                    Color currentPixel = orijinalGoruntu.GetPixel(genislik - satir - 1, sutun);
                    evilI = genislik - satir - 1;
                    if (flag == true)
                    {
                        hedefGoruntu.SetPixel(satir, sutun, currentPixel);
                        flag = false;
                    }
                    else
                    {
                        hedefGoruntu.SetPixel(evilI, sutun, currentPixel);
                        flag = true;
                    }
                }
            }
            hedef.Image = hedefGoruntu;
            destinationImage = hedefGoruntu;
            orijinal.Refresh();
        }

        private void satirlariCoz()
        {
            if (orijinal.Image == null) return;

            Bitmap orijinalGoruntu = destinationImage;
            int genislik = orijinalGoruntu.Width;
            int yukseklik = orijinalGoruntu.Height;
            Bitmap hedefGoruntu = new Bitmap(genislik, yukseklik);
            int evilI; Boolean flag = true;


            for (int y = 0; y < yukseklik - 1; y++)
            {
                for (int x = 0; x < genislik - 1; x++)
                {
                    Color currentPixel = orijinalGoruntu.GetPixel(x, yukseklik - y - 1);
                    evilI = yukseklik - y - 1;
                    if (flag == true)
                    {
                        hedefGoruntu.SetPixel(x, y, currentPixel);
                        flag = false;
                    }
                    else
                    {
                        hedefGoruntu.SetPixel(x, evilI, currentPixel);
                        flag = true;
                    }
                }
            }
            hedef.Image = hedefGoruntu;
            destinationImage = hedefGoruntu;
            orijinal.Refresh();
        }

        private void KarmasikSifrele_Click(object sender, EventArgs e)
        {
            sutunlariSagaSolaDagit();
            satirlariAsagiYukariDagit();
            marshalRenkSifrele(false);
        }

        private void DesifreEt_Click(object sender, EventArgs e)
        {
            marshalRenkCoz(false);
            satirlariCoz();
            sutunlariCoz();
        }

        private void EstetikSifreleme_Click(object sender, EventArgs e)
        {
            sutunlariSagaSolaDagit();
            satirlariAsagiYukariDagit();
            marshalRenkSifrele(true);
        }

        private void estetikDesifre_Click(object sender, EventArgs e)
        {
            marshalRenkCoz(true);
            satirlariCoz();
            sutunlariCoz();
        }
    }
}
