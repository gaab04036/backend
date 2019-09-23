using System;

namespace Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string admLogin  = "admin";
            string admPassws = "admin";


            Console.Write("Dígite seu Email:");
            string login = Console.ReadLine();
            Console.WriteLine("Senha:");
            string passwd = Console.ReadLine();

            if ((login == admLogin) && passwd == admPassws){
                Console.WriteLine("Bem vindo admin.");
            } else {
                Console.WriteLine("Olá Usuário.");
            }
        }
    }
}
