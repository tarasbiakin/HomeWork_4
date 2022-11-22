//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());


int Digits(int num)
{
    int result = 0;
    if (num > 0)
    {
     while (num > 0){ result = result+num % 10;num=num/10;}
    }
    else{Console.Write("число меньше '0' ");}
    return result;
}
Console.WriteLine("Сумма чисел: "+Digits(number));