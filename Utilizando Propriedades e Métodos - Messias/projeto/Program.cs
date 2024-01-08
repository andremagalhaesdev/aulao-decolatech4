using System;

class Robo
{
    public int VelocidadeAtual { get; set; } = 0;
    public int VelocidadeMaxima { get; }
    public int VelocidadeMinima { get; }

    public Robo(int vmin, int vmax)
    {
        VelocidadeMinima = vmin;
        VelocidadeMaxima = vmax;
        VelocidadeAtual = vmin;
    }

    public void Acelerar()
    {
        if (VelocidadeAtual < VelocidadeMaxima)
        {
            VelocidadeAtual++;
        }
    }

    public void Desacelerar()
    {
        if (VelocidadeAtual > VelocidadeMinima)
        {
            VelocidadeAtual--;
        }
    }
}

class Program
{
    static void Main()
    {
        string[] valoresVminVmax = Console.ReadLine().Split(' ');
        int vmin = int.Parse(valoresVminVmax[0]);
        int vmax = int.Parse(valoresVminVmax[1]);

        Robo robo = new Robo(vmin, vmax);

        string comandos = Console.ReadLine();

        foreach (char comando in comandos)
        {
            if(comando == 'A')
            {
                robo.Acelerar();
            }
            if (comando == 'D')
            {
                robo.Desacelerar();
            }
        }

        int velocidadeFinal = robo.VelocidadeAtual;
        Console.WriteLine(velocidadeFinal);
    }
}