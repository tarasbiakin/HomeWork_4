//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());


int Sum(int num)
{
    int result = 0;
    if (num > 0){
    while (num > 0){ result = result+num % 10;num=num/10;
    }System.Console.WriteLine("Сумма чисел:"+result);}
    else{
        Console.Write("число меньше '0' ");}
    return result;
}

Sum(number);
