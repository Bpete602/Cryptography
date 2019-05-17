using CryptoProject.Managers;
using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace CryptoProject
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == true)
            {
                try
                {
                    
                    var imgSrc = new BitmapImage(new Uri(ofd.FileName));
                    var bytes = ImageHelper.ImageSourceToBytes(new PngBitmapEncoder(), imgSrc);

                    var key = new byte[16] { 0x04, 0xA0, 0xF0, 0x00, 0x70, 0x00, 0x00, 0x00, 0x00, 0xB0, 0x00, 0x00, 0x08, 0x00, 0x1C, 0x00 };
                    var iv = new byte[16] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

                    CryptoHelper crypto = new CryptoHelper();

                    var encrypted = crypto.Encrypt(bytes, key, iv);
                    var decrypted = crypto.Decrypt(encrypted, key, iv);

                    ImgControl.Source = ImageHelper.LoadImage(decrypted); 
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid image file");
                }
            }
        }
    }
}
