Console.WriteLine("Введите минимальную температуру в C (Цельсиях) за день");
int min = 0;
    min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальную температуру в C (Цельсиях) за день");
int max = 0;
    max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Среднесуточная температура: {(max+min)/2}C");