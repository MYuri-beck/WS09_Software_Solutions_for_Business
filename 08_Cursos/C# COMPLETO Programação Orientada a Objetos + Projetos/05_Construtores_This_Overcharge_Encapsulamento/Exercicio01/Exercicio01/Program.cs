using Exercicio01;
using System;
using System.Globalization;  

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Você deseja criar uma conta com um deposito inicial ? y/n");
            char response = char.Parse(Console.ReadLine());

            Account account1 = null; // declare before the if/else

            if (response == 'y' || response == 'Y') {
                Console.Write("Digite o numero da conta: ");

                string number = Console.ReadLine();
                Console.Write("Digite o nome do titular: ");

                string holder = Console.ReadLine();
                Console.Write("Digite o valor de depósito inicial: ");
                double initialDeposit = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                account1 = new Account(number, holder, initialDeposit); // assign here

                Console.WriteLine("Conta criada com sucesso!");
                Console.WriteLine(account1);
            }
            else {
                Console.WriteLine("Digite o numero da conta: ");
                string number = (Console.ReadLine());

                Console.WriteLine("Digite o nome do titular: ");
                string holder = Console.ReadLine();

                account1 = new Account(number, holder); // assign here

                Console.WriteLine("Conta criada com sucesso!");
                Console.WriteLine(account1);
            }


            Console.WriteLine(account1.ToString());

            Console.WriteLine("Entre um valor para deósito: ");
            double amount = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            account1.Deposit(amount);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account1.ToString());

            Console.Write("Entre um valor para saque: ");
            amount = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            account1.Withdraw(amount);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account1.ToString());
        }
    }
}
