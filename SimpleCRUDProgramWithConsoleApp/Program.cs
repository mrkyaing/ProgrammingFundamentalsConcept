using System;
using System.Collections.Generic;

namespace SimpleCRUDProgramWithConsoleApp {
     class Program {
      static UserDbOperations userDbOperations = new UserDbOperations();
        static void Main(string[] args) {
            string choice = null;
            do {
                Console.Write("please choose a operation c(create),r(reterive),u(update),d(delete),e(exist):");
                choice = Console.ReadLine();//r
                switch (choice) {
                    case "c": CreateArecord(); break;
                    case "r": ReteriveRecords(); break;
                    case "u": UpdateArecord(); break;
                    case "d": DeleteRecord(); break;
                }
            } while (choice != "e") ;

            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }

        public static void CreateArecord() {
            UserModel u1 = new UserModel();

            Console.Write("type user Id");
            u1.Id =Convert.ToInt32( Console.ReadLine());

            Console.Write("type user Name:");
            u1.UserName = Console.ReadLine();

            Console.Write("type user Email:");
            u1.Email = Console.ReadLine();

            Console.Write("type user Password:");
            u1.Password = Console.ReadLine();

            u1.IsDelete = false;
            u1.CreatedAt = DateTime.Now;

            bool IsSuccess = userDbOperations.SaveUser(u1);
            if (IsSuccess) {
                Console.WriteLine("1 user created successfully.");
                ReteriveRecords();
            }
            else {
                Console.WriteLine("user creation process is failed.");
            }
        }
        public static void ReteriveRecords() {
            List<UserModel> users = userDbOperations.GetUsers();
            foreach (UserModel user in users) {
                Console.WriteLine($"User Id:{user.Id}");
                Console.WriteLine($"User Email:{user.Email}");
                Console.WriteLine($"User UserName:{user.UserName}");
                Console.WriteLine($"User IsDelete:{user.IsDelete}");
                Console.WriteLine($"User CreatedAt:{user.CreatedAt}");
                Console.WriteLine("=========================");
            }

        }
        public static void DeleteRecord() {
            Console.Write("type user Id to delete ");
            int Id = Convert.ToInt32(Console.ReadLine());
           
            bool IsDeleteSuccess = userDbOperations.DeleteByUserId(Id);
            if (IsDeleteSuccess) {
                Console.WriteLine("1 user deleted successfully.");
                ReteriveRecords();
            }
            else {
                Console.WriteLine("user delete process is failed.");
            }
        }

        public static void UpdateArecord() {
            UserModel u1 = new UserModel();
            Console.Write("type user Id to update ");
            u1.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("type user Name:");
            u1.UserName = Console.ReadLine();
            Console.Write("type user Email:");
            u1.Email = Console.ReadLine();

            Console.Write("type user Password:");
            u1.Password = Console.ReadLine();

            u1.CreatedAt = DateTime.Now;

            bool IsSuccess = userDbOperations.UpdateUser(u1);
            if (IsSuccess) {
                Console.WriteLine("1 user updated successfully.");
                ReteriveRecords();
            }
            else {
                Console.WriteLine("user updating process is failed.");
            }
        }
    }
}
