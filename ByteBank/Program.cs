using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ByteBank - Cadastro de Clientes");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            Cliente Cliente1 = new Cliente(nome, cpf, email);

            bool trocouSenha = false;
            do
            {
                Console.Write("Senha: ");
                string senha = Console.ReadLine();
                trocouSenha = Cliente1.TrocaSenha(senha);
                if (trocouSenha)
                {
                    Console.WriteLine("Senha alterada com sucesso!");
                }
                else
                {
                    Console.WriteLine("404 error");
                }
            } while (!trocouSenha);
            Console.WriteLine();

            Console.WriteLine("ByteBank - Cadastro da Conta");
            Console.WriteLine("Entre com Agencia:");
            int agencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a Conta:");
            int conta = int.Parse(Console.ReadLine());


            ContaCorrente contaCorrente1 = new ContaCorrente(agencia, conta, Cliente1);
            double saldo;
            do
            {
                Console.Write("Entre com o saldo:");
                saldo = double.Parse(Console.ReadLine());
                if (saldo > 0)
                {
                    contaCorrente1.Saldo = saldo;
                }
                else
                {
                    Console.WriteLine("Valor do saldo deve ser positivo.");
                }
            } while (saldo < 0);
            Console.WriteLine();


            Cliente cliente2 = new Cliente("Cesar", "123.123.123-x", "gfd@b.com");
            ContaCorrente contaCorrente2 = new ContaCorrente(123, 312, cliente2);

            Cliente usuario = ContaCorrente.Titular;

            #region Depósito.
            Console.WriteLine("ByteBank - Depósito em conta");
            Console.WriteLine($"Bem Vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia {contaCorrente1.Agencia} Cobta: {contaCorrente1.Numero}");
            Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            Console.WriteLine();
            Console.WriteLine("Digite o valor do Depósito: ");
            double valor = double.Parse(Console.ReadLine());
            contaCorrente1.deposito(valor);
            Console.WriteLine();
            Console.WriteLine($"Novo Saldo: {contaCorrente1.Saldo}");
            Console.WriteLine();
            #endregion

            #region Saque.
            Console.WriteLine("ByteBank - Saque");
            Console.WriteLine($"Bem Vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia {contaCorrente1.Agencia} Cobta: {contaCorrente1.Numero}");
            Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            Console.WriteLine();
            Console.WriteLine("Digite o valor do Saque: ");
            valor = double.Parse(Console.ReadLine());
            contaCorrente1.deposito(valor);
            Console.WriteLine();
            Console.WriteLine($"Novo Saldo: {contaCorrente1.Saldo}");
            Console.WriteLine();
            #endregion

            #region Transferência 
            Console.WriteLine("ByteBank - Transferência");
            Console.WriteLine($"Bem Vindo - {usuario.Nome}");
            Console.WriteLine($"Agencia {contaCorrente1.Agencia} Cobta: {contaCorrente1.Numero}");
            Console.WriteLine($"Saldo: {contaCorrente1.Saldo}");
            Console.WriteLine();
            Console.WriteLine("Digite o valor da Transferência: ");
            valor = double.Parse(Console.ReadLine());
            if (contaCorrente1.Transferencia(contaCorrente2, valor)){
                Console.WriteLine("Transferência efetuada.");
                }
            else
            {
                Console.WriteLine("Não foi possível realizar a operação.");
                }
            Console.WriteLine();
            Console.WriteLine($"Novo Saldo: {contaCorrente1.Saldo}");
            Console.WriteLine("Novo Saldo Destino: {contaCorrente1.Saldo}");
            Console.WriteLine();
            #endregion



        }
    }
}
