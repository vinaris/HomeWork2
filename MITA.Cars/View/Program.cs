using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //FR001
            var model = "Лада";
            var category = 'D';
            var car = new Car(model, category) { Color = Color.DarkMagenta };

            //FR002
            try
            {
                Console.WriteLine("Имя владельца {0}: {1}", car.Model, car.CarPassport.Owner.Name);
            }
            catch (NullReferenceException exeption)
            {
                Console.WriteLine("Владельца {0} не существует! Сообщение об ошибке: {1}", car.Model, exeption.Message);
            }

            //FR003
            var driverName = "Вольдемар";
            var driverCategory = "BC";
            var driver = new Driver(new DateTime(2010, 11, 20), driverName) { Category = driverCategory };

            //FR004
            var carNumber = "o777oo";
            try
            {
                car.ChangeOwner(driver, carNumber);
            }
            catch (NoCategoryException exception)
            {
                Console.WriteLine(exception.Message);
            }

            //FR005
            if (!driverCategory.Contains('D')) driver.Category += "D";
            try
            {
                car.ChangeOwner(driver, carNumber);
            }
            catch (NoCategoryException exception)
            {
                Console.WriteLine(exception.Message);
            }

            //FR006
            Console.WriteLine("Номер машины {0}: {1}", driver.Name, driver.Car.CarNumber);

            //FR007
            Console.WriteLine("Имя владельца {0}: {1}", car.Model, car.CarPassport.Owner.Name);

            Console.ReadKey();
        }
    }
}
