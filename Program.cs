using System;

namespace CSharpBasics
{
    class Program
    {
        const byte sample1 = 0x3A;
        static byte sample2 = 58;
        static int heartRate = 85;
        static double deposits = 135002796;
        public static float acceleration = 9.800f;
        public static float mass = 14.6f;
        static double distance = 129.763001;
        static bool lost = true;
        static bool expensive = true;
        static int choice = 2;
        public const char integral = '\u222B';
        const string greeting = "Hello";
        static string name = "Karen";
        static void Main(string[] args)
        {
            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.\n");
            }
            else
            {
                Console.WriteLine("The samples are not equal.\n");
            }

            if(heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.\n");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal.\n");
            }

            if(deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.\n");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.\n");
            }

            float force = mass * acceleration;
            Console.WriteLine("force = {0}\n", force);
            Console.WriteLine("{0} is the distance.\n", distance);

            if(lost == true && expensive == true)
            {
                Console.WriteLine("I am really sorry! I will get the manager.\n");
            }
            if(lost == true && expensive == false)
            {
                Console.WriteLine("Here is coupon for 10% off.\n");
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose 1.\n");
                    break;
                case 2:
                    Console.WriteLine("You chose 2.\n");
                    break;
                case 3:
                    Console.WriteLine("You chose 3.\n");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice\n");
                    break;
            }

            Console.WriteLine("{0} is an integral\n", integral);

            for(int i = 5; i < 11; i++)
            {
                Console.WriteLine("i = {0}", i);
            }

            Console.WriteLine("\n");

            int age = 0;
            while (age < 6)
            {
                Console.WriteLine("age = {0}", age);
                age++;
            }

            Console.WriteLine("\nGreetings {0}\n", name);
        }
    }
}
