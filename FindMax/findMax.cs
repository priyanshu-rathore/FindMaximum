using System;

namespace FindMaximum
{
    class findMax
    {
        public static void printMax(){
            System.Console.WriteLine("Enter the First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
             System.Console.WriteLine("Enter the Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
             System.Console.WriteLine("Enter the Third Number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int max = findMaximum(num1,num2,num3);

            System.Console.WriteLine($"The maximum element is : {max}");

        }
        public static int findMaximum(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            { return num2; }
            else return num3;
        }
    }
}