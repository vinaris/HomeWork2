using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Driver
    {
        public Driver(DateTime date, string name)
        {
            LicenseDate = date;
            Name = name;
        }

        public DateTime LicenseDate { get; }
        public string Name { get; }
        public int Experience
        {
            get
            {
                int age = DateTime.Today.Year - LicenseDate.Year;
                if (LicenseDate > DateTime.Today.AddYears(-age)) age--;
                return age;
            }
        }
        public string Category { get; set; }
        public Car Car { get; private set; }

        public void OwnCar(Car car)
        {
            if (Category.Contains(car.Category))
            {
                Car = car;
            }
            else
            {
                throw new Exception($"У водителя {Name} нет прав на вождение автомобилей категории {car.Category}");
            }
        }
    }
}
