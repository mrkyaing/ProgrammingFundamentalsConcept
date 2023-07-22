using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay2 {
    internal class Car {
        protected string LicenceNo; //state of car class 
        protected string Model;
        protected string Engine;
        protected string Color;
        protected string GearNo;
        //behavior of car 
        public void PlayHorn() {
            Console.WriteLine("T.T.T");
        }
        public void StartEngine() {
            Console.WriteLine("Engine is started");
        }
        public void StopEngine() {
            Console.WriteLine("Engine Stopped");
        }
        private void ChangePinion() {
            Console.WriteLine("Pinion is changine");
        }
        public void Drive(string gearNo) {
            ChangePinion();
            Console.WriteLine("Driving with Gear :" + gearNo);
        }
        public void DisplayInfo() {
            Console.WriteLine("Color :" + Color);
            Console.WriteLine("Model :" + Model);
            Console.WriteLine("Engine :" + Engine);
            Console.WriteLine("Licence No:" + LicenceNo);
        }
    }
}
