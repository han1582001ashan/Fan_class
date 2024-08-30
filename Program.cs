using System;
using System.Dynamic;
using System.Reflection.Metadata;
namespace AnimalClass
{
    class Fan
    {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;
        private int speed = SLOW;
        private bool on = false;
        private double radius = 5;
        private string color = "blue";

        public int getSpeed()
        {
            return this.speed;
        }
        public void setSpeed(int speed)
        {
            this.speed = speed;
        }

        public bool getON()
        {
            return this.on;
        }
        public void setON(bool on)
        {
            this.on = on;
        }
        public double getRadius()
        {
            return this.radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public string getColor()
        {
            return this.color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }

        public Fan()
        {
        }
        public string ToString()
        {
            string status = this.on ? "fan is on" : "fan is off";
            string result = "Speed: " + this.speed + "\nColor: " + this.color + "\nRadius: " + this.radius + "\n" + status;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            fan1.setSpeed(Fan.FAST);
            fan1.setON(true);
            fan1.setRadius(10);
            fan1.setColor("Yellow");
            Fan fan2 = new Fan();
            fan1.setSpeed(Fan.MEDIUM);
            fan1.setON(false);
            fan1.setRadius(5);
            fan1.setColor("Blue");
            Console.WriteLine(fan1.ToString());
            Console.WriteLine(fan2.ToString());
        }
    }
}

