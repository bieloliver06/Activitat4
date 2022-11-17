namespace Apartat4
{
    class Program
    {
        static void Main()
        {
            string? input_age;
            string? input_ingressos;
            int age;
            decimal ingressos;

            while (true)
            {
                Console.WriteLine("Introdueix la teva edat : ");
                input_age = Console.ReadLine();
                if (input_age != null)
                {
                    try
                    {
                        age = int.Parse(input_age);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid");
                    }
                }
            }
            while (true)
            {
                Console.WriteLine("Introdueix els teus ingressos mensuals : ");
                input_ingressos = Console.ReadLine();
                if (input_ingressos != null)
                {
                    try
                    {
                        ingressos = decimal.Parse(input_ingressos);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid");
                    }
                }
            }
            if (age >= 16 && ingressos >= 1000)
            {
                Console.WriteLine("Has de tributar");
            }
            else
            {
                Console.WriteLine("No has de tributar");
            }
        }
    }
}