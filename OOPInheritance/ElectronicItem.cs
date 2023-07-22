using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance {
    public class ElectronicItem {
		//name,model,unitPrice=-$100,manufacturedDate,manufacturedCompany
		private string name;
		public  string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string model;
		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		private decimal unitPrice;
		public decimal UnitPrice
		{
			get { return unitPrice; }
			set {
				if (value < 0) {
					throw new ArgumentException("minimun unit price is zero");
				}
				unitPrice = value; //-100
			}
		}

		private bool enableInternet;
		public bool EnableInternet
		{
			get { return enableInternet; }
			set { enableInternet = value; }
		}


		public DateTime ManufacturedDate { get; set; }
		public string ManufacturedCompany { get; set; }

		public void PowerOn() {
			Console.WriteLine($"{name} is power on.");
		}

        public void PowerOff() {
            Console.WriteLine($"{name} is power Off.");
        }

		public void PlugIn() {
            Console.WriteLine($"{name} is plug in.");
        }

		//method overrding 
		public virtual void Specification() {
			Console.WriteLine($"Model :{model}");
            Console.WriteLine($"Unt Price :{UnitPrice}");
            Console.WriteLine($"Name :{name}");
            Console.WriteLine($"ManufacturedCompany :{ManufacturedCompany}");
            Console.WriteLine($"ManufacturedDate :{ManufacturedDate}");
        }
    }
}
