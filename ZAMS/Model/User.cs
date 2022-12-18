using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAMS.Model
{
    class User
    {

        private string UserName;

        public string Username
        {
            get { return UserName; }
            set { UserName = value; }
        }

        private string Password;

        public string Password1
        {
            get { return Password; }
            set { Password = value; }
        }

        private string Name;

        public string Name1
        {
            get { return Name; }
            set { Name = value; }
        }


        //private string conform_Password;

        //public string Conform_Password
        //{
        //    get { return conform_Password; }
        //    set { conform_Password = value; }
        //}

        private string PhoneNumber;

        public string PhoneNumber1
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }

        private string Address;

        public string Address1
        {
            get { return Address; }
            set { Address = value; }
        }

        private string AccessSpecifier;

        public string AccessSpecifier1
        {
            get { return AccessSpecifier; }
            set { AccessSpecifier = value; }
        }

  

       public User()
       { 
       }
      // public User(string username, string password, string conform_Password, string phoneNo, string address, string accessSpecifier)
       public User(string username, string password, string name ,  string phoneNo, string address, string accessSpecifier)
       {
           this.UserName = username;
           this.Password = password;
         //  this.conform_Password = conform_Password;
           this.Name = name;
           this.PhoneNumber = phoneNo;
           this.Address = address;
           this.AccessSpecifier = accessSpecifier;
       }

    }
}
