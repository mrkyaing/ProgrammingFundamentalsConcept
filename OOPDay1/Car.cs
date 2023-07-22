using System;

namespace OOPDay1 {
    public class Car {

        public string LicenceNo; //state of car class 
        public string Model;
        public string Engine;
        public string Color;
        public string GearNo;
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
