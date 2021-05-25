using System;
using ContaDAL;
using ContaDAL.Models;
using ContaDAL.Services;
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
    /// Interaction logic for CalcProfitTotal.xaml
    /// </summary>
    public partial class CalcProfitTotal : Window
    {
        public CalcProfitTotal()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void GridBarTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MasterContext masterContext = new MasterContext();

            if (ComboBox1.SelectedIndex == 0)
            {
                txtVenit.Text = "";
                txtCheltuieli.Text = "";
                txtProfit.Text = "";
                var item = masterContext.Point1.ToList();
                lvPoints.ItemsSource = item;

            }
            else if (ComboBox1.SelectedIndex == 1)
            {
                txtVenit.Text = "";
                txtCheltuieli.Text = "";
                txtProfit.Text = "";
                var item = masterContext.Point2.ToList();
                lvPoints.ItemsSource = item;

            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                txtVenit.Text = "";
                txtCheltuieli.Text = "";
                txtProfit.Text = "";
                var item = masterContext.Point3.ToList();
                lvPoints.ItemsSource = item;

            }
            else if (ComboBox1.SelectedIndex == 3)
            {
                txtVenit.Text = "";
                txtCheltuieli.Text = "";
                txtProfit.Text = "";
                var item = masterContext.Point4.ToList();
                lvPoints.ItemsSource = item;

            }
            else if (ComboBox1.SelectedIndex == 4)
            {
                txtVenit.Text = "";
                txtCheltuieli.Text = "";
                txtProfit.Text = "";
                var item = masterContext.Point5.ToList();
                lvPoints.ItemsSource = item;

            }
            else if (ComboBox1.SelectedIndex == 5)
            {
                txtVenit.Text = "";
                txtCheltuieli.Text = "";
                txtProfit.Text = "";
                var item = masterContext.Point6.ToList();
                lvPoints.ItemsSource = item;

            }
        }
        private void datePicker_DateChanged(object sender, SelectionChangedEventArgs e)
        {
            MasterContext masterContext = new MasterContext();
            if (ComboBox1.SelectedIndex == 0)
            {

                DateTime d = Convert.ToDateTime(datePicker.Text);
                var item= (from u in masterContext.Point1 where u.Date.Month == d.Month select u).ToArray();
                var tet = (from u in item select u).FirstOrDefault();
                if (tet == null)
                {
                    MessageBox.Show("Nu exista informatii pentru luna selectata!");
                }
                else
                {
                    lvPoints.ItemsSource = item;
                    double v = 0;
                    double c = 0;
                    double p = 0;
                    for (int i = tet.Id ; i<= item.Last().Id ; i++ )
                    {
                        var items = (from u in item where u.Id == i select u).FirstOrDefault();
                        v = v + items.Venituri;
                        c = c + items.Cheltuieli;
                        p = p + items.Profit;
                    }
                    txtVenit.Text = Convert.ToString(v);
                    txtCheltuieli.Text = Convert.ToString(c);
                    txtProfit.Text = Convert.ToString(p);
                }
            }
            else if (ComboBox1.SelectedIndex == 1)
            {

                DateTime d = Convert.ToDateTime(datePicker.Text);
                var item = (from u in masterContext.Point2 where u.Date.Month == d.Month select u).ToArray();
                var tet = (from u in item select u).FirstOrDefault();
                if (tet == null)
                {
                    MessageBox.Show("Nu exista informatii pentru luna selectata!");
                }
                else
                {
                    lvPoints.ItemsSource = item;
                    double v = 0;
                    double c = 0;
                    double p = 0;
                    for (int i = tet.Id; i <= item.Last().Id; i++)
                    {
                        var items = (from u in item where u.Id == i select u).FirstOrDefault();
                        v = v + items.Venituri;
                        c = c + items.Cheltuieli;
                        p = p + items.Profit;
                    }
                    txtVenit.Text = Convert.ToString(v);
                    txtCheltuieli.Text = Convert.ToString(c);
                    txtProfit.Text = Convert.ToString(p);
                }
            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                DateTime d = Convert.ToDateTime(datePicker.Text);
                var item = (from u in masterContext.Point3 where u.Date.Month == d.Month select u).ToArray();
                var tet = (from u in item select u).FirstOrDefault();
                if (tet == null)
                {
                    MessageBox.Show("Nu exista informatii pentru luna selectata!");
                }
                else
                {
                    lvPoints.ItemsSource = item;
                    double v = 0;
                    double c = 0;
                    double p = 0;
                    for (int i = tet.Id; i <= item.Last().Id; i++)
                    {
                        var items = (from u in item where u.Id == i select u).FirstOrDefault();
                        v = v + items.Venituri;
                        c = c + items.Cheltuieli;
                        p = p + items.Profit;
                    }
                    txtVenit.Text = Convert.ToString(v);
                    txtCheltuieli.Text = Convert.ToString(c);
                    txtProfit.Text = Convert.ToString(p);
                }
            }
            else if (ComboBox1.SelectedIndex == 3)
            {
                DateTime d = Convert.ToDateTime(datePicker.Text);
                var item = (from u in masterContext.Point4 where u.Date.Month == d.Month select u).ToArray();
                var tet = (from u in item select u).FirstOrDefault();
                if (tet == null)
                {
                    MessageBox.Show("Nu exista informatii pentru luna selectata!");
                }
                else
                {
                    lvPoints.ItemsSource = item;
                    double v = 0;
                    double c = 0;
                    double p = 0;
                    for (int i = tet.Id; i <= item.Last().Id; i++)
                    {
                        var items = (from u in item where u.Id == i select u).FirstOrDefault();
                        v = v + items.Venituri;
                        c = c + items.Cheltuieli;
                        p = p + items.Profit;
                    }
                    txtVenit.Text = Convert.ToString(v);
                    txtCheltuieli.Text = Convert.ToString(c);
                    txtProfit.Text = Convert.ToString(p);
                }
            }
            else if (ComboBox1.SelectedIndex == 4)
            {
                DateTime d = Convert.ToDateTime(datePicker.Text);
                var item = (from u in masterContext.Point5 where u.Date.Month == d.Month select u).ToArray();
                var tet = (from u in item select u).FirstOrDefault();
                if (tet == null)
                {
                    MessageBox.Show("Nu exista informatii pentru luna selectata!");
                }
                else
                {
                    lvPoints.ItemsSource = item;
                    double v = 0;
                    double c = 0;
                    double p = 0;
                    for (int i = tet.Id; i <= item.Last().Id; i++)
                    {
                        var items = (from u in item where u.Id == i select u).FirstOrDefault();
                        v = v + items.Venituri;
                        c = c + items.Cheltuieli;
                        p = p + items.Profit;
                    }
                    txtVenit.Text = Convert.ToString(v);
                    txtCheltuieli.Text = Convert.ToString(c);
                    txtProfit.Text = Convert.ToString(p);
                }
            }
            else if (ComboBox1.SelectedIndex == 5)
            {
                DateTime d = Convert.ToDateTime(datePicker.Text);
                var item = (from u in masterContext.Point6 where u.Date.Month == d.Month select u).ToArray();
                var tet = (from u in item select u).FirstOrDefault();
                if (tet == null)
                {
                    MessageBox.Show("Nu exista informatii pentru luna selectata!");
                }
                else
                {
                    lvPoints.ItemsSource = item;
                    double v = 0;
                    double c = 0;
                    double p = 0;
                    for (int i = tet.Id; i <= item.Last().Id; i++)
                    {
                        var items = (from u in item where u.Id == i select u).FirstOrDefault();
                        v = v + items.Venituri;
                        c = c + items.Cheltuieli;
                        p = p + items.Profit;
                    }
                    txtVenit.Text = Convert.ToString(v);
                    txtCheltuieli.Text = Convert.ToString(c);
                    txtProfit.Text = Convert.ToString(p);

                }
            }
        }
    }
}
