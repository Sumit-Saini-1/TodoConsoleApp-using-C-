using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper helper = new Helper();
            int uid = 0;
            bool lg = true;
            bool session=false;
            while (lg)
            {
                Console.WriteLine("1. to login user\n2. to create new user");
                int input = helper.intInput();
                switch (input)
                {
                    case 1:
                        uid = helper.loginUser();
                        if (uid!=0)
                        {
                            lg = false;
                        }
                        else
                        {
                            Console.WriteLine("Enter correct credential");
                        }
                        break;
                    case 2:
                        helper.registerUser();
                        break;
                    default:
                        Console.WriteLine("Enter a correct input");
                        break;
                }
            }

            while (!session)
            {
                Console.WriteLine("1. For add new task\n2. For Complete task\n3. For delete a task\n4. For Show complete list\n0. For exit");
                switch (helper.intInput())
                {
                    case 1:
                        helper.addNewTask(uid);
                        break;
                    case 2:
                        helper.taskCompleted(uid);
                        break;
                    case 3:
                        helper.deleteTask(uid);
                        break;
                    case 4:
                        helper.showList(uid);
                        break;
                    case 0:
                        session = !session;
                        break;
                    default:
                        Console.WriteLine("Enter correct input");
                        break;
                }
            }
        }
    }
}
