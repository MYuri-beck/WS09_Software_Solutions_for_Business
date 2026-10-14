namespace Exercicio1;

 class Program {
    static void Main(string[] args) {
        Student[] rent = new Student[10];

        Console.Write("Quantos quartos serão alugados?");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            Console.WriteLine($"Aluguel {i + 1}:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            rent[i] = new Student { Name = name, Email = email };
        }

        Console.WriteLine("\nQuartos alugados:");
        for (int i = 0; i < n; i++) {
            if (rent[i] != null) {
                Console.WriteLine($"Quarto {i + 1}: {rent[i]}");
            }
        }
    }
}