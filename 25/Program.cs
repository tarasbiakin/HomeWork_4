// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
try{
Console.WriteLine("Введите число N");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число степени");
int y = Convert.ToInt32(Console.ReadLine());

void Kub(int x1,int y1)
{  
    if(y<0){
   Console.WriteLine("не то число");
    }else{
        int res =x1;
    for (int i = 1; i < y1; i++)
    {
        res =res*x1;
          }
    Console.WriteLine($"результат {(res)}");}
    
}

Kub(x,y);

}catch(FormatException){
    Console.WriteLine($"Не тот формат данных");
    
}
