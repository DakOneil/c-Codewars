// It's pretty straightforward. Your goal is to create a function that removes the first and last characters of a string. You're given one parameter, the original string. You don't have to worry with strings with less than two characters.

using System;

public class Kata
{
    public static string Remove_char(string s)
    {
        // Your Code
    }
}




// Summation
// Write a program that finds the summation of every number from 1 to num. The number will always be a positive integer greater than 0.

// For example:

// summation(2) -> 3
// 1 + 2

// summation(8) -> 36
// 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8

// using System;

public static class Kata 
{
    public static int summation(int num)
    {
      int sum = 0;
      for (int i = 0 ; i <= num ; i++) {
        sum += i;
      }
      return sum;
    }
}





// Description:
// Make a simple function called greet that returns the most-famous "hello world!".

// Style Points
// Sure, this is about as easy as it gets. But how clever can you be to create the most creative hello world you can think of? What is a "hello world" solution you would want to show your friends?

public static class Kata
{
  public static string greet() {
    string hello = "hello world!";
    return hello;
  }
  // Write a public static method "greet" that returns "hello world!"
}