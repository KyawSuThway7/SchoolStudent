using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolStudent
{
    class Program
    { 
        static void Main(string[] args)
        {
            Dboperation dBOperation = new Dboperation();
            string select = "";
            do
            {
                ShowMenu();
                select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        {
                            Console.WriteLine("Id\tName\tPhone\tEmail\tAdress");
                            UserModle Students = new UserModle()
                            {
                                id = 12,
                                name = "Kyaw su ",
                                phone = " 09791756",
                                Email = "Kyaw@gmail.com",
                                Adress = "Shwe"

                            };

                            bool saveProcess = dBOperation.SaveUser(Students);
                            if (saveProcess)
                            {
                                Console.WriteLine("save process is complete successfully!");
                            }
                        }
                        break;
                    case "2":
                        {
                            List<UserModle> Student1 = Dboperation.GetAllUser();
                            foreach (UserModle u in Student1)
                            {
                                Console.WriteLine(u.id + " " + u.name + " " + u.Email + " " + u.Adress + " " + u.phone);
                            }
                            Console.WriteLine("==================================");
                        }
                        break;
                    case "3":
                            {
                            bool deleteprocess = dBOperation.deleteUser(12);
                            if(deleteprocess)
                            {
                                Console.WriteLine("Delete Process is successfuly completed");
                            }

                        }break;
                    case "4":
                        {
                            Console.WriteLine("Thank For Using My app");
                            Console.WriteLine("Press any key to the Window");
                            Console.ReadLine();

                        }
                        break;

                }
                
            } while (select != "4");
          
        }
        public static void ShowMenu()
        {
            Console.WriteLine("Please Selected Operator");
            Console.WriteLine("Press 1 : Save ");
            Console.WriteLine("Press 2 : Show Information");
            Console.WriteLine("Press 3 : delete ");
            Console.WriteLine("Press 4 : Exist");
        }
    }
}
