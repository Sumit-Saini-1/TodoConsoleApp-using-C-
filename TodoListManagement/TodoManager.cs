using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListManagement
{
    internal class TodoManager
    {
        Todo todo=new Todo();
        TodosListDataContext db = new TodosListDataContext();
        public void saveTodo(string task,int uid)
        {
            DateTime localDate = DateTime.Now;
            todo.task = task;
            todo.addedTime = localDate;
            todo.isCompleted = "N";
            todo.uid = uid;
            db.Todos.InsertOnSubmit(todo);
            db.SubmitChanges();
        }
        public void completed(int tid,int uid)
        {
            todo=db.Todos.Single(todo=>todo.tid == tid&&todo.uid==uid);
            todo.isCompleted = "Y";
            todo.doneTime = DateTime.Now;
            db.SubmitChanges();
        }
        public void delete(int tid,int uid)
        {
            todo=db.Todos.Single(todo => todo.tid == tid&&todo.uid==uid);
            db.Todos.DeleteOnSubmit(todo);
            db.SubmitChanges();
        }
        public void showTodos(int uid)
        {
            var data=from todo in db.Todos where todo.uid==uid select todo;
            Console.WriteLine("tid  task    addedTime   isCompleted doneTime");
            foreach (var todo in data)
            {
                Console.WriteLine(todo.tid+" "+todo.task+" "+todo.addedTime+" "+todo.isCompleted+" "+todo.doneTime);
            }
        }
    }
}
