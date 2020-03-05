using System;

namespace w3sTutorial
{
    class Program
    {
        static void Main(String[] args)
        {
            //Console.WriteLine("Hello World");
            string myName = "NamTong";
            const int myNumb = 36;
            const float myNumbFloat = 36.9F;
            const bool myBool = true;
            int x = 1, y = 2, z = 3, xx = 4;
            int yy = -3;

  //          Console.WriteLine(x += 5);
            Console.WriteLine(Math.Max(x, y));
            Console.WriteLine(Math.Min(x, y));
            Console.WriteLine(Math.Sqrt(y));
            Console.WriteLine(Math.Abs(yy));
            Console.WriteLine(Math.Round(myNumbFloat));

            Console.WriteLine("Hello " + $"{myName} {myNumb} {myNumbFloat} {myBool}");
            
            Console.WriteLine(myNumb + myNumbFloat);
            
            Console.WriteLine(x + y + z);

            Console.WriteLine(Convert.ToDouble(myNumb));

            Console.WriteLine(Convert.ToInt32(myNumbFloat));
            
            Console.WriteLine(Convert.ToString(myNumb));

            Console.WriteLine("Hello World");
            String username = Console.ReadLine();
            Console.WriteLine("my name is : " + username);


            Console.WriteLine("Enter your age: " + 3);
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("My age: " + age);


        }
    }
}
