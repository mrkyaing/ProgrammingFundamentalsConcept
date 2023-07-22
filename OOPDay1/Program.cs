using OOPDay1;
using System.Runtime.CompilerServices;

Console.WriteLine("OOP Day1");

Car myCar = new Car();//create the object  / instance of class 
myCar.LicenceNo = "YGN-101";
myCar.Color = "Green";
myCar.Model = "M2019";
myCar.Engine = "1J-1236547";
myCar.GearNo = "D";
myCar.DisplayInfo();
myCar.StartEngine();
myCar.Drive(myCar.GearNo);
myCar.PlayHorn();
myCar.StopEngine();
Console.WriteLine("=======================");

Car yourCar = new Car();
yourCar.LicenceNo = "MDY-101";
yourCar.Color = "Black";
yourCar.Model = "Y2020";
yourCar.Engine = "1J-8527419";
yourCar.DisplayInfo();
yourCar.StartEngine();
yourCar.StopEngine();
Console.WriteLine("=======================");

Car bmw = new Car();
bmw.Engine = "1J-9874561";
bmw.Color = "red";
bmw.Model = "M2020";
bmw.LicenceNo = "YGN-103";
bmw.DisplayInfo();
bmw.StartEngine();
bmw.StopEngine();

Console.WriteLine("=======================");
TruckCar toyota=new TruckCar();
toyota.LicenceNo = "YGN-202";
toyota.Color = "Black";
toyota.Engine = "JP-506";
toyota.Model = "TOYOTA2021";
toyota.GearNo = "D";
toyota.DisplayInfo();
toyota.LoadingTon = 10;
toyota.LoadGoods(50);
