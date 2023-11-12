string str = "hello";

while (str!= "exit")
{
    Console.WriteLine("Выполняется цикл.\n" +
        "для выхода введите: \"exit\"");
    str = Console.ReadLine()!;
}

Console.WriteLine("Цикл завершился.");
