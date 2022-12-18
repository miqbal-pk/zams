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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;


namespace ZAMS
{
    public partial class ReportHome : BaseControl
    {
        List<TransactionDummy> dataForPartyReports = null, dataForProjectReports = null;
        List<TransactionOnlyDummy> dataForAllPartyReports2 = null;
        public static string mainHeadingForReports = null;
        public static string projectHeading = null;
        public static string mango = null;

        public ReportHome()
        {
            InitializeComponent();
        }


        public ReportHome(string title)
            : base(title, "ReportHome")
        {
            InitializeComponent();
        }

        private void ReportHome_Load(object sender, EventArgs e)
        {
            PartyDummy p1 = new PartyDummy();
            p1.Party_Name = "Select Client";
            p1.Id = -2;
            PartyDummy p2 = new PartyDummy();
            p2.Party_Name = "Select Project";
            List<PartyDummy> lp = ZAMSFactory.DataBase.GetClient();

            lp.Add(p1);
            if (lp != null)
            {
                reportcombo_party.DataSource = lp;
                reportcombo_party.ValueMember = "Id";
                reportcombo_party.DisplayMember = "Party_Name";
                reportcombo_party.SelectedIndex = lp.Count-1;

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportcombo_party_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string name = Convert.ToString(reportcombo_party.SelectedValue);
            int id = Convert.ToInt32(reportcombo_party.SelectedValue);
            bool a = true;
            
            dataGridView1.Visible = false;
            Button_Print_party.Visible = false;
            if (id == -1)
            {
                //int id1 = int.Parse(ZAMSFactory.DataBase.getCompanyId("Zakriya Construction"));
                List<long> Amount = ZAMSFactory.DataBase.getPaidAmountAll();
                label_showAmountreceived.Text = String.Format("{0:n}", Amount[1]);//Convert.ToString(Amount[1]);
                label_showAmountPaid.Text = String.Format("{0:n}", Amount[0]);
                long bal = Amount[0] - Amount[1];
                label_balanceshow.Text = String.Format("{0:n}", bal);
                label_AmountPaid.Visible = a;
                label_AmountReceived.Visible = a;
                label_Balance.Visible = a;
                button_viewAll.Visible = a;
                label_showAmountPaid.Visible = true;
                label_showAmountreceived.Visible = true;
                label_balanceshow.Visible = a;
                List<ProjectReprt> pr = ZAMSFactory.DataBase.GetAllProjects(id);
                dataGridView3.DataSource = pr;
                dataGridView3.Visible = true;

                Project p1 = new Project();
                p1.ProjectName = "All Projects";
                p1.Id = -1;
                List<Project> lp = ZAMSFactory.DataBase.GetProjects();
                if (lp != null)
                {
                    lp.Add(p1);

                    comboBox_selectProject.DataSource = lp;
                    comboBox_selectProject.ValueMember = "Id";
                    comboBox_selectProject.DisplayMember = "ProjectName";
                    //comboBox_selectProject.Text = "Select Party";
                    comboBox_selectProject.SelectedIndex = lp.Count - 1;
                }
                comboBox_selectProject.Visible = true;
                label_selectProject.Visible = true;
            }
            else if(id==-2)
            {
                //do nothing
                bool a1 = false;
                dataGridView1.Visible = false;
                Button_Print_party.Visible = false;
                label_AmountPaid.Visible = a1;
                label_AmountReceived.Visible = a1;
                label_Balance.Visible = a1;
                button_viewAll.Visible = a1;
                label_showAmountPaid.Visible = a1;
                label_showAmountreceived.Visible = a1;
                label_balanceshow.Visible = a1;
                comboBox_selectProject.Visible = a1;
                label_selectProject.Visible = a1;
                dataGridView3.Visible = a1;
            }
            else
            {
                List<long> Amount = ZAMSFactory.DataBase.getPaidSpecific(id);
                label_showAmountreceived.Text = String.Format("{0:n}", Amount[0]);
                label_showAmountPaid.Text = String.Format("{0:n}", Amount[1]);
                label_balanceshow.Text = String.Format("{0:n}", Amount[1] - Amount[0]);
                label_AmountPaid.Visible = a;
                label_AmountReceived.Visible = a;
                label_Balance.Visible = a;
                button_viewAll.Visible = a;
                label_showAmountPaid.Visible = true;
                label_showAmountreceived.Visible = true;
                label_balanceshow.Visible = a;
                List<ProjectReprt> pr = ZAMSFactory.DataBase.GetAllProjects(id);
                dataGridView3.DataSource = pr;
                dataGridView3.Visible = true;

                Project p1 = new Project();
                p1.ProjectName = "All Projects";
                p1.Id = -1;
                if (ZAMSFactory.DataBase.GetProjectsforParty(id) == null)
                {
                    MessageBox.Show("Error loading data");

                }
                else
                {
                    List<Project> lp = ZAMSFactory.DataBase.GetProjectsforParty(id);
                    if (lp != null)
                    {
                        lp.Add(p1);

                        comboBox_selectProject.DataSource = lp;
                        comboBox_selectProject.ValueMember = "Id";
                        comboBox_selectProject.DisplayMember = "ProjectName";
                        //comboBox_selectProject.Text = "Select Party";
                        comboBox_selectProject.SelectedIndex = lp.Count - 1;
                    }
                    comboBox_selectProject.Visible = true;
                    label_selectProject.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int partyid = Convert.ToInt32(reportcombo_party.SelectedValue);
            int projectid = Convert.ToInt32(comboBox_selectProject.SelectedValue);
            Button_Print_party.Visible = true;
            if (partyid == -1 && projectid == -1)
            {
                List<TransactionOnlyDummy> transactions = ZAMSFactory.DataBase.GetTransactionOnlyDummy();
                dataGridView1.DataSource = transactions;

                dataForAllPartyReports2 = transactions;
            }
            else if (partyid == -1)
            {
                List<TransactionDummy> transactions = ZAMSFactory.DataBase.GetTransactionsByProject1(projectid);
                dataGridView1.DataSource = transactions;

                dataForPartyReports = transactions;
            }
            else if (projectid == -1)
            {
                List<TransactionDummy> transactions = ZAMSFactory.DataBase.GetTransactionsByCompany1(partyid);
                dataGridView1.DataSource = transactions;

                dataForPartyReports = transactions;
            }
            else
            {
                List<TransactionDummy> transactions = ZAMSFactory.DataBase.GetTransactionsByCompanyAndProject(partyid,projectid);
                dataGridView1.DataSource = transactions;

                dataForPartyReports = transactions;
            }
            dataGridView1.Visible = true;
        }







        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    
                    // Do nothing here (let's suppose that TabPage index 0 is the address information which is already loaded.
                    break;
                case 1:
                    // Let's suppose TabPage index 1 is the one for the transactions.
                    // Assuming you have put a DataGridView control so that the transactions can be listed.
                    // currentCustomer.Id can be obtained through the CurrencyManager of your BindingSource object used to data bind your data to your Windows form controls.
                    // dataGridview1.DataSource = GetTransactions(currentCustomer.Id);
                    List<Project> lp = ZAMSFactory.DataBase.GetProjects();
                    if (lp != null)
                    {
                        Project p = new Project();
                        p.ProjectName = "All Projects";
                        p.Id = -1;
                        lp.Add(p);
                        Project p1 = new Project();
                        p1.ProjectName = "Select Project";
                        p1.Id = -2;
                        lp.Add(p1);
                        comboBox2.DataSource = lp;
                        comboBox2.ValueMember = "Id";
                        comboBox2.DisplayMember = "ProjectName";
                        comboBox2.SelectedIndex = lp.Count-1;

                        
                    }
                    break;
                case 2:
                         PartyDummy pd = new PartyDummy();
                         pd.Party_Name = "Select Client";
                         pd.Id = -2;
                         List<PartyDummy> clientList = ZAMSFactory.DataBase.GetClient();
                         clientList.Add(pd);
                         if (clientList != null)
                         {
                             comboBox_clientReport.DataSource = clientList;
                             comboBox_clientReport.ValueMember = "Id";
                             comboBox_clientReport.DisplayMember = "Party_Name";
                             comboBox_clientReport.SelectedIndex = clientList.Count - 1;
                         }
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataForProjectReports = null;
            dataForAllPartyReports2 = null;
            string name = Convert.ToString(comboBox2.SelectedValue);
            int id = Convert.ToInt32(comboBox2.SelectedValue);
            bool a = true;
            dataGridView2.Visible = a;
            button_print_project.Visible = a;
            // label_AmountPaid.Visible = a;
            //label_AmountReceived.Visible = a;
            if (id == -1)
            {
                List<TransactionOnlyDummy> transactions = ZAMSFactory.DataBase.GetTransactionOnlyDummy();
                dataGridView2.DataSource = transactions;
                
                //dataGridView2.Refresh();

                dataForAllPartyReports2 = transactions;
            }
            else
            {
                List<TransactionDummy> transactions = ZAMSFactory.DataBase.GetTransactionsByProject(id);
                dataGridView2.DataSource = transactions;

                dataForProjectReports = transactions;
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string name = Convert.ToString(comboBox2.SelectedValue);
            int id = Convert.ToInt32(comboBox2.SelectedValue);
            bool a = true;
            label3.Visible = a;
            label5.Visible = a;
            label_profit.Visible = a;
            button1.Visible = a;
            button_print_project.Visible = false;
            dataGridView2.Visible = false;
            if (id == -1)
            {
                //int id1 = int.Parse(ZAMSFactory.DataBase.getCompanyId("Zakriya Construction"));
                List<long> Amount = ZAMSFactory.DataBase.getPaidAmountAllproject();
                label4.Text = String.Format("{0:n}", Amount[0]);
                label6.Text = String.Format("{0:n}", Amount[1]);
                label7.Text = String.Format("{0:n}", Amount[1] - Amount[0]);
                label4.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                List<PartyReport> pr=ZAMSFactory.DataBase.getPartyReport(id);
                dataGridView4.DataSource = pr;
                dataGridView4.Visible = true;
            }
            else if(id==-2)
            {
                label4.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                dataGridView4.Visible = false;
                bool a1 = false;
                label3.Visible = a1;
                label5.Visible = a1;
                label_profit.Visible = a1;
                button1.Visible = a1;
                // do nothing
            }
            else
            {
                List<long> Amount = ZAMSFactory.DataBase.getPaidAmount(id);
                label4.Text = String.Format("{0:n}", Amount[0]);
                label6.Text = String.Format("{0:n}", Amount[1]);
                label7.Text = String.Format("{0:n}", Amount[1] - Amount[0]);
                label4.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                List<PartyReport> pr = ZAMSFactory.DataBase.getPartyReport(id);
                dataGridView4.DataSource = pr;
                dataGridView4.Visible = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }








/// <summary>
/// /////////////////////////
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>


        private void button_print_project_Click(object sender, EventArgs e)
        {
            mango=comboBox2.Text;
            mango = mango + " All Vendors";
            if (mango.Equals("All Projects All Vendors"))
            {
                Function_All_Project();
            }
            else
            {
                Function_NotAllProjects();
            }


        }
        public void Function_All_Project()
        {
            string pathToSaveReports = "C://ZAMS_Reports";
            if (!(Directory.Exists(pathToSaveReports)))
            {
                Directory.CreateDirectory(pathToSaveReports);
            }

            status = 0;
            string heading = Convert.ToString(comboBox2.Text);
            mainHeadingForReports = heading;
            mainHeadingForReports ="All Parties ::::::::::::: "+ mainHeadingForReports  ;
            MemoryStream ms = new MemoryStream();
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

                int size = dataForAllPartyReports2.Count;
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
                            cell.Colspan = 1;
                            cell.Border = 0;
                            cell.BorderWidthRight = 0;
                            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                            objTable.AddCell(cell);
                        }

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("", fontGeneralText));
                        cell.Colspan = 6;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Description, fontGeneralText));
                        cell.Colspan = 3;
                        cell.Border = 1;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Debit, fontGeneralText));
                        cell.Colspan = 3;
                        cell.Border = 1;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Credit, fontGeneralText));
                        cell.Colspan = 3;
                        cell.Border = 1;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                        //////////////////////////////////////////////////////
                        /////////////////////////////////////////////////////
                        /////////////////////////////////////////////////////

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].UserName, fontGeneralText));
                        cell.Colspan = 3;
                        cell.Border = 1;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                    }


                    else
                    {

                        string date = dataForAllPartyReports2[i].Date.Date.ToString();

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + (dataForAllPartyReports2[i].Date).Day + "/" + (dataForAllPartyReports2[i].Date).Month + "/" + (dataForAllPartyReports2[i].Date).Year, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthLeft = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].RefId, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Party, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Project, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Cheque_No, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Description, fontGeneralText));
                        cell.Colspan = 3;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Debit, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Credit, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        
                        //////////////////////////////////////////////////////
                        //////////////////////////////////////////////////////
                        //////////////////////////////////////////////////////


                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].UserName, fontGeneralText));
                        cell.Colspan = 2;
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

            //Printing
            //string path = heading + "_" + "Reports_" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + ".pdf";
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                Verb = "print",
                FileName = pathToSaveReports + "//" + path
                //put the correct path here
            };
            p.Start();
            mango = null;
        }





        public void Function_NotAllProjects()
        {
            string pathToSaveReports = "C://ZAMS_Reports";
            if (!(Directory.Exists(pathToSaveReports)))
            {
                Directory.CreateDirectory(pathToSaveReports);
            }

            status = 0;
            string heading = Convert.ToString(comboBox2.Text);
            mainHeadingForReports = heading;

            //projectHeading = comboBox_selectProject.Text;
            mainHeadingForReports ="All Parties :::::::::::: "+ mainHeadingForReports ;

            MemoryStream ms = new MemoryStream();
            Document pdfDoc = null;
            pdfDoc = new Document(new iTextSharp.text.Rectangle(792, 612),-80 ,-80 , 15, 50);

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

                int size = dataForProjectReports.Count;
                for (int i = 0; i < size-1; i++)
                {
                    string date = dataForProjectReports[i].Date.Date.ToString();

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ITALIC, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + (dataForProjectReports[i].Date).Day + "/" + (dataForProjectReports[i].Date).Month + "/" + (dataForProjectReports[i].Date).Year, fontGeneralText));
                    cell.Colspan = 1;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthLeft = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForProjectReports[i].RefId, fontGeneralText));
                    cell.Colspan = 1;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);


                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForProjectReports[i].PartyORProject, fontGeneralText));
                    cell.Colspan = 2;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);




                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForProjectReports[i].Cheque_No, fontGeneralText));
                    cell.Colspan = 2;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ITALIC, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForProjectReports[i].Description, fontGeneralText));
                    cell.Colspan = 3;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForProjectReports[i].Debit, fontGeneralText));
                    cell.Colspan = 2;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForProjectReports[i].Credit, fontGeneralText));
                    cell.Colspan = 2;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForProjectReports[i].Balance, fontGeneralText));
                    cell.Colspan = 2;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);


                    /////////////////////////////////////////////////////////
                    ////////////////////////////////////////////////////////

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForProjectReports[i].UserName, fontGeneralText));
                    cell.Colspan = 2;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    /////////////////////////////////////////////////////////
                    ////////////////////////////////////////////////////////


                }

                fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                cell = new PdfPCell(new Phrase("" + Environment.NewLine, fontGeneralText));
                cell.Colspan = 15;
                cell.Border = 0;
                cell.BorderWidthRight = 0;
                cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                objTable.AddCell(cell);

                fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                cell = new PdfPCell(new Phrase("", fontGeneralText));
                cell.Colspan = 4;
                cell.Border = 0;
                cell.BorderWidthRight = 0;
                cell.BorderWidthBottom = 0;
                cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                objTable.AddCell(cell);

                fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                cell = new PdfPCell(new Phrase("Total", fontGeneralText));
                cell.Colspan = 5;
                cell.BorderWidthTop = 1;
                cell.Border = 1;
                cell.BorderWidthRight = 0;
                cell.BorderWidthBottom = 1;
                cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                objTable.AddCell(cell);

                fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                cell = new PdfPCell(new Phrase("" + dataForProjectReports[size - 1].Debit, fontGeneralText));
                cell.Colspan = 2;
                cell.BorderWidthTop = 1;
                cell.Border = 1;
                cell.BorderWidthRight = 0;
                cell.BorderWidthBottom = 1;
                cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                objTable.AddCell(cell);

                fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                cell = new PdfPCell(new Phrase("" + dataForProjectReports[size - 1].Credit, fontGeneralText));
                cell.Colspan = 2;
                cell.BorderWidthTop = 1;
                cell.Border = 1;
                cell.BorderWidthRight = 0;
                cell.BorderWidthBottom = 1;
                cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                objTable.AddCell(cell);

                fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                cell = new PdfPCell(new Phrase("", fontGeneralText));
                cell.Colspan = 2;
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

            //Printing
            //string path = heading + "_" + "Reports_" + DateTime.Now.ToLongDateString() + " " + DateTime.Now.Hour + "_" + DateTime.Now.Minute + "_" + DateTime.Now.Second + ".pdf";
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo()
            {
                CreateNoWindow = true,
                Verb = "print",
                FileName = pathToSaveReports + "//" + path
                //put the correct path here
            };
            p.Start();
            mango = null;
        }

        private void Button_Print_party_Click(object sender, EventArgs e)
        {
            mango = comboBox_selectProject.Text;
            string party = reportcombo_party.Text;
            mango = mango + " "+party;
            if (mango.Equals("All Projects All Vendors"))
            {
                Party_All_Projects();
            }
            else
            {
                Party_Not_All_Projects();
            }
                

        }
        public void Party_All_Projects()
        {
            string pathToSaveReports = "C://ZAMS_Reports";
            if (!(Directory.Exists(pathToSaveReports)))
            {
                Directory.CreateDirectory(pathToSaveReports);
            }

            status = 0;
            string heading = Convert.ToString(reportcombo_party.Text);
            mainHeadingForReports = heading;
            projectHeading = comboBox_selectProject.Text;
           // projectHeading = comboBox_selectProject.Text;
            mainHeadingForReports =mainHeadingForReports+ "::::::::::::::" + projectHeading;
            Document pdfDoc = null;
            pdfDoc = new Document(new iTextSharp.text.Rectangle(792, 612),-80,-80,15,50);

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
                bool flag = true;
                
                int size = dataForAllPartyReports2.Count;
                int for_total=size-3;
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
                        
                        


                            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                            cell = new PdfPCell(new Phrase("", fontGeneralText));
                            cell.Colspan = 4;
                            cell.Border = 0;
                            cell.BorderWidthRight = 0;
                            cell.BorderWidthBottom = 0;
                            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                            objTable.AddCell(cell);


                            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                            cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Description, fontGeneralText));
                            cell.Colspan = 3;
                            cell.Border = 1;
                            cell.BorderWidthRight = 0;
                            cell.BorderWidthBottom = 0;
                            cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                            objTable.AddCell(cell);

                            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                            cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Debit, fontGeneralText));
                            cell.Colspan = 4;
                            cell.Border = 1;
                            cell.BorderWidthRight = 0;
                            cell.BorderWidthBottom = 0;
                            cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                            objTable.AddCell(cell);

                            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                            cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Credit, fontGeneralText));
                            cell.Colspan = 4;
                            cell.Border = 1;
                            cell.BorderWidthRight = 0;
                            cell.BorderWidthBottom = 0;
                            cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                            objTable.AddCell(cell);

                        



                        /////////////////////////////////////////////////////
                        /////////////////////////////////////////////////////


                            fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                            cell = new PdfPCell(new Phrase("", fontGeneralText));
                            cell.Colspan = 1;
                            cell.Border = 1;
                            cell.BorderWidthRight = 0;
                            cell.BorderWidthBottom = 0;
                            cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                            objTable.AddCell(cell);





                    }
                    else
                    {




                        string date = dataForAllPartyReports2[i].Date.Date.ToString();

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + (dataForAllPartyReports2[i].Date).Day + "/" + (dataForAllPartyReports2[i].Date).Month + "/" + (dataForAllPartyReports2[i].Date).Year, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthLeft = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].RefId, fontGeneralText));
                        cell.Colspan = 1;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);


                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Party, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);



                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Project, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);




                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Cheque_No, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Description, fontGeneralText));
                        cell.Colspan = 3;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Debit, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);

                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].Credit, fontGeneralText));
                        cell.Colspan = 2;
                        cell.Border = 0;
                        cell.BorderWidthRight = 0;
                        cell.BorderWidthBottom = 0;
                        cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                        objTable.AddCell(cell);





                        ///////////////////////////////////////////////////
                        //////////////////////////////////////////////////


                        fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                        cell = new PdfPCell(new Phrase("" + dataForAllPartyReports2[i].UserName, fontGeneralText));
                        cell.Colspan = 2;
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
            mango = null;
            projectHeading = null;
        }
        public void Party_Not_All_Projects()
        {
            string pathToSaveReports = "C://ZAMS_Reports";
            if (!(Directory.Exists(pathToSaveReports)))
            {
                Directory.CreateDirectory(pathToSaveReports);
            }

            status = 0;
            string heading = Convert.ToString(reportcombo_party.Text);
            mainHeadingForReports = heading;
            projectHeading = comboBox_selectProject.Text;
            mainHeadingForReports = mainHeadingForReports+"::::::::::::::" + projectHeading;

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

                int size = dataForPartyReports.Count;
                for (int i = 0; i < size-1; i++)
                {
                    string date = dataForPartyReports[i].Date.Date.ToString();

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + (dataForPartyReports[i].Date).Day + "/" + (dataForPartyReports[i].Date).Month + "/" + (dataForPartyReports[i].Date).Year, fontGeneralText));
                    cell.Colspan = 1;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthLeft = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForPartyReports[i].RefId, fontGeneralText));
                    cell.Colspan = 1;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);


                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForPartyReports[i].PartyORProject, fontGeneralText));
                    cell.Colspan = 2;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);



                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForPartyReports[i].Cheque_No, fontGeneralText));
                    cell.Colspan = 2;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForPartyReports[i].Description, fontGeneralText));
                    cell.Colspan = 3;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForPartyReports[i].Debit, fontGeneralText));
                    cell.Colspan = 2;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForPartyReports[i].Credit, fontGeneralText));
                    cell.Colspan = 2;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForPartyReports[i].Balance, fontGeneralText));
                    cell.Colspan = 2;
                    cell.Border = 0;
                    cell.BorderWidthRight = 0;
                    cell.BorderWidthBottom = 0;
                    cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                    objTable.AddCell(cell);



                    ////////////////////////////////////////////////
                    /////////////////////////////////////////////
                    ///////////////////////////////////////////

                    fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    cell = new PdfPCell(new Phrase("" + dataForPartyReports[i].UserName, fontGeneralText));
                    cell.Colspan = 2;
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

                fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                cell = new PdfPCell(new Phrase("", fontGeneralText));
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
                cell = new PdfPCell(new Phrase("" + dataForPartyReports[size - 1].Debit, fontGeneralText));
                cell.Colspan = 4;
                cell.BorderWidthTop = 1;
                cell.Border = 1;
                cell.BorderWidthRight = 0;
                cell.BorderWidthBottom = 1;
                cell.HorizontalAlignment = 2; //0=Left, 1=Centre, 2=Right
                objTable.AddCell(cell);

                fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                cell = new PdfPCell(new Phrase("" + dataForPartyReports[size - 1].Credit, fontGeneralText));
                cell.Colspan = 3;
                cell.BorderWidthTop = 1;
                cell.Border = 1;
                cell.BorderWidthRight = 0;
                cell.BorderWidthBottom = 1;
                cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
                objTable.AddCell(cell);

                fontGeneralText = FontFactory.GetFont(FontFactory.TIMES_ROMAN, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                cell = new PdfPCell(new Phrase("", fontGeneralText));
                cell.Colspan = 2;
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
            mango = null;
            projectHeading = null;
        }

        private void reportcombo_party_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_selectProject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bool a = false;
            dataGridView1.Visible = false;
            Button_Print_party.Visible = false;
            label_AmountPaid.Visible = a;
            label_AmountReceived.Visible = a;
            label_Balance.Visible = a;
            button_viewAll.Visible = a;
            label_showAmountPaid.Visible = a;
            label_showAmountreceived.Visible = a;
            label_balanceshow.Visible = a;
            comboBox_selectProject.Visible = a;
            label_selectProject.Visible = a;
            dataGridView3.Visible = a;
            PartyDummy p1 = new PartyDummy();
            p1.Party_Name = "Select Client";
            p1.Id = -2;
            List<PartyDummy> lp = ZAMSFactory.DataBase.GetClient();
            lp.Add(p1);
            if (lp != null)
            {
                reportcombo_party.DataSource = lp;
                reportcombo_party.ValueMember = "Id";
                reportcombo_party.DisplayMember = "Party_Name";
                reportcombo_party.SelectedIndex = lp.Count-1;
            }
            else
                reportcombo_party.DataSource = null;
        }

        private void radioButton_vendor_CheckedChanged(object sender, EventArgs e)
        {
            bool a = false;
            dataGridView1.Visible = false;
            Button_Print_party.Visible = false;
            label_AmountPaid.Visible = a;
            label_AmountReceived.Visible = a;
            label_Balance.Visible = a;
            button_viewAll.Visible = a;
            label_showAmountPaid.Visible = a;
            label_showAmountreceived.Visible = a;
            label_balanceshow.Visible = a;
            comboBox_selectProject.Visible = a;
            label_selectProject.Visible = a;
            dataGridView3.Visible = a;
            Party p1 = new Party();
            p1.Party_Name = "All Vendors";
            p1.Id = -1;
            Party p2 = new Party();
            p2.Party_Name = "Select Vendor";
            p2.Id = -2;
            
            List<Party> lp = ZAMSFactory.DataBase.getVendor();

            if (lp != null)
            {
                lp.Add(p1);
                lp.Add(p2);
                reportcombo_party.DataSource = lp;
                reportcombo_party.ValueMember = "Id";
                reportcombo_party.DisplayMember = "Party_Name";
                reportcombo_party.SelectedIndex = lp.Count-1;
            }
            else
                    reportcombo_party.DataSource = null;
        }
        /// 14 november 2015
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String clientName = Convert.ToString(comboBox_clientReport.Text);
            List<Project> clientProjects = ZAMSFactory.DataBase.GetProjects(clientName);
            if (clientProjects != null)
            {
                Project pAll = new Project();
                pAll.ProjectName = "All Projects";
                pAll.Id = -1;
                clientProjects.Add(pAll);
                Project p1 = new Project();
                p1.ProjectName = "Select Project";
                p1.Id = -2;
                clientProjects.Add(p1);
                
                comboBox_clientProject.DataSource = clientProjects;
                comboBox_clientProject.ValueMember = "Id";
                comboBox_clientProject.DisplayMember = "ProjectName";
                comboBox_clientProject.SelectedIndex = clientProjects.Count - 1;

            }
         


        }

        private void comboBox_clientReport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox_clientProject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int partyid = Convert.ToInt32(comboBox_clientReport.SelectedValue);
            int projectid = Convert.ToInt32(comboBox_clientProject.SelectedValue);
            List<long> list=new List<long>();
            if (partyid != -1 && projectid != -1)
            {
                List<long> list1=ZAMSFactory.DataBase.getRecievedAmountAndExpenditure(partyid,projectid);
                list = list1;
               
            }
            else if (projectid == -1 && partyid != -1)
            {
                List<long> list2 = ZAMSFactory.DataBase.getRecievedAmountAndExpenditure(partyid);

                list = list2;


            }
            if (list != null)
            {
                RecivedAmount.Text = String.Format("{0:n}", list[0]);
                Expenditure.Text = String.Format("{0:n}", list[1]);
                Profit.Text = String.Format("{0:n}", list[0] - list[1]);
            }


        }

        private void comboBox_clientProject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
