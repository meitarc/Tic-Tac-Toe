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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string a = "X", b="O",c="";
        int a1=0, a2=0, a3=0, a4=0, a5=0, a6=0, a7=0, a8=0, a9=0, b1=0;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Check_C()
        {
            if (c == a)
            {
                c = b;
            }
            else
            {
                c = a;
            }
        }

        public void Check_X_Win()
        {
            if (bt1.Content == a && bt2.Content == a && bt3.Content == a||
                bt4.Content == a && bt5.Content == a && bt6.Content == a||
                bt7.Content == a && bt8.Content == a && bt9.Content == a||
                bt1.Content == a && bt4.Content == a && bt7.Content == a||
                bt2.Content == a && bt5.Content == a && bt8.Content == a||
                bt3.Content == a && bt6.Content == a && bt9.Content == a||
                bt1.Content == a && bt5.Content == a && bt9.Content == a||
                bt3.Content == a && bt5.Content == a && bt7.Content == a)
            {
                MessageBox.Show("X WIN");
                Clear();
               
            }
        }

        public void Check_O_Win()
        {
            if (bt1.Content == b && bt2.Content == b && bt3.Content == b ||
                bt4.Content == b && bt5.Content == b && bt6.Content == b ||
                bt7.Content == b && bt8.Content == b && bt9.Content == b ||
                bt1.Content == b && bt4.Content == b && bt7.Content == b ||
                bt2.Content == b && bt5.Content == b && bt8.Content == b ||
                bt3.Content == b && bt6.Content == b && bt9.Content == b ||
                bt1.Content == b && bt5.Content == b && bt9.Content == b ||
                bt3.Content == b && bt5.Content == b && bt7.Content == b)
            {
                MessageBox.Show("O WIN");
                Clear();
            }
        }

        public void Check_Tie()
        {
            if (b1 == 9)
            {
                MessageBox.Show("TIE");
                Clear();
            }
        }

        public void Clear()
        {
            a = "X";
            b = "O";
            c="";
            a1=0;
            a2=0;
            a3=0;
            a4=0;
            a5=0; 
            a6=0; 
            a7=0;
            a8=0;
            a9 = 0; 
            b1 = 0;
            bt1.Content = "";
            bt2.Content = "";
            bt3.Content = "";
            bt4.Content = "";
            bt5.Content = "";
            bt6.Content = "";
            bt7.Content = "";
            bt8.Content = "";
            bt9.Content = "";
        }


        private void Button_Click(object sender, RoutedEventArgs e) //button 1
        {
            if (a1 == 0)
            {
                Check_C();
                bt1.Content = c;
                b1++;
            }
            a1++;
            Check_X_Win();
            Check_O_Win();

            Check_Tie();
        }

    
        private void bt2_Click(object sender, RoutedEventArgs e)    //button 2
        {
            if (a2 == 0)
            {
                Check_C();
                bt2.Content = c; 
                b1++;
            }
            a2++;
            Check_X_Win();
            Check_O_Win();

            Check_Tie();
        }

        private void bt3_Click(object sender, RoutedEventArgs e)    //button 3
        {
            if (a3 == 0)
            {
                Check_C();
                bt3.Content = c;   
                b1++;
            }
            a3++;
            Check_X_Win();
            Check_O_Win();

            Check_Tie();
        }

        private void bt4_Click(object sender, RoutedEventArgs e)    //button 4
        {
            if (a4 == 0)
            {
                Check_C();
                bt4.Content = c;  
                b1++;
            }
            a4++;
            Check_X_Win();
            Check_O_Win();

            Check_Tie();
        }

        private void bt5_Click(object sender, RoutedEventArgs e)    //button 5
        {
            if (a5 == 0)
            {
                Check_C();
                bt5.Content = c;  
                b1++;
            }
            a5++;
            Check_X_Win();
            Check_O_Win();

            Check_Tie();
        }

        private void bt6_Click(object sender, RoutedEventArgs e)    //button 6
        {
            if (a6 == 0)
            {
                Check_C();
                bt6.Content = c;    
                b1++;
            }
            a6++;
            Check_X_Win();
            Check_O_Win();

            Check_Tie();
        }

        private void bt7_Click(object sender, RoutedEventArgs e)    //button 7
        {
            if (a7 == 0)
            {
                Check_C();
                bt7.Content = c;    
                b1++;
            }
            a7++;
            Check_X_Win();
            Check_O_Win();

            Check_Tie();
        }

        private void bt8_Click(object sender, RoutedEventArgs e)    //button 8
        {
            if (a8 == 0)
            {
                Check_C();
                bt8.Content = c;      
                b1++;
            }
            a8++;
            Check_X_Win();
            Check_O_Win();

            Check_Tie();
        }

        private void bt9_Click(object sender, RoutedEventArgs e)    //button 9
        {
            if (a9 == 0)
            {
                Check_C();
                bt9.Content = c;      
                b1++;
            }
            a9++;
            Check_X_Win();
            Check_O_Win();

            Check_Tie();
        }


    }
}
