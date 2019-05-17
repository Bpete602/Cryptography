using CryptoProject.Managers;
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

namespace CryptoProject
{
    /// <summary>
    /// Interaction logic for CryptoKeyManagerView.xaml
    /// </summary>
    public partial class CryptoKeyManagerView : UserControl
    {
        public CryptoKeyManagerView()
        {
            InitializeComponent();
            DataContext = CryptoKeyManager.Instance;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CryptoKeyManager.Instance.CreateKey();
        }
    }
}
