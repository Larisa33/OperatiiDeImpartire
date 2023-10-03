namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deimpartit = ValidNumber("Introdu deimpartitul: ");
            int impartitor = ValidNumber("Introdu impartitorul: ");

            while (impartitor == 0)
            {
                Console.WriteLine("Impartire la zero! Introdu alt numar.");
                impartitor = ValidNumber("Introdu impartitorul: ");
            }

            Impartire(deimpartit, impartitor);

            static void Impartire(int deimpartit, int impartitor)
            {
                int rezultat = deimpartit / impartitor;
                int rest  = deimpartit % impartitor;

                if (rest == 0)
                {
                    Console.WriteLine("Rezultatul impartirii: '" + deimpartit + "/" + impartitor + "' este: " + rezultat);
                } else
                {
                    Console.WriteLine("Impartirea poate sa fie efectuata doar cu rest!");
                    Console.WriteLine("Rezultatul impartirii: '" + deimpartit + "/" + impartitor + "' este: " + rezultat + " rest " + rest);
                }
              
            }

            static int ValidNumber(string eticheta)
            {
                bool validNumber = false;

                while (!validNumber)
                {
                    Console.Write(eticheta);
                    string text = Console.ReadLine();

                    validNumber = int.TryParse(text, out int result);

                  
                    if (validNumber)
                    {
                        return result;
                    }
                    else 
                    {
                        Console.WriteLine("Sorry, the text does not represent a valid age. Please try again!");
                    }

                }

                return 0;

            }
        }
    }
}