using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseOperator
    {
        static void AddUserInDB(User u)
        {
            DBase dBase = new DBase();
            dBase.Users.Add(u);
            dBase.SaveChanges();
        }
    }
}
