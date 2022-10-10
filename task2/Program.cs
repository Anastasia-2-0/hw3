Console.WriteLine("Введите координаты x точки А");
double ax = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты y точки А");
double ay = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты с точки А");
double ac = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты y точки В");
double bx = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты x точки В");
double by = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты с точки В");
double bc = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bc - ac, 2));

Console.WriteLine($"Расстоние между точками равно {Math.Round(result,2)}");