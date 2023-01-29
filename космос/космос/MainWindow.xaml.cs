using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using инопланетяне;

namespace космос
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Alien alien1 = new Alien();
        Alien alien2 = new Alien();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTChan1_Click(object sender, RoutedEventArgs e)
        {
            alien1.Height = Convert.ToDouble(H1.Text);
            int fr = Convert.ToInt32(from1.Text);
            int bf = Convert.ToInt32(before1.Text);
            Random r = new Random();
            bf += 1;
            double rr = r.Next(fr, bf);
            alien1.Maxheight = Convert.ToDouble(MaxH1.Text);
            alien1.Minheight = Convert.ToDouble(MinH1.Text);
            if (rr > alien1.Maxheight - alien1.Height)
            {
                rr = alien1.Maxheight - alien1.Height;
            }
            else if (rr < alien1.Minheight - alien1.Height)
            {
                rr = alien1.Minheight - alien1.Height;
            }
            double height2 = alien1.Change(rr);
            alien1.HeightChangeVal += rr;
            alien1.HeightChangeCnt++;
            if (height2 > alien1.Maxheight)
            {
                height2 = alien1.Maxheight;
                double raz = alien1.Maxheight - alien1.Height;
                RR1.Content = rr;
                H1.Text = " " + height2;
            }
            else
            {
                RR1.Content = rr;
                H1.Text = " " + height2;
            }
        }

        private void BTChan2_Click(object sender, RoutedEventArgs e)
        {
            alien2.Height = Convert.ToDouble(H2.Text);
            int fr2 = Convert.ToInt32(from2.Text);
            int bf2 = Convert.ToInt32(before2.Text);
            Random rand = new Random();
            bf2 += 1;
            double rr2 = rand.Next(fr2, bf2);
            alien2.Maxheight = Convert.ToDouble(MaxH2.Text);
            alien2.Minheight = Convert.ToDouble(MinH2.Text);
            if (rr2 > alien2.Maxheight - alien2.Height)
            {
                rr2 = alien2.Maxheight - alien2.Height;
            }
            else if (rr2 < alien2.Minheight - alien2.Height)
            {
                rr2 = alien2.Minheight - alien2.Height;
            }
            double height3 = alien2.Change(rr2);
            alien2.HeightChangeVal += rr2;
            alien2.HeightChangeCnt++;
            if (height3 > alien2.Maxheight)
            {
                height3 = alien2.Maxheight;
                double raz2 = alien2.Maxheight - alien2.Height;
                RR2.Content = rr2;
                H2.Text = " " + height3;
            }    
            else
            {
                RR2.Content = rr2;
                H2.Text = " " + height3;
            }

        }

        private void Otclon1_Click(object sender, RoutedEventArgs e)
        {
            //SRO1.Content = alien1.Otclonenie() + Convert.ToDouble(RR1.Content);
            SRO1.Content = alien1.HeightChangeVal / alien1.HeightChangeCnt;
        }

        private void Otclon2_Click(object sender, RoutedEventArgs e)
        {
            //SRO2.Content = alien1.Otclonenie() + Convert.ToDouble (RR2.Content);
            SRO2.Content = alien2.HeightChangeVal / alien2.HeightChangeCnt;
        }
    }
}
