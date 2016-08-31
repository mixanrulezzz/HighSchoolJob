using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using PurchaseHistoryLibrary;

namespace PDFWork
{
    public static class PDF
    {
        public static void CreatePackingList(string file, PurchaseHistoryList Data)
        {
            var doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(file, FileMode.Create));
            doc.Open();



            doc.Close();
            writer.Close();
            return;
        }

        public static bool CreateCheck(string file, string date)
        {
            var doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(file, FileMode.Create));
            doc.Open();



            doc.Close();
            writer.Close();
            return true;
        }
    }
}
