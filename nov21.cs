// Even or Odd

// Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.

using System;

namespace Solution
{
  public class SolutionClass
  {
    public static string EvenOrOdd(int number)
    {
      if (number % 2 == 0)
      {
        return "Even";
      }
      else 
      {
        return "Odd";
      }
      
    }
  }
}





// A + B

// Vasya Pupkin just started learning Java and C#. At first, he decided to write simple program that was supposed to sum up two small numbers (numbers and their sum fit in a byte), but it didn't work. Vasya was too sad to find out what is wrong. Help him to correct the mistake.

public class FirstClass 
{
    public static int sum (int a, int b) 
    {
        int c = (a + b);
        return c;
    }
}