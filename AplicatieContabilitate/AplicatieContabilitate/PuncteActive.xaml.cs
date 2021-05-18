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
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
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

        }

        private void btnPunct3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPunct4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPunct5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPunct6_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
