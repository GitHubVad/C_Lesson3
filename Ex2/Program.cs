
// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти");
int x = Convert.ToInt32(Console.ReadLine());
CheckKoord(x);
// CheckKoord(8, -8);
// int vivod = CheckKoord2(x);
// Console.WriteLine($"Точка находится в диапазоне {vivod}");

void CheckKoord(int x)
{
    if (x == 1)
        Console.WriteLine("Диапазон возможных координат: x>0 ; y>0");
    else if (x == 2)
        Console.WriteLine("Диапазон возможных координат: x>0 ; y<0");
    else if (x == 3)
        Console.WriteLine("Диапазон возможных координат: x<>>0 ; y>0");
    else if (x == 4)
        Console.WriteLine("Диапазон возможных координат: x<>>0 ; y<=>0");
            else Console.WriteLine("Неправильный номер четверти");
}

// int CheckKoord2(int x)
// {
//    if (x>4 && x<1)
//         Console.WriteLine("Неправильный номер четверти");
//     else if (x == 1)
//         Console.WriteLine("Диапазон возможных координат: x>0 ; y>0");
//     else if (x == 2)
//         Console.WriteLine("Диапазон возможных координат: x>0 ; y<0");
//     else if (x == 3)
//         Console.WriteLine("Диапазон возможных координат: x<>>0 ; y>0");
//     else if (x == 4)
//         Console.WriteLine("Диапазон возможных координат: x<>>0 ; y<=>0");
//     return x;
// }


