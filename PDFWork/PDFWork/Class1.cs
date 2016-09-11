using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using FormatDateLibrary;


namespace PDFWork
{
    public static class PDF
    {
        public static void CreatePackingList(string file, List<int> Data, List<int> Prices, List<string> ShipmentNames)
        {
            int sum = 0;

            var doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(file, FileMode.Create));

            string fg = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.TTF");
            BaseFont fgBaseFont = BaseFont.CreateFont(fg, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            Font Font = new Font(fgBaseFont, 12, Font.BOLD, BaseColor.BLACK);
            Font mainFont = new Font(fgBaseFont, 10, Font.NORMAL, BaseColor.BLACK);

            doc.Open();

            Paragraph p = new Paragraph();
            Phrase phr = new Phrase("Товарная накладная №____", Font);
            p.Alignment = 1;
            p.Add(phr);
            doc.Add(p);

            p = new Paragraph();
            phr = new Phrase(" ", Font);
            p.Alignment = 1;
            p.Add(phr);
            doc.Add(p);

            PdfPTable Table = new PdfPTable(7);

            PdfPCell cell = new PdfPCell(new Phrase("№", mainFont));
            cell.BorderWidth = 1;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Название товара", mainFont));
            cell.BorderWidth = 1;
            cell.Colspan = 3;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Количество", mainFont));
            cell.BorderWidth = 1;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Цена", mainFont));
            cell.BorderWidth = 1;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Стоимость", mainFont));
            cell.BorderWidth = 1;
            Table.AddCell(cell);

            for(int i = 0; i < Data.Count; i++)
            {
                cell = new PdfPCell(new Phrase((i+1).ToString(), mainFont));
                cell.BorderWidth = 1;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase(ShipmentNames[i], mainFont));
                cell.BorderWidth = 1;
                cell.Colspan = 3;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase(Data[i].ToString(), mainFont));
                cell.BorderWidth = 1;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase(Prices[i].ToString(), mainFont));
                cell.BorderWidth = 1;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase((Prices[i] * Data[i]).ToString(), mainFont));
                cell.BorderWidth = 1;
                Table.AddCell(cell);

                sum += Prices[i] * Data[i];
            }

            cell = new PdfPCell(new Phrase("Сумма:", mainFont));
            cell.BorderWidthBottom = 0;
            cell.BorderWidthLeft = 0;
            cell.Colspan = 6;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase(sum.ToString(), mainFont));
            cell.BorderWidth = 1;
            Table.AddCell(cell);

            doc.Add(Table);

            p = new Paragraph();
            phr = new Phrase(" ", Font);
            p.Alignment = 1;
            p.Add(phr);
            doc.Add(p);

            p = new Paragraph();
            phr = new Phrase("Подпись   _______________", Font);
            p.Alignment = 2;
            p.Add(phr);
            doc.Add(p);
            
            doc.Close();
            writer.Close();
            return;
        }

        public static void CreateCheck(string file, List<int> Data, List<int> Prices, List<string> ShipmentNames)
        {
            int sum = 0;

            var doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(file, FileMode.Create));

            string fg = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Fradm.TTF");
            BaseFont fgBaseFont = BaseFont.CreateFont(fg, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            Font Font = new Font(fgBaseFont, 12, Font.BOLD, BaseColor.BLACK);
            Font mainFont = new Font(fgBaseFont, 10, Font.NORMAL, BaseColor.BLACK);

            doc.Open();

            Paragraph p = new Paragraph();
            Phrase phr = new Phrase("Товарный чек", Font);
            p.Alignment = 1;
            p.Add(phr);
            doc.Add(p);

            p = new Paragraph();
            phr = new Phrase(" ", Font);
            p.Alignment = 1;
            p.Add(phr);
            doc.Add(p);

            PdfPTable Table = new PdfPTable(6);

            PdfPCell cell = new PdfPCell(new Phrase("№", mainFont));
            cell.BorderWidth = 0;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Название товара", mainFont));
            cell.BorderWidth = 0;
            cell.Colspan = 3;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Количество", mainFont));
            cell.BorderWidth = 0;
            Table.AddCell(cell);
            
            cell = new PdfPCell(new Phrase("Стоимость", mainFont));
            cell.BorderWidth = 0;
            Table.AddCell(cell);

            for (int i = 0; i < Data.Count; i++)
            {
                cell = new PdfPCell(new Phrase((i + 1).ToString(), mainFont));
                cell.BorderWidth = 0;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase(ShipmentNames[i], mainFont));
                cell.BorderWidth = 0;
                cell.Colspan = 3;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase(Data[i].ToString(), mainFont));
                cell.BorderWidth = 0;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase((Prices[i] * Data[i]).ToString(), mainFont));
                cell.BorderWidth = 0;
                Table.AddCell(cell);

                sum += Prices[i] * Data[i];
            }

            cell = new PdfPCell(new Phrase("Сумма:", mainFont));
            cell.BorderWidth = 0;            
            cell.Colspan = 5;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase(sum.ToString(), mainFont));
            cell.BorderWidth = 0;
            Table.AddCell(cell);

            doc.Add(Table);

            doc.Close();
            writer.Close();
        }

        public static void CreateClientReport(string file, List<string> Names, List<int> Counts, List<int> Costs)
        {
            var doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(file, FileMode.Create));

            string fg = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
            BaseFont fgBaseFont = BaseFont.CreateFont(fg, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            Font Font = new Font(fgBaseFont, 12, Font.BOLD, BaseColor.BLACK);
            Font mainFont = new Font(fgBaseFont, 10, Font.NORMAL, BaseColor.BLACK);

            doc.Open();

            Paragraph p = new Paragraph();
            Phrase phr = new Phrase("Отчет по клиентам за " + FormatDate.GetNowDate(), Font);
            p.Alignment = 1;
            p.Add(phr);
            doc.Add(p);

            p = new Paragraph();
            phr = new Phrase(" ", Font);
            p.Alignment = 1;
            p.Add(phr);
            doc.Add(p);

            PdfPTable Table = new PdfPTable(6);

            PdfPCell cell = new PdfPCell(new Phrase("№", mainFont));
            cell.BorderWidth = 1;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Ф.И. клиента", mainFont));
            cell.BorderWidth = 1;
            cell.Colspan = 3;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Суммарное количество купленного товара", mainFont));
            cell.BorderWidth = 1;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Сумма всех покупок", mainFont));
            cell.BorderWidth = 1;
            Table.AddCell(cell);

            for (int i = 0; i < Names.Count; i++)
            {
                cell = new PdfPCell(new Phrase((i + 1).ToString(), mainFont));
                cell.BorderWidth = 1;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase(Names[i], mainFont));
                cell.BorderWidth = 1;
                cell.Colspan = 3;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase(Counts[i].ToString(), mainFont));
                cell.BorderWidth = 1;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase(Costs[i].ToString(), mainFont));
                cell.BorderWidth = 1;
                Table.AddCell(cell);
            }

            doc.Add(Table);

            p = new Paragraph();
            phr = new Phrase(" ", Font);
            p.Alignment = 1;
            p.Add(phr);
            doc.Add(p);

            p = new Paragraph();
            phr = new Phrase("Подпись   _______________", Font);
            p.Alignment = 2;
            p.Add(phr);
            doc.Add(p);

            doc.Close();
            writer.Close();
        }

        public static void CreateShipmentReport(string file, List<string> Titles, List<int> Prices, List<int> Counts, List<int> Costs)
        {
            var doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(file, FileMode.Create));

            string fg = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
            BaseFont fgBaseFont = BaseFont.CreateFont(fg, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            Font Font = new Font(fgBaseFont, 12, Font.BOLD, BaseColor.BLACK);
            Font mainFont = new Font(fgBaseFont, 10, Font.NORMAL, BaseColor.BLACK);

            doc.Open();

            Paragraph p = new Paragraph();
            Phrase phr = new Phrase("Отчет по товарам за " + FormatDate.GetNowDate(), Font);
            p.Alignment = 1;
            p.Add(phr);
            doc.Add(p);

            p = new Paragraph();
            phr = new Phrase(" ", Font);
            p.Alignment = 1;
            p.Add(phr);
            doc.Add(p);

            PdfPTable Table = new PdfPTable(7);

            PdfPCell cell = new PdfPCell(new Phrase("№", mainFont));
            cell.BorderWidth = 1;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Название товара", mainFont));
            cell.BorderWidth = 1;
            cell.Colspan = 3;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Цена", mainFont));
            cell.BorderWidth = 1;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Количество купленного товара", mainFont));
            cell.BorderWidth = 1;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Сумма", mainFont));
            cell.BorderWidth = 1;
            Table.AddCell(cell);

            for (int i = 0; i < Titles.Count; i++)
            {
                cell = new PdfPCell(new Phrase((i + 1).ToString(), mainFont));
                cell.BorderWidth = 1;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase(Titles[i], mainFont));
                cell.BorderWidth = 1;
                cell.Colspan = 3;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase(Prices[i].ToString(), mainFont));
                cell.BorderWidth = 1;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase(Counts[i].ToString(), mainFont));
                cell.BorderWidth = 1;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase(Costs[i].ToString(), mainFont));
                cell.BorderWidth = 1;
                Table.AddCell(cell);
            }

            doc.Add(Table);

            p = new Paragraph();
            phr = new Phrase(" ", Font);
            p.Alignment = 1;
            p.Add(phr);
            doc.Add(p);

            p = new Paragraph();
            phr = new Phrase("Подпись   _______________", Font);
            p.Alignment = 2;
            p.Add(phr);
            doc.Add(p);

            doc.Close();
            writer.Close();
        }

        public static void CreatePurchaseHistoryReport(string file, List<string> Dates, List<int> Counts, List<int> Costs)
        {
            var doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(file, FileMode.Create));

            string fg = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Tahoma.TTF");
            BaseFont fgBaseFont = BaseFont.CreateFont(fg, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            Font Font = new Font(fgBaseFont, 12, Font.BOLD, BaseColor.BLACK);
            Font mainFont = new Font(fgBaseFont, 10, Font.NORMAL, BaseColor.BLACK);

            doc.Open();

            Paragraph p = new Paragraph();
            Phrase phr = new Phrase("Отчет по продажам за " + FormatDate.GetNowDate(), Font);
            p.Alignment = 1;
            p.Add(phr);
            doc.Add(p);

            p = new Paragraph();
            phr = new Phrase(" ", Font);
            p.Alignment = 1;
            p.Add(phr);
            doc.Add(p);

            PdfPTable Table = new PdfPTable(6);

            PdfPCell cell = new PdfPCell(new Phrase("№", mainFont));
            cell.BorderWidth = 1;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Дата продаж", mainFont));
            cell.BorderWidth = 1;
            cell.Colspan = 3;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Суммарное количество купленного товара", mainFont));
            cell.BorderWidth = 1;
            Table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Сумма всех покупок", mainFont));
            cell.BorderWidth = 1;
            Table.AddCell(cell);

            for (int i = 0; i < Dates.Count; i++)
            {
                cell = new PdfPCell(new Phrase((i + 1).ToString(), mainFont));
                cell.BorderWidth = 1;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase(Dates[i], mainFont));
                cell.BorderWidth = 1;
                cell.Colspan = 3;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase(Counts[i].ToString(), mainFont));
                cell.BorderWidth = 1;
                Table.AddCell(cell);

                cell = new PdfPCell(new Phrase(Costs[i].ToString(), mainFont));
                cell.BorderWidth = 1;
                Table.AddCell(cell);
            }

            doc.Add(Table);

            p = new Paragraph();
            phr = new Phrase(" ", Font);
            p.Alignment = 1;
            p.Add(phr);
            doc.Add(p);

            p = new Paragraph();
            phr = new Phrase("Подпись   _______________", Font);
            p.Alignment = 2;
            p.Add(phr);
            doc.Add(p);

            doc.Close();
            writer.Close();
        }
    }
}
