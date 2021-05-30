using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AplicatieContabilitate
{
    class Singleton
    {
        private static Singleton instance = null;
        public static  Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        public void Message(string mesaj)
        {
            MessageBox.Show(mesaj);
        }
    }
}
