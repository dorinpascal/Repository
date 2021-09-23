using System;
using System.Collections.Generic;

namespace Ex._4
{
    public class CarList
    {
        public List<Car> GetCars()
        {
            return new()
            {
                
                new Car() {Color="Green",EngineSize = 1.3,IsManuelShift = true},
                new Car() {Color="Green",EngineSize = 1.4,IsManuelShift = false},
                new Car() {Color="Blue",EngineSize = 1.3,IsManuelShift = true}
            };
        }


        public  void Run()
        {
            List<Car> cars = new CarList().GetCars();
            List<Car> sameColor = cars.FindAll(car => car.IsManuelShift);
            Console.WriteLine(sameColor);
          
        }
    }
}