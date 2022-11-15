namespace Apartat4
{
    class Program
    {
        static void Main()
        {
            string? input_edat;
            string? input_ingressos;
            int edat;
            decimal ingressos;

            while (true)
            {
                Console.WriteLine("Introdueix la teva edat : ");
                input_edat = Console.ReadLine();
                if (input_edat != null)
                {
                    try
                    {
                        edat = int.Parse(input_edat);
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
            if (edat >= 16 && ingressos >= 1000)
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