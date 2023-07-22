using System;

namespace OOPInheritance {
    //is-A relationship
    public class Phone : ElectronicItem{
		private string simCardNo;

		public string SimCardNo
        {
			get { return simCardNo; }
			set { simCardNo = value; }
		}

        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public bool EnableCamera { get; set; }
        public void TakePhoto() {
           
            if (EnableCamera) {
                Console.WriteLine("take a photo");
            }
            else {
                Console.WriteLine("Oh!! sorry ,There is no camera.");
            }
        }

        //Method overriding here .
        public override void Specification() {
            base.Specification();
            Console.WriteLine($"CUP {CPU}");
            Console.WriteLine($"RAM {RAM}");
            Console.WriteLine($"Storage {Storage}");
            Console.WriteLine($"SimCardNo {SimCardNo}");
        }
    }
}
