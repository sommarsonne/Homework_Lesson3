Console.WriteLine("Введите номер цвета");
string number = Console.ReadLine();



switch (number)
{
    case "1":
        Console.WriteLine("Красный");
        break;

    case "2":
        Console.WriteLine("Оранжевый");
        break;

    case "3":
        Console.WriteLine("Желтый");
        break;

    case "4":
        Console.WriteLine("Зеленый");
        break;

    case "5":
        Console.WriteLine("Голубой");
        break;

    case "6":
        Console.WriteLine("Синий");
        break;

    case "7":
        Console.WriteLine("Фиолетовый");
        break;

    default:
        Console.WriteLine("Введите число от 1 до 7");
        break;
}