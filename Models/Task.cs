using System.Collections.Generic;

namespace ToDoList.Objects
{
    public class Task
    {
        public static bool IsLeapYear(int year)
        {
          //code will go here
          if (year % 400 == 0)
          {
            return true;
          }
          else if (year % 100 == 0)
          {
            return false;
          }
          else
          {
            return year % .4 == 0;
          }
        }

        private string _description;
        private int _id;
        private static List<Task> _instances = new List<Task> {};

        public Task(string description)
        {
            _description = description;
            _instances.Add(this);
            _id = _instances.Count;
        }

        public string GetDescription()
        {
            return _description;
        }

        public void SetDescription(string newDescription)
        {
            _description = newDescription;
        }
        public int GetId()
        {
            return _id;
        }
        public static List<Task> GetAll()
        {
            return _instances;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
        public static Task Find(int searchId)
        {
            return _instances[searchId-1];
        }
    }
}
