using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZAMS.DAL;
using ZAMS.Model;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace ZAMS
{
    public partial class SearchTransactions : BaseControl
    {
        List<TransactionDummy> dataForSearchTransactionsReport = null;
        List<TransactionOnlyDummy> dataForSearchTransactionsReport2 = null;
        public static string dateRange=null, projectNameForReport=null;
       
        public SearchTransactions()
        {
            InitializeComponent();
        }


        public SearchTransactions(string title)
            : base(title, "SearchTransactions")
        {
            InitializeComponent();
        }

        private void SearchTransactions_Load(object sender, EventArgs e)
        {
           // radioButton_client.Select();
            List<Project> projects= ZAMSFactory.DataBase.GetProjects();
            if (projects.Count != 0)
            {
                Project p = new Project();
                p.ProjectName = "All Projects";
                p.Id = -1;
                projects.Add(p);
                comboBox_project1.DataSource = projects;
                comboBox_project1.ValueMember = "Id";
                comboBox_project1.DisplayMember = "ProjectName";
                comboBox_project1.SelectedIndex = projects.Count - 1;
            }
            List<Party> cp = ZAMSFactory.DataBase.getClient1();
            //Party party = new Party();
            //party.Party_Name = "All Parties";
            //party.Id = -1;
            //cp.Add(party);
            if (cp.Count != 0)
            {
                comboBox_party1.DataSource = cp;
                comboBox_party1.ValueMember = "Id";
                comboBox_party1.DisplayMember = "Party_Name";
                comboBox_party1.SelectedIndex = 0;
            }
        }

        private void comboBox_project_SelectedIndexChanged(object sender, EventArgs e)
        {
                       
        }

        private void comboBox_project_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string name = Convert.ToString(comboBox_project1.SelectedValue);

                if (name.Equals("All"))
                {
                    List<Party> cp = ZAMSFactory.DataBase.getCompanies1();
                    if (cp.Count !=0)
                    {
                        Party p = new Party();
                        p.Party_Name = "All";
                        p.Id = -1;
                        cp.Add(p);
                        comboBox_party1.DataSource = cp;
                        comboBox_party1.ValueMember = "Id";
                        comboBox_party1.DisplayMember = "Party_Name";
                        comboBox_party1.SelectedIndex = cp.Count - 1;
                    }

                }
                else
                {

                    List<Party> cp = ZAMSFactory.DataBase.getContractParty(name);
                    if (cp != null)
                    {
                        Party p = new Party();
                        p.Party_Name = "All";
                        p.Id = -1;
                        cp.Add(p);
                        comboBox_party1.DataSource = cp;
                        comboBox_party1.ValueMember = "Id";
                        comboBox_party1.DisplayMember = "Party_Name";

                        comboBox_party1.SelectedIndex = cp.Count - 1;
                    }
                }
            }
            catch (Exception exception)
            {
                string message = exception.Message;
            }

        }

        private void button_getTransactions_Click(object sender, EventArgs e)
        {
            dataForSearchTransactionsReport = null;
            dataForSearchTransactionsReport2 = null;
            DateTime startDate = picker_startingDate.Value.Date;
            DateTime endDate = picker_endingDate.Value.Date;
            endDate=endDate.AddHours(23);
            endDate=endDate.AddMinutes(59);
            endDate=endDate.AddSeconds(59);
            button_print_transaction.Visible = true;
            dataGridView_transactions.Visible = true;
            //endDate.TimeOfDay = "11:59";
            //MessageBox.Show(endDate.TimeOfDay);
            string projectName = Convert.ToString(comboBox_project1.SelectedValue);
            string partyName = Convert.ToString(comboBox_party1.SelectedValue);
            int cid = Convert.ToInt32(comboBox_party1.SelectedValue);
            int pid = Convert.ToInt32(comboBox_project1.SelectedValue);

            if (projectName.Equals("-1") && partyName.Equals("-1"))
            {
                List<TransactionOnlyDummy> transactions = ZAMSFactory.DataBase.getTransactionByTime(startDate, endDate);
                dataGridView_transactions.DataSource = transactions;

                dataForSearchTransactionsReport2 = transactions;
            }
            else if((projectName.Equals("-1")))
            {
                List<TransactionDummy> transactions = ZAMSFactory.DataBase.GetTransactionsByCompany(cid,startDate,endDate);
                dataGridView_transactions.DataSource = transactions;

                dataForSearchTransactionsReport = transactions;
            }
            else if (partyName.Equals("-1"))
            {
                List<TransactionDummy> transactions = ZAMSFactory.DataBase.GetTransactionsByProject(pid,startDate,endDate);
                dataGridView_transactions.DataSource = transactions;

                dataForSearchTransactionsReport = transactions;
            }
            else
            {
                List<TransactionDummy> transactions = ZAMSFactory.DataBase.GetTransactionsByCompanyAndProject(cid, pid, startDate, endDate);
                dataGridView_transactions.DataSource = transactions;

                dataForSearchTransactionsReport = transactions;
            }
            //int projectId = int.Parse(ZAMSFactory.DataBase.getProjectId(projectName));
            //int partyId = int.Parse(ZAMSFactory.DataBase.getCompanyId(partyName));
            //List<Transaction> transactions = ZAMSFactory.DataBase.getTransactions(startDate,endDate,projectId,partyId);
        }


        private void SearchTransactions_Enter(object sender, EventArgs e)
        {

            //dataGridView_transactions.Visible = false;
            //SearchTransactions_Load(sender, e);
        }



        private void button_print_transaction_Click(object sender, EventArgs e)
        {
            ReportHome.mango = comboBox_project1.Text;
            string party = comboBox_party1.Text;
            if (party.Equals("All Vendors"))
                ReportHome.mango = ReportHome.mango + " " + "All Vendors";

            if (ReportHome.mango.Equals("All Projects All Vendors"))
            {
                All_Projects();
            }
            else
            {
                string pathToSaveReports = "C://ZAMS_Reports";
                if (!(Directory.Exists(pathToSaveReports)))
                {
                    Directory.CreateDirectory(pathToSaveReports);
                }


                status = 1;
                ReportHome.mainHeadingForReports = Convert.ToString(comboBox_party1.Text);
                projectNameForReport = Convert.ToString(comboBox_project1.Text);
                dateRange = "Ledger From " + picker_startingDate.Value.Day + "/" + picker_startingDate.Value.Month + "/" + picker_startingDate.Value.Year + " To " + picker_endingDate.Value.Day + "/" + picker_endingDate.Value.Month + "/" + picker_endingDate.Value.Year;

                Document pdfDoc = null;

                pdfDoc = new Document(new iTextSharp.text.Rectangle(792, 612),-80,-80,15,50);

                //PdfWriter.GetInstance(pdfDoc, new FileStream("Reports.pdf", FileMode.Create));
                String path = ReportHome.mainHeadingForReports + "_" + projectNameForReport + "_" + "Reports_" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + ".pdf";
                FileStream fs = new FileStream(pathToSaveReports + "//" + path, FileMode.Create);
                // PdfWriter.GetInstance(pdfDoc,fs);
                PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, fs);
                pdfWriter.PageEvent = new ITextEvents();
                pdfDoc.Open();


                PdfPTable objTable = null;
                PdfPCell cell = null;
                iTextSharp.text.Font fontGeneralText = null;
                
                objTable = new PdfPTable(16);

                try
                {


                    #region Populating Data

                    int size = dataForSearchTransactionsReport.Count;
                    for (int i = 0; i < size-1; i++)
                    {
                        string date = dataForSearchTransactionsReport[i].Date.Date.ToString();




                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + (dataForSearchTransactionsReport[i].Date).Day + "/" + (dataForSearchTransactionsReport[i].Date).Month + "/" + (dataForSearchTransactionsReport[i].Date).Year, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthLeft = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport[i].RefId, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);



                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport[i].PartyORProject, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);



                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport[i].Cheque_No, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport[i].Description, fontGeneralText));
                        cell.Colspan = 3;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport[i].Debit, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport[i].Credit, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport[i].Balance, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);



                        ///////////////////////////////
                        //////////////////////////////

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport[i].UserName, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                    }

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + Environment.NewLine, fontGeneralText));
                    cell.Colspan = 16;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" , fontGeneralText));
                    cell.Colspan = 4;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("Total", fontGeneralText));
                    cell.Colspan = 3;
                    cell.BorderWidthTop = 1;
                    cell.Border = 1;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 1;
                    cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase(""+dataForSearchTransactionsReport[size-1].Debit, fontGeneralText));
                    cell.Colspan = 4;
                    cell.BorderWidthTop = 1;
                    cell.Border = 1;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 1;
                    cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport[size - 1].Credit, fontGeneralText));
                    cell.Colspan = 4;
                    cell.BorderWidthTop = 1;
                    cell.Border = 1;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 1;
                    cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);



                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" , fontGeneralText));
                    cell.Colspan = 1;
                    cell.BorderWidthTop = 1;
                    cell.Border = 1;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 1;
                    cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);
                  


                    pdfDoc.Add(objTable);
                    #endregion
                }

                catch (Exception)
                {
                }
                pdfDoc.Close();

                Process p = new Process();
                p.StartInfo = new ProcessStartInfo()
                {
                    CreateNoWindow = true,
                    Verb = "print",
                    FileName = pathToSaveReports + "//" + path
                    //put the correct path here
                };
                p.Start();
                ReportHome.mango = null;
            }
        }

    
        
        
        
        
        
        public void All_Projects()
        {
            string pathToSaveReports = "C://ZAMS_Reports";
            if (!(Directory.Exists(pathToSaveReports)))
            {
                Directory.CreateDirectory(pathToSaveReports);
            }


            status = 1;
            ReportHome.mainHeadingForReports = Convert.ToString(comboBox_party1.Text);
            projectNameForReport = Convert.ToString(comboBox_project1.Text);
            dateRange = "Ledger From " + picker_startingDate.Value.Day + "/" + picker_startingDate.Value.Month + "/" + picker_startingDate.Value.Year + " To " + picker_endingDate.Value.Day + "/" + picker_endingDate.Value.Month + "/" + picker_endingDate.Value.Year;

            Document pdfDoc = null;
            pdfDoc = new Document(new iTextSharp.text.Rectangle(792, 612), -80, -80, 15, 50);

            //PdfWriter.GetInstance(pdfDoc, new FileStream("Reports.pdf", FileMode.Create));
            String path = ReportHome.mainHeadingForReports + "_" + projectNameForReport + "_" + "Reports_" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + ".pdf";
            FileStream fs = new FileStream(pathToSaveReports + "//" + path, FileMode.Create);
            // PdfWriter.GetInstance(pdfDoc,fs);
            PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, fs);
            pdfWriter.PageEvent = new ITextEvents();
            pdfDoc.Open();


            PdfPTable objTable = null;
            PdfPCell cell = null;
            iTextSharp.text.Font fontGeneralText = null;
            
            try
            {
                objTable = new PdfPTable(16);

                #region Populating Data

                int size = dataForSearchTransactionsReport2.Count;
                int for_total = size - 3;
                bool flag = true;
                for (int i = 0; i < size; i++)
                {

                    if (i >= for_total)
                    {
                        if (flag)
                        {



                            flag = false;
                            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                            cell = new PdfPCell(new Phrase("" + Environment.NewLine, fontGeneralText));
                            cell.Colspan = 16;
                            cell.Border = 0;
                            cell.BorderWidthRight = 0;
                            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                            objTable.AddCell(cell);
                        }
                        

                fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                cell = new PdfPCell(new Phrase("", fontGeneralText));
                cell.Colspan = 4;
                cell.Border = 0;
                cell.BorderWidthRight = 0;
                cell.BorderWidthBottom = 0;
                cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                objTable.AddCell(cell);

                fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport2[i].Description, fontGeneralText));
                cell.Colspan = 3;
                cell.BorderWidthTop = 1;
                cell.Border = 1;
                cell.BorderWidthRight = 0;
                cell.BorderWidthBottom = 0;
                cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                objTable.AddCell(cell);

                fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport2[i].Debit, fontGeneralText));
                cell.Colspan = 4;
                cell.BorderWidthTop = 1;
                cell.Border = 1;
                cell.BorderWidthRight = 0;
                cell.BorderWidthBottom = 0;
                cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                objTable.AddCell(cell);

                fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport2[i].Credit, fontGeneralText));
                cell.Colspan = 4;
                cell.BorderWidthTop = 1;
                cell.Border = 1;
                cell.BorderWidthRight = 0;
                cell.BorderWidthBottom = 0;
                cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                objTable.AddCell(cell);


                fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                cell = new PdfPCell(new Phrase("", fontGeneralText));
                cell.Colspan = 1;
                cell.BorderWidthTop = 1;
                cell.Border = 1;
                cell.BorderWidthRight = 0;
                cell.BorderWidthBottom = 0;
                cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                objTable.AddCell(cell);






                    }

                    else
                    {


                        string date = dataForSearchTransactionsReport2[i].Date.Date.ToString();

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + (dataForSearchTransactionsReport2[i].Date).Day + "/" + (dataForSearchTransactionsReport2[i].Date).Month + "/" + (dataForSearchTransactionsReport2[i].Date).Year, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthLeft = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport2[i].RefId, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport2[i].Party, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport2[i].Project, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);



                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport2[i].Cheque_No, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport2[i].Description, fontGeneralText));
                        cell.Colspan = 3;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport2[i].Debit, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport2[i].Credit, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForSearchTransactionsReport2[i].UserName, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                    

                        
                        objTable.AddCell(cell);

                    }


                }



                pdfDoc.Add(objTable);

                #endregion
            }
            catch (Exception)
            {
            }
            pdfDoc.Close();

            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                Verb = "print",
                FileName = pathToSaveReports + "//" + path
                //put the correct path here
            };
            p.Start();
            ReportHome.mango = null;
        }
        private void SearchTransactions_DragEnter(object sender, DragEventArgs e)
        {
            //dataGridView_transactions.Visible = false;
        }

        private void radioButton_client_CheckedChanged(object sender, EventArgs e)
        {
            button_print_transaction.Visible = false;
            dataGridView_transactions.Visible = false;
            
            List<Party> cp = ZAMSFactory.DataBase.getClient1();
            //Party party = new Party();
            //party.Party_Name = "All Parties";
            //party.Id = -1;
            //cp.Add(party);
            if (cp.Count != 0)
            {
                comboBox_party1.DataSource = cp;
                comboBox_party1.ValueMember = "Id";
                comboBox_party1.DisplayMember = "Party_Name";
                comboBox_party1.SelectedIndex = 0;
            }
            else
                comboBox_party1.DataSource = null;

        }

        private void radioButton_vendor_CheckedChanged(object sender, EventArgs e)
        {
            button_print_transaction.Visible = false;
            dataGridView_transactions.Visible = false;

            List<Party> cp = ZAMSFactory.DataBase.getVendor();
            if (cp.Count!= 0)
            {
                Party party = new Party();
                party.Party_Name = "All Vendors";
                party.Id = -1;
                cp.Add(party);
                comboBox_party1.DataSource = cp;
                comboBox_party1.ValueMember = "Id";
                comboBox_party1.DisplayMember = "Party_Name";
                comboBox_party1.SelectedIndex = 0;
            }
            else
                comboBox_party1.DataSource = null;
        }

        private void comboBox_party1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_transactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    
}
