namespace Topic_1___Assignment__Basics_of_Printing_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Angelpreet AKA Angel   

            Console.Title = "Topic 1 - Assignment (Basics of Printing)";    

            Console.ForegroundColor = ConsoleColor.Cyan;    
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Good day! My name is Angel!");
            Console.WriteLine(" ");
            Console.WriteLine("There are two reasons why programmers utilize comments. First reason would be to hide certain code from appearing in the output. The second reason would be to create a note for oneself.");
            Console.WriteLine();

            Console.WriteLine("Press ENTER to see my initials in ASCII art!");
            Console.ReadLine(); 

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("  A     ");

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("TTTTT");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write(" A A    ");

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("  T  ");

            /* Is the sky really blue? No, there are blue, violet, and red rays in the sky. 
             * However, our eyes see blue better than red which is why the sky appears blue. 
             * Something like this...don't trust me on it though .
            */

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("AAAAA   ");

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("  T  ");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("A   A   ");  

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("  T  ");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("A   A   ");

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("  T  ");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("A   A   ");

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("  T  ");

        }
    }
}
