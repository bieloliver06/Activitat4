namespace Apartat5
{
    class Program
    {
        static void Main()
        {
            string? input_renda;
            decimal renda;

            while (true)
            {
                Console.WriteLine("Introdueix la teva renda : ");
                input_renda = Console.ReadLine();
                if (input_renda != null)
                {
                    try
                    {
                        renda = Math.Abs(decimal.Parse(input_renda));
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid");
                    }
                }
            }
            switch (renda)
            {
                case < 10000:
                    Console.WriteLine("Tipus impositiu 5%");
                    break;
                case < 20000:
                    Console.WriteLine("Tipus impositiu 15%");
                    break;
                case < 35000:
                    Console.WriteLine("Tipus impositiu 20%");
                    break;
                case < 60000:
                    Console.WriteLine("Tipus impositiu 30%");
                    break;
                default:
                    Console.WriteLine("Tipus impositiu 45%");
                    break;
            }
        }
    }
}