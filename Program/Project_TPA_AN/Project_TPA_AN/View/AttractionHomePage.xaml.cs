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
    /// Interaction logic for AttractionHomePage.xaml
    /// </summary>
    public partial class AttractionHomePage : Page
    {
        public AttractionHomePage()
        {
            InitializeComponent();
            updateButton.IsEnabled = false;
            refreshTable();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            var reslt = TicketController.SearchByID(id);
            if(reslt != null)
            {
                QuantityText.Text = reslt.Quantity.ToString();
                updateButton.IsEnabled = true;
            }
            else
            {
                updateButton.IsEnabled = false;
            }
        }
        private void refreshTable()
        {
            var data = DatabaseSingleton.GetInstance().TicketTransactions.Where(x => x.TransactionStauts != "Deleted").ToList();
            TicketTransactionTable.ItemsSource = data;
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            TicketController.insertRecordTicketTransaction(DateTime.Now.Date,Int32.Parse(QuantityText.Text));
            refreshTable();
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            TicketController.updateQty(Int32.Parse(QuantityText.Text), Int32.Parse(idText.Text));
            refreshTable();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            TicketController.deleteTransaction(Int32.Parse(idText.Text));
            refreshTable();
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(idText.Text);
            TicketController.printTicket(TicketController.SearchByID(id));
        }

        QRCodeDecoder decoder = new QRCodeDecoder();
        OpenFileDialog openFile = new OpenFileDialog();
        private void Scan_Click(object sender, RoutedEventArgs e)
        {
            if(openFile.ShowDialog() == true)
            {
                imageQR.Source = new BitmapImage(new Uri(openFile.FileName));
                String code = decoder.Decode(new QRCodeBitmapImage(new System.Drawing.Bitmap(openFile.FileName)));
                code = code.Substring(0, 8);
                bool flag = TicketController.checkValidityTicket(code);
                if (flag == true)
                {
                    MessageBox.Show("Your Ticket Date : " + code.Substring(0, 4) + "-" + code.Substring(4, 2) + "-" + code.Substring(6, 2)+" ,Valid !");
                }
                else
                {
                    MessageBox.Show("Your Ticket Date : " + code.Substring(0, 4) + "-" + code.Substring(4, 2) + "-" + code.Substring(6, 2) + " ,invalid !");
                }
            }
        }


        private void Logout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
