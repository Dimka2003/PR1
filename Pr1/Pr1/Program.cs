using System;

namespace Pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Lake a = new Lake();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1 - Добавить реку" + " " +
                "2 - Вывести реку" + " " + "3 - Выход");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        {
                            a.Input();
                            break;
                        }
                    case 2:
                        {
                            a.Print();
                            break;
                        }
                    default:
                        {
                            flag = false;
                            break;
                        }
                }
            }
        }
    }
}
