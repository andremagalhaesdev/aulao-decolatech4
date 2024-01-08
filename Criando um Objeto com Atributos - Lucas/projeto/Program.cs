using System;

class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }


    public Jogador(string nome, string nacionalidade, int idade, string posicao)
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
        Idade = idade;
        Posicao = posicao;
    }
    public void Apresentar()
    {
        Console.WriteLine($"Jogador criado!\n {Nome}\n {Nacionalidade} \n {Idade} \n Posição: {Posicao}");
    }
}


class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        string nacionalidade = Console.ReadLine();
        int idade = Convert.ToInt32(Console.ReadLine());
        string posicao = Console.ReadLine();  
        Jogador j1 = new Jogador(nome,nacionalidade,idade,posicao);
        j1.Apresentar();
    
    }
}