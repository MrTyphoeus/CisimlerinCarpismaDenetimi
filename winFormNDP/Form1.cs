
using winFormNDP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static winFormNDP.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace winFormNDP
{
        public partial class Form1 : Form
    {
        
       
        public Form1()
        {
            InitializeComponent();
        }

        string secilen = "";
        private void Form1_Load(object sender, EventArgs e)
        {

        }




        int kacNesne = 0;
        int secilenNoktaSayisi = 0, secilenKureSayisi = 0, secilenDikdortgenSayisi = 0;
        int secilenCemberSayisi = 0, secilenYuzeySayisi = 0, secilenSilindirSayisi = 0;
        private Nokta3d[] noktalar = new Nokta3d[2];
        private Kure[] kureler = new Kure[2];
        private dikdortgen[] dikdortgenler = new dikdortgen[2];
        private circle[] cemberler = new circle[2];
        private Yuzey[] yuzeyler = new Yuzey[2];
        private silindir[] silindirler = new silindir[2];

        private void nesnemaxsayisiuyari()
        {
            string message = "Maksimum 2 nesne ekleyebilirsiniz";
            string title = "UYARI";
            MessageBox.Show(message, title);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void buttonPaint_Click(object sender, EventArgs e) //gönder butonu
        {
            Graphics g = panel1.CreateGraphics();
            GraphicsPath path = new GraphicsPath();
 
            int x = (int)xSend.Value;
            int y = (int)ySend.Value;
            int z = (int)zSend.Value;
            int r = (int)rSend.Value;
            int en = (int)enSend.Value;
            int boy = (int)boySend.Value;
            string secilen = "";

            if (listBox1.SelectedIndex != -1)
            {
                secilen = listBox1.SelectedItem.ToString();
            }

            if (kacNesne < 2)
            {
                buttonReset.Visible = false;

                //----NOKTA

                if (secilen == "Nokta" && secilenNoktaSayisi < 2)
                {
                    noktalar[secilenNoktaSayisi] = new Nokta3d(x, y, z);
                    label7.Text = "Nokta" ;
                    secilenNoktaSayisi++;

                    g.DrawRectangle(Pens.Black, new Rectangle(x, 430 - y, 1, 1));

                }
                else if (secilenNoktaSayisi > 2)
                    nesnemaxsayisiuyari();

                //----------
                //----KÜRE

                if (secilen == "Küre" && secilenKureSayisi < 2)
                {
                    kureler[secilenKureSayisi] = new Kure(new Nokta3d(x, y, z), r);

                    if (z != 0)
                    {
                        float zx = (float)Math.Sqrt(z);
                        r = r/Convert.ToInt32(zx);

                    }

                    label7.Text = "Küre";

                    g.DrawEllipse(Pens.Black, new Rectangle(x - r / 2, (430 - y) - r / 2, r, r));

                    g.DrawEllipse(Pens.Black, new Rectangle(x - r / 2, (430 - y) - r / 2 + (3 * r / 8), r, r / 3));

                    secilenKureSayisi++;
                }

                else if (secilenKureSayisi > 2)
                    nesnemaxsayisiuyari();

                //----------
                //----DİKDÖRTGEN

                if (secilen == "Dikdörtgen" && secilenDikdortgenSayisi < 2)

                {
                    if (z != 0)
                    {
                        float zx = (float)Math.Sqrt(Math.Sqrt(z));
                        en = en / Convert.ToInt32(zx);
                        boy = boy / Convert.ToInt32(zx);

                    }


                    dikdortgenler[secilenDikdortgenSayisi] = new dikdortgen(new Nokta3d(x, y, z), en, boy);

                    label7.Text = "Dikdörtgen";

                    g.DrawRectangle(Pens.Black, new Rectangle(x, (430 - y) - boy, en, boy));

                    secilenDikdortgenSayisi++;

                }
                else if (secilenDikdortgenSayisi > 2)
                    nesnemaxsayisiuyari();

                //----------
                //----Silindir

                if (secilen == "Silindir" && secilenSilindirSayisi < 2)
                {
                    silindirler[secilenSilindirSayisi] = new silindir(new Nokta3d(x,y,z), en, boy);
                    label7.Text = "Silindir";

                    g.DrawLine(Pens.Black, x - en / 2, (430 - y) - boy / 2, x - en / 2, (430 - y) + boy / 2);
                    g.DrawLine(Pens.Black, x - en / 2, (430 - y) + boy / 2, x + en / 2, (430 - y) + boy / 2);
                    g.DrawLine(Pens.Black, x + en / 2, (430 - y) + boy / 2, x + en / 2, (430 - y) - boy / 2);
                    g.DrawEllipse(Pens.Black, new Rectangle(x - en / 2, (430 - y) - boy / 2 - 20, en, 40));

                    secilenSilindirSayisi++;
                
                }
                else if(secilenSilindirSayisi > 2)
                    nesnemaxsayisiuyari();


                //----------
                //----Çember

                if (secilen == "Çember" && secilenCemberSayisi < 2)
                {
                    cemberler[secilenCemberSayisi] = new circle(new Nokta3d(x, y, z), r);

                    label7.Text = "Çember";

                    g.DrawEllipse(Pens.Black, new Rectangle(x - r / 2, (430 - y) - r / 2, r, r));

                    secilenCemberSayisi++;
                }
                else if (secilenCemberSayisi > 2)
                    nesnemaxsayisiuyari();

                //----------
                //----Yüzey

                if (secilen == "Yüzey" && secilenYuzeySayisi < 2) 
                {
                    yuzeyler[secilenYuzeySayisi] = new Yuzey(x, y, z, boy);
                    label7.Text = "Yüzey";
                    secilenYuzeySayisi++;

                    g.DrawRectangle(Pens.Black, new Rectangle(x, 430 - y, 1, boy));
                    g.DrawRectangle(Pens.Black, new Rectangle(x+4*(int)Math.Sqrt(z), 430 - y - 4*(int)Math.Sqrt(z), 1, boy- (int)Math.Sqrt(z)));
                    g.DrawLine(Pens.Gray, x, 430 - y, x + 4 * (int)Math.Sqrt(z), 430 - y - 4 * (int)Math.Sqrt(z));
                    g.DrawLine(Pens.Gray, x, 430 - y + boy, x + 4 * (int)Math.Sqrt(z), 430 - y - 4 * (int)Math.Sqrt(z) + boy - (int)Math.Sqrt(z));
                }
                else if (secilenYuzeySayisi > 2)
                    nesnemaxsayisiuyari();

                
                kacNesne++;

                if (kacNesne == 2)
                    {
                        //-------------------------CARPISMA TEST

                        //----Nokta

                        if (secilenNoktaSayisi == 1)
                        {
                            if (secilenKureSayisi == 1)
                            {
                                if (Carpisma.kurenoktaCarp(kureler[0], noktalar[0]))
                                    label7.Text = "Küre 1 ve Nokta 1 Çarpışıyor";
                            }
                            if (secilenDikdortgenSayisi == 1)
                            {
                                if (noktalar[0].Z == dikdortgenler[0].M.Z)
                                    if (Carpisma.dikdortgennoktaCarp(dikdortgenler[0], noktalar[0]))
                                        label7.Text = "Dikdörtgen 1 ve Nokta 1 Çarpışıyor";
                            }
                            if (secilenSilindirSayisi == 1)
                            {
                                if (Carpisma.silindirnoktaCarp(silindirler[0], noktalar[0]))
                                 label7.Text = "Silindir 1 ve Nokta 1 Çarpışıyor";
                            }

                            if (secilenCemberSayisi == 1)
                            {
                                if (noktalar[0].Z == cemberler[0].M.Z)
                                    if (Carpisma.cembernoktaCarp(cemberler[0], noktalar[0]))
                                        label7.Text = "Çember 1 ve Nokta 1 Çarpışıyor";
                            }
                            if (secilenYuzeySayisi == 1)
                            {
                                if (Carpisma.yuzeynoktaCarp(yuzeyler[0], noktalar[0]))
                                    label7.Text = "Yüzey 1 ve Nokta 1 Çarpışıyor";
                            }

                        } //Nokta ve diğer nesneler
                        if (secilenNoktaSayisi == 2)
                        {
                            if (
                            noktalar[0].X == noktalar[1].X &&
                            noktalar[0].Y == noktalar[1].Y &&
                            noktalar[0].Z == noktalar[1].Z
                            ) label7.Text = "Nokta 1 ve Nokta 2 Çarpışıyor"; ;
                        } // Nokta Nokta

                        //-----
                        //----Küre

                        if (secilenKureSayisi == 1)
                    {
                        if (secilenDikdortgenSayisi == 1)
                        {
                            if (Carpisma.kuredikdortgenCarp(kureler[0], dikdortgenler[0]))
                                label7.Text = "Küre 1 ve Dikdörtgen 1 çarpışıyor";
                        }

                        if(secilenSilindirSayisi == 1)
                        {
                            if (Carpisma.kuresilindirCarp(kureler[0], silindirler[0]))
                                label7.Text = "Küre 1 ve Dikdörtgen 1 çarpışıyor";
                        }



                        if (secilenCemberSayisi == 1) { 
                             if (Carpisma.kurecemberCarp(kureler[0], cemberler[0]))
                                label7.Text = "Küre 1 ve Çember 1 çarpışıyor";
                        }

                    }
                        if (secilenKureSayisi == 2)
                        {
                            if (Carpisma.kureCarp(kureler[0], kureler[1]))
                                label7.Text = "Küre 1 ve Küre 2 çarpışıyor";
                           
                        }

                        //-----
                        //----Dikdörtgen

                        if (secilenDikdortgenSayisi == 1)
                        {
                          if (secilenCemberSayisi == 1)
                          {
                            if (Carpisma.dikdortgencemberCarp(cemberler[0], dikdortgenler[0]))
                                label7.Text = "Çember 1 ve Dikdörtgen 1 çarpışıyor";
                           }                       

                        if(secilenSilindirSayisi == 1)
                        {
                        if (Carpisma.silindirdikdortgenCarp(silindirler[0], dikdortgenler[0]))
                            label7.Text = "Silindir 1 ve Dikdörtgen 1 çarpışıyor";

                        }
                        }
                        if (secilenDikdortgenSayisi == 2)
                        {
                            if (Carpisma.dikdortgenCarp(dikdortgenler[0], dikdortgenler[1]))
                                label7.Text = "Dikdörtgen 1 ve Dikdörtgen 2 çarpışıyor";
                        }

                        //-----
                        //----Silindir

                        if(secilenSilindirSayisi == 2)
                        {
                        if (Carpisma.silindirCarp(silindirler[0], silindirler[1]))
                            label7.Text = "Silindir 1 ve Silindir 2 çarpışıyor";
                        }


                        //-----
                        //----Çember

                        if (secilenCemberSayisi == 1)
                        if (secilenCemberSayisi == 2)
                        {
                            if (Carpisma.cemberCarp(cemberler[0], cemberler[1]))
                                label7.Text = "Çember 1 ve Çember 2 çarpışıyor";
                        }

                        //-----
                        //----Yüzey

                        if(secilenYuzeySayisi == 1) {
                        if (secilenDikdortgenSayisi == 1)
                            if (Carpisma.yuzeydikdortgenCarp(yuzeyler[0], dikdortgenler[0]))
                                label7.Text = "Yüzey 1 ve Dikdörtgen 1 Çarpışıyor";
    
                        }


                    //-------------------------------
                    nesnemaxsayisiuyari();
                         buttonReset.Visible = true;
                }


                
            }
            else if(kacNesne > 2)
            {
                nesnemaxsayisiuyari();
                buttonReset.Visible = true;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Update();
            kacNesne = 0;
            panel1.Controls.Clear();
            secilenNoktaSayisi = 0; secilenKureSayisi = 0; secilenDikdortgenSayisi = 0;
            secilenCemberSayisi = 0; secilenYuzeySayisi = 0; secilenSilindirSayisi = 0;
        }

        private void ekle_Click(object sender, EventArgs e)
        {

            rSend.Visible = false;
            r.Visible = false;
            boyLabel.Visible = false;
            enLabel.Visible = false;
            boySend.Visible = false;
            enSend.Visible = false;

            if (listBox1.SelectedIndex != -1)
            {
                secilen = listBox1.SelectedItem.ToString();
                label3.Text = secilen;
                xSend.Enabled = true;
                ySend.Enabled = true;
                zSend.Enabled = true;
                if (secilen == "Küre")
                {
                    rSend.Visible = true;
                    r.Visible = true;
                }
                if (secilen == "Dikdörtgen")
                {
                    boyLabel.Visible = true;
                    enLabel.Visible = true;
                    boySend.Visible = true;
                    enSend.Visible = true;

                }
                if (secilen == "Çember")
                {
                    rSend.Visible= true;
                    r.Visible = true;
                }
                if (secilen == "Yüzey")
                {
                    boySend.Visible = true;
                    boyLabel.Visible = true;
                }
                if (secilen == "Silindir")
                {
                    boyLabel.Visible = true;
                    enLabel.Visible = true;
                    boySend.Visible = true;
                    enSend.Visible = true;

                }
            }
          
            
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }




    }

}
