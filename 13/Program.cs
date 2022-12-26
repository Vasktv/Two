
Console.WriteLine("Введите любое число.");

int number = Convert.ToInt32(Console.ReadLine());

int firstnumber = number /100;

if (number /100 == 0)
{
System.Console.WriteLine("Ваше число не является техзначным.");
return;
}

while (number > 999)
{
  number /= 10;
}

System.Console.WriteLine(number % 10);
