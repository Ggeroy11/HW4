using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Car
    {
        private string model;       //реализация 5 закрытых полей
        private int maxSpeed;
        private int passengerCapacity;
        private double price;
        private int horsePower;
        private static int wheelAmount; //статические поля
        private static int helmAmount;

        public string Model     //модель метод доступа к закрытым полям
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public int MaxSpeed         //максимальная скорость метод доступа к закрытым полям
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                maxSpeed = value;
            }
        }

        public double Price     //цена метод доступа к закрытым полям
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        static Car() {
            wheelAmount = 4;
            helmAmount = 1;
        }
        public Car()
        {
            this.model = null;
            this.maxSpeed = 0;
            this.passengerCapacity = 0;
            this.price = 0;
            this.horsePower = 0;
        }

        public Car(string Model, int maxspeed,int passenger,double Price,int horsePower){
            this.model = Model;
            this.maxSpeed = maxspeed;
            this.passengerCapacity = passenger;
            this.price = Price;
            this.horsePower = horsePower;
        }


    }
}
