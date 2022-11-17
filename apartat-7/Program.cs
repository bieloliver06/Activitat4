namespace Apartat7
{
    class Program
    {
        static void Main()
        {
            string? input_class;
            bool b_class;
            while (true)
            {
                Console.WriteLine("Vols la pizza vegetariana? (Y/N)");
                input_class = Console.ReadLine();
                if (input_class != null)
                {
                    try
                    {
                        if (input_class.Trim().ToLower()[0] == 'y')
                        {
                            b_class = true;
                            break;
                        }
                        else if (input_class.Trim().ToLower()[0] == 'n')
                        {
                            b_class = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("El que has introduit no és valid...");
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        Console.WriteLine("El que has introduit no és valid...");
                    }
                }
            }
            if (b_class == true)
            {
                Console.WriteLine("Ingredients vegetarians: Pebrot i tofu.");
            }
            else
            {
                Console.WriteLine("Ingredients no vegetarians: Peperoni, Pernil i Salmó.");
            }
        }
    }
}