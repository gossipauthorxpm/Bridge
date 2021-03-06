using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Volkswagen : Car, ICar
    {
        string type_of_body;
        string serial;
        Color color;

        public Volkswagen(string type_of_body, string serial, string max_speed, Color color)
        {
            this.mark = "Volkswagen";
            this.vechicle = "2 Liters";
            this.max_speed = max_speed;
            this.type_of_body = type_of_body;
            this.serial = serial;
            this.color = color;
        }

        public void ShowInfoOfCar()
        {
            Console.WriteLine($"Марка машины {mark}, серия {serial}, максимальная скорость {max_speed}, тип кузова {type_of_body}, " +
                              $"объем двигателя {vechicle}, цвет кузова {color.GetNameColor} ({color.GetHashColor})");
        }
    }
}
