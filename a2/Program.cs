// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки А ");
Console.Write("Введите координаты точки B ");
string[] masStr = Console.ReadLine().Split(' ');
double[] masSdbl = new double[6];
for (int index = 0; index < masStr.Length; index++)      // цикл для заполнения пустого целочисленного массива
    masSdbl[index] = Convert.ToInt32(masStr[index]);
double res = Math.Sqrt(Math.Pow(masSdbl[0] - masSdbl[3], 2) + Math.Pow(masSdbl[1] - masSdbl[4], 2) + Math.Pow(masSdbl[2] - masSdbl[5], 2));
Console.WriteLine($"Расстояние между точками {res}");