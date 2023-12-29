using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListManagement
{
    internal class UserManager
    {
        user usr=new user();
        TodosListDataContext db=new TodosListDataContext();
        public bool createUser(string email,string password,string name)
        {
            usr.email = email;
            usr.password = password;
            usr.name = name;
            try
            {
                db.users.InsertOnSubmit(usr);  
                db.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public int getUidByEmail(string email)
        {
            usr=db.users.Single(usr=>usr.email == email);
            return usr.uid;
        }
        public bool loginConfirm(string email,string password) 
        {
            usr=db.users.Single(usr=>usr.email == email);
            if (usr!=null)
            {
                if (usr.password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
