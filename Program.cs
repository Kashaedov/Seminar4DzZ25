Console.WriteLine("Введите число A: ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите число B: ");
int number2 = Convert.ToInt32 (Console.ReadLine());
int itog = 1;
void  Zadacha25 (int number1, int number2, int itog )
{
    for ( int i = 0; i < number2; i = i + 1 )
    {
    itog = number1 * itog;

    }


Console.WriteLine($"Число {number1} в степени {number2} = {itog}  ");
}
Zadacha25 (number1, number2, itog );