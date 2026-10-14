namespace EnumExercicio01;
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número do mês (1 a 12):");
        int mes = int.Parse(Console.ReadLine());
        if (mes < 1 || mes > 12)
        {
            Console.WriteLine("Mês inválido.");
            return;
        }
        string nomeMes = Enum.GetName(typeof(Meses), mes);
        Console.WriteLine($"O mês correspondente é: {nomeMes}");
    }
}