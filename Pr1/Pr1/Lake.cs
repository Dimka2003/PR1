using System;
using System.Collections.Generic;
using System.Text;

namespace Pr1
{
    class Lake
    {
        public string Name { get; set; }
        public double Square { get; set; }
        public double Length { get; set; }
        public Lake()
        {
            Name = "";
            Square = 0;
            Length = 0;
        }
        public Lake(string name, double Square, double Length)
        {
            this.Name = name;
            this.Square = Square;
            this.Length = Length;

        }
        public void Print()
        {
            Console.Write($"Название: {Name}\n" +
                              $"Площадь бассейна: {Square}\n" +
                              $"Протяженность: {Length}\n");
        }
        public void Input()
        {
            Console.Write("Введите название: ");
            this.Name = Console.ReadLine();
            Console.Write("Введите площадь бассейна: ");
            this.Square = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите протяженность: ");
            this.Length = Convert.ToInt32(Console.ReadLine());
        }
    }
}
