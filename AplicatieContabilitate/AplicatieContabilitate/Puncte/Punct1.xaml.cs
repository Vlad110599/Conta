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
using System.Globalization;

namespace AplicatieContabilitate.Puncte
{
    /// <summary>
    /// Interaction logic for Punct1.xaml
    /// </summary>
    public partial class Punct1 : Window
    {
        public Punct1()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            PuncteActive dashbord = new PuncteActive();
            dashbord.Show();
            this.Close();
        }
        private void GridBarTitle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnAddVenit_Click(object sender, RoutedEventArgs e)
        {
            Singleton m = Singleton.GetInstance;
            ContaDAL.Models.Punct1 p = new ContaDAL.Models.Punct1();
            var v = Convert.ToDouble(txtVenit.Text);
            var c = Convert.ToDouble(txtCheltuieli.Text);
            DateTime d = Convert.ToDateTime(datePicker.Text);
            p.Venituri = v;
            p.Cheltuieli = c;
            p.Date = d.Date;

            Point1Services p1Services = new Point1Services();
            p1Services.AddPunct1(p);

            m.Message("Datele au fost adaugate cu succes!");
            txtVenit.Text = " ";
            txtCheltuieli.Text = " ";
        }
    }
}
