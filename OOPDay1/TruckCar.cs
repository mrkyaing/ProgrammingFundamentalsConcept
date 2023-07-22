using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay1 {
     class TruckCar :Car {
        public int LoadingTon;//10
        public int SparingWheels;
        public void LoadGoods(int loadItem) {
            if (IsFull(loadItem)) {
                Console.WriteLine("Maximun Loading the Goods " + LoadingTon);
            }
            else {
                Console.WriteLine("Load Ton is " + loadItem);
            }
        }
        private bool IsFull(int loadItem) {
            if (loadItem > LoadingTon) {//5>10
                Console.WriteLine("can't load over ton");
                return true;
            }
            else if (LoadingTon == loadItem) {//10==10
                return true;
            }
            else { return false; }
        }
        private bool IsEmpty() {
            if (LoadingTon == 0) {
                return true;
            }
            else {
                return false;
            }
        }
        public void DropGoods() {

            Console.WriteLine("Droping the Goods " + LoadingTon);
        }
    }
}
