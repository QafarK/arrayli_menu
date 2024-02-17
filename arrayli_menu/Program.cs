int select = 1;
string[] menu = new string[3]
{
    "Start game",
    "Points",
    "Exit"
};
do
{
    Console.Clear();
    switch (select)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("-->");
            foreach (var item in menu)
            {
                if (item == menu[0])
                {
                    Console.WriteLine(item);
                    Console.ForegroundColor= ConsoleColor.White;
                }
                else
                {
                Console.WriteLine(item);
                }
            }
            break;
        case 2:
;
            foreach (var item in menu)
            {
                if (item == menu[1])
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("-->");
                    Console.WriteLine(item);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                Console.WriteLine(item);
                }
            }
            break;
        case 3:
            ;
            foreach (var item in menu)
            {
                if (item == menu[2])
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("-->");
                    Console.WriteLine(item);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
            break;
        default:
            break;
    }
    ConsoleKeyInfo info = Console.ReadKey(true);
    if (info.Key == ConsoleKey.UpArrow)
    {
        if (select != 1)
        {
            select--;
        }
        else
        {
            select = 3;
        }
    }
    else if (info.Key == ConsoleKey.DownArrow)
    {
        if (select != 3)
        {
            select++;
        }
        else
        {
            select = 1;
        }
    }
} while (true);


