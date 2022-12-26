
Console.WriteLine("Введите любое трехзначное число.");

int number = Convert.ToInt32(Console.ReadLine());

int firstnumber = number /100;

if (firstnumber == 0)
{
System.Console.WriteLine("Ваше не трехзначное");
}

else
{
  int secondnumber = number % 10;

  System.Console.WriteLine(secondnumber);  
}