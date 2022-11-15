namespace Apartat2
{
    class Program
    {
        static void Main()
        {
            string? input_num1;
            string? input_num2;
            int num1;
            int num2;

            while (true)
            {
                Console.WriteLine("Introdueix el primer nombre : ");
                input_num1 = Console.ReadLine();
                if (input_num1 != null)
                {
                    try
                    {
                        num1 = int.Parse(input_num1);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid.");
                    }
                }
            }
            while (true)
            {
                Console.WriteLine("Introdueix el segon nombre : ");
                input_num2 = Console.ReadLine();
                if (input_num2 != null)
                {
                    try
                    {
                        num2 = int.Parse(input_num2);
                        if (num2 != 0) break;
                        else Console.WriteLine("0 no és un nombre valid.");
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid.");
                    }
                }
            }

            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

        }
    }
}