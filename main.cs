using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a number:");
    int x= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter another number:");
    int y = Convert.ToInt32(Console.ReadLine());
    int sum = x + y;
    int diff = x - y; 
    int product = x*y;
    int quotient = x/y;
    int remainder = x%y;

    
    
    Console.WriteLine("Sum ="+ " " + sum);
    Console.WriteLine("Diff ="+" "+ diff);
    Console.WriteLine("Product = "+ " "+product);
    Console.WriteLine("Quotient =" +" "+ quotient);
    Console.WriteLine("Remainder = " + " "+ remainder);

  }
}