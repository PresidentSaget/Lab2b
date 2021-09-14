using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Input Number 1: ");
      double num1 = Double.Parse(Console.ReadLine());

    Console.WriteLine("Input Number 2: ");
      double num2 = Double.Parse(Console.ReadLine());

    double sum = num1 + num2;
      Console.WriteLine("The sum is: " + sum);

    double diff = num2 - num1;
      Console.WriteLine("The difference is: " + diff);

    double product = num1 * num2;
      Console.WriteLine("The product is: " + product);

    double quotient = num1 / num2;
      Console.WriteLine("The quotient is: " + quotient);

    double remainder = num1 % num2;
      Console.WriteLine("The remainder is: " + remainder); 
    //time taken to finish: 20-25 mins
  }
}