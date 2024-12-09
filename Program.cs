/* 
Challenge 1: Data Types
    Declares variables of different types (int, double, string).
    Initializes them and prints their values.
 */

class Program1
{
    static void Main(string[] args)
    {
        int intNumber = 1;
        double doubleNumber = 2.2;
        string stringExample = "Example";

        Console.WriteLine($"Integer: {intNumber}");
        Console.WriteLine($"Double: {doubleNumber}");
        Console.WriteLine($"String: {stringExample}");
    }
}

/* 
Challenge 2: Collections
    Create a List<int> and add numbers 1 to 10.
    Use a foreach loop to display the values.
 */
class Program2
{
    static void Main()
    {
        List<int> numberList = CreateNumberList();
        PrintList(numberList);
    }

    static List<int> CreateNumberList()
    {
        return new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    }

    static void PrintList(List<int> list)
    {
        foreach (int num in list)
        {
            Console.WriteLine(num);
        }
    }
}



 /* 
 Challenge 3: Loops
    Write a for loop that prints all even numbers from 0 to 20.
    Write a while loop that counts down from 5 to 0.
  */
class Program3
{
    static void Main()
    {
        EvenNumber();
        CountDown();
    }

    static void EvenNumber()
    {
        Console.WriteLine("Even Number to 20: ");
        for (int i = 0; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }
    }

    static void CountDown()
    {
        Console.WriteLine("Count Down: ");
        int count = 5;
        while (count >= 0)
        {
            Console.WriteLine(count);
            count--;
        }
    }
}


  /* 
  Challenge 4: Conditional Statements
    Write a program that asks for the user's age and prints:
    "Child" if age < 12.
    "Teenager" if age >= 12 and < 18.
    "Adult" if age >= 18.
   */


class Program4
{
    static void Main()
    {
        Console.Write("Please enter your age: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            TestAge(age);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static void TestAge(int age)
    {
        if (age < 12 && age >= 0)
        {
            Console.WriteLine("Child");
        }
        else if (age >= 12 && age < 18)
        {
            Console.WriteLine("Teenager");
        }
        else if (age >= 18)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Please enter a valid age");
        }
    }

}
