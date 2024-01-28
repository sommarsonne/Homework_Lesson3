{
    Console.WriteLine("Введите температуру");

    string Temperature = Console.ReadLine();    
    int T = Convert.ToInt32(Temperature);    // Так и не додумался до чего-то действительно рабочего 

    if (T > -5)
    {
        Console.WriteLine("Тепло");
    }
    else

    if (T <= -5 & T > -20)
    {
        Console.WriteLine("Нормально");
    }
    else

    if (T <= -20)
    {
        Console.WriteLine("Холодно");
    }
}