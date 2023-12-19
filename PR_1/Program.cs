using System.Threading.Tasks.Sources;

class Prgoram
{
    static int a, b;
    private static void Main()
    {
        Console.Clear();
        Console.WriteLine("Выберите действие:\n" +
        "1. Сложить 2 числа\n" +
        "2. Вычислить первое число из второго\n" +
        "3. Перемножить первое и второе число\n" +
        "4. Разделить первое число на второе\n" +
        "5. Возвести в степень N первое число\n" +
        "6. Найти квадратный корень из числа\n" +
        "7. найти процент числа\n" +
        "8. Найти факториал из числа\n" +
        "9. Выйти из программы");
        a = 0;
        b = 0;
        string result = Console.ReadLine();
        switch (result)
        {
            case "1":
                set();
                Console.WriteLine($"Результат: {a + b}");
                break;
            case "2":
                set();
                Console.WriteLine($"Результат: {b - a}");
                break;
            case "3":
                set();
                Console.WriteLine($"Результат: {a * b}");
                break;
            case "4":
                set();
                if (b != 0)
                {
                    Console.WriteLine($"Результат: {a / b}");
                }
                else
                {
                    Console.WriteLine("Деление на 0 запрещено");
                }
                break;
            case "5":
                set();
                Console.WriteLine($"Результат: {Math.Pow(a,b)}");
                break;
            case "6":
                set(false);
                Console.WriteLine($"Результат: {Math.Sqrt(Convert.ToDouble(a))}");
                break;
            case "7":
                set(false);
                Console.WriteLine($"Результат: {Convert.ToDouble(a)/100}");
                break;
            case "8":
                set(false);
                int tmp = 1;
                for (int i = 1; i <= a; i++)
                {
                    tmp *= i;
                }
                a = tmp;
                Console.WriteLine($"Результат: {a}");
                break;
            case "9":
                Environment.Exit(0);
                break;
        }
        restart();
    }
    static void set(bool param = true)
    {
        try
        {
            Console.WriteLine("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (param)
            {
                Console.WriteLine("Введите второе число: ");
                b = Convert.ToInt32(Console.ReadLine());
            }
        }
        catch
        {
            Console.WriteLine("Произошла ошибка");
            restart();
        }
    }
    static void restart()
    {
        Thread.Sleep(2000);
        Main();
    }
}