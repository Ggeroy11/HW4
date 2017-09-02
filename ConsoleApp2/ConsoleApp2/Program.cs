using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountCar=5;
            Car[] car = new Car[amountCar];
            for(int i = 0; i < amountCar; i++) {
                car[i] = new Car();
            }
            

        }
    }
}
