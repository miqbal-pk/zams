using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAMS.DAL
{
    class ZAMSFactory
    {
        public  static ZAMS_DAL DataBase { get; set; }
        static ZAMSFactory()
        {
            if (DataBase == null)
            {
                DataBase = new ZAMS_DAL();
            }
        }
    }
}
