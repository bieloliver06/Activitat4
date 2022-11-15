namespace Apartat3
{
    class Program
    {
        static void Main()
        {
            string? input;
            int num;

            while (true)
            {
                Console.WriteLine("Introdueix el nombre que desitges saber si es parell o imparell : ");
                input = Console.ReadLine();
                if (input != null)
                {
                    try
                    {
                        num = int.Parse(input);
                        if (num % 2 == 0)
                        {
                            Console.WriteLine($"{num} és parell");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{num} és imparell");
                            break;
                        }
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid");
                    }
                }
            }
        }
    }
}