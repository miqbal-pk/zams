using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZAMS.uc;

namespace ZAMS
{
    class ITextEvents : PdfPageEventHelper
    {
        ReportHome reportObj = new ReportHome();

        // This is the contentbyte object of the writer
        PdfContentByte cb;

        // we will put the final number of pages in a template
        PdfTemplate headerTemplate, footerTemplate;

        // this is the BaseFont we are going to use for the header / footer
        BaseFont bf = null;

        // This keeps track of the creation time
        DateTime PrintTime = DateTime.Now;


        #region Fields
        private string _header;
        #endregion

        #region Properties
        public string Header
        {
            get { return _header; }
            set { _header = value; }
        }
        #endregion


        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            try
            {
                PrintTime = DateTime.Now;
                bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                cb = writer.DirectContent;
                headerTemplate = cb.CreateTemplate(50, 50);
                footerTemplate = cb.CreateTemplate(50, 50);
            }
            catch (DocumentException de)
            {

            }
            catch (System.IO.IOException ioe)
            {

            }
        }

        public override void OnEndPage(iTextSharp.text.pdf.PdfWriter writer, iTextSharp.text.Document document)
        {
            base.OnEndPage(writer, document);

            iTextSharp.text.Font baseFontNormal = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK);

            iTextSharp.text.Font baseFontBig = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);

            //Phrase p1Header = new Phrase("Educational Services (PVT) Limited", baseFontNormal);
            Phrase p1Header = new Phrase(ReportHome.mainHeadingForReports, baseFontNormal);
            Phrase p2Header, p3Header,p4Header;

          
            p2Header = new Phrase(SearchTransactions.dateRange, baseFontNormal);
            p3Header = new Phrase(SearchTransactions.projectNameForReport, baseFontNormal);
           // p4Header = new Phrase(ReportHome.projectHeading, baseFontNormal);

            

            //Create PdfTable object
            PdfPTable pdfTab = new PdfPTable(3);

            //We will have to create separate cells to include image logo and 2 separate strings
            //Row 1
            

            PdfPCell pdfCell1 = new PdfPCell(p1Header);
            PdfPCell pdfCell2 = null, pdfCell3 = null, pdfCell40 = null;
            if (BaseControl.status == 1)
            {
                pdfCell2 = new PdfPCell(p2Header);
                pdfCell3 = new PdfPCell(p3Header);
                //pdfCell40= new PdfPCell(p4Header);
            }
            else
            {
               // pdfCell40 = new PdfPCell(p4Header);
                pdfCell2 = new PdfPCell();
                pdfCell3 = new PdfPCell();
            }
            String text = "Page " + writer.PageNumber + " of ";


            ////Add paging to header
            //{
            //    cb.BeginText();
            //    cb.SetFontAndSize(bf, 12);
            //    cb.SetTextMatrix(document.PageSize.GetRight(200), document.PageSize.GetTop(45));
            //    cb.ShowText(text);
            //    cb.EndText();
            //    float len = bf.GetWidthPoint(text, 12);
            //    //Adds "12" in Page 1 of 12
            //    cb.AddTemplate(headerTemplate, document.PageSize.GetRight(200) + len, document.PageSize.GetTop(45));
            //}
            //Add paging to footer
            {
                cb.BeginText();
                cb.SetFontAndSize(bf, 12);
                cb.SetTextMatrix(document.PageSize.GetRight(90), document.PageSize.GetBottom(15));
                cb.ShowText(text);

                cb.SetTextMatrix(document.PageSize.GetLeft(25), document.PageSize.GetBottom(15));
                
                if (ReportHome.mango.Equals("All Projects All Parties"))
                {
                    cb.ShowText("Prepared By: ________________                                                   Approved By: __________________");
                }
                else
                cb.ShowText("Prepared By: ________________         Approved By: __________________            Received By: ___________________");


                cb.EndText();
                float len = bf.GetWidthPoint(text, 12);
                cb.AddTemplate(footerTemplate, document.PageSize.GetRight(90) + len, document.PageSize.GetBottom(15));
            }
            //Row 2
            PdfPCell pdfCell4 = new PdfPCell(new Phrase("", baseFontNormal));
            //Row 3


            PdfPCell pdfCell5 = new PdfPCell(new Phrase("Date:" + PrintTime.ToShortDateString(), baseFontBig));
            PdfPCell pdfCell6 = new PdfPCell();
            PdfPCell pdfCell7 = new PdfPCell(new Phrase("TIME:" + string.Format("{0:t}", DateTime.Now), baseFontBig));


            //set the alignment of all three cells and set border to 0
            pdfCell1.HorizontalAlignment = Element.ALIGN_CENTER;
           // pdfCell40.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell2.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell3.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell4.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell5.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell6.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfCell7.HorizontalAlignment = Element.ALIGN_CENTER;


            pdfCell2.VerticalAlignment = Element.ALIGN_BOTTOM;
            pdfCell3.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell4.VerticalAlignment = Element.ALIGN_TOP;
            pdfCell5.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell6.VerticalAlignment = Element.ALIGN_MIDDLE;
            pdfCell7.VerticalAlignment = Element.ALIGN_MIDDLE;


            pdfCell4.Colspan = 3;



            pdfCell1.Border = 0;
            pdfCell2.Border = 0;
            pdfCell3.Border = 0;
           // pdfCell40.Border = 0;
            pdfCell4.Border = 0;
            pdfCell5.Border = 0;
            pdfCell6.Border = 0;
            pdfCell7.Border = 0;

            pdfCell1.Colspan = 3;
            pdfCell2.Colspan = 3;
            pdfCell3.Colspan = 3;
           // pdfCell40.Colspan = 3;
            


            //add all three cells into PdfTable
            pdfTab.AddCell(pdfCell1);
            //pdfTab.AddCell(pdfCell40);
            pdfTab.AddCell(pdfCell2);
            pdfTab.AddCell(pdfCell3);
            pdfTab.AddCell(pdfCell4);
            pdfTab.AddCell(pdfCell5);
            pdfTab.AddCell(pdfCell6);
            pdfTab.AddCell(pdfCell7);

            pdfTab.TotalWidth = document.PageSize.Width - 80f;
            pdfTab.WidthPercentage = 70;
            //pdfTab.HorizontalAlignment = Element.ALIGN_CENTER;


            //call WriteSelectedRows of PdfTable. This writes rows from PdfWriter in PdfTable
            //first param is start row. -1 indicates there is no end row and all the rows to be included to write
            //Third and fourth param is x and y position to start writing
            pdfTab.WriteSelectedRows(0, -1, 40, document.PageSize.Height - 30, writer.DirectContent);
            //set pdfContent value

            //Move the pointer and draw line to separate header section from rest of page
            //cb.MoveTo(40, document.PageSize.Height - 100);
            //cb.LineTo(document.PageSize.Width - 40, document.PageSize.Height - 100);
            //cb.Stroke();

            //Move the pointer and draw line to separate footer section from rest of page
            //cb.MoveTo(40, document.PageSize.GetBottom(50));
            //cb.LineTo(document.PageSize.Width - 40, document.PageSize.GetBottom(50));
            //cb.Stroke();
        }

        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            base.OnCloseDocument(writer, document);

            headerTemplate.BeginText();
            headerTemplate.SetFontAndSize(bf, 12);
            headerTemplate.SetTextMatrix(0, 0);
            headerTemplate.ShowText((writer.PageNumber - 1).ToString());
            headerTemplate.EndText();

            footerTemplate.BeginText();
            footerTemplate.SetFontAndSize(bf, 12);
            footerTemplate.SetTextMatrix(0, 0);
            footerTemplate.ShowText((writer.PageNumber - 1).ToString());
            footerTemplate.EndText();
        }


        public override void OnStartPage(PdfWriter writer, Document document)
        {

            if (Bank_an_PettyCash_Reports.Bank_Paty.Equals("Bank"))
            {
                Bank(writer,  document);
            }
            else if (Bank_an_PettyCash_Reports.Bank_Paty.Equals("Patty"))
            {
                Patty(writer, document);
            }
            else
            {



                if (ReportHome.mango.Equals("All Projects All Vendors"))
                {
                    AllProjects(writer, document);
                }
                else
                {
                    // MessageBox.Show("In Page Created");
                    string heading = "Zikria Construction Company";
                    PdfPTable objTable = null;
                    PdfPCell cell = null;
                    iTextSharp.text.Font fontGeneralText = null;

                    
                    
                    objTable = new PdfPTable(16);



                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ITALIC, 14, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY);
                    cell = new PdfPCell(new Phrase("" + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + heading + Environment.NewLine + Environment.NewLine, fontGeneralText));
                    cell.Colspan = 16;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);


                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("Date", fontGeneralText));
                    cell.Colspan = 1;
                    cell.Border = 1;
                    cell.BorderWidthTop = 1;
                    cell.BorderWidthLeft = 1;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 1;
                    cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("Ref. ID", fontGeneralText));
                    cell.Colspan = 1;
                    cell.Border = 1;
                    cell.BorderWidthTop = 1;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 1;
                    cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);



                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("Party Or Project", fontGeneralText));
                    cell.Colspan = 2;
                    cell.Border = 1;
                    cell.BorderWidthTop = 1;
                    cell.BorderWidthLeft = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 1;
                    cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);




                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("Cheque No.", fontGeneralText));
                    cell.Colspan = 2;
                    cell.Border = 1;
                    cell.BorderWidthTop = 1;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 1;
                    cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("Narration", fontGeneralText));
                    cell.Colspan = 3;
                    cell.Border = 1;
                    cell.BorderWidthTop = 1;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 1;
                    cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("Debit", fontGeneralText));
                    cell.Colspan = 2;
                    cell.Border = 1;
                    cell.BorderWidthTop = 1;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 1;
                    cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("Credit", fontGeneralText));
                    cell.Colspan = 2;
                    cell.Border = 1;
                    cell.BorderWidthTop = 1;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 1;
                    cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("Balance", fontGeneralText));
                    cell.Colspan = 2;
                    cell.Border = 1;
                    cell.BorderWidthTop = 1;
                    cell.BorderWidthRight = 1;
                    cell.BorderWidthBottom = 1;
                    cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);



                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("User Name", fontGeneralText));
                    cell.Colspan = 1;
                    cell.Border = 1;
                    cell.BorderWidthTop = 1;
                    cell.BorderWidthRight = 1;
                    cell.BorderWidthBottom = 1;
                    cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);




                    document.Add(objTable);
                }
            }
        }





        public void AllProjects(PdfWriter writer, Document document)
        {
            string heading = "Zikria Construction Company";
            PdfPTable objTable = null;
            PdfPCell cell = null;
            iTextSharp.text.Font fontGeneralText = null;

            objTable = new PdfPTable(16);



            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("" + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + heading + Environment.NewLine + Environment.NewLine, fontGeneralText));
            cell.Colspan = 16;
            cell.Border = 0;
            cell.BorderWidthRight = 0;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);


            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Date", fontGeneralText));
            cell.Colspan = 1;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthLeft = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);

            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Ref. ID", fontGeneralText));
            cell.Colspan = 1;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);


            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Party Name", fontGeneralText));
            cell.Colspan = 2;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthLeft = 0;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);



            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Project Name", fontGeneralText));
            cell.Colspan = 2;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthLeft = 0;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);


            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Cheque No.", fontGeneralText));
            cell.Colspan = 2;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);

            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Narration", fontGeneralText));
            cell.Colspan = 3;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);

            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Debit", fontGeneralText));
            cell.Colspan = 2;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);

            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Credit", fontGeneralText));
            cell.Colspan = 2;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 1;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);



            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("UserName", fontGeneralText));
            cell.Colspan = 1;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 1;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);


            document.Add(objTable);
        }










        public void Bank(PdfWriter writer, Document document)
        {


            // MessageBox.Show("In Page Created");
            string heading = "Zikria Construction Company";
            PdfPTable objTable = null;
            PdfPCell cell = null;
            iTextSharp.text.Font fontGeneralText = null;

            objTable = new PdfPTable(16);



            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ITALIC, 14, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY);
            cell = new PdfPCell(new Phrase("" + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + heading + Environment.NewLine + Environment.NewLine, fontGeneralText));
            cell.Colspan = 16;
            cell.Border = 0;
            cell.BorderWidthRight = 0;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);


            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Date", fontGeneralText));
            cell.Colspan = 1;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthLeft = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);

            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("ID", fontGeneralText));
            cell.Colspan = 1;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);




            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Ref. ID", fontGeneralText));
            cell.Colspan = 1;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);



            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Cheque No.", fontGeneralText));
            cell.Colspan = 1;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthLeft = 0;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);




            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Description", fontGeneralText));
            cell.Colspan = 2;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);

            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Bank Name", fontGeneralText));
            cell.Colspan = 1;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);

            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Account No.", fontGeneralText));
            cell.Colspan = 2;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);


            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Debit", fontGeneralText));
            cell.Colspan = 2;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);

            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Credit", fontGeneralText));
            cell.Colspan = 2;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);

            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Balance", fontGeneralText));
            cell.Colspan = 2;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 1;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);





            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("UserName", fontGeneralText));
            cell.Colspan = 1;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 1;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);



            document.Add(objTable);


        }









        public void Patty(PdfWriter writer, Document document)
        {


            string heading = "Zikria Construction Company";
            PdfPTable objTable = null;
            PdfPCell cell = null;
            iTextSharp.text.Font fontGeneralText = null;

            objTable = new PdfPTable(13);



            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("" + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + heading + Environment.NewLine + Environment.NewLine, fontGeneralText));
            cell.Colspan = 13;
            cell.Border = 0;
            cell.BorderWidthRight = 0;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);


            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Date", fontGeneralText));
            cell.Colspan = 1;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthLeft = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);


            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("ID", fontGeneralText));
            cell.Colspan = 1;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);



            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Ref. ID", fontGeneralText));
            cell.Colspan = 1;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);




            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Narration", fontGeneralText));
            cell.Colspan = 3;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);

            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Debit", fontGeneralText));
            cell.Colspan = 2;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 0;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);

            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Credit", fontGeneralText));
            cell.Colspan = 2;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 1;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);

            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Balance", fontGeneralText));
            cell.Colspan = 2;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 1;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);




            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("UserName", fontGeneralText));
            cell.Colspan = 1;
            cell.Border = 1;
            cell.BorderWidthTop = 1;
            cell.BorderWidthRight = 1;
            cell.BorderWidthBottom = 1;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            objTable.AddCell(cell);





            document.Add(objTable);





        }
    }

}
