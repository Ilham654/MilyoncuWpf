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

namespace MilyoncuWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        string yenisual = "Rusiya paytaxt haradir";
        string yenibtn = "Moscov";
        string yenibtn2 = "Baku";
        string yenibtn3 = "Monqolustan";
        string yenibtn4 = "Amerika";
        int dost = 0;
        int b = 1;
        int c = 1;
        bool d = true;
        bool f = false;
        bool g = true;
        int win = 0;
        int lose = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (b is 1)
            {
                if (Convert.ToBoolean(b))
                {
                    Zeng.Content = 0;
                    if (dost == 0)
                    {
                        MessageBox.Show("Salam Brat Baki sec mence duzdu");
                    }
                    else if (dost == 1)
                    {
                        MessageBox.Show("Salam Brat mence Moscova duzdu");
                    }
                    --b;
                }
            }
            else 
            {
                MessageBox.Show("Bir daha sinaya bilmersiniz");
            }
        }
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            Sual1.Content = yenisual;
            Btn1.Content = yenibtn;
            Btn2.Content = yenibtn2;
            Btn3.Content = yenibtn3;
            Btn4.Content = yenibtn4;
            ++dost;
            if (d == true)
            {
                MessageBox.Show("Cavab duz");
            }
            if (f)
            {
                if (Btn1.Content == "Moscov")
                {
                    MessageBox.Show("Cavab duzzz Oyun bitdi");
                }
            }
            if (win == 1)
            {
                MessageBox.Show("Tebrikler qazandin");
                this.Close();
            }
            f = true;
            g = false;
            ++win;
        }
        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show("Cavab Yanlis");
            if (g)
            {
                d = false;
                Btn1_Click(Btn1, e);
            }
            ++lose;
            if (lose == 2)
            {
                MessageBox.Show("You Loser");
                this.Close();
            }

        }
        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cavab Yanlis");
            if (g)
            {
                d = false;
                Btn1_Click(Btn1, e);
            }
            ++lose;
            if (lose == 2)
            {
                MessageBox.Show("You Loser");
                this.Close();
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cavab Yanlis");
            if (g)
            {
                d = false;
                Btn1_Click(Btn1, e);
            }
            ++lose;
            if (lose == 2)
            {
                MessageBox.Show("You Loser");
                this.Close();
            }
        }

        private void Btnn_Click(object sender, RoutedEventArgs e)
        {
            if (c is 1)
            {
                while (Convert.ToBoolean(c))
                {
                    Fivefive.Content = 0;
                    Btn2.Content = "";
                    Btn4.Content = "";
                    --c;
                }
            }
            else
            {
                MessageBox.Show("Bir daha sinaya bilmersiniz");
            }
        }
    }
}
