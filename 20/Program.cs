// 20. Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите номер четверти: ");
int N = int.Parse(Console.ReadLine());


if (N == 1) Console.WriteLine("Координаты Х > 0, координаты Y > 0");
else if (N == 2) Console.WriteLine("Координаты Х < 0, координаты Y > 0");
else if (N == 3) Console.WriteLine("Координаты Х < 0, координаты Y < 0");
else if (N == 4) Console.WriteLine("Координаты Х > 0, координаты Y < 0");
else Console.WriteLine("Введите корректный номер четверти");
