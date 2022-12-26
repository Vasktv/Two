
Console.WriteLine("Введите день недели от 1 до 7 ");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)

{
    System.Console.WriteLine($"{number} Это число не является  днём недели");
}

if (number == 6 || number == 7)
{
    System.Console.WriteLine($"{number} Это число  является выходным днём недели");
} 

if (number >= 1) 
if ( number <= 5) 
{
    System.Console.WriteLine($"{number} Это число не является выходным днём недели");
}



