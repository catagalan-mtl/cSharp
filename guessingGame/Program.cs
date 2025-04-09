// See https://aka.ms/new-console-template for more information
using System.Net.Quic;

Random random = new Random();
int answer = random.Next(1, 100);

Console.WriteLine("Hello, welcome to the Guessing Game! (shhhhhhhh): " + answer);
Console.Write("Enter a number from 1 to 100: > ");
byte attempts = 0;
GuessingGame(attempts, answer);

static void GuessingGame(byte attempts, int answer)
{
  var input = Console.ReadLine();
  attempts++;

  if (!Byte.TryParse(input, out byte choice))
  {
    Console.Write("Wrong Input! Please tri again: > ");
    GuessingGame(attempts, answer);
  }

  Byte.TryParse(input, out choice);
  while (choice != answer)
  {
    if (choice > answer)
    {
      Console.Write("too high... ");
    }
    else
    {
      Console.Write("too low... ");
    }
    Console.Write("Sorry, try again! > ");
    GuessingGame(attempts, answer);
  }
  Console.WriteLine("YOU WIN!!!!!!! it only took you " + attempts + " attempts! hahaha");
  Environment.Exit(0);
}
