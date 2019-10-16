using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pacanele_de_belele
{
    public partial class Form1 : Form
    {
        private void WaitNSeconds(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }
        Random rnd = new Random();

        int l1 = 0,l2=0,l3=0;
        int cash = 5000;
        int bet=0;

        public Form1()
        {
            InitializeComponent();
        }
        int secbet = 0;
        void prize(int n)
        {

            switch(n)
            {
                case 1: secbet = (int)(1.2f * bet);
                    break;
                case 2:
                        secbet = (int)(1.5f * bet);
                    break;
                case 3:
                        secbet = (int)(2.5f * bet);
                    break;
                case 4:
                    secbet = (int)(5.0f * bet);
                    break;
                case 5:
                    {




                    }
                    break;
             



            }
        }

        void play()
        {
            button1.Hide();
            line1.Start();
            linie2.Start();
            linie3.Start();
            WaitNSeconds(1);
            line1.Stop();
            WaitNSeconds(1);
            linie2.Stop();
            WaitNSeconds(1);
            linie3.Stop();
            button1.Show();

            if (l1 == l2 && l2 == l3) prize(l1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cashlab.Text = cash.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { bet = Convert.ToInt32(b_t.Text); } catch { bet = 0; }
            if (bet <= cash)
            {
                cash -= bet;
                Cashlab.Text = cash.ToString();
                play();

           //     if (l1 == l2 && l2== l3) prize(l1);
            }
            else
                MessageBox.Show("Bet prea mare , nu ai $$");
        }

        private void linie3_Tick(object sender, EventArgs e)
        {
            l3 = rnd.Next(1, 5);
            switch (l3)
            {
               
                case 1:
                    Lamaie3.Show(); barbatel3.Hide(); Cireasa3.Hide(); ls3.Hide(); pruna3.Hide();
                    break;
                case 2:
                    Lamaie3.Hide(); barbatel3.Show(); Cireasa3.Hide(); ls3.Hide(); pruna3.Hide();
                    break;
                case 3:
                    Lamaie3.Hide(); barbatel3.Hide(); Cireasa3.Show(); ls3.Hide(); pruna3.Hide();
                    break;
                case 4:
                    Lamaie3.Hide(); barbatel3.Hide(); Cireasa3.Hide(); ls3.Show(); pruna3.Hide();
                    break;
                case 5:
                    Lamaie3.Hide(); barbatel3.Hide(); Cireasa3.Hide(); ls3.Hide(); pruna3.Show();
                    break;
            }
          

        }

        private void line1_Tick(object sender, EventArgs e)
        {
            l1 = rnd.Next(1, 5);
            switch(l1)
            {
                case 1:
                    Lamaie1.Show();barbatel1.Hide();Cireasa1.Hide();ls1.Hide();pruna1.Hide();
                    break;
                case 2:
                    Lamaie1.Hide(); barbatel1.Show(); Cireasa1.Hide(); ls1.Hide(); pruna1.Hide();
                    break;
                case 3:
                    Lamaie1.Hide(); barbatel1.Hide(); Cireasa1.Show(); ls1.Hide(); pruna1.Hide();
                    break;
                case 4:
                    Lamaie1.Hide(); barbatel1.Hide(); Cireasa1.Hide(); ls1.Show(); pruna1.Hide();
                    break;
                case 5:
                    Lamaie1.Hide(); barbatel1.Hide(); Cireasa1.Hide(); ls1.Hide(); pruna1.Show();
                    break;
            }
                  
        }

        private void linie2_Tick(object sender, EventArgs e)
        {
            l2 = rnd.Next(1, 5);
            switch (l2)
            {
                case 1:
                    Lamaie2.Show(); barbatel2.Hide(); Cireasa2.Hide(); ls2.Hide(); pruna2.Hide();
                    break;
                case 2:
                    Lamaie2.Hide(); barbatel2.Show(); Cireasa2.Hide(); ls2.Hide(); pruna2.Hide();
                    break;
                case 3:
                    Lamaie2.Hide(); barbatel2.Hide(); Cireasa2.Show(); ls2.Hide(); pruna2.Hide();
                    break;
                case 4:
                    Lamaie2.Hide(); barbatel2.Hide(); Cireasa2.Hide(); ls2.Show(); pruna2.Hide();
                    break;
                case 5:
                    Lamaie2.Hide(); barbatel2.Hide(); Cireasa2.Hide(); ls2.Hide(); pruna2.Show();
                    break;
            }
         
        }
    }
}
