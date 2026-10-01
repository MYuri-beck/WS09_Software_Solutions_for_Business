using System.Diagnostics;

namespace OperacoesString;

class Program
{
    static void Main(String[] args)
    {
        string original = "abcde FGHIJ ABC abc DEFG  ";
        Console.WriteLine(original);
        Separador();

        string s1 = original.ToUpper();
        string s2 = original.ToLower();
        string s3 = original.Trim();

        int n1 = original.IndexOf("bc");
        int n2 = original.LastIndexOf("bc");

        string s4 = original.Substring(3);
        string s5 = original.Substring(3, 5);

        string s6 = original.Replace('a', 'x');
        string s7 = original.Replace("abc", "xy");

        bool b1 = String.IsNullOrEmpty(original);
        bool b2 = String.IsNullOrWhiteSpace(original);

        Console.WriteLine($"Original: -{original}-");
        Separador();
        Console.WriteLine($"ToUpperCase: -{s1}-");
        Separador();
        Console.WriteLine($"ToLowerCase: -{s2}-");
        Separador();
        Console.WriteLine($"Trim: -{s3}-");
        Separador();
        Console.WriteLine($"IndexOf('bc'): -{n1}-");
        Separador();
        Console.WriteLine($"LastIndexOf('bc'): -{n2}-");
        Separador();
        Console.WriteLine($"Substring(3): -{s4}-");
        Separador();
        Console.WriteLine($"Substring(3,5): -{s5}-");
        Separador();
        Console.WriteLine($"Replace('a','x'): -{s6}-");
        Separador();
        Console.WriteLine($"Replace(\"abc\", \" xy\": -{s7}-");
        Separador();
        Console.WriteLine($"IsNullOrEmpty: -{b1}-");
        Separador();
        Console.WriteLine($"IsNullOrWhiteSpace: -{b2}-");
    }

    static void Separador() { Console.WriteLine("--------------------------------------------------------------------------------"); }
}