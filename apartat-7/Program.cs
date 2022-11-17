namespace Apartat7
{
    class Program
    {
        static void Main()
        {
            string? input_class;
            string? input_ingredient;
            int ingredient;
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
                Console.WriteLine("Ingredients vegetarians: (1) Pebrot i (2) tofu.");
                while (true)
                {
                    Console.WriteLine("Quin ingredient vols? : ");
                    input_ingredient = Console.ReadLine();
                    if (input_ingredient != null)
                    {
                        try
                        {
                            ingredient = int.Parse(input_ingredient);
                            if (ingredient == 1 || ingredient == 2) break;
                            else Console.WriteLine("L'opció que has introduit no és valida");
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("El que has introduit no és valid.");
                        }
                    }
                }
                if (ingredient == 1)
                {
                    Console.WriteLine("La pizza és vegetariana i porta mozzarella, tomàquet i pebrot");
                }
                else
                {
                    Console.WriteLine("La pizza és vegetariana i porta mozzarella, tomàquet i tofu");
                }
            }
            else
            {
                Console.WriteLine("Ingredients no vegetarians: (1) Peperoni, (2) Pernil i (3) Salmó.");
                while (true)
                {
                    Console.WriteLine("Quin ingredient vols? : ");
                    input_ingredient = Console.ReadLine();
                    if (input_ingredient != null)
                    {
                        try
                        {
                            ingredient = int.Parse(input_ingredient);
                            if (ingredient >= 1 && ingredient <= 3) break;
                            else Console.WriteLine("L'opció que has introduit no és valida");
                        }
                        catch (System.FormatException)
                        {
                            Console.WriteLine("El que has introduit no és valid.");
                        }
                    }
                }
                if (ingredient == 1)
                {
                    Console.WriteLine("La pizza no és vegetariana i porta mozzarella, tomàquet i peperoni");
                }
                else if (ingredient == 2)
                {
                    Console.WriteLine("La pizza no és vegetariana i porta mozzarella, tomàquet i pernil");
                }
                else
                {
                    Console.WriteLine("La pizza no és vegetariana i porta mozzarella, tomàquet i salmó");
                }
            }
        }
    }
}