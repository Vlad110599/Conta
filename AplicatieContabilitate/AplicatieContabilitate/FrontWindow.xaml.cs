using System;
using ContaDAL;
using ContaDAL.Models;
using ContaDAL.Services;
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
    /// Interaction logic for FrontWindow.xaml
    /// </summary>
    public partial class FrontWindow : Window
    {
        public FrontWindow()
        {
            InitializeComponent();
            MasterContext masterContext = new MasterContext();
            var p1 = (from u in masterContext.Point1 where u.Id == 1 select u).FirstOrDefault();
            var p2 = (from u in masterContext.Point2 where u.Id == 1 select u).FirstOrDefault();
            var p3 = (from u in masterContext.Point3 where u.Id == 1 select u).FirstOrDefault();
            var p4 = (from u in masterContext.Point4 where u.Id == 1 select u).FirstOrDefault();
            var p5 = (from u in masterContext.Point5 where u.Id == 1 select u).FirstOrDefault();
            var p6 = (from u in masterContext.Point6 where u.Id == 1 select u).FirstOrDefault();
            int nr;


            nr = p1.Status + p2.Status + p3.Status + p4.Status + p5.Status + p6.Status;


            NrPuncte.Text = Convert.ToString(nr);
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void GridBarTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnPctActive_Click(object sender, RoutedEventArgs e)
        {
            PuncteActive dashbord = new PuncteActive();
            dashbord.Show();
            this.Close();
        }

        private void btnCalcProfit_Click(object sender, RoutedEventArgs e)
        {
            CalculProfit calcdashbord = new CalculProfit();
            calcdashbord.Show();
        }

        private void btnCalcProfitTot_Click(object sender, RoutedEventArgs e)
        {
            CalcProfitTotal calctotdashbord = new CalcProfitTotal();
            calctotdashbord.Show();
        }

        private void btnViewIncasari_Click(object sender, RoutedEventArgs e)
        {
            ViewIncasari incdashbord = new ViewIncasari();
            incdashbord.Show();
        }

        private void btnViewCheltuieli_Click(object sender, RoutedEventArgs e)
        {
            ViewCheltuieli cheltuielidashbord = new ViewCheltuieli();
            cheltuielidashbord.Show();
        }

        private void btnStatus_Click(object sender, RoutedEventArgs e)
        {
            MasterContext masterContext = new MasterContext();
            if(ComboBox1.SelectedIndex==0)
            {
                var items = (from u in masterContext.Point1 where u.Id == 1 select u).FirstOrDefault();
                if(ComboBox2.SelectedIndex==0)
                {
                    items.Status = 1;
                }
                else
                {
                    items.Status = 0;
                }

                Point1Services p1 = new Point1Services();
                p1.Update(items);
            }
            else if (ComboBox1.SelectedIndex == 1)
            {
                var items = (from u in masterContext.Point2 where u.Id == 1 select u).FirstOrDefault();
                if (ComboBox2.SelectedIndex == 0)
                {
                    items.Status = 1;
                }
                else
                {
                    items.Status = 0;
                }

                Point2Services p2 = new Point2Services();
                p2.Update(items);
            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                var items = (from u in masterContext.Point3 where u.Id == 1 select u).FirstOrDefault();
                if (ComboBox2.SelectedIndex == 0)
                {
                    items.Status = 1;
                }
                else
                {
                    items.Status = 0;
                }

                Point3Services p3 = new Point3Services();
                p3.Update(items);
            }
            else if (ComboBox1.SelectedIndex == 3)
            {
                var items = (from u in masterContext.Point4 where u.Id == 1 select u).FirstOrDefault();
                if (ComboBox2.SelectedIndex == 0)
                {
                    items.Status = 1;
                }
                else
                {
                    items.Status = 0;
                }

                Point4Services p4 = new Point4Services();
                p4.Update(items);
            }
            else if (ComboBox1.SelectedIndex == 4)
            {
                var items = (from u in masterContext.Point5 where u.Id == 1 select u).FirstOrDefault();
                if (ComboBox2.SelectedIndex == 0)
                {
                    items.Status = 1;
                }
                else
                {
                    items.Status = 0;
                }

                Point5Services p5 = new Point5Services();
                p5.Update(items);
            }
            else if (ComboBox1.SelectedIndex == 5)
            {
                var items = (from u in masterContext.Point6 where u.Id == 1 select u).FirstOrDefault();
                if (ComboBox2.SelectedIndex == 0)
                {
                    items.Status = 1;
                }
                else
                {
                    items.Status = 0;
                }

                Point6Services p6 = new Point6Services();
                p6.Update(items);
            }
            var pct1 = (from u in masterContext.Point1 where u.Id == 1 select u).FirstOrDefault();
            var pct2 = (from u in masterContext.Point2 where u.Id == 1 select u).FirstOrDefault();
            var pct3 = (from u in masterContext.Point3 where u.Id == 1 select u).FirstOrDefault();
            var pct4 = (from u in masterContext.Point4 where u.Id == 1 select u).FirstOrDefault();
            var pct5 = (from u in masterContext.Point5 where u.Id == 1 select u).FirstOrDefault();
            var pct6 = (from u in masterContext.Point6 where u.Id == 1 select u).FirstOrDefault();
            int nr;


            nr = pct1.Status + pct2.Status + pct3.Status + pct4.Status + pct5.Status + pct6.Status;


            NrPuncte.Text = Convert.ToString(nr);
        }
    }
}
