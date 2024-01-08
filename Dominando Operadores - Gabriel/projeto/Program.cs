using System;

class Program
{
    static void Main()
    {
        string titulo, descricao, dataVencimento;
        titulo = Console.ReadLine();
        descricao = Console.ReadLine();
        dataVencimento = Console.ReadLine();
        if (descricao.Length > 50)
        {
            Console.WriteLine("Descricao ultrapassa limite de caracteres.");
        }
        else
        {
            Console.WriteLine("{0} ate {1}", descricao, dataVencimento);
        }
    }
}
