using DotNetEnv;

namespace Apartat1
{
    class Program
    {
        static void Main()
        {
            DotNetEnv.Env.Load();
            string? correct_password = Environment.GetEnvironmentVariable("PASSWORD");
            Console.WriteLine("Introdueix la contrasenya : ");
            string? passowrd_input = Console.ReadLine();

            if (correct_password == passowrd_input)
            {
                Console.WriteLine("La contrasenya es correcta.");
            }
            else
            {
                Console.WriteLine("La contrasenya es incorrecta.");
            }
        }
    }
}