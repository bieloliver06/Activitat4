namespace Apartat6
{
    class Program
    {
        static void Main()
        {
            string? input_edat;
            ushort edat;
            while (true)
            {
                Console.WriteLine("Introdueix la teva edat : ");
                input_edat = Console.ReadLine();
                if (input_edat != null)
                {
                    try
                    {
                        edat = ushort.Parse(input_edat);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no és valid.");
                    }
                }
            }
            switch (edat)
            {
                case < 4:
                    Console.WriteLine("El preu de l'entrada és gratis");
                    break;
                case < 18:
                    Console.WriteLine("El preu de l'entrada és 5 euros");
                    break;
                default:
                    Console.WriteLine("El preu de l'entrada és 10 euros");
                    break;
            }
        }
    }
}