// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine ("Введите число N" ); 
int N = Convert.ToInt32(Console.ReadLine()); 
Digree3 (N); 
 
void Digree3 (int N) 
{ 
for (int i=1;i<=N;i++)  
    Console.Write(i+"=>"+Math.Pow(i,3)+" "); 
}