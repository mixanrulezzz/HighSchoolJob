using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace PDFWork
{
    public static class PDF
    {
        public static bool CreatePackingList(string file, string date)
        {
            var doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(file, FileMode.Create));
            doc.Open();
            return true;
        }

        public static bool CreateCheck(string file, string date)
        {
            var doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(file, FileMode.Create));
            doc.Open();
            return true;
        }
    }
}
