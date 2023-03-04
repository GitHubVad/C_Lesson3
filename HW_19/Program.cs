// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine ("Введите число n "); 
int n = Convert.ToInt32(Console.ReadLine());
int a = Convert.ToInt32(Math.Log10(n))+1;
int n1 = n /10000; 
int n2 = n/1000;
n2 = n2%10;
int n4 = n/10;
n4 = n4%10;
int n5 = n% 10;
if (a!=5)
    Console.Write ("Не пятизначное число");
        else 
            if (n5 == n1 && n4 == n2)
                Console.Write ("Число - палиндром");
                     else Console.Write ("Число - не палиндром");
    



    
    