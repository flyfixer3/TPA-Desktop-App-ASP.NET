using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using Microsoft.Win32;
using Project_TPA_AN.Controller;
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

namespace Project_TPA_AN.View
{
    /// <summary>
    /// Interaction logic for DiningRoomPage.xaml
    /// </summary>
    public partial class DiningRoomPage : Page
    {
        public DiningRoomPage()
        {
            InitializeComponent();
        }

        QRCodeDecoder decoder = new QRCodeDecoder();
        OpenFileDialog openFile = new OpenFileDialog();
        private void Scan_Click(object sender, RoutedEventArgs e)
        {
            if (openFile.ShowDialog() == true)
            {
                imageQR.Source = new BitmapImage(new Uri(openFile.FileName));
                String code = decoder.Decode(new QRCodeBitmapImage(new System.Drawing.Bitmap(openFile.FileName)));
                code = code.Substring(0, 8);
                bool flag = TicketController.checkValidityTicket(code);
                if (flag == true)
                {
                    MessageBox.Show("Your Ticket Date : " + code.Substring(0, 4) + "-" + code.Substring(4, 2) + "-" + code.Substring(6, 2) + " ,Valid !");
                }
                else
                {
                    MessageBox.Show("Your Ticket Date : " + code.Substring(0, 4) + "-" + code.Substring(4, 2) + "-" + code.Substring(6, 2) + " ,invalid !");
                }
            }
        }
    }
}
