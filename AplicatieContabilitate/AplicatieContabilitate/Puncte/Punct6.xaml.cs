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

namespace AplicatieContabilitate.Puncte
{
    /// <summary>
    /// Interaction logic for Punct6.xaml
    /// </summary>
    public partial class Punct6 : Window
    {
        public Punct6()
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
            ContaDAL.Models.Punct6 p = new ContaDAL.Models.Punct6();
            var v = Convert.ToDouble(txtVenit.Text);
            var c = Convert.ToDouble(txtCheltuieli.Text);
            DateTime d = Convert.ToDateTime(datePicker.Text);
            var dformat = d.ToString("yyyy/MM/dd");
            DateTime dt = Convert.ToDateTime(dformat);
            p.Venituri = v;
            p.Cheltuieli = c;
            p.Date = dt;

            Point6Services p6Services = new Point6Services();
            p6Services.AddPunct6(p);
            MessageBox.Show("Datele au fost adaugate cu succes!");
            txtVenit.Text = " ";
            txtCheltuieli.Text = " ";
        }
    }
}
