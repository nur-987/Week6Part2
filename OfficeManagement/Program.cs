using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagement
{
    /// <summary>
    /// all functions complete
    /// missing: Upload all info into File.Txt
    /// </summary>
    class Program
    {
        public static List<User> userList = new List<User>();
        static void Main(string[] args)
        {
            bool b = true;
            InstantiateSuperAdmin();
            InstantiateAdmin();

            while (b)
            {
                Console.WriteLine("1) Add User 2) Delete User 3) Assign Task 4) View Task assigned 5) Submit report");
                int res = Int32.Parse(Console.ReadLine());
                if (res == 1)
                {
                    if (!CheckSuperAdmin())
                    {
                        Console.WriteLine("user is not Super Admin. Access denied!");
                    }
                    else
                    {
                        AddUser();
                    }

                }
                if (res == 2)
                {
                    if (!CheckSuperAdmin())
                    {
                        Console.WriteLine("user is not Super Admin. Access denied!");
                    }
                    else
                    {
                        DeleteUser();
                    }
                }
                if (res == 3)
                {
                    if (!CheckAdmin())
                    {
                        Console.WriteLine("user is not Admin. Access denied!");
                    }
                    else
                    {
                        AssignTask();
                    }
                }
                if (res == 4)
                {
                    ViewTaskForSelectedUser();
                }
                if (res == 5)
                {
                    SubmitReport();
                }
            }
            


            Console.ReadLine();
        }

        public static bool CheckSuperAdmin()
        {
            //check that user = superAdmin
            Console.WriteLine("user ID");
            int userID = Int32.Parse(Console.ReadLine());

            foreach(User item in userList)
            {
                if(item.Id == userID)
                {
                    item.Position = Position.SuperAdmin;
                    Console.WriteLine("User is a Super Admin. Proceed to next fuction.");
                    return true;
                }
            }
            return false;
            
        }
        public static bool CheckAdmin()
        {
            //check that user = superAdmin
            Console.WriteLine("user ID");
            int userID = Int32.Parse(Console.ReadLine());

            foreach (User item in userList)
            {
                if (item.Id == userID)
                {
                    item.Position = Position.Admin;
                    Console.WriteLine("User is a Admin. Proceed to next fuction.");
                    return true;
                }
            }
            return false;

        }
        public static void AddUser()
        {
            Console.WriteLine("-------Adding User-------");
            User user = new User();
            
            Console.WriteLine("user ID?");
            int tempId = Int32.Parse(Console.ReadLine());
            user.Id = tempId;

            Console.WriteLine("user POSITION? 1) User 2) Admin 3) Super Admin");
            int res = Int32.Parse(Console.ReadLine());
            if (res == 1)
            {
                user.Position = Position.User;
            }
            if (res == 2)
            {
                user.Position = Position.Admin;
            }
            if (res == 3)
            {
                user.Position = Position.SuperAdmin;
            }

            userList.Add(user);
            Console.WriteLine("number of users in total: " + userList.Count());
            Console.WriteLine("new user added");

        }

        public static void DeleteUser()
        {
            //check that user = superAdmin 
            //use method

            Console.WriteLine("-------Deleting User-------");
            User user = new User();

            Console.WriteLine("User ID?");
            int tempId = Int32.Parse(Console.ReadLine());

            foreach (User item in userList)
            {
                if (item.Id == tempId)
                {
                    userList.Remove(item);

                }
            }
            Console.WriteLine("user deleted");
            Console.WriteLine("number of users in total: " + userList.Count());
        }

        public static void InstantiateSuperAdmin()
        {
            User user = new User();
            user.Id = 1;
            user.Position = Position.SuperAdmin;
            userList.Add(user);
        }

        public static void InstantiateAdmin()
        {
            User user = new User();
            user.Id = 2;
            user.Position = Position.Admin;
            userList.Add(user);

            //temporary 
            //instaniate user 
            User user1 = new User();
            user1.Id = 3;
            user1.Position = Position.User;
            userList.Add(user1);

        }

        public static void AssignTask()
        {
            Console.WriteLine("task description?");
            string task = Console.ReadLine();

            Console.WriteLine("For which user? input ID");
            int tempId = Int32.Parse(Console.ReadLine());

            foreach (User item in userList)
            {
                if (item.Id == tempId)
                {
                    item.Task = task;
                    Console.WriteLine("task added. please check details below:");
                    Console.WriteLine("id: " + item.Id);
                    Console.WriteLine("position: " + item.Position.ToString());
                    Console.WriteLine("task: " + item.Task);
                    Console.WriteLine("completed: " + item.CompleteReport);
                }
            }
            
        }

        public static void ViewTaskForSelectedUser()
        {
            Console.WriteLine("user id?");
            int tempId = Int32.Parse(Console.ReadLine());

            foreach (User item in userList)
            {
                if (item.Id == tempId)
                {
                    Console.WriteLine("task details below:");
                    Console.WriteLine("id: " + item.Id);
                    Console.WriteLine("position: " + item.Position.ToString());
                    Console.WriteLine("task: " + item.Task);
                    Console.WriteLine("completed: " + item.CompleteReport);
                }
            }

        }

        public static void SubmitReport()
        {
            Console.WriteLine("user id?");
            int tempId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("type report");
            string report = Console.ReadLine();

            foreach (User item in userList)
            {
                if (item.Id == tempId)
                {
                    item.Report = report;
                    item.CompleteReport = true;

                    Console.WriteLine("check details below");
                    Console.WriteLine("id: " + item.Id);
                    Console.WriteLine("position: " + item.Position.ToString());
                    Console.WriteLine("task: " + item.Task);
                    Console.WriteLine("report: " + item.Report);
                    Console.WriteLine("Completed: " + item.CompleteReport);

                }
            }


        }
    }



}
