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
    /// Interaction logic for CalculProfit.xaml
    /// </summary>
    public partial class CalculProfit : Window
    {
        public CalculProfit()
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
            if(ComboBox1.SelectedIndex == 0)
            {
                
                DateTime d = Convert.ToDateTime(datePicker.Text);
                var items = (from u in masterContext.Point1 where u.Date == d select u).FirstOrDefault();
                if (items == null)
                {
                    MessageBox.Show("Nu exista informatii pentru data selectata!");
                }
                else
                {
                    txtVenit.Text = Convert.ToString(items.Venituri);
                    txtCheltuieli.Text = Convert.ToString(items.Cheltuieli);
                }
            }
            else if(ComboBox1.SelectedIndex == 1)
            {
                
                DateTime d = Convert.ToDateTime(datePicker.Text);
                var items = (from u in masterContext.Point2 where u.Date == d select u).FirstOrDefault();
                if (items == null)
                {
                    MessageBox.Show("Nu exista informatii pentru data selectata!");
                }
                else
                {
                    txtVenit.Text = Convert.ToString(items.Venituri);
                    txtCheltuieli.Text = Convert.ToString(items.Cheltuieli);
                }
            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                DateTime d = Convert.ToDateTime(datePicker.Text);
                var items = (from u in masterContext.Point3 where u.Date == d select u).FirstOrDefault();
                if (items == null)
                {
                    MessageBox.Show("Nu exista informatii pentru data selectata!");
                }
                else
                {
                    txtVenit.Text = Convert.ToString(items.Venituri);
                    txtCheltuieli.Text = Convert.ToString(items.Cheltuieli);
                }
            }
            else if (ComboBox1.SelectedIndex == 3)
            {
                DateTime d = Convert.ToDateTime(datePicker.Text);
                var items = (from u in masterContext.Point4 where u.Date == d select u).FirstOrDefault();
                if (items == null)
                {
                    MessageBox.Show("Nu exista informatii pentru data selectata!");
                }
                else
                {
                    txtVenit.Text = Convert.ToString(items.Venituri);
                    txtCheltuieli.Text = Convert.ToString(items.Cheltuieli);
                }
            }
            else if (ComboBox1.SelectedIndex == 4)
            {
                DateTime d = Convert.ToDateTime(datePicker.Text);
                var items = (from u in masterContext.Point5 where u.Date == d select u).FirstOrDefault();
                if (items == null)
                {
                    MessageBox.Show("Nu exista informatii pentru data selectata!");
                }
                else
                {
                    txtVenit.Text = Convert.ToString(items.Venituri);
                    txtCheltuieli.Text = Convert.ToString(items.Cheltuieli);
                }
            }
            else if (ComboBox1.SelectedIndex == 5)
            {
                DateTime d = Convert.ToDateTime(datePicker.Text);
                var items = (from u in masterContext.Point6 where u.Date == d select u).FirstOrDefault();
                if (items == null)
                {
                    MessageBox.Show("Nu exista informatii pentru data selectata!");
                }
                else
                {
                    txtVenit.Text = Convert.ToString(items.Venituri);
                    txtCheltuieli.Text = Convert.ToString(items.Cheltuieli);
                }
            }
        }

        private void btnCalcProfit_Click(object sender, RoutedEventArgs e)
        {
            MasterContext masterContext = new MasterContext();
            if (ComboBox1.SelectedIndex == 0)
            {
                if (datePicker.Text == "Select a date")
                {
                    MessageBox.Show("Nu ati selectat o data!");
                }
                else
                {
                    DateTime d = Convert.ToDateTime(datePicker.Text);
                    var items = (from u in masterContext.Point1 where u.Date == d select u).FirstOrDefault();

                    items.Profit = Convert.ToDouble(txtVenit.Text) - Convert.ToDouble(txtCheltuieli.Text);
                    Point1Services p1Services = new Point1Services();
                    p1Services.Update(items);
                    txtProfit.Text = items.Profit.ToString();
                }
            }
            else if (ComboBox1.SelectedIndex == 1)
            {
                if (datePicker.Text != "Select a date")
                {
                    DateTime d = Convert.ToDateTime(datePicker.Text);
                    var items = (from u in masterContext.Point2 where u.Date == d select u).FirstOrDefault();
                
                    items.Profit = Convert.ToDouble(txtVenit.Text) - Convert.ToDouble(txtCheltuieli.Text);
                    Point2Services p2Services = new Point2Services();
                    p2Services.Update(items);
                    txtProfit.Text = items.Profit.ToString();
                }
                else
                {
                    MessageBox.Show("Nu ati selectat o data!");
                }
            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                if (datePicker.Text != "Select a date")
                {
                    DateTime d = Convert.ToDateTime(datePicker.Text);
                    var items = (from u in masterContext.Point3 where u.Date == d select u).FirstOrDefault();

                    items.Profit = Convert.ToDouble(txtVenit.Text) - Convert.ToDouble(txtCheltuieli.Text);
                    Point3Services p3Services = new Point3Services();
                    p3Services.Update(items);
                    txtProfit.Text = items.Profit.ToString();
                }
                else
                {
                    MessageBox.Show("Nu ati selectat o data!");
                }
            }
            else if (ComboBox1.SelectedIndex == 3)
            {
                if (datePicker.DataContext != null)
                {
                    DateTime d = Convert.ToDateTime(datePicker.Text);
                    var items = (from u in masterContext.Point4 where u.Date == d select u).FirstOrDefault();

                    items.Profit = Convert.ToDouble(txtVenit.Text) - Convert.ToDouble(txtCheltuieli.Text);
                    Point4Services p4Services = new Point4Services();
                    p4Services.Update(items);
                    txtProfit.Text = items.Profit.ToString();
                }
                else
                {
                    MessageBox.Show("Nu ati selectat o data!");
                }
            }
            else if (ComboBox1.SelectedIndex == 4)
            {
                if (datePicker.DataContext != null)
                {
                    DateTime d = Convert.ToDateTime(datePicker.Text);
                    var items = (from u in masterContext.Point5 where u.Date == d select u).FirstOrDefault();

                    items.Profit = Convert.ToDouble(txtVenit.Text) - Convert.ToDouble(txtCheltuieli.Text);
                    Point5Services p5Services = new Point5Services();
                    p5Services.Update(items);
                    txtProfit.Text = items.Profit.ToString();
                }
                else
                {
                    MessageBox.Show("Nu ati selectat o data!");
                }
            }
            else if (ComboBox1.SelectedIndex == 5)
            {
                if (datePicker.DataContext != null)
                {
                    DateTime d = Convert.ToDateTime(datePicker.Text);
                    var items = (from u in masterContext.Point6 where u.Date == d select u).FirstOrDefault();

                    items.Profit = Convert.ToDouble(txtVenit.Text) - Convert.ToDouble(txtCheltuieli.Text);
                    Point6Services p6Services = new Point6Services();
                    p6Services.Update(items);
                    txtProfit.Text = items.Profit.ToString();
                }
                else
                {
                    MessageBox.Show("Nu ati selectat o data!");
                }
            }
            else
            {
                MessageBox.Show("Nu ati selectat un punct!");
            }

        }
    }
}
