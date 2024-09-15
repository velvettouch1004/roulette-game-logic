public class Program
{
    public static void Main()
    {
        int chips = 10;
        int[] antwoorden = new int[0];
        Random rand = new Random();

        while (chips > 0)
        {
            Array.Clear(antwoorden, 0, antwoorden.Length);
            int antwoord = 0;
            bool inzetten = true;
            Console.WriteLine("Je hebt " + chips + " chips.");

            while (inzetten)
            {
                int number = rand.Next(1, 6);

                if (chips == 0)
                {
                    Console.WriteLine("Je hebt geen chips meer.");
                    inzetten = false;
                    Console.WriteLine("Rien ne va plus.");
                    Console.WriteLine("De uitkomst was " + number);
                    Console.WriteLine("Je hebt " + chips + " chips.");
                    if (antwoorden.Contains(number))
                    {
                        chips = chips + 35;
                        break;
                    }
                }
                else if (chips == 10)
                {
                    Console.WriteLine("Op welke nummers wil je inzetten?");
                    antwoord = int.Parse(Console.ReadLine());
                    chips = chips - 1;
                    antwoorden = antwoorden.Append(antwoord).ToArray();
                }
                else
                {
                    string input = Console.ReadLine();

                    if (input == "stop")
                    {
                        inzetten = false;
                        Console.WriteLine("Rien ne va plus.");
                        Console.WriteLine("De uitkomst was " + number);
                        Console.WriteLine("Je hebt " + chips + " chips.");

                        if (antwoorden.Contains(number))
                        {
                            chips = chips + 35;
                            break;
                        }
                    }
                    else
                    {
                        antwoord = int.Parse(input);
                        chips = chips - 1;
                        antwoorden = antwoorden.Append(antwoord).ToArray();
                    }
                }
            }

            if (chips <= 0)
            {
                Console.WriteLine("Game Over!");
            }
        }
    }
}
