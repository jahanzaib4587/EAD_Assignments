using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            myNewClass var1 = new myNewClass();
            myNewClass var2 = new myNewClass();
            myNewClass var3 = new myNewClass();
            myNewClass var4 = new myNewClass();
            Console.WriteLine($"Total intialized variables are: {Task_5.myNewClass.count}");
        }
    }
    class myNewClass
    {
        public static int count = 0;
        //Constructor
        public myNewClass()
        {
            count += 1;
        }
    }
}
