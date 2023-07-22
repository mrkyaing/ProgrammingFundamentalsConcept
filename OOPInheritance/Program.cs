using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance {
    public class Program {
        static void Main(string[] args) {
            SmartPhone myPhone=new SmartPhone();
            myPhone.Name = "SAMSAUNG";
            myPhone.UnitPrice = 350000;
            myPhone.SimCardNo = "+959256275319";
            myPhone.ManufacturedDate =Convert.ToDateTime("2021-10-10");
            myPhone.ManufacturedCompany = "SAMSAUNG Co,LTD";
            myPhone.EnableInternet = true;
            myPhone.CPU = "macro23";
            myPhone.RAM = "6GB";
            myPhone.Storage = "128BG";
            myPhone.Model = "A21";
            myPhone.EnableCamera = true;
            myPhone.PlugIn();
            myPhone.PowerOn();
            myPhone.TakePhoto();
            myPhone.Specification();
            Console.WriteLine("==================");
           
            CordPhone homePhone = new CordPhone();
            homePhone.Name = "PANOSONIC";
            homePhone.UnitPrice = 30000;
            homePhone.SimCardNo = "+01963562";
            homePhone.ManufacturedDate = Convert.ToDateTime("2010-10-10");
            homePhone.ManufacturedCompany = "PANOSONIC Co,LTD";
          
            homePhone.EnableInternet = false;
            homePhone.CPU = "macro23";
            homePhone.RAM = "1MB";
            homePhone.Storage = "50MB";
            homePhone.EnableCamera = false;
            homePhone.Model = "p203";
            homePhone.PlugIn();
            homePhone.PowerOn();
            homePhone.TakePhoto();
            homePhone.Specification();
            Console.WriteLine("==================");
            Console.WriteLine("press any key to close this window");
            Console.ReadKey();
        }
    }
}
