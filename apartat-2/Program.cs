namespace Apartat2
{
    class Program
    {
        static void Main()
        {
            string? input_num;
            int num1;
            int num2;

            while (true)
            {
                Console.WriteLine("Introdueix el primer nombre : ");
                input_num = Console.ReadLine();
                if (input_num != null)
                {
                    try
                    {
                        num1 = int.Parse(input_num);
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
                input_num = Console.ReadLine();
                if (input_num != null)
                {
                    try
                    {
                        num2 = int.Parse(input_num);
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