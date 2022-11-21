// Задача 42: Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int TransformToDecimal(int num)
{
    int result = 0;
    while (num > 0)
    {
        int digit1 = num % 2;
        result += digit1;
        result *= 10;
        num /= 2;
    }
    return result;
}

int ReverseNumber(int hz)
{
    int result = 0;
    while (hz > 9)
    { 
        result += hz % 10;
        result *= 10;
        hz /= 10;
        result += hz % 10;
        
    }
    return result;
}

Console.WriteLine(ReverseNumber(TransformToDecimal(number)));