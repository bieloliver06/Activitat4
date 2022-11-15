namespace Apartat1
{
    class Program
    {
        static void Main()
        {
            string correct_password = "P@ssw0rd";

            string? passowrd_input = Console.ReadLine();

            if (correct_password == passowrd_input)
            {
                Console.WriteLine("La contrasenya es correcta");
            }
        }
    }
}