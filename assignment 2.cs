/*question 1*/
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        Console.WriteLine("You entered: " + input);
    }
}

/*question 2*/

using System;

class Program
{
    static void Main()
    {
        string input = "123abc";
        try
        {
            int number = Convert.ToInt32(input);
            Console.WriteLine("Converted number: " + number);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}



/*question 3*/

using System;

class Program
{
    static void Main()
    {
        float num1 = 10.5f, num2 = 2.3f;
        float result = num1 / num2;
        Console.WriteLine($"Result: {result}");
    }
}


/*question 4*/

using System;

class Program
{
    static void Main()
    {
        string input = "Hello, World!";
        string substring = input.Substring(7, 5);
        Console.WriteLine("Extracted substring: " + substring);
    }
}



/*question 5*/

using System;

class Program
{
    static void Main()
    {
        int a = 10;
        int b = a;
        b = 20;
        Console.WriteLine($"a: {a}, b: {b}");
    }
}




/*question 6*/


using System;

class Program
{
    class MyClass
    {
        public int Value;
    }

    static void Main()
    {
        MyClass obj1 = new MyClass { Value = 10 };
        MyClass obj2 = obj1;
        obj2.Value = 20;
        Console.WriteLine($"obj1.Value: {obj1.Value}, obj2.Value: {obj2.Value}");
    }
}



/*question 7*/

using System;

class Program
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "World";
        string result = str1 + " " + str2;
        Console.WriteLine(result);
    }
}



/*question 8*/

int d; 
d = Convert.ToInt32(!(30 < 20));

A value 1 will be assigned to d.
 because !(30 < 20) true which is converted to 1 by Convert.ToInt32


/*question 9*/

answer is 6 1
3 / 2 performs integer divisionwhich give us 6.
13 % 2 gives the remainder, which is 1.
The concatenated result is 6 1.



/*question 10*/


int num = 1, z = 5;

if (!(num <= 0))
    Console.WriteLine(++num + z++ + " " + ++z);
else
    Console.WriteLine(--num + z-- + " " + --z);


answer is 7 7
!(num <= 0) evaluates to true because num is 1.
Inside the if block:
++num increments num to 2.
z++ uses 5 then increments z to 6.
++z increments z to 7.
Total: 2 + 5 = 7 and z becomes 7.