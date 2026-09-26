/*C# Constructor Challenge — Car
Create a small program where you practice constructors, objects, and object methods.
1. Create a class called Car.
2. Give every car these fields:
   - brand
   - model
   - speed
   - fuel
3. Create a constructor that receives values for all four fields.
4. In Main, create two different Car objects using the constructor. Give them different brands/models and different starting fuel.
5. Create a method called ShowInfo().
   - Print the car's brand and model.
   - Print its current speed.
   - Print its current fuel.
6. Create a method called Drive().
   - Increase speed by 10.
   - Decrease fuel by 5.
   - If there isn't enough fuel, the car shouldn't drive.
   - Print a message if the car has no fuel.
7. Create a method called Refuel().
   - Add 20 fuel.
   - Fuel cannot go above 100.
8. In Main, test both cars separately:
   - Show their information.
   - Drive one car a few times.
   - Refuel it.
   - Show its information again.
   - Make sure changing one car doesn't change the other car.*/

using System;

namespace LearningCSharp
{
    class Car
    {
        public string brand;
        public string model;
        public int speed;
        public int fuel;

        public Car(string model, string brand, int speed, int fuel)
        {
            this.brand = brand;
            this.model= model;
            this.speed = speed;
            this.fuel = fuel;
        }

        public void ShowInfo()
        {
            Console.WriteLine("The brand is "+brand+", the model is "+model+" and the speed is "+speed+" while the fuel is "+fuel);
        }

        public void Drive()
        {
            if (fuel < 5)
            {
                Console.WriteLine("The "+model+" has no fuel go refuel");
            }
            else
            {
                fuel -= 5;
                speed += 10;
            }
        }

        public void Refuel()
        {
            if(fuel > 80)
            {
                Console.WriteLine("You cannot refuel at the current time.");
            }
            else
            {
                fuel += 20;
            }
        }
    }

    class MainP
    {
        public static void MainG()
        {
            Car car1 = new Car("A3", "Audi", 120, 100);
            Car car2 = new Car("Revuelto", "Lamborghini", 280, 100);

            car1.ShowInfo();
            car2.ShowInfo();

            for(int i = 0; i <= 5; i++)
            {
                car1.Drive();
                car1.ShowInfo();
            }

            for(int i = 0; i <= 3; i++)
            {
                car1.Refuel();
                car1.ShowInfo();
            }

            for(int i = 0; i <= 5; i++)
            {
                car2.Drive();
                car2.ShowInfo();
            }

            for(int i = 0; i <= 3; i++)
            {
                car2.Refuel();
                car2.ShowInfo();
            }
            
        }

    }
}