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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //public static void ThreadProc()

        //{
            
        //    Application.Run(new Form());

        //}

        private void passwordBox_TouchEnter(object sender, TouchEventArgs e)
        {
           
            
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string pass = passwordBox.Password.ToString();
                if (pass == "a") {
                    //MessageBox.Show("twoje hasło to " + pass, "Error Title", MessageBoxButton.OK); // to jest tylko okienko co finalnie ma podać Ci info o błędynym haśle
                    Window1 form2 = new Window1();
                    form2.Show();

                    //System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));

                    //t.Start();
                    //main_window.Close();

                }
                else
                MessageBox.Show("nope", "Error Title", MessageBoxButton.OK); // to jest tylko okienko co finalnie ma podać Ci info o błędynym haśle
            }
        }
    }
}
