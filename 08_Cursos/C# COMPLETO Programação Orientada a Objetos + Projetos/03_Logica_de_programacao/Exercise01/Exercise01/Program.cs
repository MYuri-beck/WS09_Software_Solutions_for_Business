namespace Exercise01;
 public class Program {
   static void Main(string[] args) {
        
        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";

        byte idade = 30;
        int codigo = 5290;  
        char genero = 'M';

        double preco1 = 2100.00;
        double preco2 = 650.50;
        double medida = 53.234567;

        Console.WriteLine("Produtos:");
        Console.WriteLine($"{produto1}, cujo preco é $ {preco1} \n {produto2}, cujo preco é $ {preco2} ");
        Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero {genero}");
        Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
        Console.WriteLine($"Arredondamento (três casas decimais): {medida:F3}");
        Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString("F8", System.Globalization.CultureInfo.InvariantCulture));
    }
}