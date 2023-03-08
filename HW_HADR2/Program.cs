// Задача 19 - HARD необязательная

// Напишите программу, которая принимает на вход целое число любой разрядности 
// и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.


Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
    int num1 = num;
    int reverse = 0;
    int temp = 0;

        while (num > 0)
        {
            temp = num % 10;
            reverse = (reverse * 10) + temp;
            num = num / 10;
        }

        if (num1 == reverse)
            Console.WriteLine("Число - палиндром.");
                 else Console.WriteLine("Число - не палиндром.");
        