using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        string oyuncubusted;
        int  kurpiernum = 0;
        int kurpiercip = 1000;
        int oyuncucip = 1000;
        private void Button1_Click(object sender, EventArgs e)
        {
            kurpiercip = kurpiercip - 50;
            oyuncucip = oyuncucip - 50;
            blackjack.Text = "Good Luck";
            blackjack1.Text = "Good Luck";
            lblCipK.Text = kurpiercip.ToString();
            lblCiftG.Text = oyuncucip.ToString();

            blackjack.ForeColor = Color.Gray;
            blackjack1.ForeColor = Color.Gray;
            btnHit.Visible = true ;
            btnStand.Visible = true;


            i = 1;
            kurpiernum = 0;
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
            int sayi1 = rastgele.Next(2, 14);
            
           
           //Kurpier Section
            KurpierKolon1.SizeMode = PictureBoxSizeMode.StretchImage;
            KurpierKolon2.SizeMode = PictureBoxSizeMode.StretchImage;
            KurpierKolon2.Image = Image.FromFile(Application.StartupPath + "\\background.jpg");
            KurpierKolon3.Image = Image.FromFile(Application.StartupPath + "\\background.jpg");
            KurpierKolon4.Image = Image.FromFile(Application.StartupPath + "\\background.jpg");
            KurpierKolon5.Image = Image.FromFile(Application.StartupPath + "\\background.jpg");
            //Gamer Section
            GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\background.jpg");
            GamerKolon4.Image = Image.FromFile(Application.StartupPath + "\\background.jpg");
            GamerKolon5.Image = Image.FromFile(Application.StartupPath + "\\background.jpg");
            switch (sayi1)
            {
              
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
                case 14:
                    KurpierKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\as.png");
                    kurpiernum = kurpiernum + 11;
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
            int sayi1 = rastgele.Next(2, 14);
            int sayi2 = rastgele.Next(2, 14);
            GamerKolon1.SizeMode = PictureBoxSizeMode.StretchImage;
            GamerKolon2.SizeMode = PictureBoxSizeMode.StretchImage;
          


                switch (sayi1)
                {
                    
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
                case 14:
                    GamerKolon1.Image = Image.FromFile(Application.StartupPath + "\\maca\\as.png");
                    gamernum = gamernum + 11;
                    break;
                default:
                        Console.WriteLine("Default case");
                        break;
                }
           
                switch (sayi2)
                {
                    
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
                        GamerKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\macapapaz.png");
                        gamernum = gamernum + 10;
                        break;
                case 14:
                    GamerKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\as.png");
                    gamernum = gamernum + 11;
                    break;
                default:
                        Console.WriteLine("Default case");
                        break;
                }
            int yirmibir = sayi1 + sayi2;
            if(yirmibir==21)
            {
                gamerCount.Text = "21";
                blackjack.Text = "Gamer Wins";
                blackjack1.Text = "Kurpier Lost";
                btnHit.Visible = false;
                MessageBox.Show(" 21 değerine ulaştın tebrikler");

                blackjack.ForeColor = Color.Green;

                
            }
            else
            {
                gamerCount.Text = gamernum.ToString();

            }

         

        }
        int i = 1;
        private void Button2_Click(object sender, EventArgs e)
        {
            if (gamerCount.Text == "21")
            {
                MessageBox.Show("Game is 21 already");
               

            }
            else
            {

            if (i == 1)
            {
                Hit();
                   
                }
            if(i == 2)
            {
                    int control = Convert.ToInt32(gamerCount.Text);

                    if (control>21)
                    {
                        MessageBox.Show("You busted Gamer :)");
                        btnHit.Visible = false;
                    }
                    else
                    {
                HitSecond();
                       
                    }
            }
            if(i==3)
                {
                    int control = Convert.ToInt32(gamerCount.Text);

                    if (control > 21)
                    {
                        MessageBox.Show("You busted Gamer ");
                        btnHit.Visible = false;
                    }
                    else
                    {
                   HitThird();
                      


                    }
                }

                int controll = Convert.ToInt32(gamerCount.Text);

                if (controll> 21)
                {
                    MessageBox.Show("You busted Gamer :)");
                    btnHit.Visible = false;
                }
                else
                {
                    i++;
                }


            }
          
            
            
       



        }
        public void Hit()
    {
            int gamernum1 = Convert.ToInt32(gamerCount.Text);
        Random rastgele = new Random();
        int sayi1 = rastgele.Next(2, 14);
            GamerKolon3.SizeMode = PictureBoxSizeMode.StretchImage;
           
            switch (sayi1)
            {
                 
               
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
                    GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\macapapaz.png");
                    gamernum1 = gamernum1 + 10;
                    break;
                case 14:
                    GamerKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\as.png");
                    gamernum1 = gamernum1 + 11;

                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            int yirmibir = gamernum1;
            if (yirmibir == 21)
            {
                gamerCount.Text = "21";
                blackjack.Text = "Gamer Wins";
                blackjack1.Text = "Kurpier Lost";

                blackjack.ForeColor = Color.Green;
               
            }
            else if (yirmibir > 21)
            {
                blackjack1.Text = "Gamer Busted";
                blackjack.Text = "Busted";
                blackjack1.ForeColor = Color.Green;
                blackjack.ForeColor = Color.Red;
                gamerCount.Text = gamernum1.ToString();

            }
            else
            {
                gamerCount.Text = gamernum1.ToString();

            }


        }
        public void HitSecond()
        {
            int gamernum1 = Convert.ToInt32(gamerCount.Text);
            Random rastgele = new Random();
            int sayi2 = rastgele.Next(2, 14);

                GamerKolon4.SizeMode = PictureBoxSizeMode.StretchImage;
                switch (sayi2)
                {
                   
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
                case 14:
                    GamerKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\as.png");
                    gamernum1 = gamernum1 + 11;
                    break;
                default:
                        Console.WriteLine("Default case");
                        break;
                }
            int yirmibir = gamernum1;
            if (yirmibir == 21)
            {
                gamerCount.Text = "21";
                blackjack.Text = "Gamer Wins";
                blackjack1.Text = "Kurpier Lost";
                blackjack.ForeColor = Color.Green;


            }
            else if(yirmibir>21)
            {
                blackjack1.Text = "Gamer Busted";
                blackjack.Text = "Busted";

                blackjack1.ForeColor = Color.Green;
                blackjack.ForeColor = Color.Red;
                gamerCount.Text = gamernum1.ToString();

            }
            else
            {
                gamerCount.Text = gamernum1.ToString();

            }
           
        }
        public void HitThird()
        {
            int gamernum1 = Convert.ToInt32(gamerCount.Text);
            Random rastgele = new Random();
            int sayi2 = rastgele.Next(2, 14);

            GamerKolon5.SizeMode = PictureBoxSizeMode.StretchImage;
            switch (sayi2)
            {

                case 2:
                    GamerKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca2.png");
                    gamernum1 = gamernum1 + 2;
                    break;
                case 3:
                    GamerKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca3.png");
                    gamernum1 = gamernum1 + 3;

                    break;
                case 4:
                    GamerKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca4.png");
                    gamernum1 = gamernum1 + 4;

                    break;
                case 5:
                    GamerKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca5.png");
                    gamernum1 = gamernum1 + 5;

                    break;
                case 6:
                    GamerKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca6.png");
                    gamernum1 = gamernum1 + 6;

                    break;
                case 7:
                    GamerKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca7.png");
                    gamernum1 = gamernum1 + 7;
                    break;
                case 8:
                    GamerKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca8.png");
                    gamernum1 = gamernum1 + 8;
                    break;
                case 9:
                    GamerKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca9.png");
                    gamernum1 = gamernum1 + 9;
                    break;
                case 10:
                    GamerKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca10.png");
                    gamernum1 = gamernum1 + 10;
                    break;
                case 11:
                    GamerKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\macabacak.png");
                    gamernum1 = gamernum1 + 10;
                    break;
                case 12:
                    GamerKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\macakız.png");
                    gamernum1 = gamernum1 + 10;
                    break;
                case 13:
                    GamerKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\macakız.png");
                    gamernum1 = gamernum1 + 10;
                    break;
                case 14:
                    GamerKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\as.png");
                    gamernum1 = gamernum1 + 11;
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            int yirmibir = gamernum1;
            if (yirmibir == 21)
            {
                gamerCount.Text = "21";
                blackjack.Text = "Gamer Wins";
                blackjack1.Text = "Kurpier Lost";
                blackjack.ForeColor = Color.Green;


            }
            else if (yirmibir > 21)
            {
                blackjack1.Text = "Gamer Busted";
                blackjack.Text = "Busted";

                blackjack1.ForeColor = Color.Green;
                blackjack.ForeColor = Color.Red;
                gamerCount.Text = gamernum1.ToString();

            }
            else
            {
                gamerCount.Text = gamernum1.ToString();

            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            btnStand.Visible = false;
            btnHit.Visible = false;
            int kurpier = Convert.ToInt32(kurpierCount.Text);
            int oyuncu = Convert.ToInt32(gamerCount.Text);
            
           //kurpier 18
           //oyuncuda 19
            if (kurpier == 21)
            {
                oyuncubusted = "busted";
            }
            else if (kurpier >= 17)
            {
                if (oyuncu < 21)
                {
                    if (kurpier > oyuncu)
                    {
                        oyuncubusted = "busted";

                    }
                    else if (kurpier == oyuncu)
                    {
                        oyuncubusted = "equal";
                    }
                    else
                    {
                       
                    }
                }
                else
                {
                   oyuncubusted = "busted";
                }
               
            }
            else
            {
                Thread.Sleep(400);
                Stand();
                if (Convert.ToInt32(kurpierCount.Text) == 21)
                {
                    
                }
                else if (Convert.ToInt32(kurpierCount.Text) >= 17)
                {
                    if (Convert.ToInt32(gamerCount.Text) < 21)
                    {
                        if (Convert.ToInt32(kurpierCount.Text) > oyuncu)
                        {
                            oyuncubusted = "busted";

                        }
                        else if (Convert.ToInt32(kurpierCount.Text) == oyuncu)
                        {
                            oyuncubusted = "equal";
                        }
                        else
                        {
                           

                        }
                    }
                }
                else
                {

              Thread.Sleep(800);
                StandSecond();
                }
                if (Convert.ToInt32(kurpierCount.Text) == 21)
                {
                }
                else if (Convert.ToInt32(kurpierCount.Text) >= 17)
                {
                    if (Convert.ToInt32(gamerCount.Text) < 21)
                    {
                        if (Convert.ToInt32(kurpierCount.Text) > oyuncu)
                        {
                            oyuncubusted = "busted";

                        }
                        else if (Convert.ToInt32(kurpierCount.Text) == oyuncu)
                        {
                            oyuncubusted = "equal";
                        }
                        else
                        {
                            
                        }
                    }

                }
                else
                {

                    Thread.Sleep(1400);
                    StandThird();

                }
                if (Convert.ToInt32(kurpierCount.Text) == 21)
                {
                }
                else if (Convert.ToInt32(kurpierCount.Text) >= 17)
                {
                    if (Convert.ToInt32(gamerCount.Text) < 21)
                    {
                        if (Convert.ToInt32(kurpierCount.Text) > oyuncu)
                        {
                            oyuncubusted = "busted";

                        }
                        else if (Convert.ToInt32(kurpierCount.Text) == oyuncu)
                        {
                            oyuncubusted = "equal";
                        }
                    }
                }
                else
                {

                    Thread.Sleep(2400);
                    StandFourth();

                }
                
            }
            int cipk = Convert.ToInt32(kurpierCount.Text);
            int cipg = Convert.ToInt32(gamerCount.Text);
            if(oyuncubusted=="equal")
            {
                kurpiercip += 50;
                oyuncucip += 50;
                MessageBox.Show("Oyun Berabere Tebrikler");
            }
          else  if (oyuncubusted == "busted")
            {
                MessageBox.Show("Kurpiyer Kazandi");

                kurpiercip += 100;
            }
            else
            {
                MessageBox.Show("Oyuncu Kazandi");

                oyuncucip += 100;
            }
              lblCiftG.Text = oyuncucip.ToString();
                lblCipK.Text = kurpiercip.ToString();
        }
        public void Stand()
        {
            
                int kurpiernum = Convert.ToInt32(kurpierCount.Text);
                Random rastgele = new Random();
                int sayi1 = rastgele.Next(2, 14);
                KurpierKolon2.SizeMode = PictureBoxSizeMode.StretchImage;

                switch (sayi1)
                {


                    case 2:
                    KurpierKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca2.png");
                    kurpiernum = kurpiernum + 2;
                        break;
                    case 3:
                    KurpierKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca3.png");
                    kurpiernum = kurpiernum + 3;

                        break;
                    case 4:
                    KurpierKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca4.png");
                    kurpiernum = kurpiernum + 4;

                        break;
                    case 5:
                    KurpierKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca5.png");
                    kurpiernum = kurpiernum + 5;

                        break;
                    case 6:
                    KurpierKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca6.png");
                    kurpiernum = kurpiernum + 6;

                        break;
                    case 7:
                    KurpierKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca7.png");
                    kurpiernum = kurpiernum + 7;
                        break;
                    case 8:
                    KurpierKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca8.png");
                    kurpiernum = kurpiernum + 8;
                        break;
                    case 9:
                    KurpierKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca9.png");
                    kurpiernum = kurpiernum + 9;
                        break;
                    case 10:
                    KurpierKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca10.png");
                    kurpiernum = kurpiernum + 10;
                        break;
                    case 11:
                    KurpierKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\macabacak.png");
                    kurpiernum = kurpiernum + 10;
                        break;
                    case 12:
                    KurpierKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\macakız.png");
                    kurpiernum = kurpiernum + 10;
                        break;
                    case 13:
                    KurpierKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\macapapaz.png");
                    kurpiernum = kurpiernum + 10;
                        break;
                    case 14:
                    KurpierKolon2.Image = Image.FromFile(Application.StartupPath + "\\maca\\as.png");
                    kurpiernum = kurpiernum + 11;

                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
                int yirmibir = kurpiernum;
                if (yirmibir == 21)
                {
                kurpierCount.Text = "21";
                    blackjack.Text = "Kurpier Wins";
                    blackjack1.Text = "Gamer Lost";

                    blackjack.ForeColor = Color.Green;

                }
                else if (yirmibir > 21)
                {
                    blackjack1.Text = "Kurpier Busted";
                    blackjack.Text = "Busted";
                    blackjack1.ForeColor = Color.Green;
                    blackjack.ForeColor = Color.Red;
                    kurpierCount.Text = kurpiernum.ToString();

                }
                else
                {
                kurpierCount.Text = kurpiernum.ToString();

                }


            }
        public void StandSecond()
        {

            int kurpiernum = Convert.ToInt32(kurpierCount.Text);
            Random rastgele = new Random();
            int sayi1 = rastgele.Next(2, 14);
            KurpierKolon3.SizeMode = PictureBoxSizeMode.StretchImage;

            switch (sayi1)
            {


                case 2:
                    KurpierKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca2.png");
                    kurpiernum = kurpiernum + 2;
                    break;
                case 3:
                    KurpierKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca3.png");
                    kurpiernum = kurpiernum + 3;

                    break;
                case 4:
                    KurpierKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca4.png");
                    kurpiernum = kurpiernum + 4;

                    break;
                case 5:
                    KurpierKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca5.png");
                    kurpiernum = kurpiernum + 5;

                    break;
                case 6:
                    KurpierKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca6.png");
                    kurpiernum = kurpiernum + 6;

                    break;
                case 7:
                    KurpierKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca7.png");
                    kurpiernum = kurpiernum + 7;
                    break;
                case 8:
                    KurpierKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca8.png");
                    kurpiernum = kurpiernum + 8;
                    break;
                case 9:
                    KurpierKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca9.png");
                    kurpiernum = kurpiernum + 9;
                    break;
                case 10:
                    KurpierKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca10.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                case 11:
                    KurpierKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\macabacak.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                case 12:
                    KurpierKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\macakız.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                case 13:
                    KurpierKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\macapapaz.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                case 14:
                    KurpierKolon3.Image = Image.FromFile(Application.StartupPath + "\\maca\\as.png");
                    kurpiernum = kurpiernum + 11;

                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            int yirmibir = kurpiernum;
            if (yirmibir == 21)
            {
                kurpierCount.Text = "21";
                blackjack.Text = "Kurpier Wins";
                blackjack1.Text = "Gamer Lost";

                blackjack.ForeColor = Color.Green;

            }
            else if (yirmibir > 21)
            {
                blackjack1.Text = "Kurpier Busted";
                blackjack.Text = "Busted";
                blackjack1.ForeColor = Color.Green;
                blackjack.ForeColor = Color.Red;
                kurpierCount.Text = kurpiernum.ToString();

            }
            else
            {
                kurpierCount.Text = kurpiernum.ToString();

            }


        }
        public void StandThird()
        {

            int kurpiernum = Convert.ToInt32(kurpierCount.Text);
            Random rastgele = new Random();
            int sayi1 = rastgele.Next(2, 14);
            KurpierKolon4.SizeMode = PictureBoxSizeMode.StretchImage;

            switch (sayi1)
            {


                case 2:
                    KurpierKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca2.png");
                    kurpiernum = kurpiernum + 2;
                    break;
                case 3:
                    KurpierKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca3.png");
                    kurpiernum = kurpiernum + 3;

                    break;
                case 4:
                    KurpierKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca4.png");
                    kurpiernum = kurpiernum + 4;

                    break;
                case 5:
                    KurpierKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca5.png");
                    kurpiernum = kurpiernum + 5;

                    break;
                case 6:
                    KurpierKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca6.png");
                    kurpiernum = kurpiernum + 6;

                    break;
                case 7:
                    KurpierKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca7.png");
                    kurpiernum = kurpiernum + 7;
                    break;
                case 8:
                    KurpierKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca8.png");
                    kurpiernum = kurpiernum + 8;
                    break;
                case 9:
                    KurpierKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca9.png");
                    kurpiernum = kurpiernum + 9;
                    break;
                case 10:
                    KurpierKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca10.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                case 11:
                    KurpierKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\macabacak.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                case 12:
                    KurpierKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\macakız.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                case 13:
                    KurpierKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\macapapaz.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                case 14:
                    KurpierKolon4.Image = Image.FromFile(Application.StartupPath + "\\maca\\as.png");
                    kurpiernum = kurpiernum + 11;

                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            int yirmibir = kurpiernum;
            if (yirmibir == 21)
            {
                kurpierCount.Text = "21";
                blackjack.Text = "Kurpier Wins";
                blackjack1.Text = "Gamer Lost";

                blackjack.ForeColor = Color.Green;

            }
            else if (yirmibir > 21)
            {
                blackjack1.Text = "Kurpier Busted";
                blackjack.Text = "Busted";
                blackjack1.ForeColor = Color.Green;
                blackjack.ForeColor = Color.Red;
                kurpierCount.Text = kurpiernum.ToString();

            }
            else
            {
                kurpierCount.Text = kurpiernum.ToString();

            }


        }
        public void StandFourth()
        {

            int kurpiernum = Convert.ToInt32(kurpierCount.Text);
            Random rastgele = new Random();
            int sayi1 = rastgele.Next(2, 14);
            KurpierKolon5.SizeMode = PictureBoxSizeMode.StretchImage;

            switch (sayi1)
            {


                case 2:
                    KurpierKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca2.png");
                    kurpiernum = kurpiernum + 2;
                    break;
                case 3:
                    KurpierKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca3.png");
                    kurpiernum = kurpiernum + 3;

                    break;
                case 4:
                    KurpierKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca4.png");
                    kurpiernum = kurpiernum + 4;

                    break;
                case 5:
                    KurpierKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca5.png");
                    kurpiernum = kurpiernum + 5;

                    break;
                case 6:
                    KurpierKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca6.png");
                    kurpiernum = kurpiernum + 6;

                    break;
                case 7:
                    KurpierKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca7.png");
                    kurpiernum = kurpiernum + 7;
                    break;
                case 8:
                    KurpierKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca8.png");
                    kurpiernum = kurpiernum + 8;
                    break;
                case 9:
                    KurpierKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca9.png");
                    kurpiernum = kurpiernum + 9;
                    break;
                case 10:
                    KurpierKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\maca10.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                case 11:
                    KurpierKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\macabacak.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                case 12:
                    KurpierKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\macakız.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                case 13:
                    KurpierKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\macapapaz.png");
                    kurpiernum = kurpiernum + 10;
                    break;
                case 14:
                    KurpierKolon5.Image = Image.FromFile(Application.StartupPath + "\\maca\\as.png");
                    kurpiernum = kurpiernum + 11;

                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            int yirmibir = kurpiernum;
            if (yirmibir == 21)
            {
                kurpierCount.Text = "21";
                blackjack.Text = "Kurpier Wins";
                blackjack1.Text = "Gamer Lost";

                blackjack.ForeColor = Color.Green;

            }
            else if (yirmibir > 21)
            {
                blackjack1.Text = "Kurpier Busted";
                blackjack.Text = "Busted";
                blackjack1.ForeColor = Color.Green;
                blackjack.ForeColor = Color.Red;
                kurpierCount.Text = kurpiernum.ToString();

            }
            else
            {
                kurpierCount.Text = kurpiernum.ToString();

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCiftG.Text = oyuncucip.ToString();
            lblCipK.Text = kurpiercip.ToString();

        }
    }
}


  



