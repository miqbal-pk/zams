using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZAMS.Model;

namespace ZAMS.DAL
{
    class ZAMS_DAL
    {
        //ZamsEntities21 db;
        public ZAMS_DAL()
        {
            //db = new ZamsEntities2();
        }

        // UserName , Password , Name , PhoneNumber , Address , AccessSpecifier  =>  Varchar(50) username & password are mandatory 

        //        .OrderBy(t => t.Party_Name)

        /////////////////////////////////////////////////////////////////
        /////                      LOGIN                         ///////
        ///////////////////////////////////////////////////////////////
        

        public List<Login> GetLogin(string name, string password)
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                return db.Logins.Where(p => p.UserName.Equals(name) && p.Password.Equals(password)).ToList();

            }
        }



        /////////////////////////////////////////////////////////////////
        /////                     CREAT ACCOUNT                  ///////
        ///////////////////////////////////////////////////////////////


        public int createAccount(Login login)
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                db.Logins.Add(login);
               return db.SaveChanges();
            }
               
        }

        /////////////////////////////////////////////////////////////////
        /////                      Delete Account                ///////
        ///////////////////////////////////////////////////////////////


        public bool deleteUser(string name, string password)
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {

                Login login = db.Logins.SingleOrDefault(p => p.UserName.Equals(name) && p.Password.Equals(password));

                if (login != null)
                {
                    db.Logins.Remove(login);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }



        /////////////////////////////////////////////////////////////////
        /////                 Load Users                         ///////
        ///////////////////////////////////////////////////////////////


        public List<Login> GetUsers()
        {
            ZamsEntities6 db = new ZamsEntities6();
            List<Login> usersList = new List<Login>();

            using (db)
            {

                usersList = db.Logins.ToList();
                return usersList ;
            }
        }




          /////////////////////////////////////////////////////////////////
         /////                     Find SignUp Member ACCOUNT      ///////
        ///////////////////////////////////////////////////////////////
        ////////    else account with this name already exist  ////////

        public bool FindSignUpName(string SignUpName)
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                Login login = db.Logins.SingleOrDefault(p => p.UserName.Equals(SignUpName));
                if (login == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }


        /////////////////////////////////////////////////////////////////
        /////                    CHANGE PASSWORD                 ///////
        ///////////////////////////////////////////////////////////////

        public int ChangePassword(string name , string password , string newPassword)
        {
            ZamsEntities6 db = new ZamsEntities6();

            List<Login> loginList = db.Logins.Where(p => p.UserName.Equals(name) && p.Password.Equals(password)).ToList();
            Login login = (Login)loginList[0];
            try
            {


                login.Password = newPassword;
                return db.SaveChanges();
            }
            catch (Exception e)
            {
                return 0;
            }

        }


        public List<PartyDummy> GetCompanies()
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                List<PartyDummy> pd = new List<PartyDummy>();
                List<Party> p = db.Parties.ToList();
                
                foreach (Party p1 in p)
                {
                    PartyDummy pd1 = new PartyDummy();
                    if(p1.CompanyBalance!=null)
                        pd1.CompanyBalance =String.Format("{0:n}",p1.CompanyBalance);
                    else
                        pd1.CompanyBalance = String.Format("{0:n}", 0);

                    pd1.Email = p1.Email;
                    pd1.FaxNumber = p1.FaxNumber;
                    pd1.Id = p1.Id;
                    pd1.Location = p1.Location;
                    pd1.OwnerName = p1.OwnerName;
                    pd1.Party_Name = p1.Party_Name;
                    pd1.PhoneNumber = p1.PhoneNumber;
                    pd1.CompanyType = p1.CompanyType;
                    pd1.CNIC_NTN = p1.CNIC_NTN;
                    pd.Add(pd1);
                   
                    
                }
                return pd;

            }
        }
        public List<PartyDummy> GetCompanies1()
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                return db.Parties.Where(p => p.Party_Name != "Zakriya Construction").Select(p => new PartyDummy { Id = p.Id, Party_Name = p.Party_Name, Location = p.Location, PhoneNumber = p.PhoneNumber, FaxNumber = p.FaxNumber, OwnerName = p.OwnerName, Email = p.Email }).OrderBy(t => t.Party_Name).ToList();

            }
        }
        public List<ProjectDummy> GetProjectsDummy()
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                return db.Projects.Select(p => new ProjectDummy { Id = p.Id, ProjectName = p.ProjectName, OwnerParty = p.Party.Party_Name, Status = p.Status, Credit = p.Credit, EstimatedStartDate = p.EstimatedStartDate, StartDate = p.StartDate, EstimatedEndDate = p.EstimatedEndDate, EndDate = p.EndDate, InitialBalance = p.InitialBalance, CurrentBalance = p.CurrentBalance }).OrderBy(t => t.ProjectName).ToList();
            }
        }

        // /////////////////////    ENDED PROJECTS   /////////////////////////

        public List<Project> EndedProjects()
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                return db.Projects.Where(p => p.Status.Equals("Ended")).OrderBy(t => t.ProjectName).ToList();
                
            }
        }

                // /////////////////////    ONGOING PROJECTS   /////////////////////////

        public List<Project> OngoinProjects()
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
              //  return db.Projects.Where(p => p.Status.Equals("Ongoing")).ToList();
                return db.Projects.Where(p => p.Status.Equals("Ongoing")).OrderBy(t => t.ProjectName).ToList();
            }
        }

        ///////////////////////    ONGOING PROJECTS   /////////////////////////

        public List<Project> getPendingProjects()
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                return db.Projects.Where(p => p.Status.Equals("Pending")).OrderBy(t => t.ProjectName).ToList();
                
            }
        }

        
        

        public Party GetCompanyByName(string name)
        {
         ZamsEntities6 db = new ZamsEntities6();
            return db.Parties.Where(p => p.Party_Name.Equals(name)).FirstOrDefault();
        }
        public Project GetProjectByName(string name)
        {
            Project proj = new Project();
            ZamsEntities6 db = new ZamsEntities6();
          
            proj = db.Projects.Where(p => p.ProjectName.Equals(name)).FirstOrDefault();

            return proj;
        }

        public List<Party> getCompanies1()
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                return db.Parties.Where(p => p.Party_Name != "Zakriya Construction").OrderBy(t => t.Party_Name).ToList();

            }
        }
        public List<Project> GetProjects()
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                return db.Projects.OrderBy(t=>t.ProjectName).ToList();

            }
        }
        public List<Project> GetProjects(String clientName)
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                return db.Projects.Where(p => p.Party.Party_Name.Equals(clientName)).OrderBy(t => t.ProjectName).ToList();
            }
        }
        public int SaveCompany(Party party)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                db.Parties.Add(party);
                return db.SaveChanges();
            }


        }
        public int SaveProject(Project proj)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                db.Projects.Add(proj);
                return db.SaveChanges();
            }

        }
        public string getCompanyId(string name)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                Party id = db.Parties.Where(p => p.Party_Name.Equals(name)).First();
                return id.Id.ToString();
            }


        }
        public string getProjectId(string name)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                Project project = db.Projects.Where(p => p.ProjectName.Equals(name)).First()  ;
                return project.Id.ToString();

            }

        }
        public int UpdateParty(Party p)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                db.Parties.Attach(p);
                return db.SaveChanges();
            }
        }
        //         Save Transaction in case of bill
        public int SaveTransaction(Transaction transaction, bool reverse)
        {
            ZamsEntities6 db = new ZamsEntities6();

            using (db)
            {

                try
                {
                    Transaction last = null;
                    Project proj = db.Projects.Find(transaction.ProjectId);
                    Party p1 = db.Parties.Find(transaction.PartyId);
                    List<Transaction> tr = db.Transactions.Where(t => t.PartyId == transaction.PartyId && t.ProjectId == transaction.ProjectId).ToList();
                    last = tr.LastOrDefault(t => t.PartyId == transaction.PartyId);
                    if (p1.CompanyBalance == null)
                    {
                        if (transaction.TransactionType.Equals("Credit"))
                        {
                            p1.CompanyBalance = -1 * transaction.Amount;
                            transaction.CompanyBalance = p1.CompanyBalance;
                        }
                        else
                        {
                            p1.CompanyBalance = transaction.Amount;
                            transaction.CompanyBalance = p1.CompanyBalance;
                        }

                    }
                    else
                    {
                        if (transaction.TransactionType.Equals("Credit"))
                        {
                            p1.CompanyBalance = p1.CompanyBalance - transaction.Amount;
                            transaction.CompanyBalance = p1.CompanyBalance;
                        }
                        else
                        {
                            p1.CompanyBalance = p1.CompanyBalance + transaction.Amount;
                            transaction.CompanyBalance = p1.CompanyBalance;
                        }
                    }

                    if (last != null)
                    {
                        if (transaction.TransactionType.Equals("Credit"))
                            transaction.TransactionBalance = last.TransactionBalance - transaction.Amount;
                        else
                            transaction.TransactionBalance = last.TransactionBalance + transaction.Amount;
                    }
                    else if (transaction.TransactionType.Equals("Credit"))
                        transaction.TransactionBalance = -1 * transaction.Amount;
                    else
                        transaction.TransactionBalance = transaction.Amount;

                    List<Party> listparty = db.Parties.Where(p => p.Id.Equals(transaction.PartyId)).ToList();
                    Party pVendor = listparty.LastOrDefault();
                    if (pVendor.CompanyType.Equals("Vendor"))
                    {
                        if (transaction.TransactionType.Equals("Credit"))
                        {
                            proj.CurrentBalance -= transaction.Amount;
                            transaction.Balance = proj.CurrentBalance;


                        }
                        else if (transaction.TransactionType.Equals("Debit"))
                        {
                            proj.CurrentBalance += transaction.Amount;
                            transaction.Balance = proj.CurrentBalance;

                        }
                        else
                        {
                            transaction.Balance = proj.CurrentBalance;
                        }
                    }

                    db.Transactions.Add(transaction);
          
                    var check = db.ContractParties.Where(p => p.PartyId == transaction.PartyId && p.ProjectId == transaction.ProjectId).ToList();
                    if (check.Count == 0)
                    {
                        ContractParty cp = new ContractParty();
                        cp.ProjectId = transaction.ProjectId;
                        cp.PartyId = transaction.PartyId;
                        db.ContractParties.Add(cp);
                    }

                    if (reverse == true)
                    {
                        List<Transaction> list1 = db.Transactions.ToList();
                        Transaction refTr = list1.LastOrDefault();
                        db.SaveChanges();

                       
                        ReverseEntry rev1 = new ReverseEntry();
                        rev1.Amount = transaction.Amount;
                        if (refTr != null)
                        {
                            rev1.ReverseID = refTr.Id + 1;
                        }
                        else
                            rev1.ReverseID = 1;

                        rev1.TableName = "Project";
                        rev1.TransactionID = (int)rev1.ReverseID;
                        rev1.trDate = transaction.DateTime;
                        db.ReverseEntries.Add(rev1);
                    }
                    ////////
                    int status = db.SaveChanges();
                    //contextTransaction.Commit();
                    return status;
                }
                catch (Exception exc)
                {
                    //contextTransaction.Rollback();
                    return 0;
                }

            }
        }
        ////////////
        public int SaveTransaction(Transaction transaction, PettyCash pattyTransaction,bool reverse)
        {
         ZamsEntities6 db = new ZamsEntities6();

            using (db)
            {
                
                    try
                    {
                        Transaction last = null;
                        Project proj = db.Projects.Find(transaction.ProjectId);
                        Party p1 = db.Parties.Find(transaction.PartyId);
                        List<Transaction> tr = db.Transactions.Where(t => t.PartyId == transaction.PartyId && t.ProjectId == transaction.ProjectId).ToList();
                        last = tr.LastOrDefault(t => t.PartyId == transaction.PartyId);
                        if (p1.CompanyBalance == null)
                        {
                             if(transaction.TransactionType.Equals("Credit"))
                             {
                                 p1.CompanyBalance=-1*transaction.Amount;
                                 transaction.CompanyBalance=p1.CompanyBalance;
                             }
                            else
                             {
                                 p1.CompanyBalance=transaction.Amount;
                                 transaction.CompanyBalance=p1.CompanyBalance;
                             }

                        }
                        else
                        {
                            if (transaction.TransactionType.Equals("Credit"))
                            {
                                p1.CompanyBalance =  p1.CompanyBalance - transaction.Amount;
                                transaction.CompanyBalance = p1.CompanyBalance;
                            }
                            else
                            {
                                p1.CompanyBalance = p1.CompanyBalance + transaction.Amount;
                                transaction.CompanyBalance = p1.CompanyBalance;
                            }
                        }
                        if (last != null)
                        {
                            if(transaction.TransactionType.Equals("Credit"))
                                transaction.TransactionBalance=last.TransactionBalance-transaction.Amount;
                            else
                                transaction.TransactionBalance = last.TransactionBalance + transaction.Amount;
                        }
                        else if (transaction.TransactionType.Equals("Credit"))
                            transaction.TransactionBalance = -1 * transaction.Amount ;
                        else
                            transaction.TransactionBalance = transaction.Amount;
                        List<Party> listparty = db.Parties.Where(p => p.Id.Equals(transaction.PartyId)).ToList();
                        Party pVendor = listparty.LastOrDefault();
                        if (pVendor.CompanyType.Equals("Vendor"))
                        {
                            if (transaction.TransactionType.Equals("Credit") && transaction.PaymentType.Equals("Cash"))
                            {
                                proj.CurrentBalance -= transaction.Amount;
                                transaction.Balance = proj.CurrentBalance;


                            }
                            else if (transaction.TransactionType.Equals("Debit") && transaction.PaymentType.Equals("Cash"))
                            {
                                proj.CurrentBalance += transaction.Amount;
                                transaction.Balance = proj.CurrentBalance;

                            }
                            else
                            {
                                transaction.Balance = proj.CurrentBalance;
                            }
                        }
                        
                        db.Transactions.Add(transaction);

                        var check = db.ContractParties.Where(p => p.PartyId == transaction.PartyId && p.ProjectId == transaction.ProjectId).ToList();
                        if (check.Count==0)
                        {
                            ContractParty cp = new ContractParty();
                            cp.ProjectId = transaction.ProjectId;
                            cp.PartyId = transaction.PartyId;
                            db.ContractParties.Add(cp);
                        }
                        ////// Save Patty Transaction
                        List<PettyCash> lastpetty = db.PettyCashes.ToList();
                       
                        if (lastpetty.Count>0)
                        {
                            PettyCash ptlast = lastpetty.LastOrDefault();
                            if(pattyTransaction.TransactionType.Equals("Credit"))
                                pattyTransaction.Balance = ptlast.Balance - pattyTransaction.Amount;
                            else
                                pattyTransaction.Balance = ptlast.Balance + pattyTransaction.Amount;
                        }
                        else
                        {
                            if (pattyTransaction.TransactionType.Equals("Credit"))
                                pattyTransaction.Balance = -1*pattyTransaction.Amount;
                            else
                                pattyTransaction.Balance = pattyTransaction.Amount;
                        }

                        List<Transaction> list1 = db.Transactions.ToList();
                        Transaction refTr = list1.LastOrDefault();
                        if (refTr != null)
                        {
                            pattyTransaction.RefID = (refTr.Id + 1).ToString();
                        }else
                            pattyTransaction.RefID = 1+"";

                      
                        
                        db.PettyCashes.Add(pattyTransaction);
                        


                        //////////
                        if (reverse == true)
                        {
                            pattyTransaction.RefID = pattyTransaction.RefID + " Rev";
                            ReverseEntry rev1 = new ReverseEntry();
                            rev1.Amount = transaction.Amount;
                            if (refTr != null)
                            {
                                rev1.ReverseID = refTr.Id + 1;
                            }else
                                rev1.ReverseID = 1;

                            rev1.TableName = "Project";
                            rev1.TransactionID = (int)rev1.ReverseID;
                            rev1.trDate = transaction.DateTime;
                          //  db.SaveChanges();
                            ReverseEntry rev2 = new ReverseEntry();
                            rev2.Amount =pattyTransaction.Amount;
                            List<PettyCash> plist = db.PettyCashes.ToList();
                            PettyCash plast = plist.LastOrDefault();
                          if (plast != null)
                            {
                                rev2.ReverseID = plast.Id + 1;
                            }else
                                rev2.ReverseID = 1;

                            rev2.TableName = "Petty";
                            rev2.trDate = pattyTransaction.TransactionDate;
                            db.SaveChanges();
                            db.ReverseEntries.Add(rev1);

                            db.ReverseEntries.Add(rev2);
                        }

                        ////////
                        int status = db.SaveChanges();
                        //contextTransaction.Commit();
                        return status;
                    }
                    catch (Exception exc)
                    {
                        //contextTransaction.Rollback();
                        return 0;
                    }
                
            }
        }

        ////////////
        public int SaveTransaction(Transaction transaction, BankTransaction bankTransaction,bool reverse)
        {
            ZamsEntities6 db = new ZamsEntities6();

            using (db)
            {

                try
                {
                    Transaction last = null;
                    Project proj = db.Projects.Find(transaction.ProjectId);
                    Party p1 = db.Parties.Find(transaction.PartyId);
                    List<Transaction> tr = db.Transactions.Where(t => t.PartyId == transaction.PartyId && t.ProjectId == transaction.ProjectId).ToList();
                    last = tr.LastOrDefault(t => t.PartyId == transaction.PartyId);
                    if (p1.CompanyBalance == null)
                    {
                        if (transaction.TransactionType.Equals("Credit"))
                        {
                            p1.CompanyBalance = -1 * transaction.Amount;
                            transaction.CompanyBalance = p1.CompanyBalance;
                        }
                        else
                        {
                            p1.CompanyBalance = transaction.Amount;
                            transaction.CompanyBalance = p1.CompanyBalance;
                        }

                    }
                    else
                    {
                        if (transaction.TransactionType.Equals("Credit"))
                        {
                            p1.CompanyBalance = p1.CompanyBalance - transaction.Amount;
                            transaction.CompanyBalance = p1.CompanyBalance;
                        }
                        else
                        {
                            p1.CompanyBalance = p1.CompanyBalance + transaction.Amount;
                            transaction.CompanyBalance = p1.CompanyBalance;
                        }
                    }
                    if (last != null)
                    {
                        if (transaction.TransactionType.Equals("Credit"))
                            transaction.TransactionBalance = last.TransactionBalance - transaction.Amount;
                        else
                            transaction.TransactionBalance = last.TransactionBalance + transaction.Amount;
                    }
                    else if (transaction.TransactionType.Equals("Credit"))
                        transaction.TransactionBalance = -1 * transaction.Amount;
                    else
                        transaction.TransactionBalance = transaction.Amount;
                    List<Party> listparty = db.Parties.Where(p => p.Id.Equals(transaction.PartyId)).ToList();
                    Party pVendor = listparty.LastOrDefault();
                    if (pVendor.CompanyType.Equals("Vendor"))
                    {
                        if (transaction.TransactionType.Equals("Credit") && transaction.PaymentType.Equals("Cash"))
                        {
                            proj.CurrentBalance -= transaction.Amount;
                            transaction.Balance = proj.CurrentBalance;


                        }
                        else if (transaction.TransactionType.Equals("Debit") && transaction.PaymentType.Equals("Cash"))
                        {
                            proj.CurrentBalance += transaction.Amount;
                            transaction.Balance = proj.CurrentBalance;

                        }
                        else
                        {
                            transaction.Balance = proj.CurrentBalance;
                        }
                    }

                 
                    
                    db.Transactions.Add(transaction);
                    
                    
                    var check = db.ContractParties.Where(p => p.PartyId == transaction.PartyId && p.ProjectId == transaction.ProjectId).ToList();
                    if (check.Count == 0)
                    {
                        ContractParty cp = new ContractParty();
                        cp.ProjectId = transaction.ProjectId;
                        cp.PartyId = transaction.PartyId;
                        db.ContractParties.Add(cp);
                    }
                    
                    
                    ///////////////// Save Bank Transaction


                    Bank b = db.Banks.FirstOrDefault(b1 => b1.Id == bankTransaction.BankId);
                    Bank center = db.Banks.Where(p => p.AccountNumber.Equals("999999") && p.Branch.Equals("RSS")).FirstOrDefault();
                    if (b != null && center!=null)
                    {
                        if (bankTransaction.TransactionType.Equals("Credit"))
                        {
                            bankTransaction.Balance = b.Balance - bankTransaction.Amount;
                            b.Balance = bankTransaction.Balance;
                            bankTransaction.AllBankBalance = center.Balance - bankTransaction.Amount;
                            center.Balance = bankTransaction.AllBankBalance;
                        }
                        else
                        {
                            bankTransaction.AllBankBalance = center.Balance + bankTransaction.Amount;
                            center.Balance = bankTransaction.AllBankBalance;
                            bankTransaction.Balance = b.Balance + bankTransaction.Amount;
                            b.Balance = bankTransaction.Balance;
                        }
                    }
                    else 
                        return 0;
                   // bankTransaction.AllBankBalance = 0;
                    List<Transaction> list1 = db.Transactions.ToList();
                    Transaction refTr = list1.LastOrDefault();
                    if (refTr != null)
                    {
                        bankTransaction.RefID = (refTr.Id + 1).ToString();
                    }else
                        bankTransaction.RefID = 1+"";


                    db.BankTransactions.Add(bankTransaction);
                    
                    

                    //////////////
                    if (reverse == true)
                    {

                        bankTransaction.RefID = bankTransaction.RefID + " Rev";
                        ReverseEntry rev1 = new ReverseEntry();
                        rev1.Amount = transaction.Amount;
                        if (refTr != null)
                        {
                            rev1.ReverseID = refTr.Id + 1;
                        }else
                            rev1.ReverseID =  1;

                        rev1.TableName = "Project";
                        rev1.TransactionID =(int) rev1.ReverseID;
                        rev1.trDate = transaction.DateTime;
                        ReverseEntry rev2 = new ReverseEntry();
                        rev2.Amount = bankTransaction.Amount;
                        List<BankTransaction> blist = db.BankTransactions.ToList();
                       BankTransaction blast = blist.LastOrDefault();
                       if (blast != null)
                       {
                           rev2.ReverseID = blast.Id + 1;
                       }else
                           rev2.ReverseID = 1;

                        rev2.TableName = "Bank";
                        rev2.trDate = bankTransaction.TransactionDate;
                        db.SaveChanges();
                        db.ReverseEntries.Add(rev1);

                        db.ReverseEntries.Add(rev2);
                    }

                    ////////////////
                    int status = db.SaveChanges();
                    //contextTransaction.Commit();
                    return status;
                }
                catch (Exception exc)
                {
                    //contextTransaction.Rollback();
                    return 0;
                }

            }
        }

        
         ////////
        public int SaveTransactionPattyBank(BankTransaction bankTransaction, PettyCash pattyTransaction,bool reverse)
        {
            ZamsEntities6 db = new ZamsEntities6();

            using (db)
            {

                try
                {
                    ///////////////// Save Bank Transaction
                    Bank b = db.Banks.FirstOrDefault(b1 => b1.Id == bankTransaction.BankId);
                    Bank center = db.Banks.Where(p => p.AccountNumber.Equals("999999") && p.Branch.Equals("RSS")).FirstOrDefault();
                    if (b != null)
                    {
                        if (bankTransaction.TransactionType.Equals("Credit"))
                        {
                            bankTransaction.Balance = b.Balance - bankTransaction.Amount;
                            b.Balance = bankTransaction.Balance;
                            bankTransaction.AllBankBalance = center.Balance - bankTransaction.Amount;
                            center.Balance = bankTransaction.AllBankBalance;

                        }
                        else
                        {
                            bankTransaction.Balance = b.Balance + bankTransaction.Amount;
                            b.Balance = bankTransaction.Balance;
                            bankTransaction.AllBankBalance = center.Balance + bankTransaction.Amount;
                            center.Balance = bankTransaction.AllBankBalance;
                        }
                    }
                   // bankTransaction.AllBankBalance = 0;
                     List<PettyCash> plist = db.PettyCashes.ToList();
                    PettyCash ptr = plist.LastOrDefault();
                    if (ptr != null)
                    {
                        bankTransaction.RefID = ptr.Id + 1 + " Pty";
                    }else
                        bankTransaction.RefID =1 + " Pty";

                    db.BankTransactions.Add(bankTransaction);

                    ////////////////
                    ////// Save Patty Transaction
                    List<PettyCash> lastpetty = db.PettyCashes.ToList();
                    if (lastpetty.Count > 0)
                    {
                        PettyCash ptlast = lastpetty.LastOrDefault();
                        if (pattyTransaction.TransactionType.Equals("Credit"))
                            pattyTransaction.Balance = ptlast.Balance - pattyTransaction.Amount;
                        else
                            pattyTransaction.Balance = ptlast.Balance + pattyTransaction.Amount;
                    }
                    else
                    {
                        if (pattyTransaction.TransactionType.Equals("Credit"))
                            pattyTransaction.Balance = -1 * pattyTransaction.Amount;
                        else
                            pattyTransaction.Balance = pattyTransaction.Amount;
                    }
                    List<BankTransaction> blist = db.BankTransactions.ToList();
                    BankTransaction btr = blist.LastOrDefault();
                    if (btr != null)
                    {
                        pattyTransaction.RefID = btr.Id + 1 + " Bank";
                    }else
                        pattyTransaction.RefID = 1 + " Bank";

                   
                    //////// reverse check
                    if (reverse == true)
                    {
                        bankTransaction.RefID = bankTransaction.RefID + " R";
                        pattyTransaction.RefID = pattyTransaction.RefID + " R";
                        ReverseEntry rev1 = new ReverseEntry();
                        rev1.Amount =pattyTransaction.Amount;
                        PettyCash ptlast = lastpetty.LastOrDefault();
                        if (ptlast != null)
                        {
                            rev1.ReverseID = ptlast.Id + 1;
                        }else
                            rev1.ReverseID =  1;

                        rev1.TableName = "Petty";
                        rev1.trDate = pattyTransaction.TransactionDate;
                        db.ReverseEntries.Add(rev1);
                        ReverseEntry rev2 = new ReverseEntry();
                        rev2.Amount = bankTransaction.Amount;
                     //   List<BankTransaction> blist = new List<BankTransaction>();
                    //    BankTransaction blast = blist.LastOrDefault();
                        if (btr != null)
                        {
                            rev2.ReverseID = btr.Id + 1;
                        }else
                            rev2.ReverseID =1;

                        rev2.TableName = "Bank";
                        rev2.trDate = bankTransaction.TransactionDate;
                        db.ReverseEntries.Add(rev2);
                    }
                   // db.BankTransactions.
                    db.PettyCashes.Add(pattyTransaction);
                    ////////
                    int status = db.SaveChanges();
                    //contextTransaction.Commit();
                    return status;

                }
             catch (Exception exc)
                {
                    //contextTransaction.Rollback();
                    return 0;
                }
          }
        }

       //
        public List<Party> getContractParty(string id)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                Project p1 = db.Projects.FirstOrDefault(p => p.ProjectName.Equals(id));
                List<ContractParty> ids = db.ContractParties.Where(p => p.ProjectId == p1.Id).ToList();
                List<Party> Parties = new List<Party>();
                foreach (ContractParty a in ids)
                {
                    Parties.Add(db.Parties.FirstOrDefault(p => p.Id == a.PartyId));
                }
                return Parties;
            }
        }
        public List<Transaction> getTransactions(System.DateTime startDate, System.DateTime endDate, int projectId, int partyId)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                return null;
                //List<Transaction> transactions = db.Transactions.Where(p => p.DateTime >= startDate && p.DateTime <= endDate && p.ProjectId == projectId && p.PayerId == partyId && p.RecipientId == partyId).ToList();
                //return transactions;
            }
        }
        public List<TransactionOnlyDummy> getTransactionByTime(DateTime startDate, DateTime endDate)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                List<Transaction> transactions = db.Transactions.Where(p => p.DateTime >= startDate && p.DateTime <= endDate && p.Party.CompanyType.Equals("Vendor")).ToList();//Select(p => new TransactionDummy { RefId = p.Id, Date = p.DateTime.Date, Amount = p.Amount, TransactionType = p.TransactionType, Description = p.Description, CheNumber = p.OtherDetails, ProjectName = p.Project.ProjectName, PartyName = p.Party.Party_Name }).ToList();
                List<TransactionOnlyDummy> transactionsdumy = new List<TransactionOnlyDummy>();
                long debitTotal = 0, creditTotal = 0;
                foreach(Transaction t in transactions)
                {
                    TransactionOnlyDummy td = new TransactionOnlyDummy();
                    td.Date = t.DateTime.Date;
                    td.RefId = t.Id;
                   // string name=t.Party.
                    td.Cheque_No = t.OtherDetails;
                    td.Description = t.Description;
                    td.Party = t.Party.Party_Name;
                    td.Project = t.Project.ProjectName;

                    td.UserName = t.UserName;

                    if (t.TransactionType.Equals("Credit"))
                    {
                      //  if (t.PaymentType != "Bill")
                       // {
                            creditTotal = creditTotal + t.Amount;
                       // }
                        td.Credit = String.Format("{0:n}", t.Amount);
                        //td.Debit = 0;
                    }
                    else
                    {
                       // if (t.PaymentType != "Bill")
                      //  {
                            debitTotal = debitTotal + t.Amount;
                       // }
                        td.Debit = String.Format("{0:n}", t.Amount);
                       // td.Credit = 0;
                    }
                   // td.Balance = t.Balance;
                    transactionsdumy.Add(td);

                }
                TransactionOnlyDummy ttd = new TransactionOnlyDummy();
                ttd.Description = "Total";
                ttd.Debit = String.Format("{0:n}", debitTotal);
                ttd.Credit = String.Format("{0:n}", creditTotal);
                transactionsdumy.Add(ttd);
                long reverseAmount = 0;
                TransactionOnlyDummy tdr = new TransactionOnlyDummy();
                tdr.Debit = String.Format("{0:n}", reverseAmount);
                tdr.Credit = String.Format("{0:n}", reverseAmount);
                tdr.Description = "Reverse Amount";
                if (db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.trDate >= startDate && r.trDate < endDate && r.Transaction.Party.CompanyType.Equals("Vendor")).ToList().Count != 0)
                {
                   
                    ///// revrese Amount
                    reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.trDate >= startDate && r.trDate < endDate && r.Transaction.Party.CompanyType.Equals("Vendor")).Sum(r => r.Amount);
                   // TransactionOnlyDummy tdr = new TransactionOnlyDummy();
                    tdr.Debit = String.Format("{0:n}", reverseAmount);
                    tdr.Credit = String.Format("{0:n}", reverseAmount);
                   // tdr.Description = "Reverse Amount";
                   
                }
                transactionsdumy.Add(tdr);
                TransactionOnlyDummy tdnet = new TransactionOnlyDummy();
                tdnet.Debit = String.Format("{0:n}", debitTotal - reverseAmount);
                tdnet.Credit = String.Format("{0:n}", creditTotal - reverseAmount);
                tdnet.Description = "Net Total";
                transactionsdumy.Add(tdnet);

                ////////
                return transactionsdumy;
               // return null;
            }
        }
        public string getprojectName(int id)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                Project projects = db.Projects.Where(p => p.Id == id).First();
                return projects.ProjectName;
            }
        }
        public List<TransactionDummy> GetTransactionsByCompany(int companyId,DateTime startDate,DateTime endDate)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
               // return null;
                List<Transaction> transactions = db.Transactions.Where(p => p.Party.Id == companyId && p.DateTime >= startDate && p.DateTime <= endDate).ToList();//Select(p => new TransactionDummy { Id = p.Id, DateTime = p.DateTime, Amount = p.Amount, TransactionType = p.TransactionType, Description = p.Description, CheckNumber = p.OtherDetails, ProjectName = p.Project.ProjectName, PartyName = p.Party.Party_Name }).ToList();
                List<TransactionDummy> transactionsdumy = new List<TransactionDummy>();
                long debitTotal = 0, creditTotal = 0;
                foreach (Transaction t in transactions)
                {
                    TransactionDummy td = new TransactionDummy();
                    td.Date = t.DateTime.Date;
                    td.RefId = t.Id;
                    td.Cheque_No = t.OtherDetails;
                    td.Description = t.Description;
                    td.PartyORProject = t.Project.ProjectName;
                   
                    td.UserName = t.UserName;

                    td.Balance =  String.Format("{0:n}",t.CompanyBalance);
                    if (t.TransactionType.Equals("Credit"))
                    {
                        creditTotal = creditTotal + t.Amount;
                        td.Credit = String.Format("{0:n}", t.Amount);
                      //  td.Debit = 0;
                    }
                    else
                    {
                        debitTotal = debitTotal + t.Amount;
                        td.Debit = String.Format("{0:n}", t.Amount);
                       // td.Credit = 0;
                    }
                   // td.Balance = t.Balance;
                    transactionsdumy.Add(td);
                }
                long reverseAmount = 0;
                if (db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.Party.Id.Equals(companyId) && r.trDate >= startDate && r.trDate < endDate).ToList().Count != 0)
                {



                    reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.Party.Id.Equals(companyId) && r.trDate >= startDate && r.trDate < endDate).Sum(r => r.Amount);

                }
                TransactionDummy ttd = new TransactionDummy();
                ttd.Description = "Total";
                ttd.Debit = String.Format("{0:n}", debitTotal-reverseAmount);
                ttd.Credit = String.Format("{0:n}", creditTotal-reverseAmount);
                transactionsdumy.Add(ttd);
                return transactionsdumy;
            }
        }
        public List<TransactionDummy> GetTransactionsByProject(int projectId,DateTime startDate,DateTime endDate)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                //return null;
                List<Transaction> transactions = db.Transactions.Where(p => p.Project.Id == projectId&&p.DateTime >= startDate && p.DateTime <= endDate && p.Party.CompanyType.Equals("Vendor")).ToList();//Select(p => new TransactionDummy { Id = p.Id, DateTime = p.DateTime, Amount = p.Amount, TransactionType = p.TransactionType, Description = p.Description, CheckNumber = p.OtherDetails, ProjectName = p.Project.ProjectName, PartyName = p.Party.Party_Name  }).ToList();
                List<TransactionDummy> transactionsdumy = new List<TransactionDummy>();
                long debitTotal = 0, creditTotal = 0;
                foreach (Transaction t in transactions)
                {
                    TransactionDummy td = new TransactionDummy();
                    td.Date = t.DateTime.Date;
                    td.RefId = t.Id;
                    td.Cheque_No = t.OtherDetails;
                    td.Description = t.Description;
                    td.PartyORProject = t.Party.Party_Name;

                    td.UserName = t.UserName;

                    if (t.TransactionType.Equals("Credit"))
                    {
                        creditTotal = creditTotal + t.Amount;
                        td.Credit = String.Format("{0:n}", t.Amount);
                      //  td.Debit = 0;
                    }
                    else
                    {
                        debitTotal = debitTotal + t.Amount;
                        td.Debit = String.Format("{0:n}", t.Amount);
                        //td.Credit = 0;
                    }
                    td.Balance = String.Format("{0:n}", t.Balance); 
                    transactionsdumy.Add(td);
                }
                long reverseAmount = 0;
                if (db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.Project.Id.Equals(projectId) && r.trDate >= startDate && r.trDate < endDate).ToList().Count != 0)
                {



                    reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.Project.Id.Equals(projectId) && r.trDate >= startDate && r.trDate < endDate).Sum(r => r.Amount);

                }
                TransactionDummy ttd = new TransactionDummy();
                ttd.Description = "Total";
                ttd.Debit = String.Format("{0:n}", debitTotal-reverseAmount);
                ttd.Credit = String.Format("{0:n}", creditTotal-reverseAmount);
                transactionsdumy.Add(ttd);
                return transactionsdumy;
                // return null;
                }
        }
        public List<TransactionDummy> GetTransactionsByCompanyAndProject(int companyId, int projectId, DateTime startDate, DateTime endDate)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                //return null;
                List<Transaction> transactions = db.Transactions.Where(p => p.Project.Id == projectId && (p.Party.Id == companyId) && p.DateTime >= startDate && p.DateTime <= endDate).ToList();//Select(p => new TransactionDummy { Id = p.Id, DateTime = p.DateTime, Amount = p.Amount, TransactionType = p.TransactionType, Description = p.Description, CheckNumber = p.OtherDetails, ProjectName = p.Project.ProjectName, PartyName = p.Party.Party_Name }).ToList();
                List<TransactionDummy> transactionsdumy = new List<TransactionDummy>();
                long debitTotal = 0, creditTotal = 0;
                foreach (Transaction t in transactions)
                {
                    TransactionDummy td = new TransactionDummy();
                    td.Date = t.DateTime.Date;
                    td.RefId = t.Id;
                    td.Cheque_No = t.OtherDetails;
                    td.Description = t.Description;
                    td.PartyORProject = t.Party.Party_Name;

                    td.UserName = t.UserName;

                    if (t.TransactionType.Equals("Credit"))
                    {
                        creditTotal = creditTotal + t.Amount;
                        td.Credit = String.Format("{0:n}", t.Amount);
                        //td.Debit = 0;
                    }
                    else
                    {
                        debitTotal = debitTotal + t.Amount;
                        td.Debit = String.Format("{0:n}", t.Amount);
                        //td.Credit = 0;
                    }
                    td.Balance = String.Format("{0:n}", t.TransactionBalance);
                    transactionsdumy.Add(td);
                }
                long reverseAmount = 0;
                if (db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.Project.Id.Equals(projectId)&&r.Transaction.Party.Id.Equals(companyId) && r.trDate >= startDate && r.trDate < endDate).ToList().Count != 0)
                {



                    reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.Project.Id.Equals(projectId)&&r.Transaction.Party.Id.Equals(companyId) && r.trDate >= startDate && r.trDate < endDate).Sum(r => r.Amount);

                }
                TransactionDummy ttd = new TransactionDummy();
                ttd.Description = "Total";
                ttd.Debit = String.Format("{0:n}", debitTotal);
                ttd.Credit = String.Format("{0:n}", creditTotal);
                transactionsdumy.Add(ttd);
                return transactionsdumy;
                // return null;
            }
        }


        public List<long> getPaidAmountAll()
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                //return null;
                //long pay = 0, received = 0;
                ////int id = int.Parse(getCompanyId("Zakriya Construction"));
                //if (db.Transactions.Where(p => p.PayerId == id).ToList().Count != 0)
                //    pay = db.Transactions.Where(p => p.PayerId == id).Sum(p => p.Amount);
                //if (db.Transactions.Where(p => p.RecipientId == id).ToList().Count != 0)
                //    received = db.Transactions.Where(p => p.RecipientId == id).Sum(p => p.Amount);
                //
                long pay = 0, received = 0;
                if (db.Transactions.Where(p => p.TransactionType.Equals("Credit") && p.Party.CompanyType.Equals("Vendor")).ToList().Count != 0)
                {
                    received = db.Transactions.Where(p => p.TransactionType.Equals("Credit") && p.Party.CompanyType.Equals("Vendor")).Sum(p => p.Amount);
                }
                if (db.Transactions.Where(p => p.TransactionType.Equals("Debit") && p.Party.CompanyType.Equals("Vendor")).ToList().Count != 0)
                {
                    pay = db.Transactions.Where(p => p.TransactionType.Equals("Debit") && p.Party.CompanyType.Equals("Vendor")).Sum(p => p.Amount);
                }
                List<long> a = new List<long>();
                long reverseAmount = 0;
                if (db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor")).ToList().Count != 0)
                {



                    reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor")).Sum(r => r.Amount);
                }
                a.Add(pay-reverseAmount);
                a.Add(received-reverseAmount);
                return a;
            }
        }

        public List<TransactionOnlyDummy> GetTransactionOnlyDummy()
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                //return null;
                List<Transaction> transactions = db.Transactions.Where(p=>p.Party.CompanyType.Equals("Vendor")).ToList();//Select(p => new TransactionDummy { RefId = p.Id, Date= p.DateTime, Amount = p.Amount, TransactionType = p.TransactionType, Description = p.Description, CheckNumber = p.OtherDetails, ProjectName = p.Project.ProjectName, PartyName = p.Party.Party_Name }).ToList();
                List<TransactionOnlyDummy> transactionsdumy = new List<TransactionOnlyDummy>();
                long debitTotal = 0, creditTotal = 0;
                foreach (Transaction t in transactions)
                {
                    TransactionOnlyDummy td = new TransactionOnlyDummy();
                    td.Date = t.DateTime.Date;
                    td.RefId = t.Id;
                    td.Cheque_No = t.OtherDetails;
                    td.Description = t.Description;
                    td.Party = t.Party.Party_Name;
                    td.Project = t.Project.ProjectName;

                    td.UserName = t.UserName;

                    
                        if (t.TransactionType.Equals("Credit"))
                        {
                          //  if (t.PaymentType != "Bill")
                          //  {
                                  creditTotal = creditTotal + t.Amount;
                           // }
                            td.Credit = String.Format("{0:n}", t.Amount);
                            //  td.Debit = 0;
                        }
                        else
                        {
                           // if (t.PaymentType != "Bill")
                           // {
                                 debitTotal = debitTotal + t.Amount;
                          //  }
                            td.Debit = String.Format("{0:n}", t.Amount);
                            // td.Credit = 0;
                        }
                    
                    
                   // td.Balance = t.Balance;
                    transactionsdumy.Add(td);
                }

                TransactionOnlyDummy ttd = new TransactionOnlyDummy();
                ttd.Description = "Total";
                ttd.Debit = String.Format("{0:n}", debitTotal);
                ttd.Credit = String.Format("{0:n}", creditTotal);
                transactionsdumy.Add(ttd);

                 long   reverseAmount=0;
                 TransactionOnlyDummy tdr = new TransactionOnlyDummy();
                 tdr.Debit = String.Format("{0:n}", reverseAmount);
                 tdr.Credit = String.Format("{0:n}", reverseAmount);
                 tdr.Description = "Reverse Amount";
               

                if (db.ReverseEntries.Where(r => r.TableName.Equals("Project")&& r.Transaction.Party.CompanyType.Equals("Vendor")).ToList().Count != 0)
                {

                    reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor")).Sum(r => r.Amount);
                    // TransactionOnlyDummy tdr = new TransactionOnlyDummy();
                    tdr.Debit = String.Format("{0:n}", reverseAmount);
                    tdr.Credit = String.Format("{0:n}", reverseAmount);
                    // tdr.Description = "Reverse Amount";
             
                }
                 
                transactionsdumy.Add(tdr);
                TransactionOnlyDummy tdnet = new TransactionOnlyDummy();
                tdnet.Debit = String.Format("{0:n}", debitTotal-reverseAmount);
                tdnet.Credit = String.Format("{0:n}",creditTotal-reverseAmount);
                tdnet.Description = "Net Total";
                transactionsdumy.Add(tdnet);

                return transactionsdumy;
            }
        }
        public List<long> getPaidAmountAllproject()
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                long pay = 0, rec = 0;
                if (db.Transactions.Where(p => p.TransactionType.Equals("Debit") && p.Party.CompanyType.Equals("Vendor")).ToList().Count != 0)
                    pay = db.Transactions.Where(p => p.TransactionType.Equals("Debit") && p.Party.CompanyType.Equals("Vendor") ).Sum(p => p.Amount);
                if (db.Transactions.Where(p => p.TransactionType.Equals("Credit") && p.Party.CompanyType.Equals("Vendor")).ToList().Count != 0)
                    rec = db.Transactions.Where(p => p.TransactionType.Equals("Credit") && p.Party.CompanyType.Equals("Vendor") ).Sum(p => p.Amount);
                List<long> a = new List<long>();
                long reverseAmount=0;
                if (db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor")).ToList().Count != 0)
                {



                    reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor")).Sum(r => r.Amount);
                }
                a.Add(pay-reverseAmount);
                a.Add(rec-reverseAmount);
                return a;
            }
        }
        public List<long> getPaidAmount(int id)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                long pay = 0, rec = 0;
                if (db.Transactions.Where(p => p.TransactionType.Equals("Debit") && p.ProjectId == id && p.Party.CompanyType.Equals("Vendor")).ToList().Count != 0)
                    pay = db.Transactions.Where(p => p.TransactionType.Equals("Debit") && p.ProjectId == id && p.Party.CompanyType.Equals("Vendor")).Sum(p => p.Amount);
                if (db.Transactions.Where(p => p.TransactionType.Equals("Credit") && p.ProjectId == id && p.Party.CompanyType.Equals("Vendor")).ToList().Count != 0)
                    rec = db.Transactions.Where(p => p.TransactionType.Equals("Credit") && p.ProjectId == id && p.Party.CompanyType.Equals("Vendor")).Sum(p => p.Amount);
                List<long> a = new List<long>();
                long reverseAmount = 0;
                if (db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor")&&r.Transaction.Project.Id.Equals(id)).ToList().Count != 0)
                {



                    reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor")&&r.Transaction.Project.Id.Equals(id)).Sum(r => r.Amount);
                }
                a.Add(pay-reverseAmount);
                a.Add(rec-reverseAmount);
                return a;
            }
        }
        public int SaveContractParty(int partyId, int projectId)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                ContractParty cp = new ContractParty();
                cp.PartyId = partyId;
                cp.ProjectId = projectId;
                try
                {
                    db.ContractParties.Add(cp);
                    return db.SaveChanges();
                }
                catch (Exception e)
                {
                    return 1;
                }


            }
        }
        public List<ProjectReprt> GetAllProjects(int id)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                long pay;
                long received;
                List<Project> pro = null;
                if (id == -1)
                {
                    pro = db.Projects.ToList();
                    List<ProjectReprt> pr = new List<ProjectReprt>();
                    foreach (Project project in pro)
                    {
                        pay = 0;
                        received = 0;
                        if (db.Transactions.Where(p => p.TransactionType.Equals("Debit") && p.ProjectId == project.Id && p.Party.CompanyType.Equals("Vendor")).ToList().Count != 0)
                            pay = db.Transactions.Where(p => p.TransactionType.Equals("Debit") && p.ProjectId == project.Id && p.Party.CompanyType.Equals("Vendor")).Sum(p => p.Amount);

                        if (db.Transactions.Where(p => p.TransactionType.Equals("Credit") && p.ProjectId == project.Id && p.Party.CompanyType.Equals("Vendor")).ToList().Count != 0)
                            received = db.Transactions.Where(p => p.TransactionType.Equals("Credit") && p.ProjectId == project.Id && p.Party.CompanyType.Equals("Vendor")).Sum(p => p.Amount);
                        ProjectReprt p1 = new ProjectReprt();

                        p1.ProjectName = project.ProjectName;
                        p1.ProjectOwner = project.Party.Party_Name;
                        long reverseAmount = 0;
                        if (db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor")&&r.Transaction.ProjectId.Equals(project.Id)).ToList().Count != 0)
                        {



                            reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor")&&r.Transaction.ProjectId.Equals(project.Id)).Sum(r => r.Amount);
                        }
                        p1.AmountPaid = pay-reverseAmount;

                        p1.AmountReceived = received-reverseAmount;
                        p1.Balance =  pay-received;
                        pr.Add(p1);
                    }
                    return pr;
                }
                else
                {

                    pro = db.ContractParties.Where(p => p.PartyId == id).Select(p => p.Project).ToList();
                    List<ProjectReprt> pr = new List<ProjectReprt>();
                    foreach (Project project in pro)
                    {
                        pay = 0;
                        received = 0;
                        if (db.Transactions.Where(p => p.TransactionType.Equals("Debit") && p.ProjectId == project.Id&& p.PartyId==id).ToList().Count != 0)
                            pay = db.Transactions.Where(p => p.TransactionType.Equals("Debit") && p.ProjectId == project.Id && p.PartyId == id).Sum(p => p.Amount);

                        if (db.Transactions.Where(p => p.TransactionType.Equals("Credit")&& p.ProjectId == project.Id && p.PartyId == id).ToList().Count != 0)
                            received = db.Transactions.Where(p => p.TransactionType.Equals("Credit") && p.ProjectId == project.Id && p.PartyId == id).Sum(p => p.Amount);
                        ProjectReprt p1 = new ProjectReprt();

                        p1.ProjectName = project.ProjectName;
                        p1.ProjectOwner = project.Party.Party_Name;
                        long reverseAmount = 0;
                        if (db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.ProjectId.Equals(project.Id)&&r.Transaction.PartyId.Equals(id)).ToList().Count != 0)
                        {



                            reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.ProjectId.Equals(project.Id)&&r.Transaction.PartyId.Equals(id)).Sum(r => r.Amount);
                        }

                        p1.AmountPaid = pay-reverseAmount;
                        p1.AmountReceived = received-reverseAmount;
                        p1.Balance =  pay-received;
                        pr.Add(p1);
                    }
                    return pr;
                }
                
                //db.Projects.Select(p=>new ProjectReprt{ ProjectName=p.ProjectName,OwnerName=p.Party.Party_Name,AmountPaid=})
            }

        }
        public List<PartyReport> getPartyReport(int id)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
               
                List<Party> party = null;
                if (id == -1)
                {
                    party = db.Parties.Where(p=>p.CompanyType.Equals("Vendor")).ToList();
                    List<PartyReport> pr = new List<PartyReport>();
                    foreach (Party par in party)
                    {
                        long pay = 0;
                        long received = 0;
                        PartyReport partyreport = new PartyReport();
                        if (db.Transactions.Where(p => p.TransactionType.Equals("Credit") && p.PartyId == par.Id && p.Party.CompanyType.Equals("Vendor")).ToList().Count != 0)
                            received = db.Transactions.Where(p => p.TransactionType.Equals("Credit") && p.PartyId == par.Id && p.Party.CompanyType.Equals("Vendor")).Sum(p => p.Amount);
                        if (db.Transactions.Where(p => p.TransactionType.Equals("Debit") && p.PartyId == par.Id && p.Party.CompanyType.Equals("Vendor")).ToList().Count != 0)
                            pay = db.Transactions.Where(p => p.TransactionType.Equals("Debit") && p.PartyId == par.Id && p.Party.CompanyType.Equals("Vendor")).Sum(p => p.Amount);
                        partyreport.PartyName = par.Party_Name;
                        partyreport.PartyOwner = par.OwnerName;
                        long reverseAmount = 0;
                        if (db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.PartyId.Equals(par.Id)).ToList().Count != 0)
                        {



                            reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.PartyId.Equals(par.Id)).Sum(r => r.Amount);
                        }
                        partyreport.AmountPaid = pay-reverseAmount;
                        partyreport.AmountReceived = received-reverseAmount;
                        partyreport.Balance = pay - received;
                        pr.Add(partyreport);
                    }
                    return pr;
                }
                else
                {
                    //party=db.Parties.Where(p=>p.Id==id).ToList();
                    party = db.ContractParties.Where(p => p.ProjectId == id).Select(p => p.Party).ToList();
                    party = party.Where(p => p.CompanyType.Equals("Vendor")).ToList();
                    List<PartyReport> pr = new List<PartyReport>();
                    foreach (Party par in party)
                    {
                        long pay = 0;
                        long received = 0;
                        PartyReport partyreport = new PartyReport();
                        if (db.Transactions.Where(p => p.TransactionType.Equals("Credit") && p.PartyId == par.Id && p.ProjectId==id).ToList().Count != 0)
                            received = db.Transactions.Where(p => p.TransactionType.Equals("Credit") && p.PartyId == par.Id&& p.ProjectId==id).Sum(p => p.Amount);
                        if (db.Transactions.Where(p => p.TransactionType.Equals("Debit") && p.PartyId == par.Id && p.ProjectId == id).ToList().Count != 0)
                            pay = db.Transactions.Where(p => p.TransactionType.Equals("Debit") && p.PartyId == par.Id && p.ProjectId == id).Sum(p => p.Amount);
                        partyreport.PartyName = par.Party_Name;
                        partyreport.PartyOwner = par.OwnerName;
                        long reverseAmount = 0;
                        if (db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.PartyId.Equals(par.Id)&&r.Transaction.ProjectId.Equals(id)).ToList().Count != 0)
                        {



                            reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.PartyId.Equals(par.Id)&&r.Transaction.ProjectId.Equals(id)).Sum(r => r.Amount);
                        }
                        partyreport.AmountPaid = pay-reverseAmount;
                        partyreport.AmountReceived = received-reverseAmount;
                        partyreport.Balance = pay-received;
                        pr.Add(partyreport);
                    }
                    return pr;
                }
                
            }
        }
        public int SaveEditCompany(Party p)
        {
          ZamsEntities6 db = new ZamsEntities6();
             using (db)
             {

                 try
                 {
                     Party p1 = db.Parties.Find(p.Id);
                     p1.OwnerName = p.OwnerName;
                     p1.Location = p.Location;
                     p1.PhoneNumber = p.PhoneNumber;
                     p1.Email = p.Email;
                     p1.FaxNumber = p.FaxNumber;
                     return db.SaveChanges();
                 }
                 catch (Exception e)
                 {
                     return 0;
                 }
             }
        }
        public int SaveEditProject(Project p)
        {
         ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {

                try
                {
                    Project p1 = db.Projects.Find(p.Id);
                    p1.Status = p.Status;
                   // if (p.Status.Equals("Ended"))
                   p1.EndDate = p.EndDate;

                    return db.SaveChanges();
                }
                catch (Exception e)
                {
                    return 0;
                }
            }
        }
        public List<long> getPaidSpecific(int id)
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                long pay = 0, received = 0;
                if (db.Transactions.Where(p => p.PartyId==id && p.TransactionType.Equals("Credit") ).ToList().Count != 0)
                {
                    received = db.Transactions.Where(p => p.PartyId==id && p.TransactionType.Equals("Credit") ).Sum(p => p.Amount);
                }
                if (db.Transactions.Where(p => p.PartyId==id && p.TransactionType.Equals("Debit")).ToList().Count != 0)
                {
                    pay = db.Transactions.Where(p =>p.PartyId==id&& p.TransactionType.Equals("Debit")).Sum(p => p.Amount);
                }
                long reverseAmount = 0;
                if (db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor")&&r.Transaction.Party.Id.Equals(id)).ToList().Count != 0)
                {



                    reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor")&&r.Transaction.Party.Id.Equals(id)).Sum(r => r.Amount);
                }
                List<long> a = new List<long>();
                a.Add(received);
                a.Add(pay);
                return a;
            }
        }
        public List<TransactionDummy> GetTransactionsByCompany(int companyId)
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                // return null;
                List<Transaction> transactions = db.Transactions.Where(p => p.Party.Id == companyId ).ToList();//Select(p => new TransactionDummy { Id = p.Id, DateTime = p.DateTime, Amount = p.Amount, TransactionType = p.TransactionType, Description = p.Description, CheckNumber = p.OtherDetails, ProjectName = p.Project.ProjectName, PartyName = p.Party.Party_Name }).ToList();
                List<TransactionDummy> transactionsdumy = new List<TransactionDummy>();
                long debitTotal = 0, creditTotal = 0;
                foreach (Transaction t in transactions)
                {
                    TransactionDummy td = new TransactionDummy();
                    td.Date = t.DateTime.Date;
                    td.RefId = t.Id;
                    td.Cheque_No = t.OtherDetails;
                    td.Description = t.Description;
                    td.PartyORProject = t.Party.Party_Name;
                    if (t.TransactionType.Equals("Credit"))
                    {
                        creditTotal = creditTotal + t.Amount;
                        td.Credit = String.Format("{0:n}", t.Amount);
                        //td.Debit = 0;
                    }
                    else
                    {
                        debitTotal = debitTotal + t.Amount;
                        td.Debit = String.Format("{0:n}", t.Amount);
                        //td.Credit = 0;
                    }
                    td.Balance = String.Format("{0:n}", t.Balance);
                    transactionsdumy.Add(td);
                }
                TransactionDummy ttd = new TransactionDummy();
                ttd.Description = "Total";
                ttd.Debit = String.Format("{0:n}", debitTotal);
                ttd.Credit = String.Format("{0:n}", creditTotal);
                transactionsdumy.Add(ttd);
                return transactionsdumy;
            }
        }
        public List<TransactionDummy> GetTransactionsByProject(int projectId)
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                //return null;
                List<Transaction> transactions = db.Transactions.Where(p => p.Project.Id == projectId && p.Party.CompanyType.Equals("Vendor")  ).ToList();//Select(p => new TransactionDummy { Id = p.Id, DateTime = p.DateTime, Amount = p.Amount, TransactionType = p.TransactionType, Description = p.Description, CheckNumber = p.OtherDetails, ProjectName = p.Project.ProjectName, PartyName = p.Party.Party_Name  }).ToList();
                List<TransactionDummy> transactionsdumy = new List<TransactionDummy>();
                long debitTotal = 0, creditTotal = 0;
                foreach (Transaction t in transactions)
                {
                    TransactionDummy td = new TransactionDummy();
                    td.Date = t.DateTime.Date;
                    td.RefId = t.Id;
                    td.Cheque_No = t.OtherDetails;
                    td.Description = t.Description;
                    td.PartyORProject = t.Party.Party_Name;

                    td.UserName = t.UserName;

                    if (t.TransactionType.Equals("Credit"))
                    {
                        creditTotal = creditTotal + t.Amount;
                        td.Credit = String.Format("{0:n}", t.Amount);
                        //td.Debit = 0;
                    }
                    else
                    {
                        debitTotal = debitTotal + t.Amount;
                        td.Debit = String.Format("{0:n}", t.Amount);
                       // td.Credit = 0;
                    }
                    td.Balance = String.Format("{0:n}", t.Balance);
                    transactionsdumy.Add(td);
                }
                long reverseAmount = 0;
                if (db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.Project.Id.Equals(projectId)).ToList().Count != 0)
                {



                    reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.Project.Id.Equals(projectId)).Sum(r => r.Amount);

                }
                TransactionDummy ttd = new TransactionDummy();
                ttd.Description = "Total";
                ttd.Debit = String.Format("{0:n}", debitTotal-reverseAmount);
                ttd.Credit = String.Format("{0:n}", creditTotal-reverseAmount);
                transactionsdumy.Add(ttd);
                return transactionsdumy;
                // return null;
            }
        }
        public List<TransactionDummy> GetTransactionDummy()
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                //return null;
                List<Transaction> transactions = db.Transactions.ToList();//Select(p => new TransactionDummy { RefId = p.Id, Date= p.DateTime, Amount = p.Amount, TransactionType = p.TransactionType, Description = p.Description, CheckNumber = p.OtherDetails, ProjectName = p.Project.ProjectName, PartyName = p.Party.Party_Name }).ToList();
                List<TransactionDummy> transactionsdumy = new List<TransactionDummy>();
                long debitTotal = 0, creditTotal = 0;
                foreach (Transaction t in transactions)
                {
                    TransactionDummy td = new TransactionDummy();
                    td.Date = t.DateTime.Date;
                    td.RefId = t.Id;
                    td.Cheque_No = t.OtherDetails;
                    td.Description = t.Description;
                    td.PartyORProject = t.Party.Party_Name;
                    if (t.TransactionType.Equals("Credit"))
                    {
                        creditTotal = creditTotal + t.Amount;
                        td.Credit = String.Format("{0:n}", t.Amount);
                        //  td.Debit = 0;
                    }
                    else
                    {
                        debitTotal = debitTotal + t.Amount;
                        td.Debit = String.Format("{0:n}", t.Amount);
                        // td.Credit = 0;
                    }
                    td.Balance = String.Format("{0:n}", t.Balance);
                    transactionsdumy.Add(td);
                }
                TransactionDummy ttd = new TransactionDummy();
                ttd.Description = "Total";
                ttd.Debit = String.Format("{0:n}", debitTotal);
                ttd.Credit = String.Format("{0:n}", creditTotal);
                transactionsdumy.Add(ttd);
                return transactionsdumy;
            }
        }
        public List<Project> GetProjectsforParty(int id)
        {
            try
            {
                ZamsEntities6 zam = new ZamsEntities6();
                using (zam)
                {
                    List<ContractParty> cp = zam.ContractParties.Where(p => p.PartyId == id).ToList();
                    List<Project> p1 = new List<Project>();
                    foreach (var a in cp)
                    {
                        p1.Add(a.Project);
                    }
                    return p1;
                }        //List<Project> l=zam.Projects.Where(p=>p)
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<TransactionDummy> GetTransactionsByProject1(int projectId)
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                //return null;
                List<Transaction> transactions = db.Transactions.Where(p => p.Project.Id == projectId && p.Party.CompanyType.Equals("Vendor")).ToList();//Select(p => new TransactionDummy { Id = p.Id, DateTime = p.DateTime, Amount = p.Amount, TransactionType = p.TransactionType, Description = p.Description, CheckNumber = p.OtherDetails, ProjectName = p.Project.ProjectName, PartyName = p.Party.Party_Name  }).ToList();
                List<TransactionDummy> transactionsdumy = new List<TransactionDummy>();
                long debitTotal = 0, creditTotal = 0;
                foreach (Transaction t in transactions)
                {
                    TransactionDummy td = new TransactionDummy();
                    td.Date = t.DateTime.Date;
                    td.RefId = t.Id;
                    td.Cheque_No = t.OtherDetails;
                    td.Description = t.Description;
                    td.PartyORProject = t.Party.Party_Name;

                    td.UserName = t.UserName;

                    if (t.TransactionType.Equals("Credit"))
                    {
                        creditTotal = creditTotal + t.Amount;
                        td.Credit = String.Format("{0:n}", t.Amount);
                        //td.Debit = 0;
                    }
                    else
                    {
                        debitTotal = debitTotal + t.Amount;
                        td.Debit = String.Format("{0:n}", t.Amount);
                       // td.Credit = 0;
                    }
                    td.Balance = String.Format("{0:n}", t.Balance);
                    transactionsdumy.Add(td);
                }

                long reverseAmount=0;
                if (db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.Project.Id.Equals(projectId)).ToList().Count != 0)
                {



                    reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor")&& r.Transaction.Project.Id.Equals(projectId)).Sum(r => r.Amount);

                }
                TransactionDummy ttd = new TransactionDummy();
                ttd.Description = "Total";
                ttd.Debit = String.Format("{0:n}", debitTotal-reverseAmount);
                ttd.Credit = String.Format("{0:n}", creditTotal-reverseAmount);
                transactionsdumy.Add(ttd);
                return transactionsdumy;
                // return null;
            }
        }
        public List<TransactionDummy> GetTransactionsByCompany1(int companyId)
        {
            ZamsEntities6 db = new ZamsEntities6();
            long debitTotal = 0, creditTotal = 0;
            using (db)
            {
                // return null;
                List<Transaction> transactions = db.Transactions.Where(p => p.Party.Id == companyId ).ToList();//Select(p => new TransactionDummy { Id = p.Id, DateTime = p.DateTime, Amount = p.Amount, TransactionType = p.TransactionType, Description = p.Description, CheckNumber = p.OtherDetails, ProjectName = p.Project.ProjectName, PartyName = p.Party.Party_Name }).ToList();
                List<TransactionDummy> transactionsdumy = new List<TransactionDummy>();
                foreach (Transaction t in transactions)
                {
                    TransactionDummy td = new TransactionDummy();
                    td.Date = t.DateTime.Date;
                    td.RefId = t.Id;
                   td.Cheque_No = t.OtherDetails;
                    td.Description = t.Description;
                    td.PartyORProject = t.Project.ProjectName ;
                    td.UserName = t.UserName;

                    td.Balance =  String.Format("{0:n}",t.CompanyBalance);
                    if (t.TransactionType.Equals("Credit"))
                    {
                        creditTotal = creditTotal + t.Amount;
                        td.Credit = String.Format("{0:n}", t.Amount);
                        //  td.Debit = 0;
                    }
                    else
                    {
                        debitTotal = debitTotal + t.Amount;
                        td.Debit = String.Format("{0:n}", t.Amount);
                        // td.Credit = 0;
                    }
                    // td.Balance = t.Balance;
                    
                    transactionsdumy.Add(td);
                }
                // zeshan
                long reverseAmount = 0;
                if (db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.Party.Id.Equals(companyId)).ToList().Count != 0)
                {



                    reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.Party.Id.Equals(companyId)).Sum(r => r.Amount);

                }
                TransactionDummy ttd = new TransactionDummy();
                ttd.Description = "Total";
                ttd.Debit = String.Format("{0:n}", debitTotal-reverseAmount);
                ttd.Credit = String.Format("{0:n}", creditTotal-reverseAmount);
                transactionsdumy.Add(ttd);
                return transactionsdumy;
            }
        }
        public List<TransactionDummy> GetTransactionsByCompanyAndProject(int companyId, int projectId)
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                //return null;
                List<Transaction> transactions = db.Transactions.Where(p => p.Project.Id == projectId && (p.Party.Id == companyId) ).ToList();//Select(p => new TransactionDummy { Id = p.Id, DateTime = p.DateTime, Amount = p.Amount, TransactionType = p.TransactionType, Description = p.Description, CheckNumber = p.OtherDetails, ProjectName = p.Project.ProjectName, PartyName = p.Party.Party_Name }).ToList();
                List<TransactionDummy> transactionsdumy = new List<TransactionDummy>();
                long debitTotal = 0, creditTotal = 0;
                foreach (Transaction t in transactions)
                {
                    TransactionDummy td = new TransactionDummy();
                    td.Date = t.DateTime.Date;
                    td.RefId = t.Id;
                    td.Cheque_No = t.OtherDetails;
                    td.Description = t.Description;
                    td.PartyORProject = t.Party.Party_Name;

                    td.UserName = t.UserName;

                    if (t.TransactionType.Equals("Credit"))
                    {
                        creditTotal = creditTotal + t.Amount;
                        td.Credit = String.Format("{0:n}", t.Amount); 
                        //td.Debit = 0;
                    }
                    else
                    {
                        debitTotal = debitTotal + t.Amount;
                        td.Debit = String.Format("{0:n}", t.Amount);
                        //td.Credit = 0;
                    }
                    td.Balance = String.Format("{0:n}", t.TransactionBalance); 
                    transactionsdumy.Add(td);
                }
                long reverseAmount = 0;
                if (db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.Project.Id.Equals(projectId)&&r.Transaction.Party.Id.Equals(companyId)).ToList().Count != 0)
                {



                    reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.Party.CompanyType.Equals("Vendor") && r.Transaction.Project.Id.Equals(projectId)&&r.Transaction.Party.Id.Equals(companyId)).Sum(r => r.Amount);

                }
                TransactionDummy ttd = new TransactionDummy();
                ttd.Description = "Total";
                ttd.Debit = String.Format("{0:n}", debitTotal);
                ttd.Credit = String.Format("{0:n}", creditTotal);
                transactionsdumy.Add(ttd);
                return transactionsdumy;
                // return null;
            }
        }

        public List<PartyDummy> GetClient()
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                List<PartyDummy> pd = new List<PartyDummy>();
                List<Party> p= db.Parties.Where(p2 => p2.CompanyType.Equals("Client")).OrderBy(t=>t.Party_Name).ToList();
                foreach (Party p1 in p)
                {
                    PartyDummy pd1 = new PartyDummy();
                    if (p1.CompanyBalance != null)
                        pd1.CompanyBalance = String.Format("{0:n}", p1.CompanyBalance);
                    else
                        pd1.CompanyBalance = String.Format("{0:n}", 0);
                    pd1.Email = p1.Email;
                    pd1.FaxNumber = p1.FaxNumber;
                    pd1.Id = p1.Id;
                    pd1.Location = p1.Location;
                    pd1.OwnerName = p1.OwnerName;
                    pd1.Party_Name = p1.Party_Name;
                    pd1.PhoneNumber = p1.PhoneNumber;
                 //   pd1.c
                    pd.Add(pd1);


                }
                return pd;
            }
        }

        //
        public List<Party> getClient1()
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                
                return db.Parties.Where(p => p.Party_Name != "Zakriya Construction"&&p.CompanyType.Equals("Client")).OrderBy(t => t.Party_Name).ToList();


            }
        }
        //
        public List<Party> getVendor()
        {
            ZamsEntities6 db = new ZamsEntities6();
            using (db)
            {
                //return (List<Party>)db.Parties.Where(p => p.Party_Name != "Zakriya Construction" && p.CompanyType.Equals("Vendor")).ToList().OrderBy(t => t.Party_Name);
                return db.Parties.Where(p => p.Party_Name != "Zakriya Construction" && p.CompanyType.Equals("Vendor")).OrderBy(t=>t.Party_Name).ToList() ;


            }
        }

        public int SaveBank(Bank bank)
        {
            try
            {
                ZamsEntities6 db = new ZamsEntities6();
                using (db)
                {
                    if (db.Banks.ToList().Count != 0)
                    {
                        
                        Bank b = db.Banks.Where(p => p.BankName.Equals(bank.BankName) && p.Branch.Equals(bank.Branch) && p.AccountNumber.Equals(bank.AccountNumber)).FirstOrDefault();
                        if (b == null)
                        {
                            Bank center = db.Banks.Where(p => p.AccountNumber.Equals("999999") && p.Branch.Equals("RSS")).FirstOrDefault();
                            center.Balance += bank.Balance;
                            db.Banks.Add(bank);
                            return db.SaveChanges();
                        }
                        else
                            return -999;
                    }
                    else
                    {
                        Bank b1 = new Bank();
                        b1.AccountNumber = "999999";
                        b1.AccountTitle = "Balance Mainain";
                        b1.BankName = "Center";
                        b1.Balance = bank.Balance;
                        b1.Branch = "RSS";
                        db.Banks.Add(b1);
                        db.Banks.Add(bank);
                        return db.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public List<BankDummy> GetBanks()
        {
            try
            {
                ZamsEntities6 db = new ZamsEntities6();
                using (db)
                {
                    List<BankDummy> bd = new List<BankDummy>();
                    List<Bank> b = db.Banks.Where(b1=>b1.BankName!="Center").ToList();
                  
                    foreach (Bank b1 in b)
                    {
                        BankDummy bd1 = new BankDummy();
                        bd1.Id = b1.Id;
                        bd1.Balance = String.Format("{0:n}", b1.Balance);
                        bd1.AccountNumber = b1.AccountNumber;
                        bd1.AccountTitle = b1.AccountTitle;
                        bd1.Address = b1.Address;
                        bd1.BankName = b1.BankName;
                        bd1.Branch = b1.Branch;
                        bd1.PhoneNumber = b1.PhoneNumber;
                        bd.Add(bd1);
                    }
                    return bd;
                }

            }
            catch (Exception e)
            {
                return null;
            }
         }

        //
        public List<String> GetBankNames()
        {
            try
            {
                ZamsEntities6 db = new ZamsEntities6();
                using (db)
                {
                    List<String> bankName = db.Banks.Where(b=>b.BankName!="Center").Select(b=>b.BankName).Distinct().ToList();
                    return bankName;

                }
            }
            catch (Exception e)
            {
                return null;
            }


        }
        //
        public List<String> GetBranchNames(String bankName)
        {
            try
            {
                ZamsEntities6 db = new ZamsEntities6();
                using (db)
                {
                    List<String> branchName = db.Banks.Where(b=>b.BankName.Equals(bankName)).Select(b => b.Branch).Distinct().ToList();
                    return branchName;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        //
        public List<String> GetAccountNo(String bankName, String branchName)
        {
            try
            {
                ZamsEntities6 db = new ZamsEntities6();
                using (db)
                {
                    //List<Bank> lb = db.Banks.Where(b => b.BankName.Equals(bankName) && b.Branch.Equals(branchName)).ToList();
                    List<String> AccountNo = db.Banks.Where(b => b.BankName.Equals(bankName) && b.Branch.Equals(branchName)).Select(b => b.AccountNumber).Distinct().ToList();
                    return AccountNo;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        //
        public Bank GetSpecificAccountInfo(String bankName, String branchName, String AccountNo)
        {
            try
            {
                ZamsEntities6 db = new ZamsEntities6();
                using (db)
                {
                    //List<Bank> lb = db.Banks.Where(b => b.BankName.Equals(bankName) && b.Branch.Equals(branchName)).ToList();
                    Bank AccountInfo = db.Banks.FirstOrDefault(b => b.BankName.Equals(bankName) && b.Branch.Equals(branchName)&&b.AccountNumber.Equals(AccountNo));
                    return AccountInfo;

                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        //
        public long GetPattyBalance()
        {
            try
            {
                ZamsEntities6 db = new ZamsEntities6();
                using (db)
                {
                    List<PettyCash> p = db.PettyCashes.ToList();
                    if (p != null)
                        return p.Last().Balance;
                    return 0;
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public List<PtyCashDummy> getPtyCashTransactions(DateTime startDate, DateTime endDate)
        {
            try
            {
                ZamsEntities6 db = new ZamsEntities6();
                using (db)
                {
                    List<PettyCash> transactions = db.PettyCashes.Where(p => p.TransactionDate >= startDate && p.TransactionDate <= endDate).ToList();
                    List<PtyCashDummy> pty = new List<PtyCashDummy>();
                    PtyCashDummy pt2 = new PtyCashDummy();
                    long debit = 0;
                    long credit = 0;
                    foreach (PettyCash pc in transactions)
                    {
                        PtyCashDummy pt1 = new PtyCashDummy();
                        pt1.Balance = String.Format("{0:n}", pc.Balance);
                        if (pc.TransactionType.Equals("Debit"))
                        {
                            debit += pc.Amount;
                            pt1.Debit = String.Format("{0:n}", pc.Amount);
                        }
                        else
                        {
                            credit += pc.Amount;
                            pt1.Credit = String.Format("{0:n}", pc.Amount);
                        }
                        pt1.Description = pc.Description;
                        pt1.RefId = pc.RefID;
                        pt1.ID = pc.Id;
                        pt1.Date = pc.TransactionDate.Date;

                        pt1.UserName = pc.UserName;


                        pty.Add(pt1);
                    }
                    pt2.Debit = String.Format("{0:n}", debit);
                    pt2.Credit = String.Format("{0:n}", credit);
                    pt2.Description = "Total";
                    pty.Add(pt2);
                     long reverseAmount=0;
                     PtyCashDummy tdr = new PtyCashDummy();
                     tdr.Debit = String.Format("{0:n}", reverseAmount);
                     tdr.Credit = String.Format("{0:n}", reverseAmount);
                     tdr.Description = "Reverse Amount";
                     if (db.ReverseEntries.Where(r => r.TableName.Equals("Petty") && r.trDate >= startDate && r.trDate <= endDate).ToList().Count != 0)
                    {
                        reverseAmount= db.ReverseEntries.Where(r => r.TableName.Equals("Petty") && r.trDate >= startDate && r.trDate <= endDate).Sum(r => r.Amount);
                       // PtyCashDummy tdr = new PtyCashDummy();
                        tdr.Debit = String.Format("{0:n}", reverseAmount);
                        tdr.Credit = String.Format("{0:n}", reverseAmount);
                       // tdr.Description = "Reverse Amount";
                      
                    }
                    pty.Add(tdr);
                    PtyCashDummy tdnet = new PtyCashDummy();
                    tdnet.Debit = String.Format("{0:n}", debit - reverseAmount);
                    tdnet.Credit = String.Format("{0:n}", credit - reverseAmount);
                    tdnet.Description = "Net Total";
                    pty.Add(tdnet);
                    return pty;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<PtyCashDummy> getPtyCashTransactions()
        {
            try
            {
                ZamsEntities6 db = new ZamsEntities6();
                using (db)
                {
                    List<PettyCash> transactions = db.PettyCashes.ToList();
                    List<PtyCashDummy> pty = new List<PtyCashDummy>();
                    PtyCashDummy pt2 = new PtyCashDummy();
                    long debit = 0, credit = 0;
                    foreach (PettyCash pc in transactions)
                    {
                        PtyCashDummy pt1 = new PtyCashDummy();
                        pt1.Balance = String.Format("{0:n}", pc.Balance);
                        if (pc.TransactionType.Equals("Debit"))
                        {
                            debit += pc.Amount;
                            pt1.Debit = String.Format("{0:n}", pc.Amount);
                        }
                        else
                        {
                            credit += pc.Amount;
                            pt1.Credit = String.Format("{0:n}", pc.Amount);
                        }
                        pt1.ID = pc.Id;
                        pt1.Description = pc.Description;
                        pt1.RefId = pc.RefID;
                        pt1.Date = pc.TransactionDate.Date;

                        pt1.UserName = pc.UserName;

                        pty.Add(pt1);
                    }
                    long reverseAmount = 0;
                    pt2.Debit = String.Format("{0:n}", debit);
                    pt2.Credit = String.Format("{0:n}", credit);
                    pt2.Description = "Total";
                    pty.Add(pt2);
                    PtyCashDummy tdr = new PtyCashDummy();
                    tdr.Debit = String.Format("{0:n}", reverseAmount);
                    tdr.Credit = String.Format("{0:n}", reverseAmount);
                    tdr.Description = "Reverse Amount";
                    if (db.ReverseEntries.Where(r => r.TableName.Equals("Project")).ToList().Count != 0)
                    {
                      
                        reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Petty")).Sum(r => r.Amount);
                       // PtyCashDummy tdr = new PtyCashDummy();
                        tdr.Debit = String.Format("{0:n}", reverseAmount);
                        tdr.Credit = String.Format("{0:n}", reverseAmount);
                       // tdr.Description = "Reverse Amount";
                       
                    }
                    pty.Add(tdr);
                    PtyCashDummy tdnet = new PtyCashDummy();
                    tdnet.Debit = String.Format("{0:n}", debit - reverseAmount);
                    tdnet.Credit = String.Format("{0:n}", credit - reverseAmount);
                    tdnet.Description = "Net Total";
                    pty.Add(tdnet);
                    return pty;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<BankTransactionDummy> getAllBanksTransactions(DateTime startDate, DateTime endDate)
        {
            try
            {
                ZamsEntities6 db = new ZamsEntities6();
                using (db)
                {
                    List<BankTransaction> bt = db.BankTransactions.Where(p => p.TransactionDate >= startDate && p.TransactionDate <= endDate).ToList();
                    List<BankTransactionDummy> btd = new List<BankTransactionDummy>();
                    BankTransactionDummy btd2 = new BankTransactionDummy();
                    long debit = 0, credit = 0;
                    foreach (BankTransaction bt1 in bt)
                    {
                        BankTransactionDummy btd1 = new BankTransactionDummy();
                        btd1.Date = bt1.TransactionDate.Date;
                        btd1.Balance = String.Format("{0:n}", bt1.AllBankBalance);
                        if (bt1.TransactionType.Equals("Debit"))
                        {
                            btd1.Debit = String.Format("{0:n}", bt1.Amount);
                            //btd1.Credit = String.Format("{0:n}", 0);
                            debit += bt1.Amount;
                        }
                        else
                        {
                            credit += bt1.Amount;
                            //btd1.Debit = String.Format("{0:n}", 0);
                            btd1.Credit = String.Format("{0:n}", bt1.Amount);
                        }
                        btd1.ID = bt1.Id;
                        btd1.RefId = bt1.RefID;
                        btd1.BankName = bt1.Bank.BankName;
                        btd1.AccountNumber = bt1.Bank.AccountNumber;
                        btd1.Description = bt1.Description;
                        btd1.ChequeNumber = bt1.OtherDetail;

                        btd1.UserName = bt1.UserName;


                        btd.Add(btd1);
                    }
                    long reverseAmount = 0;
                    btd2.Debit = String.Format("{0:n}", debit);
                    btd2.Credit = String.Format("{0:n}", credit);
                    btd2.Description = "Total";
                    btd.Add(btd2);
                    BankTransactionDummy tdr = new BankTransactionDummy();
                    tdr.Debit = String.Format("{0:n}", reverseAmount);
                    tdr.Credit = String.Format("{0:n}", reverseAmount);
                    tdr.Description = "Reverse Amount";
                    if (db.ReverseEntries.Where(r => r.TableName.Equals("Bank") && r.trDate >= startDate && r.trDate <= endDate).ToList().Count != 0)
                    {
                       
                        reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Bank") && r.trDate >= startDate && r.trDate <= endDate).Sum(r => r.Amount);
                       // BankTransactionDummy tdr = new BankTransactionDummy();
                        tdr.Debit = String.Format("{0:n}", reverseAmount);
                        tdr.Credit = String.Format("{0:n}", reverseAmount);
                       // tdr.Description = "Reverse Amount";
                       
                    }
                    btd.Add(tdr);
                    BankTransactionDummy tdnet = new BankTransactionDummy();
                    tdnet.Debit = String.Format("{0:n}", debit - reverseAmount);
                    tdnet.Credit = String.Format("{0:n}", credit - reverseAmount);
                    tdnet.Description = "Net Total";
                    btd.Add(tdnet);

                    return btd;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<BankTransactionDummy> getAllBanksTransactions()
        {
            try
            {
                ZamsEntities6 db = new ZamsEntities6();
                using (db)
                {
                    List<BankTransaction> bt = db.BankTransactions.ToList();
                    List<BankTransactionDummy> btd = new List<BankTransactionDummy>();
                    BankTransactionDummy btd2 = new BankTransactionDummy();
                    long debit = 0, credit = 0;
                    foreach (BankTransaction bt1 in bt)
                    {
                        BankTransactionDummy btd1 = new BankTransactionDummy();
                        btd1.Date = bt1.TransactionDate.Date;
                        btd1.Balance = String.Format("{0:n}", bt1.AllBankBalance);
                        if (bt1.TransactionType.Equals("Debit"))
                        {
                            debit += bt1.Amount;
                            btd1.Debit = String.Format("{0:n}", bt1.Amount);
                            //btd1.Credit = String.Format("{0:n}", 0);
                        }
                        else
                        {
                            credit += bt1.Amount;
                            //btd1.Debit = String.Format("{0:n}", 0);
                            btd1.Credit = String.Format("{0:n}", bt1.Amount);
                        }
                        btd1.ID = bt1.Id;
                        btd1.RefId = bt1.RefID;
                        btd1.BankName = bt1.Bank.BankName;
                        btd1.AccountNumber = bt1.Bank.AccountNumber;
                        btd1.Description = bt1.Description;
                        btd1.ChequeNumber = bt1.OtherDetail;

                        btd1.UserName = bt1.UserName;

                        btd.Add(btd1);
                    }
                    long reverseAmount = 0;
                    btd2.Debit = String.Format("{0:n}", debit);
                    btd2.Credit = String.Format("{0:n}", credit);
                    btd2.Description = "Total";
                    btd.Add(btd2);
                    BankTransactionDummy tdr = new BankTransactionDummy();
                    tdr.Debit = String.Format("{0:n}", reverseAmount);
                    tdr.Credit = String.Format("{0:n}", reverseAmount);
                    tdr.Description = "Reverse Amount";
                    if (db.ReverseEntries.Where(r => r.TableName.Equals("Bank")).ToList().Count != 0)
                    {
                        
                        reverseAmount = db.ReverseEntries.Where(r => r.TableName.Equals("Bank")).Sum(r => r.Amount);
                       // BankTransactionDummy tdr = new BankTransactionDummy();
                        tdr.Debit = String.Format("{0:n}", reverseAmount);
                        tdr.Credit = String.Format("{0:n}", reverseAmount);
                       // tdr.Description = "Reverse Amount";
                       
                    }
                    btd.Add(tdr);
                    BankTransactionDummy tdnet = new BankTransactionDummy();
                    tdnet.Debit = String.Format("{0:n}", debit - reverseAmount);
                    tdnet.Credit = String.Format("{0:n}", credit - reverseAmount);
                    tdnet.Description = "Net Total";
                    btd.Add(tdnet);
                    return btd;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public List<BankTransactionDummy> getTransactionByBankId(DateTime startDate,DateTime endDate,string bankName, string branchName, string accountNumber)
        {
            try
            {
                ZamsEntities6 db = new ZamsEntities6();
                using (db)
                {
                    List<BankTransaction> bt = db.BankTransactions.Where(p=>p.Bank.AccountNumber.Equals(accountNumber)&&p.Bank.Branch.Equals(branchName)&&p.Bank.BankName.Equals(bankName)&&p.TransactionDate>=startDate&&p.TransactionDate<=endDate).ToList();
                    List<BankTransactionDummy> btd = new List<BankTransactionDummy>();
                    long debit = 0, credit = 0;
                    BankTransactionDummy btd2 = new BankTransactionDummy();
                    foreach (BankTransaction bt1 in bt)
                    {
                        BankTransactionDummy btd1 = new BankTransactionDummy();
                        btd1.Date = bt1.TransactionDate.Date;
                        btd1.Balance = String.Format("{0:n}", bt1.Balance);
                        if (bt1.TransactionType.Equals("Debit"))
                        {
                            debit += bt1.Amount;
                            btd1.Debit = String.Format("{0:n}", bt1.Amount);
                            //btd1.Credit = String.Format("{0:n}", 0);
                        }
                        else
                        {
                            credit += bt1.Amount;
                            //btd1.Debit = String.Format("{0:n}", 0);
                            btd1.Credit = String.Format("{0:n}", bt1.Amount);
                        }
                        btd1.ID = bt1.Id;
                        btd1.RefId = bt1.RefID;
                        btd1.BankName = bt1.Bank.BankName;
                        btd1.AccountNumber = bt1.Bank.AccountNumber;
                        btd1.Description = bt1.Description;
                        btd1.ChequeNumber = bt1.OtherDetail;

                        btd1.UserName = bt1.UserName;

                        btd.Add(btd1);
                    }
                    btd2.Debit = String.Format("{0:n}", debit);
                    btd2.Credit = String.Format("{0:n}", credit);
                    btd2.AccountNumber = "Total";
                    btd.Add(btd2);
                    return btd;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public List<BankTransactionDummy> getTransactionByBankId(string bankName, string branchName, string accountNumber)
        {
            try
            {
                ZamsEntities6 db = new ZamsEntities6();
                using (db)
                {
                   
                    List<BankTransaction> bt = db.BankTransactions.Where(p => p.Bank.AccountNumber.Equals(accountNumber) && p.Bank.Branch.Equals(branchName) && p.Bank.BankName.Equals(bankName)).ToList();
                    List<BankTransactionDummy> btd = new List<BankTransactionDummy>();
                    BankTransactionDummy btd2 = new BankTransactionDummy();
                    long debit = 0, credit = 0;
                    foreach (BankTransaction bt1 in bt)
                    {
                        BankTransactionDummy btd1 = new BankTransactionDummy();
                        btd1.Date = bt1.TransactionDate.Date;
                        btd1.Balance = String.Format("{0:n}", bt1.Balance);
                        if (bt1.TransactionType.Equals("Debit"))
                        {
                            debit += bt1.Amount;
                            btd1.Debit = String.Format("{0:n}", bt1.Amount);
                            //btd1.Credit = String.Format("{0:n}", 0);
                        }
                        else
                        {
                            credit += bt1.Amount;
                            //btd1.Debit = String.Format("{0:n}", 0);
                            btd1.Credit = String.Format("{0:n}", bt1.Amount);
                        }
                        btd1.ID = bt1.Id;
                        btd1.RefId = bt1.RefID;
                        btd1.BankName = bt1.Bank.BankName;
                        btd1.AccountNumber = bt1.Bank.AccountNumber;
                        btd1.Description = bt1.Description;
                        btd1.ChequeNumber = bt1.OtherDetail;
                        btd.Add(btd1);
                    }
                    btd2.Debit = String.Format("{0:n}", debit);
                    btd2.Credit = String.Format("{0:n}", credit);
                    btd2.AccountNumber = "Total";
                    btd.Add(btd2);
                    return btd;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
        //////////// 
        public List<long> getRecievedAmountAndExpenditure(int clientId,int projectId)
        {
            try
            {
                ZamsEntities6 db = new ZamsEntities6();
                using (db)
                {
                    // Recieved Amount
                    long recieveAmount = 0,reverseRecieve=0;

                    if (db.Transactions.Where(p => p.PartyId == clientId && p.ProjectId == projectId && p.TransactionType.Equals("Credit")).ToList().Count > 0)
                    {
                        recieveAmount = db.Transactions.Where(p => p.PartyId == clientId && p.ProjectId == projectId && p.TransactionType.Equals("Credit")).ToList().Sum(t=>t.Amount);//.p.Id(db.ReverseEntries.Where(r=>r.TableName.Equals("Projects"))));
                    }
                   
                       if (db.ReverseEntries.Where(r =>r.Transaction.PartyId.Equals(clientId)&&r.Transaction.ProjectId.Equals(projectId) && r.TableName.Equals("Project")).ToList().Count > 0)
                       {
                           reverseRecieve = db.ReverseEntries.Where(r => r.Transaction.PartyId.Equals(clientId) && r.Transaction.ProjectId.Equals(projectId) && r.TableName.Equals("Project")).ToList().Sum(r => r.Amount);
                       }
                   
                    // Expenditures
                       long Expenditure = 0,reverseExpenditure=0;
                       if (db.Transactions.Where(p => p.ProjectId == projectId && p.Party.CompanyType.Equals("Vendor") && p.TransactionType.Equals("Debit")).ToList().Count > 0)
                       {
                           Expenditure = db.Transactions.Where(p => p.ProjectId == projectId && p.Party.CompanyType.Equals("Vendor") && p.TransactionType.Equals("Debit")).ToList().Sum(t=>t.Amount);
                       }
                   
                       if (db.ReverseEntries.Where(r =>r.Transaction.ProjectId.Equals(projectId)&&r.Transaction.Party.CompanyType.Equals("Vendor") && r.TableName.Equals("Project")).ToList().Count>0)
                       {
                           reverseExpenditure = db.ReverseEntries.Where(r => r.Transaction.ProjectId.Equals(projectId) && r.Transaction.Party.CompanyType.Equals("Vendor") && r.TableName.Equals("Project")).ToList().Sum(r=>r.Amount);
                       }
                   

                   List<long> intList = new List<long>();
                   intList.Add(recieveAmount-reverseRecieve);
                   intList.Add(Expenditure-reverseExpenditure);
                   return intList;
                }
            }
            catch (Exception e)
            {
                return null;
            }
       }  
        //////////////////
         public List<long> getRecievedAmountAndExpenditure(int clientId)
        {
            try
            {
                ZamsEntities6 db = new ZamsEntities6();
                using (db)
                {
                    // Recieved Amount
                    long recieveAmount = 0, reverseRecieve = 0;
                    if (db.Transactions.Where(p => p.PartyId == clientId && p.TransactionType.Equals("Credit")).ToList().Count>0)
                    {
                        recieveAmount = db.Transactions.Where(p => p.PartyId == clientId && p.TransactionType.Equals("Credit")).ToList().Sum(p=>p.Amount);//.p.Id(db.ReverseEntries.Where(r=>r.TableName.Equals("Projects"))));
                    }

                   
                        if (db.ReverseEntries.Where(r => r.TableName.Equals("Project")&&r.Transaction.PartyId.Equals(clientId)).ToList().Count>0)
                        {
                            reverseRecieve = db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.PartyId.Equals(clientId)).ToList().Sum(r => r.Amount);
                        }
                    
                    // Expenditure
                      long expenditure = 0, reverseExpenditure = 0;
                    List<Project> clientAllProjects = db.Projects.Where(p => p.Party.Id.Equals(clientId)).ToList();
                   
                    foreach (Project proj in clientAllProjects)
                    {
                        if(db.Transactions.Where(p => p.ProjectId == proj.Id && p.Party.CompanyType.Equals("Vendor") && p.TransactionType.Equals("Debit")).ToList().Count>0)
                        {
                                 expenditure += db.Transactions.Where(p => p.ProjectId == proj.Id && p.Party.CompanyType.Equals("Vendor") && p.TransactionType.Equals("Debit")).ToList().Sum(t=>t.Amount);
                        }
                        if (db.ReverseEntries.Where(r =>r.TableName.Equals("Project")&&r.Transaction.ProjectId.Equals(proj.Id)&&r.Transaction.Party.CompanyType.Equals("Vendor")).ToList().Count>0)
                            {
                                reverseExpenditure += db.ReverseEntries.Where(r => r.TableName.Equals("Project") && r.Transaction.ProjectId.Equals(proj.Id) && r.Transaction.Party.CompanyType.Equals("Vendor")).ToList().Sum(r=>r.Amount);
                            }

                    }
                           
                    List<long> intList = new List<long>();
                    intList.Add(recieveAmount-reverseRecieve);
                    intList.Add(expenditure-reverseExpenditure);
                    return intList;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }  
       public List<Party> getVendor(int projectId)
       {
           try
            {
                ZamsEntities6 db = new ZamsEntities6();
                using (db)
                {
                  return db.ContractParties.Where(p => p.ProjectId == projectId && p.Party.CompanyType.Equals("Vendor")).Select(p => p.Party).OrderBy(t=>t.Party_Name).ToList();

                }
           }
 
            catch (Exception e)
            {
                return null;
            }
       }
        //////////////////// Save Bank Debit
       public int SaveTransactionBank(BankTransaction bankTransaction)
       {
           ZamsEntities6 db = new ZamsEntities6();

           using (db)
           {

               try
               {
                   ///////////////// Save Bank Transaction
                   Bank b = db.Banks.FirstOrDefault(b1 => b1.Id == bankTransaction.BankId);
                   Bank center = db.Banks.Where(p => p.AccountNumber.Equals("999999") && p.Branch.Equals("RSS")).FirstOrDefault();
                   if (b != null)
                   {
                       if (bankTransaction.TransactionType.Equals("Credit"))
                       {
                           bankTransaction.Balance = b.Balance - bankTransaction.Amount;
                           b.Balance = bankTransaction.Balance;
                           bankTransaction.AllBankBalance = center.Balance - bankTransaction.Amount;
                           center.Balance = bankTransaction.AllBankBalance;

                       }
                       else
                       {
                           bankTransaction.Balance = b.Balance + bankTransaction.Amount;
                           b.Balance = bankTransaction.Balance;
                           bankTransaction.AllBankBalance = center.Balance + bankTransaction.Amount;
                           center.Balance = bankTransaction.AllBankBalance;
                       }
                   }
                   db.BankTransactions.Add(bankTransaction);
                   return db.SaveChanges();
               }
               catch (Exception e)
               {
                   return 0;
               }

           }
       }
        // end of functions
    }
}

