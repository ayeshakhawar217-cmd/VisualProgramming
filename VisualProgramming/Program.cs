using System;
using VisualProgramming;

class Program
{
   

static void Main(string[] args)
{
    Console.WriteLine("Enter Number");
   int num = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine(i * i * i);
    }

        Class1 obj = new Class1();
        obj.display();
}

}

