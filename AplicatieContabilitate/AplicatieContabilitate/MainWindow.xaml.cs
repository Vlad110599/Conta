using ContaDAL;
using ContaDAL.Models;
using ContaDAL.Services;
using AplicatieContabilitate.Puncte;
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
using log4net;
using System.IO;
using log4net.Config;

namespace AplicatieContabilitate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FileStream fs = new FileStream("../../log4netConfig.xml", FileMode.Open);
        private ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public MainWindow()
        {
            InitializeComponent();
            XmlConfigurator.Configure(fs);
            logger.Info("A inceput aplicatia!");
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            MasterContext masterContext = new MasterContext();
            var a = txtUsername.Text;
            var b = txtPassword.Password;
            if (a == masterContext.Utilizator.Find(1).Username && b == masterContext.Utilizator.Find(1).Password)
            {
                FrontWindow dashbord = new FrontWindow();
                dashbord.Show();
                this.Close();
                logger.Warn("Te-ai logat!");
            }
            else
            {
                Singleton s = Singleton.GetInstance;
                s.Message("Username or password is incorrect!");

                logger.Error("Username or password is incorrect!");
            }

        }
    }
}
