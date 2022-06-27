using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0);
            Console.Write("How much gasoline would you like to refuel?\n");
            int refuelQty = int.Parse(Console.ReadLine());
            car.refuel(refuelQty);
            car.Drive();
        }
    }

    interface IVehiculo
    {
        void Drive();
        bool refuel(int gasAmount);
    }

    class Car
    {
     int currentGasAmount;
     public Car(int initialGasAmount){
         currentGasAmount=initialGasAmount;
}   
     public void Drive(){
         if(currentGasAmount>0){
             Console.WriteLine("Car is driving");
         }
         else
         {
             Console.Write("You are out of gas. Refuel");
         }
     }
     public bool refuel(int gasAmount){
       currentGasAmount +=gasAmount;
       return true;
     }
    }
}
