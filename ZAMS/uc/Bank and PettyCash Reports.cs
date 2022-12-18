using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZAMS.Model;
using ZAMS.DAL;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;

namespace ZAMS.uc
{
    public partial class Bank_an_PettyCash_Reports : BaseControl
    {
        List<BankTransactionDummy> BankData = null;
        List<PtyCashDummy> PattyData = null;
        public static string Bank_Paty = "mangooooooooooooooooooooooooooooooooo";
        public static string bank_name = "";

        private string userName;
        private string userRole;


        public Bank_an_PettyCash_Reports()
        {
            InitializeComponent();
        }
        public Bank_an_PettyCash_Reports(string title, string userName, string userRole)
            : base(title, "Bank and PettyCash Reports")
        {
            this.userName = userName;
            this.userRole = userRole;

            InitializeComponent();
        }
        private void Bank_an_PettyCash_Reports_Load(object sender, EventArgs e)
        {

            if (userRole.ToUpper() == "BANKUSER")
            {
                radioButton_pattyCash.Visible = false;
                radioButton_bank.Visible = true;
                radioButton_bank.Checked = true;
            }

            if (userRole.ToUpper() == "PATTYCASHUSER")
            {
                radioButton_pattyCash.Visible = true;
                radioButton_bank.Visible = false;
                panel1.Visible = false;
            }

        }

        private void radioButton_pattyCash_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView_viewTransactions.DataSource = null;
            panel1.Visible = false;
            dataGridView_viewTransactions.Visible = false;
            label_Status.Visible = false;
        }

        private void button_searchTransactions_Click(object sender, EventArgs e)
        {
            BaseControl.status = 1;
            SearchTransactions.dateRange = "Ledger From " + picker_startingDate.Value.Day + "/" + picker_startingDate.Value.Month + "/" + picker_startingDate.Value.Year + " To " + picker_endingDate.Value.Day + "/" + picker_endingDate.Value.Month + "/" + picker_endingDate.Value.Year;
            PattyData = null;
            BankData = null;
            if (radioButton_pattyCash.Checked == true)
            {
                DateTime startDate = picker_startingDate.Value.Date;
                DateTime endDate = picker_endingDate.Value.Date;
                endDate = endDate.AddHours(23);
                endDate = endDate.AddMinutes(59);
                endDate = endDate.AddSeconds(59);
                List<PtyCashDummy> ptycash = ZAMSFactory.DataBase.getPtyCashTransactions(startDate, endDate);

                if (ptycash != null)
                {
                    PattyData = ptycash;
                    dataGridView_viewTransactions.DataSource = ptycash;
                    label_Status.Visible = false;
                    dataGridView_viewTransactions.Visible = true;
                }
                else
                {
                    label_Status.Text = "Something went wrong, please try later";
                    label_Status.Visible = true;
                    dataGridView_viewTransactions.Visible = false;
                }
            }
            else if (radioButton_bank.Checked == true)
            {
                DateTime startDate = picker_startingDate.Value.Date;
                DateTime endDate = picker_endingDate.Value.Date;
                endDate = endDate.AddHours(23);
                endDate = endDate.AddMinutes(59);
                endDate = endDate.AddSeconds(59);
                if (comboBox_bank.SelectedValue.ToString().Equals("Select Bank"))
                {

                    label_Status.Text = "Please select All the fields first";
                    label_Status.Visible = true;
                    return;
                }
                label_Status.Visible = false;
                string bankName = comboBox_bank.SelectedValue.ToString();
                bank_name = bankName;
                if (bankName.Equals("All Banks"))
                {
                    List<BankTransactionDummy> btd = ZAMSFactory.DataBase.getAllBanksTransactions(startDate, endDate);
                    if (btd != null)
                    {
                        BankData = btd;
                        dataGridView_viewTransactions.DataSource = btd;
                        label_Status.Visible = false;
                        dataGridView_viewTransactions.Visible = true;
                    }
                    else
                    {
                        label_Status.Text = "Something went wrong, please try later";
                        label_Status.Visible = true;
                        dataGridView_viewTransactions.Visible = false;
                    }
                }
                else
                {
                    if (comboBox_Branch.SelectedValue.ToString().Equals("Select Branch") || comboBox_bank.SelectedValue.ToString().Equals("Select Bank"))
                    {

                        label_Status.Text = "Please select All the fields first";
                        label_Status.Visible = true;
                        return;
                    }
                    label_Status.Visible = false;
                    string branchame = comboBox_Branch.SelectedValue.ToString();
                    string accountNumber = comboBox_AccountNumber.SelectedValue.ToString();
                    List<BankTransactionDummy> btd1 = ZAMSFactory.DataBase.getTransactionByBankId(startDate, endDate, bankName, branchame, accountNumber);
                    if (btd1 != null)
                    {
                        BankData = btd1;
                        dataGridView_viewTransactions.DataSource = btd1;
                        label_Status.Visible = false;
                        dataGridView_viewTransactions.Visible = true;
                    }
                    else
                    {
                        label_Status.Text = "Something went wrong, please try later";
                        label_Status.Visible = true;
                        dataGridView_viewTransactions.Visible = false;
                    }
                }
            }
        }

        private void radioButton_bank_CheckedChanged(object sender, EventArgs e)
        {

            dataGridView_viewTransactions.DataSource = null;
            comboBox_Branch.Enabled = true;
            comboBox_AccountNumber.Enabled = true;
            comboBox_AccountNumber.DataSource = null;
            comboBox_Branch.DataSource = null;
            //panel1.Dispose();
            panel1.Visible = true;
            dataGridView_viewTransactions.Visible = false;
            label_Status.Visible = false;
            List<string> banks = ZAMSFactory.DataBase.GetBankNames();
            banks.Add("All Banks");
            banks.Add("Select Bank");

            comboBox_bank.DataSource = banks;
            comboBox_bank.SelectedIndex = banks.Count - 1;
        }

        private void button_viewAll_Click(object sender, EventArgs e)
        {
            BaseControl.status = 0;
            SearchTransactions.dateRange = "";
            PattyData = null;
            BankData = null;
            if (radioButton_pattyCash.Checked == true)
            {
                //DateTime startDate = picker_startingDate.Value.Date;
                // DateTime endDate = picker_endingDate.Value.Date;
                // endDate = endDate.AddHours(23);
                // endDate = endDate.AddMinutes(59);
                // endDate = endDate.AddSeconds(59);
                List<PtyCashDummy> ptycash = ZAMSFactory.DataBase.getPtyCashTransactions();
                if (ptycash != null)
                {
                    PattyData = ptycash;
                    dataGridView_viewTransactions.DataSource = ptycash;
                    label_Status.Visible = false;
                    dataGridView_viewTransactions.Visible = true;
                }
                else
                {
                    label_Status.Text = "Something went wrong, please try later";
                    label_Status.Visible = true;
                    dataGridView_viewTransactions.Visible = false;
                }

            }
            else if (radioButton_bank.Checked == true)
            {
                //DateTime startDate = picker_startingDate.Value.Date;
                //DateTime endDate = picker_endingDate.Value.Date;
                //endDate = endDate.AddHours(23);
                //endDate = endDate.AddMinutes(59);
                //endDate = endDate.AddSeconds(59);
                if (comboBox_bank.SelectedValue.ToString().Equals("Select Bank"))
                {

                    label_Status.Text = "Please select All the fields first";
                    label_Status.Visible = true;
                    return;
                }
                label_Status.Visible = false;
                string bankName = comboBox_bank.SelectedValue.ToString();
                bank_name = bankName;
                if (bankName.Equals("All Banks"))
                {
                    List<BankTransactionDummy> btd = ZAMSFactory.DataBase.getAllBanksTransactions();
                    if (btd != null)
                    {
                        BankData = btd;
                        dataGridView_viewTransactions.DataSource = btd;
                        label_Status.Visible = false;
                        dataGridView_viewTransactions.Visible = true;
                    }
                    else
                    {
                        label_Status.Text = "Something went wrong, please try later";
                        label_Status.Visible = true;
                        dataGridView_viewTransactions.Visible = false;
                    }
                }
                else
                {
                    if (comboBox_Branch.SelectedValue.ToString().Equals("Select Branch") || comboBox_bank.SelectedValue.ToString().Equals("Select Bank"))
                    {

                        label_Status.Text = "Please select All the fields first";
                        label_Status.Visible = true;
                        return;
                    }
                    label_Status.Visible = false;
                    string branchame = comboBox_Branch.SelectedValue.ToString();
                    string accountNumber = comboBox_AccountNumber.SelectedValue.ToString();
                    List<BankTransactionDummy> btd1 = ZAMSFactory.DataBase.getTransactionByBankId(bankName, branchame, accountNumber);
                    if (btd1 != null)
                    {
                        BankData = btd1;
                        dataGridView_viewTransactions.DataSource = btd1;
                        label_Status.Visible = false;
                        dataGridView_viewTransactions.Visible = true;
                    }
                    else
                    {
                        label_Status.Text = "Something went wrong, please try later";
                        label_Status.Visible = true;
                        dataGridView_viewTransactions.Visible = false;
                    }
                }
            }
        }

        private void comboBox_bank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_bank_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView_viewTransactions.Visible = false;
            comboBox_AccountNumber.DataSource = null;
            String bankName = comboBox_bank.SelectedValue.ToString();
            if (bankName.Equals("All Banks"))
            {
                comboBox_AccountNumber.Enabled = false;
                comboBox_Branch.Enabled = false;
                return;
            }
            comboBox_Branch.Enabled = true;
            comboBox_AccountNumber.Enabled = true;
            List<String> branchName = ZAMSFactory.DataBase.GetBranchNames(bankName);
            branchName.Add("Select Branch");
            comboBox_Branch.DataSource = branchName;
            comboBox_Branch.SelectedIndex = branchName.Count - 1;
        }

        private void comboBox_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView_viewTransactions.Visible = false;
            String bankName = comboBox_bank.SelectedValue.ToString();
            String branchName = comboBox_Branch.SelectedValue.ToString();
            List<String> AccountNo = ZAMSFactory.DataBase.GetAccountNo(bankName, branchName);
            AccountNo.Add("Select AccountNo");
            comboBox_AccountNumber.DataSource = AccountNo;
            comboBox_AccountNumber.SelectedIndex = AccountNo.Count - 1;
        }

        private void comboBox_AccountNumber_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dataGridView_viewTransactions.Visible = false;
        }

        private void Print_Click(object sender, EventArgs e)
        {
            if (radioButton_bank.Checked)
            {
                Bank_Paty = "Bank";
                BankReport();
            }
            else
            {
                Bank_Paty = "Patty";
                PattyReport();
            }
        }


        public void BankReport()
        {


            ReportHome.mango = "mango";
            string pathToSaveReports = "C://ZAMS_Reports";
            if (!(Directory.Exists(pathToSaveReports)))
            {
                Directory.CreateDirectory(pathToSaveReports);
            }

            // status = 0;
            string heading = " " + comboBox_bank.SelectedValue;
            ReportHome.mainHeadingForReports = heading;
            // projectHeading = comboBox_selectProject.Text;
            // projectHeading = comboBox_selectProject.Text;
            //mainHeadingForReports = mainHeadingForReports + "::::::::::::::" + projectHeading;
            Document pdfDoc = null;
            pdfDoc = new Document(new iTextSharp.text.Rectangle(792, 612), -80, -80, 15, 50);

            //PdfWriter.GetInstance(pdfDoc, new FileStream("Reports.pdf", FileMode.Create));
            String path = heading + "_" + "Reports_" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + ".pdf";
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
                int c = 0;
                int size = BankData.Count;
                int for_total = size - 3;
                bool flag = true;
                for (int i = 0; i < size; i++)
                {


                    if (i >= for_total && bank_name.Equals("All Banks"))
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
                        c++;
                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("", fontGeneralText));
                        cell.Colspan = 3;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + BankData[i].Description, fontGeneralText));
                        cell.Colspan = 5;
                        cell.BorderWidthTop = 1;
                        cell.Border = 1;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 1;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + BankData[i].Debit, fontGeneralText));
                        cell.Colspan = 3;
                        cell.BorderWidthTop = 1;
                        cell.Border = 1;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 1;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + BankData[i].Credit, fontGeneralText));
                        cell.Colspan = 3;
                        cell.BorderWidthTop = 1;
                        cell.Border = 1;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 1;
                        cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase(""));
                        cell.Colspan = 2;
                        cell.BorderWidthTop = 1;
                        cell.Border = 1;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 1;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);



                    }



                    else
                    {
                        string date = BankData[i].Date.Date.ToString();

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + (BankData[i].Date).Day + "/" + (BankData[i].Date).Month + "/" + (BankData[i].Date).Year, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthLeft = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);



                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + BankData[i].ID, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + BankData[i].RefId, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + BankData[i].ChequeNumber, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + BankData[i].Description, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + BankData[i].BankName, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + BankData[i].AccountNumber, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + BankData[i].Debit, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + BankData[i].Credit, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + BankData[i].Balance, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                        //////////////////////////////////
                        /////////////////////////////////
                        /////////////////////////////////

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + BankData[i].UserName, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);






                        if (i == size - 2)
                            bank_name = "All Banks";

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
            // mango = null;
            // ReportHome.mango = null;
            // projectHeading = null;
            //ReportHome.projectHeading = null;
            // ReportHome.mainHeadingForReports = null;
            Bank_an_PettyCash_Reports.Bank_Paty = "Big mango";

        }
        public void PattyReport()
        {
            ReportHome.mango = "mango";
            string pathToSaveReports = "C://ZAMS_Reports";
            if (!(Directory.Exists(pathToSaveReports)))
            {
                Directory.CreateDirectory(pathToSaveReports);
            }

            // status = 0;
            string heading = Bank_Paty;
            ReportHome.mainHeadingForReports = heading + " Cash Report";
            // ReportHome.projectHeading =heading ;
            // projectHeading = comboBox_selectProject.Text;
            // ReportHome. mainHeadingForReports = ReportHome.mainHeadingForReports + "::::::::::::::" + ReportHome.projectHeading;
            Document pdfDoc = null;
            pdfDoc = new Document(new iTextSharp.text.Rectangle(792, 612), -80, -80, 15, 50);

            //PdfWriter.GetInstance(pdfDoc, new FileStream("Reports.pdf", FileMode.Create));
            String path = heading + "_" + "Reports_" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + ".pdf";
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
                objTable = new PdfPTable(13);

                #region Populating Data

                int size = PattyData.Count;
                int for_total = size - 3;
                bool flag = true;
                for (int i = 0; i < size; i++)
                {

                    if (for_total <= i)
                    {
                        if (flag)
                        {
                            flag = false;
                            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                            cell = new PdfPCell(new Phrase("" + Environment.NewLine, fontGeneralText));
                            cell.Colspan = 13;
                            cell.Border = 0;
                            cell.BorderWidthRight = 0;
                            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                            objTable.AddCell(cell);
                        }

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("", fontGeneralText));
                        cell.Colspan = 4;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + PattyData[i].Description, fontGeneralText));
                        cell.Colspan = 3;

                        cell.Border = 1;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + PattyData[i].Debit, fontGeneralText));
                        cell.Colspan = 2;
                        //cell.BorderWidthTop = 0;
                        cell.Border = 1;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + PattyData[i].Credit, fontGeneralText));
                        cell.Colspan = 2;
                        //cell.BorderWidthTop = 0;
                        cell.Border = 1;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase(""));
                        cell.Colspan = 3;
                        // cell.BorderWidthTop = 0;
                        cell.Border = 1;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                    }
                    else
                    {


                        string date = PattyData[i].Date.Date.ToString();

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + (PattyData[i].Date).Day + "/" + (PattyData[i].Date).Month + "/" + (PattyData[i].Date).Year, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthLeft = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + PattyData[i].ID, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);



                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + PattyData[i].RefId, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);



                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + PattyData[i].Description, fontGeneralText));
                        cell.Colspan = 3;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + PattyData[i].Debit, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + PattyData[i].Credit, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + PattyData[i].Balance, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        ///////////////////
                        ////////////////////
                        ///////////////////

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + PattyData[i].UserName, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
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
            //mango = null;
            //  ReportHome.projectHeading = null;
            //ReportHome.mango = null;
            // ReportHome.mainHeadingForReports = null;
            Bank_an_PettyCash_Reports.Bank_Paty = "Big mango";
        }

        public string mainHeadingForReports { get; set; }

        private void dataGridView_viewTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_AccountNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
