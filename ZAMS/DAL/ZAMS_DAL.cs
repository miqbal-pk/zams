using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZAMS.Model;

namespace ZAMS.DAL
{
    class ZAMS_DAL
    {
        //Database1Entities1 db;
        public ZAMS_DAL()
        {
            //db = new Database1Entities1();
        }
        public List<PartyDummy> GetCompanies()
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                return db.Parties.Select(p => new PartyDummy { Id = p.Id, Party_Name = p.Party_Name, Location = p.Location, PhoneNumber = p.PhoneNumber, FaxNumber = p.FaxNumber, OwnerName = p.OwnerName, Email = p.Email }).ToList();

            }
        }
        public List<PartyDummy> GetCompanies1()
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                return db.Parties.Where(p=>p.Party_Name!="Zakriya Construction").Select(p => new PartyDummy { Id = p.Id, Party_Name = p.Party_Name, Location = p.Location, PhoneNumber = p.PhoneNumber, FaxNumber = p.FaxNumber, OwnerName = p.OwnerName, Email = p.Email }).ToList();

            }
        }
        public List<ProjectDummy> GetProjectsDummy()
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                return db.Projects.Select(p => new ProjectDummy { Id = p.Id, ProjectName = p.ProjectName, OwnerPartyId = p.OwnerPartyId, Credit = p.Credit, EstimatedStartDate = p.EstimatedStartDate, StartDate = p.StartDate, Status = p.Status, EstimatedEndDate = p.EstimatedEndDate, EndDate = p.EndDate, InitialBalance = p.InitialBalance, CurrentBalance = p.CurrentBalance }).ToList();
            }
        }
        public Party GetCompanyByName(string name)
        {
            Database1Entities1 db = new Database1Entities1();
            return db.Parties.Where(p => p.Party_Name.Equals(name)).First();
        }
        public Project GetProjectByName(string name)
        {
            Project proj = new Project();
            Database1Entities1 db = new Database1Entities1();


            proj = db.Projects.Where(p => p.ProjectName.Equals(name)).First();

            return proj;
        }

        public List<Party> getCompanies1()
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                return db.Parties.Where(p => p.Party_Name != "Zakriya Construction").ToList();


            }
        }
        public List<Project> GetProjects()
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                return db.Projects.ToList();

            }
        }
        public int SaveCompany(Party party)
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                db.Parties.Add(party);
                return db.SaveChanges();
            }


        }
        public int SaveProject(Project proj)
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                db.Projects.Add(proj);
                return db.SaveChanges();
            }

        }
        public string getCompanyId(string name)
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                Party id = db.Parties.Where(p => p.Party_Name.Equals(name)).First();
                return id.Id.ToString();
            }


        }
        public string getProjectId(string name)
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                Project project = db.Projects.Where(p => p.ProjectName.Equals(name)).First();
                return project.Id.ToString();
            }

        }
        public int SaveTransaction(Transaction transaction)
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                db.Transactions.Add(transaction);
                return db.SaveChanges();
            }
        }
        public List<Party> getContractParty(string id)
        {
            Database1Entities1 db = new Database1Entities1();
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
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                List<Transaction> transactions = db.Transactions.Where(p => p.DateTime >= startDate && p.DateTime <= endDate && p.ProjectId == projectId && p.PayerId == partyId && p.RecipientId == partyId).ToList();
                return transactions;
            }
        }
        public List<TransactionDummy> getTransactionByTime(DateTime startDate, DateTime endDate)
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                List<TransactionDummy> transactions = db.Transactions.Where(p => p.DateTime >= startDate && p.DateTime <= endDate).Select(p => new TransactionDummy { Id = p.Id, DateTime = p.DateTime, Amount = p.Amount, TransactionType = p.TransactionType, Description = p.Description, OtherDetails = p.OtherDetails, ProjectName = p.Project.ProjectName, PayerName = p.Party.Party_Name, RecipientName = p.Party1.Party_Name }).ToList();
                return transactions;
            }
        }
        public string getprojectName(int id)
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                Project projects = db.Projects.Where(p => p.Id == id).First();
                return projects.ProjectName;
            }
        }
        public List<TransactionDummy> GetTransactionsByCompany(int companyId)
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                return db.Transactions.Where(p => p.Party.Id == companyId || p.Party1.Id == companyId).Select(p => new TransactionDummy { Id = p.Id, DateTime = p.DateTime, Amount = p.Amount, TransactionType = p.TransactionType, Description = p.Description, OtherDetails = p.OtherDetails, ProjectName = p.Project.ProjectName, PayerName = p.Party.Party_Name, RecipientName = p.Party1.Party_Name }).ToList();
            }
        }
        public List<TransactionDummy> GetTransactionsByProject(int projectId)
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                return db.Transactions.Where(p => p.Project.Id == projectId).Select(p => new TransactionDummy { Id = p.Id, DateTime = p.DateTime, Amount = p.Amount, TransactionType = p.TransactionType, Description = p.Description, OtherDetails = p.OtherDetails, ProjectName = p.Project.ProjectName, PayerName = p.Party.Party_Name, RecipientName = p.Party1.Party_Name }).ToList();
            }
        }
        public List<TransactionDummy> GetTransactionsByCompanyAndProject(int companyId, int projectId)
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                return db.Transactions.Where(p => p.Project.Id == projectId && (p.Party.Id == companyId || p.Party1.Id == companyId)).Select(p => new TransactionDummy { Id = p.Id, DateTime = p.DateTime, Amount = p.Amount, TransactionType = p.TransactionType, Description = p.Description, OtherDetails = p.OtherDetails, ProjectName = p.Project.ProjectName, PayerName = p.Party.Party_Name, RecipientName = p.Party1.Party_Name }).ToList();
            }
        }
        public List<long> getPaidAmountAll(int id)
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                long pay = 0, received = 0;
                //int id = int.Parse(getCompanyId("Zakriya Construction"));
                if (db.Transactions.Where(p => p.PayerId == id).ToList().Count != 0)
                    pay = db.Transactions.Where(p => p.PayerId == id).Sum(p => p.Amount);
                if (db.Transactions.Where(p => p.RecipientId == id).ToList().Count != 0)
                    received = db.Transactions.Where(p => p.RecipientId == id).Sum(p => p.Amount);
                List<long> a = new List<long>();
                a.Add(pay);
                a.Add(received);
                return a;
            }
        }

        public List<TransactionDummy> GetTransactionDummy()
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                return db.Transactions.Select(p => new TransactionDummy { Id = p.Id, DateTime = p.DateTime, Amount = p.Amount, TransactionType = p.TransactionType, Description = p.Description, OtherDetails = p.OtherDetails, ProjectName = p.Project.ProjectName, PayerName = p.Party.Party_Name, RecipientName = p.Party1.Party_Name }).ToList();
            }
        }
        public List<long> getPaidAmountAllproject()
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                long pay = 0, rec = 0;
                if (db.Transactions.Where(p => p.TransactionType.Equals("Withdraw")).ToList().Count != 0)
                    pay = db.Transactions.Where(p => p.TransactionType.Equals("Withdraw")).Sum(p => p.Amount);
                if (db.Transactions.Where(p => p.TransactionType.Equals("Deposit")).ToList().Count != 0)
                    rec = db.Transactions.Where(p => p.TransactionType.Equals("Deposit")).Sum(p => p.Amount);
                List<long> a = new List<long>();
                a.Add(pay);
                a.Add(rec);
                return a;
            }
        }
        public List<long> getPaidAmount(int id)
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                long pay = 0, rec = 0;
                if (db.Transactions.Where(p => p.TransactionType.Equals("Withdraw") && p.ProjectId == id).ToList().Count != 0)
                    pay = db.Transactions.Where(p => p.TransactionType.Equals("Withdraw") && p.ProjectId == id).Sum(p => p.Amount);
                if (db.Transactions.Where(p => p.TransactionType.Equals("Deposit") && p.ProjectId == id).ToList().Count != 0)
                    rec = db.Transactions.Where(p => p.TransactionType.Equals("Deposit") && p.ProjectId == id).Sum(p => p.Amount);
                List<long> a = new List<long>();
                a.Add(pay);
                a.Add(rec);
                return a;
            }
        }
        public int SaveContractParty(int partyId, int projectId)
        {
            Database1Entities1 db = new Database1Entities1();
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
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                long pay;
                long received;
                List<Project> pro = null;
                if (id == -1)
                {
                    pro = db.Projects.ToList();

                }
                else
                {

                    pro = db.ContractParties.Where(p => p.PartyId == id).Select(p => p.Project).ToList();

                }
                List<ProjectReprt> pr = new List<ProjectReprt>();
                foreach (Project project in pro)
                {
                    pay = 0;
                    received = 0;
                    if (db.Transactions.Where(p => p.TransactionType.Equals("Withdraw") && p.ProjectId == project.Id).ToList().Count != 0)
                        pay = db.Transactions.Where(p => p.TransactionType.Equals("Withdraw") && p.ProjectId == project.Id).Sum(p => p.Amount);

                    if (db.Transactions.Where(p => p.TransactionType.Equals("Deposit") && p.ProjectId == project.Id).ToList().Count != 0)
                        received = db.Transactions.Where(p => p.TransactionType.Equals("Deposit") && p.ProjectId == project.Id).Sum(p => p.Amount);
                    ProjectReprt p1 = new ProjectReprt();

                    p1.ProjectName = project.ProjectName;
                    p1.OwnerName = project.Party.Party_Name;
                    p1.AmountPaid = pay;
                    p1.AmountReceived = received;
                    pr.Add(p1);
                }
                return pr;
                //db.Projects.Select(p=>new ProjectReprt{ ProjectName=p.ProjectName,OwnerName=p.Party.Party_Name,AmountPaid=})
            }

        }
        public List<PartyReport> getPartyReport(int id)
        {
            Database1Entities1 db = new Database1Entities1();
            using (db)
            {
                long pay;
                long received;
                List<Party> party = null;
                if (id == -1)
                {
                    party = db.Parties.ToList();
                }
                else
                {
                    //party=db.Parties.Where(p=>p.Id==id).ToList();
                    party = db.ContractParties.Where(p => p.ProjectId == id).Select(p => p.Party).ToList();
                }
                List<PartyReport> pr = new List<PartyReport>();
                foreach (Party par in party)
                {
                    pay = 0;
                    received = 0;
                    PartyReport partyreport = new PartyReport();
                    if (db.Transactions.Where(p => p.PayerId == par.Id).ToList().Count != 0)
                        received = db.Transactions.Where(p => p.PayerId == par.Id).Sum(p => p.Amount);
                    if (db.Transactions.Where(p => p.RecipientId == par.Id).ToList().Count != 0)
                        pay = db.Transactions.Where(p => p.RecipientId == par.Id).Sum(p => p.Amount);
                    partyreport.Party_Name = par.Party_Name;
                    partyreport.OwnerName = par.OwnerName;
                    partyreport.AmountPaid = pay;
                    partyreport.AmountReceived = received;
                    pr.Add(partyreport);
                }
                return pr;
            }
        }
    }
}

