using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListManagement
{
    internal class Helper
    {
        public int intInput()
        {
            try
            {
                int x = int.Parse(Console.ReadLine());
                return x;
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.Message);
                return -1; 
            }
        }
        public int loginUser()
        {
            UserManager userManager = new UserManager();
            Console.WriteLine("Enetr Email");
            string email=Console.ReadLine();
            Console.WriteLine("Enter password");
            string password=Console.ReadLine();
            if(userManager.loginConfirm(email, password))
            {
                return userManager.getUidByEmail(email);
            }
            else
            {
                return 0;
            }
        }
        public void registerUser()
        {
            UserManager userManager = new UserManager();
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Name");
            string name=Console.ReadLine();
            bool r=userManager.createUser(email, password, name);
            if(!r)
            {
                Console.WriteLine("Something wrong in registration");
            }
        }

        public void addNewTask(int uid)
        {
            TodoManager todoManager = new TodoManager();
            Console.WriteLine("Enter task\n");
            string task = Console.ReadLine();
            todoManager.saveTodo(task, uid);
        }
        public void taskCompleted(int uid)
        {
            TodoManager todoManager = new TodoManager();
            Console.WriteLine("Enter task id");
            int tid = intInput();
            if (tid > 0)
            {
                todoManager.completed(tid,uid);
            }
        }
        public void deleteTask(int uid)
        {
            TodoManager todoManager = new TodoManager();
            Console.WriteLine("Enter task id");
            int tid =intInput();
            if (tid > 0)
            {
                todoManager.delete(tid, uid);
            }
        }
        public void showList(int uid)
        {
            TodoManager todoManager = new TodoManager();
            todoManager.showTodos(uid);
        }
    }
}
