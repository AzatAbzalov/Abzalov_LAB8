//Задание 1. Пункт А 

//using System.Diagnostics;
//TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, Math.Cos); //a)
//Console.WriteLine();
//TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, functionB); //b)
//Console.WriteLine();
//TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, x => (-1) * Math.Pow((x / Math.PI), 2) - 2 * x + 5 * Math.PI);//c)
//Console.WriteLine();
//TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, x =>
//{
//    double sum = 0;
//    for (int k = 1; k <= 100; k++)
//        sum += Math.Pow((x / Math.PI * k) - 1, 2);
//    return sum;

//});//d

//static double functionB(double x)
//{
//    return 2 * Math.Sqrt(Math.Abs(x - 1)) + 1;
//}

//ArifmFucn Fdel = delegate (double x)
//{
//    if (x < 0) return (1.0 / 4) * Math.Pow(Math.Sin(x), 2) + 1;
//    else return (1.0 / 2) * (Math.Cos(x)) - 1;
//};
//Console.WriteLine();
//TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, Fdel);

//void TabFunc(double a, double b, double s, ArifmFucn del)
//{
//    Console.WriteLine("Значения функции {3} на отрезке [{0},{1}] с шагом {2}", a, b, s, del.Method.Name);
//    for (double x = a; x <= b; x += s)
//        Console.WriteLine("x={0}\t f(x) = {1}", x, del(x));
//}
//delegate double ArifmFucn(double x);

//Задание 1. Пункт Б

//Func<double, double> function = delegate (double x)  
//{
//    if (x < 0) return (1.0 / 4) * Math.Pow(Math.Sin(x), 2) + 1;
//    else return (1.0 / 2) * Math.Cos(x) - 1;
//};
//void TabFunc(double a, double b, double step, Func<double, double> del)
//{
//    Console.WriteLine("значения функции {3} на отрезке [{0}, {1}] с шагом {2}",a, b, step, del.Method.Name);
//    for (double x = a; x <= b; x += s)
//        Console.WriteLine("x={0}\t f(x) = {1}", x, del(x));
//}
//TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, fun);

//Задание 1. Пункт В 

//double functionB(double x) 
//{ 
//    return 2 * Math.Sqrt(Math.Abs(x - 1)) + 1; 
//}
//Func<double, double> funсtion = delegate (double x)   
//{
//    if (x < 0) return (1.0 / 4) * Math.Pow(Math.Sin(x), 2) + 1;
//    else return (1.0 / 2) * Math.Cos(x) - 1;
//};

//Func<double, double>[] array = new Func<double, double>[]{ Math.Cos, functionB, x => (-1) * Math.Pow((x / Math.PI), 2) - 2 * x + 5 * Math.PI, x =>
//{
//    double sum = 0;
//    for (int k = 1; k <= 100; k++)
//        sum += Math.Pow(x / (Math.PI * k) - 1, 2);
//    return sum;
//}, funсtion };

//for (int i = 0; i < array.Length; i++)
//{
//    TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, array[i]);
//    Console.WriteLine();
//}
//void TabFunc(double a, double b, double s, Func<double, double> del)
//{
//    Console.WriteLine("Значения функции {3} на отрезке [{0}, {1}] с шагом {2}",
//        a, b, s, del.Method.Name);
//    for (double x = a; x <= b; x += s)
//        Console.WriteLine("x={0}\t f(x) = {1}", x, del(x));
//}

//Задание 1. Пункт Г 
//double functionB(double x) 
//{ 
//    return 2 * Math.Sqrt(Math.Abs(x - 1)) + 1; 
//}
//Func<double, double> function = delegate (double x)   
//{
//    if (x < 0) return (1.0 / 4) * Math.Pow(Math.Sin(x), 2) + 1;
//    else return (1.0 / 2) * Math.Cos(x) - 1;
//};

//Func<double, double>[] array = new Func<double, double>[]{ Math.Cos, functionB, x => (-1) * Math.Pow((x / Math.PI), 2) - 2 * x + 5 * Math.PI, x =>
//{
//    double sum = 0;
//    for (int k = 1; k <= 100; k++)
//        sum += Math.Pow(x / (Math.PI * k) - 1, 2);
//    return sum;
//}, function };

//Predicate<double> Neg = (double num) => num < 0;
//Predicate<double> LessM1 = (double num) => Math.Abs(num) <= 1;

//int count1 = 0, count2 = 0;
//for (int i = 0; i < array.Length; i++)
//{
//    int c1 = TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, array[i], Neg);
//    Console.WriteLine($"Кол-во отрицательных значений функции = {c1}");
//    Console.WriteLine();
//    count1 += c1;
//}
//Console.WriteLine("Всего отрицательных значений " + count1);
//Console.WriteLine();
//for (int i = 0; i < array.Length; i++)
//{
//    int c2 = TabFunc(-2 * Math.PI, 2 * Math.PI, Math.PI / 6, array[i], LessM1);
//    Console.WriteLine($"Кол-во значений функции из [-1; 1] = {c2}");
//    count2 += c2;
//}
//Console.WriteLine("Всего значений из [-1; 1] " + count2);


//int TabFunc(double a, double b, double s, Func<double, double> del, Predicate<double> check)
//{
//    int count = 0;
//    Console.WriteLine("Значения функции {3} на отрезке [{0}, {1}] с шагом {2}",a, b, s, del.Method.Name);
//    for (double x = a; x <= b; x += s)
//    {
//        Console.WriteLine("x={0}\t f(x) = {1}", x, del(x));
//        if (check(del(x))) 
//            count++;
//    }
//    return count;
//}

//Задание 1. Пункт Д

//int[] array = new int[10];
//Random rnd = new();
//for (int i = 0; i < array.Length; i++) { array[i] = rnd.Next(-10, 11); }
//double min, max;

//double funсtionB(double x) 
//{ 
//    return 2 * Math.Sqrt(Math.Abs(x - 1)) + 1; 
//}
//Func<double, double> function = delegate (double x)   // анонимный метод
//{
//    if (x < 0) return (1.0 / 4) * Math.Pow(Math.Sin(x), 2) + 1;
//    else return (1.0 / 2) * Math.Cos(x) - 1;
//};

//Func<double, double>[] funcs = new Func<double, double>[]{ Math.Cos, funсtionB, x => (-1) * Math.Pow((x / Math.PI), 2) - 2 * x + 5 * Math.PI, x =>
//{
//    double sum = 0;
//    for (int k = 1; k <= 100; k++)
//        sum += Math.Pow(x / (Math.PI * k) - 1, 2);
//    return sum;
//}, function };

//void MaxAndMin(int[] a, Func<double, double> del, out double minimum, out double maximum)
//{
//    minimum = del(a[0]);
//    maximum = del(a[0]);
//    Console.WriteLine("Значения функции {0} на интервале [-1; 1]", del.Method.Name);
//    for (int i = 0; i < a.Length; i++)
//    {
//        Console.WriteLine("x={0}\t f(x) = {1}", a[i], del(a[i]));
//        if (del(a[i]) > maximum) maximum = del(a[i]);
//        if (del(a[i]) < minimum) minimum = del(a[i]);
//    }
//}

//for (int j = 0; j < funcs.Length; j++)
//{
//    MaxAndMin(array, funcs[j], out min, out max);
//    Console.WriteLine();
//    Console.WriteLine("Мин значение функции = " + min);
//    Console.WriteLine("Макс значение функции = " + max );
//    Console.WriteLine();
//}

//Задание 2





string[] strings = { "Hello", "world", "level", "madam", "C# is awesome", "Worldwide", "open-source" };

        int countNoUppercaseLetters = CountStrings(strings, HasNoUppercaseLetters);
        int countPalindromes = CountStrings(strings, IsPalindrome);
        int countTenCharStrings = CountStrings(strings, IsTenSym);
        int countFiveLetterWords = CountStrings(strings, FiveLetterWord);
        string[] wWords = FilterStrings(strings, StartsW);
        string[] hyphenatedWords = FilterStrings(strings, ContainDef);

        Console.WriteLine("Количество строк без заглавных букв: " + countNoUppercaseLetters);
        Console.WriteLine("Количество палиндромов: " + countPalindromes);
        Console.WriteLine("Количество десятисимвольных строк: " + countTenCharStrings);
        Console.WriteLine("Количество пятибуквенных слов: " + countFiveLetterWords);
        Console.WriteLine("Слова, начинающиеся на 'W': " + string.Join(", ", wWords));
        Console.WriteLine("Составные слова, включающие дефис: " + string.Join(", ", hyphenatedWords));
    
    static int CountStrings(string[] strings, StringConditionDelegate condition)
    {
        return strings.Count(str => condition(str));
    }

 
    static string[] FilterStrings(string[] strings, StringConditionDelegate condition)
    {
        return strings.Where(str => condition(str)).ToArray();
    }

    static bool HasNoUppercaseLetters(string str)
    {
        foreach (char c in str)
        {
            if (c >= 'A' && c <= 'Z') return false;
        }
        return true;
    }   

    static bool IsPalindrome(string str)
    {
        return str.SequenceEqual(str.Reverse());
    }

    static bool IsTenSym(string str)
    {
        return str.Length == 10;
    }
    static bool FiveLetterWord(string str)
    {
        string[] words = str.Split(' ');
        foreach (var word in words)
        {
            if (word.Length == 5)
            {
                return true;
            }
        }
        return false;
    }
    static bool StartsW(string str)
    {
        string[] words = str.Split(' ');
        foreach (var word in words)
        {
            if (!string.IsNullOrEmpty(word) && word[0] == 'W')
            {
                return true;
            }
        }
        return false;
    }
    static bool ContainDef(string str)
    {
        string[] words = str.Split(' ');
        foreach (var word in words)
        {
            if (word.Contains('-'))
            {
                return true;
            }
        }
        return false;
    }

    delegate bool StringConditionDelegate(string str);
