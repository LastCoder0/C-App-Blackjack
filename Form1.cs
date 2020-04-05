using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int  kurpiernum = 0;
        int  gamernum= 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            i = 1;
            kurpiernum = 0;
            int gamernum = 0;
            GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\background.jpg");
            GamerKolon4.Image = Image.FromFile(Application.StartupPath + "\\background.jpg");

            //Kurpier Kısmındaki  kağıtlar
            KurpierStart();
            GamerStart();
            //Oyuncu Kısmındaki kağıtlar
            i = 1;

        }
        public void KurpierStart()
        {
          
            Random rastgele = new Random();
            int sayi1 = rastgele.Next(1, 13);
            int sayi2 = rastgele.Next(1, 13);
            KurpierKolon1.SizeMode = PictureBoxSizeMode.StretchImage;
            KurpierKolon2.SizeMode = PictureBoxSizeMode.StretchImage;
            KurpierKolon2.Image = Image.FromFile(Application.StartupPath + "\\blackjackdefault.png");

            switch (sayi1)
            {
                case 1:
                    KurpierKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\as.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                case 2:
                    KurpierKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca2.png");
                    kurpiernum = kurpiernum + 2;
                    break;
                case 3:
                    KurpierKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca3.png");
                    kurpiernum = kurpiernum + 3;

                    break;
                case 4:
                    KurpierKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca4.png");
                    kurpiernum = kurpiernum + 4;

                    break;
                case 5:
                    KurpierKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca5.png");
                    kurpiernum = kurpiernum + 5;

                    break;
                case 6:
                    KurpierKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca6.png");
                    kurpiernum = kurpiernum + 6;

                    break;
                case 7:
                    KurpierKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca7.png");
                    kurpiernum = kurpiernum + 7;
                    break;
                case 8:
                    KurpierKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca8.png");
                    kurpiernum = kurpiernum + 8;
                    break;
                case 9:
                    KurpierKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca9.png");
                    kurpiernum = kurpiernum + 9;
                    break;
                case 10:
                    KurpierKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca10.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                case 11:
                    KurpierKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\macabacak.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                case 12:
                    KurpierKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\macakız.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                case 13:
                    KurpierKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\macakız.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                default:
                    Console.WriteLine("Default case");
                   break;
            }
            KurpierKolon2.Image = Image.FromFile(Application.StartupPath + "\\blackjackdefault.png");

            kurpierCount.Text = kurpiernum.ToString();

            

        }
  public void GamerStart()
        {
            int gamernum = 0;
            Random rastgele = new Random();
            int sayi1 = rastgele.Next(1, 13);
            int sayi2 = rastgele.Next(1, 13);
            GamerKolon1.SizeMode = PictureBoxSizeMode.StretchImage;
            GamerKolon2.SizeMode = PictureBoxSizeMode.StretchImage;
            switch (sayi1)
        {
            case 1:
                GamerKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\as.png");
                    gamernum = gamernum + 10;
                break;
            case 2:
                    GamerKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca2.png");
                    gamernum = gamernum + 2;
                break;
            case 3:
                    GamerKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca3.png");
                    gamernum = gamernum + 3;

                break;
            case 4:
                    GamerKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca4.png");
                    gamernum = gamernum + 4;

                break;
            case 5:
                    GamerKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca5.png");
                    gamernum = gamernum + 5;

                break;
            case 6:
                    GamerKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca6.png");
                    gamernum = gamernum + 6;

                break;
            case 7:
                    GamerKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca7.png");
                    gamernum = gamernum + 7;
                break;
            case 8:
                    GamerKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca8.png");
                    gamernum = gamernum + 8;
                break;
            case 9:
                    GamerKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca9.png");
                    gamernum = gamernum + 9;
                break;
            case 10:
                    GamerKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca10.png");
                    gamernum = gamernum + 10;
                break;
            case 11:
                    GamerKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\macabacak.png");
                    gamernum = gamernum + 10;
                break;
            case 12:
                    GamerKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\macakız.png");
                    gamernum = gamernum + 10;
                break;
            case 13:
                    GamerKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\macakız.png");
                    gamernum = gamernum + 10;
                break;
            default:
                Console.WriteLine("Default case");
                break;
        }
            switch (sayi2)
            {
                case 1:
                    GamerKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\as.png");
                    gamernum = gamernum + 10;
                    break;
                case 2:
                    GamerKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca2.png");
                    gamernum = gamernum + 2;
                    break;
                case 3:
                    GamerKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca3.png");
                    gamernum = gamernum + 3;

                    break;
                case 4:
                    GamerKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca4.png");
                    gamernum = gamernum + 4;

                    break;
                case 5:
                    GamerKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca5.png");
                    gamernum = gamernum + 5;

                    break;
                case 6:
                    GamerKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca6.png");
                    gamernum = gamernum + 6;

                    break;
                case 7:
                    GamerKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca7.png");
                    gamernum = gamernum + 7;
                    break;
                case 8:
                    GamerKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca8.png");
                    gamernum = gamernum + 8;
                    break;
                case 9:
                    GamerKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca9.png");
                    gamernum = gamernum + 9;
                    break;
                case 10:
                    GamerKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca10.png");
                    gamernum = gamernum + 10;
                    break;
                case 11:
                    GamerKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\macabacak.png");
                    gamernum = gamernum + 10;
                    break;
                case 12:
                    GamerKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\macakız.png");
                    gamernum = gamernum + 10;
                    break;
                case 13:
                    GamerKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\macakız.png");
                    gamernum = gamernum + 10;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            gamerCount.Text = gamernum.ToString();


        }
        int i = 1;
        private void Button2_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                Hit();
            }
            if(i == 2)
            {
                HitSecond();
               
            }
          
            i++;
            
       



        }
        public void Hit()
    {
            int gamernum1 = Convert.ToInt32(gamerCount.Text);
        Random rastgele = new Random();
        int sayi1 = rastgele.Next(1, 13);
            GamerKolon3.SizeMode = PictureBoxSizeMode.StretchImage;
           
            switch (sayi1)
            {
                 
                case 1:
                    GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\as.png");
                    gamernum1 = gamernum1 + 10;

                    break;
                case 2:
                    GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca2.png");
                    gamernum1 = gamernum1 + 2;
                    break;
                case 3:
                    GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca3.png");
                    gamernum1 = gamernum1 + 3;

                    break;
                case 4:
                    GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca4.png");
                    gamernum1 = gamernum1 + 4;

                    break;
                case 5:
                    GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca5.png");
                    gamernum1 = gamernum1 + 5;

                    break;
                case 6:
                    GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca6.png");
                    gamernum1 = gamernum1 + 6;

                    break;
                case 7:
                    GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca7.png");
                    gamernum1 = gamernum1 + 7;
                    break;
                case 8:
                    GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca8.png");
                    gamernum1 = gamernum1 + 8;
                    break;
                case 9:
                    GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca9.png");
                    gamernum1 = gamernum1 + 9;
                    break;
                case 10:
                    GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca10.png");
                    gamernum1 = gamernum1 + 10;
                    break;
                case 11:
                    GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\macabacak.png");
                    gamernum1 = gamernum1 + 10;
                    break;
                case 12:
                    GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\macakız.png");
                    gamernum1 = gamernum1 + 10;
                    break;
                case 13:
                    GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\macakız.png");
                    gamernum1 = gamernum1 + 10;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            gamerCount.Text = gamernum1.ToString();




        }
        public void HitSecond()
        {
            int gamernum1 = Convert.ToInt32(gamerCount.Text);
            Random rastgele = new Random();
            int sayi2 = rastgele.Next(1, 13);

                GamerKolon4.SizeMode = PictureBoxSizeMode.StretchImage;
                switch (sayi2)
                {
                    case 1:
                        GamerKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\as.png");
                    gamernum1 = gamernum1 + 10;
                        break;
                    case 2:
                        GamerKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca2.png");
                    gamernum1 = gamernum1 + 2;
                        break;
                    case 3:
                        GamerKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca3.png");
                    gamernum1 = gamernum1 + 3;

                        break;
                    case 4:
                        GamerKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca4.png");
                    gamernum1 = gamernum1 + 4;

                        break;
                    case 5:
                        GamerKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca5.png");
                    gamernum1 = gamernum1 + 5;

                        break;
                    case 6:
                        GamerKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca6.png");
                    gamernum1 = gamernum1 + 6;

                        break;
                    case 7:
                        GamerKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca7.png");
                    gamernum1 = gamernum1 + 7;
                        break;
                    case 8:
                        GamerKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca8.png");
                    gamernum1 = gamernum1 + 8;
                        break;
                    case 9:
                        GamerKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca9.png");
                    gamernum1 = gamernum1 + 9;
                        break;
                    case 10:
                        GamerKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca10.png");
                    gamernum1 = gamernum1 + 10;
                        break;
                    case 11:
                        GamerKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\macabacak.png");
                    gamernum1 = gamernum1 + 10;
                        break;
                    case 12:
                        GamerKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\macakız.png");
                    gamernum1 = gamernum1 + 10;
                        break;
                    case 13:
                        GamerKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\macakız.png");
                    gamernum1 = gamernum1 + 10;
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            gamerCount.Text = gamernum1.ToString();
        }
           

        }
    }
  



