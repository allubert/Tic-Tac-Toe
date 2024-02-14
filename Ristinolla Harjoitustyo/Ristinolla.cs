using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace Ristinolla_Harjoitustyo
{
    public partial class Ristinolla : Form
    {
        //Luo ristinolla pelikentän

        int[] iRistinolla = new int[9];
        int iSeuraavavuoro = -1;
        const int EX = 1;
        const int OH = 2;
        int iPelimuoto = 1; //jos pelimuoto 1, pelaa tietokonetta vastaan, jos jotain muuta, pelaa kaveria vastaan

        Rectangle[] rPeliruudukko =
        {
            new Rectangle(16,16,96,96),
            new Rectangle(128,16,96,96),
            new Rectangle(240,16,96,96),
            new Rectangle(16,128,96,96),
            new Rectangle(128,128,96,96),
            new Rectangle(240,128,96,96),
            new Rectangle(16,240,96,96),
            new Rectangle(128,240,96,96),
            new Rectangle(240,240,96,96)
        };

        public Ristinolla()
        {
            InitializeComponent();
            this.MouseClick += new MouseEventHandler(Ristinolla_Hiirenklikkaus);
            NollaaPeli();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Piiratausta(e.Graphics);
        }
        int Hiirenpaikka(Point pt)
        {
            for (int i = 0; i < 9; i++)
            {
                if (pt.X > rPeliruudukko[i].Left && pt.X < rPeliruudukko[i].Right && pt.Y > rPeliruudukko[i].Top
                    && pt.Y < rPeliruudukko[i].Bottom)
                    return i;
            }
            return -1;
        }
        void Piiratausta(Graphics g)
        {
            Pen kyna = new Pen(Color.Black, 16);
            g.DrawLine(kyna, 120, 16, 120, 336);
            g.DrawLine(kyna, 232, 16, 232, 336);
            g.DrawLine(kyna, 16, 120, 336, 120);
            g.DrawLine(kyna, 16, 232, 336, 232);

            for (int i = 0; i < 9; i++)
            {
                if (iRistinolla[i] == EX)
                    PiirraX(i);
                else if (iRistinolla[i] == OH)
                    PiirraO(i);
            }
        }

        void PiirraX(int nPos)
        {
            using (Graphics g = CreateGraphics())
            {
                Pen pn = new Pen(Color.Blue, 16);
                Rectangle rect = rPeliruudukko[nPos];
                rect.Inflate(-16, -16);
                g.DrawLine(pn, rect.Left, rect.Top, rect.Right, rect.Bottom);
                g.DrawLine(pn, rect.Left, rect.Bottom, rect.Right, rect.Top);
            }
        }
        void PiirraO(int nPos)
        {
            using (Graphics g = CreateGraphics())
            {
                Pen pn = new Pen(Color.Red, 16);
                Rectangle rect = rPeliruudukko[nPos];
                rect.Inflate(-16, -16);
                g.DrawEllipse(pn, rect);
            }
        }
        void TarkkistaPeli()
        {
            int iVoittaja = TarkistaVoittaja();

            if (iVoittaja != 0)
            {
                string sVoitto = (iVoittaja == EX) ? "X voitti!" : "O voitti!";
                MessageBox.Show(sVoitto, "Peli loppui", MessageBoxButtons.OK);
                NollaaPeli();

            }
            else if (TasaPeli())
            {
                MessageBox.Show("Tasapeli");
                NollaaPeli();
            }
        }
        int TarkistaVoittaja()
        {
            int[,] iTarkistus =
            {
                {0,1,2},
                {3,4,5},
                {6,7,8},
                {0,3,6},
                {1,4,7},
                {2,5,8},
                {0,4,8},
                {2,4,6}
            };
            for (int i = 0; i < 8; i++)
            {
                if ((iRistinolla[iTarkistus[i, 0]] == EX) &&
                   (iRistinolla[iTarkistus[i, 1]] == EX) &&
                   (iRistinolla[iTarkistus[i, 2]] == EX))
                    return EX;
                if ((iRistinolla[iTarkistus[i, 0]] == OH) &&
                   (iRistinolla[iTarkistus[i, 1]] == OH) &&
                   (iRistinolla[iTarkistus[i, 2]] == OH))
                    return OH;
            }
            return 0;
        }
        bool TasaPeli()
        {
            for (int i = 0; i < 9; i++)
            {
                if (iRistinolla[i] == 0)
                    return false;
            }
            return true;
        }
        void NollaaPeli()
        {
            iSeuraavavuoro = EX;
            for (int i = 0; i < 9; i++)
            {
                iRistinolla[i] = 0;

            }
            Invalidate();
        }
        public void Ristinolla_Hiirenklikkaus(object sender, MouseEventArgs e)
        {
            if (iPelimuoto == 1)
            {
                if (iSeuraavavuoro == EX)
                {
                    int nPos = Hiirenpaikka(new Point(e.X, e.Y));
                    if (nPos == -1 || iRistinolla[nPos] != 0)
                        return;
                    iRistinolla[nPos] = EX;
                    iSeuraavavuoro = OH;
                    PiirraX(nPos);
                    Tietokoneen_Siirto();
                    TarkkistaPeli();
                    TarkistaVoittaja();
                    iSeuraavavuoro = EX;
                    return;
                }
            }
            else
            {
                if (iSeuraavavuoro != EX)
                {
                    int nPos = Hiirenpaikka(new Point(e.X, e.Y));
                    if (nPos == -1 || iRistinolla[nPos] != 0)
                        return;
                    iRistinolla[nPos] = OH;
                    iSeuraavavuoro = EX;
                    PiirraO(nPos);
                    TarkkistaPeli();
                    TarkistaVoittaja();
                    return;
                }
            }

            if (e.Button == MouseButtons.Middle)
            {
                NollaaPeli();
            }
        }

        private void Tietokoneen_Siirto()
        {
            Random rnd = new Random();

            if (TarkistaVoittaja() != OH && TarkistaVoittaja() != EX && TasaPeli() == false) //jos peli ei ole vielä ratkennut
            {
                OdotusAika(1); //tekoälyn miettimisaika 1 sekunti
                
                if (!TietokoneenOikeaVuoro(OH)) //tällä tarkistetaan tietokoneen omat siirrot, joka miettii paikkaa millä voittaisi
                {
                    if (!TietokoneenOikeaVuoro(EX)) //jos ei voiteta niin puolustetaan
                    {
                        while (true) //jos ei ole vaihtoehtoja, niin sitten arvotaan paikka
                        {
                            int i = rnd.Next(9);
                            if (iRistinolla[i] == 0)
                            {
                                iRistinolla[i] = OH;
                                PiirraO(i);
                                this.Refresh();
                                return;
                            }
                        }
                    }
                }
            }
            else
            {
                OdotusAika(0);
            }
        }
        private bool TietokoneenOikeaVuoro(int hyokkayspuolustusspagetti)
        {
            int ristivinooikea = 0;
            int ristivinovasen = 0;

            for (int i = 0; i < 3; i++) //Tämä tarkistaa kaikki mahdollisuudet
            {
                int ristivaaka = 0;
                int ristipysty = 0;
                
                // 0 3 6
                // 1 4 7
                // 2 5 8

                if (iRistinolla[i + 3 * i] == hyokkayspuolustusspagetti) //Taulukon vinorivi vas ylhäältä oikealle alas eli 0, 4, 8
                {
                    ristivinooikea++;
                }
                if (iRistinolla[2 - i + 3 * i] == hyokkayspuolustusspagetti) //Taulukon vinorivi vas alhaalta oikealle ylös 2, 4, 6
                {
                    ristivinovasen++;
                }

                for (int j = 0; j < 3; j++) //Sisempi looppi käy vaaka ja pystyrivit
                {
                    if (iRistinolla[j + 3 * i] == hyokkayspuolustusspagetti)
                    {
                        ristivaaka++;
                    }
                    if (iRistinolla[i + 3 * j] == hyokkayspuolustusspagetti)
                    {
                        ristipysty++;
                    }
                }
                if (ristivaaka == 2) //tämä tarkistaa sen onko ristejä jo kaksi rivillä
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (iRistinolla[j + 3 * i] == 0)
                        {
                            iRistinolla[j + 3 * i] = OH;
                            PiirraO(j + 3 * i);
                            this.Refresh();
                            return true;
                        }
                    }
                }
                if (ristipysty == 2) //sama homma mutta pystysuunnassa
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (iRistinolla[i + 3 * j] == 0)
                        {
                            iRistinolla[i + 3 * j] = OH;
                            PiirraO(i + 3 * j);
                            this.Refresh();
                            return true;
                        }
                    }
                }
            }
            if (ristivinooikea == 2) //sama homma mutta vinot
            {
                for (int i = 0; i < 3; i++)
                {
                    if (iRistinolla[i + 3 * i] == 0)
                    {
                        iRistinolla[i + 3 * i] = OH;
                        PiirraO(i + 3 * i);
                        this.Refresh();
                        return true;
                    }
                }
            }
            if (ristivinovasen == 2) //sama homma mutta vinot
            {
                for (int i = 0; i < 3; i++)
                {
                    if (iRistinolla[2 - i + 3 * i] == 0)
                    {
                        iRistinolla[2 - i + 3 * i] = OH;
                        PiirraO(2 - i + 3 * i);
                        this.Refresh();
                        return true;
                    }
                }
            }
            return false;
        }
        private void OdotusAika(int sekuntia) //tällä funktiolla synnytettiin tekoälyn miettimisaika
        {
            if (sekuntia < 1)
            {
                return;
            }
            
            DateTime haluttu = DateTime.Now.AddSeconds(sekuntia);
            
            while (DateTime.Now < haluttu)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            NollaaPeli();
        }
    }
}
