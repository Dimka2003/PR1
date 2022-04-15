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

    }
}
