// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("Введите координату первой точки х" ); 
int x1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Введите координату первой точки y" ); 
int y1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Введите координату первой точки z" ); 
int z1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Введите координату второй точки x" ); 
int x2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Введите координату второй точки y" ); 
int y2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine ("Введите координату первой точки z" ); 
int z2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(Length(x1, x2, y1, y2, z1, z2)); 
 
 
double Length (int x1, int x2, int y1, int y2, int z1, int z2) 
{ 
    return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2)); 
} 