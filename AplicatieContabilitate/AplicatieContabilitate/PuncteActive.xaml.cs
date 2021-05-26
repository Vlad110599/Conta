using System;
using AplicatieContabilitate.Puncte;
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
using System.Windows.Shapes;

namespace AplicatieContabilitate
{
    /// <summary>
    /// Interaction logic for PuncteActive.xaml
    /// </summary>
    public partial class PuncteActive : Window
    {
        public PuncteActive()
        {
            InitializeComponent();
            ContaDAL.MasterContext masterContext = new ContaDAL.MasterContext();
            var p1 = (from u in masterContext.Point1 where u.Id == 1 select u).FirstOrDefault();
            if (p1.Status == 1)
            {
                pct1Status.Text = "Status:Activ";
                pct1Status.Foreground =new SolidColorBrush(Colors.Green);
            }
            else
            {
                pct1Status.Text = "Status:Inactiv";
                pct1Status.Foreground = new SolidColorBrush(Colors.Red);
            }
            var p2 = (from u in masterContext.Point2 where u.Id == 1 select u).FirstOrDefault();
            if (p2.Status == 1)
            {
                pct2Status.Text = "Status:Activ";
                pct2Status.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                pct2Status.Text = "Status:Inactiv";
                pct2Status.Foreground = new SolidColorBrush(Colors.Red);
            }
            var p3 = (from u in masterContext.Point3 where u.Id == 1 select u).FirstOrDefault();
            if (p3.Status == 1)
            {
                pct3Status.Text = "Status:Activ";
                pct3Status.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                pct3Status.Text = "Status:Inactiv";
                pct3Status.Foreground = new SolidColorBrush(Colors.Red);
            }
            var p4 = (from u in masterContext.Point4 where u.Id == 1 select u).FirstOrDefault();
            if (p4.Status == 1)
            {
                pct4Status.Text = "Status:Activ";
                pct4Status.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                pct4Status.Text = "Status:Inactiv";
                pct4Status.Foreground = new SolidColorBrush(Colors.Red);
            }
            var p5 = (from u in masterContext.Point5 where u.Id == 1 select u).FirstOrDefault();
            if (p5.Status == 1)
            {
                pct5Status.Text = "Status:Activ";
                pct5Status.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                pct5Status.Text = "Status:Inactiv";
                pct5Status.Foreground = new SolidColorBrush(Colors.Red);
            }
            var p6 = (from u in masterContext.Point6 where u.Id == 1 select u).FirstOrDefault();
            if (p6.Status == 1)
            {
                pct6Status.Text = "Status:Activ";
                pct6Status.Foreground = new SolidColorBrush(Colors.Green);
            }
            else
            {
                pct6Status.Text = "Status:Inactiv";
                pct6Status.Foreground = new SolidColorBrush(Colors.Red);
            }

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            FrontWindow front = new FrontWindow();
            front.Show();
            this.Close();
        }

        private void GridBarTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnPunct1_Click(object sender, RoutedEventArgs e)
        {
           Punct1 dashbord = new Punct1();
            dashbord.Show();
            this.Close();
        }

        private void btnPunct2_Click(object sender, RoutedEventArgs e)
        {
            Punct2 dashbord = new Punct2();
            dashbord.Show();
            this.Close();
        }

        private void btnPunct3_Click(object sender, RoutedEventArgs e)
        {
            Punct3 dashbord = new Punct3();
            dashbord.Show();
            this.Close();
        }

        private void btnPunct4_Click(object sender, RoutedEventArgs e)
        {
            Punct4 dashbord = new Punct4();
            dashbord.Show();
            this.Close();
        }

        private void btnPunct5_Click(object sender, RoutedEventArgs e)
        {
            Punct5 dashbord = new Punct5();
            dashbord.Show();
            this.Close();
        }

        private void btnPunct6_Click(object sender, RoutedEventArgs e)
        {
            Punct6 dashbord = new Punct6();
            dashbord.Show();
            this.Close();
        }
    }
}
