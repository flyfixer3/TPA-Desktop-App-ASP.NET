using MessagingToolkit.QRCode.Codec;
using Project_TPA_AN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Microsoft.Win32;
using System.Drawing.Imaging;

namespace Project_TPA_AN.Controller
{
    class TicketController
    {
        public static int getTransactionId()
        {
            TicketTransaction tct = DatabaseSingleton.GetInstance().TicketTransactions.ToArray().LastOrDefault();

            return tct.TicketTransactionID;
        }
        public static bool checkValidityTicket(string code)
        {
            if (DateTime.Now.ToString("yyyyMMdd").Equals(code))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static TicketTransaction SearchByID(int id)
        {
            return DatabaseSingleton.GetInstance().TicketTransactions.Where(x => x.TicketTransactionID == id).FirstOrDefault();
        }

        public static void insertRecordTicketTransaction(DateTime date, int qty)
        {
            TicketTransaction newTct = new TicketTransaction();
            newTct.TicketDate = date;
            newTct.Quantity = qty;
            newTct.TransactionStauts = "Active";

            DatabaseSingleton.GetInstance().TicketTransactions.Add(newTct);
            DatabaseSingleton.GetInstance().SaveChanges();
        }

        public static void updateQty(int qty, int id)
        {
            var rslt = DatabaseSingleton.GetInstance().TicketTransactions.Where(x => x.TicketTransactionID == id).FirstOrDefault();
            rslt.Quantity = qty;
            DatabaseSingleton.GetInstance().SaveChanges();
        }


        public static void deleteTransaction(int id)
        {
            var rslt = DatabaseSingleton.GetInstance().TicketTransactions.Where(x => x.TicketTransactionID == id).FirstOrDefault();
            rslt.TransactionStauts = "Deleted";
            DatabaseSingleton.GetInstance().SaveChanges();
        }

        //=========================================================================================
        //QR CODE GENERATOR
        //=========================================================================================

        static QRCodeEncoder encoder = new QRCodeEncoder();
        static Bitmap bitmap;
        static SaveFileDialog sfd = new SaveFileDialog();
        static string ticketId;

        public static void createQR()
        {
            encoder.QRCodeScale = 8;
            bitmap = encoder.Encode(ticketId);
        }

        public static void saveQR()
        {
            sfd.Filter = "PNG|*.png";
            sfd.FileName = ticketId;
            if (sfd.ShowDialog() == true)
            {
                if (bitmap != null)
                {
                    bitmap.Save(string.Concat(sfd.FileName), ImageFormat.Png);
                    insertTicket();
                }
            }
        }

        public static string generateTicketId()
        {
            Ticket tc = DatabaseSingleton.GetInstance().Tickets.ToArray().LastOrDefault();
            ticketId = tc.TicketID.Substring(8);
            string id = "" + (Int32.Parse(ticketId) + 1);
            string nol = "";
            if (id.Length == 1)
            {
                nol = "00";
            }
            else if (id.Length == 2)
            {
                nol = "0";
            }
            else if (id.Length == 3)
            {
                nol = "";
            }
            ticketId = DateTime.Now.ToString("yyyyMMdd") + nol + id;
            return ticketId;
        }

        public static void insertTicket()
        {
            Ticket newTc = new Ticket();
            newTc.TicketID = ticketId;

            DatabaseSingleton.GetInstance().Tickets.Add(newTc);
            DatabaseSingleton.GetInstance().SaveChanges();

        }

        public static void printTicket(TicketTransaction tct)
        {
            int qty = tct.Quantity;
            for (int i = 0; i < qty; i++)
            {
                ticketId = generateTicketId();
                createQR();
                saveQR();
            }
        }
    }
}
