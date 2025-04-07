// See https://aka.ms/new-console-template for more information
Random random = new Random();
int answer = random.Next(1, 100);

Console.WriteLine("Hello, welcome to the Guessing Game! (shhhhhhhh): " + answer);
Console.Write("Enter a number from 1 to 100: > ");
byte choice;

while ((!Byte.TryParse(Console.ReadLine(), out choice)) || (choice > 100))
{
  Console.Write("Wrong Input! Please tri again: > ");
}

while (choice != answer)
{

}
Console.WriteLine("YOU WIN!!!!!!! hahaha");
