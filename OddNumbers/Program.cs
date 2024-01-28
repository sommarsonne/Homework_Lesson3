{
    Console.WriteLine("Введите число");
    
    string input = Console.ReadLine();
    int X = Convert.ToInt32(input);

    if (X % 2 == 0)
    {
        Console.WriteLine("Четное число");
    }
    else
    {
        Console.WriteLine("Нечетное число");
    }
;
}

