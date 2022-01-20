namespace Task_2;

class Program

{
    static void Main(string[] args)
    {
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Choose the program mode or type 'Exit'!");
            Console.WriteLine("1. Command");
            Console.WriteLine("2. Dialog");
            Console.WriteLine("3. Exit");
            UserSelectFromMainMenu();

        }
    }
    
    static void UserSelectFromMainMenu()
    { 
        string choise;

        do
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Type here: ");
            choise = Console.ReadLine().ToLower();
            if (choise != "command" & choise != "dialog" & choise != "exit")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Incorrect input, try again");
                Console.ResetColor();
            }

        } while (choise != "command" & choise != "dialog" & choise != "exit");
        if (choise == "command")
        {
            UserCommandFromMainMenu();
        }
        else if (choise == "dialog")
        {
            UserDialogFromMainMenu();
        }
        else if (choise == "exit")
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Bye.");
            Environment.Exit(0);
        }
    }
        
    static void UserCommandFromMainMenu()
    {
        Console.Write("Type here: ");
        string command = Console.ReadLine().ToLower();
            
        string[] parsed_command = command.Split(new[] { ' ' });
        string value_0 = parsed_command[0];
        int figure = ConvertFigureToInt(value_0);
            
        if (figure == 1)
        {
            string a = parsed_command[1];
            double value_1 = double.Parse(a);
            CircleCalculator(value_1);
        }
        else if (figure == 2)
        {
            string a = parsed_command[1];
            double value_1 = double.Parse(a);
            SquareCalculator(value_1);
        }
        else if (figure == 3)
        {
            string a = parsed_command[1];
            double value_1 = double.Parse(a);
            string b = parsed_command[2];
            double value_2 = double.Parse(b);
            RectangleCalculator(value_1, value_2);
        }
        else if (figure == 4)
        {
            string a = parsed_command[1];
            double value_1 = double.Parse(a);
            string b = parsed_command[2];
            double value_2 = double.Parse(b);
            string c = parsed_command[3];
            double value_3 = double.Parse(c);
            TriangleCalculator(value_1, value_2, value_3);
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Incorrect input");
            Environment.Exit(0);
        }
    }

    static void UserDialogFromMainMenu()
    {
        Console.WriteLine("Available figures: circle, square, rectangle, triangle");
        Console.WriteLine("Step 1: Input figure name");
        Console.WriteLine("Step 2: Input figure parameters in meters");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("*************");
        Console.WriteLine("Example 1:\n circle \n 5");
        Console.WriteLine("*************");
        Console.WriteLine("Example 2:\n triangle \n 5.41 \n 4.7 \n 3");
        Console.WriteLine("*************");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("To exit press q key button, to continue press enter");
        ConsoleKeyInfo user_input = Console.ReadKey();
        while (user_input.Key != ConsoleKey.Q) 
        {
            Console.Write("Type figure: ");
            string figure = Console.ReadLine().ToLower();
            int figure_to_int = ConvertFigureToInt(figure);
            if (figure_to_int == 1)
            {
                Console.Write("Type value 1 (radius): ");
                double radius;
                double.TryParse(Console.ReadLine(), out radius);
                CircleCalculator(radius);
            }
            else if (figure_to_int == 2)
            {
                Console.Write("Type value 1 (square side): ");
                double square_side;
                double.TryParse(Console.ReadLine(), out square_side);
                SquareCalculator(square_side);
            }
            else if (figure_to_int == 3)
            {
                Console.Write("Type value 1 (side): ");
                double r_side_1;
                double.TryParse(Console.ReadLine(), out r_side_1);
                Console.Write("Type value 2 (side): ");
                double r_side_2;
                double.TryParse(Console.ReadLine(), out r_side_2);
                RectangleCalculator(r_side_1, r_side_2);
            }
            else if (figure_to_int == 4)
            {
                Console.Write("Type value 1 (side): ");
                double t_side_1;
                double.TryParse(Console.ReadLine(), out t_side_1);
                Console.Write("Type value 2 (side): ");
                double t_side_2;
                double.TryParse(Console.ReadLine(), out t_side_2);
                Console.Write("Type value 3 (side): ");
                double t_side_3;
                double.TryParse(Console.ReadLine(), out t_side_3);
                TriangleCalculator(t_side_1, t_side_2, t_side_3);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Incorrect parameter");
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("To exit press q key button, to continue press enter");
            user_input = Console.ReadKey();
        }
        Environment.Exit(0);
    }
        
    private static double CircleCalculator(double value1)
    {
        double result = 3.14 * Math.Pow(value1, 2);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(result);
        Console.ResetColor();
        if (result == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It's not a circle");
            Console.ResetColor();
        }
        return result;
    }
        
    private static double SquareCalculator(double value1)
    {
        double result = Math.Pow(value1, 2);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(result);
        Console.ResetColor();
        if (result == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It's not a square");
            Console.ResetColor();
        }
        return result;
    }
        
    private static double RectangleCalculator(double value1, double value2)
    {
        double result = value1 * value2;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(result);
        Console.ResetColor();
        if (result == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It's not a rectangle");
            Console.ResetColor();
        }
        return result;
    }
        
    private static double TriangleCalculator(double value1, double value2, double value3)
    {
        double p = (value1 + value2 + value3) / 2;
        double result = Math.Sqrt(p * (p - value1) * (p - value2) * (p - value3));
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(result);
        Console.ResetColor();
        if (result.Equals(Double.NaN))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("It's not a triangle");
            Console.ResetColor();
        }
        return result;
    }
        
    static int ConvertFigureToInt(string value0)
    {
        int figure = 0;
        switch (value0)
        {
            case "circle":
                figure = 1;
                break;
            case "square":
                figure = 2;
                break;
            case "rectangle":
                figure = 3;
                break;
            case "triangle":
                figure = 4;
                break;
        }
        return figure;
    }
}