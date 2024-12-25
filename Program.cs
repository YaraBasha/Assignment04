using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        //1
        static void PassByValue(int X)
        {
            X += 10;
        }
        static void PassByReference(ref int X)
        {
            X += 10;
        }
        static void Main()
        {
            int number = 5;

            PassByValue(number);
            Console.WriteLine("After PassByValue:" + number);

            PassByReference(ref number);
            Console.WriteLine("After PassByReference:" + number);
        }
        
            
        }
    }
//2

// PassByValue : the changes of the data affect the original object
//PassByReference : can modify both reference and object data 

class MyClass
{
    public int value;
}
class Program2
{
    static void PassByValue(MyClass obj)
    {
        obj.value = 10;
    }
    static void PassByReference(ref MyClass obj)
    {
        obj = new MyClass { value = 20 };
    }
    static void Main()
    {
        MyClass obj = new MyClass { value = 5 };

        PassByValue(obj);
        Console.WriteLine("After PassByValue: " + obj.value);

        PassByReference(ref obj);
        Console.WriteLine("After PassByReference:" + obj.value);
    }
}

//3

class Program3
{
    static (int sum, int diff) Calculate(int a, int b, int c ,int d)
    {
        int sum = a + b + c + d;
        int diff = a- b - c - d;
        return (sum, diff);
    }
    static void Main()
    {
        Console.WriteLine("Enter the four number:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        var result = Calculate(a, b, c, d);
        Console.WriteLine("Sum=" + result.sum + "Difference:" + result.diff);

    }
}

//4

class Program4
{
    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
    static void Main() {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of digits of" + number + "is = " + SumOfDigits(number));
    }
}

//5

class Program5
{
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("is" + number + "prime?" + IsPrime(number));
    }
}

//6

class Program6
{
    static void MinMaxArray(int[] arr, out int min, out int max)
    {
        min = arr[0];
        max = arr[0];
        foreach (int num in arr)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }
    }
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        MinMaxArray(arr, out int min, out int max);
        Console.WriteLine("Min = " + min + "Max = " + max);
    }
}

//7

class Program7
{
        static int Factorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial of {number} is: {Factorial(number)}");
        }
    }

//8 ***




