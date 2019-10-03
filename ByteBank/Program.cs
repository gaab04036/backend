using System;

namespace Byte_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ByteBank - Cdastro de Clientes");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            Cliente Cliente1 = new Cliente(nome,cpf,email);
            
            bool trocouSenha = false;
            do{
                Console.Write("Senha: ");
                string senha = Console.ReadLine();
                trocouSenha = Cliente1.TrocaSenha(senha);
                if (trocouSenha) {
                    Console.WriteLine("Senha alterada com sucesso!");
                } else {
                    Console.WriteLine("Senha Inválida!");
                }
            }while(!trocouSenha);
        }
    }
}
